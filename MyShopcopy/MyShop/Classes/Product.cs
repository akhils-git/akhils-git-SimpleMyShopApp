using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ExpDate { get; set; }
        public string CompanyName { get; set; }
        public string ManDate { get; set; }
        public decimal Quntity { get; set; }
        public string Features { get; set; }

        public bool AddNewProduct(Product product)
        {
            int id = Convert.ToInt32(Functions.IDGeneration(MyShopConfigration.Products)) + 1;
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "Id", id.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "Name", Name);
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "Price", Price.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "ExpDate", ExpDate.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "ManDate", ManDate.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "CompanyName", CompanyName);
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "Quntity", Quntity.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Products, id.ToString() + "." + product.Name, "Features", Features);
            return true;
        }

        public static Product[] ViewProducts(string root)
        {
            try
            {
                string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Products);
                Product[] product = new Product[temp.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    product[i] = new Product();
                    product[i].Id = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Id"));
                    product[i].Name = SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Name");
                    product[i].Price = Convert.ToDecimal(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Price"));
                    product[i].ExpDate = Convert.ToString(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "ExpDate"));
                    product[i].ManDate = Convert.ToString(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "ManDate"));
                    product[i].CompanyName = SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "CompanyName");
                    product[i].Quntity = Convert.ToDecimal(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Quntity"));
                    product[i].Features = SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Features");

                }
                return product;
            }
            catch (Exception)
            { return null; }

        }

        public static void DeleteProduct(Product[] product, int id)
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Products);
            for (int i = 0; i < product.Length; i++)
            {
                if (id == Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Products, temp[i], "Id")))
                {
                    SysRegedit.DeleteSubKey(MyShopConfigration.Products, temp[i]);
                    break;
                }
            }
        }

    }
}
