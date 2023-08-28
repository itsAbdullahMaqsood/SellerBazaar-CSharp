using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManagementSystem.Models;
using MarketManagementSystem.SQL;
using Market_Management_System.Sellerforms;
using Market_Management_System.Adminforms;
using Market_Management_System.Buyerforms;
using Market_Management_System.Models;

namespace Market_Management_System
{
    public partial class formSignin : Form
    {
        private Customer customer;

        public formSignin(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        public formSignin()
        {
            InitializeComponent();
        }
        

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formSignup signupform = new formSignup(customer);
            signupform.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            customer.Username = textboxUsernameSignIn.Text;
            customer.Passsword = textboxPasswordSignIn.Text; //checks corresponding password using the given username in the sql database.
            if (customer.Passsword == connectorSQL.ValidateSignIn(customer) || (customer.Username == "Admin" && customer.Passsword == "admin"))
            {
                MessageBox.Show("Login Successfull");
                this.Hide();
                switch (Customer.Role)
                {
                    case "Buyer":
                        customer = connectorSQL.GetCustomerDetails(customer);
                        formAvailableProducts form1AvailableProducts = new formAvailableProducts(customer);
                        form1AvailableProducts.Show();
                        break;
                    case "Seller":
                        customer = connectorSQL.GetCustomerDetails(customer);
                        formSalesHistory form1SalesHistory = new formSalesHistory(customer);
                        form1SalesHistory.Show();
                        break;
                    case "Admin":
                        formViewSeller form1ViewSeller = new formViewSeller();
                        form1ViewSeller.Show();
                        break;
                }
            }
            else if (connectorSQL.ValidateSignIn(customer) == "Banned")
            {
                MessageBox.Show("Account Banned!");
            }
            else
                MessageBox.Show("Invalid Username or Password !");
        }

        private void formSignin_Load(object sender, EventArgs e)
        {
            if(Customer.Role == "Admin")
            {   
                //Delete the default text after finished setting up
                textboxUsernameSignIn.Text = "Admin";
                textboxPasswordSignIn.Text = "admin";

                linkNewAccount.Enabled = false;
                linkNewAccount.Visible = false;
            }
        }

        private void labelback_MouseEnter(object sender, EventArgs e)
        {
            labelback.ForeColor = Color.White;
            labeldash.ForeColor = Color.White;
        }

        private void labelback_MouseLeave(object sender, EventArgs e)
        {
            labelback.ForeColor = SystemColors.ControlDarkDark;
            labeldash.ForeColor = SystemColors.ControlDarkDark;
        }

        private void labeldash_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole formSelectRole = new formSelectRole();
            formSelectRole.Show();
        }

        private void labelback_Click(object sender, EventArgs e)
        {
            labeldash_Click(sender, e);
        }

        private void labeldash_MouseEnter(object sender, EventArgs e)
        {
            labelback_MouseEnter(sender, e);   
        }

        private void labeldash_MouseLeave(object sender, EventArgs e)
        {
            labelback_MouseLeave(sender, e);
        }

        private void labelClear_MouseEnter(object sender, EventArgs e)
        {
            labelClear.ForeColor = Color.Red;
        }

        private void labelClear_MouseLeave(object sender, EventArgs e)
        {
            labelClear.ForeColor = SystemColors.ControlDarkDark;
        }

        private void labelX_MouseEnter(object sender, EventArgs e)
        {
            labelXLogin.ForeColor = Color.Red;
        }

        private void labelX_MouseLeave(object sender, EventArgs e)
        {
            labelXLogin.ForeColor = SystemColors.ControlDarkDark;
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textboxUsernameSignIn.Clear();
            textboxPasswordSignIn.Clear();
        }
    }
}
