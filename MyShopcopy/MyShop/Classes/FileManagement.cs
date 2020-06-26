using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Classes
{
   public class FileManagement
    {
       public static void WriteFile(Bill bill)
       {
           using (StreamWriter stream = File.CreateText(bill.Name + ".txt"))
           {

               stream.WriteLine("My Shop");
               stream.WriteLine("=======");
               stream.WriteLine();
               stream.WriteLine("Customer\t\t: "+bill.Name);
               stream.WriteLine("Address\t\t\t: " + bill.Address);
               stream.WriteLine("PIN\t\t\t: " + bill.PIN);
               stream.WriteLine("Mobile\t\t\t: " + bill.Mobile);
               stream.WriteLine("Email\t\t\t: " + bill.Email);
               stream.WriteLine("Purchase date\t\t: " + bill.BillDateTime);
               stream.WriteLine();
               stream.WriteLine("id\tProduct Name\t\tCompany Name\t\tQuntity\t\tPrice");
               stream.WriteLine("==\t============\t\t============\t\t=======\t\t=====");

               int productnameLength = 0, companyNameLength=0,quntityLength=0;

               for (int i = 0; i < bill.Products.Count; i++)
               {
                   productnameLength =12- bill.Products[i].Name.Length;
                   companyNameLength = 12 - bill.Products[i].CompanyName.Length;
                   quntityLength = 7 - Convert.ToString(bill.Products[i].Quntity).Length;

                   string strQuntity = string.Empty;
                   for (int j = 0; j < productnameLength; j++)
                   {
                       bill.Products[i].Name = bill.Products[i].Name.Insert(bill.Products[i].Name.Length, " ");
                   }
                   for (int k = 0; k < companyNameLength; k++)
                   {
                       bill.Products[i].CompanyName = bill.Products[i].CompanyName.Insert(bill.Products[i].CompanyName.Length, " ");
                   }
                   strQuntity = bill.Products[i].Quntity.ToString();
                   for (int l = 0; l < quntityLength; l++)
                   {
                        strQuntity = strQuntity.Insert(strQuntity.Length, " ");
                   }

                   stream.WriteLine(i + "\t" + bill.Products[i].Name + "\t\t" + bill.Products[i].CompanyName + "\t\t" + strQuntity + "\t\t" + bill.Products[i].Price + "/-");
               }
               stream.WriteLine("==\t============\t\t============\t\t=======\t\t=====");
               stream.WriteLine("Total Items\t\t: " + bill.TotalItems);
               stream.WriteLine("Total Amount\t\t: " + bill.TotalPrice+"/-");
               
               System.Diagnostics.Process.Start("notepad.exe", bill.Name+".txt");
           }
       }
    }
}
