using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManagementSystem.Models;

namespace Market_Management_System
{
    public partial class formSelectRole : Form
    {
        private Customer customer = new Customer();

        public formSelectRole()
        {
            InitializeComponent();
            
        }

        private void buttonBuyer_Click(object sender, EventArgs e)
        {
            Customer.Role = "Buyer";
            this.Hide();
            formSignin Signinform = new formSignin(customer);
            Signinform.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Customer.Role = "Admin";
            this.Hide();
            formSignin Signinform = new formSignin(customer);
            Signinform.Show();
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            Customer.Role = "Seller";
            this.Hide();
            formSignin Signinform = new formSignin(customer);
            Signinform.Show();
        }

        private void labelXLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelXLogin_MouseEnter(object sender, EventArgs e)
        {
            labelXLogin.ForeColor = Color.Red;
        }

        private void labelXLogin_MouseLeave(object sender, EventArgs e)
        {
            labelXLogin.ForeColor = SystemColors.ControlDarkDark;
        }
    }
}
