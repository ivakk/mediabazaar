using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_and_B
{
    public partial class ScheduleForm : Form
    {
        int month, year;

        public static int static_month, static_year;
        public ScheduleForm()
        {
            InitializeComponent();
        }
        private void Schedule_Load(object sender, EventArgs e)
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

            DateTime startOfTheMonth = new DateTime(year,month,1);

            int days = DateTime.DaysInMonth(year,month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) ;

            for(int i = 1;i <= dayOfTheWeek;i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            for(int i = 1; i <= days;i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
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

            month ++;
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
    }
}
