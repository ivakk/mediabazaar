using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class SubCategoryDALManager : Connection, DALManagerBase {

        private string tableName = "SubCategories";

        public SubCategoryDALManager()
        {
        }

        /**
         * Query that gets a specific subcategory using id
         */
        public object? Get(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE subCategoryId = @id";

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
                    CategoryDALManager categoryGet = new CategoryDALManager();
                    Category category = (Category)categoryGet.Get((int)reader.GetValue(1));
                    return new SubCategory((int)reader.GetValue(0), category, (string)reader.GetValue(2));
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
         * Query that gets all subcategories
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
                List<SubCategory> subCategories = new List<SubCategory>();
                while (reader.Read())
                {
                    CategoryDALManager categoryGet = new CategoryDALManager();
                    Category category = (Category)categoryGet.Get((int)reader.GetValue(1));
                    subCategories.Add(new SubCategory((int)reader.GetValue(0), category, (string)reader.GetValue(2)));
                }
                connection.Close();
                return subCategories;
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
        * Query that updates the subcategory if he exists
        * or creates a new one if he doesn't exist
        */
        public object? Update(object newSubCategoryObject)
        {
            SubCategory newSubCategory = (SubCategory)newSubCategoryObject;
            string query =
                $"UPSERT INTO {tableName} (subCategoryId, categoryId, name)" +
                $"VALUES ({newSubCategory.Id}, {newSubCategory.Category.Id}, {newSubCategory.Name})";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newSubCategory;
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
         * Query that deletes a specific subcategory using id
        */
        public bool Delete(int id)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE subCategoryId = @id";

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
