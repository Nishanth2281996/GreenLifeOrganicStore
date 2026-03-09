using GreenLifeOrganicStore.Forms.Customer.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer
{
    public partial class FrmCustomerMain : Form
    {
        public FrmCustomerMain()
        {
            InitializeComponent();
            OpenCustomerPage(new UcBrowseProducts());

        }

        private void OpenCustomerPage(UserControl Page)
        {
            panelDesktop.Controls.Clear();
            Page.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Page);
           
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            cmsNav.Show(btnUser, 0, btnUser.Height);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenCustomerPage(new UcCartCheckout());
        }
    }
}
