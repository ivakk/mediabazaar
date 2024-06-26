using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingDAL
{
    public class ShiftController : Connection
    {
        private readonly string tableName = "Shifts";

        private UserController userController = new UserController();

        public ShiftController()
        {    
        }
        public List<Shift> GetAll()
        {
            string query = $"SELECT * FROM {tableName} ";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                List<Shift> shifts = new List<Shift>();
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shifts.Add(new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4),
                        (string)reader.GetValue(5), (int)reader.GetValue(6)));
                }

                return shifts;
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
            return new List<Shift>();

        }
        public Shift GetShiftById(int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE shiftId = @shiftId";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shiftId", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4),
                        (string)reader.GetValue(5), (int)reader.GetValue(6));
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
            return new Shift();
        }
        public List<Shift> GetAllShiftsOfUser(int userId)
        {
            string query = $"SELECT * FROM {tableName} WHERE userId = @userId";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@userId", userId);
                List<Shift> shifts = new List<Shift>();
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shifts.Add(new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4), 
                        (string)reader.GetValue(5), (int)reader.GetValue(6)));
                }

                return shifts;
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
            return new List<Shift>();
        }
        public List<Shift> GetAllByShiftType(string shiftType)
        {
            string query = $"SELECT * FROM {tableName} WHERE shiftType = @shiftType";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shiftType", shiftType);
                List<Shift> shifts = new List<Shift>();
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shifts.Add(new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4),
                        (string)reader.GetValue(5), (int)reader.GetValue(6)));
                }

                return shifts;
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
            return new List<Shift>();
        }
        public List<Shift> GetShiftsForWeek(DateTime weekStart)
        {
            string query = $"SELECT * FROM {tableName} WHERE startTime >= @shift_start AND endTime <= @shift_end AND (shiftType=@shiftType OR shiftType=@shiftType2)";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shift_start", weekStart);
                command.Parameters.AddWithValue("@shift_end", weekStart.AddDays(7));
                command.Parameters.AddWithValue("@shiftType", "Availability");
                command.Parameters.AddWithValue("@shiftType2", "Shift");

                List<Shift> shifts = new List<Shift>();
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shifts.Add(new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4),
                        (string)reader.GetValue(5), (int)reader.GetValue(6)));
                }

                return shifts;
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
            return new List<Shift>();
        }
        public List<Shift> GetShiftsForPeriod(DateTime start, DateTime end)
        {
            string query = $"SELECT * FROM {tableName} WHERE startTime >= @shift_start AND endTime <= @shift_end AND (shiftType=@shiftType OR shiftType=@shiftType2)";

            // Open the connection
            connection.Open();

            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shift_start", start);
                command.Parameters.AddWithValue("@shift_end", end);
                command.Parameters.AddWithValue("@shiftType", "Availability");
                command.Parameters.AddWithValue("@shiftType2", "Shift");

                List<Shift> shifts = new List<Shift>();
                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shifts.Add(new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
                        (DateTime)reader.GetValue(2), (DateTime)reader.GetValue(3), (string)reader.GetValue(4),
                        (string)reader.GetValue(5), (int)reader.GetValue(6)));
                }

                return shifts;
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
            return new List<Shift>();
        }
        public bool CreateShift(Shift shift)
        {

            // Set up the query
            string query = $"INSERT INTO {tableName} (userId, startTime, endTime, description, shiftType, accepted) " +
                            $"VALUES ( @userId, @startTime, @endTime, @description, @type, @accepted)";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@userId", shift.User.Id);
            command.Parameters.AddWithValue("@startTime", shift.StartTime);
            command.Parameters.AddWithValue("@endTime", shift.EndTime);
            command.Parameters.AddWithValue("@description", shift.Description);
            command.Parameters.AddWithValue("@type", shift.Type);
            command.Parameters.AddWithValue("@accepted", shift.State);

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

                connection.Close();
                return false;
            }
        }
        public void DeleteShift(int shiftId)
        {
            // Set up the query
            string query = $"DELETE FROM {tableName} WHERE shiftId = @shiftId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            // Add the parameters
            command.Parameters.AddWithValue("@shiftId", shiftId);

            try
            {
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

        public bool UpdateShiftStatus(int shiftId, int status)
        {
            string query =
                $"UPDATE {tableName} " +
                $"SET accepted = @status " +
                $"WHERE shiftId = @shiftId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shiftId", shiftId);
                command.Parameters.AddWithValue("@status", status);


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
        public bool UpdateShiftType(int shiftId, string type)
        {
            string query =
                $"UPDATE {tableName} " +
                $"SET shiftType = @type " +
                $"WHERE shiftId = @shiftId";

            // Open the connection
            connection.Open();

            // Creating Command string to combine the query and the connection String
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shiftId", shiftId);
                command.Parameters.AddWithValue("@type", type);


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
    }
}
