namespace PET_Store
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.picPet = new System.Windows.Forms.PictureBox();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelTask = new System.Windows.Forms.Panel();
            this.First.SuspendLayout();
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
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(16, 568);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 50);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Yellow;
            this.btnCustomer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(16, 467);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(280, 50);
            this.btnCustomer.TabIndex = 11;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.Color.Yellow;
            this.btnPet.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPet.Location = new System.Drawing.Point(16, 366);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(280, 50);
            this.btnPet.TabIndex = 9;
            this.btnPet.Text = "Pet";
            this.btnPet.UseVisualStyleBackColor = false;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Yellow;
            this.btnEmployee.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(16, 265);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(280, 50);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.Color.GreenYellow;
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
            this.picCustomer.Location = new System.Drawing.Point(21, 471);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(68, 41);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 12;
            this.picCustomer.TabStop = false;
            // 
            // picPet
            // 
            this.picPet.Image = global::PET_Store.Properties.Resources.PetIcon;
            this.picPet.Location = new System.Drawing.Point(21, 370);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(68, 41);
            this.picPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPet.TabIndex = 10;
            this.picPet.TabStop = false;
            // 
            // picEmployee
            // 
            this.picEmployee.Image = global::PET_Store.Properties.Resources.Employee;
            this.picEmployee.Location = new System.Drawing.Point(21, 269);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(68, 41);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 8;
            this.picEmployee.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::PET_Store.Properties.Resources.Home1;
            this.picHome.Location = new System.Drawing.Point(21, 168);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(68, 41);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Yellow;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(16, 164);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(280, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.Aquamarine;
            this.PanelTask.Location = new System.Drawing.Point(314, 12);
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.Size = new System.Drawing.Size(896, 635);
            this.PanelTask.TabIndex = 6;
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
    }
}