using MP_BusinessLogic.InterfacesLL;
using MP_EntityLibrary;
using System;
using System.Windows.Forms;

namespace MP_WindowsFormsApp.Forms
{
    public partial class AddDepartmentForm : Form
    {
        private readonly IDepartmentService _departmentService;

        public AddDepartmentForm(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var department = new Department(
                    0,
                    txtName.Text,
                    "",
                    txtDescription.Text,
                    (int)nudRequiredPersonnel.Value,
                    txtPositions.Text,
                    txtPointOfContact.Text
                );

                _departmentService.CreateDepartment(department);
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
                MessageBox.Show("Required Personnel must be a valid number greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtRequiredPersonnel_TextChanged(object sender, EventArgs e)
        {
            // You can add additional logic here if needed
        }
    }
}
