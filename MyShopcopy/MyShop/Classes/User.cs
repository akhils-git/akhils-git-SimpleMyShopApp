using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class User
    {
        string Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public static bool Login(User user)
        {
            if (SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Login", "Username")
                == user.UserName && SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Login", "Password") == user.Password)
                return true;
            else
                return false;
        }
        public static bool ChangeUsername(string oldUsername,string newUsername)
        {
            if (SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Login", "Username") == oldUsername)
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Login", "Username", newUsername);
                return true;
            }
            else
                return false;
        }
        public static bool ChangePassword(string oldPassword, string newPassword)
        {
            if (SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Login", "Password") == oldPassword)
            {
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Login", "Password", newPassword);
                return true;
            }
            else
                return false;
        }
    }

}
