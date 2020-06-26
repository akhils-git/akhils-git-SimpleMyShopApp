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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Functions.CheckUserText(txtName.Text.Trim()) && txtPIN.Text != "" && txtMobile.Text != "")
            {
                Customer customer = new Customer();
                customer.Name = txtName.Text;
                customer.Address = txtCompany.Text;
                customer.PIN = Convert.ToInt32(txtPIN.Text);
                customer.Mobile = txtMobile.Text;
                customer.Email = txtEmail.Text;
                customer.AddNewCustomer(customer);
                Functions.MBox(lblMsgBox, "Sucessfully added new customer", true);
                Functions.ClearTextBox(pnlCustomers);
            }
            else
                Functions.MBox(lblMsgBox, "Invalid input !", false);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Functions.ClearTextBox(pnlCustomers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Functions.CheckUserNumber(txtName.Text.Trim()))
            {
                MessageBox.Show("Suc");
            }
            else
            {
                MessageBox.Show("falce");
            }
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            ThemeService.ActiveTheme(this);
            txtPIN.Text = "";
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            Functions.FormShow(h, this);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblMsgBox.Visible = false;
        }

        private void AddNewUser_KeyDown(object sender, KeyEventArgs e)
        {
            Functions.Navigation(this, e);
        }
    }
}
