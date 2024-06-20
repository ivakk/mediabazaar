using Amazon.Auth.AccessControlPolicy;
using Amazon.Runtime.Internal.Util;
using Microsoft.TeamFoundation.Build.WebApi;
using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;

namespace MP_DataAccess.DALManagers
{
    public class UserDAL: Connection , IUserDalManager
    {
        IDepartmentService departmentService;
        private readonly string tableName = "Employees";
        public UserDAL(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        public bool InsertUser(User newUser)
        {
            // Set up the query
            string query = $"INSERT INTO {tableName} " +
                           $"(firstName, lastName, email, phoneNumber, position, birthday, passwordHash, passwordSalt, " +
                           $"departmentId, startContract, endContract, salaryLevel) " +
                           $"VALUES (@firstName, @lastName, @email, @phoneNumber, @position, " +
                           $"@birthday, @passwordHash, @passwordSalt, @departmentId, " +
                           $"@startContract, @endContract, @salaryLevel)";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {

                command.Parameters.AddWithValue("@firstName", newUser.FirstName);
                command.Parameters.AddWithValue("@lastName", newUser.LastName);
                command.Parameters.AddWithValue("@email", newUser.Email);
                command.Parameters.AddWithValue("@phoneNumber", newUser.PhoneNumber);
                command.Parameters.AddWithValue("@position", newUser.Position);
                command.Parameters.AddWithValue("@birthday", newUser.Birthdate);
                command.Parameters.AddWithValue("@passwordHash", newUser.PasswordHash);
                command.Parameters.AddWithValue("@passwordSalt", newUser.PasswordSalt);
                command.Parameters.AddWithValue("@departmentId", newUser.Department.Id);
                command.Parameters.AddWithValue("@startContract", newUser.StartContract);
                command.Parameters.AddWithValue("@endContract", newUser.EndContract);
                command.Parameters.AddWithValue("@salaryLevel", newUser.SalaryLevel);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();

                connection.Close();
                return true;
                ;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
                connection.Close();
                return false;
            }

        }
        public User GetUserByEmail(string email)
        {
            string query = $"SELECT * FROM {tableName} WHERE email = @email";
            User foundUser = null;

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@email", email);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    foundUser = new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12));
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
            return foundUser;
        }

        public User GetUserById(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE userId = @userId";
            User foundUser = null;
            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@userId", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     foundUser = new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12));
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
            return foundUser;
        }

        /**
        * Query that gets a specific user using email
        */
        //public User GetUserByEmail(string email)
        //{
        //    string query = $"SELECT * FROM {tableName} WHERE email = @email";

        //    // Open the connection
        //    connection.Open();

        //    SqlCommand command = new SqlCommand(query, base.connection);

        //    try
        //    {
        //        // Add the parameters
        //        command.Parameters.AddWithValue("@email", email);

        //        // Execute the query and get the data
        //        using SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            return new User((int)reader.GetValue(0), (string)reader.GetValue(1),
        //                (string)reader.GetValue(2), (string)reader.GetValue(3),
        //                (string)reader.GetValue(4), (string)reader.GetValue(5),
        //                (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
        //                (string)reader.GetValue(8), new Department((int)reader.GetValue(9)),
        //                (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
        //                (int)reader.GetValue(12));
        //        }
        //    }
        //    catch (SqlException e)
        //    {
        //        // Handle any errors that may have occurred.
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return new User();
        //}

        /**
         * Query that gets all users
         */
        public List<User> GetAllUsers()
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
                List<User> users = new List<User>();

                while (reader.Read())
                {
                    users.Add(new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12)));
                }
                return users;
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
            return new List<User>();
        }


        public List<User> GetUsersByDepartment(int departmentId)
        {
            string query = $"SELECT * FROM {tableName} WHERE departmentId = @departmentId";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@departmentId", departmentId);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                List<User> users = new List<User>();

                while (reader.Read())
                {
                    users.Add(new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12)));
                }
                return users;

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
            return new List<User>();
        }
        /**
         * Query that updates the user data
         */
        public bool UpdateUser(User newUser)
        {
            string query =
                $"UPDATE {tableName} " +
                $"SET firstName = @firstName, lastName = @lastName, email = @email, phoneNumber = @phoneNumber, " +
                $"position = @position, birthday = @birthdate, passwordHash = @passwordHash, passwordSalt = @passwordSalt, " +
                $"departmentId = @departmentId, startContract = @startContract, endContract = @endContract, salaryLevel = @salaryLevel " +
                $"WHERE userId = @id";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@id", newUser.Id);
                command.Parameters.AddWithValue("@firstName", newUser.FirstName);
                command.Parameters.AddWithValue("@lastName", newUser.LastName);
                command.Parameters.AddWithValue("@email", newUser.Email);
                command.Parameters.AddWithValue("@phoneNumber", newUser.PhoneNumber);
                command.Parameters.AddWithValue("@position", newUser.Position);
                command.Parameters.AddWithValue("@birthdate", newUser.Birthdate);
                command.Parameters.AddWithValue("@passwordHash", newUser.PasswordHash);
                command.Parameters.AddWithValue("@passwordSalt", newUser.PasswordSalt);
                command.Parameters.AddWithValue("@departmentId", newUser.Department.Id);
                command.Parameters.AddWithValue("@startContract", newUser.StartContract);
                command.Parameters.AddWithValue("@endContract", newUser.EndContract);
                command.Parameters.AddWithValue("@salaryLevel", newUser.SalaryLevel);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();

                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Console.WriteLine(e.Message);
                connection.Close();
                return false;
            }
        }

        /**
         * Query that deletes a specific user using id
         */
        public bool DeleteUser(int id)
        {
            AddUserToExEmployees(GetUserById(id));
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE userId = @userId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@userId", id);

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
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddUserToExEmployees(User exUser)
        {
            // Set up the query
            string query = $"INSERT INTO ExEmployees " +
                           $"(userId, firstName, lastName, email, phoneNumber, position, birthday, passwordHash, passwordSalt, " +
                           $"departmentId, startContract, endContract, salaryLevel) " +
                           $"VALUES (@userId, @firstName, @lastName, @email, @phoneNumber, @position, " +
                           $"@birthday, @passwordHash, @passwordSalt, @departmentId, " +
                           $"@startContract, @endContract, @salaryLevel)";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                command.Parameters.AddWithValue("@userId", exUser.Id);
                command.Parameters.AddWithValue("@firstName", exUser.FirstName);
                command.Parameters.AddWithValue("@lastName", exUser.LastName);
                command.Parameters.AddWithValue("@email", exUser.Email);
                command.Parameters.AddWithValue("@phoneNumber", exUser.PhoneNumber);
                command.Parameters.AddWithValue("@position", exUser.Position);
                command.Parameters.AddWithValue("@birthday", exUser.Birthdate);
                command.Parameters.AddWithValue("@passwordHash", exUser.PasswordHash);
                command.Parameters.AddWithValue("@passwordSalt", exUser.PasswordSalt);
                command.Parameters.AddWithValue("@departmentId", exUser.Department.Id);
                command.Parameters.AddWithValue("@startContract", exUser.StartContract);
                command.Parameters.AddWithValue("@endContract", exUser.EndContract);
                command.Parameters.AddWithValue("@salaryLevel", exUser.SalaryLevel);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();

                connection.Close();
            }
            catch (SqlException e)
            {
                // Handle any errors that may have occurred.
                Debug.WriteLine(e.Message);
                connection.Close();
            }
        }

        /**
         * Query that creates new user in the database
         */
        //public bool InsertUser(User newUser)
        //{
        //    // Set up the query
        //    string query = $"INSERT INTO {tableName} " +
        //                   $"(firstName, lastName, email, phoneNumber, position, birthday, passwordHash, passwordSalt, " +
        //                   $"departmentId, startContract, endContract, salaryLevel) " +
        //                   $"VALUES (@firstName, @lastName, @email, @phoneNumber, @position, " +
        //                   $"@birthday, @passwordHash, @passwordSalt, @departmentId, " +
        //                   $"@startContract, @endContract, @salaryLevel)";

        //    // Open the connection
        //    connection.Open();

        //    // Creating Command string to combine the query and the connection String
        //    SqlCommand command = new SqlCommand(query, base.connection);

        //    try
        //    {

        //        command.Parameters.AddWithValue("@firstName", newUser.FirstName);
        //        command.Parameters.AddWithValue("@lastName", newUser.LastName);
        //        command.Parameters.AddWithValue("@email", newUser.Email);
        //        command.Parameters.AddWithValue("@phoneNumber", newUser.PhoneNumber);
        //        command.Parameters.AddWithValue("@position", newUser.Position);
        //        command.Parameters.AddWithValue("@birthday", newUser.Birthdate);
        //        command.Parameters.AddWithValue("@passwordHash", newUser.PasswordHash);
        //        command.Parameters.AddWithValue("@passwordSalt", newUser.PasswordSalt);
        //        command.Parameters.AddWithValue("@departmentId", newUser.Department.Id);
        //        command.Parameters.AddWithValue("@startContract", newUser.StartContract);
        //        command.Parameters.AddWithValue("@endContract", newUser.EndContract);
        //        command.Parameters.AddWithValue("@salaryLevel", newUser.SalaryLevel);

        //        // Execute the query and get the data
        //        using SqlDataReader reader = command.ExecuteReader();

        //        connection.Close();
        //        return true;
        //        ;
        //    }
        //    catch (SqlException e)
        //    {
        //        // Handle any errors that may have occurred.
        //        Console.WriteLine(e.Message);
        //        connection.Close();
        //        return false;
        //    }

        //}

        /**
        * Query that changes the user department
        */
        public void UpdateDepartment(int userId, string department)
        {
            string query =
                $"UPDATE {tableName} " +
                $"SET departmentId = @departmentId " +
                $"WHERE userId = @userId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@firstName", department);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
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
        }

        public bool IsPasswordCorrect(string email, string password)
        {
            /// <summary>
            /// This function returns true, if the password is correct for the given email address.
            /// </summary>

            // Get user by email property, 
            User users = GetUserByEmail(email);

            // If there is no user with the given email address, return false.
            if (users == null)
            {
                // No user found with given email.
                return false;
            }

            PasswordHashing passwordHashing = new PasswordHashing();
            string hashedPasswordToCheck = passwordHashing.GenerateSHA256Hash(password, users.PasswordSalt);

            if (users.PasswordHash == hashedPasswordToCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangePassword(string email, string newPassword)
        {
            //User user = GetUserById(userId);
            User user = GetUserByEmail(email);

            if (user == null)
            {
                throw new ArgumentException("User not found.");
            }
            PasswordHashing hashing = new PasswordHashing();


            //string passwordSalt = hashing.GenerateRandomSalt(10);
            //string passwordHash = hashing.GenerateSHA256Hash("MediaBazaar", passwordSalt);
            // Generate new password hash and salt

            string newSalt = hashing.GenerateRandomSalt(10);
            string newHashedPassword = hashing.GenerateSHA256Hash(newPassword, newSalt);

            // Update user with new password and salt
            user.PasswordSalt = newSalt;
            user.PasswordHash = newHashedPassword;

            return UpdateUser(user);
        }

        public User GetUserByUserName(string firstName)
        {
            string query = $"SELECT * FROM Users WHERE firstName = @firstName";
            User foundUser = null;

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@firstName", firstName);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    foundUser = new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12));
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
            return foundUser;

        }
        public Dictionary<DateTime, int> GetMonthlyHireStatistics()
        {
            string query = @"SELECT YEAR(startContract) AS Year, MONTH(startContract) AS Month, COUNT(*) AS Count
                     FROM Employees
                     GROUP BY YEAR(startContract), MONTH(startContract)
                     ORDER BY Year, Month;";
            Dictionary<DateTime, int> stats = new Dictionary<DateTime, int>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = new DateTime((int)reader["Year"], (int)reader["Month"], 1);
                        stats[date] = (int)reader["Count"];
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<DateTime, int> GetMonthlyExEmployeeStatistics()
        {
            string query = @"SELECT YEAR(endContract) AS Year, MONTH(endContract) AS Month, COUNT(*) AS Count
                     FROM ExEmployees
                     GROUP BY YEAR(endContract), MONTH(endContract)
                     ORDER BY Year, Month;";
            Dictionary<DateTime, int> stats = new Dictionary<DateTime, int>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = new DateTime((int)reader["Year"], (int)reader["Month"], 1);
                        stats[date] = (int)reader["Count"];
                    }
                }
                connection.Close();
            }
            return stats;
        }

        public Dictionary<int, string> GetAllDepartments()
        {
            string query = "SELECT departmentId, name FROM Departments";
            Dictionary<int, string> departments = new Dictionary<int, string>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["departmentId"];
                        string name = (string)reader["name"];
                        departments[id] = name;
                    }
                }
                connection.Close();
            }
            return departments;
        }

        public int GetEmployeeCountByDepartment(int departmentId)
        {
            string query = @"SELECT COUNT(*) AS Count
                     FROM Employees
                     WHERE departmentId = @departmentId";
            int count = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@departmentId", departmentId);
                connection.Open();
                count = (int)command.ExecuteScalar();
                connection.Close();
            }
            return count;
        }

        public Dictionary<int, int> GetAllDepartmentEmployeeCounts()
        {
            string query = @"SELECT departmentId, COUNT(*) AS Count
                     FROM Employees
                     GROUP BY departmentId;";
            Dictionary<int, int> stats = new Dictionary<int, int>();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int departmentId = (int)reader["departmentId"];
                        int count = (int)reader["Count"];
                        stats[departmentId] = count;
                    }
                }
                connection.Close();
            }
            return stats;
        }

    }
}
