namespace PET_Store
{
    partial class Pet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PetPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PetPanel
            // 
            this.PetPanel.BackColor = System.Drawing.Color.LightGreen;
            this.PetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PetPanel.Location = new System.Drawing.Point(0, 0);
            this.PetPanel.Name = "PetPanel";
            this.PetPanel.Size = new System.Drawing.Size(896, 635);
            this.PetPanel.TabIndex = 9;
            // 
            // Pet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 635);
            this.Controls.Add(this.PetPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pet";
            this.Text = "Pet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PetPanel;
    }
}