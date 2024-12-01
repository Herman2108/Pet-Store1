namespace PET_Store
{
    partial class SubCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.DGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewCustomer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 464);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGID,
            this.DGName,
            this.DGSex,
            this.DGPhone,
            this.DGDOB,
            this.DGEmail,
            this.DGAddress});
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(896, 464);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // DGID
            // 
            this.DGID.HeaderText = "ID";
            this.DGID.MinimumWidth = 6;
            this.DGID.Name = "DGID";
            // 
            // DGName
            // 
            this.DGName.HeaderText = "Name";
            this.DGName.MinimumWidth = 6;
            this.DGName.Name = "DGName";
            // 
            // DGSex
            // 
            this.DGSex.HeaderText = "Sex";
            this.DGSex.MinimumWidth = 6;
            this.DGSex.Name = "DGSex";
            // 
            // DGPhone
            // 
            this.DGPhone.HeaderText = "Phone Number";
            this.DGPhone.MinimumWidth = 6;
            this.DGPhone.Name = "DGPhone";
            // 
            // DGDOB
            // 
            this.DGDOB.HeaderText = "Date Of Birth";
            this.DGDOB.MinimumWidth = 6;
            this.DGDOB.Name = "DGDOB";
            // 
            // DGEmail
            // 
            this.DGEmail.HeaderText = "Email";
            this.DGEmail.MinimumWidth = 6;
            this.DGEmail.Name = "DGEmail";
            // 
            // DGAddress
            // 
            this.DGAddress.HeaderText = "Address";
            this.DGAddress.MinimumWidth = 6;
            this.DGAddress.Name = "DGAddress";
            // 
            // SubCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 464);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGAddress;
    }
}