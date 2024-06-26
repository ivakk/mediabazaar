using MP_DataAccess.DALManagers;
using MP_BusinessLogic.Entities;
using MP_WindowsFormsApp;
using MP_WindowsFormsApp.Forms;
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
using MP_SchedulingService;
using MP_SchedulingDAL;

namespace MP_WindowsFormsApp.Forms
{
    public partial class ShiftManagement : Form
    {
        ShiftService shiftService = new ShiftService();
        ShiftController shiftsManager = new ShiftController();
        UserService userService = new UserService();
        DepartmentService departmentService = new DepartmentService();

        public MainForm form { get; set; }
        public List<List<UserControlShift>> UserControls { get; set; }
        public DateTime dateOfFirstDay { get; set; }
        public List<Shift> weekShifts { get; set; }
        public List<Shift> selectedShifts { get; set; }

        public ShiftManagement(MainForm layoutForm)
        {
            InitializeComponent();
            this.form = layoutForm;
            dateOfFirstDay = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            AutoScheduleStart.Value = dateOfFirstDay;
            AutoScheduleEnd.Value = dateOfFirstDay.AddDays(6);
            UserControls = new List<List<UserControlShift>>();
            for (int h = 0; h < 3; h++)
            {
                UserControls.Add(new List<UserControlShift>());
                for (int d = 0; d < 7; d++)
                {
                    UserControls[h].Add(new UserControlShift(DateTime.Now, new List<Shift>(), this, "", h));
                }
            }


        }
        private void PlanningWeekly_Load(object sender, EventArgs e)
        {
            weekShifts = shiftsManager.GetShiftsForWeek(dateOfFirstDay);
            LoadCalendar(dateOfFirstDay);
            LoadDepartments();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            dateOfFirstDay = dateOfFirstDay.AddDays(-7);
            AutoScheduleStart.Value = dateOfFirstDay;
            AutoScheduleEnd.Value = dateOfFirstDay.AddDays(6);
            weekShifts = shiftsManager.GetShiftsForWeek(dateOfFirstDay);
            LoadCalendar(dateOfFirstDay);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            dateOfFirstDay = dateOfFirstDay.AddDays(7);
            AutoScheduleStart.Value = dateOfFirstDay;
            AutoScheduleEnd.Value = dateOfFirstDay.AddDays(6);
            weekShifts = shiftsManager.GetShiftsForWeek(dateOfFirstDay);
            LoadCalendar(dateOfFirstDay);
        }
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(userService.GetBySearch(tbSearch.Text));
        }
        private void btnDepartmentSearch_Click(object sender, EventArgs e)
        {
            Department dep = (Department)cboDepartmens.SelectedItem;
            dgvAvailableUsers.DataSource = userService.GetUsersByDepartment(dep.Id);
            weekShifts = shiftsManager.GetShiftsForWeek(dateOfFirstDay);
            weekShifts = weekShifts.Where(shift => shift.User.Department.Id == dep.Id).ToList();
            LoadCalendar(dateOfFirstDay);
        }
        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            try
            {
                Shift newShift = new Shift();
                newShift.User = GetSelectedUser();
                newShift.StartTime = dtpStart.Value;
                newShift.EndTime = dtpEnd.Value;
                newShift.Description = tbDescription.Text;
                newShift.Type = "Shift";
                shiftsManager.CreateShift(newShift);
                foreach (Shift shift in selectedShifts)
                {
                    if (shift.User.Id == GetSelectedUser().Id &&
                        shift.Type == "Availability")
                        shiftsManager.DeleteShift(shift.ShiftId);
                }

                weekShifts = shiftsManager.GetShiftsForWeek(dateOfFirstDay);
            }
            catch
            {
                MessageBox.Show("You have no user selected or your dates are incorrect!");
            }

            LoadCalendar(dateOfFirstDay);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //AUTO SCHEDULING
            Department dep = (Department)cboDepartmens.SelectedItem;
            if (dep == null)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                List<Shift> autoSchedulingShifts = shiftService.AutoShedule(AutoScheduleStart.Value, AutoScheduleEnd.Value, dep.Id);
                AutoSchedulingPreview autoSchedulingPreview = new AutoSchedulingPreview(autoSchedulingShifts, AutoScheduleStart.Value, AutoScheduleEnd.Value, form) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
                form.pnlMainForm.Controls.Clear();
                form.pnlMainForm.Controls.Add(autoSchedulingPreview);
                autoSchedulingPreview.Show();
            }
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
                    UserControls[h][d] = new UserControlShift(
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
        public void LoadDepartments()
        {
            cboDepartmens.Items.Clear();
            foreach (Department dep in departmentService.GetAllDepartments())
            {
                cboDepartmens.Items.Add(dep);
            }
        }


    }
}
