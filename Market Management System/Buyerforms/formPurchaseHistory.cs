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

namespace Market_Management_System.Buyerforms
{
    public partial class formPurchaseHistory : Form
    {
        public formPurchaseHistory()
        {
            InitializeComponent();
        }

        private Customer customer;
        private string Date;

        public formPurchaseHistory(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void buyerButtonMyCart_Click(object sender, EventArgs e)
        {
            formMyCart form1MyCart = new formMyCart(customer);
            this.Hide();
            form1MyCart.Show();
        }

        private void buyerButtonAvailableProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAvailableProducts form1AvailableProducts = new formAvailableProducts(customer);
            form1AvailableProducts.Show();
        }

        private void formPurchaseHistory_Load(object sender, EventArgs e)
        {
            buyerLabelFullname.Text = customer.FullName + " !";
            WireUpComboBox();
            WireUpGrid();
        }

        private void WireUpGrid()
        {
            DataGridViewPurchaseHistory.DataSource = connectorSQL.GetSalesTable(customer, Date);
        }

        private void WireUpComboBox()
        {
            List<string> DistinctProductList = new List<string>();
            DistinctProductList = connectorSQL.GetDates_All(customer);
            var distinctCategories = DistinctProductList.Distinct().ToList();
            comboBoxFilterByCategory.DataSource = distinctCategories;
            comboBoxFilterByCategory.DisplayMember = "Date";
            comboBoxFilterByCategory.Text = null;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Date = comboBoxFilterByCategory.Text;
            WireUpGrid();
        }

        private void buttonShowAllProducts_Click(object sender, EventArgs e)
        {
            Date = null;
            comboBoxFilterByCategory.Text = null;
            WireUpGrid();
        }

        private void buyerButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }
    }
}
