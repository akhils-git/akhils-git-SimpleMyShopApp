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
    public partial class LogIn : Form
    {
        bool formAnimationFlg = false;
        public LogIn()
        {
            InitializeComponent();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user = new User(txtUserName.Text, txtPassword.Text);
            if (User.Login(user))
            {
                //MessageBox.Show("Sucess");
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else
            {
                lblInfo.Text = "Thats invalid ! Sorry, try again";
                lblInfo.Visible = true;
            }
        }

       
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (formAnimationFlg == false)
            {
                this.Opacity = this.Opacity + .010;
                this.Top = this.Top - 1;
                if (this.Opacity == 1)
                {
                    formAnimationFlg = true;
                    tmr.Enabled = false;
                }
            }
            if (formAnimationFlg == true)
            {
                this.Opacity = this.Opacity - .03;
                this.Top = this.Top + 1;
                if (this.Opacity == 0)
                {
                    this.Close();
                    tmr.Enabled = false;
                }

            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            lblTitle.Text = MyShopConfigration.ProjectName;
            this.Top = this.Top + 100;
            notifyIcon1.BalloonTipTitle = MyShopConfigration.ProjectName;
            lblTime.Text = DateTime.Now.ToString("t");
            Functions.Notification(notifyIcon1, "Active theme : " + this.BackColor.Name.ToString() + " | System name: " + Environment.MachineName
               + " | Username: " + Environment.UserName + " | Developers: Nithin R Nair, Maheesh M - MCA 2013 - 16 KVVS IT - Adoor", 100);
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == 27)
            //{
            //    formAnimationFlg = true;
            //    tmr.Enabled = true;
            //}
            //else if (e.KeyCode==Keys.F1)
            //{
            //    //About about = new About();
            //    //about.Show();
            //    //this.Close();
            //}
            Functions.Navigation(this, e);
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
        }

        private void LogIn_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Visible = false;

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("t");
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            Image i=picExit.Image;
            i.RotateFlip(RotateFlipType.Rotate180FlipNone);
            picExit.Image = i;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            Image i = picExit.Image;
            i.RotateFlip(RotateFlipType.Rotate180FlipY);
            picExit.Image = i;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            //lblInfo.Text = "Not implimented !";
            //lblInfo.Visible = true;
            pnlRecovery.Visible = true;
          //  pnlLogin.Enabled = false;
        }

        private void lblForgot_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void pnlRecovery_MouseLeave(object sender, EventArgs e)
        {
            //

        }

        private void pnlLogin_MouseEnter(object sender, EventArgs e)
        {
        }

        private void lblRecoveryClose_Click(object sender, EventArgs e)
        {
            pnlRecovery.Visible = false;
        }

        private void lblForgot_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
