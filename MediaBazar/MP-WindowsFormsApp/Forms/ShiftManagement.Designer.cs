namespace MP_WindowsFormsApp.Forms
{
    partial class ShiftManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnNext = new Button();
            lblDate7 = new Label();
            btnPrevious = new Button();
            lblDate5 = new Label();
            lblDate4 = new Label();
            lblDate3 = new Label();
            lblDate2 = new Label();
            lblDate6 = new Label();
            lblDate1 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label24 = new Label();
            label23 = new Label();
            date1 = new Label();
            lblShifts = new Label();
            dayContainer = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            label1 = new Label();
            tbDescription = new TextBox();
            lblSelectedEmployee = new Label();
            label31 = new Label();
            label32 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            btnCreateShift = new Button();
            label33 = new Label();
            cboDepartmens = new ComboBox();
            dgvAvailableUsers = new DataGridView();
            label4 = new Label();
            label19 = new Label();
            label9 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            AutoScheduleEnd = new DateTimePicker();
            button4 = new Button();
            AutoScheduleStart = new DateTimePicker();
            label8 = new Label();
            label2 = new Label();
            btnDepartmentSearch = new Button();
            label3 = new Label();
            btnSearch = new Button();
            tbSearch = new TextBox();
            groupBox1 = new GroupBox();
            dgvScheduledUsers = new DataGridView();
            label7 = new Label();
            label10 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableUsers).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduledUsers).BeginInit();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(204, 43, 29);
            btnNext.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(285, 51);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(158, 47);
            btnNext.TabIndex = 63;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblDate7
            // 
            lblDate7.AutoSize = true;
            lblDate7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate7.Location = new Point(1277, 138);
            lblDate7.Margin = new Padding(4, 0, 4, 0);
            lblDate7.Name = "lblDate7";
            lblDate7.Size = new Size(90, 29);
            lblDate7.TabIndex = 77;
            lblDate7.Text = "DATE1";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(204, 43, 29);
            btnPrevious.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(129, 51);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(152, 47);
            btnPrevious.TabIndex = 62;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblDate5
            // 
            lblDate5.AutoSize = true;
            lblDate5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate5.Location = new Point(928, 138);
            lblDate5.Margin = new Padding(4, 0, 4, 0);
            lblDate5.Name = "lblDate5";
            lblDate5.Size = new Size(90, 29);
            lblDate5.TabIndex = 76;
            lblDate5.Text = "DATE1";
            // 
            // lblDate4
            // 
            lblDate4.AutoSize = true;
            lblDate4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate4.Location = new Point(768, 138);
            lblDate4.Margin = new Padding(4, 0, 4, 0);
            lblDate4.Name = "lblDate4";
            lblDate4.Size = new Size(90, 29);
            lblDate4.TabIndex = 75;
            lblDate4.Text = "DATE1";
            // 
            // lblDate3
            // 
            lblDate3.AutoSize = true;
            lblDate3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate3.Location = new Point(571, 138);
            lblDate3.Margin = new Padding(4, 0, 4, 0);
            lblDate3.Name = "lblDate3";
            lblDate3.Size = new Size(90, 29);
            lblDate3.TabIndex = 74;
            lblDate3.Text = "DATE1";
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate2.Location = new Point(360, 138);
            lblDate2.Margin = new Padding(4, 0, 4, 0);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(90, 29);
            lblDate2.TabIndex = 73;
            lblDate2.Text = "DATE1";
            // 
            // lblDate6
            // 
            lblDate6.AutoSize = true;
            lblDate6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate6.Location = new Point(1077, 138);
            lblDate6.Margin = new Padding(4, 0, 4, 0);
            lblDate6.Name = "lblDate6";
            lblDate6.Size = new Size(90, 29);
            lblDate6.TabIndex = 72;
            lblDate6.Text = "DATE1";
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate1.Location = new Point(177, 138);
            lblDate1.Margin = new Padding(4, 0, 4, 0);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(90, 29);
            lblDate1.TabIndex = 71;
            lblDate1.Text = "DATE1";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(360, 104);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(106, 29);
            label30.TabIndex = 70;
            label30.Text = "Tuesday";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(545, 104);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(140, 29);
            label29.TabIndex = 69;
            label29.Text = "Wednesday";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(754, 104);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(113, 29);
            label28.TabIndex = 68;
            label28.Text = "Thursday";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(928, 104);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(80, 29);
            label27.TabIndex = 67;
            label27.Text = "Friday";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(1077, 104);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(107, 29);
            label24.TabIndex = 66;
            label24.Text = "Saturday";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(1273, 104);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(93, 29);
            label23.TabIndex = 65;
            label23.Text = "Sunday";
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            date1.Location = new Point(177, 104);
            date1.Margin = new Padding(4, 0, 4, 0);
            date1.Name = "date1";
            date1.Size = new Size(98, 29);
            date1.TabIndex = 64;
            date1.Text = "Monday";
            // 
            // lblShifts
            // 
            lblShifts.AutoSize = true;
            lblShifts.Dock = DockStyle.Top;
            lblShifts.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblShifts.Location = new Point(0, 0);
            lblShifts.Margin = new Padding(2, 0, 2, 0);
            lblShifts.Name = "lblShifts";
            lblShifts.Size = new Size(430, 55);
            lblShifts.TabIndex = 60;
            lblShifts.Text = "Shift Management";
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(129, 190);
            dayContainer.Margin = new Padding(0);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1307, 548);
            dayContainer.TabIndex = 78;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbDescription);
            groupBox2.Controls.Add(lblSelectedEmployee);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(dtpEnd);
            groupBox2.Controls.Add(dtpStart);
            groupBox2.Controls.Add(btnCreateShift);
            groupBox2.Controls.Add(label33);
            groupBox2.Location = new Point(1022, 743);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(419, 246);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 43, 29);
            label1.Location = new Point(20, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 29;
            label1.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(22, 170);
            tbDescription.Margin = new Padding(4, 3, 4, 3);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(252, 69);
            tbDescription.TabIndex = 28;
            // 
            // lblSelectedEmployee
            // 
            lblSelectedEmployee.AutoSize = true;
            lblSelectedEmployee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedEmployee.ForeColor = Color.FromArgb(204, 43, 29);
            lblSelectedEmployee.Location = new Point(32, 44);
            lblSelectedEmployee.Margin = new Padding(2, 0, 2, 0);
            lblSelectedEmployee.Name = "lblSelectedEmployee";
            lblSelectedEmployee.Size = new Size(63, 20);
            lblSelectedEmployee.TabIndex = 27;
            lblSelectedEmployee.Text = "NONE!";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.FromArgb(204, 43, 29);
            label31.Location = new Point(222, 67);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(135, 31);
            label31.TabIndex = 26;
            label31.Text = "End Date";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.FromArgb(204, 43, 29);
            label32.Location = new Point(16, 6);
            label32.Margin = new Padding(2, 0, 2, 0);
            label32.Name = "label32";
            label32.Size = new Size(273, 31);
            label32.TabIndex = 20;
            label32.Text = "Selected Employee:";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(222, 102);
            dtpEnd.Margin = new Padding(2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(186, 23);
            dtpEnd.TabIndex = 25;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(20, 102);
            dtpStart.Margin = new Padding(2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(192, 23);
            dtpStart.TabIndex = 21;
            // 
            // btnCreateShift
            // 
            btnCreateShift.BackColor = Color.FromArgb(204, 43, 29);
            btnCreateShift.Font = new Font("Arial Narrow", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateShift.ForeColor = SystemColors.Control;
            btnCreateShift.Location = new Point(280, 161);
            btnCreateShift.Margin = new Padding(2);
            btnCreateShift.Name = "btnCreateShift";
            btnCreateShift.Size = new Size(128, 78);
            btnCreateShift.TabIndex = 23;
            btnCreateShift.Text = "Create Shift";
            btnCreateShift.UseVisualStyleBackColor = false;
            btnCreateShift.Click += btnCreateShift_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.FromArgb(204, 43, 29);
            label33.Location = new Point(20, 69);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(158, 31);
            label33.TabIndex = 22;
            label33.Text = "Begin Date";
            // 
            // cboDepartmens
            // 
            cboDepartmens.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDepartmens.FormattingEnabled = true;
            cboDepartmens.Items.AddRange(new object[] { "HR", "Sales", "Warehouse" });
            cboDepartmens.Location = new Point(447, 52);
            cboDepartmens.Margin = new Padding(2);
            cboDepartmens.Name = "cboDepartmens";
            cboDepartmens.Size = new Size(189, 26);
            cboDepartmens.TabIndex = 15;
            // 
            // dgvAvailableUsers
            // 
            dgvAvailableUsers.AllowUserToAddRows = false;
            dgvAvailableUsers.AllowUserToDeleteRows = false;
            dgvAvailableUsers.AllowUserToResizeColumns = false;
            dgvAvailableUsers.AllowUserToResizeRows = false;
            dgvAvailableUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvailableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAvailableUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAvailableUsers.Location = new Point(308, 743);
            dgvAvailableUsers.Margin = new Padding(2);
            dgvAvailableUsers.MultiSelect = false;
            dgvAvailableUsers.Name = "dgvAvailableUsers";
            dgvAvailableUsers.ReadOnly = true;
            dgvAvailableUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvAvailableUsers.RowTemplate.Height = 33;
            dgvAvailableUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableUsers.Size = new Size(353, 246);
            dgvAvailableUsers.TabIndex = 63;
            dgvAvailableUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 526);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 47;
            label4.Text = "16:00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(34, 704);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(71, 29);
            label19.TabIndex = 46;
            label19.Text = "20:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(34, 190);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 29);
            label9.TabIndex = 45;
            label9.Text = "08:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 353);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 29);
            label5.TabIndex = 44;
            label5.Text = "12:00";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkGray;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(AutoScheduleEnd);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(AutoScheduleStart);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(859, 0);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(626, 99);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(204, 43, 29);
            label6.Location = new Point(222, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 31);
            label6.TabIndex = 26;
            label6.Text = "End Date";
            // 
            // AutoScheduleEnd
            // 
            AutoScheduleEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            AutoScheduleEnd.Format = DateTimePickerFormat.Custom;
            AutoScheduleEnd.Location = new Point(222, 53);
            AutoScheduleEnd.Margin = new Padding(2);
            AutoScheduleEnd.Name = "AutoScheduleEnd";
            AutoScheduleEnd.Size = new Size(158, 23);
            AutoScheduleEnd.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(204, 43, 29);
            button4.Font = new Font("Arial Narrow", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(384, 25);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(198, 51);
            button4.TabIndex = 24;
            button4.Text = " Auto schedule";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AutoScheduleStart
            // 
            AutoScheduleStart.CustomFormat = "dd/MM/yyyy HH:mm";
            AutoScheduleStart.Format = DateTimePickerFormat.Custom;
            AutoScheduleStart.Location = new Point(47, 51);
            AutoScheduleStart.Margin = new Padding(2);
            AutoScheduleStart.Name = "AutoScheduleStart";
            AutoScheduleStart.Size = new Size(158, 23);
            AutoScheduleStart.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(204, 43, 29);
            label8.Location = new Point(47, 19);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(158, 31);
            label8.TabIndex = 22;
            label8.Text = "Begin Date";
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 43, 29);
            label2.Location = new Point(447, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 41);
            label2.TabIndex = 80;
            label2.Text = "Department:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDepartmentSearch
            // 
            btnDepartmentSearch.BackColor = Color.FromArgb(204, 43, 29);
            btnDepartmentSearch.FlatStyle = FlatStyle.Flat;
            btnDepartmentSearch.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepartmentSearch.ForeColor = Color.White;
            btnDepartmentSearch.Location = new Point(649, 30);
            btnDepartmentSearch.Margin = new Padding(2);
            btnDepartmentSearch.Name = "btnDepartmentSearch";
            btnDepartmentSearch.Size = new Size(162, 48);
            btnDepartmentSearch.TabIndex = 17;
            btnDepartmentSearch.Text = "Search";
            btnDepartmentSearch.UseVisualStyleBackColor = false;
            btnDepartmentSearch.Click += btnDepartmentSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 69);
            label3.Name = "label3";
            label3.Size = new Size(219, 37);
            label3.TabIndex = 81;
            label3.Text = "Search Employee";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Red;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(75, 170);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 43);
            btnSearch.TabIndex = 83;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.Location = new Point(11, 123);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(281, 32);
            tbSearch.TabIndex = 82;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbSearch);
            groupBox1.Location = new Point(5, 743);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 245);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            // 
            // dgvScheduledUsers
            // 
            dgvScheduledUsers.AllowUserToAddRows = false;
            dgvScheduledUsers.AllowUserToDeleteRows = false;
            dgvScheduledUsers.AllowUserToResizeColumns = false;
            dgvScheduledUsers.AllowUserToResizeRows = false;
            dgvScheduledUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvScheduledUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvScheduledUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvScheduledUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvScheduledUsers.Location = new Point(665, 743);
            dgvScheduledUsers.Margin = new Padding(2);
            dgvScheduledUsers.MultiSelect = false;
            dgvScheduledUsers.Name = "dgvScheduledUsers";
            dgvScheduledUsers.ReadOnly = true;
            dgvScheduledUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvScheduledUsers.RowTemplate.Height = 33;
            dgvScheduledUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScheduledUsers.Size = new Size(353, 246);
            dgvScheduledUsers.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(319, 945);
            label7.Name = "label7";
            label7.Size = new Size(131, 37);
            label7.TabIndex = 86;
            label7.Text = "Available:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDarkDark;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(676, 945);
            label10.Name = "label10";
            label10.Size = new Size(146, 37);
            label10.TabIndex = 87;
            label10.Text = "Scheduled:";
            // 
            // ShiftManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1750, 1000);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(dgvScheduledUsers);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(btnDepartmentSearch);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(cboDepartmens);
            Controls.Add(dgvAvailableUsers);
            Controls.Add(dayContainer);
            Controls.Add(btnNext);
            Controls.Add(lblDate7);
            Controls.Add(btnPrevious);
            Controls.Add(lblDate5);
            Controls.Add(lblDate4);
            Controls.Add(lblDate3);
            Controls.Add(lblDate2);
            Controls.Add(lblDate6);
            Controls.Add(lblDate1);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(date1);
            Controls.Add(lblShifts);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ShiftManagement";
            Text = "PlanningWeekly";
            Load += PlanningWeekly_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableUsers).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduledUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Label lblDate7;
        private Button btnPrevious;
        private Label lblDate5;
        private Label lblDate4;
        private Label lblDate3;
        private Label lblDate2;
        private Label lblDate6;
        private Label lblDate1;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label24;
        private Label label23;
        private Label date1;
        private Label lblShifts;
        private FlowLayoutPanel dayContainer;
        private ComboBox cboDepartmens;
        private GroupBox groupBox2;
        private Label lblSelectedEmployee;
        private Label label31;
        private Label label32;
        public DateTimePicker dtpEnd;
        public DateTimePicker dtpStart;
        private Button btnCreateShift;
        private Label label33;
        public DataGridView dgvAvailableUsers;
        private Label label4;
        private Label label19;
        private Label label9;
        private Label label5;
        private TextBox tbDescription;
        private Label label1;
        private GroupBox groupBox3;
        private Label label6;
        public DateTimePicker AutoScheduleEnd;
        private Button button4;
        public DateTimePicker AutoScheduleStart;
        private Label label8;
        private Label label2;
        private Button btnDepartmentSearch;
        private Label label3;
        private Button btnSearch;
        private TextBox tbSearch;
        private GroupBox groupBox1;
        public DataGridView dgvScheduledUsers;
        private Label label7;
        private Label label10;
    }
}