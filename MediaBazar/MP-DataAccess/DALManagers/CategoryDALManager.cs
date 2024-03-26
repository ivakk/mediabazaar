using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class CategoryDALManager : Connection, DALManagerBase
    {
        private string tableName = "Categories";

        public CategoryDALManager() {
        }

        /**
         * Query that gets a specific category using id
         */
        public object? Get(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE categoryId = @id";

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
                    return new Category((int)reader.GetValue(0), (string)reader.GetValue(1));
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
         * Query that gets all categories
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
                List<Category> categories = new List<Category>();
                while (reader.Read())
                {
                    categories.Add(new Category((int)reader.GetValue(0), (string)reader.GetValue(1)));
                }
                connection.Close();
                return categories;
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
         * Query that updates the category if he exists
         * or creates a new one if he doesn't exist
         */
        public object? Update(object newCategoryObject)
        {
            Category newCategory = (Category)newCategoryObject;
            string query =
                $"UPSERT INTO {tableName} (categoryId, name)" +
                $"VALUES ({newCategory.Id}, {newCategory.Name})";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newCategory;
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
         * Query that deletes a specific category using id
         */
        public bool Delete(int id)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE categoryId = @id";

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
