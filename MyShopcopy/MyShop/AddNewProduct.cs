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
    public partial class AddNewProduct : Form
    {
        string temp = string.Empty;

        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void caln_DateSelected(object sender, DateRangeEventArgs e)
        {
            // TextBox txtBox = (TextBox)sender;
            if (temp == "EDate")
                txtEDate.Text = e.Start.ToString("dd/MM/yyyy");
            else if (temp == "MDate")
                txtMDate.Text = e.Start.ToString("dd/MM/yyyy");
            caln.Visible = false;
        }

        private void txtExDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEDate_Click(object sender, EventArgs e)
        {
            temp = "EDate";
            caln.Visible = true;
        }

        private void txtMDate_Click(object sender, EventArgs e)
        {
            temp = "MDate";
            caln.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Functions.CheckUserText(txtName.Text.Trim()) && txtCompany.Text != "" && txtEDate.Text != "" && txtMDate.Text != "" && txtPrice.Text != "")
            {
                Product product = new Product();
                product.Name = txtName.Text;
                product.CompanyName = txtCompany.Text;
                product.ExpDate = txtEDate.Text;
                product.ManDate = txtMDate.Text;
                product.Price = Convert.ToDecimal(txtPrice.Text);
                product.Features = txtFeature.Text;
                product.Quntity = Convert.ToDecimal(txtQuntity.Text);
                product.AddNewProduct(product);
                Functions.MBox(lblMsgBox, "Product Added.", true);
                Functions.ClearTextBox(pnlProducts);

            }
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Functions.ClearTextBox(pnlProducts);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblMsgBox.Visible = false;
        }

        private void AddNewProduct_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }


    }
}
