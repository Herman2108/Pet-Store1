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

        MainForm mainForm = new MainForm();
        private void btnAC_Click(object sender, EventArgs e)
        {
            AddCustomer ACus = new AddCustomer();
            ACus.TopLevel = false;
           
            if (panelShow.Controls.Count>0)
            {
                panelShow.Controls.Clear();
                
            }
            panelShow.Controls.Add(ACus);
            ACus.BringToFront();
            ACus.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            SubCustomer SCus = new SubCustomer();
            SCus.TopLevel = false;
            SCus.Show();
            panelShow.Controls.Add(SCus);
            SCus.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
