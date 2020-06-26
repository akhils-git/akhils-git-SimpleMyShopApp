namespace MyShop
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.tileManageApp = new System.Windows.Forms.Panel();
            this.lblManageApp = new System.Windows.Forms.Label();
            this.tileNewBill = new System.Windows.Forms.Panel();
            this.lblNewBill = new System.Windows.Forms.Label();
            this.tileViewBills = new System.Windows.Forms.Panel();
            this.lblViewBills = new System.Windows.Forms.Label();
            this.tileCustomers = new System.Windows.Forms.Panel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.tileAboutApp = new System.Windows.Forms.Panel();
            this.lblAbout = new System.Windows.Forms.Label();
            this.tileProducts = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.Selectr = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.picSelector = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picHelpInfo = new System.Windows.Forms.PictureBox();
            this.tileLogout = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.tileTheme = new System.Windows.Forms.PictureBox();
            this.picProducts = new System.Windows.Forms.PictureBox();
            this.picAboutApp = new System.Windows.Forms.PictureBox();
            this.picCustomers = new System.Windows.Forms.PictureBox();
            this.picViewBill = new System.Windows.Forms.PictureBox();
            this.picNewBill = new System.Windows.Forms.PictureBox();
            this.picManageApp = new System.Windows.Forms.PictureBox();
            this.tileLogout2 = new System.Windows.Forms.PictureBox();
            this.tileManageApp.SuspendLayout();
            this.tileNewBill.SuspendLayout();
            this.tileViewBills.SuspendLayout();
            this.tileCustomers.SuspendLayout();
            this.tileAboutApp.SuspendLayout();
            this.tileProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLogout2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileManageApp
            // 
            this.tileManageApp.Controls.Add(this.lblManageApp);
            this.tileManageApp.Controls.Add(this.picManageApp);
            this.tileManageApp.Location = new System.Drawing.Point(465, 124);
            this.tileManageApp.Name = "tileManageApp";
            this.tileManageApp.Size = new System.Drawing.Size(120, 110);
            this.tileManageApp.TabIndex = 7;
            this.tileManageApp.MouseEnter += new System.EventHandler(this.tileNewBill_MouseEnter);
            // 
            // lblManageApp
            // 
            this.lblManageApp.AutoSize = true;
            this.lblManageApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageApp.ForeColor = System.Drawing.Color.White;
            this.lblManageApp.Location = new System.Drawing.Point(9, 79);
            this.lblManageApp.Name = "lblManageApp";
            this.lblManageApp.Size = new System.Drawing.Size(98, 21);
            this.lblManageApp.TabIndex = 8;
            this.lblManageApp.Text = "Manage App";
            // 
            // tileNewBill
            // 
            this.tileNewBill.Controls.Add(this.lblNewBill);
            this.tileNewBill.Controls.Add(this.picNewBill);
            this.tileNewBill.Location = new System.Drawing.Point(321, 124);
            this.tileNewBill.Name = "tileNewBill";
            this.tileNewBill.Size = new System.Drawing.Size(120, 110);
            this.tileNewBill.TabIndex = 9;
            this.tileNewBill.Paint += new System.Windows.Forms.PaintEventHandler(this.tileNewBill_Paint);
            this.tileNewBill.MouseEnter += new System.EventHandler(this.tileNewBill_MouseEnter);
            this.tileNewBill.MouseLeave += new System.EventHandler(this.tileNewBill_MouseLeave);
            this.tileNewBill.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tileNewBill_MouseMove);
            // 
            // lblNewBill
            // 
            this.lblNewBill.AutoSize = true;
            this.lblNewBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBill.ForeColor = System.Drawing.Color.White;
            this.lblNewBill.Location = new System.Drawing.Point(26, 79);
            this.lblNewBill.Name = "lblNewBill";
            this.lblNewBill.Size = new System.Drawing.Size(67, 21);
            this.lblNewBill.TabIndex = 8;
            this.lblNewBill.Text = "New Bill";
            this.lblNewBill.MouseEnter += new System.EventHandler(this.lblNewBill_MouseEnter);
            // 
            // tileViewBills
            // 
            this.tileViewBills.Controls.Add(this.lblViewBills);
            this.tileViewBills.Controls.Add(this.picViewBill);
            this.tileViewBills.Location = new System.Drawing.Point(609, 124);
            this.tileViewBills.Name = "tileViewBills";
            this.tileViewBills.Size = new System.Drawing.Size(120, 110);
            this.tileViewBills.TabIndex = 9;
            // 
            // lblViewBills
            // 
            this.lblViewBills.AutoSize = true;
            this.lblViewBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBills.ForeColor = System.Drawing.Color.White;
            this.lblViewBills.Location = new System.Drawing.Point(24, 79);
            this.lblViewBills.Name = "lblViewBills";
            this.lblViewBills.Size = new System.Drawing.Size(76, 21);
            this.lblViewBills.TabIndex = 8;
            this.lblViewBills.Text = "View bills";
            // 
            // tileCustomers
            // 
            this.tileCustomers.Controls.Add(this.lblCustomers);
            this.tileCustomers.Controls.Add(this.picCustomers);
            this.tileCustomers.Location = new System.Drawing.Point(321, 279);
            this.tileCustomers.Name = "tileCustomers";
            this.tileCustomers.Size = new System.Drawing.Size(120, 110);
            this.tileCustomers.TabIndex = 10;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(17, 79);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(85, 21);
            this.lblCustomers.TabIndex = 8;
            this.lblCustomers.Text = "Customers";
            // 
            // tileAboutApp
            // 
            this.tileAboutApp.Controls.Add(this.lblAbout);
            this.tileAboutApp.Controls.Add(this.picAboutApp);
            this.tileAboutApp.Location = new System.Drawing.Point(609, 279);
            this.tileAboutApp.Name = "tileAboutApp";
            this.tileAboutApp.Size = new System.Drawing.Size(120, 110);
            this.tileAboutApp.TabIndex = 11;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(18, 79);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(84, 21);
            this.lblAbout.TabIndex = 8;
            this.lblAbout.Text = "About App";
            // 
            // tileProducts
            // 
            this.tileProducts.Controls.Add(this.lblProducts);
            this.tileProducts.Controls.Add(this.picProducts);
            this.tileProducts.Location = new System.Drawing.Point(465, 279);
            this.tileProducts.Name = "tileProducts";
            this.tileProducts.Size = new System.Drawing.Size(120, 110);
            this.tileProducts.TabIndex = 11;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(27, 79);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(71, 21);
            this.lblProducts.TabIndex = 8;
            this.lblProducts.Text = "Products";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(66, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(129, 54);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Home";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(688, 432);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(212, 74);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "12:52 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 2000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // Selectr
            // 
            this.Selectr.BackColor = System.Drawing.Color.White;
            this.Selectr.Location = new System.Drawing.Point(321, 237);
            this.Selectr.Name = "Selectr";
            this.Selectr.Size = new System.Drawing.Size(120, 5);
            this.Selectr.TabIndex = 17;
            this.Selectr.Visible = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(97, 234);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(175, 85);
            this.lblHelp.TabIndex = 24;
            this.lblHelp.Text = "1. Press Esc exit app.\r\n2. F1 show about.  \r\n3. Press F2 or L Logout.\r\n4. Press F" +
    "3 or H Home\r\n5. Press F12 or P Personalize";
            // 
            // picSelector
            // 
            this.picSelector.Image = global::MyShop.Properties.Resources._110;
            this.picSelector.Location = new System.Drawing.Point(60, 434);
            this.picSelector.Name = "picSelector";
            this.picSelector.Size = new System.Drawing.Size(20, 19);
            this.picSelector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelector.TabIndex = 31;
            this.picSelector.TabStop = false;
            this.picSelector.Visible = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::MyShop.Properties.Resources.file2;
            this.picHome.Location = new System.Drawing.Point(6, 8);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(71, 50);
            this.picHome.TabIndex = 30;
            this.picHome.TabStop = false;
            // 
            // picHelpInfo
            // 
            this.picHelpInfo.Image = global::MyShop.Properties.Resources._19;
            this.picHelpInfo.Location = new System.Drawing.Point(26, 237);
            this.picHelpInfo.Name = "picHelpInfo";
            this.picHelpInfo.Size = new System.Drawing.Size(70, 83);
            this.picHelpInfo.TabIndex = 25;
            this.picHelpInfo.TabStop = false;
            // 
            // tileLogout
            // 
            this.tileLogout.Image = global::MyShop.Properties.Resources._14;
            this.tileLogout.Location = new System.Drawing.Point(803, 13);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(74, 50);
            this.tileLogout.TabIndex = 22;
            this.tileLogout.TabStop = false;
            this.toolTip1.SetToolTip(this.tileLogout, "Log out");
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            this.tileLogout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tileLogout_MouseDown);
            this.tileLogout.MouseEnter += new System.EventHandler(this.tileLogout_MouseEnter);
            this.tileLogout.MouseLeave += new System.EventHandler(this.tileLogout_MouseLeave);
            this.tileLogout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tileLogout_MouseUp);
            // 
            // picExit
            // 
            this.picExit.Image = global::MyShop.Properties.Resources._891;
            this.picExit.Location = new System.Drawing.Point(2, 449);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(39, 50);
            this.picExit.TabIndex = 21;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // tileTheme
            // 
            this.tileTheme.Image = global::MyShop.Properties.Resources._123;
            this.tileTheme.Location = new System.Drawing.Point(48, 449);
            this.tileTheme.Name = "tileTheme";
            this.tileTheme.Size = new System.Drawing.Size(51, 50);
            this.tileTheme.TabIndex = 18;
            this.tileTheme.TabStop = false;
            this.tileTheme.Click += new System.EventHandler(this.tileTheme_Click);
            this.tileTheme.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.tileTheme.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // picProducts
            // 
            this.picProducts.Image = global::MyShop.Properties.Resources._08;
            this.picProducts.Location = new System.Drawing.Point(21, 14);
            this.picProducts.Name = "picProducts";
            this.picProducts.Size = new System.Drawing.Size(66, 62);
            this.picProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProducts.TabIndex = 7;
            this.picProducts.TabStop = false;
            this.picProducts.Click += new System.EventHandler(this.picProducts_Click);
            this.picProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picProducts.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picProducts.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picProducts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // picAboutApp
            // 
            this.picAboutApp.Image = global::MyShop.Properties.Resources._01;
            this.picAboutApp.Location = new System.Drawing.Point(22, 14);
            this.picAboutApp.Name = "picAboutApp";
            this.picAboutApp.Size = new System.Drawing.Size(64, 62);
            this.picAboutApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAboutApp.TabIndex = 7;
            this.picAboutApp.TabStop = false;
            this.picAboutApp.Click += new System.EventHandler(this.picAboutApp_Click);
            this.picAboutApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picAboutApp.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picAboutApp.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picAboutApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // picCustomers
            // 
            this.picCustomers.Image = global::MyShop.Properties.Resources._04;
            this.picCustomers.Location = new System.Drawing.Point(30, 14);
            this.picCustomers.Name = "picCustomers";
            this.picCustomers.Size = new System.Drawing.Size(62, 62);
            this.picCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomers.TabIndex = 7;
            this.picCustomers.TabStop = false;
            this.picCustomers.Click += new System.EventHandler(this.picCustomers_Click);
            this.picCustomers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picCustomers.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picCustomers.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picCustomers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // picViewBill
            // 
            this.picViewBill.Image = global::MyShop.Properties.Resources._03;
            this.picViewBill.Location = new System.Drawing.Point(36, 14);
            this.picViewBill.Name = "picViewBill";
            this.picViewBill.Size = new System.Drawing.Size(45, 62);
            this.picViewBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewBill.TabIndex = 7;
            this.picViewBill.TabStop = false;
            this.picViewBill.Click += new System.EventHandler(this.picViewBill_Click);
            this.picViewBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picViewBill.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picViewBill.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picViewBill.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // picNewBill
            // 
            this.picNewBill.Image = global::MyShop.Properties.Resources._07;
            this.picNewBill.Location = new System.Drawing.Point(25, 14);
            this.picNewBill.Name = "picNewBill";
            this.picNewBill.Size = new System.Drawing.Size(62, 62);
            this.picNewBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewBill.TabIndex = 7;
            this.picNewBill.TabStop = false;
            this.picNewBill.Click += new System.EventHandler(this.picNewBill_Click);
            this.picNewBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picNewBill.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picNewBill.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picNewBill.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // picManageApp
            // 
            this.picManageApp.Image = global::MyShop.Properties.Resources.file;
            this.picManageApp.Location = new System.Drawing.Point(28, 17);
            this.picManageApp.Name = "picManageApp";
            this.picManageApp.Size = new System.Drawing.Size(62, 62);
            this.picManageApp.TabIndex = 7;
            this.picManageApp.TabStop = false;
            this.picManageApp.Click += new System.EventHandler(this.picManageApp_Click);
            this.picManageApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseDown);
            this.picManageApp.MouseEnter += new System.EventHandler(this.picNewBill_MouseEnter);
            this.picManageApp.MouseLeave += new System.EventHandler(this.picNewBill_MouseLeave);
            this.picManageApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNewBill_MouseUp);
            // 
            // tileLogout2
            // 
            this.tileLogout2.Image = global::MyShop.Properties.Resources._15;
            this.tileLogout2.Location = new System.Drawing.Point(803, 12);
            this.tileLogout2.Name = "tileLogout2";
            this.tileLogout2.Size = new System.Drawing.Size(74, 50);
            this.tileLogout2.TabIndex = 23;
            this.tileLogout2.TabStop = false;
            this.toolTip1.SetToolTip(this.tileLogout2, "Log out");
            this.tileLogout2.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.picSelector);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picHelpInfo);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.tileLogout);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.tileTheme);
            this.Controls.Add(this.Selectr);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tileProducts);
            this.Controls.Add(this.tileAboutApp);
            this.Controls.Add(this.tileCustomers);
            this.Controls.Add(this.tileViewBills);
            this.Controls.Add(this.tileNewBill);
            this.Controls.Add(this.tileManageApp);
            this.Controls.Add(this.tileLogout2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.MouseEnter += new System.EventHandler(this.Home_MouseEnter);
            this.tileManageApp.ResumeLayout(false);
            this.tileManageApp.PerformLayout();
            this.tileNewBill.ResumeLayout(false);
            this.tileNewBill.PerformLayout();
            this.tileViewBills.ResumeLayout(false);
            this.tileViewBills.PerformLayout();
            this.tileCustomers.ResumeLayout(false);
            this.tileCustomers.PerformLayout();
            this.tileAboutApp.ResumeLayout(false);
            this.tileAboutApp.PerformLayout();
            this.tileProducts.ResumeLayout(false);
            this.tileProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManageApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileLogout2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tileManageApp;
        private System.Windows.Forms.Label lblManageApp;
        private System.Windows.Forms.PictureBox picManageApp;
        private System.Windows.Forms.Panel tileNewBill;
        private System.Windows.Forms.Label lblNewBill;
        private System.Windows.Forms.PictureBox picNewBill;
        private System.Windows.Forms.Panel tileViewBills;
        private System.Windows.Forms.Label lblViewBills;
        private System.Windows.Forms.PictureBox picViewBill;
        private System.Windows.Forms.Panel tileCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.PictureBox picCustomers;
        private System.Windows.Forms.Panel tileAboutApp;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox picAboutApp;
        private System.Windows.Forms.Panel tileProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.PictureBox picProducts;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label Selectr;
        private System.Windows.Forms.PictureBox tileTheme;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox tileLogout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox tileLogout2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.PictureBox picHelpInfo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picSelector;

    }
}