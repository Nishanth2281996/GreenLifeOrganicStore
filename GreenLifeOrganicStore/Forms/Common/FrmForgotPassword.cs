using GreenLifeOrganicStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GreenLifeOrganicStore
{
    public partial class FrmForgotPassword : Form
    {
        //Create auth service Object to Handle password reset logic
        private readonly AuthService authService = new AuthService();
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            //Get User input to table 
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            //Check if field Empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check Password and Confirm Password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Call Auth service to reset Password
            bool success = authService.ResetPassword(email, password);

            if (success)
            {
                MessageBox.Show("Password Reset Sccessfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Open Login Form 
                FrmLogin loginFrm = new FrmLogin();
                loginFrm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Email Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLogin loginFrm = new FrmLogin();
            loginFrm.Show();
            this.Hide();
        }
    }
}
