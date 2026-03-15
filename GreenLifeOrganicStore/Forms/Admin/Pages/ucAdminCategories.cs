using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenLifeOrganicStore.DAL;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminCategories : UserControl
    {
        private readonly CategoryDAL categorytDAL = new CategoryDAL();
        private int selectedCategoryId = 0;
        private readonly DbHelper dbHelper = new DbHelper();
        public UcAdminCategories()
        {
            InitializeComponent();
            LoadCategories();
        }

        //Load Categories from database and display in Gridview
        private void LoadCategories()
        {
            try
            {
                dgvCatagories.DataSource = categorytDAL.GetAllCategories();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Loading categories : " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Clear textbox and reset selected Category 
        private void ClearFields()
        {
            txtCategoryName.Clear();
            selectedCategoryId = 0;
            txtCategoryName.Focus();
        }



        private void splitCategories_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Category Name from Text box
                string categoryName = txtCategoryName.Text.Trim();

                //Validate Empty Input 
                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("Please Enter Category Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Insert Category from Database 
                categorytDAL.InsertCategory(categoryName);
                MessageBox.Show("Category added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCategories();
                ClearFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {    //Get Category
                string categoryName = txtCategoryName.Text.Trim();

                //Check if a category   row is selected 
                if (selectedCategoryId == 0)
                {
                    MessageBox.Show("Please select a category to Update", "selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("Please Enter category Name ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Update Category in database 
                categorytDAL.UpdateCategory(selectedCategoryId, categoryName);

                MessageBox.Show("Category Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCategories();
                ClearFields();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Updating Category: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {   //Check if Category Seleted 
                if (selectedCategoryId == 0)
                {
                    MessageBox.Show("Please Select a category to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                //Ask Confirmation before Deleting 
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    categorytDAL.DeleteCategory(selectedCategoryId);

                    MessageBox.Show("Category Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCategories();
                    ClearFields();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Deleting Category: "+ ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvCatagories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ensure valid database clicked 
            if (e.RowIndex >= 0) 
            { 
             DataGridViewRow row = dgvCatagories.Rows[e.RowIndex];

                //Store slected category ID 
                selectedCategoryId = Convert.ToInt32(row.Cells["Category_id"].Value);

                //Display Category Name in textbox
                txtCategoryName.Text = row.Cells["Category_Name"].Value.ToString();

            }
        }

    

        private void txtSearchbox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                string keyword = txtSearchbox.Text.Trim();
                dgvCatagories.DataSource = categorytDAL.SearchCategories(keyword);
            }
            catch (Exception ex) {

                MessageBox.Show("Error Searching categories : " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelCategoryList_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void txtSearchbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearchbox.Text == "   Search Categories")
            {
                txtSearchbox.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvCatagories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
