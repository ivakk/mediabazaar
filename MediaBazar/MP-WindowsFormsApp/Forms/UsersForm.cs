using CsvHelper;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess.DALManagers;
using MP_EntityLibrary;
using MP_WindowsFormsApp.Forms.ProductSubForms;
using MP_WindowsFormsApp.Forms.UserSubForms;
using MP_WindowsFormsApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class UsersForm : Form
    {
        private readonly IUserService userService;
        private readonly IDepartmentService departmentService;
        public MainForm mainForm;
        private User loggedInUser; // Add this property
        AddUserForm addUserForm;

        public UsersForm(MainForm mainForm, IUserService userService, IDepartmentService departmentService, User loggedInUser)
        {
            InitializeComponent();
            this.userService = userService;
            this.departmentService = departmentService;
            this.mainForm = mainForm;
            this.loggedInUser = loggedInUser; // Initialize the logged-in user

            addUserForm = new AddUserForm(this, loggedInUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mainForm.pnlMainForm.Controls.Clear();
            this.mainForm.pnlMainForm.Controls.Add(addUserForm);
            addUserForm.Show();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            foreach (Department dep in departmentService.GetAllDepartments())
            {
                cbDepartment.Items.Add(dep);
            }

            LoadUsers(userService.GetAllUsers());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchFirstName = tbSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchFirstName))
            {
                UserDAL userDAL = new UserDAL(departmentService);
                User foundUser = userDAL.GetUserByUserName(searchFirstName);

                if (foundUser != null)
                {
                    LoadUsers(new List<User> { foundUser });
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                LoadUsers(userService.GetAllUsers());
            }
        }

        public void LoadUsers(List<User> users)
        {
            flpUsers.Controls.Clear();
            foreach (User user in users)
            {
                UsersUC userControl = new UsersUC(user, this);
                flpUsers.Controls.Add(userControl);
                userControl.Show();
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department dep = (Department)cbDepartment.SelectedItem;
            LoadUsers(userService.GetUsersByDepartment(dep.Id));
        }
        private void SaveChangesToCsv(List<DownUser> changeRecords)
        {
            // Create a Reports folder on the Desktop if it doesn't exist
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportsFolderPath = Path.Combine(desktopPath, "users");

            if (!Directory.Exists(reportsFolderPath))
            {
                Directory.CreateDirectory(reportsFolderPath);
            }

            // Create a CSV file path
            string csvFilePath = Path.Combine(reportsFolderPath, $"Daily Report - {DateTime.Now:yyyy-MM-dd}.csv");

            // Write changes to the CSV file
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(changeRecords);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new UserDAL(new DepartmentService(new DepartmentDAL())));
            List<User> allUsers = userService.GetAllUsers();
            List<DownUser> downUsers = new List<DownUser>();

            foreach (var user in allUsers)
            {
                downUsers.Add(new DownUser(
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.Email,
                    user.PhoneNumber,
                    user.PhoneNumber, // Assuming PhoneNumber1 and PhoneNumber2 are the same
                    user.Birthdate,
                    user.Department,
                    user.StartContract,
                    user.EndContract,
                    user.SalaryLevel,
                    user.HoursWorked
                ));
            }

            // Save downUsers to CSV
            SaveChangesToCsv(downUsers);
        }

        private class DownUser
        {
            public int Id { get; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Position { get; set; }
            public DateTime Birthdate { get; set; }
            public Department Department { get; set; }
            public DateTime StartContract { get; set; }
            public DateTime EndContract { get; set; }
            public int SalaryLevel { get; set; }
            public int HoursWorked { get; set; }

            public DownUser() { }
            public DownUser( int id, string firstName, string lastName, string email, string phoneNumber, string position, DateTime birthdate, Department department, DateTime startContract, DateTime endContract, int salaryLevel, int hoursWorked ) 
            {
                id = Id;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                PhoneNumber = phoneNumber;
                Position = position;
                Birthdate = birthdate;
                Department = department;
                StartContract = startContract;
                EndContract = endContract;
                SalaryLevel = salaryLevel;
                HoursWorked = hoursWorked;
            }
        }
    }
}
