using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;

namespace CalendarApp.Pages
{
    public class CalendarModel : PageModel
    {
        public string EventsJson { get; private set; }

        public void OnGet(int month, int year)
        {
            var events = GetShiftsForMonth(year, month);
            EventsJson = JsonConvert.SerializeObject(events.Select(e => new
            {
                title = $"{e.EmployeeName} - {e.EventType}",
                start = e.EventDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                end = e.EventDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                description = e.Comments
            }));
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

        public class Event
        {
            public int EventID { get; set; }
            public int ShiftID { get; set; }
            public string EmployeeName { get; set; }
            public string EventType { get; set; }
            public DateTime EventDate { get; set; }
            public string Comments { get; set; }
        }
    }
}
