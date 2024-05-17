using MP_BusinessLogic.InterfacesDal;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class SubCategoryDAL : Connection, ISubCategoryDalManager {

        private string tableName = "SubCategories";
        private CategoryDAL categoryDAL = new CategoryDAL();

        public SubCategoryDAL()
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
                    CategoryDAL categoryGet = new CategoryDAL();
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
        public List<SubCategory> GetAll()
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
                    CategoryDAL categoryGet = new CategoryDAL();
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

        public List<string> GetForCategoryAsString(Category category)
        {
            List<SubCategory> all = GetAll();
            List<string> result = new List<string>();
            foreach (SubCategory subCategory in all)
            {
                if (subCategory.Category.Id == category.Id)
                    result.Add(subCategory.Name);
            }
            return result;
        }

        public List<SubCategory> GetForCategory(Category category)
        {
            List<SubCategory> all = GetAll();
            List<SubCategory> result = new List<SubCategory>();
            foreach (SubCategory subCategory in all)
            {
                if (subCategory.Category.Id == category.Id)
                    result.Add(subCategory);
            }
            return result;
        }
        public SubCategory GetByName(string Name)
        {
            foreach (SubCategory subCategory in GetAll())
            {
                if (subCategory.Name == Name)
                    return subCategory;
            }
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
        public SubCategory GetSubCategoryById(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE subCategoryId = @subCategoryId";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@subCategoryId", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new SubCategory((int)reader.GetValue(0), categoryDAL.GetCategoryById((int)reader.GetValue(1)),
                        (string)reader.GetValue(2));
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
            return new SubCategory();
        }
    }
}
