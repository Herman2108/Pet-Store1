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
            this.toolstripCustomer = new System.Windows.Forms.ToolStrip();
            this.btntsRefresh = new System.Windows.Forms.ToolStripButton();
            this.btntsToolAdd = new System.Windows.Forms.ToolStripButton();
            this.btntsToolEdit = new System.Windows.Forms.ToolStripButton();
            this.btntsToolDelete = new System.Windows.Forms.ToolStripButton();
            this.btntsToolActivate = new System.Windows.Forms.ToolStripButton();
            this.btntsToolDeactivate = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblSEX = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelDataGV = new System.Windows.Forms.Panel();
            this.dataGridViewCS = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelDataGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCS)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstripCustomer
            // 
            this.toolstripCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntsRefresh,
            this.btntsToolAdd,
            this.btntsToolEdit,
            this.btntsToolDelete,
            this.btntsToolActivate,
            this.btntsToolDeactivate});
            this.toolstripCustomer.Location = new System.Drawing.Point(0, 0);
            this.toolstripCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolstripCustomer.Name = "toolstripCustomer";
            this.toolstripCustomer.Padding = new System.Windows.Forms.Padding(3, 5, 1, 5);
            this.toolstripCustomer.Size = new System.Drawing.Size(1248, 37);
            this.toolstripCustomer.TabIndex = 5;
            this.toolstripCustomer.Text = "tsCustomer";
            // 
            // btntsRefresh
            // 
            this.btntsRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsRefresh.ForeColor = System.Drawing.Color.Black;
            this.btntsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsRefresh.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsRefresh.Name = "btntsRefresh";
            this.btntsRefresh.Size = new System.Drawing.Size(66, 24);
            this.btntsRefresh.Text = " Refresh";
            // 
            // btntsToolAdd
            // 
            this.btntsToolAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsToolAdd.ForeColor = System.Drawing.Color.Black;
            this.btntsToolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsToolAdd.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsToolAdd.Name = "btntsToolAdd";
            this.btntsToolAdd.Size = new System.Drawing.Size(79, 24);
            this.btntsToolAdd.Text = " Add New";
            // 
            // btntsToolEdit
            // 
            this.btntsToolEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsToolEdit.ForeColor = System.Drawing.Color.Black;
            this.btntsToolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsToolEdit.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsToolEdit.Name = "btntsToolEdit";
            this.btntsToolEdit.Size = new System.Drawing.Size(47, 24);
            this.btntsToolEdit.Text = "  Edit";
            // 
            // btntsToolDelete
            // 
            this.btntsToolDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsToolDelete.ForeColor = System.Drawing.Color.Black;
            this.btntsToolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsToolDelete.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsToolDelete.Name = "btntsToolDelete";
            this.btntsToolDelete.Size = new System.Drawing.Size(65, 24);
            this.btntsToolDelete.Text = "  Delete";
            // 
            // btntsToolActivate
            // 
            this.btntsToolActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsToolActivate.ForeColor = System.Drawing.Color.Black;
            this.btntsToolActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsToolActivate.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsToolActivate.Name = "btntsToolActivate";
            this.btntsToolActivate.Size = new System.Drawing.Size(75, 24);
            this.btntsToolActivate.Text = "  Activate";
            this.btntsToolActivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btntsToolDeactivate
            // 
            this.btntsToolDeactivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntsToolDeactivate.ForeColor = System.Drawing.Color.Black;
            this.btntsToolDeactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsToolDeactivate.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btntsToolDeactivate.Name = "btntsToolDeactivate";
            this.btntsToolDeactivate.Size = new System.Drawing.Size(92, 24);
            this.btntsToolDeactivate.Text = "  Deactivate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelGeneral);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 272);
            this.panel1.TabIndex = 6;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGeneral.BackColor = System.Drawing.Color.White;
            this.panelGeneral.Controls.Add(this.lblAddress);
            this.panelGeneral.Controls.Add(this.textBox4);
            this.panelGeneral.Controls.Add(this.lblAge);
            this.panelGeneral.Controls.Add(this.textBox3);
            this.panelGeneral.Controls.Add(this.lblSEX);
            this.panelGeneral.Controls.Add(this.textBox1);
            this.panelGeneral.Controls.Add(this.lblPhone);
            this.panelGeneral.Controls.Add(this.textBox2);
            this.panelGeneral.Controls.Add(this.label12);
            this.panelGeneral.Controls.Add(this.panel9);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtName);
            this.panelGeneral.Controls.Add(this.txtConfirm);
            this.panelGeneral.Controls.Add(this.lblDOB);
            this.panelGeneral.Controls.Add(this.lblmail);
            this.panelGeneral.Controls.Add(this.txtPw);
            this.panelGeneral.Location = new System.Drawing.Point(12, 13);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1224, 244);
            this.panelGeneral.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(551, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "General Information";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(19, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1190, 1);
            this.panel9.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(246, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.Black;
            this.txtConfirm.Location = new System.Drawing.Point(246, 181);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(310, 27);
            this.txtConfirm.TabIndex = 7;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(106, 132);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.Color.Black;
            this.lblmail.Location = new System.Drawing.Point(106, 183);
            this.lblmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(46, 20);
            this.lblmail.TabIndex = 6;
            this.lblmail.Text = "Email";
            // 
            // txtPw
            // 
            this.txtPw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.Black;
            this.txtPw.Location = new System.Drawing.Point(246, 129);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(310, 27);
            this.txtPw.TabIndex = 5;
            // 
            // lblSEX
            // 
            this.lblSEX.AutoSize = true;
            this.lblSEX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEX.ForeColor = System.Drawing.Color.Black;
            this.lblSEX.Location = new System.Drawing.Point(624, 78);
            this.lblSEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSEX.Name = "lblSEX";
            this.lblSEX.Size = new System.Drawing.Size(32, 20);
            this.lblSEX.TabIndex = 14;
            this.lblSEX.Text = "Sex";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(732, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 27);
            this.textBox1.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(624, 133);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(108, 20);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone Number";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(732, 125);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 27);
            this.textBox2.TabIndex = 17;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(905, 78);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 18;
            this.lblAge.Text = "Age";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(1004, 78);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 27);
            this.textBox3.TabIndex = 19;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(624, 188);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(732, 180);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(381, 27);
            this.textBox4.TabIndex = 21;
            // 
            // panelDataGV
            // 
            this.panelDataGV.Controls.Add(this.dataGridViewCS);
            this.panelDataGV.Location = new System.Drawing.Point(0, 311);
            this.panelDataGV.Name = "panelDataGV";
            this.panelDataGV.Size = new System.Drawing.Size(1248, 384);
            this.panelDataGV.TabIndex = 7;
            // 
            // dataGridViewCS
            // 
            this.dataGridViewCS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CName,
            this.CSex,
            this.CPhone,
            this.CDOB,
            this.CEmail,
            this.CAddress});
            this.dataGridViewCS.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCS.Name = "dataGridViewCS";
            this.dataGridViewCS.RowHeadersVisible = false;
            this.dataGridViewCS.RowHeadersWidth = 51;
            this.dataGridViewCS.RowTemplate.Height = 24;
            this.dataGridViewCS.Size = new System.Drawing.Size(1248, 384);
            this.dataGridViewCS.TabIndex = 0;
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            // 
            // CSex
            // 
            this.CSex.HeaderText = "Sex";
            this.CSex.MinimumWidth = 6;
            this.CSex.Name = "CSex";
            // 
            // CPhone
            // 
            this.CPhone.HeaderText = "Phone";
            this.CPhone.MinimumWidth = 6;
            this.CPhone.Name = "CPhone";
            // 
            // CDOB
            // 
            this.CDOB.HeaderText = "Date Of Birth";
            this.CDOB.MinimumWidth = 6;
            this.CDOB.Name = "CDOB";
            // 
            // CEmail
            // 
            this.CEmail.HeaderText = "Email";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            // 
            // CAddress
            // 
            this.CAddress.HeaderText = "Address";
            this.CAddress.MinimumWidth = 6;
            this.CAddress.Name = "CAddress";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 695);
            this.Controls.Add(this.panelDataGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolstripCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolstripCustomer.ResumeLayout(false);
            this.toolstripCustomer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelDataGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolstripCustomer;
        private System.Windows.Forms.ToolStripButton btntsRefresh;
        private System.Windows.Forms.ToolStripButton btntsToolAdd;
        private System.Windows.Forms.ToolStripButton btntsToolEdit;
        private System.Windows.Forms.ToolStripButton btntsToolDelete;
        private System.Windows.Forms.ToolStripButton btntsToolActivate;
        private System.Windows.Forms.ToolStripButton btntsToolDeactivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblSEX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panelDataGV;
        private System.Windows.Forms.DataGridView dataGridViewCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
    }
}