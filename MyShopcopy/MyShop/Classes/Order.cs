using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Classes
{
   public class Order
    {
        public int Id { get; set; }
        public string BillDate { get; set; }
        public int BillNo { get; set; }
        public int CustomerId { get; set; }
        public Decimal Total { get; set; }

        public int AddNewOrder(Order order,int billId)
        {
            int id = Convert.ToInt32(Functions.IDGeneration(MyShopConfigration.Order)) + 1;
            SysRegedit.SaveReg(MyShopConfigration.Order, id.ToString() + "." + order.Id, "Id", id.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Order, id.ToString() + "." + order.Id, "BillNo", billId.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Order, id.ToString() + "." + order.Id, "BillDate", BillDate.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Order, id.ToString() + "." + order.Id, "CustomerId", CustomerId.ToString());
            SysRegedit.SaveReg(MyShopConfigration.Order, id.ToString() + "." + order.Id, "Total", Total.ToString());
            return id;
        }

        public static Order[] ReadOrder(string root)
        {
            string[] temp = SysRegedit.GetSubKeyNames(MyShopConfigration.Order);
            Order[] order = new Order[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                order[i] = new Order();
                order[i].Id = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Order, temp[i], "Id"));
                order[i].BillNo = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Order, temp[i], "BillNo"));
                order[i].BillDate = SysRegedit.ReadReg(MyShopConfigration.Order, temp[i], "BillDate");
                order[i].CustomerId = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Order, temp[i], "CustomerId"));
                order[i].Total = Convert.ToInt32(SysRegedit.ReadReg(MyShopConfigration.Order, temp[i], "Total"));


            }
            return order;
        }
    }
}
