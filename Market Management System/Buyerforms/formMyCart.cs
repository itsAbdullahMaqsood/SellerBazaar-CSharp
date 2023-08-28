using MarketManagementSystem.Models;
using MarketManagementSystem.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management_System.Buyerforms
{
    public partial class formMyCart : Form
    {
        public formMyCart()
        {
            InitializeComponent();
        }

        private Customer customer;
        private Cart cart;
        private bool selected = false;
        private string category = null;
        private int TotalBill;
        
        public formMyCart(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            
        }

        public formMyCart(Customer customer, int TotalBill, Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
            this.customer = customer;
            this.TotalBill = TotalBill;
        }

        private void WireUpGrid()
        {   
            DataGridViewMyCart.DataSource = connectorSQL.GetCartTable(customer, category);
        }

        private void formMyCart_Load(object sender, EventArgs e)
        {
            buyerLabelFullname.Text = customer.FullName + " !";
            WireUpTotalBill();
            WireUpComboBox();
            WireUpGrid();
        }

        private void WireUpComboBox()
        {
            List<Cart> DistinctProductList = new List<Cart>();
            DistinctProductList = connectorSQL.GetCartProducts_All(customer);
            var distinctCategories = DistinctProductList.Select(product1 => product1.Category).Distinct().ToList();
            comboBoxFilterByCategory.DataSource = distinctCategories;
            comboBoxFilterByCategory.DisplayMember = "Category";
            comboBoxFilterByCategory.Text = null;
        }

        private void WireUpTotalBill()
        {
            TotalBill = connectorSQL.GetTotalBill(customer);
            textBoxTotalBill.Text = TotalBill.ToString();
        }

        private void buyerButtonAvailableProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAvailableProducts form1AvailableProducts = new formAvailableProducts(customer);
            form1AvailableProducts.Show();
        }

        private void buyerButtonPurchaseHistory_Click(object sender, EventArgs e)
        {
            formPurchaseHistory form1PurchaseHistory = new formPurchaseHistory(customer);
            this.Hide();
            form1PurchaseHistory.Show();
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

        private void buttonConfirmPurchase_Click(object sender, EventArgs e)
        {
            if (TotalBill > 0)
            {
                connectorSQL.CreateSale(customer, TotalBill);
                WireUpGrid();
                textBoxTotalBill.Text = null;
            }
            else
            {
                MessageBox.Show("Nothing to Purchase!");
            }
        }

        

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        { 
            if (DataGridViewMyCart.Rows.Count - 1 > 0 && selected)
            {
                connectorSQL.RemoveFromCart(customer, cart);
                WireUpGrid();
                WireUpComboBox();
                WireUpTotalBill();
                selected = false;
            }
            else
            {
                MessageBox.Show("Please Select a Product!");
            }
        }

        private void buyerButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }

        private void DataGridViewMyCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewMyCart.Rows.Count - 1 > 0)
            {
                cart.Id = Int32.Parse(DataGridViewMyCart.SelectedRows[0].Cells[0].Value.ToString());
                selected = true;
            }
        }
    }
}
