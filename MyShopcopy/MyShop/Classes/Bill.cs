using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Classes
{
    public class Bill
    {
        public int Id { get; set; }
        public string BillDateTime { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PIN { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }
        public List<Product> Products= new List<Product>();
        private int totalBill;
        public static void SubmitBill(Customer customer, List<Product> products, decimal tottalPrize)
        {
            Bill bill = new Bill();
            bill.Id = Convert.ToInt32(Functions.IDGeneration(MyShopConfigration.Bill)) + 1;
            bill.Name = customer.Name;
            bill.Address = customer.Address;
            bill.PIN = customer.PIN;
            bill.Mobile = customer.Mobile;
            bill.Email = customer.Email;
            bill.TotalItems = products.Count;
            bill.TotalPrice = tottalPrize;
            bill.AddNewBill(bill.Id, bill, products);
        }
        private bool AddNewBill(int id, Bill newBill, List<Product> products)
        {
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "BillDateTime", DateTime.Now.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "Id", id.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "Name", Name);
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "Address", Address);
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "PIN", PIN.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "Mobile", Mobile);
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "Email", Email);
            string[] ProductNameAndId = SysRegedit.GetSubKeyNames(MyShopConfigration.Products);
            for (int i = 0; i < products.Count; i++)
            {
                SysRegedit.SaveReg(MyShopConfigration.Bill + "\\" + id.ToString() + "." + newBill.Name, products[i].Name, "Name", products[i].Name);
                SysRegedit.SaveReg(MyShopConfigration.Bill + "\\" + id.ToString() + "." + newBill.Name, products[i].Name, "CompanyName", products[i].CompanyName);
                SysRegedit.SaveReg(MyShopConfigration.Bill + "\\" + id.ToString() + "." + newBill.Name, products[i].Name, "Quntity", products[i].Quntity.ToString());
                SysRegedit.SaveReg(MyShopConfigration.Bill + "\\" + id.ToString() + "." + newBill.Name, products[i].Name, "Price", products[i].Price.ToString());

                for (int j = 0; j < ProductNameAndId.Length; j++)
                {
                    if (ProductNameAndId[j].Remove(0, ProductNameAndId[j].IndexOf('.')+1)==products[i].Name)
                    {
                        int a = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Products, ProductNameAndId[j], "Quntity")) - Convert.ToInt32(products[i].Quntity);
                        SysRegedit.SaveReg(MyShopConfigration.Products+ "\\" + ProductNameAndId[j], "Quntity", a.ToString());
                    }
                }
            }

            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "TotalItems", TotalItems.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Bill, id.ToString() + "." + newBill.Name, "TotalPrice", TotalPrice.ToString());
            return true;
        }
        public static string[] LoadId()
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Bill);

            return temp;

        }
        public static int TotalBillCount()
        {
            return SysRegedit.GetSubKeyCount(MyShopConfigration.Bill);
        }
        public static Bill ViewBill(string id)
       {
           string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Bill);
           string billName;
           Bill bill = new Bill();
           for (int i = 0; i < temp.Length; i++)
           {
               if ( id == SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Id"))
               {
                   
                   bill.Id =Convert.ToInt32( SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Id"));
                   bill.BillDateTime = SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "BillDateTime");
                   bill.Name = SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Name");
                   bill.Address = SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Address");
                   bill.PIN =Convert.ToInt32( SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "PIN"));
                   bill.Email = SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Email");
                   bill.Mobile = SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "Mobile");
                   bill.TotalItems = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "TotalItems"));
                   bill.TotalPrice =Convert.ToDecimal( SysRegedit.ReadReg(MyShopConfigration.Bill, temp[i], "TotalPrice"));
                   string [] productNames = SysRegedit.GetSubKeyNames(MyShopConfigration.Bill + "\\" + temp[i]);
                   for (int j = 0; j < productNames.Length; j++)
                   {
                       Product tempProduct = new Product();
                       tempProduct.Name = SysRegedit.ReadReg(MyShopConfigration.Bill + "\\" + temp[i], productNames[j], "Name");
                       tempProduct.CompanyName = SysRegedit.ReadReg(MyShopConfigration.Bill + "\\" + temp[i], productNames[j], "CompanyName");
                       tempProduct.Price = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Bill + "\\" + temp[i], productNames[j], "Price"));
                       tempProduct.Quntity = Convert.ToDecimal(SysRegedit.ReadReg(MyShopConfigration.Bill + "\\" + temp[i], productNames[j], "Quntity"));
                       bill.Products.Add(tempProduct);
                   }
               }
           }
           
           return bill;
       }
        
        private static Customer[] ViewCustmoers(string root)
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Custmors);
            Customer[] custmoer = new Customer[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                custmoer[i] = new Customer();
                custmoer[i].Id = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Id"));
                custmoer[i].Name = SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Name");
                custmoer[i].Address = SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Address");
                custmoer[i].PIN = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "PIN"));
                custmoer[i].Mobile = SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Mobile");
                custmoer[i].Email = SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Email");

            }
            return custmoer;
        }
    }
}
