﻿namespace PET_Store
{
    partial class MainForm
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
            this.lblEmpName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.First = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.picPet = new System.Windows.Forms.PictureBox();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.First.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(121, 40);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(150, 31);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "EmpName";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Navy;
            this.btnLogout.Location = new System.Drawing.Point(16, 568);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 50);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Navy;
            this.btnCustomer.Location = new System.Drawing.Point(16, 211);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(280, 50);
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.Color.LightGray;
            this.btnPet.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPet.ForeColor = System.Drawing.Color.Navy;
            this.btnPet.Location = new System.Drawing.Point(16, 321);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(280, 50);
            this.btnPet.TabIndex = 9;
            this.btnPet.Text = "Pet";
            this.btnPet.UseVisualStyleBackColor = false;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.LightGray;
            this.btnEmployee.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Navy;
            this.btnEmployee.Location = new System.Drawing.Point(16, 156);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(280, 50);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "  Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.First.Controls.Add(this.pictureBox4);
            this.First.Controls.Add(this.btnPO);
            this.First.Controls.Add(this.pictureBox3);
            this.First.Controls.Add(this.btnSale);
            this.First.Controls.Add(this.pictureBox1);
            this.First.Controls.Add(this.btnVendor);
            this.First.Controls.Add(this.lblEmpName);
            this.First.Controls.Add(this.pictureBox2);
            this.First.Controls.Add(this.picLogout);
            this.First.Controls.Add(this.btnLogout);
            this.First.Controls.Add(this.picCustomer);
            this.First.Controls.Add(this.btnCustomer);
            this.First.Controls.Add(this.picPet);
            this.First.Controls.Add(this.btnPet);
            this.First.Controls.Add(this.picEmployee);
            this.First.Controls.Add(this.btnEmployee);
            this.First.Controls.Add(this.picHome);
            this.First.Controls.Add(this.btnHome);
            this.First.Controls.Add(this.PanelTask);
            this.First.Dock = System.Windows.Forms.DockStyle.Fill;
            this.First.Location = new System.Drawing.Point(0, 0);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(1222, 659);
            this.First.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightGray;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Navy;
            this.btnHome.Location = new System.Drawing.Point(16, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(280, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.White;
            this.PanelTask.Location = new System.Drawing.Point(314, 12);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(896, 635);
            this.PanelTask.TabIndex = 6;
            // 
            // btnVendor
            // 
            this.btnVendor.BackColor = System.Drawing.Color.LightGray;
            this.btnVendor.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendor.ForeColor = System.Drawing.Color.Navy;
            this.btnVendor.Location = new System.Drawing.Point(16, 267);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(280, 50);
            this.btnVendor.TabIndex = 16;
            this.btnVendor.Text = "Vendor";
            this.btnVendor.UseVisualStyleBackColor = false;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.LightGray;
            this.btnSale.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.Navy;
            this.btnSale.Location = new System.Drawing.Point(16, 377);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(280, 50);
            this.btnSale.TabIndex = 18;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.LightGray;
            this.btnPO.Font = new System.Drawing.Font("Modern No. 20", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPO.ForeColor = System.Drawing.Color.Navy;
            this.btnPO.Location = new System.Drawing.Point(16, 433);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(280, 50);
            this.btnPO.TabIndex = 20;
            this.btnPO.Text = "       Purchase Order";
            this.btnPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPO.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PET_Store.Properties.Resources.Purchese;
            this.pictureBox4.Location = new System.Drawing.Point(21, 437);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PET_Store.Properties.Resources.Sale_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(21, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PET_Store.Properties.Resources.Vendor;
            this.pictureBox1.Location = new System.Drawing.Point(21, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PET_Store.Properties.Resources._118418_user_512x512;
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // picLogout
            // 
            this.picLogout.Image = global::PET_Store.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(21, 572);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(68, 41);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 14;
            this.picLogout.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::PET_Store.Properties.Resources.customer;
            this.picCustomer.Location = new System.Drawing.Point(21, 215);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(68, 41);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 12;
            this.picCustomer.TabStop = false;
            // 
            // picPet
            // 
            this.picPet.Image = global::PET_Store.Properties.Resources.PetIcon;
            this.picPet.Location = new System.Drawing.Point(21, 325);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(68, 41);
            this.picPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPet.TabIndex = 10;
            this.picPet.TabStop = false;
            // 
            // picEmployee
            // 
            this.picEmployee.Image = global::PET_Store.Properties.Resources.Employee;
            this.picEmployee.Location = new System.Drawing.Point(21, 160);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(68, 41);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 8;
            this.picEmployee.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::PET_Store.Properties.Resources.Home1;
            this.picHome.Location = new System.Drawing.Point(21, 105);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(68, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 659);
            this.Controls.Add(this.First);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.First.ResumeLayout(false);
            this.First.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.PictureBox picPet;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel First;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSale;
    }
}