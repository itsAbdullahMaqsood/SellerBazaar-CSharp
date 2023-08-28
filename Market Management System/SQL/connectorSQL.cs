using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using MarketManagementSystem.Models;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Common;
using System.CodeDom.Compiler;
using Market_Management_System.Models;
using System.Web.UI.Design;

namespace MarketManagementSystem.SQL
{
    internal static class connectorSQL
    {
        private const string db = "MarketDB";   //This is the name of the DataBase

        public static string CnnString()    //to get connection string using name
        {
            return ConfigurationManager.ConnectionStrings[db].ConnectionString;
        }

        public static void CreateCustomer(Customer model)
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))       //Creates The Buyer or Seller in the database
            {
                var p = new DynamicParameters();        //this is from Dapper
                p.Add("@FullName", model.FullName);  
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Email", model.Email);
                p.Add("@Username", model.Username);
                p.Add("@Passsword", model.Passsword);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                switch (Customer.Role)
                {
                    case "Buyer":
                        connection.Execute("dbo.spCreateBuyer", p, commandType: CommandType.StoredProcedure); ;
                        break;
                    case "Seller":
                        connection.Execute("dbo.spCreateSeller", p, commandType: CommandType.StoredProcedure); ;
                        break;
                }

                model.Id = p.Get<int>("@Id");
            }
        }

        public static void CreateProduct(Product model)     //Creates the Product in the database
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Price", model.Price);
                p.Add("@Quantity", model.Quantity);
                p.Add("@Category", model.Category);
                p.Add("@SellerId", model.SellerId);
                p.Add("@Id",0,dbType:DbType.Int32, direction:ParameterDirection.Output);

                connection.Execute("dbo.spCreateProduct",p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("Id");
            }
        }
            
        public static void UpdateProduct(Product model)     //updates the product in the database
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                p.Add("@Name", model.Name);
                p.Add("@Price", model.Price);
                p.Add("@Quantity", model.Quantity);
                p.Add("@Category", model.Category);

                connection.Execute("dbo.spUpdateProduct",p, commandType: CommandType.StoredProcedure);
            }
        }
        
        public static void DeleteProduct(Product model)     //deletes the product in the database
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@DeleteId", model.Id);
                p.Add("@LatestId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spDeleteProduct",p, commandType: CommandType.StoredProcedure);
                if (p.Get<int>("@LatestId") != 0)
                {
                    model.Id = p.Get<int>("@LatestId");
                }
            }
        }

        public static DataTable GetProductTable(Customer model, string category)        //Returns Everything in the Product Table
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {  
                var p = new DynamicParameters();
                p.Add("@Category", category);
                IDataReader q;  //I could say var q but I was not initilizing it here so I had to specify the type.
                if (Customer.Role == "Seller")
                {
                    p.Add("@SellerId", model.Id);
                    q = connection.ExecuteReader("dbo.spGetProductTable_Seller", p, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    q = connection.ExecuteReader("dbo.spGetProductTable_Buyer", p, commandType: CommandType.StoredProcedure);
                }
                DataTable dt = new DataTable();
                dt.Load(q);
                return dt;
            }
        }

        public static void GetProduct(Product model)        //Takes the product Id and returns the whole product to insert into Cart
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                model = connection.QueryFirst<Product>("dbo.spGetProduct", p, commandType: CommandType.StoredProcedure);
            }
        }


        public static List<Product> GetProducts_All()       //to make category filter list of available products
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                List<Product> allProducts = new List<Product>();
                allProducts = connection.Query<Product>("select * from dbo.Products", commandType: CommandType.Text).ToList();
                return allProducts;
            }
        }
        
        public static List<Product> GetAllProducts_Seller(Customer model)    //to make category filter list of seller's products
        {   
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@SellerId", model.Id);
                List<Product> allProducts = new List<Product>();
                allProducts = connection.Query<Product>("dbo.spGetAllProducts_Seller", p, commandType: CommandType.StoredProcedure).ToList();
                return allProducts;
            }
        }



        public static int InsertIntoCart(Product model, Customer customer)     //Inserts The chosen product in the cart-table in the database
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@ProductId", model.Id);
                p.Add("@BuyerId", customer.Id);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInsertIntoCart", p, commandType: CommandType.StoredProcedure);
                return p.Get<int>("@Id");

            }
        }
        
        public static int GetTotalBill(Customer model)     //Calculates the Total bill by Adding the Price of All the products in the Cart
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@BuyerId", model.Id);
                p.Add("@TotalBill", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spGetTotalBill", p, commandType: CommandType.StoredProcedure);
                    return p.Get<int>("@TotalBill"); 
            }
        }

        public static void RemoveFromCart(Customer customer, Cart cart)     //Removes The product from Cart
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@BuyerId", customer.Id);
                p.Add("Id", cart.Id);
                connection.Execute("dbo.spRemoveFromCart", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static DataTable GetCartTable(Customer model, string category)       //Returns Everything in Cart Table
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {   
                var p = new DynamicParameters();
                p.Add("@BuyerId", model.Id);
                p.Add("@Category", category);
                var q = connection.ExecuteReader("dbo.spGetCartTable", p, commandType: CommandType.StoredProcedure);
                DataTable dt = new DataTable();
                dt.Load(q);
                return dt;
            }
        }
        
        public static List<Cart> GetCartProducts_All(Customer model)    //Returns a List of categories of All the products to make category filter list of seller's products
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@BuyerId", model.Id);
                var q = connection.Query<Cart>("dbo.spGetCartProducts", p, commandType: CommandType.StoredProcedure).ToList();
                return q;
            }
        }

        public static void CreateSale(Customer model, int TotalBill)    //Inserts All the products from the Cart to the Sales Table to Confirm Purchase
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@BuyerId", model.Id);
                p.Add("@TotalBill", TotalBill);
                connection.Execute("dbo.spCreateSale", p, commandType: CommandType.StoredProcedure);
            }
        }
        
        public static DataTable GetSalesTable(Customer customer, string Date)   //Returns All the Sales from The Sales Table in the database
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@DateTime", Date);
                IDataReader q;
                if (Customer.Role == "Seller")
                {
                    p.Add("@SellerId", customer.Id);
                    q = connection.ExecuteReader("dbo.spGetSalesTable_Seller", p, commandType: CommandType.StoredProcedure);
                }
                else if (Customer.Role == "Buyer")
                {
                    p.Add("@BuyerId", customer.Id);
                    q = connection.ExecuteReader("dbo.spGetSalesTable_Buyer", p, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    q = connection.ExecuteReader("dbo.spGetSalesTable_Admin", p, commandType: CommandType.StoredProcedure);
                }
                DataTable dt = new DataTable();
                dt.Load(q);
                return dt;
            }
        }

        public static List<string> GetDates_All(Customer model)       //to make Date filter list of seller's products
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                List<string> q;
                if (Customer.Role == "Seller")
                {
                    p.Add("@SellerId", model.Id);
                    q = connection.Query<string>("dbo.spGetAllDates_Seller", p, commandType: CommandType.StoredProcedure).ToList();
                }
                else if(Customer.Role == "Buyer")
                {
                    p.Add("@BuyerId", model.Id);
                    q = connection.Query<string>("dbo.spGetAllDates_Buyer", p, commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    q = connection.Query<string>("select Date from dbo.Sales", commandType: CommandType.Text).ToList();
                }

                return q;
            }
        }

        public static string ValidateSignIn(Customer model)     //Validates Sign-In by checking if The Corresponding Password in the database for the Given Username 
        {                                                       //matches the one entered in During Sign-In
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Username", model.Username);
                Customer temp = new Customer();
                switch (Customer.Role)
                {
                    case "Buyer":
                        model.AccountStatus = connection.QueryFirst<int>("dbo.spGetAccountStatus", p, commandType: CommandType.StoredProcedure);
                        if (model.AccountStatus == 1)
                        {
                            temp.Passsword = connection.QueryFirst<string>("dbo.spValidateSignIn_Buyer", p, commandType: CommandType.StoredProcedure);
                        }
                        else
                        {
                            temp.Passsword = "Banned";
                        }
                        break;

                    case "Seller":
                        model.AccountStatus = connection.QueryFirst<int>("dbo.spGetAccountStatus", p, commandType: CommandType.StoredProcedure);
                        if (model.AccountStatus == 1)
                        {
                            temp.Passsword = connection.QueryFirst<string>("dbo.spValidateSignIn_Seller", p, commandType: CommandType.StoredProcedure);
                        }
                        else
                        {
                            temp.Passsword = "Banned";
                        }
                        break;
                }
                return temp.Passsword;
            }
        
        }
        
        public static string ValidateUserName( Customer model)  //Validates Sign-Up by checking if The given Username is Unique
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Username", model.Username);
                Customer temp = new Customer();
                temp.Username = connection.QueryFirstOrDefault<string>("dbo.spValidateSignUp", p, commandType: CommandType.StoredProcedure);
               
                return temp.Username;
            }
        
        }

        public static Customer GetCustomerDetails(Customer model)        //gets the rest of the detials of the customer from the username entered during signin
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Username", model.Username);
                if (Customer.Role == "Seller")
                {
                    p.Add("@SellerName", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    model = connection.QueryFirst<Customer>("dbo.spGetCustomerDetails", p, commandType: CommandType.StoredProcedure);
                    model.FullName = p.Get<string>("@SellerName");
                }
                else
                {
                    p.Add("@BuyerName", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    model = connection.QueryFirst<Customer>("dbo.spGetCustomerDetails", p, commandType: CommandType.StoredProcedure);
                    model.FullName = p.Get<string>("@BuyerName");
                }
                
                return model;
            }
        }
                    
        public static DataTable GetAllCustomers(string name)     //Returns All the Sellers or Buyers for the Admin to Ban/Unban
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Name", name);
                IDataReader q;
                if (Customer.Role == "Seller")
                {
                    q = connection.ExecuteReader("dbo.spGetAllSellers", p, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    q = connection.ExecuteReader("dbo.spGetAllBuyers", p, commandType: CommandType.StoredProcedure);

                }
                DataTable dt = new DataTable();
                dt.Load(q);
                return dt;
            }
        }

        public static List<string> GetCustomersNames()       //to make Name filter list of the Sellers/Buyers in the Admin Panel
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                List<string> p;
                if (Customer.Role == "Seller")
                {
                    p = connection.Query<string>("select SellerName from dbo.Sellers ", commandType: CommandType.Text).ToList();
                }
                else
                {
                    p = connection.Query<string>("select BuyerName from dbo.Buyers ", commandType: CommandType.Text).ToList();
                }

                return p;
            }
        }

        public static void BanCustomer(Customer model)       //Sets the Account Status of the customer in the database to 0 to Ban the customer
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                if (Customer.Role == "Seller")
                {
                    connection.Execute("dbo.spBanSeller", p, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    connection.Execute("dbo.spBanBuyer", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
        
        public static void UnBanCustomer(Customer model)       //Sets the Account Status of the customer in the database to 1 to UnBan the customer
        {
            using (IDbConnection connection = new SqlConnection(CnnString()))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                if (Customer.Role == "Seller")
                {
                    connection.Execute("dbo.spUnBanSeller", p, commandType: CommandType.StoredProcedure);
                }
                else
                {
                    connection.Execute("dbo.spUnBanBuyer", p, commandType: CommandType.StoredProcedure);
                }
            }
        }



    }
}
