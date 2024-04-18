using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MP_WindowsFormsApp.Forms;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class UserControlDays : UserControl
    {
        public static string  static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void Days(int number)
        {
            lblDay.Text = number + "";
        }
                
        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDay.Text;
            EventForm eventForm = new EventForm(this.ParentForm as ScheduleForm);
            eventForm.Show();

        }
        private void displyEvent()
        {

        }
        public void SetShiftInfo(string employeeName, TimeSpan startTime, TimeSpan endTime)
        {
            lblEmployeeName.Text = employeeName;
            lblShiftTime.Text = $"{startTime} - {endTime}";
        }
        public int DayNumber => int.TryParse(lblDay.Text, out var day) ? day : 0;

    }
}
