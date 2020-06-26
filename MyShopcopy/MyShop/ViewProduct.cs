using MyShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            BindDataList();
        }

        private void BindDataList()
        {
            DataList.Rows.Clear();
            Product[] product = Product.ViewProducts(MyShopConfigration.Products);
            if (product!=null)
            {
                if (product.Length == 1)
                {
                    DataList.Rows.Add();
                }
                else
                {
                    DataList.Rows.Add(product.Length - 1);
                }
                for (int i = 0; i < product.Length; i++)
                {
                    DataList.Rows[i].Cells[0].Value = product[i].Id;
                    DataList.Rows[i].Cells[1].Value = product[i].CompanyName;
                    DataList.Rows[i].Cells[2].Value = product[i].Name;
                    DataList.Rows[i].Cells[3].Value = product[i].Quntity;
                    DataList.Rows[i].Cells[4].Value = product[i].Price;
                    DataList.Rows[i].Cells[5].Value = product[i].ManDate;
                    DataList.Rows[i].Cells[6].Value = product[i].ExpDate;
                    DataList.Rows[i].Cells[7].Value = product[i].Features;
                } 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product.DeleteProduct(Product.ViewProducts(MyShopConfigration.Products), Convert.ToInt32(txtProductsId.Text));
            BindDataList();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            DataList.BackgroundColor = this.BackColor;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct np = new AddNewProduct();
            Functions.FormShow(np, this);
        }
    }
}
