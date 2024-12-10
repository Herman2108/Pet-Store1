using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET_Store
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //SubSale Subs = new SubSale();
            //Subs.Show();

            SubSale Subs = new SubSale();
            Subs.TopLevel = false;
            if (PanelSale.Controls.Count > 0)
            {
                PanelSale.Controls.Clear();
            }
            PanelSale.Controls.Add(Subs);
            Subs.BringToFront();
            Subs.Show();

        }
    }
}
