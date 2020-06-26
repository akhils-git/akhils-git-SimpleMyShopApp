using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop.Classes
{
    public class ThemeService
    {
        List<string> themes = new List<string>();
        string[] colors = new string[6];
        public ThemeService()
        {
            colors[0] = "Blue";
            colors[1] = "Blue";
            colors[2] = "Blue";
            colors[3] = "Blue";
        }
        public static void ActiveTheme(Form frm)
        {
            frm.BackColor = Color.FromName(SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "ActiveTheme"));
            foreach (Control pnlCtrl in frm.Controls)
            {
                if (pnlCtrl.GetType() == typeof(Panel))
                {
                    Panel tempPanel = (Panel)pnlCtrl;
                    foreach (Control item in tempPanel.Controls)
                    {
                        if (item.Tag!="z")
                        {
                            item.BackColor = frm.BackColor;
                            
                        }
                    }
                }
            }
        }
        public static string[] AvailableThemes()
        {
            return SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "Themes").Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        }

        
    }
}
