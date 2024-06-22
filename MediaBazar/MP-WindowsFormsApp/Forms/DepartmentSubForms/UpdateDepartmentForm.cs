using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class UpdateDepartmentForm : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly Department _department;

        public UpdateDepartmentForm(IDepartmentService departmentService, Department department)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _department = department;

            LoadDepartmentData();
        }

        private void LoadDepartmentData()
        {
            txtName.Text = _department.Name;
            txtDescription.Text = _department.Description;
            nudRequiredPersonnel.Value = _department.RequiredPersonnel;
            txtPositions.Text = _department.Positions;
            txtPointOfContact.Text = _department.PointOfContact;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                _department.Name = txtName.Text;
                _department.Description = txtDescription.Text;
                _department.RequiredPersonnel = (int)nudRequiredPersonnel.Value;
                _department.Positions = txtPositions.Text;
                _department.PointOfContact = txtPointOfContact.Text;

                _departmentService.UpdateDepartment(_department);
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return false;
            }
            if (nudRequiredPersonnel.Value <= 0)
            {
                MessageBox.Show("Required Personnel must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudRequiredPersonnel.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPositions.Text))
            {
                MessageBox.Show("Positions is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPositions.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPointOfContact.Text))
            {
                MessageBox.Show("Point Of Contact is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPointOfContact.Focus();
                return false;
            }

            return true;
        }
    }
}
