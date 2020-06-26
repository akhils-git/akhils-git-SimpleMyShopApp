namespace MyShop
{
    partial class Billing
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
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.comUser = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtQuntity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comProduct = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.Company = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlProductList = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProductsId = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.sds = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataListProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picViewBill = new System.Windows.Forms.PictureBox();
            this.lblMsgBox = new System.Windows.Forms.Label();
            this.pnlCustomers.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Controls.Add(this.comUser);
            this.pnlCustomers.Controls.Add(this.txtEmail);
            this.pnlCustomers.Controls.Add(this.label5);
            this.pnlCustomers.Controls.Add(this.txtMobile);
            this.pnlCustomers.Controls.Add(this.label4);
            this.pnlCustomers.Controls.Add(this.txtPIN);
            this.pnlCustomers.Controls.Add(this.label3);
            this.pnlCustomers.Controls.Add(this.txtAddress);
            this.pnlCustomers.Controls.Add(this.label2);
            this.pnlCustomers.Controls.Add(this.label1);
            this.pnlCustomers.Location = new System.Drawing.Point(24, 65);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(320, 305);
            this.pnlCustomers.TabIndex = 13;
            // 
            // comUser
            // 
            this.comUser.BackColor = System.Drawing.Color.Green;
            this.comUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comUser.ForeColor = System.Drawing.Color.White;
            this.comUser.FormattingEnabled = true;
            this.comUser.Location = new System.Drawing.Point(92, 20);
            this.comUser.Name = "comUser";
            this.comUser.Size = new System.Drawing.Size(191, 21);
            this.comUser.TabIndex = 24;
            this.comUser.SelectedIndexChanged += new System.EventHandler(this.comUser_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Green;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(92, 265);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.Green;
            this.txtMobile.ForeColor = System.Drawing.Color.White;
            this.txtMobile.Location = new System.Drawing.Point(92, 227);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(191, 20);
            this.txtMobile.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mobile";
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.Color.Green;
            this.txtPIN.ForeColor = System.Drawing.Color.White;
            this.txtPIN.Location = new System.Drawing.Point(92, 188);
            this.txtPIN.MaxLength = 6;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(191, 20);
            this.txtPIN.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PIN";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Green;
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(92, 62);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(191, 108);
            this.txtAddress.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.lblAvailable);
            this.pnlProducts.Controls.Add(this.txtQuntity);
            this.pnlProducts.Controls.Add(this.label7);
            this.pnlProducts.Controls.Add(this.txtFeature);
            this.pnlProducts.Controls.Add(this.label6);
            this.pnlProducts.Controls.Add(this.txtMDate);
            this.pnlProducts.Controls.Add(this.label8);
            this.pnlProducts.Controls.Add(this.txtEDate);
            this.pnlProducts.Controls.Add(this.label9);
            this.pnlProducts.Controls.Add(this.txtPrice);
            this.pnlProducts.Controls.Add(this.label11);
            this.pnlProducts.Controls.Add(this.comProduct);
            this.pnlProducts.Controls.Add(this.button1);
            this.pnlProducts.Controls.Add(this.btnAdd);
            this.pnlProducts.Controls.Add(this.txtCompany);
            this.pnlProducts.Controls.Add(this.Company);
            this.pnlProducts.Controls.Add(this.label10);
            this.pnlProducts.Location = new System.Drawing.Point(409, 12);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(430, 358);
            this.pnlProducts.TabIndex = 14;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.White;
            this.lblAvailable.Location = new System.Drawing.Point(351, 292);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(65, 13);
            this.lblAvailable.TabIndex = 39;
            this.lblAvailable.Text = "0 Available !";
            this.lblAvailable.Visible = false;
            // 
            // txtQuntity
            // 
            this.txtQuntity.ForeColor = System.Drawing.Color.White;
            this.txtQuntity.Location = new System.Drawing.Point(154, 292);
            this.txtQuntity.Name = "txtQuntity";
            this.txtQuntity.Size = new System.Drawing.Size(191, 20);
            this.txtQuntity.TabIndex = 38;
            this.txtQuntity.Tag = "MDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Quntity";
            // 
            // txtFeature
            // 
            this.txtFeature.ForeColor = System.Drawing.Color.White;
            this.txtFeature.Location = new System.Drawing.Point(154, 249);
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(191, 20);
            this.txtFeature.TabIndex = 36;
            this.txtFeature.Tag = "MDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Features";
            // 
            // txtMDate
            // 
            this.txtMDate.ForeColor = System.Drawing.Color.White;
            this.txtMDate.Location = new System.Drawing.Point(154, 211);
            this.txtMDate.Name = "txtMDate";
            this.txtMDate.Size = new System.Drawing.Size(191, 20);
            this.txtMDate.TabIndex = 34;
            this.txtMDate.Tag = "MDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Manufacting Date";
            // 
            // txtEDate
            // 
            this.txtEDate.ForeColor = System.Drawing.Color.White;
            this.txtEDate.Location = new System.Drawing.Point(154, 172);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Size = new System.Drawing.Size(191, 20);
            this.txtEDate.TabIndex = 32;
            this.txtEDate.Tag = "EDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Expare Date";
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(154, 137);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Price";
            // 
            // comProduct
            // 
            this.comProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comProduct.ForeColor = System.Drawing.Color.White;
            this.comProduct.FormattingEnabled = true;
            this.comProduct.Location = new System.Drawing.Point(154, 52);
            this.comProduct.Name = "comProduct";
            this.comProduct.Size = new System.Drawing.Size(191, 21);
            this.comProduct.TabIndex = 24;
            this.comProduct.SelectedIndexChanged += new System.EventHandler(this.comProduct_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(181, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(271, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(154, 98);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(191, 30);
            this.txtCompany.TabIndex = 15;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.ForeColor = System.Drawing.Color.White;
            this.Company.Location = new System.Drawing.Point(46, 105);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(51, 13);
            this.Company.TabIndex = 14;
            this.Company.Text = "Company";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Product Name";
            // 
            // pnlProductList
            // 
            this.pnlProductList.Controls.Add(this.btnClear);
            this.pnlProductList.Controls.Add(this.label13);
            this.pnlProductList.Controls.Add(this.txtProductsId);
            this.pnlProductList.Controls.Add(this.btnDeleteItem);
            this.pnlProductList.Controls.Add(this.lblTotalAmount);
            this.pnlProductList.Controls.Add(this.lblTotalItems);
            this.pnlProductList.Controls.Add(this.sds);
            this.pnlProductList.Controls.Add(this.label12);
            this.pnlProductList.Controls.Add(this.btnSubmit);
            this.pnlProductList.Controls.Add(this.dataListProducts);
            this.pnlProductList.Location = new System.Drawing.Point(24, 385);
            this.pnlProductList.Name = "pnlProductList";
            this.pnlProductList.Size = new System.Drawing.Size(815, 275);
            this.pnlProductList.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(645, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(395, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Enter ID";
            // 
            // txtProductsId
            // 
            this.txtProductsId.Location = new System.Drawing.Point(447, 240);
            this.txtProductsId.Name = "txtProductsId";
            this.txtProductsId.Size = new System.Drawing.Size(45, 20);
            this.txtProductsId.TabIndex = 30;
            this.txtProductsId.Visible = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(498, 237);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(59, 23);
            this.btnDeleteItem.TabIndex = 29;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Visible = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(660, 50);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAmount.TabIndex = 27;
            this.lblTotalAmount.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(660, 16);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(13, 13);
            this.lblTotalItems.TabIndex = 26;
            this.lblTotalItems.Text = "0";
            // 
            // sds
            // 
            this.sds.AutoSize = true;
            this.sds.ForeColor = System.Drawing.Color.White;
            this.sds.Location = new System.Drawing.Point(582, 50);
            this.sds.Name = "sds";
            this.sds.Size = new System.Drawing.Size(70, 13);
            this.sds.TabIndex = 25;
            this.sds.Text = "Total Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(582, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total Items";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(726, 237);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // dataListProducts
            // 
            this.dataListProducts.BackgroundColor = System.Drawing.Color.Green;
            this.dataListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataListProducts.GridColor = System.Drawing.Color.LightGreen;
            this.dataListProducts.Location = new System.Drawing.Point(16, 16);
            this.dataListProducts.Name = "dataListProducts";
            this.dataListProducts.Size = new System.Drawing.Size(541, 218);
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
            this.picHome.Location = new System.Drawing.Point(0, 615);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(71, 50);
            this.picHome.TabIndex = 31;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(53, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(291, 59);
            this.lblInfo.TabIndex = 32;
            this.lblInfo.Text = "Billing";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picViewBill
            // 
            this.picViewBill.Image = global::MyShop.Properties.Resources._03;
            this.picViewBill.Location = new System.Drawing.Point(19, 12);
            this.picViewBill.Name = "picViewBill";
            this.picViewBill.Size = new System.Drawing.Size(34, 44);
            this.picViewBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewBill.TabIndex = 33;
            this.picViewBill.TabStop = false;
            // 
            // lblMsgBox
            // 
            this.lblMsgBox.BackColor = System.Drawing.Color.Maroon;
            this.lblMsgBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgBox.ForeColor = System.Drawing.Color.White;
            this.lblMsgBox.Location = new System.Drawing.Point(-2, 295);
            this.lblMsgBox.Name = "lblMsgBox";
            this.lblMsgBox.Size = new System.Drawing.Size(905, 74);
            this.lblMsgBox.TabIndex = 34;
            this.lblMsgBox.Text = "--";
            this.lblMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgBox.Visible = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(900, 664);
            this.Controls.Add(this.lblMsgBox);
            this.Controls.Add(this.picViewBill);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.pnlProductList);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.pnlProductList.ResumeLayout(false);
            this.pnlProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comUser;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.ComboBox comProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFeature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlProductList;
        private System.Windows.Forms.DataGridView dataListProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label sds;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox txtProductsId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picViewBill;
        private System.Windows.Forms.Label lblMsgBox;
    }
}