using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PIN { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool AddNewCustomer(Customer customer)
        {
            int id = Convert.ToInt32(Functions.IDGeneration(MyShopConfigration.Custmors)) + 1;
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "Id", id.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "Name", Name);
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "Address", Address);
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "PIN", PIN.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "Mobile", Mobile);
            SysRegedit.SaveReg(MyShopConfigration.Custmors, id.ToString() + "." + customer.Name, "Email", Email);
            return true;
        }

        public static void DeleteCustomer(Customer[] customer, int id)
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Custmors);
            for (int i = 0; i < customer.Length; i++)
            {
                if (id == Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Id")))
                {
                    SysRegedit.DeleteSubKey(MyShopConfigration.Custmors, temp[i]);
                    //return true;
                    break;
                }
            }
        }

        public static Customer[] ViewCustmoers(string root)
        {
            try
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
            catch (Exception)
            { return null; }
        }
    }
}
