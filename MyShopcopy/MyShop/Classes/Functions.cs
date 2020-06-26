using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public class Functions
    {
        public static string[] SplitString(string text, string splitText = " ")
        {
            return text.Trim().Split(new string[] { splitText }, StringSplitOptions.RemoveEmptyEntries);
        }
        public static string IDGeneration(string subRoot)
        {
            string[] subKeynames = SysRegedit.GetSubKeyNames(subRoot);
            try
            {
                if (subKeynames.Length == 0 || subKeynames == null)
                {
                    return "0";
                }
            }
            catch (Exception)
            {
                return "0";
            }
            string a = string.Empty;
            for (int i = 0; i < subKeynames.Length; i++)
            {
                a = subKeynames[i].Substring(0, subKeynames[i].IndexOf('.'));
              
            }
            return a;
        }
        public static void Notification(NotifyIcon notifycationIcon, string msg, int delay)
        {
            NotifyIcon notifyIcon1 = new NotifyIcon();
            notifyIcon1 = notifycationIcon;
            notifyIcon1.BalloonTipText = msg;
            notifyIcon1.ShowBalloonTip(delay);
        }
        public static void Navigation(Form activeForm, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H && activeForm.Name != "LogIn" && activeForm.Tag == "k")
            {
                Home home = new Home();
                home.Show();
                activeForm.Close();
            }
            if (e.KeyCode == Keys.F3 && activeForm.Name != "LogIn" )
            {
                Home home = new Home();
                home.Show();
                activeForm.Close();
            }
            else if (e.KeyCode == Keys.L && activeForm.Name != "LogIn" && activeForm.Tag=="k")
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                activeForm.Close();
            }
            else if (e.KeyCode == Keys.F2 && activeForm.Name != "LogIn" )
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                activeForm.Close();
            }
            else if (e.KeyCode == Keys.F12 && activeForm.Name != "LogIn")
            {
                AppTheme appTheme = new AppTheme();
                appTheme.Show();
                activeForm.Close();
            }
            else if (e.KeyCode==Keys.Escape)
            {
                Environment.Exit(0);
            }
            

        }
        //public static void ClearTextBox(Form from)
        //{
        //    foreach (var item in from.Controls)
        //    {
        //        if (item.GetType() == typeof(TextBox))
        //        {
        //            TextBox textBox = (TextBox)item;
        //            textBox.Text = "";//9946
        //        }
        //    }
        //}
        public static int BuildBillNo()
        {
            int a = 0;
            if (SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "BillNo") != "")
            {
                a = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.ProjectName, "Settings", "BillNo"));
                a++;
                SysRegedit.SaveReg(MyShopConfigration.ProjectName, "Settings", "BillNo", a.ToString());
            }
            return a;

        }
        public static bool CheckUserText(string userText)
        {
            char[] charCollection = new char[31];
            bool b = true;
            charCollection[0] = ','; charCollection[1] = '<'; charCollection[2] = '.'; charCollection[3] = '>'; charCollection[4] = '/'; charCollection[5] = '?';
            charCollection[6] = ';'; charCollection[7] = ':'; charCollection[8] = '"'; charCollection[9] = '['; charCollection[10] = ']'; charCollection[11] = '{'; charCollection[12] = '}';
            charCollection[13] = '\\'; charCollection[14] = '|'; charCollection[15] = '='; charCollection[16] = '+'; charCollection[17] = '-'; charCollection[18] = '_'; charCollection[19] = '('; charCollection[20] = ')';
            charCollection[21] = '*'; charCollection[22] = '&'; charCollection[23] = '^'; charCollection[24] = '%'; charCollection[25] = '$'; charCollection[26] = '#'; charCollection[27] = '@'; charCollection[28] = '!';
            charCollection[29] = '`'; charCollection[30] = '~';
            List<char> userChar = new List<char>();
            char a;
            for (int i = 0; i < userText.Length; i++)
            {
                a = Convert.ToChar(userText.Substring(i, 1));
                userChar.Add(a);
            }
            if (b == true)
            {

                for (int i = 0; i < userChar.Count; i++)
                {
                    for (int j = 0; j < charCollection.Length; j++)
                    {
                        if (charCollection[j] == userChar[i])
                            b = false;
                    }
                }
            }
            return b;
        }
        public static bool CheckUserNumber(string userText)
        {
            char[] charCollection = new char[12];
            bool b = false;
            charCollection[0] = '0'; charCollection[1] = '1'; charCollection[2] = '2'; charCollection[3] = '3'; charCollection[4] = '4'; charCollection[5] = '5';
            charCollection[6] = '6'; charCollection[7] = '7'; charCollection[8] = '8'; charCollection[9] = '9'; charCollection[10] = '.';
            List<char> userChar = new List<char>();
            char a;
            for (int i = 0; i < userText.Length; i++)
            {
                a = Convert.ToChar(userText.Substring(i, 1));
                userChar.Add(a);
            }
            if (b == false)
            {

                for (int i = 0; i < userChar.Count; i++)
                {
                    for (int j = 0; j < charCollection.Length; j++)
                    {
                        if (charCollection[j] != userChar[i])
                            b = true;
                    }
                }
            }
            return b;
        }
        public static void ClearTextBox(Panel panal)
        {
            foreach (Control control in panal.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    control.Text = "";
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    control.Text = "";
                }
            }

        }
        public static void FormShow(Form newForm, Form closeForm)
        {
            newForm.Show();
            closeForm.Close();
        }
        public static void MBox(Label msgLabel, string message, bool color)
        {
            msgLabel.Text = message;
            msgLabel.Visible = true;
            if (color == true)
            {
                msgLabel.BackColor = Color.Black;
                msgLabel.ForeColor = Color.White;
            }
            else if (color == false)
            {
                msgLabel.BackColor = Color.Red;
                msgLabel.ForeColor = Color.White;
            }
        }
    }
}
