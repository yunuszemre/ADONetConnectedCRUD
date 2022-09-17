using ADONetConnectedCRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetConnectedCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
           FillProducts();
        }

        private void FillProducts()
        {
           grdProducts.DataSource = GetAllProducts();
        }
        string _ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {

                try
                {
                    using (SqlCommand command = new SqlCommand("select * from Products", con))
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.ProductID = (int)reader["ProductID"];
                            product.SupplierID = (int)reader["SupplierID"];
                            product.CategoryID = (int)reader["CategoryID"];
                            product.ProductName = (string)reader["ProductName"];
                            product.QuantityPerUnit = (string)reader["QuantityPerUnit"];
                            product.UnitPrice = (decimal)reader["UnitPrice"];
                            product.UnitsInStock = (short)reader["UnitsInStock"];
                            product.UnitsOnOrder = (short)reader["UnitsOnOrder"];
                            product.ReorderLevel = (short)reader["ReorderLevel"];
                            product.Discontinued = (bool)reader["Discontinued"];
                            products.Add(product);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            return products;
        }

        private void grdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (grdProducts.DataSource as List<Product>)[e.RowIndex];
            if (product!=null)
            {
                ProductForm form = new ProductForm();
                form.RecID = product.ProductID;
                form.Show();
            }
           
        }
        List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                try
                {
                    using(SqlCommand command = new SqlCommand("select * from Products", con))
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.ProductID = (int)reader["ProductID"];
                            product.SupplierID = (int)reader["SupplierID"];
                            product.CategoryID = (int)reader["CategoryID"];
                            product.ProductName = (string)reader["ProductName"];
                            product.QuantityPerUnit = (string)reader["QuantityPerUnit"];
                            product.UnitPrice = (decimal)reader["UnitPrice"];
                            product.UnitsInStock = (short)reader["UnitsInStock"];
                            product.UnitsOnOrder = (short)reader["UnitsOnOrder"];
                            product.ReorderLevel = (short)reader["ReorderLevel"];
                            product.Discontinued = (bool)reader["Discontinued"];
                            products.Add(product);

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                return products;
            }
        }
    }
}
