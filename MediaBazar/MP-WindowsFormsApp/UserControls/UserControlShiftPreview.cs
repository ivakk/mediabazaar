using MP_SchedulingService;
using MP_SchedulingDAL;
using MP_WindowsFormsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.UserControls
{
    public partial class UserControlShiftPreview : UserControl
    {
        UserService um = new UserService();

        public DateTime dateTime { get; set; }
        public Color color { get; set; }
        public Color colorIncomplete { get; set; }
        public Color colorOvercomplete { get; set; }

        private AutoSchedulingPreview form;
        public int shiftNo { get; set; }
        public string day { get; set; }
        public int shiftDemand { get; set; }
        public List<Shift> shifts { get; set; }

        public UserControlShiftPreview(DateTime dateTime, List<Shift> shifts, AutoSchedulingPreview form, string day, int shift)
        {
            InitializeComponent();

            shiftDemand = 2;
            if (shift == 0)
            {
                shiftDemand = 1;
            }
            ShiftDemand.Value = shiftDemand;

            if (shifts.Where(s => s.Type == "Shift").Count() > 1)
            {
                ShiftDemand.Value = shifts.Where(s => s.Type == "Shift").Count();
                shiftDemand = shifts.Where(s => s.Type == "Shift").Count();
            }

            this.shifts = shifts;
            this.day = day;
            this.form = form;
            this.dateTime = dateTime;
            this.color = Color.ForestGreen;
            this.colorIncomplete = Color.Yellow;
            this.colorOvercomplete = Color.IndianRed;
        }

        private void UserControlShiftPreview_Load(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.dtpStart.Value = dateTime;
            form.dtpEnd.Value = dateTime.AddHours(4);
            form.dtpEnd.Value = dateTime.AddHours(4);
            UpdateFormUsers();
            form.RefreshAllColors();
        }

        private void ShiftDemand_ValueChanged(object sender, EventArgs e)
        {
            shiftDemand = (int)ShiftDemand.Value;
            UpdateColor();
        }

        //CUSTOM METHODS
        private void UpdateUsersText()
        {
            int available = 0;
            button1.Text = "\n";
            foreach (Shift shift in this.shifts)
            {
                if (shift.Type == "Shift")
                {
                    button1.Text += $"{shift.User.FirstName} {shift.User.LastName}\n";
                }
                else if (shift.Type == "Availability")
                {
                    available++;
                }
            }
            button1.Text += $"\n{available} Available";
        }
        public void UpdateColor()
        {
            if (shifts != null)
            {
                if (button1.Text == "Empty" && shifts.Count != 0)
                {
                    UpdateUsersText();
                }
            }

            if (shifts != null)
            {
                if (shifts.Where(s => s.Type == "Shift").Count() > shiftDemand)
                {
                    button1.BackColor = this.colorIncomplete;
                }
                else if (shifts.Where(s => s.Type == "Shift").Count() == shiftDemand)
                {
                    button1.BackColor = this.color;
                }
                else if (shifts.Where(s => s.Type == "Shift").Count() < shiftDemand)
                {
                    button1.BackColor = this.colorOvercomplete;
                }

                if (shifts.Count() == 0)
                {
                    button1.BackColor = Color.LightGray;
                }
            }

            if (form != null)
            {
                if (dateTime.CompareTo(form.dtpStart.Value) >= 0 &&
                                dateTime.CompareTo(form.dtpEnd.Value) < 0)
                {
                    button1.BackColor = Color.PaleGreen;
                }
            }

        }
        private void UpdateFormUsers()
        {
            List<User> availableUsers = new List<User>();
            List<User> scheduledUsers = new List<User>();
            if (shifts != null)
            {
                foreach (Shift shift in shifts)
                {
                    if (shift.Type == "Availability")
                        availableUsers.Add(shift.User);
                    else if (shift.Type == "Shift")
                        scheduledUsers.Add(shift.User);
                }
            }
            for (int i = 0; i < scheduledUsers.Count; i++)
            {
                for (int j = 0; j < availableUsers.Count; j++)
                {
                    if (scheduledUsers[i].Id == availableUsers[j].Id)
                    {
                        availableUsers.RemoveAt(j);
                        j--;
                    }
                }
            }
            form.dgvAvailableUsers.DataSource = availableUsers;
            form.dgvScheduledUsers.DataSource = scheduledUsers;
        }


    }
}
