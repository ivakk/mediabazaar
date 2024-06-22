﻿namespace MP_WindowsFormsApp.Forms
{
    partial class UsersForm
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
            button1 = new Button();
            btnAdd = new Button();
            cbDepartment = new ComboBox();
            lblBrand = new Label();
            btnSearch = new Button();
            tbSearch = new TextBox();
            flpUsers = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbDepartment);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbSearch);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1410, 195);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "SEARCH";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(1240, 123);
            button1.Name = "button1";
            button1.Size = new Size(155, 44);
            button1.TabIndex = 12;
            button1.Text = "Save Users";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(26, 122);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(408, 130);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(203, 33);
            cbDepartment.TabIndex = 4;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.Location = new Point(230, 123);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(172, 37);
            lblBrand.TabIndex = 3;
            lblBrand.Text = "Department:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Red;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1258, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.Location = new Point(26, 55);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(1226, 43);
            tbSearch.TabIndex = 1;
            // 
            // flpUsers
            // 
            flpUsers.AutoScroll = true;
            flpUsers.Location = new Point(12, 227);
            flpUsers.Name = "flpUsers";
            flpUsers.Size = new Size(1450, 700);
            flpUsers.TabIndex = 15;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 1000);
            Controls.Add(flpUsers);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            Text = "Users";
            Load += UsersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnAdd;
        private ComboBox cbDepartment;
        private Label lblBrand;
        private Button btnSearch;
        private TextBox tbSearch;
        private FlowLayoutPanel flpUsers;
        public Button button1;
    }
}