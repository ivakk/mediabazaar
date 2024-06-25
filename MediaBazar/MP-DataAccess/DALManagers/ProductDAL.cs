using MP_BusinessLogic.InterfacesDal;
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
    public class ProductDAL : Connection, IProductDalManager
    {

        private string tableName = "Products";
        private SubCategoryDAL subCategoryDAL = new SubCategoryDAL();
        private CategoryDAL categoryDAL = new CategoryDAL();
        private BrandDAL brandDAL = new BrandDAL();

        public ProductDAL()
        {
        }

        /**
         * Query that gets a specific product using id
         */
        public Product GetById(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE productId = @id";
            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);
            Product product = null;

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@id", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    SubCategory subCategory = (SubCategory)subCategoryDAL.GetSubCategoryById((int)reader.GetValue(1));
                    Category category = (Category)categoryDAL.GetCategoryById(subCategory.Category.Id);
                    Brand brand = (Brand)brandDAL.GetBrandById((int)reader.GetValue(2));
                    return new Product((int)reader.GetValue(0), category, subCategory, brand, (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (decimal)reader.GetValue(5), (int)reader.GetValue(6), (string)reader.GetValue(7),
                        (int)reader.GetValue(8), (decimal)reader.GetValue(9), (decimal)reader.GetValue(10), (decimal)reader.GetValue(11));
                    return product;
                }
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return product;
        }

        /**
         * Query that gets all products
         */
        public List<Product> GetAll()
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
                    SubCategory subCategory = (SubCategory)subCategoryDAL.GetSubCategoryById((int)reader.GetValue(1));
                    Category category = (Category)categoryDAL.GetCategoryById(subCategory.Category.Id);
                    Brand brand = (Brand)brandDAL.GetBrandById((int)reader.GetValue(2));
                    products.Add(new Product((int)reader.GetValue(0), category, subCategory, brand, (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (decimal)reader.GetValue(5), (int)reader.GetValue(6), (string)reader.GetValue(7),
                        (int)reader.GetValue(8), (decimal)reader.GetValue(9), (decimal)reader.GetValue(10), (decimal)reader.GetValue(11)));
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
        public bool Create(Product product)
        {
            Product newProduct = product;
            string query =
                $"INSERT INTO {tableName} (subCategoryId, brandId, model, description, price, warehouseQuantity, UPCcode, storeQuantity, weight, height, width)" +
                $"VALUES (@subCategoryId, @brandId, @model, @description, @price, @warehouseQuantity, @upcCode, @storeQuantity, @weight, @height, @width)";

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
            command.Parameters.AddWithValue("@upcCode", newProduct.UPCcode);
            command.Parameters.AddWithValue("@storeQuantity", newProduct.StoreQuantity);
            command.Parameters.AddWithValue("@weight", newProduct.Weight);
            command.Parameters.AddWithValue("@height", newProduct.Height);
            command.Parameters.AddWithValue("@width", newProduct.Width);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                int rowsAffected = reader.RecordsAffected;
                connection.Close();
                return rowsAffected > 0;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            
            
        }

        public bool Update(Product product)
        {
            Product newProduct = product;
            string query =
                $"UPDATE {tableName} SET " +
                $"subCategoryId = @subCategoryId, " +
                $"brandId = @brandId, " +
                $"model = @model, " +
                $"description = @description, " +
                $"price = @price, " +
                $"warehouseQuantity = @warehouseQuantity, " +
                $"UPCcode = @upcCode, " +
                $"storeQuantity = @storeQuantity, " +
                $"weight = @weight, " +
                $"height = @height, " +
                $"width = @width " +
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
            command.Parameters.AddWithValue("@upcCode", newProduct.UPCcode);
            command.Parameters.AddWithValue("@storeQuantity", newProduct.StoreQuantity);
            command.Parameters.AddWithValue("@weight", newProduct.Weight);
            command.Parameters.AddWithValue("@height", newProduct.Height);
            command.Parameters.AddWithValue("@width", newProduct.Width);


            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                int rowsAffected = reader.RecordsAffected;
                return rowsAffected > 0;
                
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Debug.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
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
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Product> GetBySearch(string search)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in GetAll())
            {
                if (product.GetObjectString().Contains(search))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public Dictionary<string, int> GetTotalStockQuantity()
        {
            string query = @"SELECT model, SUM(storeQuantity + warehouseQuantity) AS TotalStock
                         FROM Products
                         GROUP BY model";
            Dictionary<string, int> stats = new Dictionary<string, int>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        int totalStock = (int)reader["TotalStock"];
                        stats[model] = totalStock;
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<string, decimal> GetTotalStockValue()
        {
            string query = @"SELECT model, SUM(price * (storeQuantity + warehouseQuantity)) AS TotalValue
                         FROM Products
                         GROUP BY model";
            Dictionary<string, decimal> stats = new Dictionary<string, decimal>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        decimal totalValue = (decimal)reader["TotalValue"];
                        stats[model] = totalValue;
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantities()
        {
            string query = @"SELECT model, SUM(storeQuantity) AS Store, SUM(warehouseQuantity) AS Warehouse
                         FROM Products
                         GROUP BY model";
            Dictionary<string, (int Store, int Warehouse)> stats = new Dictionary<string, (int Store, int Warehouse)>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        int storeQuantity = (int)reader["Store"];
                        int warehouseQuantity = (int)reader["Warehouse"];
                        stats[model] = (storeQuantity, warehouseQuantity);
                    }
                }
                connection.Close();
            }
            return stats;
        }
        public Dictionary<string, int> GetTotalStockQuantityByCategoryAndBrand(string category, string brand)
        {
            string query = @"SELECT model, SUM(storeQuantity + warehouseQuantity) AS TotalStock
                     FROM Products
                     WHERE subCategoryId IN (SELECT subCategoryId FROM SubCategories WHERE categoryId IN (SELECT categoryId FROM Categories WHERE name = @category))
                     AND brandId IN (SELECT brandId FROM Brands WHERE name = @brand)
                     GROUP BY model";
            Dictionary<string, int> stats = new Dictionary<string, int>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@brand", brand);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        int totalStock = (int)reader["TotalStock"];
                        stats[model] = totalStock;
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<string, decimal> GetTotalStockValueByCategoryAndBrand(string category, string brand)
        {
            string query = @"SELECT model, SUM(price * (storeQuantity + warehouseQuantity)) AS TotalValue
                     FROM Products
                     WHERE subCategoryId IN (SELECT subCategoryId FROM SubCategories WHERE categoryId IN (SELECT categoryId FROM Categories WHERE name = @category))
                     AND brandId IN (SELECT brandId FROM Brands WHERE name = @brand)
                     GROUP BY model";
            Dictionary<string, decimal> stats = new Dictionary<string, decimal>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@brand", brand);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        decimal totalValue = (decimal)reader["TotalValue"];
                        stats[model] = totalValue;
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<string, (int Store, int Warehouse)> GetWarehouseStoreQuantitiesByCategoryAndBrand(string category, string brand)
        {
            string query = @"SELECT model, SUM(storeQuantity) AS Store, SUM(warehouseQuantity) AS Warehouse
                     FROM Products
                     WHERE subCategoryId IN (SELECT subCategoryId FROM SubCategories WHERE categoryId IN (SELECT categoryId FROM Categories WHERE name = @category))
                     AND brandId IN (SELECT brandId FROM Brands WHERE name = @brand)
                     GROUP BY model";
            Dictionary<string, (int Store, int Warehouse)> stats = new Dictionary<string, (int Store, int Warehouse)>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@brand", brand);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string model = reader["model"].ToString();
                        int storeQuantity = (int)reader["Store"];
                        int warehouseQuantity = (int)reader["Warehouse"];
                        stats[model] = (storeQuantity, warehouseQuantity);
                    }
                }
                connection.Close();
            }
            return stats;
        }

    }
}
