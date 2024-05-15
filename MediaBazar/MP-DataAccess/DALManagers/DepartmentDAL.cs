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
    public class DepartmentDAL : Connection, IDepartmentDalManager
    {
        private readonly string tableName = "Departments";

        public DepartmentDAL() { }

        /**
         * Query that gets a specific department using id
         */
        public Department GetDepartmentById(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE departmentId = @departmentId";
            Department department = null;
            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@departmentId", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new Department((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2));
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
            return department;
        }

        /**
        * Query that gets all departments
        */
        public List<Department> GetAllDepartments()
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
                List<Department> departments = new List<Department>();

                while (reader.Read())
                {
                    departments.Add(new Department((int)reader.GetValue(0), (string)reader.GetValue(1), (string)reader.GetValue(2)));
                }
                return departments;
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
            return new List<Department>();
        }

        /**
        * Query that updates the department data
        */
        public bool UpdateDepartment(Department newDepartment)
        {
            string query =
                $"UPDATE {tableName} " +
                $"SET name = @name, accessString = @accessString " +
                $"WHERE departmentId = @departmentId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@departmentId", newDepartment.Id);
                command.Parameters.AddWithValue("@name", newDepartment.Name);
                command.Parameters.AddWithValue("@accessString", newDepartment.accessString);

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

        /**
        * Query that deletes a specific department using id
        */
        public bool DeleteDepartment(int id)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE departmentId = @departmentId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@departmentId", id);

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

        /**
        * Query that creates new department in the database
        */
        public bool CreateDepartment(Department newDepartment)
        {
            // Set up the query
            string query = $"INSERT INTO {tableName} (name, accessString) " +
                           $"VALUES (@name, @accessString)";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@name", newDepartment.Name);
            command.Parameters.AddWithValue("@accessString", newDepartment.accessString);

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
    }
}

