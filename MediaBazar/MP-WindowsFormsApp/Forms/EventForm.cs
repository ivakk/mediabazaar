using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.Services.Common;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MP_WindowsFormsApp.Forms
{
    public partial class EventForm : Form
    {

        // Define shift start and end times
        Dictionary<string, Tuple<TimeSpan, TimeSpan>> shiftTimes = new Dictionary<string, Tuple<TimeSpan, TimeSpan>>
        {
            { "Morning Shift", Tuple.Create(new TimeSpan(8, 0, 0), new TimeSpan(12, 30, 0)) },
            { "Afternoon Shift", Tuple.Create(new TimeSpan(12, 30, 0), new TimeSpan(17, 0, 0)) },
            { "Evening Shift", Tuple.Create(new TimeSpan(17, 0, 0), new TimeSpan(23, 30, 0)) }
        };
        private ScheduleForm _scheduleForm;
        private UserService userService;
        private DepartmentService departmentService;


        public EventForm(ScheduleForm scheduleForm)
        {
            InitializeComponent();
            _scheduleForm = scheduleForm;
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));

            comboBoxEventType.Items.Add("");
            comboBoxEventType.Items.AddRange(departmentService.GetAllDepartments().ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Select a shift!");
            }
            else
            {
                string shiftName = comboBox1.SelectedItem.ToString();
                // Get employee name
                string employeeName = comboBox2.Text;

                // Get selected event type
                string eventType = "Shift";

                // Get event date
                DateTime eventDate = DateTime.Now; // Initialize with current date
                if (!string.IsNullOrEmpty(txbDate.Text))
                {
                    if (DateTime.TryParse(txbDate.Text, out DateTime parsedDate))
                    {
                        eventDate = parsedDate;
                    }
                }

                // Get additional comments
                string comments = textBox2.Text;

                // Get shift ID from database based on shift name
                int shiftID = GetShiftID(shiftName);

                // Insert event data into the database
                InsertEventData(shiftID, employeeName, eventType, eventDate, comments);
                _scheduleForm.RefreshSchedule();

                MessageBox.Show("Event saved successfully.");
            }


        }


        private int GetShiftID(string shiftName)
        {
            // Connect to database and retrieve ShiftID based on ShiftName
            string connectionString = "Server = mssqlstud.fhict.local; Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = "SELECT ShiftID FROM Shifts WHERE ShiftName = @ShiftName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShiftName", shiftName);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }

            throw new ArgumentException("Shift not found in the database.");
        }

        private void InsertEventData(int shiftID, int employeeId, string eventType, DateTime eventDate, string comments)
        {
            // Insert event data into the database
            string connectionString = "Server = mssqlstud.fhict.local; Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = "INSERT INTO Events (ShiftID, EmployeeId, EventType, EventDate, Comments) " +
                           "VALUES (@ShiftID, @EmployeeId, @EventType, @EventDate, @Comments)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShiftID", shiftID);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@EventType", eventType);
                command.Parameters.AddWithValue("@EventDate", eventDate);
                command.Parameters.AddWithValue("@Comments", comments);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txbDate.Text = ScheduleForm.static_month + "/" + UserControlDays.static_day + "/" + ScheduleForm.static_year;
        }

        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));
            comboBox2.Items.Clear();
            var users = userService.GetUsersByDepartment(departmentService.GetDepartmentByName(comboBoxEventType.Text.ToString()).Id).ToArray();
            foreach (var u in users)
            {
                comboBox2.Items.Add(u.FirstName + " " + u.LastName);
            }

        }

        private void buttonAutoSchedule_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(comboBoxEventType.SelectedItem?.ToString()) ||
            //    string.IsNullOrEmpty(comboBox1.SelectedItem?.ToString()) ||
            //    !DateTime.TryParse(txbDate.Text, out DateTime eventDate))
            //{
            //    MessageBox.Show("Please select a department, shift time, and a valid date.");
            //    return;
            //}

            //string departmentName = comboBoxEventType.SelectedItem.ToString();
            //string shiftTime = comboBox1.SelectedItem.ToString();
            //int departmentId = departmentService.GetDepartmentByName(departmentName).Id;
            //var leastWorkedEmployee = GetLeastWorkedEmployee(departmentId);

            //if (leastWorkedEmployee == null)
            //{
            //    MessageBox.Show("No employees available for scheduling.");
            //    return;
            //}

            //int shiftID = GetShiftID(shiftTime);
            //InsertEventData(shiftID, $"{leastWorkedEmployee.FirstName} {leastWorkedEmployee.LastName}", "Shift", eventDate, departmentName);
            //_scheduleForm.RefreshSchedule();

            //MessageBox.Show($"Shift assigned to {leastWorkedEmployee.FirstName} {leastWorkedEmployee.LastName} successfully.");
        }
        private User GetLeastWorkedEmployee(int departmentId)
        {
            //User leastWorkedEmployee = null;

            //string connectionString = "Server=mssqlstud.fhict.local;Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            //string query = @"
            //    SELECT u.employeeId, u.firstName, u.lastName, COUNT(e.EventId) AS ShiftCount
            //    FROM Employees u
            //    LEFT JOIN Events e ON u.id = e.employeeId
            //    WHERE u.departmentId = @departmentId
            //    GROUP BY u.employeeID, u.firstName, u.lastName
            //    ORDER BY COUNT(e.EventID) ASC";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@DepartmentID", departmentId);

            //    connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            leastWorkedEmployee = new User((int)reader.GetValue(0), (string)reader.GetValue(1),
            //            (string)reader.GetValue(2), (string)reader.GetValue(3),
            //            (string)reader.GetValue(4), ((string)reader.GetValue(5)).Trim(),
            //            (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
            //            (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
            //            (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
            //            (int)reader.GetValue(12));
            //        }
            //    }
            //}

            //return leastWorkedEmployee;
        }
    }
}
