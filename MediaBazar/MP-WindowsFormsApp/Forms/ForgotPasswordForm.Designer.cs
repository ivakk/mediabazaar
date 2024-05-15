namespace MP_WindowsFormsApp.Forms
{
    partial class ForgotPasswordForm
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
            btnLogin = new Button();
            tbConfirmPassword = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbNewPassword = new TextBox();
            lbNewPassword = new Label();
            pictureBox1 = new PictureBox();
            lbForgotPassword = new Label();
            lbReturnToLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(227, 6, 19);
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(233, 568);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(440, 72);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Reset Password";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.Location = new Point(247, 417);
            tbConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '●';
            tbConfirmPassword.Size = new Size(398, 39);
            tbConfirmPassword.TabIndex = 11;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(248, 238);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(398, 39);
            tbEmail.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(330, 381);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 9;
            label2.Text = "Confirm new Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(410, 201);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewPassword.Location = new Point(247, 331);
            tbNewPassword.Margin = new Padding(3, 4, 3, 4);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '●';
            tbNewPassword.Size = new Size(398, 39);
            tbNewPassword.TabIndex = 15;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbNewPassword.Location = new Point(370, 295);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(171, 32);
            lbNewPassword.TabIndex = 14;
            lbNewPassword.Text = "New Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mb_red;
            pictureBox1.InitialImage = Properties.Resources.mb_red;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbForgotPassword
            // 
            lbForgotPassword.AutoSize = true;
            lbForgotPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbForgotPassword.Location = new Point(298, 72);
            lbForgotPassword.Name = "lbForgotPassword";
            lbForgotPassword.Size = new Size(317, 54);
            lbForgotPassword.TabIndex = 17;
            lbForgotPassword.Text = "Forgot Password";
            // 
            // lbReturnToLogin
            // 
            lbReturnToLogin.Anchor = AnchorStyles.None;
            lbReturnToLogin.AutoSize = true;
            lbReturnToLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbReturnToLogin.ForeColor = Color.Red;
            lbReturnToLogin.Location = new Point(370, 511);
            lbReturnToLogin.Name = "lbReturnToLogin";
            lbReturnToLogin.Size = new Size(165, 25);
            lbReturnToLogin.TabIndex = 18;
            lbReturnToLogin.Text = "Return to Log In";
            lbReturnToLogin.Click += lbReturnToLogin_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(914, 697);
            Controls.Add(lbReturnToLogin);
            Controls.Add(lbForgotPassword);
            Controls.Add(pictureBox1);
            Controls.Add(tbNewPassword);
            Controls.Add(lbNewPassword);
            Controls.Add(btnLogin);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox tbConfirmPassword;
        private TextBox tbEmail;
        private Label label2;
        private Label label1;
        private TextBox tbNewPassword;
        private Label lbNewPassword;
        private PictureBox pictureBox1;
        private Label lbForgotPassword;
        private Label lbReturnToLogin;
    }
}