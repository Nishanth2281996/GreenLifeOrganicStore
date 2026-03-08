using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms.Admin.Pages
{
    public partial class UcAdminReports : UserControl
    {
        public UcAdminReports()
        {
            InitializeComponent();
        }

        private void tabReports_DrawItem(object sender, DrawItemEventArgs e)
        {
        
            TabControl tab = sender as TabControl;

            TabPage currentTab = tab.TabPages[e.Index];
            Rectangle tabRect = tab.GetTabRect(e.Index);

            Brush backgroundBrush;
            Brush textBrush;

            // If the tab is selected
            if (e.Index == tab.SelectedIndex)
            {
                backgroundBrush = new SolidBrush(Color.ForestGreen);
                textBrush = new SolidBrush(Color.White);
            }
            else
            {
                backgroundBrush = new SolidBrush(Color.LightGray);
                textBrush = new SolidBrush(Color.Black);
            }

            e.Graphics.FillRectangle(backgroundBrush, tabRect);

            StringFormat textFormat = new StringFormat();
            textFormat.Alignment = StringAlignment.Center;
            textFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(currentTab.Text, e.Font, textBrush, tabRect, textFormat);
        
    }
    }
}
