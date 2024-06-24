using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class DepartmentForm : Form
    {
        private readonly IDepartmentService departmentService;
        private readonly User loggedInUser;

        public DepartmentForm(IDepartmentService departmentService, User loggedInUser)
        {
            InitializeComponent();
            this.departmentService = departmentService;
            this.loggedInUser = loggedInUser;

            LoadDepartments();
            CheckUserAccess();
        }

        private void LoadDepartments()
        {
            var departments = departmentService.GetAllDepartments();
            dgvDepartments.DataSource = departments;

            // Hide the AccessString column
            dgvDepartments.Columns["AccessString"].Visible = false;

            // Resize the columns to fit the content
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CheckUserAccess()
        {
            string userPosition = loggedInUser.Position.ToLower().Trim();
            // Assuming you have a method to check if the user is HR or Admin
            if (userPosition == "admin" || userPosition == "hr" || userPosition == "manager")
            {
                btnAddDepartment.Enabled = true;
                btnUpdateDepartment.Enabled = true;
                btnDeleteDepartment.Enabled = true;
            }
            else
            {
                btnAddDepartment.Enabled = false;
                btnUpdateDepartment.Enabled = false;
                btnDeleteDepartment.Enabled = false;
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            // Open AddDepartmentForm for adding a new department
            var addDepartmentForm = new AddDepartmentForm(departmentService);
            addDepartmentForm.ShowDialog();
            LoadDepartments(); // Refresh the list after adding
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                var selectedDepartment = (Department)dgvDepartments.SelectedRows[0].DataBoundItem;
                var updateDepartmentForm = new UpdateDepartmentForm(departmentService, selectedDepartment);
                updateDepartmentForm.ShowDialog();
                LoadDepartments(); // Refresh the list after updating
            }
            else
            {
                MessageBox.Show("Please select a department to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDepartment_Click_1(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                var selectedDepartment = (Department)dgvDepartments.SelectedRows[0].DataBoundItem;
                var result = MessageBox.Show($"Are you sure you want to delete the department {selectedDepartment.Name}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    departmentService.DeleteDepartment(selectedDepartment.Id);
                    LoadDepartments(); // Refresh the list after deleting
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    