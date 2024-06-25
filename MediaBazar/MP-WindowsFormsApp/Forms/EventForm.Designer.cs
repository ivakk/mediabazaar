namespace MP_WindowsFormsApp.Forms
{
    partial class EventForm
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
            txbDate = new TextBox();
            lblDate = new Label();
            lblEvent = new Label();
            btnSave = new Button();
            lblWorkshift = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBoxEventType = new ComboBox();
            comboBox2 = new ComboBox();
            buttonAutoSchedule = new Button();
            SuspendLayout();
            // 
            // txbDate
            // 
            txbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDate.Location = new Point(266, 139);
            txbDate.Margin = new Padding(3, 2, 3, 2);
            txbDate.Multiline = true;
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(295, 27);
            txbDate.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(269, 122);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(77, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date of Event";
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(262, 64);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(70, 15);
            lblEvent.TabIndex = 3;
            lblEvent.Text = "Department";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 388);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 22);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblWorkshift
            // 
            lblWorkshift.AutoSize = true;
            lblWorkshift.Location = new Point(70, 64);
            lblWorkshift.Margin = new Padding(4, 0, 4, 0);
            lblWorkshift.Name = "lblWorkshift";
            lblWorkshift.Size = new Size(58, 15);
            lblWorkshift.TabIndex = 5;
            lblWorkshift.Text = "Workshift";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Morning Shift", "Afternoon Shift", "Evening Shift" });
            comboBox1.Location = new Point(74, 82);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Name of Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 9;
            label3.Text = "Additional Comments";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 238);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(488, 116);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 18);
            label4.TabIndex = 11;
            label4.Text = "Form for Assigning Shifts";
            // 
            // comboBoxEventType
            // 
            comboBoxEventType.FormattingEnabled = true;
            comboBoxEventType.Items.AddRange(new object[] { "Shift" });
            comboBoxEventType.Location = new Point(262, 83);
            comboBoxEventType.Margin = new Padding(4);
            comboBoxEventType.Name = "comboBoxEventType";
            comboBoxEventType.Size = new Size(196, 23);
            comboBoxEventType.TabIndex = 12;
            comboBoxEventType.SelectedIndexChanged += comboBoxEventType_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Shift" });
            comboBox2.Location = new Point(74, 139);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 23);
            comboBox2.TabIndex = 13;
            // 
            // buttonAutoSchedule
            // 
            buttonAutoSchedule.Location = new Point(74, 168);
            buttonAutoSchedule.Margin = new Padding(3, 2, 3, 2);
            buttonAutoSchedule.Name = "buttonAutoSchedule";
            buttonAutoSchedule.Size = new Size(185, 22);
            buttonAutoSchedule.TabIndex = 14;
            buttonAutoSchedule.Text = "Auto Schedule";
            buttonAutoSchedule.UseVisualStyleBackColor = true;
            buttonAutoSchedule.Click += buttonAutoSchedule_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(686, 439);
            Controls.Add(buttonAutoSchedule);
            Controls.Add(comboBox2);
            Controls.Add(comboBoxEventType);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(lblWorkshift);
            Controls.Add(btnSave);
            Controls.Add(lblEvent);
            Controls.Add(lblDate);
            Controls.Add(txbDate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDate;
        private Label lblDate;
        private Label lblEvent;
        private Button btnSave;
        private Label lblWorkshift;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBoxEventType;
        private ComboBox comboBox2;
        private Button buttonAutoSchedule;
    }
}