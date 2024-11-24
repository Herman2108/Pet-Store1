namespace PET_Store
{
    partial class Login
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
            this.BG = new System.Windows.Forms.Panel();
            this.logoName = new System.Windows.Forms.Label();
            this.bntlogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.GreenYellow;
            this.BG.Controls.Add(this.logoName);
            this.BG.Controls.Add(this.bntlogin);
            this.BG.Controls.Add(this.textBox2);
            this.BG.Controls.Add(this.textBox1);
            this.BG.Controls.Add(this.PW);
            this.BG.Controls.Add(this.User);
            this.BG.Controls.Add(this.logo);
            this.BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG.Location = new System.Drawing.Point(0, 0);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(428, 575);
            this.BG.TabIndex = 0;
            // 
            // logoName
            // 
            this.logoName.AutoSize = true;
            this.logoName.Font = new System.Drawing.Font("KonKhmer_Moul", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoName.Location = new System.Drawing.Point(179, 153);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(95, 35);
            this.logoName.TabIndex = 7;
            this.logoName.Text = "PET Care";
            // 
            // bntlogin
            // 
            this.bntlogin.Font = new System.Drawing.Font("KonKhmer_Moul", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntlogin.Location = new System.Drawing.Point(175, 460);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(140, 45);
            this.bntlogin.TabIndex = 6;
            this.bntlogin.Text = "Login";
            this.bntlogin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 376);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 286);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 30);
            this.textBox1.TabIndex = 3;
            // 
            // PW
            // 
            this.PW.Image = global::PET_Store.Properties.Resources.lock_4573711_960_720;
            this.PW.Location = new System.Drawing.Point(39, 350);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(69, 61);
            this.PW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PW.TabIndex = 2;
            this.PW.TabStop = false;
            // 
            // User
            // 
            this.User.Image = global::PET_Store.Properties.Resources._118418_user_512x512;
            this.User.Location = new System.Drawing.Point(39, 255);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(69, 61);
            this.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User.TabIndex = 1;
            this.User.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::PET_Store.Properties.Resources.Pet_Logo;
            this.logo.Location = new System.Drawing.Point(116, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(214, 167);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 575);
            this.Controls.Add(this.BG);
            this.Name = "Login";
            this.Text = "Login";
            this.BG.ResumeLayout(false);
            this.BG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BG;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.PictureBox PW;
        private System.Windows.Forms.Button bntlogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label logoName;
    }
}

