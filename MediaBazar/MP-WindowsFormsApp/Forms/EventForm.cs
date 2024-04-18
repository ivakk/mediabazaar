using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_WindowsFormsApp.UserControls;

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


        public EventForm(ScheduleForm scheduleForm)
        {
            InitializeComponent();
           _scheduleForm = scheduleForm;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string shiftName = comboBox1.SelectedItem.ToString();

            // Get employee name
            string employeeName = textBox1.Text;

            // Get selected event type
            string eventType = comboBoxEventType.SelectedItem.ToString();

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

        private void InsertEventData(int shiftID, string employeeName, string eventType, DateTime eventDate, string comments)
        {
            // Insert event data into the database
            string connectionString = "Server = mssqlstud.fhict.local; Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = "INSERT INTO Events (ShiftID, EmployeeName, EventType, EventDate, Comments) " +
                           "VALUES (@ShiftID, @EmployeeName, @EventType, @EventDate, @Comments)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShiftID", shiftID);
                command.Parameters.AddWithValue("@EmployeeName", employeeName);
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
    }
}
