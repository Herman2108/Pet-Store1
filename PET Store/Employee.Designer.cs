namespace PET_Store
{
    partial class Employee
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
            this.EmpPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PosterCS = new System.Windows.Forms.PictureBox();
            this.EmpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpPanel
            // 
            this.EmpPanel.BackColor = System.Drawing.Color.LightGreen;
            this.EmpPanel.Controls.Add(this.panel1);
            this.EmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpPanel.Name = "EmpPanel";
            this.EmpPanel.Size = new System.Drawing.Size(896, 635);
            this.EmpPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PosterCS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 174);
            this.panel1.TabIndex = 0;
            // 
            // PosterCS
            // 
            this.PosterCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosterCS.Image = global::PET_Store.Properties.Resources.CS_Poster;
            this.PosterCS.Location = new System.Drawing.Point(0, 0);
            this.PosterCS.Name = "PosterCS";
            this.PosterCS.Size = new System.Drawing.Size(896, 174);
            this.PosterCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterCS.TabIndex = 0;
            this.PosterCS.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 635);
            this.Controls.Add(this.EmpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.EmpPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmpPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PosterCS;
    }
}