    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using GreenLifeOrganicStore.DAL;

    namespace GreenLifeOrganicStore.Forms.Customer.Pages
    {
        public partial class UcMyOrders : UserControl
        {
            private readonly int customerId;


            // Create DAL objects
            private readonly OrderDAL orderDAL = new OrderDAL();
     

            public UcMyOrders(int loggedInCustomerId)
            {
                InitializeComponent();
                customerId = loggedInCustomerId;

                LoadOrders();

             
                
            }

            // Load orders for the logged-in customer
            private void LoadOrders()
            {
                DataTable orders = orderDAL.GetCustomerOrders(customerId);
                dgvOrders.DataSource = orders;
            }

            // Run when customer double-clicks an order row
            private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                // Ignore header row
                if (e.RowIndex < 0)
                    return;

                // Stop if Order_id is missing
                if (dgvOrders.Rows[e.RowIndex].Cells["Order_id"].Value == null)
                    return;

                // Read selected order id
                int selectedOrderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["Order_id"].Value);

                // Open order details page
                OpenOrderDetails(selectedOrderId);
            }

            // Open selected order details page
            private void OpenOrderDetails(int selectedOrderId)
            {
                // Get parent form safely
                FrmCustomerMain main = this.FindForm() as FrmCustomerMain;

                // Stop if form is not found
                if (main == null)
                {
                    MessageBox.Show("Customer main form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Open order details page
                main.LoadCustomerPage(new UcOrderDetails(selectedOrderId, customerId));
            }

            private void cmbAllOrders_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Status filter logic can be added later
            }
        }
    }

      
  

