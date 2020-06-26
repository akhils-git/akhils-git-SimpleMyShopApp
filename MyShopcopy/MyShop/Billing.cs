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
    public partial class Billing : Form
    {
        Customer[] custmoers;
        Customer currentCustomerSelected = new Customer();

        List<Product> currentCustemorProducts = new List<Product>();
        Product[] product;
       
        int a, billNo = 0, activeProductQuntity = 0;

        int custemorId, productId;
        decimal totalPrice;
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            BindComUser();
            BindProduct();
            a = 0;
            ThemeService.ActiveTheme(this);
            dataListProducts.BackgroundColor = this.BackColor;
        }

        public void BindComUser()
        {
            custmoers = Customer.ViewCustmoers(MyShopConfigration.Custmors);
            try
            {
                for (int i = 0; i < custmoers.Length; i++)
                {
                    comUser.Items.Add(custmoers[i].Name);
                }
            }
            catch (Exception)
            { }
        }
        public void BindProduct()
        {
            product = Product.ViewProducts(MyShopConfigration.Products);
            try
            {
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i].Quntity >= 1)
                        comProduct.Items.Add(product[i].Name);
                }
            }
            catch (Exception)
            { }
        }
        public void BindProductList()
        {
            if (dataListProducts.Rows.Count >= 1)
            {
                txtProductsId.Visible = true;
                btnDeleteItem.Visible = true;
            }
            if (activeProductQuntity >= Convert.ToInt32(txtQuntity.Text.Trim()))
            {
                dataListProducts.Rows.Add();
                dataListProducts.Rows[a].Cells[0].Value = a;
                dataListProducts.Rows[a].Cells[1].Value = comProduct.Text.Trim();
                dataListProducts.Rows[a].Cells[2].Value = txtCompany.Text.Trim();
                dataListProducts.Rows[a].Cells[3].Value = txtQuntity.Text.Trim();
                totalPrice = Convert.ToDecimal(txtQuntity.Text) * Convert.ToDecimal(txtPrice.Text);
                dataListProducts.Rows[a].Cells[4].Value = totalPrice;
                a++;

                //order.BillDate = "12/12/2013";
                //order.CustomerId = custemorId;
                //order.Total = Convert.ToDecimal(txtQuntity.Text) * Convert.ToDecimal(txtPrice.Text);
                //int orderId = order.AddNewOrder(order, billNo);

                //orderDetails.OrderId = orderId;
                //orderDetails.ProductId = productId;
                //orderDetails.Quntity = Convert.ToInt32(txtQuntity.Text);
                //orderDetails.Amount = Convert.ToDecimal(lblTotalAmount.Text);

                //   orderDetails.AddNewOrderDetails(orderDetails);

                lblTotalAmount.Text = (Convert.ToDecimal(totalPrice) + Convert.ToDecimal(lblTotalAmount.Text)).ToString();
                lblTotalItems.Text = ((dataListProducts.RowCount) - 1).ToString();
                activeProductQuntity = activeProductQuntity - Convert.ToInt32(txtQuntity.Text.Trim());
                ProductAvailableShow(activeProductQuntity);
            }
            else
                MessageBox.Show("Only " + activeProductQuntity + " can be available now !");
        }
        private void comUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < custmoers.Length; i++)
            {
                if (comUser.Text.Trim() == custmoers[i].Name)
                {
                    txtAddress.Text = custmoers[i].Address;
                    txtPIN.Text = custmoers[i].PIN.ToString();
                    txtMobile.Text = custmoers[i].Mobile;
                    txtEmail.Text = custmoers[i].Email;
                    custemorId = custmoers[i].Id;
                    currentCustomerSelected = custmoers[i];
                }
            }
            ClearDataProductList();
        }

        private void ClearDataProductList()
        {
            billNo = Functions.BuildBillNo();
            dataListProducts.Rows.Clear();
            a = 0;
            lblTotalAmount.Text = "0";
            lblTotalItems.Text = "0";
        }

        private void comProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < product.Length; i++)
            {
                if (comProduct.Text.Trim() == product[i].Name)
                {
                    txtCompany.Text = product[i].CompanyName;
                    txtPrice.Text = product[i].Price.ToString();
                    txtMDate.Text = product[i].ManDate;
                    txtEDate.Text = product[i].ExpDate;
                    txtFeature.Text = product[i].Features; ;
                    productId = product[i].Id;
                    txtQuntity.Text = "1";
                    activeProductQuntity = Convert.ToInt32(product[i].Quntity);
                    ProductAvailableShow(Convert.ToInt32(product[i].Quntity));
                    btnAdd.Enabled = true;
                }
            }

            lblAvailable.Visible = true;
        }

        private void ProductAvailableShow(int i)
        {
            lblAvailable.Text = i + " Available";
            if (i <= 3)
                lblAvailable.ForeColor = Color.Red;
            else
                lblAvailable.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindProductList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            lblAvailable.Visible = false;
            int a = Functions.BuildBillNo();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            currentCustomerSelected.Name = comUser.Text.Trim();
            currentCustomerSelected.Address = txtAddress.Text;
            currentCustomerSelected.PIN = Convert.ToInt32(txtPIN.Text);
            currentCustomerSelected.Mobile = txtMobile.Text;
            currentCustomerSelected.Email = txtEmail.Text;
            BindCurrentCustomerProducts();

            Bill.SubmitBill(currentCustomerSelected, currentCustemorProducts, Convert.ToDecimal(lblTotalAmount.Text));
            //MessageBox.Show("Sucessfully billed");
            Functions.MBox(lblMsgBox, "Sucessfully billed", true);
            Functions.ClearTextBox(pnlCustomers);
            Functions.ClearTextBox(pnlProducts);
            Functions.ClearTextBox(pnlProductList);
        }

        private void BindCurrentCustomerProducts()
        {
            for (int i = 0; i < dataListProducts.Rows.Count - 1; i++)
            {
                Product tempProduct = new Product();
                tempProduct.Id = Convert.ToInt32(dataListProducts.Rows[i].Cells[0].Value);
                tempProduct.Name = dataListProducts.Rows[i].Cells[1].Value.ToString();
                tempProduct.CompanyName = dataListProducts.Rows[i].Cells[2].Value.ToString();
                tempProduct.Quntity = Convert.ToDecimal(dataListProducts.Rows[i].Cells[3].Value);
                tempProduct.Price = Convert.ToDecimal(dataListProducts.Rows[i].Cells[4].Value);
                currentCustemorProducts.Add(tempProduct);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataListProducts.Rows.RemoveAt(Convert.ToInt32(txtProductsId.Text.Trim()));
                if (dataListProducts.Rows.Count == 0)
                {
                    txtProductsId.Visible = false;
                    btnDeleteItem.Visible = false;
                }
                txtProductsId.Text = "";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Intem to in the bill list !");
                txtProductsId.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Plese enter valid id !");
                txtProductsId.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Functions.ClearTextBox(pnlCustomers);
            Functions.ClearTextBox(pnlProducts);
            Functions.ClearTextBox(pnlProductList);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            lblMsgBox.Visible = false;
        }

    }
}
