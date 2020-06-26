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
    public partial class ViewBill : Form
    {
        string[] billIdAndCustomerName=new string[Bill.TotalBillCount()];
        Bill bill = new Bill();
        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            dataListProducts.BackgroundColor = this.BackColor;
            BindComBillId(Bill.LoadId());
        }
       
        
        private void btnView_Click(object sender, EventArgs e)
        {
         
        }
        private void BindComBillId(string[] id)
        {
            try
            {
                for (int i = 0; i < id.Length; i++)
                {

                    comBillId.Items.Add(id[i].Remove(id[i].IndexOf('.'), id[i].Length - 1));
                    billIdAndCustomerName[i] = id[i];
                }
            }
            catch (Exception)
            { }
        }
        
       
        private void comBillId_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill = Bill.ViewBill(comBillId.Text.Trim());
            txtName.Text = bill.Name;
            txtAddress.Text = bill.Address;
            txtPIN.Text = bill.PIN.ToString();
            txtMobile.Text = bill.Mobile;
            txtEmail.Text = bill.Email;
            lblBilldateTime.Text = bill.BillDateTime;
            dataListProducts.Rows.Clear();
            try
            {
                dataListProducts.Rows.Add(bill.Products.Count - 1);
            }
            catch (Exception)
            {
                
            }
           
            for (int i = 0; i < bill.Products.Count; i++)
            {
                dataListProducts.Rows[i].Cells[0].Value = i;
                dataListProducts.Rows[i].Cells[1].Value = bill.Products[i] .Name;
                dataListProducts.Rows[i].Cells[2].Value = bill.Products[i].CompanyName;
                dataListProducts.Rows[i].Cells[3].Value = bill.Products[i].Quntity;
                dataListProducts.Rows[i].Cells[4].Value = bill.Products[i].Price;
                lblTotalAmount.Text = bill.TotalPrice.ToString();
                lblTotalItems.Text = bill.TotalItems.ToString();
              
            }
            if (bill!=null)
            {
                btnSaveFile.Enabled = true;
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FileManagement.WriteFile(bill);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

    }
}
