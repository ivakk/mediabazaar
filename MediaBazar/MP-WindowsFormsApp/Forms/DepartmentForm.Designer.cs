namespace MP_WindowsFormsApp.Forms
{
    partial class DepartmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvDepartments = new DataGridView();
            btnAddDepartment = new Button();
            btnUpdateDepartment = new Button();
            btnDeleteDepartment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartments
            // 
            dgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Location = new Point(10, 9);
            dgvDepartments.Margin = new Padding(3, 2, 3, 2);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.RowTemplate.Height = 29;
            dgvDepartments.Size = new Size(1412, 826);
            dgvDepartments.TabIndex = 0;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDepartment.Location = new Point(178, 853);
            btnAddDepartment.Margin = new Padding(3, 2, 3, 2);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(184, 61);
            btnAddDepartment.TabIndex = 1;
            btnAddDepartment.Text = "ADD";
            btnAddDepartment.UseVisualStyleBackColor = true;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // btnUpdateDepartment
            // 
            btnUpdateDepartment.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateDepartment.Location = new Point(999, 853);
            btnUpdateDepartment.Margin = new Padding(3, 2, 3, 2);
            btnUpdateDepartment.Name = "btnUpdateDepartment";
            btnUpdateDepartment.Size = new Size(221, 61);
            btnUpdateDepartment.TabIndex = 2;
            btnUpdateDepartment.Text = "Update";
            btnUpdateDepartment.UseVisualStyleBackColor = true;
            btnUpdateDepartment.Click += btnUpdateDepartment_Click;
            // 
            // btnDeleteDepartment
            // 
            btnDeleteDepartment.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteDepartment.Location = new Point(581, 853);
            btnDeleteDepartment.Margin = new Padding(3, 2, 3, 2);
            btnDeleteDepartment.Name = "btnDeleteDepartment";
            btnDeleteDepartment.Size = new Size(210, 61);
            btnDeleteDepartment.TabIndex = 3;
            btnDeleteDepartment.Text = "Delete";
            btnDeleteDepartment.UseVisualStyleBackColor = true;
            btnDeleteDepartment.Click += btnDeleteDepartment_Click_1;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 961);
            Controls.Add(btnDeleteDepartment);
            Controls.Add(btnUpdateDepartment);
            Controls.Add(btnAddDepartment);
            Controls.Add(dgvDepartments);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DepartmentForm";
            Text = "Department Management";
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDepartments;
        private Button btnAddDepartment;
        private Button btnUpdateDepartment;
        private Button btnDeleteDepartment;
    }
}
