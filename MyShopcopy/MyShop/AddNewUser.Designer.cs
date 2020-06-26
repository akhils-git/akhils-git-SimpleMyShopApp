namespace MyShop
{
    partial class AddNewUser
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
            this.txtPIN = new System.Windows.Forms.MaskedTextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picCustomers = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lblMsgBox = new System.Windows.Forms.Label();
            this.pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomers.Controls.Add(this.txtPIN);
            this.pnlCustomers.Controls.Add(this.txtMobile);
            this.pnlCustomers.Controls.Add(this.btnClear);
            this.pnlCustomers.Controls.Add(this.btnSave);
            this.pnlCustomers.Controls.Add(this.txtEmail);
            this.pnlCustomers.Controls.Add(this.label5);
            this.pnlCustomers.Controls.Add(this.label4);
            this.pnlCustomers.Controls.Add(this.label3);
            this.pnlCustomers.Controls.Add(this.txtCompany);
            this.pnlCustomers.Controls.Add(this.label2);
            this.pnlCustomers.Controls.Add(this.txtName);
            this.pnlCustomers.Controls.Add(this.label1);
            this.pnlCustomers.Location = new System.Drawing.Point(313, 82);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(321, 372);
            this.pnlCustomers.TabIndex = 12;
            // 
            // txtPIN
            // 
            this.txtPIN.ForeColor = System.Drawing.Color.White;
            this.txtPIN.Location = new System.Drawing.Point(95, 213);
            this.txtPIN.Mask = "000999";
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(191, 20);
            this.txtPIN.TabIndex = 2;
            // 
            // txtMobile
            // 
            this.txtMobile.ForeColor = System.Drawing.Color.White;
            this.txtMobile.Location = new System.Drawing.Point(95, 250);
            this.txtMobile.Mask = "9990000000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(191, 20);
            this.txtMobile.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(211, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Green;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(95, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PIN";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.Green;
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(95, 70);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(191, 108);
            this.txtCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Green;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(95, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(69, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(323, 74);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Add new customer";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCustomers
            // 
            this.picCustomers.Image = global::MyShop.Properties.Resources._04;
            this.picCustomers.Location = new System.Drawing.Point(12, 21);
            this.picCustomers.Name = "picCustomers";
            this.picCustomers.Size = new System.Drawing.Size(51, 48);
            this.picCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomers.TabIndex = 25;
            this.picCustomers.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::MyShop.Properties.Resources.file2;
            this.picHome.Location = new System.Drawing.Point(3, 448);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(71, 50);
            this.picHome.TabIndex = 29;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // lblMsgBox
            // 
            this.lblMsgBox.BackColor = System.Drawing.Color.Maroon;
            this.lblMsgBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgBox.ForeColor = System.Drawing.Color.White;
            this.lblMsgBox.Location = new System.Drawing.Point(-5, 218);
            this.lblMsgBox.Name = "lblMsgBox";
            this.lblMsgBox.Size = new System.Drawing.Size(905, 74);
            this.lblMsgBox.TabIndex = 32;
            this.lblMsgBox.Text = "--";
            this.lblMsgBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgBox.Visible = false;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblMsgBox);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picCustomers);
            this.Controls.Add(this.pnlCustomers);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new user !";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNewUser_KeyDown);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picCustomers;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.Label lblMsgBox;
        private System.Windows.Forms.MaskedTextBox txtPIN;

    }
}