using MP_SchedulingDAL;
using MP_SchedulingService;
using MP_WindowsFormsApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class AutoSchedulingPreview : Form
    {
        ShiftService shiftService = new ShiftService();
        ShiftController shiftsManager = new ShiftController();
        UserService userService = new UserService();
        DepartmentService departmentService = new DepartmentService();

        public MainForm form { get; set; }
        public List<List<UserControlShiftPreview>> UserControls { get; set; }
        public DateTime dateOfFirstDay { get; set; }
        public List<Shift> weekShifts { get; set; }
        DateTime start;
        DateTime end;
        public AutoSchedulingPreview(List<Shift> shifts, DateTime start, DateTime end, MainForm form)
        {
            InitializeComponent();
            weekShifts = shifts;
            dateOfFirstDay = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday); ;
            UserControls = new List<List<UserControlShiftPreview>>();
            for (int h = 0; h < 3; h++)
            {
                UserControls.Add(new List<UserControlShiftPreview>());
                for (int d = 0; d < 7; d++)
                {
                    UserControls[h].Add(new UserControlShiftPreview(DateTime.Now, new List<Shift>(), this, "", h));
                }
            }

            this.start = start;
            this.end = end;
            this.form = form;
        }

        private void AutoSchedulingPreview_Load(object sender, EventArgs e)
        {
            LoadCalendar(dateOfFirstDay);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dateOfFirstDay = dateOfFirstDay.AddDays(-7);
            LoadCalendar(dateOfFirstDay);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            dateOfFirstDay = dateOfFirstDay.AddDays(7);
            LoadCalendar(dateOfFirstDay);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(userService.GetBySearch(tbSearch.Text));
        }
        private void dgvAvailableUsers_SelectionChanged(object sender, EventArgs e)
        {
            User user = GetSelectedUser();
            if (user != null)
            {
                lblSelectedEmployee.Text = $"{user.FirstName} {user.LastName} : {user.Department}";
            }
            else
            {
                lblSelectedEmployee.Text = "NONE!";
            }
        }
        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            Shift corShift = weekShifts.Find(s => s.User.Id == GetSelectedUser().Id &&
            s.StartTime == dtpStart.Value && s.EndTime == dtpEnd.Value);
            if (corShift != null)
            {
                weekShifts.Add(new Shift(
                                corShift.ShiftId, GetSelectedUser(), dtpStart.Value, dtpEnd.Value, tbDescription.Text, "Shift", 1
                                ));
            }
            else
            {
                weekShifts.Add(new Shift(
                                0, GetSelectedUser(), dtpStart.Value, dtpEnd.Value, tbDescription.Text, "Shift", 1
                                ));
            }

            LoadCalendar(dateOfFirstDay);
        }
        //CUSTOM METHODS
        public void LoadCalendar(DateTime dateOfFirstDay)
        {
            System.Diagnostics.Debug.WriteLine("Load Calendar!");
            List<string> days = new List<string>() { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            dayContainer.Controls.Clear();
            for (int h = 0; h < 3; h++)
            {
                for (int d = 0; d < 7; d++)
                {
                    UserControls[h][d] = new UserControlShiftPreview(
                                                dateOfFirstDay.AddDays(d).AddHours(8 + h * 4),
                                                CheckForShift(dateOfFirstDay.AddDays(d).AddHours(8 + h * 4)), this,
                                                days[d], h);
                    dayContainer.Controls.Add(UserControls[h][d]);
                }

            }

            lblDate1.Text = dateOfFirstDay.AddDays(0).ToString("dd MM");
            lblDate2.Text = dateOfFirstDay.AddDays(1).ToString("dd MM");
            lblDate3.Text = dateOfFirstDay.AddDays(2).ToString("dd MM");
            lblDate4.Text = dateOfFirstDay.AddDays(3).ToString("dd MM");
            lblDate5.Text = dateOfFirstDay.AddDays(4).ToString("dd MM");
            lblDate6.Text = dateOfFirstDay.AddDays(5).ToString("dd MM");
            lblDate7.Text = dateOfFirstDay.AddDays(6).ToString("dd MM");
        }
        private User GetSelectedUser()
        {
            try
            {
                int selectedrowindex = dgvAvailableUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAvailableUsers.Rows[selectedrowindex];
                return (User)selectedRow.DataBoundItem;
            }
            catch
            {
                return null;
            }
        }
        public void RefreshAllColors()
        {
            for (int h = 0; h < 3; h++)
            {
                for (int d = 0; d < 7; d++)
                {
                    UserControls[h][d].UpdateColor();
                }
            }
        }
        private List<Shift> CheckForShift(DateTime dateTime)
        {
            List<Shift> list = new List<Shift>();
            if (weekShifts != null)
            {
                foreach (Shift shift in weekShifts)
                {
                    if (dateTime.CompareTo(shift.StartTime) >= 0 &&
                        dateTime.AddHours(3).AddMinutes(59).CompareTo(shift.EndTime) <= 0)
                    {
                        list.Add(shift);
                    }
                }
            }
            return list;
        }
        public void LoadUsers(List<User> users)
        {
            dgvAvailableUsers.Controls.Clear();
            dgvAvailableUsers.DataSource = users;
        }

        private void btnDisregard_Click(object sender, EventArgs e)
        {
            form.menuButtons.Where(mb => mb.ButtonText == "Shifts").ToList()[0].Button_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            shiftService.SaveAutoScheduling(start, end, weekShifts);
            form.menuButtons.Where(mb => mb.ButtonText == "Shifts").ToList()[0].Button_Click(sender, e);
            form.shiftManagementForm.LoadCalendar(form.shiftManagementForm.dateOfFirstDay);
        }
    }
}
