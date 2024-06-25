using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.UserControls;

namespace MP_WindowsFormsApp.Forms
{
    public partial class EventForm : Form
    {
        private ScheduleForm _scheduleForm;
        private UserService userService;
        private DepartmentService departmentService;

        // Define shift start and end times
        private Dictionary<string, Tuple<TimeSpan, TimeSpan>> shiftTimes = new Dictionary<string, Tuple<TimeSpan, TimeSpan>>
        {
            { "Morning Shift", Tuple.Create(new TimeSpan(8, 0, 0), new TimeSpan(12, 30, 0)) },
            { "Afternoon Shift", Tuple.Create(new TimeSpan(12, 30, 0), new TimeSpan(17, 0, 0)) },
            { "Evening Shift", Tuple.Create(new TimeSpan(17, 0, 0), new TimeSpan(23, 30, 0)) }
        };

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
            if (string.IsNullOrEmpty(comboBox1.SelectedItem?.ToString()))
            {
                MessageBox.Show("Select a shift!");
            }
            else
            {
                SaveEvent();
            }
        }

        private void SaveEvent()
        {
            string shiftName = comboBox1.SelectedItem.ToString();
            if (comboBox2.SelectedItem is ComboBoxItem selectedEmployee)
            {
                string eventType = "Shift";
                DateTime eventDate = DateTime.Now;

                if (!string.IsNullOrEmpty(txbDate.Text) && DateTime.TryParse(txbDate.Text, out DateTime parsedDate))
                {
                    eventDate = parsedDate;
                }

                string comments = textBox2.Text;
                int shiftID = GetShiftID(shiftName);

                InsertEventData(shiftID, selectedEmployee.EmployeeID, eventType, eventDate, comments);
                _scheduleForm.RefreshSchedule();

                MessageBox.Show("Event saved successfully.");
            }
            else
            {
                MessageBox.Show("Please select an employee.");
            }
        }

        private int GetShiftID(string shiftName)
        {
            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
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

        private void InsertEventData(int shiftID, int employeeID, string eventType, DateTime eventDate, string comments)
        {
            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = "INSERT INTO Events (ShiftID, EmployeeID, EventType, EventDate, Comments) " +
                           "VALUES (@ShiftID, @EmployeeID, @EventType, @EventDate, @Comments)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShiftID", shiftID);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@EventType", eventType);
                command.Parameters.AddWithValue("@EventDate", eventDate);
                command.Parameters.AddWithValue("@Comments", comments);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txbDate.Text = $"{ScheduleForm.static_month}/{UserControlDays.static_day}/{ScheduleForm.static_year}";
        }

        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentService = new DepartmentService(new DepartmentDAL());
            userService = new UserService(new UserDAL(departmentService));
            comboBox2.Items.Clear();

            var users = userService.GetUsersByDepartment(departmentService.GetDepartmentByName(comboBoxEventType.Text.ToString()).Id);
            foreach (var user in users)
            {
                comboBox2.Items.Add(new ComboBoxItem(user.Id, user.FirstName, user.LastName));
            }
        }

        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxEventType.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(comboBox1.SelectedItem?.ToString()) ||
                !DateTime.TryParse(txbDate.Text, out DateTime eventDate))
            {
                MessageBox.Show("Please select a department, shift time, and a valid date.");
                return;
            }

            string departmentName = comboBoxEventType.SelectedItem.ToString();
            string shiftTime = comboBox1.SelectedItem.ToString();
            int departmentId = departmentService.GetDepartmentByName(departmentName).Id;
            var leastWorkedEmployee = GetLeastWorkedEmployee(departmentId);

            if (leastWorkedEmployee == null)
            {
                MessageBox.Show("No employees available for scheduling.");
                return;
            }

            int shiftID = GetShiftID(shiftTime);
            InsertEventData(shiftID, leastWorkedEmployee.Id, "Shift", eventDate, departmentName);
            _scheduleForm.RefreshSchedule();

            MessageBox.Show($"Shift assigned to {leastWorkedEmployee.FirstName} {leastWorkedEmployee.LastName} successfully.");
        }

        private User GetLeastWorkedEmployee(int departmentId)
        {
            User leastWorkedEmployee = null;

            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = @"
                SELECT TOP 1 u.userId, u.firstName, u.lastName, COUNT(e.EventID) AS ShiftCount
                FROM Employees u
                LEFT JOIN Events e ON u.userId = e.EmployeeID
                WHERE u.departmentId = @DepartmentId
                GROUP BY u.userId, u.firstName, u.lastName
                ORDER BY COUNT(e.EventID) ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentId", departmentId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        leastWorkedEmployee = new User((int)reader.GetValue(0), (string)reader.GetValue(1),
                        (string)reader.GetValue(2), (string)reader.GetValue(3),
                        (string)reader.GetValue(4), (string)reader.GetValue(5),
                        (DateTime)reader.GetValue(6), (string)reader.GetValue(7),
                        (string)reader.GetValue(8), departmentService.GetDepartmentById((int)reader.GetValue(9)),
                        (DateTime)reader.GetValue(10), (DateTime)reader.GetValue(11),
                        (int)reader.GetValue(12));
                    }
                }
            }

            return leastWorkedEmployee;
        }
    }

    public class ComboBoxItem
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ComboBoxItem(int employeeID, string firstName, string lastName)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
