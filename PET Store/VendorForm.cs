using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PET_Store
{
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_Paint(object sender, PaintEventArgs e)
        {
            // Create a linear gradient brush
            using (LinearGradientBrush brush = new LinearGradientBrush(btnSearch.ClientRectangle, Color.LightBlue, Color.DarkBlue, 45F))
            {
                // Fill the button with a gradient
                e.Graphics.FillRectangle(brush, btnSearch.ClientRectangle);
            }

            // Draw the button text
            TextRenderer.DrawText(e.Graphics, btnSearch.Text, btnSearch.Font, button1.ClientRectangle, btnSearch.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
