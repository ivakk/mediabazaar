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
            btnApprove = new Button();
            btnReject = new Button();
            btnRemove = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(225, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 1;
            label2.Text = "Model";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(0, 50);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(144, 50);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 3;
            label4.Text = "Sub-Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(3, 88);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 4;
            label5.Text = "Price: 0.00";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Green;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnApprove.ForeColor = Color.Black;
            btnApprove.Location = new Point(492, 50);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(176, 58);
            btnApprove.TabIndex = 12;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.DarkRed;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnReject.ForeColor = Color.Black;
            btnReject.Location = new Point(492, 120);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(176, 58);
            btnReject.TabIndex = 13;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Gray;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(492, 190);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(176, 58);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(144, 120);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 14;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(492, 17);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 15;
            label7.Text = "Amount: 0";
            // 
            // ReplenishmentRequestUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnApprove);
            Controls.Add(btnReject);
            Controls.Add(btnRemove);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReplenishmentRequestUC";
            Size = new Size(700, 250);
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
        private Button btnApprove;
        private Button btnReject;
        private Button btnRemove;
        private Label label6;
        private Label label7;
    }
}
