using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Open Login Form
            FrmLogin loginFrm = new FrmLogin();
            loginFrm.Show();
            this.Hide();
        }
       private void btnRegister_Click(object sender, EventArgs e)
        {
            //Open Register Form
            FrmRegister registerFrm = new FrmRegister();
            registerFrm.Show();
            this.Hide();
        }
    }
}
