namespace MyShop
{
    partial class Install
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Install));
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.lblInfoMain = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblMachineName = new System.Windows.Forms.Label();
            this.pnlSysChek = new System.Windows.Forms.Panel();
            this.lblSysPageSize = new System.Windows.Forms.Label();
            this.lblProcesserCount = new System.Windows.Forms.Label();
            this.lblOSBuild = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPBar = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picGo = new System.Windows.Forms.PictureBox();
            this.picGo1 = new System.Windows.Forms.PictureBox();
            this.picProcess1 = new System.Windows.Forms.PictureBox();
            this.picData2 = new System.Windows.Forms.PictureBox();
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.picData1 = new System.Windows.Forms.PictureBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.tnrSys = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlSysChek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(597, 163);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Get things ready...";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 30;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // lblInfoMain
            // 
            this.lblInfoMain.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMain.ForeColor = System.Drawing.Color.White;
            this.lblInfoMain.Location = new System.Drawing.Point(291, 215);
            this.lblInfoMain.Name = "lblInfoMain";
            this.lblInfoMain.Size = new System.Drawing.Size(597, 112);
            this.lblInfoMain.TabIndex = 5;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 200;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick_1);
            // 
            // lblMachineName
            // 
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.ForeColor = System.Drawing.Color.White;
            this.lblMachineName.Location = new System.Drawing.Point(31, 26);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(492, 27);
            this.lblMachineName.TabIndex = 6;
            this.lblMachineName.Text = "Machine name";
            this.lblMachineName.Visible = false;
            // 
            // pnlSysChek
            // 
            this.pnlSysChek.Controls.Add(this.lblSysPageSize);
            this.pnlSysChek.Controls.Add(this.lblProcesserCount);
            this.pnlSysChek.Controls.Add(this.lblOSBuild);
            this.pnlSysChek.Controls.Add(this.lblMachineName);
            this.pnlSysChek.Location = new System.Drawing.Point(279, 145);
            this.pnlSysChek.Name = "pnlSysChek";
            this.pnlSysChek.Size = new System.Drawing.Size(587, 240);
            this.pnlSysChek.TabIndex = 7;
            // 
            // lblSysPageSize
            // 
            this.lblSysPageSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysPageSize.ForeColor = System.Drawing.Color.White;
            this.lblSysPageSize.Location = new System.Drawing.Point(31, 155);
            this.lblSysPageSize.Name = "lblSysPageSize";
            this.lblSysPageSize.Size = new System.Drawing.Size(492, 27);
            this.lblSysPageSize.TabIndex = 9;
            this.lblSysPageSize.Text = "System page size";
            this.lblSysPageSize.Visible = false;
            // 
            // lblProcesserCount
            // 
            this.lblProcesserCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesserCount.ForeColor = System.Drawing.Color.White;
            this.lblProcesserCount.Location = new System.Drawing.Point(31, 112);
            this.lblProcesserCount.Name = "lblProcesserCount";
            this.lblProcesserCount.Size = new System.Drawing.Size(492, 27);
            this.lblProcesserCount.TabIndex = 8;
            this.lblProcesserCount.Text = "Processor Count";
            this.lblProcesserCount.Visible = false;
            // 
            // lblOSBuild
            // 
            this.lblOSBuild.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSBuild.ForeColor = System.Drawing.Color.White;
            this.lblOSBuild.Location = new System.Drawing.Point(31, 69);
            this.lblOSBuild.Name = "lblOSBuild";
            this.lblOSBuild.Size = new System.Drawing.Size(492, 27);
            this.lblOSBuild.TabIndex = 7;
            this.lblOSBuild.Text = "OS Core build  ";
            this.lblOSBuild.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(333, 264);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(492, 36);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Okey, thats batter confirmation";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // lblPBar
            // 
            this.lblPBar.BackColor = System.Drawing.Color.White;
            this.lblPBar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPBar.ForeColor = System.Drawing.Color.White;
            this.lblPBar.Location = new System.Drawing.Point(24, 460);
            this.lblPBar.Name = "lblPBar";
            this.lblPBar.Size = new System.Drawing.Size(21, 17);
            this.lblPBar.TabIndex = 11;
            this.lblPBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1, 421);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(225, 74);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "12:52";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Visible = false;
            // 
            // picGo
            // 
            this.picGo.Image = global::MyShop.Properties.Resources._22;
            this.picGo.Location = new System.Drawing.Point(759, 411);
            this.picGo.Name = "picGo";
            this.picGo.Size = new System.Drawing.Size(107, 67);
            this.picGo.TabIndex = 14;
            this.picGo.TabStop = false;
            this.picGo.Visible = false;
            this.picGo.Click += new System.EventHandler(this.picGo_Click);
            this.picGo.MouseEnter += new System.EventHandler(this.picGo_MouseEnter);
            this.picGo.MouseLeave += new System.EventHandler(this.picGo_MouseLeave);
            // 
            // picGo1
            // 
            this.picGo1.Image = global::MyShop.Properties.Resources._111;
            this.picGo1.Location = new System.Drawing.Point(12, 411);
            this.picGo1.Name = "picGo1";
            this.picGo1.Size = new System.Drawing.Size(107, 67);
            this.picGo1.TabIndex = 12;
            this.picGo1.TabStop = false;
            this.picGo1.Visible = false;
            // 
            // picProcess1
            // 
            this.picProcess1.Image = global::MyShop.Properties.Resources._11;
            this.picProcess1.Location = new System.Drawing.Point(158, 277);
            this.picProcess1.Name = "picProcess1";
            this.picProcess1.Size = new System.Drawing.Size(73, 76);
            this.picProcess1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcess1.TabIndex = 4;
            this.picProcess1.TabStop = false;
            this.picProcess1.Click += new System.EventHandler(this.picProcess1_Click);
            // 
            // picData2
            // 
            this.picData2.Image = global::MyShop.Properties.Resources._11;
            this.picData2.Location = new System.Drawing.Point(-122, 468);
            this.picData2.Name = "picData2";
            this.picData2.Size = new System.Drawing.Size(164, 163);
            this.picData2.TabIndex = 3;
            this.picData2.TabStop = false;
            this.picData2.Visible = false;
            // 
            // picProcess
            // 
            this.picProcess.Image = global::MyShop.Properties.Resources._11;
            this.picProcess.Location = new System.Drawing.Point(66, 171);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(116, 118);
            this.picProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProcess.TabIndex = 2;
            this.picProcess.TabStop = false;
            this.picProcess.Click += new System.EventHandler(this.picProcess_Click);
            // 
            // picData1
            // 
            this.picData1.Image = global::MyShop.Properties.Resources._09;
            this.picData1.Location = new System.Drawing.Point(-112, 468);
            this.picData1.Name = "picData1";
            this.picData1.Size = new System.Drawing.Size(164, 163);
            this.picData1.TabIndex = 1;
            this.picData1.TabStop = false;
            this.picData1.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(80, 302);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(102, 19);
            this.lblCPU.TabIndex = 15;
            this.lblCPU.Text = "CPU : 0 %";
            // 
            // lblRAM
            // 
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.White;
            this.lblRAM.Location = new System.Drawing.Point(145, 366);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(98, 19);
            this.lblRAM.TabIndex = 16;
            this.lblRAM.Text = "RAM : 0.0 GB";
            // 
            // tnrSys
            // 
            this.tnrSys.Enabled = true;
            this.tnrSys.Interval = 1000;
            this.tnrSys.Tick += new System.EventHandler(this.tnrSys_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "In Process";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.picProcess1);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.picGo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picGo1);
            this.Controls.Add(this.lblPBar);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlSysChek);
            this.Controls.Add(this.lblInfoMain);
            this.Controls.Add(this.picData2);
            this.Controls.Add(this.picProcess);
            this.Controls.Add(this.picData1);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Install";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstallMyShop";
            this.Load += new System.EventHandler(this.Install_Load);
            this.pnlSysChek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picData1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picData1;
        private System.Windows.Forms.PictureBox picProcess;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox picData2;
        private System.Windows.Forms.PictureBox picProcess1;
        private System.Windows.Forms.Label lblInfoMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Panel pnlSysChek;
        private System.Windows.Forms.Label lblProcesserCount;
        private System.Windows.Forms.Label lblOSBuild;
        private System.Windows.Forms.Label lblSysPageSize;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPBar;
        private System.Windows.Forms.PictureBox picGo1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picGo;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Timer tnrSys;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}