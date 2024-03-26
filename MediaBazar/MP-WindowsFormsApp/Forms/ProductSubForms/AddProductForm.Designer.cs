namespace MP_WindowsFormsApp.Forms.ProductSubForms
{
    partial class AddProductForm
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
            btnAdd = new Button();
            label6 = new Label();
            nudPrice = new NumericUpDown();
            label5 = new Label();
            tbDescription = new TextBox();
            cbSubCategory = new ComboBox();
            lbSubCategory = new Label();
            cbCategory = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            tbModel = new TextBox();
            cbBrand = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nudPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDescription);
            groupBox1.Controls.Add(cbSubCategory);
            groupBox1.Controls.Add(lbSubCategory);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbModel);
            groupBox1.Controls.Add(cbBrand);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 30F);
            groupBox1.Location = new Point(504, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 459);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD PRODUCT";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(314, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 43);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(51, 390);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 14F);
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new Point(111, 388);
            nudPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 32);
            nudPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(51, 218);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 14F);
            tbDescription.Location = new Point(51, 246);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(400, 116);
            tbDescription.TabIndex = 9;
            // 
            // cbSubCategory
            // 
            cbSubCategory.Font = new Font("Segoe UI", 14F);
            cbSubCategory.FormattingEnabled = true;
            cbSubCategory.Location = new Point(258, 175);
            cbSubCategory.Name = "cbSubCategory";
            cbSubCategory.Size = new Size(193, 33);
            cbSubCategory.TabIndex = 8;
            cbSubCategory.Visible = false;
            // 
            // lbSubCategory
            // 
            lbSubCategory.AutoSize = true;
            lbSubCategory.Font = new Font("Segoe UI", 14F);
            lbSubCategory.Location = new Point(258, 147);
            lbSubCategory.Name = "lbSubCategory";
            lbSubCategory.Size = new Size(120, 25);
            lbSubCategory.TabIndex = 7;
            lbSubCategory.Text = "SubCategory";
            lbSubCategory.Visible = false;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 14F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(51, 175);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(193, 33);
            cbCategory.TabIndex = 6;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(51, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(178, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Model";
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 14F);
            tbModel.Location = new Point(178, 112);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(273, 32);
            tbModel.TabIndex = 3;
            // 
            // cbBrand
            // 
            cbBrand.Font = new Font("Segoe UI", 14F);
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(51, 111);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 33);
            cbBrand.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(51, 83);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 1000);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductForm";
            Text = "AddProductForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox tbModel;
        private ComboBox cbBrand;
        private ComboBox cbSubCategory;
        private Label lbSubCategory;
        private ComboBox cbCategory;
        private Label label3;
        private Label label5;
        private TextBox tbDescription;
        private Label label6;
        private NumericUpDown nudPrice;
        private Button btnAdd;
    }
}