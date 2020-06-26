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
    public partial class Home : Form
    {
        Image logOut;
        public Home()
        {
            InitializeComponent();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("t");
            lblHelp.Visible = false;
            picHelpInfo.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        
            ThemeService.ActiveTheme(this);
            lblTime.Text = DateTime.Now.ToString("t");
        }

        private void tileNewBill_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void tileNewBill_MouseLeave(object sender, EventArgs e)
        {
            Selectr.Visible = false;
        }

        private void tileNewBill_MouseMove(object sender, MouseEventArgs e)
        {

        }

      

        private void lblNewBill_MouseEnter(object sender, EventArgs e)
        {
            Selectr.Visible = true;
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            Selectr.Visible = false;
        }

        private void tileTheme_Click(object sender, EventArgs e)
        {
       
            AppTheme appTheme = new AppTheme();
            appTheme.Show();
            this.Close();
        
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }

        private void tileNewBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picNewBill_MouseLeave(object sender, EventArgs e)
        {
            Selectr.Visible = false;
        }

        private void picNewBill_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Name=="picNewBill")
            {
                Selectr.Left = 321;
                Selectr.Top = 237;

            }
            else if (pic.Name=="picManageApp")
            {
                 Selectr.Left = 465;
                 Selectr.Top = 237;
            }
            else if (pic.Name == "picViewBill")
            {
                Selectr.Left = 609;
                Selectr.Top = 237;
            }
            else if (pic.Name == "picCustomers")
            {
                Selectr.Left = 321;
                Selectr.Top = 389;
            }
            else if (pic.Name == "picProducts")
            {
                Selectr.Left = 465;
                Selectr.Top = 389;
            }
            else if (pic.Name == "picAboutApp")
            {
                Selectr.Left = 609;
                Selectr.Top = 389;
            }
            Selectr.Visible = true;
        }

        private void picNewBill_MouseDown(object sender, MouseEventArgs e)
        {
            Selectr.BackColor = Color.Black;
        }

        private void picNewBill_MouseUp(object sender, MouseEventArgs e)
        {
            Selectr.BackColor = Color.White;
        }

        private void picManageApp_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            Functions.FormShow(s, this);
        }

        private void picNewBill_Click(object sender, EventArgs e)
        {
            Billing b = new Billing();
            Functions.FormShow(b, this);
        }

        private void picAboutApp_Click(object sender, EventArgs e)
        {
            About a = new About();
            Functions.FormShow(a, this);
        }

        private void picViewBill_Click(object sender, EventArgs e)
        {
            ViewBill vl = new ViewBill();
            Functions.FormShow(vl,this);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Name=="picExit")
            {
                picSelector.Visible = true;
                picSelector.Left = 15;
            }
            else if (pic.Name=="tileTheme")
            {
                 picSelector.Visible = true;
                picSelector.Left = 60;
            }
        }

        private void picProducts_Click(object sender, EventArgs e)
        {
            ViewProduct vp = new ViewProduct();
            Functions.FormShow(vp, this);

        }

        private void picCustomers_Click(object sender, EventArgs e)
        {
            ViewUser vs = new ViewUser();
            Functions.FormShow(vs, this);
        }

        private void tileLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        public void LogOut()
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void tileLogout_MouseEnter(object sender, EventArgs e)
        {
            logOut = tileLogout.Image;
            tileLogout.Image = tileLogout2.Image;
        }

        private void tileLogout_MouseLeave(object sender, EventArgs e)
        {
            tileLogout.Image = logOut;
        }

        private void tileLogout_MouseDown(object sender, MouseEventArgs e)
        {
            tileLogout.Image = logOut;
        }

        private void tileLogout_MouseUp(object sender, MouseEventArgs e)
        {
            logOut = tileLogout.Image;
            tileLogout.Image = tileLogout2.Image;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picSelector.Visible = false;
        }
    }
}
