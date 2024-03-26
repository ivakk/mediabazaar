namespace MP_WindowsFormsApp.UserControls
{
    partial class ReplenishmentRequestUC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnStatus = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 54);
            label1.TabIndex = 0;
            label1.Text = "Samsung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(225, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 54);
            label2.TabIndex = 1;
            label2.Text = "S23 Ultra";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(0, 113);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(144, 113);
            label4.Name = "label4";
            label4.Size = new Size(181, 37);
            label4.TabIndex = 3;
            label4.Text = "Sub-Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(3, 54);
            label5.Name = "label5";
            label5.Size = new Size(183, 37);
            label5.TabIndex = 4;
            label5.Text = "Price: 1299.99";
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.Red;
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btnStatus.ForeColor = Color.Black;
            btnStatus.Location = new Point(492, 71);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(176, 58);
            btnStatus.TabIndex = 12;
            btnStatus.Text = "OPEN";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(392, 84);
            label6.Name = "label6";
            label6.Size = new Size(94, 37);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(492, 17);
            label7.Name = "label7";
            label7.Size = new Size(155, 37);
            label7.TabIndex = 14;
            label7.Text = "Amount: 10";
            // 
            // ReplenishmentRequestUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReplenishmentRequestUC";
            Size = new Size(700, 150);
            Load += ReplenishmentRequestUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnStatus;
        private Label label6;
        private Label label7;
    }
}
