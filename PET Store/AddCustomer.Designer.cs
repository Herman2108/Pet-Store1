namespace PET_Store
{
    partial class AddCustomer
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
            this.PanelAC = new System.Windows.Forms.Panel();
            this.lblAddCS = new System.Windows.Forms.Label();
            this.lblNameCS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.PanelAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAC
            // 
            this.PanelAC.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelAC.Controls.Add(this.txtFirstName);
            this.PanelAC.Controls.Add(this.textBox1);
            this.PanelAC.Controls.Add(this.lblNameCS);
            this.PanelAC.Controls.Add(this.lblAddCS);
            this.PanelAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAC.Location = new System.Drawing.Point(0, 0);
            this.PanelAC.Name = "PanelAC";
            this.PanelAC.Size = new System.Drawing.Size(451, 464);
            this.PanelAC.TabIndex = 0;
            // 
            // lblAddCS
            // 
            this.lblAddCS.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCS.ForeColor = System.Drawing.Color.Black;
            this.lblAddCS.Location = new System.Drawing.Point(69, 9);
            this.lblAddCS.Name = "lblAddCS";
            this.lblAddCS.Size = new System.Drawing.Size(326, 73);
            this.lblAddCS.TabIndex = 0;
            this.lblAddCS.Text = "Add Customer";
            this.lblAddCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameCS
            // 
            this.lblNameCS.AutoSize = true;
            this.lblNameCS.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCS.Location = new System.Drawing.Point(12, 81);
            this.lblNameCS.Name = "lblNameCS";
            this.lblNameCS.Size = new System.Drawing.Size(69, 25);
            this.lblNameCS.TabIndex = 1;
            this.lblNameCS.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(17, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 45);
            this.textBox1.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 238);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 464);
            this.Controls.Add(this.PanelAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.PanelAC.ResumeLayout(false);
            this.PanelAC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAC;
        private System.Windows.Forms.Label lblAddCS;
        private System.Windows.Forms.Label lblNameCS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}