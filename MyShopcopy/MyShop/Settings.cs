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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text.Trim() == txtConfomUsername.Text.Trim())
            {
                if (User.ChangeUsername(txtUserName.Text.Trim(), txtConfomUsername.Text.Trim()))
                {
                    Functions.MBox(lblMBoxUsername, "Sucessfully changed username", true);
                    Functions.ClearTextBox(pnlChangeUsernamr);
                }
                else
                    Functions.MBox(lblMBoxUsername, "Error username !", false);
            }
            else
            {
                txtConfomUsername.Text = "";
                txtNewUsername.Text = "";
                Functions.MBox(lblMBoxUsername, "New user name note match", false);
            }
        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == txtConformPassword.Text.Trim())
            {
                if (User.ChangePassword(txtPassword.Text.Trim(), txtConformPassword.Text.Trim()))
                {
                    //MessageBox.Show("Sucessfully changed password");
                    Functions.MBox(lblMBoxPassword, "Sucessfully changed password", true);
                    Functions.ClearTextBox(pnlChangePassword);
                }
                else
                    // MessageBox.Show("Error password !");
                    Functions.MBox(lblMBoxPassword, "Error password !", false);
            }
            else
            {
                // MessageBox.Show("New password note match");
                txtNewPassword.Text = "";
                txtConformPassword.Text = "";
                Functions.MBox(lblMBoxPassword, "New password note match !", false);
            }
        }

        private void picChangeUsername_Click(object sender, EventArgs e)
        {
            pnlChangeUsernamr.Left = 300;
            pnlChangeUsernamr.Visible = true;
        }

        private void picChangePassword_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Left = 300;
            pnlChangePassword.Visible = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            ThemeService.ActiveTheme(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void picChangeUsername_MouseDown(object sender, MouseEventArgs e)
        {
            Selectr.BackColor = Color.Black;
        }

        private void picChangeUsername_MouseUp(object sender, MouseEventArgs e)
        {
            Selectr.BackColor = Color.White;
        }

        private void picChangeUsername_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Name == "picChangeUsername")
            {
                Selectr.Left = 340;
                Selectr.Top = 244;

            }
            else if (pic.Name == "picChangePassword")
            {
                Selectr.Left = 482;
                Selectr.Top = 244;
            }
            else if (pic.Name == "picAbout")
            {
                Selectr.Left = 481;
                Selectr.Top = 407;
            }
            else if (pic.Name == "picChangeTheme")
            {
                Selectr.Left = 340;
                Selectr.Top = 407;
            }
            Selectr.Visible = true;
        }

        private void picChangeUsername_MouseLeave(object sender, EventArgs e)
        {
            Selectr.Visible = false;
        }

        private void lblPClose_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = false;
        }

        private void lblUClose_Click(object sender, EventArgs e)
        {
            pnlChangeUsernamr.Visible = false;
        }

        private void picChangeTheme_Click(object sender, EventArgs e)
        {
            AppTheme appTheme = new AppTheme();
            appTheme.Show();
            this.Close();
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }

        private void picExport_Click(object sender, EventArgs e)
        {
            SysRegedit.ExportKey(Environment.CurrentDirectory + @"\MyShopBackUp" + DateTime.Now.ToString("dd_MMM") + ".reg", @"HKEY_CURRENT_USER\MyShop");
            System.Diagnostics.Process.Start("explorer.exe", Environment.CurrentDirectory);

        }

        private void picExport_MouseEnter(object sender, EventArgs e)
        {
            lblBackupInfo.Visible = true;
            picBackupInfo.Visible = true;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnlChangePassword.Visible = false;
            pnlChangeUsernamr.Visible = false;
        }

        private void picExport_MouseLeave(object sender, EventArgs e)
        {
            lblBackupInfo.Visible = false;
            picBackupInfo.Visible = false;
            pnl1.Visible = true;
            pnl2.Visible = true;
            pnl3.Visible = true;
            pnl4.Visible = true;
        }

        private void btnPasswordClear_Click(object sender, EventArgs e)
        {
            Functions.ClearTextBox(pnlChangePassword);
        }

        private void btnPasswordChange_MouseLeave(object sender, EventArgs e)
        {
            lblMBoxPassword.Visible = false;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            lblMBoxUsername.Visible = false;
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }
    }
}
