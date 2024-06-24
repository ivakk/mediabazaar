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
            dgvDepartments.Location = new Point(12, 12);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.RowHeadersWidth = 51;
            dgvDepartments.RowTemplate.Height = 29;
            dgvDepartments.Size = new Size(1000, 400);
            dgvDepartments.TabIndex = 0;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.Location = new Point(12, 430);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(100, 30);
            btnAddDepartment.TabIndex = 1;
            btnAddDepartment.Text = "Add";
            btnAddDepartment.UseVisualStyleBackColor = true;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // btnUpdateDepartment
            // 
            btnUpdateDepartment.Location = new Point(277, 431);
            btnUpdateDepartment.Name = "btnUpdateDepartment";
            btnUpdateDepartment.Size = new Size(100, 30);
            btnUpdateDepartment.TabIndex = 2;
            btnUpdateDepartment.Text = "Update";
            btnUpdateDepartment.UseVisualStyleBackColor = true;
            btnUpdateDepartment.Click += btnUpdateDepartment_Click;
            // 
            // btnDeleteDepartment
            // 
            btnDeleteDepartment.Location = new Point(144, 431);
            btnDeleteDepartment.Name = "btnDeleteDepartment";
            btnDeleteDepartment.Size = new Size(94, 29);
            btnDeleteDepartment.TabIndex = 3;
            btnDeleteDepartment.Text = "Delete";
            btnDeleteDepartment.UseVisualStyleBackColor = true;
            btnDeleteDepartment.Click += btnDeleteDepartment_Click_1;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 481);
            Controls.Add(btnDeleteDepartment);
            Controls.Add(btnUpdateDepartment);
            Controls.Add(btnAddDepartment);
            Controls.Add(dgvDepartments);
            Name = "DepartmentForm";
            Text = "Department Management";
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private Button btnDeleteDepartment;
    }
}
