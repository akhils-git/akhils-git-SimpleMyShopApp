namespace MyShop
{
    partial class ViewBill
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comBillId = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblBilldateTime = new System.Windows.Forms.Label();
            this.lblsd = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.sds = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataListProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblViewBills = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.comBillId);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 358);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bill Id";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(74, 51);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 25;
            // 
            // comBillId
            // 
            this.comBillId.ForeColor = System.Drawing.Color.White;
            this.comBillId.FormattingEnabled = true;
            this.comBillId.Location = new System.Drawing.Point(74, 13);
            this.comBillId.Name = "comBillId";
            this.comBillId.Size = new System.Drawing.Size(120, 21);
            this.comBillId.TabIndex = 24;
            this.comBillId.SelectedIndexChanged += new System.EventHandler(this.comBillId_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(74, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(199, 13);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // txtMobile
            // 
            this.txtMobile.ForeColor = System.Drawing.Color.White;
            this.txtMobile.Location = new System.Drawing.Point(74, 275);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(191, 20);
            this.txtMobile.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mobile";
            // 
            // txtPIN
            // 
            this.txtPIN.ForeColor = System.Drawing.Color.White;
            this.txtPIN.Location = new System.Drawing.Point(74, 231);
            this.txtPIN.MaxLength = 6;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(191, 20);
            this.txtPIN.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PIN";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(74, 95);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(191, 108);
            this.txtAddress.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveFile);
            this.panel3.Controls.Add(this.lblBilldateTime);
            this.panel3.Controls.Add(this.lblsd);
            this.panel3.Controls.Add(this.lblTotalAmount);
            this.panel3.Controls.Add(this.lblTotalItems);
            this.panel3.Controls.Add(this.sds);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dataListProducts);
            this.panel3.Location = new System.Drawing.Point(327, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 426);
            this.panel3.TabIndex = 16;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(466, 387);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(90, 23);
            this.btnSaveFile.TabIndex = 24;
            this.btnSaveFile.Text = "Save and View";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblBilldateTime
            // 
            this.lblBilldateTime.AutoSize = true;
            this.lblBilldateTime.ForeColor = System.Drawing.Color.White;
            this.lblBilldateTime.Location = new System.Drawing.Point(105, 392);
            this.lblBilldateTime.Name = "lblBilldateTime";
            this.lblBilldateTime.Size = new System.Drawing.Size(13, 13);
            this.lblBilldateTime.TabIndex = 29;
            this.lblBilldateTime.Text = "0";
            this.lblBilldateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsd
            // 
            this.lblsd.AutoSize = true;
            this.lblsd.ForeColor = System.Drawing.Color.White;
            this.lblsd.Location = new System.Drawing.Point(13, 392);
            this.lblsd.Name = "lblsd";
            this.lblsd.Size = new System.Drawing.Size(87, 13);
            this.lblsd.TabIndex = 28;
            this.lblsd.Text = "Bill date and time";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(317, 360);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAmount.TabIndex = 27;
            this.lblTotalAmount.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(105, 360);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(13, 13);
            this.lblTotalItems.TabIndex = 26;
            this.lblTotalItems.Text = "0";
            // 
            // sds
            // 
            this.sds.AutoSize = true;
            this.sds.ForeColor = System.Drawing.Color.White;
            this.sds.Location = new System.Drawing.Point(225, 360);
            this.sds.Name = "sds";
            this.sds.Size = new System.Drawing.Size(70, 13);
            this.sds.TabIndex = 25;
            this.sds.Text = "Total Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total Items";
            // 
            // dataListProducts
            // 
            this.dataListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataListProducts.Location = new System.Drawing.Point(16, 16);
            this.dataListProducts.Name = "dataListProducts";
            this.dataListProducts.Size = new System.Drawing.Size(540, 325);
            this.dataListProducts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quntity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // picHome
            // 
            this.picHome.Image = global::MyShop.Properties.Resources.file2;
            this.picHome.Location = new System.Drawing.Point(0, 453);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(71, 50);
            this.picHome.TabIndex = 29;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // lblViewBills
            // 
            this.lblViewBills.AutoSize = true;
            this.lblViewBills.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBills.ForeColor = System.Drawing.Color.White;
            this.lblViewBills.Location = new System.Drawing.Point(16, 9);
            this.lblViewBills.Name = "lblViewBills";
            this.lblViewBills.Size = new System.Drawing.Size(190, 54);
            this.lblViewBills.TabIndex = 30;
            this.lblViewBills.Text = "View bills";
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblViewBills);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBill";
            this.Load += new System.EventHandler(this.ViewBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBillId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label sds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataListProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblBilldateTime;
        private System.Windows.Forms.Label lblsd;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblViewBills;
    }
}