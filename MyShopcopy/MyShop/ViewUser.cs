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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindDataList();
           
        }

        private void BindDataList()
        {
            try
            {
                DataList.Rows.Clear();
                Customer[] custmoers = Customer.ViewCustmoers(MyShopConfigration.Custmors);
                if (custmoers.Length==1)
                {
                       DataList.Rows.Add();
                }
                else
                {
                    DataList.Rows.Add(custmoers.Length - 1);

                }
                for (int i = 0; i < custmoers.Length; i++)
                {
                    DataList.Rows[i].Cells[0].Value = custmoers[i].Id;
                    DataList.Rows[i].Cells[1].Value = custmoers[i].Name;
                    DataList.Rows[i].Cells[2].Value = custmoers[i].Address;
                    DataList.Rows[i].Cells[3].Value = custmoers[i].PIN;
                    DataList.Rows[i].Cells[4].Value = custmoers[i].Mobile;
                    DataList.Rows[i].Cells[5].Value = custmoers[i].Email;
                }
            }
            catch (Exception)
            {
                
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer.DeleteCustomer(Customer.ViewCustmoers(MyShopConfigration.Custmors), Convert.ToInt32(txtCustmoerId.Text));
            BindDataList();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            DataList.BackgroundColor = this.BackColor;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser nu = new AddNewUser();
            Functions.FormShow(nu, this);
        }

       
    }
}
