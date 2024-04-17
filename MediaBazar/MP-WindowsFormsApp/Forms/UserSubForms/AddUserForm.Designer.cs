namespace MP_WindowsFormsApp.Forms.UserSubForms
{
    partial class AddUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label10 = new Label();
            dtpContractEnd = new DateTimePicker();
            label9 = new Label();
            dtpContractStart = new DateTimePicker();
            cbSalaryLevel = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            dtpbirthday = new DateTimePicker();
            label5 = new Label();
            cbDepartment = new ComboBox();
            label3 = new Label();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbLastName = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            tbFirstName = new TextBox();
            label1 = new Label();
            cbPosition = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(cbPosition);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpContractEnd);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtpContractStart);
            groupBox1.Controls.Add(cbSalaryLevel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpbirthday);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbDepartment);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbPhoneNumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(465, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 680);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD USER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(53, 545);
            label10.Name = "label10";
            label10.Size = new Size(125, 25);
            label10.TabIndex = 31;
            label10.Text = "Contract end:";
            // 
            // dtpContractEnd
            // 
            dtpContractEnd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpContractEnd.Format = DateTimePickerFormat.Short;
            dtpContractEnd.ImeMode = ImeMode.NoControl;
            dtpContractEnd.Location = new Point(189, 539);
            dtpContractEnd.Name = "dtpContractEnd";
            dtpContractEnd.Size = new Size(262, 32);
            dtpContractEnd.TabIndex = 30;
            dtpContractEnd.Value = new DateTime(2023, 11, 7, 12, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(53, 507);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 29;
            label9.Text = "Contract start:";
            // 
            // dtpContractStart
            // 
            dtpContractStart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpContractStart.Format = DateTimePickerFormat.Short;
            dtpContractStart.ImeMode = ImeMode.NoControl;
            dtpContractStart.Location = new Point(189, 501);
            dtpContractStart.Name = "dtpContractStart";
            dtpContractStart.Size = new Size(262, 32);
            dtpContractStart.TabIndex = 28;
            dtpContractStart.Value = new DateTime(2023, 11, 7, 12, 0, 0, 0);
            // 
            // cbSalaryLevel
            // 
            cbSalaryLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbSalaryLevel.FormattingEnabled = true;
            cbSalaryLevel.Items.AddRange(new object[] { "Low - 1000 euro", "Medium - 2000 euro ", "High - 3000 euro" });
            cbSalaryLevel.Location = new Point(175, 462);
            cbSalaryLevel.Name = "cbSalaryLevel";
            cbSalaryLevel.Size = new Size(276, 33);
            cbSalaryLevel.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(53, 465);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 27;
            label8.Text = "Salary level:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 430);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 25;
            label6.Text = "Birthday:";
            // 
            // dtpbirthday
            // 
            dtpbirthday.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpbirthday.Format = DateTimePickerFormat.Short;
            dtpbirthday.ImeMode = ImeMode.NoControl;
            dtpbirthday.Location = new Point(175, 424);
            dtpbirthday.Name = "dtpbirthday";
            dtpbirthday.Size = new Size(276, 32);
            dtpbirthday.TabIndex = 24;
            dtpbirthday.Value = new DateTime(2023, 11, 7, 12, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 389);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 22;
            label5.Text = "Position:";
            // 
            // cbDepartment
            // 
            cbDepartment.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(175, 347);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(276, 33);
            cbDepartment.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 350);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 20;
            label3.Text = "Department:";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.Location = new Point(51, 304);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(400, 32);
            tbPhoneNumber.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(51, 275);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 18;
            label7.Text = "Phone number";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(53, 240);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(400, 32);
            tbEmail.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 211);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 16;
            label4.Text = "Email address";
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(53, 176);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(400, 32);
            tbLastName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 147);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(316, 613);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 43);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.Location = new Point(51, 112);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(400, 32);
            tbFirstName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 83);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // cbPosition
            // 
            cbPosition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "worker", "manager" });
            cbPosition.Location = new Point(175, 386);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(276, 33);
            cbPosition.TabIndex = 32;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 1000);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            Text = "AddUserForm";
            Load += AddUserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox tbFirstName;
        private Label label1;
        private TextBox tbPhoneNumber;
        private Label label7;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbLastName;
        private Label label2;
        private ComboBox cbDepartment;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpbirthday;
        private Label label6;
        private ComboBox cbSalaryLevel;
        private Label label8;
        private Label label10;
        private DateTimePicker dtpContractEnd;
        private Label label9;
        private DateTimePicker dtpContractStart;
        private ComboBox cbPosition;
    }
}