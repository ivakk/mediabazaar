using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_WindowsFormsApp.UserControls;
using static Microsoft.Azure.Pipelines.WebApi.PipelinesResources;

namespace MP_WindowsFormsApp.Forms
{
    public partial class ScheduleForm : Form
    {
        int month, year;

        public static int static_month, static_year;
        public MainForm mainForm;
        public ScheduleForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            dispalyDays();
        }
        public void RefreshSchedule()
        {
            dispalyDays(); 
        }
        private void dispalyDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lblDate.Text = monthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
            var eventsForMonth = GetShiftsForMonth(year, month);

            foreach (UserControlDays dayControl in dayContainer.Controls.OfType<UserControlDays>())
            {
                var dayEvents = eventsForMonth.Where(e => e.EventDate.Day == dayControl.DayNumber).ToList();

                // If there are any events for this day, display the first one
                if (dayEvents.Any())
                {
                    var eventInfo = dayEvents.First(); // This just takes the first event; you can adjust as needed
                    var shiftTimes = GetShiftTimes(eventInfo.ShiftID);
                    dayControl.SetShiftInfo(eventInfo.EmployeeName, shiftTimes.Item1, shiftTimes.Item2);
                    dayControl.Visible = true; // Ensure the control is visible
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;
            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lblDate.Text = monthName + " " + year;

            if (month < 1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;
            string monthName = DateTimeFormatInfo.CurrentInfo.MonthNames[month - 1];
            lblDate.Text = monthName + " " + year;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }
        private List<Event> GetShiftsForMonth(int year, int month)
        {
            var events = new List<Event>();
            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi503708_mp;User Id=dbi503708_mp; Password=password;";
            string query = "SELECT * FROM Events WHERE MONTH(EventDate) = @Month AND YEAR(EventDate) = @Year";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        events.Add(new Event
                        {
                            EventID = reader.GetInt32(reader.GetOrdinal("EventID")),
                            ShiftID = reader.GetInt32(reader.GetOrdinal("ShiftID")),
                            EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                            EventType = reader.GetString(reader.GetOrdinal("EventType")),
                            EventDate = reader.GetDateTime(reader.GetOrdinal("EventDate")),
                            Comments = reader.GetString(reader.GetOrdinal("Comments"))
                        });
                    }
                }
            }

            return events;
        }
        private Tuple<TimeSpan, TimeSpan> GetShiftTimes(int shiftId)
        {
            
            return shiftId switch
            {
                1 => Tuple.Create(new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0)),
                2 => Tuple.Create(new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0)),
                3 => Tuple.Create(new TimeSpan(16, 0, 0), new TimeSpan(20, 0, 0)),
                _ => Tuple.Create(new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0)),
            };
        }
    }
}
