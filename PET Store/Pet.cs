using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PET_Store
{
    public partial class Pet : Form
    {
        public Pet()
        {
            InitializeComponent();
        }

        private void PetPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            entry_purchase entry_Purchase = new entry_purchase();
            entry_Purchase.TopLevel = false;
            entry_Purchase.Show();
            Panelpet.Controls.Add(entry_Purchase);
            entry_Purchase.BringToFront();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

