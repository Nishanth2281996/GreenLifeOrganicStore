using GreenLifeOrganicStore.DAL;
using GreenLifeOrganicStore.Models;
using iText.IO.Colors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcMyProfile : UserControl
    {
        private readonly int customerId;
        private readonly UserDAL userDAL = new UserDAL();
        
        public UcMyProfile(int loggedInCustomerId)
        {
            InitializeComponent();

            // Store the logged-in customer ID
            customerId = loggedInCustomerId;

            // Load customer profile data
            LoadProfile();
        }
        // Enable profile editing control

        // Change the form between edit mode and read-only mode
        private void SetEditMode(bool isEditing)
        {
            // Textboxes become editable only in edit mode
            txtFullName.ReadOnly = !isEditing;
            txtEmail.ReadOnly = !isEditing;
            txtPhone.ReadOnly = !isEditing;
            txtCity.ReadOnly = !isEditing;
            txtAddress.ReadOnly = !isEditing;

            // Buttons become active only in edit mode
            btnUploadPhoto.Enabled = isEditing;
            btnSave.Enabled = isEditing;
            btnCancel.Enabled = isEditing;
        }

        // Enable profile editing
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode(true);
        }

        // Cancel editing and return to original data
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadProfile();       // Reload saved profile data
            SetEditMode(false);  // Return to read-only mode
        }

        // Upload photo and preview it
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            // Allow only image files
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Show selected image in PictureBox
                pictureProfilepic.Image = Image.FromFile(ofd.FileName);

                // Store original selected file path temporarily
                pictureProfilepic.Tag = ofd.FileName;
            }
        }

        // Save profile changes and return to read-only mode
        private void btnSave_Click(object sender, EventArgs e)
        {
            string profileImagePath = null;

            // Keep old image path if no new image selected
            User existingUser = userDAL.GetUserById(customerId);
            if (existingUser != null)
            {
                profileImagePath = existingUser.ProfileImagePath;
            }

            // If a new image was selected, save it into project folder
            if (pictureProfilepic.Tag != null)
            {
                string selectedImagePath = pictureProfilepic.Tag.ToString();

                // Only copy image if it is an absolute path from user's PC
                if (Path.IsPathRooted(selectedImagePath))
                {
                    profileImagePath = SaveImageToProject(selectedImagePath);
                }
                else
                {
                    // Already a relative project path
                    profileImagePath = selectedImagePath;
                }
            }

            User user = new User
            {
                Users_id = customerId,
                Full_Name = txtFullName.Text.Trim(),
                U_Email = txtEmail.Text.Trim(),
                U_Phone = txtPhone.Text.Trim(),
                U_Address = txtAddress.Text.Trim(),
                U_City = txtCity.Text.Trim(),
                ProfileImagePath = profileImagePath
            };

            bool success = userDAL.UpdateUserProfile(user);

            if (success)
            {
                MessageBox.Show("Profile updated successfully!");
                LoadProfile();       // Refresh data after saving
                SetEditMode(false);  // Lock fields again
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        // Load profile data
        private void LoadProfile()
        {
            User user = userDAL.GetUserById(customerId);

            if (user != null)
            {
                txtFullName.Text = user.Full_Name;
                txtEmail.Text = user.U_Email;
                txtPhone.Text = user.U_Phone;
                txtCity.Text = user.U_City;
                txtAddress.Text = user.U_Address;

                lblName.Text = user.Full_Name;
                lblUniqueCustomerID.Text = user.Users_id.ToString();

                // Store saved image path in Tag
                pictureProfilepic.Tag = user.ProfileImagePath;

                // Clear old image first
                pictureProfilepic.Image = null;

                // Load saved image if available
                if (!string.IsNullOrEmpty(user.ProfileImagePath))
                {
                    string fullPath = Path.Combine(Application.StartupPath, user.ProfileImagePath);

                    if (File.Exists(fullPath))
                    {
                        pictureProfilepic.Image = Image.FromFile(fullPath);
                    }
                }
            }
        }

        // Save selected image into project folder and return relative path
        private string SaveImageToProject(string sourcePath)
        {
            // Create folder path inside project output folder
            string folderPath = Path.Combine(Application.StartupPath, "Images", "Profiles");

            // Create folder if it does not exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Create file name based on customer id
            string fileName = "customer_" + customerId + Path.GetExtension(sourcePath);

            // Full destination path
            string destinationPath = Path.Combine(folderPath, fileName);

            // Copy selected image into project folder
            File.Copy(sourcePath, destinationPath, true);

            // Return relative path to store in database
            return Path.Combine("Images", "Profiles", fileName);
        }
    }
}
