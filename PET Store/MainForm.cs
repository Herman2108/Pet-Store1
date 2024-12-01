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
            PanelTask.Controls.Add(home);
            home.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp= new Employee();
            emp.TopLevel = false;
            emp.Show();
            /*if (PanelTask.Controls.Count > 0)
            {
                PanelTask.Controls.Clear();
                PanelTask.Controls.Add(emp);
            }*/
            PanelTask.Controls.Add(emp);
            emp.BringToFront();
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
            PanelTask.Controls.Add(pet);
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
            PanelTask.Controls.Add(Cus);
            Cus.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
