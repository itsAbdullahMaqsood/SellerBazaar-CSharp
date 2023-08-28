using Market_Management_System.Buyerforms;
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

namespace Market_Management_System
{
    public partial class formAvailableProducts : Form
    {
        private Customer customer;
        private Cart cart = new Cart();
        private string category = null;
        private int TotalBill;

        public formAvailableProducts(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            WireUpGrid();
        }
        
        public formAvailableProducts()
        {
            InitializeComponent();
        }

        private void WireUpGrid()
        {   
            DataGridViewAvailableProducts.DataSource = connectorSQL.GetProductTable(customer, category);
        }

        private void formAvailableProducts_Load(object sender, EventArgs e)
        {   
            labelFullname.Text = customer.FullName + " !";
            TotalBill = connectorSQL.GetTotalBill(customer);
            textBoxTotalBill.Text = TotalBill.ToString();
            WireUpComboBox();
            WireUpGrid();
        }

        private void WireUpComboBox()
        {
            List<Product> DistinctProductList = new List<Product>();
            DistinctProductList = connectorSQL.GetProducts_All();
            var distinctCategories = DistinctProductList.Select(product1 => product1.Category).Distinct().ToList();
            comboBoxFilterByCategory.DataSource = distinctCategories;
            comboBoxFilterByCategory.DisplayMember = "Category";
            comboBoxFilterByCategory.Text = null;
        }

        private void buyerButtonMyCart_Click(object sender, EventArgs e)
        {
            formMyCart form1MyCart = new formMyCart(customer, TotalBill, cart);
            this.Hide();
            form1MyCart.Show();
        }

        private void buyerButtonPurchaseHistory_Click(object sender, EventArgs e)
        {
            formPurchaseHistory form1PurchaseHistory = new formPurchaseHistory(customer);
            this.Hide();
            form1PurchaseHistory.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (DataGridViewAvailableProducts.Rows.Count - 1 > 0)
            {
                Product product1 = new Product();
                product1.Id = Int32.Parse(DataGridViewAvailableProducts.SelectedRows[0].Cells[0].Value.ToString());
                connectorSQL.GetProduct(product1);      //fills the object will all the rest of the values
                cart.Id = connectorSQL.InsertIntoCart(product1, customer);

                TotalBill += Int32.Parse(DataGridViewAvailableProducts.SelectedRows[0].Cells[2].Value.ToString());
                textBoxTotalBill.Text = TotalBill.ToString();
                WireUpGrid();
            }
            else
                MessageBox.Show("Please Select A Product!");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            category = comboBoxFilterByCategory.Text;
            WireUpGrid();
        }

        private void buttonShowAllProducts_Click(object sender, EventArgs e)
        {
            category = null;
            comboBoxFilterByCategory.Text = null;
            WireUpGrid();
        }

        private void buttonShowMyCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMyCart form1 = new formMyCart(customer, TotalBill, cart);
            form1.Show();
        }
    }
}
