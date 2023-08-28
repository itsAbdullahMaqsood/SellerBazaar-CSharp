using MarketManagementSystem.Models;
using MarketManagementSystem.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management_System
{
    public partial class formSignup : Form
    {

        private Customer customer;
        
        public formSignup()
        {
            InitializeComponent();
        }


        public formSignup(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void labelClear_MouseEnter(object sender, EventArgs e)
        {
            labelClear.ForeColor = Color.Red;
        }

        private void labelClear_MouseLeave(object sender, EventArgs e)
        {
            labelClear.ForeColor = SystemColors.ControlDarkDark;
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            textboxFullNameSignUp.Clear();
            textboxEmailSignUp.Clear();
            textboxPhoneNumberSignUp.Clear();
            textboxUsernameSignUp.Clear();
            textboxPasswordSignUp.Clear();
        }

        private void labelX_MouseEnter(object sender, EventArgs e)
        {
            labelX.ForeColor = Color.Red;
        }

        private void labelX_MouseLeave(object sender, EventArgs e)
        {
            labelX.ForeColor = SystemColors.ControlDarkDark;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Username = textboxUsernameSignUp.Text;
            customer.FullName = textboxFullNameSignUp.Text;
            customer.PhoneNumber = textboxPhoneNumberSignUp.Text;
            customer.Email = textboxEmailSignUp.Text;
            customer.Passsword = textboxPasswordSignUp.Text;

            if (customer.Username == connectorSQL.ValidateUserName(customer))
            {
                MessageBox.Show("Invalid! Username Already Taken.");
            }
            else
            { 
                connectorSQL.CreateCustomer(customer);
                formSignin Signinform = new formSignin(customer);
                Signinform.Show();
                this.Hide();  
            }
            
        }

        private void labelback_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSignin Formsignin = new formSignin();
            Formsignin.Show();
        }

        private void labeldash_Click(object sender, EventArgs e)
        {
            labelback_Click(sender, e);
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

        private void labeldash_MouseEnter(object sender, EventArgs e)
        {
            labelback_MouseEnter(sender, e);
        }

        private void labeldash_MouseLeave(object sender, EventArgs e)
        {
            labelback_MouseLeave(sender, e);
        }
    }
}
