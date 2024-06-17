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
            label4 = new Label();
            nudWeight = new NumericUpDown();
            label7 = new Label();
            nudHeight = new NumericUpDown();
            label8 = new Label();
            nudWidth = new NumericUpDown();
            label9 = new Label();
            tbUPCcode = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbUPCcode);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nudWidth);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nudHeight);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudWeight);
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
            groupBox1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(504, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 576);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD PRODUCT";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Red;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(314, 503);
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
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 514);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new Point(111, 512);
            nudPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 32);
            nudPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 342);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 10;
            label5.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.Location = new Point(51, 370);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(400, 116);
            tbDescription.TabIndex = 9;
            // 
            // cbSubCategory
            // 
            cbSubCategory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            lbSubCategory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbSubCategory.Location = new Point(258, 147);
            lbSubCategory.Name = "lbSubCategory";
            lbSubCategory.Size = new Size(120, 25);
            lbSubCategory.TabIndex = 7;
            lbSubCategory.Text = "SubCategory";
            lbSubCategory.Visible = false;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 84);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Model";
            // 
            // tbModel
            // 
            tbModel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.Location = new Point(178, 112);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(273, 32);
            tbModel.TabIndex = 3;
            // 
            // cbBrand
            // 
            cbBrand.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(51, 111);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 33);
            cbBrand.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 83);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 216);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 15;
            label4.Text = "Weight";
            // 
            // nudWeight
            // 
            nudWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nudWeight.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudWeight.Location = new Point(52, 244);
            nudWeight.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(120, 32);
            nudWeight.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(178, 216);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 17;
            label7.Text = "Height";
            // 
            // nudHeight
            // 
            nudHeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nudHeight.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudHeight.Location = new Point(178, 244);
            nudHeight.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(130, 32);
            nudHeight.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(314, 216);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 19;
            label8.Text = "Width";
            // 
            // nudWidth
            // 
            nudWidth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nudWidth.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudWidth.Location = new Point(314, 244);
            nudWidth.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(137, 32);
            nudWidth.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(52, 279);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 21;
            label9.Text = "UPC Code";
            // 
            // tbUPCcode
            // 
            tbUPCcode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbUPCcode.Location = new Point(51, 307);
            tbUPCcode.Name = "tbUPCcode";
            tbUPCcode.Size = new Size(400, 32);
            tbUPCcode.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
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
        private Label label4;
        private NumericUpDown nudWeight;
        private Label label9;
        private TextBox tbUPCcode;
        private Label label8;
        private NumericUpDown nudWidth;
        private Label label7;
        private NumericUpDown nudHeight;
    }
}