using Market_Management_System.Adminforms;
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

namespace Market_Management_System.Models
{
    public partial class formViewSeller : Form
    {
        public formViewSeller()
        {
            InitializeComponent();
        }

        Customer customer = new Customer();
        string name;
        bool selected = false;

        private void formViewSeller_Load(object sender, EventArgs e)
        {
            Customer.Role = "Seller";
            WireUpGrid();
            WireUpComboBox();
        }

        private void WireUpGrid()
        {
            DataGridViewAllSellers.DataSource = connectorSQL.GetAllCustomers(name);
        }

        private void WireUpComboBox()
        {
            List<string> DistinctProductList = new List<string>();
            DistinctProductList = connectorSQL.GetCustomersNames();
            var distinctCategories = DistinctProductList.Distinct().ToList();
            comboBoxFilterByCategory.DataSource = distinctCategories;
            comboBoxFilterByCategory.DisplayMember = "Name";
            comboBoxFilterByCategory.Text = null;
        }

        private void buttonAllBuyers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formViewBuyer form1ViewBuyer = new formViewBuyer();
            form1ViewBuyer.Show();
        }

        private void buttonTotalSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            formViewSales form1ViewSales = new formViewSales();
            form1ViewSales.Show();
        }

        private void buyerButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }

        private void DataGridViewAllSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridViewAllSellers.Rows.Count - 1 > 0)
            {
                customer.Id = Int32.Parse(DataGridViewAllSellers.SelectedRows[0].Cells[0].Value.ToString());
                selected = true;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            name = comboBoxFilterByCategory.Text;
            WireUpGrid();
        }

        private void buttonShowAllProducts_Click(object sender, EventArgs e)
        {
            name = null;
            comboBoxFilterByCategory.Text = null;
            WireUpGrid();
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                connectorSQL.BanCustomer(customer);
                WireUpGrid();
                selected = false;
            }
            else
            {
                MessageBox.Show("Please Select a Person!");
            }
        }

        private void buttonUnban_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                connectorSQL.UnBanCustomer(customer);
                WireUpGrid();
                selected = false;
            }
            else
            {
                MessageBox.Show("Please Select a Person!");
            }
        }
    }
}
