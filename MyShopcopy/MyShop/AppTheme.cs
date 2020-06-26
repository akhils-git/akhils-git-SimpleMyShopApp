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
    public partial class AppTheme : Form
    {
        string[] themes = new string[4];
        string activeTheme;
        public AppTheme()
        {
            InitializeComponent();
        }
        //public AppTheme(Form prev)
        //{
        //   // prev.Close();
        //}
        private void lblColor1_MouseEnter(object sender, EventArgs e)
        {
            lblColor1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void AppTheme_Load(object sender, EventArgs e)
        {
          
           
            themes = ThemeService.AvailableThemes();
            ThemeService.ActiveTheme(this);

            lblColor1.BackColor = Color.FromName(themes[0]);
            lblColor2.BackColor = Color.FromName(themes[1]);
            lblColor3.BackColor = Color.FromName(themes[2]);
            lblColor4.BackColor = Color.FromName(themes[3]);
            lblColor5.BackColor = Color.FromName(themes[4]);
            lblColor6.BackColor = Color.FromName(themes[5]);

           //  Home.ActiveForm.Close();

            foreach (Label control in this.pnlThemeList.Controls)
            {

                Label lbl = (Label)control;
                if (this.BackColor == control.BackColor && control.Tag=="z")
                {

                    control.BorderStyle = BorderStyle.Fixed3D;
                    control.Text = "Active Theme";
                    lblColorName.Text = this.BackColor.Name;
                    lblColorName.BorderStyle = BorderStyle.None;
                }
                else
                {
                    control.Text = "";
                }

            }


        }

        private void lblColor1_Click(object sender, EventArgs e)
        {

        }

        private void lblColor1_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if (lbl.Name == "lblColor1")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }
            else if (lbl.Name == "lblColor2")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }
            else if (lbl.Name == "lblColor3")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }
            else if (lbl.Name == "lblColor4")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }
            else if (lbl.Name == "lblColor5")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }
            else if (lbl.Name == "lblColor6")
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme", lbl.BackColor.Name);
            }

            ThemeService.ActiveTheme(this);

            foreach (Label control in this.pnlThemeList.Controls)
            {

               // Label lbl1 = (Label)control;
                if (this.BackColor == control.BackColor)
                {

                    control.BorderStyle = BorderStyle.Fixed3D;
                   control.Text = "Active Theme";

                }
                else
                {
                    control.BorderStyle = BorderStyle.None;
                    control.Text = "";
                }

            }
            lblColorName.BorderStyle = BorderStyle.None;
            lblColorName.Text = this.BackColor.Name;

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void AppTheme_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }
    }
}
