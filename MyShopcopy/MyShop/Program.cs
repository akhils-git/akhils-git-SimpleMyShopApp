using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // string ss = SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "New");
            if (SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "New")==null ||SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "New")=="")
            {
              
                MyApplicationContext context = new MyApplicationContext(new Install());
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "New", "1");
                Application.Run(context);
                return;
            }
               
            else if(SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "New")=="1")
            {
                MyApplicationContext context = new MyApplicationContext(new LogIn());
                Application.Run(context);
            }
     
        }
        class MyApplicationContext : ApplicationContext
        {
            Form _frm;
            public MyApplicationContext(Form frm)
            {
                _frm = frm;
                _frm.Show();
            }
        }
    }
}
