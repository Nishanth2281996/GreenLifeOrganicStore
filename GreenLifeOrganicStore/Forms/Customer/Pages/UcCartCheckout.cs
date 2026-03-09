using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Customer.Pages
{
    public partial class UcCartCheckout : UserControl
    {
        public UcCartCheckout()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShipping_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void cmbCreditCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void lblSummarySubtoal_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotalNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblShippingNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscountNumber_Click(object sender, EventArgs e)
        {

        }

        private void pictureProfilepic_Click(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureProfilepic.Width, pictureProfilepic.Height);
            pictureProfilepic.Region = new Region(path);
        }
    }
}
