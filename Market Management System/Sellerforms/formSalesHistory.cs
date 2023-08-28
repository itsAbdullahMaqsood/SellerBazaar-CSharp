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

namespace Market_Management_System.Sellerforms
{
    public partial class formSalesHistory : Form
    {
        public formSalesHistory()
        {
            InitializeComponent();
        }

        private Customer customer;
        private string Date;

        public formSalesHistory(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void buttonMyProducts_Click(object sender, EventArgs e)
        {   
            formMyProducts form1MyProducts = new formMyProducts(customer);
            this.Hide();
            form1MyProducts.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }

        private void formSalesHistory_Load(object sender, EventArgs e)
        {
            labelFullname.Text = customer.FullName + " !";
            WireUpComboBox();
            WireUpGrid();
        }

        private void WireUpGrid()
        {
            DataGridViewSalesHistory.DataSource = connectorSQL.GetSalesTable(customer, Date);
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

        private void comboBoxFilterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date = comboBoxFilterByCategory.Text;
            WireUpGrid();
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
    }
}
