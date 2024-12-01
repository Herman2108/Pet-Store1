using System;      
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PET_Store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {   
            Home home= new Home();
            home.TopLevel = false;
            home.Show();
            splitContainer1.Panel2.Controls.Add(home);
            home.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp= new Employee();
            emp.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(emp);
            emp.BringToFront();
            emp.Show();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.TopLevel = false;
            pet.Show();
            /*if (PanelTask.Controls.Count > 0)
            {
                PanelTask.Controls.Clear();
                PanelTask.Controls.Add(emp);
            }*/
            splitContainer1.Panel2.Controls.Add(pet);
            pet.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer Cus= new Customer();
            Cus.TopLevel = false;
            Cus.Show();
            /*if (PanelTask.Controls.Count > 0)
            {
                PanelTask.Controls.Clear();
                PanelTask.Controls.Add(emp);
            }*/
            splitContainer1.Panel2.Controls.Add(Cus);
            Cus.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
