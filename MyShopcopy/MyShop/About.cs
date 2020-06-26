using MyShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class About : Form
    {
        Image i, i1;
        byte a = 0,waitTimer=15,j1=0;
        string password = SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Login", "Password");
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            lblPassword.BackColor = pnlReset.BackColor;
            txtPassword.BackColor = pnlReset.BackColor;
            pnlReset.Left = this.Width / 2 - pnlReset.Width / 2;
            pnlReset.Top = this.Height / 2 - pnlReset.Height / 2;

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void lblReset_MouseEnter(object sender, EventArgs e)
        {
            picWarning.Visible = true;
            lblResetInfo.Visible = true;
        }

        private void lblReset_MouseLeave(object sender, EventArgs e)
        {
            picWarning.Visible = false;
            lblResetInfo.Visible = false;
        }

        private void picProcess1_MouseMove(object sender, MouseEventArgs e)
        {
            i1 = picProcess1.Image;
            i1.RotateFlip(RotateFlipType.Rotate180FlipX);
            picProcess1.Image = i1;
        }

        private void picProcess1_Click(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            ResetScreenEffect();
           
        }

        private void ResetScreenEffect()
        {
            //System.Media.SystemSounds.Exclamation.Play();
            this.BackColor = Color.Black;
            lblDiv.BackColor = Color.Black;
            lblPassword.BackColor = pnlReset.BackColor;
            txtPassword.BackColor = pnlReset.BackColor;
            lblEsc.BackColor = pnlReset.BackColor;
            pnlAbout.Visible = false;
            pnlMain.Visible = false;
            pnlReset.Visible = true;
            picProcess1.BackColor = pnlReset.BackColor;
            lblReseting.BackColor = pnlReset.BackColor;
            lblWarning2.BackColor = pnlReset.BackColor;
            picWarning2.BackColor = pnlReset.BackColor;
            pnlReset.Left = 311;
            pnlReset.Top = 172;
            picHome.Visible = false;
            tmrResetWait.Enabled = true;
            lblTitle.Text = "Please wait "+Environment.UserName+"...";
            lblTitle.ForeColor = Color.Red;
            //lblTitle.Text = lblTitle.Text + waitTimer + " Sec";
            
        }
        public void Reset()
        {
            string[] tempCustmors = SysRegedit.GetSubKeyNames(MyShopConfigration.Custmors);
            Customer[] custmoers = Customer.ViewCustmoers(MyShopConfigration.Custmors);

            string[] tempBills = SysRegedit.GetSubKeyNames(MyShopConfigration.Bill);

            string[] tempProducts = SysRegedit.GetSubKeyNames(MyShopConfigration.Products);
            Product[] products = Product.ViewProducts(MyShopConfigration.Products);

            try
            {
                for (int i = 0; i < custmoers.Length; i++)
                {
                    SysRegedit.DeleteSubKey(MyShopConfigration.Custmors, tempCustmors[i]);
                }
            }
            catch (Exception)
            { }

            try
            {
                for (int i = 0; i < products.Length; i++)
                {
                    SysRegedit.DeleteSubKey(MyShopConfigration.Products, tempProducts[i]);
                }
            }
            catch (Exception)
            { }


            string[] billId = Bill.LoadId();
            Bill[] bill = new Bill[Bill.TotalBillCount()];
            string[] subKeyNames = SysRegedit.GetSubKeyNames(MyShopConfigration.Bill);
            for (int i = 0; i < bill.Length; i++)
            {
                bill[i] = Bill.ViewBill(billId[i].Remove(billId[i].IndexOf('.')));
                for (int j = 0; j < bill[i].Products.Count; j++)
                {
                    SysRegedit.DeleteSubKey(MyShopConfigration.Bill + "\\" + subKeyNames[i], bill[i].Products[j].Name);
                }
                SysRegedit.DeleteSubKey(MyShopConfigration.Bill, subKeyNames[i]);
            }

            SysRegedit.DeleteSubKey(MyShopConfigration.ProjectName, "Settings");
            SysRegedit.DeleteSubKey(MyShopConfigration.ProjectName, "Login");
            SysRegedit.DeleteSubKey(MyShopConfigration.ProjectName, "Customers");
            SysRegedit.DeleteSubKey(MyShopConfigration.ProjectName, "Products");
            SysRegedit.DeleteSubKey(MyShopConfigration.ProjectName, "Bill");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (password == txtPassword.Text.Trim())
            {
                txtPassword.Visible = false;
                lblPassword.Visible = false;
                picProcess1.Visible = true;
                lblWarning2.Visible = true;
                picWarning2.Visible = true;
                lblEsc.Visible = false;
                tmr.Enabled = true;
                lblTitle.Visible = false;
              //  SysRegedit.ExportKey(Environment.CurrentDirectory + @"\MyShopBackUp_BeforeReset" + DateTime.Now.ToString("dd_MMM") + ".reg", @"HKEY_CURRENT_USER\MyShop");
                tmrResetWait.Enabled = false;
                waitTimer = 15;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            a++;
            i1 = picProcess1.Image;
            i1.RotateFlip(RotateFlipType.Rotate270FlipXY);
            picProcess1.Image = i1;
            if (a == 10)
            {
                Reset();
            }
            else if (a == 30)
            {
                Install install = new Install();
                install.Show();
                this.Close();
            }

        }

        private void lblEsc_Click(object sender, EventArgs e)
        {
            EscResetEffect();
        }

        private void EscResetEffect()
        {
            ThemeService.ActiveTheme(this);
            lblDiv.BackColor = Color.White;
            pnlReset.Visible = false;
            pnlMain.Visible = true;
            pnlAbout.Visible = true;
            txtPassword.Text = "";
            lblTitle.Text = "About App";
            lblTitle.ForeColor = Color.White;
            tmrResetWait.Enabled = false;
            waitTimer = 15;
            picHome.Visible = true;
        }

        private void lblEsc_MouseEnter(object sender, EventArgs e)
        {
            lblEsc.BackColor = Color.Maroon;
        }

        private void lblEsc_MouseLeave(object sender, EventArgs e)
        {
            lblEsc.BackColor = pnlReset.BackColor;
        }

        private void tmrResetWait_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = "Waiting... ";
            lblTitle.Text = lblTitle.Text + waitTimer+" Sec";
            waitTimer--;
            System.Media.SystemSounds.Beep.Play();
            if (waitTimer==0)
            {
                EscResetEffect();
                tmrResetWait.Enabled = false;
            }
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }

        private void picDv1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            if (pic.Name=="picDv1")
            {
                pnlAboutDeveloper.Visible = true;
                lblAboutTitleDv.Text = "About - ";
                lblAboutTitleDv.Text = lblAboutTitleDv.Text + lblDv1.Text;
                tmrChar.Enabled = true;
            }
            else if (pic.Name=="picDv2")
            {
                pnlAboutDeveloper.Visible = true;
                lblAboutTitleDv.Text = "About - ";
                lblAboutTitleDv.Text = lblAboutTitleDv.Text + lblDv2.Text;
                tmrChar.Enabled = true;
            }
        }

        private void lblCloseDv_Click(object sender, EventArgs e)
        {
            pnlAboutDeveloper.Visible = false;
        }

        private void picDv1_MouseLeave(object sender, EventArgs e)
        {
            pnlAboutDeveloper.Visible = false;
            tmrChar.Enabled = false;
            j1 = 0;
            lblAboutNoteDv.Text = "";
        }

        private void tmrChar_Tick(object sender, EventArgs e)
        {
            if (l.Text.Length > j1)
            {
                if (l.Text.Substring(j1, 1) == " ")
                {
                    tmrChar.Interval = 1;
                }
                else
                {
                    tmrChar.Interval = 100;
                }
                lblAboutNoteDv.Text = lblAboutNoteDv.Text + l.Text.Substring(j1, 1);

                j1++;
                if (j1 == l.Text.Length)
                {
                    tmrChar.Enabled = false;
                }
            }
        }

        private void lblDv1_Click(object sender, EventArgs e)
        {

        }

        private void lblDv2_Click(object sender, EventArgs e)
        {

        }

        private void lblAboutNoteDv_Click(object sender, EventArgs e)
        {

        }
    }
}
