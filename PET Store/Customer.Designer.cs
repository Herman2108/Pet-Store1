﻿namespace PET_Store
{
    partial class Customer
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
            this.CusPanel = new System.Windows.Forms.Panel();
            this.EmpPanel = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.PosterCS = new System.Windows.Forms.PictureBox();
            this.CusPanel.SuspendLayout();
            this.EmpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).BeginInit();
            this.SuspendLayout();
            // 
            // CusPanel
            // 
            this.CusPanel.BackColor = System.Drawing.Color.LightGreen;
            this.CusPanel.Controls.Add(this.EmpPanel);
            this.CusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusPanel.Location = new System.Drawing.Point(0, 0);
            this.CusPanel.Name = "CusPanel";
            this.CusPanel.Size = new System.Drawing.Size(896, 635);
            this.CusPanel.TabIndex = 10;
            // 
            // EmpPanel
            // 
            this.EmpPanel.BackColor = System.Drawing.Color.LightGreen;
            this.EmpPanel.Controls.Add(this.panelShow);
            this.EmpPanel.Controls.Add(this.panel1);
            this.EmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpPanel.Name = "EmpPanel";
            this.EmpPanel.Size = new System.Drawing.Size(896, 635);
            this.EmpPanel.TabIndex = 9;
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.GhostWhite;
            this.panelShow.Location = new System.Drawing.Point(0, 171);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(896, 464);
            this.panelShow.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnCS);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.PosterCS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 174);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(723, 114);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 41);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.ForeColor = System.Drawing.Color.Black;
            this.btnCS.Location = new System.Drawing.Point(723, 67);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(144, 41);
            this.btnCS.TabIndex = 2;
            this.btnCS.Text = "Customer";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnAC
            // 
            this.btnAC.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.Black;
            this.btnAC.Location = new System.Drawing.Point(723, 20);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(144, 41);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "Add Customer";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 635);
            this.Controls.Add(this.CusPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.CusPanel.ResumeLayout(false);
            this.EmpPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CusPanel;
        private System.Windows.Forms.Panel EmpPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.PictureBox PosterCS;
        private System.Windows.Forms.Panel panelShow;
    }
}