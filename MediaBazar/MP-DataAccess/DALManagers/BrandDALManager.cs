using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class BrandDALManager : Connection, DALManagerBase {
        private string tableName = "Brands";

        /**
         * Default Constructor
         */
        public BrandDALManager() {
        }

        /**
         * Query that gets a specific brand using id
         */
        public object? Get(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE brandId = @id";

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
                    return new Brand((int)reader.GetValue(0), (string)reader.GetValue(1));
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
         * Query that gets all brands
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
                List<Brand> brands = new List<Brand>();
                while (reader.Read())
                {
                    brands.Add(new Brand((int)reader.GetValue(0), (string)reader.GetValue(1)));
                }
                connection.Close();
                return brands;
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
         * Query that updates the brand if he exists
         * or creates a new one if he doesn't exist
         */
        public object? Update(object newBrandObject)
        {
            Brand newBrand = (Brand)newBrandObject;
            string query =
                $"UPSERT INTO {tableName} (brandId, name)" +
                $"VALUES ({newBrand.Id}, {newBrand.Name})";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newBrand;
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
         * Query that deletes a specific brand using id
         */
        public bool Delete(int id)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE id = @id";

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
