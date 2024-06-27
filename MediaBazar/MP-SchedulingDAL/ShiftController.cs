using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            Shift shift = null;
            SqlCommand command = new SqlCommand(query, base.connection);

            try
            {
                // Add the parameters
                command.Parameters.AddWithValue("@shiftId", id);

                // Execute the query and get the data
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shift = new Shift((int)reader.GetValue(0), userController.GetUserById((int)reader.GetValue(1)),
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
            return shift;
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
            string query = $"INSERT INTO {tableName} (userId, startTime, endTime, description, shiftType, accepted) " +
                            $"VALUES (@userId, @startTime, @endTime, @description, @type, @accepted)";

            connection.Open();
            SqlCommand command = new SqlCommand(query, base.connection);
            command.Parameters.AddWithValue("@userId", shift.User.Id);
            command.Parameters.AddWithValue("@startTime", shift.StartTime);
            command.Parameters.AddWithValue("@endTime", shift.EndTime);
            command.Parameters.AddWithValue("@description", shift.Description);
            command.Parameters.AddWithValue("@type", shift.Type);
            command.Parameters.AddWithValue("@accepted", shift.State);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
                return false;
            }
        }

        public bool UpdateShiftStatus(int shiftId, int status)
        {
            Shift shift = GetShiftById(shiftId);
            if (shift != null && IsShiftAllowed(shift))
            {
                string query = $"UPDATE {tableName} SET accepted = @status WHERE shiftId = @shiftId";

                connection.Open();
                SqlCommand command = new SqlCommand(query, base.connection);
                command.Parameters.AddWithValue("@shiftId", shiftId);
                command.Parameters.AddWithValue("@status", status);

                try
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    connection.Close();
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Shift constraints not met.");
                return false;
            }
        }

        public bool IsShiftAllowed(Shift shift)
        {
            if (HasReachedMaxShiftsForDay(shift.User.Id, shift.StartTime))
            {
                return false;
            }

            if (!IsAdjacentShift(shift.User.Id, shift))
            {
                return false;
            }

            return true;
        }

        public bool HasReachedMaxShiftsForDay(int userId, DateTime shiftStartTime)
        {
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE userId = @userId AND CAST(startTime AS DATE) = @shiftDate AND accepted = '1'";
            SqlCommand command = new SqlCommand(query, base.connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@shiftDate", shiftStartTime.Date);
            int shiftCount = 0;
            try
            {
                connection.Open();
                shiftCount = (int)command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            connection.Close();

            return shiftCount >= 2;
        }

        public bool IsAdjacentShift(int userId, Shift shiftToBeScheduled)
        {
            // Retrieve all shifts for the user on the specific day
            string query = $"SELECT startTime, endTime FROM {tableName} WHERE userId = @userId AND accepted = 1";
            SqlCommand command = new SqlCommand(query, base.connection);
            command.Parameters.AddWithValue("@userId", userId);

            List<Shift> userShifts = new List<Shift>();

            try
            {
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime startTime = reader.GetDateTime(0);
                    DateTime endTime = reader.GetDateTime(1);
                    userShifts.Add(new Shift { StartTime = startTime, EndTime = endTime });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            // Filter the shifts for the specific day
            var shiftsOnDay = userShifts.Where(s => s.StartTime.Date == shiftToBeScheduled.StartTime.Date).ToList();

            // Check if the new shift is adjacent to any existing shifts
            if(shiftsOnDay.Count > 0 )
            {
                foreach (var shift in shiftsOnDay)
                {
                    if (shift.EndTime == shiftToBeScheduled.StartTime || shift.StartTime == shiftToBeScheduled.EndTime)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
            

            return false;
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
    }
}
