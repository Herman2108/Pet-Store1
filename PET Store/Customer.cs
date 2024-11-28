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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            AddCustomer ACus = new AddCustomer();
            ACus.TopLevel = false;
            ACus.Show();
            /*if (PanelTask.Controls.Count > 0)
            {
                PanelTask.Controls.Clear();
                PanelTask.Controls.Add(emp);
            }*/
            panelShow.Controls.Add(ACus);
            ACus.BringToFront();
        }
    }
}
