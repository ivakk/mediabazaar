using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class ProductDALManager : Connection
    {

        private string tableName = "Products";

        public ProductDALManager()
        {
        }

        /**
         * Query that gets a specific product using id
         */
        public object? Get(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE productId = @id";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@id", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CategoryDALManager CategoryGet = new CategoryDALManager();
                    Category Category = (Category)CategoryGet.Get((int)reader.GetValue(1));
                    SubCategoryDALManager subCategoryGet = new SubCategoryDALManager();
                    SubCategory subCategory = (SubCategory)subCategoryGet.Get((int)reader.GetValue(1));
                    BrandDALManager brandGet = new BrandDALManager();
                    Brand brand = (Brand)brandGet.Get((int)reader.GetValue(2));
                    return new Product((int)reader.GetValue(0), Category, subCategory, brand,(string) reader.GetValue(3),
                        (string)reader.GetValue(4), (decimal)reader.GetValue(5), (int)reader.GetValue(6));
                }
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return null;
        }

        /**
         * Query that gets all products
         */
        public object? GetAll()
        {
            string query = $"SELECT * FROM {tableName}";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                List<Product> products = new List<Product>();
                while (reader.Read())
                {
                    CategoryDALManager CategoryGet = new CategoryDALManager();
                    Category Category = (Category)CategoryGet.Get((int)reader.GetValue(1));
                    SubCategoryDALManager subCategoryGet = new SubCategoryDALManager();
                    SubCategory subCategory = (SubCategory)subCategoryGet.Get((int)reader.GetValue(1));
                    BrandDALManager brandGet = new BrandDALManager();
                    Brand brand = (Brand)brandGet.Get((int)reader.GetValue(2));
                    products.Add(new Product((int)reader.GetValue(0), Category, subCategory, brand, (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (decimal)reader.GetValue(5), (int)reader.GetValue(6)));
                }
                connection.Close();
                return products;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }

            // Close the connection
            connection.Close();
            return null;
        }

        /**
        * Query that updates the product if he exists
        * or creates a new one if he doesn't exist
        */
        public object? Create(object newProductObject)
        {
            Product newProduct = (Product)newProductObject;
            string query =
                $"INSERT INTO {tableName} (subCategoryId, brandId, model, description, price, warehouseQuantity)" +
                $"VALUES (@subCategoryId, @brandId, @model, @description, @price, @warehouseQuantity)";

            // Open the connection
            try
            {
                connection.Open();
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            command.Parameters.AddWithValue("@subCategoryId", newProduct.SubCategory.Id);
            command.Parameters.AddWithValue("@brandId", newProduct.Brand.Id);
            command.Parameters.AddWithValue("@model", newProduct.Model);
            command.Parameters.AddWithValue("@description", newProduct.Desciption);
            command.Parameters.AddWithValue("@price", newProduct.Price);
            command.Parameters.AddWithValue("@warehouseQuantity", newProduct.WarehouseQuantity);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newProduct;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Debug.WriteLine(e.Message);
            }
            connection.Close();
            return null;
        }

        public object? Update(object newProductObject)
        {
            Product newProduct = (Product)newProductObject;
            string query =
                $"UPDATE {tableName} SET " +
                $"subCategoryId = @subCategoryId, " +
                $"brandId = @brandId, " +
                $"model = @model, " +
                $"description = @description, " +
                $"price = @price, " +
                $"warehouseQuantity = @warehouseQuantity " +
                $"WHERE productId = @id";

            // Open the connection
            try
            {
                connection.Open();
            }catch(Exception e)
            { Console.WriteLine(e.Message); }

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            command.Parameters.AddWithValue("@id", newProduct.Id);
            command.Parameters.AddWithValue("@subCategoryId", newProduct.SubCategory.Id);
            command.Parameters.AddWithValue("@brandId", newProduct.Brand.Id);
            command.Parameters.AddWithValue("@model", newProduct.Model);
            command.Parameters.AddWithValue("@description", newProduct.Desciption);
            command.Parameters.AddWithValue("@price", newProduct.Price);
            command.Parameters.AddWithValue("@warehouseQuantity", newProduct.WarehouseQuantity);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newProduct;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Debug.WriteLine(e.Message);
            }
            connection.Close();
            return null;
        }

        /**
         * Query that deletes a specific product using id
        */
        public bool Delete(int id)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE productId = @id";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@id", id);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return false;
        }
    }
}
