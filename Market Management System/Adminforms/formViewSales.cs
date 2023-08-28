using Market_Management_System.Models;
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
using System.Drawing.Printing;

namespace Market_Management_System.Adminforms
{
    public partial class formViewSales : Form
    {
        public formViewSales()
        {
            InitializeComponent();
        }

        private Customer customer;
        private string Date;

        private void buttonAllSellers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formViewSeller form1ViewSeller = new formViewSeller();
            form1ViewSeller.Show();
        }

        private void buttonAllBuyers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formViewBuyer form1ViewBuyer = new formViewBuyer();
            form1ViewBuyer.Show();
        }

        private void formViewSales_Load(object sender, EventArgs e)
        {
            Customer.Role = "Admin";
            WireUpGrid();
            WireUpComboBox();
        }

        private void WireUpGrid()
        {
            DataGridViewTotalSales.DataSource = connectorSQL.GetSalesTable(customer, Date);
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

