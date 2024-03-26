using Amazon.Auth.AccessControlPolicy;
using Microsoft.TeamFoundation.Build.WebApi;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_DataAccess.DALManagers
{
    public class UserDALManager: Connection, DALManagerBase {

        private string tableName = "Users";
        public UserDALManager() { }

        /**
         * Query that gets a specific user using id
         */
        public object? Get(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE userId = @id";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try {
                // Add the parameters
                command.Parameters.AddWithValue("@id", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new User((int)reader.GetValue(0), (string)reader.GetValue(1), 
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5), 
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7));
                }
            } catch (SqlException e) {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return null;
        }

        /**
         * Query that gets all users
         */
        public object? GetAll() {
            string query = $"SELECT * FROM {tableName}";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                List<User> users = new List<User>();
                while (reader.Read()) {
                    users.Add(new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7)));
                }
                connection.Close();
                return users;
            } catch (SqlException e) {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }

            // Close the connection
            connection.Close();
            return null;
        }

        /**
         * Query that updates the user if he exists
         * or creates a new one if he doesn't exist
         */
        public object? Update(Object newUserObject)
        {
            User newUser = (User)newUserObject;
            string query =
                $"UPSERT INTO {tableName} (userId, firtName, lastName, email, phoneNumber, position, birthday," +
                $" nationality, passwordHash, passwordSalt, birthday, nationality, passwordHash, passwordSalt) " +
                $"VALUES ({newUser.Id}, {newUser.FirstName}, {newUser.LastName}," +
                $" {newUser.Email}, {newUser.PhoneNumber}, {newUser.Position}, {newUser.Birthdate},{newUser.Nationality})";
            
            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try {
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                return newUser;
            }
            catch (SqlException e) {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return null;
        }

        /**
         * Query that deletes a specific user using id
         */
        public bool Delete(int id) {
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
