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
            entry panelentry = new entry();
            panelentry.TopLevel = false;

            if (Panelpet.Controls.Count  >0)
            {
                Panelpet.Controls.Clear();

            }
            Panelpet.Controls.Add(panelentry);
            panelentry.BringToFront();
            panelentry.Show();
            //entry_purchase entry_Purchase = new entry_purchase();
            //entry_Purchase.TopLevel = false;
            //entry_Purchase.Show();
            //Panelpet.Controls.Add(entry_Purchase);
            //entry_Purchase.BringToFront();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Panelpet.Controls.Count > 0)
            {
                Panelpet.Controls.Clear();

            }
            paneltype paneltype = new paneltype();
            paneltype.TopLevel = false;
            paneltype.Show();
            Panelpet.Controls.Add(paneltype);
            paneltype.BringToFront();
        }
    }
    }

