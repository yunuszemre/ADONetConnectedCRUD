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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

            FillSupplier();
            FillCategory();
            GetAllProducts();
            FillForm();
            
        }

        private void FillForm()
        {
            if (RecID > 0)
            {
                var product = GetProductById(this.RecID);
                txtProductName.Text = product.ProductName;
                cmbCategory.SelectedValue = product.CategoryID;
                cmbSuppliers.SelectedValue = product.SupplierID;
                txtQuantityPerUnit.Text = product.QuantityPerUnit;
                nuUnitPrice.Value = (decimal)product.UnitPrice;
                nuOrder.Value = (decimal)product.UnitsOnOrder;
                nuReorderLvel.Value = (decimal)product.ReorderLevel;
                nuUnitsInStock.Value = (decimal)product.UnitsInStock;
                chkDisconiued.Checked = (bool)product.Discontinued;
            }
            else
            {

            }
        }

        private Product GetProductById(int productID)
        {
            Product product = null;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("select top 1 * from Products where ProductID=@ProductID", con))
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        command.Parameters.AddWithValue("ProductID", productID);

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            product = new Product();

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
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return product;
        }

        private void FillCategory()
        {
            cmbCategory.DataSource = null;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = GetCategories();
        }

        private void FillSupplier()
        {
            cmbSuppliers.DataSource = null;
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.DataSource = GetSuppliers();
        }

        string _ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public int RecID { get; set; }
        List<Product> GetAllProducts()
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
                return products;
            }
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("select SupplierID,CompanyName from Suppliers", con))
                    {
                        if (con.State != ConnectionState.Open) con.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier();
                            supplier.SupplierID = (int)reader["SupplierID"];
                            supplier.CompanyName = (string)reader["CompanyName"];
                            suppliers.Add(supplier);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return suppliers;
        }
        List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("select CategoryID,CategoryName from Categories", con))
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Category category = new Category();
                            category.CategoryID = (int)reader["CategoryID"];
                            category.CategoryName = (string)reader["CategoryName"];

                            categories.Add(category);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            return categories;
        }

    }

}
