using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class Install : Form
    {
        byte a = 0,b=0;
        bool c = false;
        Image tempGo;
        PerformanceCounter cpu = new PerformanceCounter();
        PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");
        public Install()
        {
            InitializeComponent();
            cpu.CategoryName = "Processor";
            cpu.CounterName = "% Processor Time";
            cpu.InstanceName = "_Total";
        }
        private void Install_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = MyShopConfigration.ProjectName;
            lblInfo.Text ="Please wait " +  Environment.UserName+" ☺ Getting things ready..." ;
            Functions.Notification(notifyIcon1, "Welcome to " + MyShopConfigration.ProjectName + " configration",200);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (c==false)
            {
                a++;
                lblPBar.Width = lblPBar.Width + 1;
                if (a == 5)
                {

                    picProcess.Image = picData1.Image;
                    picProcess1.Image = picData1.Image;

                }
                else if (a == 10)
                {
                    picProcess.Image = picData2.Image;
                    picProcess1.Image = picData2.Image;

                }
                else if (a == 12)
                {
                    a = 1;

                }
                if (lblPBar.Width == 736)
                {
                   // tmr.Enabled = false;
                    lblPBar.Visible = false;
                    lblInfo.Visible = false;
                    picProcess1.Visible = false;
                    picProcess.Visible = false;
                    lblMessage.Top = lblMessage.Top - 40;
                    lblMessage.Left = lblMessage.Left - 90;
                    lblCPU.Visible = false;
                    lblRAM.Visible = false;
                    lblMessage.Text = Environment.UserName + " Let's start...";

                    c = true;
                    lblTime.Visible = true;
                    
                    picGo.Visible = true;
                } 
            }
            lblTime.Text = DateTime.Now.ToString("hh:mm");
        }

        private void picProcess1_Click(object sender, EventArgs e)
        {

        }

        private void picProcess_Click(object sender, EventArgs e)
        {

        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {

        }

        private void tmrMain_Tick_1(object sender, EventArgs e)
        {
            b++;
            if (b == 10)
            {
                lblMachineName.Visible = true;
                lblMachineName.Text =lblMachineName.Text+"  " +Environment.MachineName;
            }
            else if (b == 20)
            {
                lblOSBuild.Visible = true;
                lblOSBuild.Text = lblOSBuild.Text + "  "+Environment.OSVersion.ToString();

            }
            else if (b == 30)
            {
                lblProcesserCount.Visible = true;
                lblProcesserCount.Text = lblProcesserCount.Text + "  "+Environment.ProcessorCount.ToString()+" only.";


            }
            else if (b == 40)
            {
                lblSysPageSize.Visible = true;
                lblSysPageSize.Text = lblSysPageSize.Text + "  "+Environment.ProcessorCount.ToString()+" only.";


            }
            else if (b == 45)
            {
                pnlSysChek.Visible = false;
                lblMessage.Visible = true;
            }
            else if (b == 60)
            {
                lblMessage.Text = "Installing " + MyShopConfigration.ProjectName + " components.";
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "Themes", MyShopConfigration.Themes);
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", MyShopConfigration.ActiveTheme);
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Login", "Username", MyShopConfigration.Username);
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Login", "Password", MyShopConfigration.Password);
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "New", "1");
            }
            else if (b == 80)
            {
                lblMessage.Text = "All most done, plese wait...";
            }
          //  ColorCharge();
        }

        private void picGo_MouseEnter(object sender, EventArgs e)
        {
            tempGo = picGo.Image;
            picGo.Image = picGo1.Image;
            lblMessage.Text = "Click to go...";
        }

        private void picGo_MouseLeave(object sender, EventArgs e)
        {
            picGo.Image = tempGo;
            lblMessage.Text = Environment.UserName + " Let's start...";
        }

        private void picGo_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void tnrSys_Tick(object sender, EventArgs e)
        {
            try
            {
                lblRAM.Text = "RAM : ";
                lblCPU.Text = "CPU : " + Convert.ToInt16(cpu.NextValue()).ToString() + " %";
                lblRAM.Text = "RAM : " + (Convert.ToDecimal(ram.NextValue()) / 1024).ToString().Remove(4) + " GB";
            }
            catch (Exception)
            { }
        }

      
    }
}
