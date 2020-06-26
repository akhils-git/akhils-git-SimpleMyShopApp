using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Classes
{
   public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quntity { get; set; }
        public decimal Amount { get; set; }
        public bool AddNewOrderDetails(OrderDetails orderDetails)
        {
            int id = Convert.ToInt32(Functions.IDGeneration(MyShopConfigration.OrderDetails)) + 1;
            SysRegedit.SaveReg(MyShopConfigration.OrderDetails, id.ToString() + "." + orderDetails.Id, "Id", id.ToString());
            SysRegedit.SaveReg(MyShopConfigration.OrderDetails, id.ToString() + "." + orderDetails.Id, "OrderId", OrderId.ToString());
            SysRegedit.SaveReg(MyShopConfigration.OrderDetails, id.ToString() + "." + orderDetails.Id, "ProductId", ProductId.ToString());
            SysRegedit.SaveReg(MyShopConfigration.OrderDetails, id.ToString() + "." + orderDetails.Id, "Quntity", Quntity.ToString());
            SysRegedit.SaveReg(MyShopConfigration.OrderDetails, id.ToString() + "." + orderDetails.Id, "Amount", Amount.ToString());
            return true;
        }
        public static OrderDetails[] ReadOrderDetails(string root)
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.OrderDetails);
            OrderDetails[] orderDetails = new OrderDetails[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                orderDetails[i] = new OrderDetails();
                orderDetails[i].Id = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.OrderDetails, temp[i], "Id"));
                orderDetails[i].OrderId = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.OrderDetails, temp[i], "OrderId"));
                orderDetails[i].ProductId =Convert.ToInt32( SysRegedit.ReadReg(MyShopConfigration.OrderDetails, temp[i], "ProductId"));
                orderDetails[i].Quntity = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.OrderDetails, temp[i], "Quntity"));
                orderDetails[i].Amount = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Custmors, temp[i], "Amount"));
                

            }
            return orderDetails;
        }
    }
    
}
