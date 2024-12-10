using System;
using System.Windows.Forms;
using Panel = System.Web.UI.WebControls.Panel;

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
            Home home = new Home();
            home.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(home);
            home.BringToFront();
            home.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
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
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(pet);
            pet.BringToFront();
            pet.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer Cus = new Customer();
            Cus.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(Cus);
            Cus.BringToFront();
            Cus.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            VendorForm Cus = new VendorForm();
            Cus.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(Cus);
            Cus.BringToFront();
            Cus.Show();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            PurchaserOders frm = new PurchaserOders();
            frm.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm Sal = new SaleForm();
            Sal.TopLevel = false;
            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.Clear();
            }
            splitContainer1.Panel2.Controls.Add(Sal);
            Sal.BringToFront();
            Sal.Show();
        }
    }
}
