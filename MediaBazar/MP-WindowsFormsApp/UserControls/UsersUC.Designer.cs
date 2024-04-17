namespace MP_WindowsFormsApp.UserControls
{
    partial class UsersUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFirstName = new Label();
            lbLastName = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            lbEmail = new Label();
            lbDepartment = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstName.Location = new Point(3, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(214, 54);
            lbFirstName.TabIndex = 0;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbLastName.Location = new Point(3, 54);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(209, 54);
            lbLastName.TabIndex = 1;
            lbLastName.Text = "Last Name";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Red;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(546, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 43);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(546, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 43);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(8, 146);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(326, 37);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "emailAddress@gmail.com";
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbDepartment.Location = new Point(546, 50);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(104, 37);
            lbDepartment.TabIndex = 24;
            lbDepartment.Text = "ADMIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(546, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 25;
            label1.Text = "Department: ";
            // 
            // UsersUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(label1);
            Controls.Add(lbDepartment);
            Controls.Add(lbEmail);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Name = "UsersUC";
            Size = new Size(700, 200);
            Load += UsersUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFirstName;
        private Label lbLastName;
        private Button btnEdit;
        private Button btnDelete;
        private Label lbEmail;
        private Label lbDepartment;
        private Label label1;
    }
}
