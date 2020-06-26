namespace MyShop
{
    partial class AddNewProduct
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.caln = new System.Windows.Forms.MonthCalendar();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtQuntity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picProducts = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblMsgBox = new System.Windows.Forms.Label();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducts.Controls.Add(this.caln);
            this.pnlProducts.Controls.Add(this.txtPrice);
            this.pnlProducts.Controls.Add(this.txtQuntity);
            this.pnlProducts.Controls.Add(this.label7);
            this.pnlProducts.Controls.Add(this.txtFeature);
            this.pnlProducts.Controls.Add(this.label6);
            this.pnlProducts.Controls.Add(this.btnClear);
            this.pnlProducts.Controls.Add(this.btnSave);
            this.pnlProducts.Controls.Add(this.txtMDate);
            this.pnlProducts.Controls.Add(this.label5);
            this.pnlProducts.Controls.Add(this.txtEDate);
            this.pnlProducts.Controls.Add(this.label4);
            this.pnlProducts.Controls.Add(this.label3);
            this.pnlProducts.Controls.Add(this.txtCompany);
            this.pnlProducts.Controls.Add(this.label2);
            this.pnlProducts.Controls.Add(this.txtName);
            this.pnlProducts.Controls.Add(this.label1);
            this.pnlProducts.Location = new System.Drawing.Point(268, 77);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(379, 385);
            this.pnlProducts.TabIndex = 13;
            // 
            // caln
            // 
            this.caln.Location = new System.Drawing.Point(139, 112);
            this.caln.Name = "caln";
            this.caln.TabIndex = 24;
            this.caln.Visible = false;
            this.caln.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.caln_DateSelected);
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(139, 120);
            this.txtPrice.Mask = "9990000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtQuntity
            // 
            this.txtQuntity.ForeColor = System.Drawing.Color.White;
            this.txtQuntity.Location = new System.Drawing.Point(139, 290);
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Size = new System.Drawing.Size(191, 20);
            this.txtQuntity.TabIndex = 6;
            this.txtQuntity.Tag = "MDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quntity";
            // 
            // txtFeature
            // 
            this.txtFeature.ForeColor = System.Drawing.Color.White;
            this.txtFeature.Location = new System.Drawing.Point(139, 248);
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(191, 20);
            this.txtFeature.TabIndex = 5;
            this.txtFeature.Tag = "MDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Features";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(164, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(255, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtMDate
            // 
            this.txtMDate.ForeColor = System.Drawing.Color.White;
            this.txtMDate.Location = new System.Drawing.Point(139, 206);
            this.txtMDate.Name = "txtMDate";
            this.txtMDate.Size = new System.Drawing.Size(191, 20);
            this.txtMDate.TabIndex = 4;
            this.txtMDate.Tag = "MDate";
            this.txtMDate.Click += new System.EventHandler(this.txtMDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Manufacting Date";
            // 
            // txtEDate
            // 
            this.txtEDate.ForeColor = System.Drawing.Color.White;
            this.txtEDate.Location = new System.Drawing.Point(139, 164);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Size = new System.Drawing.Size(191, 20);
            this.txtEDate.TabIndex = 3;
            this.txtEDate.Tag = "EDate";
            this.txtEDate.Click += new System.EventHandler(this.txtEDate_Click);
            this.txtEDate.TextChanged += new System.EventHandler(this.txtExDate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Expare Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Price";
            // 
            // txtCompany
            // 
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(139, 76);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(191, 24);
            this.txtCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Company";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(139, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(61, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(323, 74);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Add new products";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProducts
            // 
            this.picProducts.Image = global::MyShop.Properties.Resources._08;
            this.picProducts.Location = new System.Drawing.Point(12, 14);
            this.picProducts.Name = "picProducts";
            this.picProducts.Size = new System.Drawing.Size(43, 42);
            this.picProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducts.TabIndex = 26;
            this.picProducts.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::MyShop.Properties.Resources.file2;
            this.picHome.Location = new System.Drawing.Point(-2, 448);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(71, 50);
            this.picHome.TabIndex = 30;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // lblMsgBox
            // 
            this.lblMsgBox.BackColor = System.Drawing.Color.Maroon;
            this.lblMsgBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgBox.ForeColor = System.Drawing.Color.White;
            this.lblMsgBox.Location = new System.Drawing.Point(-4, 211);
            this.lblMsgBox.Name = "lblMsgBox";
            this.lblMsgBox.Size = new System.Drawing.Size(905, 74);
            this.lblMsgBox.TabIndex = 33;
            this.lblMsgBox.Text = "--";
            this.lblMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgBox.Visible = false;
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblMsgBox);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picProducts);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AddNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewProduct";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewProduct_KeyDown);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar caln;
        private System.Windows.Forms.TextBox txtFeature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picProducts;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblMsgBox;
        private System.Windows.Forms.MaskedTextBox txtPrice;
    }
}