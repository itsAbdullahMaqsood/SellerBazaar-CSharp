using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManagementSystem.SQL;
using MarketManagementSystem.Models;

namespace Market_Management_System.Sellerforms
{
    public partial class formMyProducts : Form
    {
        public formMyProducts()
        {
            InitializeComponent();
        }

        private Customer customer;
        private Product product;
        private bool selected = false;
        private string category = null;
        
        public formMyProducts(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            product = new Product();
        }

        private void formMyProducts_Load(object sender, EventArgs e)
        {
            labelFullname.Text = customer.FullName + " !";
            WireUpComboBox();
            WireUpGrid();
        }

        private void WireUpComboBox()
        {
            List<Product> DistinctProductList = new List<Product>();
            DistinctProductList = connectorSQL.GetAllProducts_Seller(customer);
            var distinctCategories = DistinctProductList.Select(product1 => product1.Category).Distinct().ToList();
            comboBoxFilterByCategory.DataSource = distinctCategories;
            comboBoxFilterByCategory.DisplayMember = "Category";
            comboBoxFilterByCategory.Text = null;
        }

        private void WireUpGrid()
        {
            DataGridViewMyProducts.DataSource = connectorSQL.GetProductTable(customer, category);
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxCategory.Text = "";
            textBoxQuantity.Text = "";
        }

        private void buttonSalesHistory_Click(object sender, EventArgs e)
        {
            formSalesHistory form1SalesHistory = new formSalesHistory(customer);
            this.Hide();
            form1SalesHistory.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            product.Name = textBoxName.Text;
            product.Price = textBoxPrice.Text;
            product.Category = textBoxCategory.Text;
            product.SellerId = customer.Id;
            if(int.TryParse(textBoxQuantity.Text, out int parsedQuantity))
            {
                product.Quantity = parsedQuantity;
                connectorSQL.CreateProduct(product);
                MessageBox.Show("Product Added Successfully");
                WireUpGrid();
                WireUpComboBox();
            }
            else
            {
                MessageBox.Show("Invalid Entry");
                textBoxQuantity.Clear();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            product.Name = textBoxName.Text;
            product.Price = textBoxPrice.Text;
            product.Category = textBoxCategory.Text;
            if (int.TryParse(textBoxQuantity.Text, out int parsedQuantity))
            {
                product.Quantity = parsedQuantity;
                connectorSQL.UpdateProduct(product);
                MessageBox.Show("Product Updated Successfully");
                WireUpGrid();
                WireUpComboBox();
            }
            else
            {
                MessageBox.Show("Invalid Entry");
                textBoxQuantity.Clear();
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSelectRole form1SelectRole = new formSelectRole();
            form1SelectRole.Show();
        }

        private void DataGridViewMyProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewMyProducts.Rows.Count - 1 > 0)
            {
                product.Id = Int32.Parse(DataGridViewMyProducts.SelectedRows[0].Cells[0].Value.ToString());
                textBoxName.Text = DataGridViewMyProducts.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPrice.Text = DataGridViewMyProducts.SelectedRows[0].Cells[2].Value.ToString();
                textBoxQuantity.Text = DataGridViewMyProducts.SelectedRows[0].Cells[3].Value.ToString();
                textBoxCategory.Text = DataGridViewMyProducts.SelectedRows[0].Cells[4].Value.ToString();
                selected = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {   
            
            if (DataGridViewMyProducts.Rows.Count - 1 > 0 && selected)
            {   
                connectorSQL.DeleteProduct(product);
                WireUpGrid();
                MessageBox.Show("Product Deleted Successfully");
                selected = false;
            }
            else
            {
                MessageBox.Show("Please Select a Product!");
            }
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

    }
}
