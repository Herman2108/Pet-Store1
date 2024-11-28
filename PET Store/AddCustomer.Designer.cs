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
            this.PanelAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAC
            // 
            this.PanelAC.Controls.Add(this.lblAddCS);
            this.PanelAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAC.Location = new System.Drawing.Point(0, 0);
            this.PanelAC.Name = "PanelAC";
            this.PanelAC.Size = new System.Drawing.Size(896, 464);
            this.PanelAC.TabIndex = 0;
            // 
            // lblAddCS
            // 
            this.lblAddCS.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCS.Location = new System.Drawing.Point(330, 0);
            this.lblAddCS.Name = "lblAddCS";
            this.lblAddCS.Size = new System.Drawing.Size(236, 73);
            this.lblAddCS.TabIndex = 0;
            this.lblAddCS.Text = "Add Customer";
            this.lblAddCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 464);
            this.Controls.Add(this.PanelAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.PanelAC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAC;
        private System.Windows.Forms.Label lblAddCS;
    }
}