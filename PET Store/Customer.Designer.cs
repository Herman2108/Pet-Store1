namespace PET_Store
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.PosterCS = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPanel.SuspendLayout();
            this.EmpPanel.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelShow.Controls.Add(this.flowLayoutPanel1);
            this.panelShow.Location = new System.Drawing.Point(0, 171);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(896, 464);
            this.panelShow.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCS);
            this.panel1.Controls.Add(this.btnAC);
            this.panel1.Controls.Add(this.PosterCS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 174);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(723, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(896, 464);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Sex,
            this.Phone,
            this.DOB,
            this.Email,
            this.Address});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date Of Birth";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
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
            this.panelShow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PosterCS)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CusPanel;
        private System.Windows.Forms.Panel EmpPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.PictureBox PosterCS;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}