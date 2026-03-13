using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore
{
    
    public partial class FrmRegister : Form
    {

        //Create AuthService object to handle registration logic
        private readonly AuthService authService = new AuthService();
        public FrmRegister()
        {

            InitializeComponent();
        
        }
  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Show login Form 
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //Show login Form 
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        //Validate the Email Adderss Correct 
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

            //Get User inputs from Textboxes
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            //Validate the email address
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //Check if any field Empty
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword)
                )
            {
                MessageBox.Show("Please Fill in all Fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check if password and confirm password match
            if(password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             

            //Check if  email is already registered in database 
            if (authService.EmailExists(email)) 
            {
                MessageBox.Show("This email is already registered", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create a User object and assign entered values
            User newUser = new User
            {
                Full_Name = fullName,
                U_Email = email,
                U_Phone = phone,
                U_Address = address,
                U_City = city,
                ProfileImagePath = null

            };

            //Call Auth service to register Customer
            bool isRegistered = authService.RegisterCustomer(newUser, password);

            if (isRegistered) {
                MessageBox.Show("Registration Successful. You can now log in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Open Login Form
              FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide();
            }

            else
            {
                //Show error if Registration failed
                MessageBox.Show("Registration failed. Please try again", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
