namespace MP_WindowsFormsApp.Forms
{
    partial class AutoSchedulingPreview
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
            dgvScheduledUsers = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnSearch = new Button();
            tbSearch = new TextBox();
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
            label5 = new Label();
            label19 = new Label();
            label4 = new Label();
            label9 = new Label();
            dgvAvailableUsers = new DataGridView();
            dayContainer = new FlowLayoutPanel();
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
            btnSave = new Button();
            btnDisregard = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvScheduledUsers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvScheduledUsers
            // 
            dgvScheduledUsers.AllowUserToAddRows = false;
            dgvScheduledUsers.AllowUserToDeleteRows = false;
            dgvScheduledUsers.AllowUserToResizeColumns = false;
            dgvScheduledUsers.AllowUserToResizeRows = false;
            dgvScheduledUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvScheduledUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvScheduledUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvScheduledUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvScheduledUsers.Location = new Point(726, 743);
            dgvScheduledUsers.Margin = new Padding(2);
            dgvScheduledUsers.MultiSelect = false;
            dgvScheduledUsers.Name = "dgvScheduledUsers";
            dgvScheduledUsers.ReadOnly = true;
            dgvScheduledUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvScheduledUsers.RowTemplate.Height = 33;
            dgvScheduledUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScheduledUsers.Size = new Size(406, 246);
            dgvScheduledUsers.TabIndex = 111;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbSearch);
            groupBox1.Location = new Point(13, 743);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 245);
            groupBox1.TabIndex = 110;
            groupBox1.TabStop = false;
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
            groupBox2.Location = new Point(1136, 743);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(436, 246);
            groupBox2.TabIndex = 96;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 43, 29);
            label1.Location = new Point(19, 135);
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
            lblSelectedEmployee.Location = new Point(31, 43);
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
            label31.Location = new Point(221, 66);
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
            label32.Location = new Point(15, 5);
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
            label33.Location = new Point(19, 68);
            label33.Margin = new Padding(2, 0, 2, 0);
            label33.Name = "label33";
            label33.Size = new Size(158, 31);
            label33.TabIndex = 22;
            label33.Text = "Begin Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 353);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 29);
            label5.TabIndex = 86;
            label5.Text = "12:00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(42, 704);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(71, 29);
            label19.TabIndex = 88;
            label19.Text = "20:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 526);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 89;
            label4.Text = "16:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(42, 190);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(71, 29);
            label9.TabIndex = 87;
            label9.Text = "08:00";
            // 
            // dgvAvailableUsers
            // 
            dgvAvailableUsers.AllowUserToAddRows = false;
            dgvAvailableUsers.AllowUserToDeleteRows = false;
            dgvAvailableUsers.AllowUserToResizeColumns = false;
            dgvAvailableUsers.AllowUserToResizeRows = false;
            dgvAvailableUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAvailableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAvailableUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAvailableUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAvailableUsers.Location = new Point(316, 743);
            dgvAvailableUsers.Margin = new Padding(2);
            dgvAvailableUsers.MultiSelect = false;
            dgvAvailableUsers.Name = "dgvAvailableUsers";
            dgvAvailableUsers.ReadOnly = true;
            dgvAvailableUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvAvailableUsers.RowTemplate.Height = 33;
            dgvAvailableUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableUsers.Size = new Size(406, 246);
            dgvAvailableUsers.TabIndex = 92;
            dgvAvailableUsers.SelectionChanged += dgvAvailableUsers_SelectionChanged;
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(137, 190);
            dayContainer.Margin = new Padding(0);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1307, 548);
            dayContainer.TabIndex = 109;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(204, 43, 29);
            btnNext.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(1380, 115);
            btnNext.Margin = new Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(158, 47);
            btnNext.TabIndex = 93;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblDate7
            // 
            lblDate7.AutoSize = true;
            lblDate7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate7.Location = new Point(1285, 138);
            lblDate7.Margin = new Padding(4, 0, 4, 0);
            lblDate7.Name = "lblDate7";
            lblDate7.Size = new Size(90, 29);
            lblDate7.TabIndex = 108;
            lblDate7.Text = "DATE1";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(204, 43, 29);
            btnPrevious.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(33, 115);
            btnPrevious.Margin = new Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(152, 47);
            btnPrevious.TabIndex = 91;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblDate5
            // 
            lblDate5.AutoSize = true;
            lblDate5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate5.Location = new Point(936, 138);
            lblDate5.Margin = new Padding(4, 0, 4, 0);
            lblDate5.Name = "lblDate5";
            lblDate5.Size = new Size(90, 29);
            lblDate5.TabIndex = 107;
            lblDate5.Text = "DATE1";
            // 
            // lblDate4
            // 
            lblDate4.AutoSize = true;
            lblDate4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate4.Location = new Point(776, 138);
            lblDate4.Margin = new Padding(4, 0, 4, 0);
            lblDate4.Name = "lblDate4";
            lblDate4.Size = new Size(90, 29);
            lblDate4.TabIndex = 106;
            lblDate4.Text = "DATE1";
            // 
            // lblDate3
            // 
            lblDate3.AutoSize = true;
            lblDate3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate3.Location = new Point(579, 138);
            lblDate3.Margin = new Padding(4, 0, 4, 0);
            lblDate3.Name = "lblDate3";
            lblDate3.Size = new Size(90, 29);
            lblDate3.TabIndex = 105;
            lblDate3.Text = "DATE1";
            // 
            // lblDate2
            // 
            lblDate2.AutoSize = true;
            lblDate2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate2.Location = new Point(368, 138);
            lblDate2.Margin = new Padding(4, 0, 4, 0);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(90, 29);
            lblDate2.TabIndex = 104;
            lblDate2.Text = "DATE1";
            // 
            // lblDate6
            // 
            lblDate6.AutoSize = true;
            lblDate6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate6.Location = new Point(1085, 138);
            lblDate6.Margin = new Padding(4, 0, 4, 0);
            lblDate6.Name = "lblDate6";
            lblDate6.Size = new Size(90, 29);
            lblDate6.TabIndex = 103;
            lblDate6.Text = "DATE1";
            // 
            // lblDate1
            // 
            lblDate1.AutoSize = true;
            lblDate1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate1.Location = new Point(185, 138);
            lblDate1.Margin = new Padding(4, 0, 4, 0);
            lblDate1.Name = "lblDate1";
            lblDate1.Size = new Size(90, 29);
            lblDate1.TabIndex = 102;
            lblDate1.Text = "DATE1";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(368, 104);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(106, 29);
            label30.TabIndex = 101;
            label30.Text = "Tuesday";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(553, 104);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(140, 29);
            label29.TabIndex = 100;
            label29.Text = "Wednesday";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(762, 104);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(113, 29);
            label28.TabIndex = 99;
            label28.Text = "Thursday";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(936, 104);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(80, 29);
            label27.TabIndex = 98;
            label27.Text = "Friday";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(1085, 104);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(107, 29);
            label24.TabIndex = 97;
            label24.Text = "Saturday";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(1281, 104);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(93, 29);
            label23.TabIndex = 95;
            label23.Text = "Sunday";
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            date1.Location = new Point(185, 104);
            date1.Margin = new Padding(4, 0, 4, 0);
            date1.Name = "date1";
            date1.Size = new Size(98, 29);
            date1.TabIndex = 94;
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
            lblShifts.Size = new Size(581, 55);
            lblShifts.TabIndex = 90;
            lblShifts.Text = "Auto Scheduling Preview";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(723, 24);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 47);
            btnSave.TabIndex = 112;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDisregard
            // 
            btnDisregard.BackColor = Color.FromArgb(204, 43, 29);
            btnDisregard.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisregard.ForeColor = SystemColors.ButtonHighlight;
            btnDisregard.Location = new Point(980, 24);
            btnDisregard.Margin = new Padding(2);
            btnDisregard.Name = "btnDisregard";
            btnDisregard.Size = new Size(152, 47);
            btnDisregard.TabIndex = 113;
            btnDisregard.Text = "Disregard";
            btnDisregard.UseVisualStyleBackColor = false;
            btnDisregard.Click += btnDisregard_Click;
            // 
            // AutoSchedulingPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1750, 1000);
            Controls.Add(btnDisregard);
            Controls.Add(btnSave);
            Controls.Add(dgvScheduledUsers);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label4);
            Controls.Add(label9);
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
            Name = "AutoSchedulingPreview";
            Text = "AutoSchedulingPreview";
            Load += AutoSchedulingPreview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvScheduledUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvScheduledUsers;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnSearch;
        private TextBox tbSearch;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox tbDescription;
        private Label lblSelectedEmployee;
        private Label label31;
        private Label label32;
        public DateTimePicker dtpEnd;
        public DateTimePicker dtpStart;
        private Button btnCreateShift;
        private Label label33;
        private Label label5;
        private Label label19;
        private Label label4;
        private Label label9;
        public DataGridView dgvAvailableUsers;
        private FlowLayoutPanel dayContainer;
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
        private Button btnSave;
        private Button btnDisregard;
    }
}