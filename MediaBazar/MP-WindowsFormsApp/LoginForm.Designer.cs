namespace MP_WindowsFormsApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            pbRevealPassword = new PictureBox();
            btnLogin = new Button();
            lbForgotPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRevealPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mb_red;
            pictureBox1.InitialImage = Properties.Resources.mb_red;
            pictureBox1.Location = new Point(175, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(415, 316);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(394, 437);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(253, 353);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(398, 39);
            tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(253, 475);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.Size = new Size(398, 39);
            tbPassword.TabIndex = 4;
            // 
            // pbRevealPassword
            // 
            pbRevealPassword.Image = Properties.Resources.show;
            pbRevealPassword.Location = new Point(658, 475);
            pbRevealPassword.Margin = new Padding(3, 4, 3, 4);
            pbRevealPassword.Name = "pbRevealPassword";
            pbRevealPassword.Size = new Size(41, 43);
            pbRevealPassword.SizeMode = PictureBoxSizeMode.CenterImage;
            pbRevealPassword.TabIndex = 5;
            pbRevealPassword.TabStop = false;
            pbRevealPassword.MouseDown += pbRevealPassword_MouseDown;
            pbRevealPassword.MouseUp += pbRevealPassword_MouseUp;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(227, 6, 19);
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(336, 577);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(233, 85);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbForgotPassword
            // 
            lbForgotPassword.Anchor = AnchorStyles.None;
            lbForgotPassword.AutoSize = true;
            lbForgotPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbForgotPassword.ForeColor = Color.Red;
            lbForgotPassword.Location = new Point(367, 535);
            lbForgotPassword.Name = "lbForgotPassword";
            lbForgotPassword.Size = new Size(172, 25);
            lbForgotPassword.TabIndex = 8;
            lbForgotPassword.Text = "Forgot password";
            lbForgotPassword.Click += lbForgotPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(914, 697);
            Controls.Add(lbForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(pbRevealPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRevealPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private PictureBox pbRevealPassword;
        private Button btnLogin;
        private Label lbForgotPassword;
    }
}