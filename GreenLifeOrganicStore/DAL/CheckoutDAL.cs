using GreenLifeOrganicStore.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganicStore.DAL
{
    public class CheckoutDAL
    {
        // Database helper object
        private readonly DbHelper dbHelper = new DbHelper();

        // Process full checkout in one SQL transaction
        public bool ProcessCheckout(int customerId, string shippingAddress, int paymentMethodId, out string message)
        {
            message = "";

            using (SqlConnection conn = dbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Load customer details from Users table
                    string userQuery = @"SELECT Full_Name, U_City, U_Phone
                                         FROM Users
                                         WHERE Users_id = @Users_id";

                    string fullName = "";
                    string city = "";
                    string phone = "";

                    using (SqlCommand cmd = new SqlCommand(userQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Users_id", customerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullName = reader["Full_Name"].ToString();
                                city = reader["U_City"].ToString();
                                phone = reader["U_Phone"].ToString();
                            }
                            else
                            {
                                message = "Customer record not found.";
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }

                    // 2. Load cart items with current stock
                    string cartQuery = @"SELECT 
                                            c.Cart_id,
                                            c.Product_id,
                                            c.Quantity,
                                            c.Unit_Price,
                                            p.Stock_Qty
                                         FROM Cart c
                                         INNER JOIN Products p ON c.Product_id = p.Product_id
                                         WHERE c.Users_id = @Users_id";

                    DataTable cartTable = new DataTable();

                    using (SqlCommand cmd = new SqlCommand(cartQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Users_id", customerId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.SelectCommand.Transaction = transaction;
                            adapter.Fill(cartTable);
                        }
                    }

                    if (cartTable.Rows.Count == 0)
                    {
                        message = "Your cart is empty.";
                        transaction.Rollback();
                        return false;
                    }

                    // 3. Validate stock and calculate totals
                    decimal subtotal = 0;
                    int totalQuantity = 0;
                    decimal shippingFee = 300;
                    decimal discountAmount = 0;

                    foreach (DataRow row in cartTable.Rows)
                    {
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        int stockQty = Convert.ToInt32(row["Stock_Qty"]);
                        decimal unitPrice = Convert.ToDecimal(row["Unit_Price"]);

                        if (quantity > stockQty)
                        {
                            message = "One or more products do not have enough stock.";
                            transaction.Rollback();
                            return false;
                        }

                        subtotal += unitPrice * quantity;
                        totalQuantity += quantity;
                    }

                    decimal grandTotal = subtotal + shippingFee - discountAmount;

                    // 4. Get default order status id (Pending)
                    int orderStatusId = GetOrderStatusId(conn, transaction, "Pending");

                    if (orderStatusId == 0)
                    {
                        message = "Order status 'Pending' was not found.";
                        transaction.Rollback();
                        return false;
                    }

                    // 5. Insert order
                    string insertOrderQuery = @"INSERT INTO Orders
                                                (Customer_id, Order_Status_id, Order_Date, C_FullName, C_Address, C_City, C_Phone, SubTotal, GrandTotal, Quantity)
                                                VALUES
                                                (@Customer_id, @Order_Status_id, GETDATE(), @C_FullName, @C_Address, @C_City, @C_Phone, @SubTotal, @GrandTotal, @Quantity);
                                                SELECT SCOPE_IDENTITY();";

                    int orderId;

                    using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Customer_id", customerId);
                        cmd.Parameters.AddWithValue("@Order_Status_id", orderStatusId);
                        cmd.Parameters.AddWithValue("@C_FullName", fullName);
                        cmd.Parameters.AddWithValue("@C_Address", shippingAddress);
                        cmd.Parameters.AddWithValue("@C_City", city);
                        cmd.Parameters.AddWithValue("@C_Phone", phone);
                        cmd.Parameters.AddWithValue("@SubTotal", subtotal);
                        cmd.Parameters.AddWithValue("@GrandTotal", grandTotal);
                        cmd.Parameters.AddWithValue("@Quantity", totalQuantity);

                        orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 6. Get default payment status id (Pending)
                    int paymentStatusId = GetPaymentStatusId(conn, transaction, "Pending");

                    if (paymentStatusId == 0)
                    {
                        message = "Payment status 'Pending' was not found.";
                        transaction.Rollback();
                        return false;
                    }

                    // 7. Insert payment
                    string insertPaymentQuery = @"INSERT INTO Payment
                                                  (Payment_Amount, Payment_Date, CreatedAt, Order_id, Payment_Status_id, Payment_Method_id)
                                                  VALUES
                                                  (@Payment_Amount, GETDATE(), GETDATE(), @Order_id, @Payment_Status_id, @Payment_Method_id)";

                    using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Payment_Amount", grandTotal);
                        cmd.Parameters.AddWithValue("@Order_id", orderId);
                        cmd.Parameters.AddWithValue("@Payment_Status_id", paymentStatusId);
                        cmd.Parameters.AddWithValue("@Payment_Method_id", paymentMethodId);

                        cmd.ExecuteNonQuery();
                    }

                    // 8. Reduce product stock
                    foreach (DataRow row in cartTable.Rows)
                    {
                        int productId = Convert.ToInt32(row["Product_id"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);

                        string updateStockQuery = @"UPDATE Products
                                                    SET Stock_Qty = Stock_Qty - @Quantity
                                                    WHERE Product_id = @Product_id";

                        using (SqlCommand cmd = new SqlCommand(updateStockQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Product_id", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 9. Clear cart after successful checkout
                    string clearCartQuery = @"DELETE FROM Cart
                                              WHERE Users_id = @Users_id";

                    using (SqlCommand cmd = new SqlCommand(clearCartQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Users_id", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    message = "Checkout completed successfully.";
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    message = "Checkout failed: " + ex.Message;
                    return false;
                }
            }
        }

        // Get order status id by status name
        private int GetOrderStatusId(SqlConnection conn, SqlTransaction transaction, string statusName)
        {
            string query = @"SELECT Order_Status_id
                             FROM OrderStatus
                             WHERE Status_Name = @Status_Name";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Status_Name", statusName);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }

        // Get payment status id by status name
        private int GetPaymentStatusId(SqlConnection conn, SqlTransaction transaction, string statusName)
        {
            string query = @"SELECT Payment_Status_id
                             FROM PaymentStatus
                             WHERE Payment_Status_Name = @Payment_Status_Name";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Payment_Status_Name", statusName);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }
    }
}
