namespace PET_Store
{
    partial class SaleForm
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
            this.PanelSale = new System.Windows.Forms.Panel();
            this.lblSale = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.SaleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSale.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSale
            // 
            this.PanelSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSale.Controls.Add(this.textBox1);
            this.PanelSale.Controls.Add(this.panel2);
            this.PanelSale.Controls.Add(this.btnAddNew);
            this.PanelSale.Controls.Add(this.lblSale);
            this.PanelSale.Location = new System.Drawing.Point(0, 0);
            this.PanelSale.Name = "PanelSale";
            this.PanelSale.Size = new System.Drawing.Size(896, 635);
            this.PanelSale.TabIndex = 0;
            // 
            // lblSale
            // 
            this.lblSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSale.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(12, 9);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(126, 33);
            this.lblSale.TabIndex = 0;
            this.lblSale.Text = "Sales List";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNew.Location = new System.Drawing.Point(17, 45);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(121, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSale);
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 537);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleNo,
            this.SaleCustomerName,
            this.SaleDate,
            this.SalePayment,
            this.SalePet,
            this.SaleAmount});
            this.dataGridViewSale.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.RowHeadersVisible = false;
            this.dataGridViewSale.RowHeadersWidth = 51;
            this.dataGridViewSale.RowTemplate.Height = 24;
            this.dataGridViewSale.Size = new System.Drawing.Size(896, 537);
            this.dataGridViewSale.TabIndex = 0;
            // 
            // SaleNo
            // 
            this.SaleNo.FillWeight = 36.2822F;
            this.SaleNo.HeaderText = "No";
            this.SaleNo.MinimumWidth = 6;
            this.SaleNo.Name = "SaleNo";
            this.SaleNo.Width = 60;
            // 
            // SaleCustomerName
            // 
            this.SaleCustomerName.FillWeight = 118.3187F;
            this.SaleCustomerName.HeaderText = "Customer Name";
            this.SaleCustomerName.MinimumWidth = 6;
            this.SaleCustomerName.Name = "SaleCustomerName";
            this.SaleCustomerName.Width = 200;
            // 
            // SaleDate
            // 
            this.SaleDate.FillWeight = 76.43302F;
            this.SaleDate.HeaderText = "Date";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Width = 170;
            // 
            // SalePayment
            // 
            this.SalePayment.FillWeight = 127.1689F;
            this.SalePayment.HeaderText = "Payment";
            this.SalePayment.MinimumWidth = 6;
            this.SalePayment.Name = "SalePayment";
            this.SalePayment.Width = 150;
            // 
            // SalePet
            // 
            this.SalePet.FillWeight = 91.00114F;
            this.SalePet.HeaderText = "Pet";
            this.SalePet.MinimumWidth = 6;
            this.SalePet.Name = "SalePet";
            this.SalePet.Width = 150;
            // 
            // SaleAmount
            // 
            this.SaleAmount.FillWeight = 150.796F;
            this.SaleAmount.HeaderText = "Amount";
            this.SaleAmount.MinimumWidth = 6;
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.Width = 165;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(660, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 3;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 635);
            this.Controls.Add(this.PanelSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.PanelSale.ResumeLayout(false);
            this.PanelSale.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
        private System.Windows.Forms.TextBox textBox1;
    }
}