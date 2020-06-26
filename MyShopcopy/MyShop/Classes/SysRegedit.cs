using EncryptStringSample;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    class SysRegedit
    {

        public static void SaveReg(string Title, string subTitle, string keyName, string keyValue) //Save a value to Reg
        {
            //Title = EncryptionDecryption.Encrypt(Title, "9946");
            //subTitle = EncryptionDecryption.Encrypt(subTitle, "9946");
            //keyName = EncryptionDecryption.Encrypt(keyName, "9946");
            keyValue = EncryptionDecryption.Encrypt(keyValue, MyShopConfigration.EncyKey);

            RegistryKey Test = Registry.CurrentUser.CreateSubKey(Title + "\\" + subTitle);
            Test.SetValue(keyName, keyValue);
            Test.Close();
        }

        public static string ReadReg(string Title, string subTitle, string keyName)//Read a value to Reg
        {
            //Title = EncryptionDecryption.Encrypt(Title, "9946");
            //subTitle = EncryptionDecryption.Encrypt(subTitle, "9946");
            //keyName = EncryptionDecryption.Encrypt(keyName, "9946");

            string t;
            RegistryKey Test = Registry.CurrentUser.OpenSubKey(Title + "\\" + subTitle);

            try
            {
                if (Test != null)
                {
                    Test.OpenSubKey(keyName);
                    t = Test.GetValue(keyName).ToString();

                }
                else
                {
                    t = null;
                }
                return EncryptionDecryption.Decrypt(t, MyShopConfigration.EncyKey);
                //return t;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public static void SaveReg(string Title, string keyName, string keyValue) //Save Local value to Reg
        {
            //Title = EncryptionDecryption.Encrypt(Title, "9946");
            //keyName = EncryptionDecryption.Encrypt(keyName, "9946");
            keyValue = EncryptionDecryption.Encrypt(keyValue, MyShopConfigration.EncyKey);

            RegistryKey Test = Registry.CurrentUser.CreateSubKey(Title);

            Test.SetValue(keyName, keyValue);
        }

        public static string ReadReg(string Title, string keyName)//ReadLocal  value to Reg
        {
            //Title = EncryptionDecryption.Encrypt(Title, "9946");
            //keyName = EncryptionDecryption.Encrypt(keyName, "9946");

            string t;
            RegistryKey Test = Registry.CurrentUser.OpenSubKey(Title);
            try
            {
                if (Test != null)
                {
                    Test.OpenSubKey(keyName);
                    t = Test.GetValue(keyName).ToString();

                }
                else
                {
                    t = null;
                }
                return EncryptionDecryption.Decrypt(t, MyShopConfigration.EncyKey);
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }


        public static bool DeleteSubKey(string Title, string subTitle)//Read a value to Reg
        {
            RegistryKey Test;// = Registry.CurrentUser.OpenSubKey(Title);

            RegistrySecurity rs = new RegistrySecurity();
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            rs.AddAccessRule(new RegistryAccessRule(user, RegistryRights.ReadKey
                | RegistryRights.Delete, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));

            Test = Registry.CurrentUser.OpenSubKey(Title, true);
            Test.SetAccessControl(rs);

            try
            {
                if (Test != null)
                {
                    try
                    {
                        Test.DeleteSubKey(subTitle);
                    }
                    catch (Exception)
                    {
                        
                     
                    }

                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
        public static string[] GetSubKeyNames(string root)
        {
            try
            {
                RegistryKey Test = Registry.CurrentUser.OpenSubKey(root);
                return Test.GetSubKeyNames();
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        public static int GetSubKeyCount(string root)
        {
            try
            {
                RegistryKey Test = Registry.CurrentUser.OpenSubKey(root);
                return Test.SubKeyCount;
            }
            catch (NullReferenceException)
            {
                return 0;
            }
        }

        public static void  ExportKey(string exportPath, string registryPath)
        {
            string path = "\"" + exportPath + "\"";
            string key = "\"" + registryPath + "\"";
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "regedit.exe";
                proc.StartInfo.UseShellExecute = false;
                proc = Process.Start("regedit.exe", "/e " + path + " " + key + "");
              proc.WaitForExit();
            }
            catch(Exception)
            {
                    proc.Dispose();
            }
        }

        // RegistryKey Key;
        //RegistryKey SubKey;

        //public static void CreateKeyAndSubKey(string key, string subKey)
        //{
        //    Registry Key = Registry.CurrentUser.CreateSubKey(key);
        //    Registry SubKey = Registry.CurrentUser.CreateSubKey(subKey);
        //}
        // public void SetValue(string key,string name,string value)
        //{

        //    Key = Registry.CurrentUser.OpenSubKey("Key\\"+key);
        //    Key.SetValue(name, value);
        // }
        //    //SubKey.SetValue("ID", 456);
        // public void DeleteSubKey(string key, string subKey)
        // {
        //     Key = Registry.CurrentUser.CreateSubKey(key);
        //     Key.DeleteSubKey(subKey);
        // }

    }

}
