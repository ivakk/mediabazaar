namespace T_and_B
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
            txbEvent = new TextBox();
            lblDate = new Label();
            lblEvent = new Label();
            btnSave = new Button();
            lblWorkshift = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txbDate
            // 
            txbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDate.Location = new Point(304, 185);
            txbDate.Multiline = true;
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(337, 35);
            txbDate.TabIndex = 0;
            // 
            // txbEvent
            // 
            txbEvent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbEvent.Location = new Point(304, 109);
            txbEvent.Multiline = true;
            txbEvent.Name = "txbEvent";
            txbEvent.Size = new Size(337, 35);
            txbEvent.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(307, 162);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(99, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date of Event";
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(300, 86);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(98, 20);
            lblEvent.TabIndex = 3;
            lblEvent.Text = "Type of Event";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(324, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblWorkshift
            // 
            lblWorkshift.AutoSize = true;
            lblWorkshift.Location = new Point(80, 85);
            lblWorkshift.Margin = new Padding(4, 0, 4, 0);
            lblWorkshift.Name = "lblWorkshift";
            lblWorkshift.Size = new Size(71, 20);
            lblWorkshift.TabIndex = 5;
            lblWorkshift.Text = "Workshift";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "8-12:30", "12:30-17:00", "17- 23:30" });
            comboBox1.Location = new Point(84, 109);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 7;
            label2.Text = "Name of Employee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 192);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 292);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 9;
            label3.Text = "Additional Comments";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 317);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(557, 153);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(259, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 24);
            label4.TabIndex = 11;
            label4.Text = "Form for Assigning Shifts";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(784, 585);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(lblWorkshift);
            Controls.Add(btnSave);
            Controls.Add(lblEvent);
            Controls.Add(lblDate);
            Controls.Add(txbEvent);
            Controls.Add(txbDate);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDate;
        private TextBox txbEvent;
        private Label lblDate;
        private Label lblEvent;
        private Button btnSave;
        private Label lblWorkshift;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}