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
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;
using GreenLifeOrganicStore.Forms.Admin;
using GreenLifeOrganicStore.Forms.Customer;

namespace GreenLifeOrganicStore
{
    public partial class FrmLogin : Form
    {
        //Create Auth service object to handle Login logic
        private readonly AuthService authService = new AuthService();
        public FrmLogin()
        {
            InitializeComponent();
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get email and password from textboxes
            string email = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Check if email and password empty 
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ){ 
            MessageBox.Show("Please enter both email and password","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Call Auth Service to verify Login 
            User loggedInUser = authService.Login(email, password);

            //If login Fails
            if (loggedInUser == null) {
                MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Login Successfull
            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //If Admin Role
            if(loggedInUser.Role_id == 1)
            {
                FrmAdminMain adminForm = new FrmAdminMain();
                adminForm.Show();
                this.Hide();
            }

            //if Customer Role 
            else if(loggedInUser.Role_id == 2)
            {
                FrmCustomerMain customerForm = new FrmCustomerMain(loggedInUser.Users_id);
                customerForm.Show();
                this.Hide();
            }

            //unkown Role 

            else
            {
                MessageBox.Show("Unknown User role", "Login Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
        private void FrmLogin_Shown(object sender, EventArgs e)
        {
         
        }

        private void CenterCard()
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CreateDefaultAdminOnce();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //Show Forgot Password Page
            FrmForgotPassword forgotPasswordFrm = new FrmForgotPassword();
            forgotPasswordFrm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            //Show Regiter page 
            FrmRegister frm = new FrmRegister();
            frm.Show();
            this.Hide();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        //Create the default admin 
        private void CreateDefaultAdminOnce()
        {
            bool created = authService.CreateDefaultAdmin(
                "System Admin",
                "admin@greenlife.com",
                "0712345678",
                "GreenLife Head Office",
                "Batticaloa",
                "Admin@123"
            );

            if (created)
            {
                MessageBox.Show(
                    "Default Admin account created successfully.\n\nEmail: admin@greenlife.com\nPassword: Admin@123",
                    "Admin Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


    }
}


