namespace Assignment_3._4
{
    partial class OrderForm
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
            lblAddtoOrder = new Label();
            lblName = new Label();
            lblPhoneNum = new Label();
            lblType = new Label();
            lblStrength = new Label();
            lblMilk = new Label();
            lblSugar = new Label();
            lblCup = new Label();
            cmbType = new ComboBox();
            cmbMilk = new ComboBox();
            cmbSugar = new ComboBox();
            cmbStrength = new ComboBox();
            cmbSize = new ComboBox();
            txtName = new TextBox();
            txtPhoneNum = new TextBox();
            btnSubmitOrder = new Button();
            SuspendLayout();
            // 
            // lblAddtoOrder
            // 
            lblAddtoOrder.AutoSize = true;
            lblAddtoOrder.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            lblAddtoOrder.Location = new Point(135, 37);
            lblAddtoOrder.Name = "lblAddtoOrder";
            lblAddtoOrder.Size = new System.Drawing.Size(478, 25);
            lblAddtoOrder.TabIndex = 0;
            lblAddtoOrder.Text = "Add a Coffer to your order by filling out the requred fields.";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.Location = new Point(12, 95);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(48, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Name :";
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.BorderStyle = BorderStyle.Fixed3D;
            lblPhoneNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNum.Location = new Point(12, 149);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new System.Drawing.Size(99, 17);
            lblPhoneNum.TabIndex = 4;
            lblPhoneNum.Text = "Phone Number :";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BorderStyle = BorderStyle.Fixed3D;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblType.Location = new Point(12, 201);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(44, 17);
            lblType.TabIndex = 5;
            lblType.Text = "Type : ";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.BorderStyle = BorderStyle.Fixed3D;
            lblStrength.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStrength.Location = new Point(12, 253);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new System.Drawing.Size(68, 17);
            lblStrength.TabIndex = 6;
            lblStrength.Text = "Strength : ";
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.BorderStyle = BorderStyle.Fixed3D;
            lblMilk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMilk.Location = new Point(12, 301);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new System.Drawing.Size(39, 17);
            lblMilk.TabIndex = 7;
            lblMilk.Text = "Milk :";
            // 
            // lblSugar
            // 
            lblSugar.AutoSize = true;
            lblSugar.BorderStyle = BorderStyle.Fixed3D;
            lblSugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSugar.Location = new Point(12, 349);
            lblSugar.Name = "lblSugar";
            lblSugar.Size = new System.Drawing.Size(47, 17);
            lblSugar.TabIndex = 8;
            lblSugar.Text = "Sugar :";
            // 
            // lblCup
            // 
            lblCup.AutoSize = true;
            lblCup.BorderStyle = BorderStyle.Fixed3D;
            lblCup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCup.Location = new Point(12, 401);
            lblCup.Name = "lblCup";
            lblCup.Size = new System.Drawing.Size(38, 17);
            lblCup.TabIndex = 9;
            lblCup.Text = "Size :";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Decalf", "Regular" });
            cmbType.Location = new Point(373, 195);
            cmbType.Name = "cmbType";
            cmbType.Size = new System.Drawing.Size(100, 23);
            cmbType.TabIndex = 10;
            // 
            // cmbMilk
            // 
            cmbMilk.FormattingEnabled = true;
            cmbMilk.Items.AddRange(new object[] { "Yes", "No" });
            cmbMilk.Location = new Point(373, 295);
            cmbMilk.Name = "cmbMilk";
            cmbMilk.Size = new System.Drawing.Size(100, 23);
            cmbMilk.TabIndex = 11;
            // 
            // cmbSugar
            // 
            cmbSugar.FormattingEnabled = true;
            cmbSugar.Items.AddRange(new object[] { "Yes", "No" });
            cmbSugar.Location = new Point(373, 343);
            cmbSugar.Name = "cmbSugar";
            cmbSugar.Size = new System.Drawing.Size(100, 23);
            cmbSugar.TabIndex = 12;
            // 
            // cmbStrength
            // 
            cmbStrength.FormattingEnabled = true;
            cmbStrength.Items.AddRange(new object[] { "Strong", "Medium", "Weak" });
            cmbStrength.Location = new Point(373, 247);
            cmbStrength.Name = "cmbStrength";
            cmbStrength.Size = new System.Drawing.Size(100, 23);
            cmbStrength.TabIndex = 13;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(373, 401);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new System.Drawing.Size(100, 23);
            cmbSize.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Location = new Point(373, 89);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Name";
            txtName.Size = new System.Drawing.Size(100, 23);
            txtName.TabIndex = 15;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(373, 143);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PlaceholderText = "Enter Phone #";
            txtPhoneNum.Size = new System.Drawing.Size(100, 23);
            txtPhoneNum.TabIndex = 17;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Location = new Point(662, 401);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new System.Drawing.Size(91, 23);
            btnSubmitOrder.TabIndex = 19;
            btnSubmitOrder.Text = "Submit Order";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSubmitOrder);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtName);
            Controls.Add(cmbSize);
            Controls.Add(cmbStrength);
            Controls.Add(cmbSugar);
            Controls.Add(cmbMilk);
            Controls.Add(cmbType);
            Controls.Add(lblCup);
            Controls.Add(lblSugar);
            Controls.Add(lblMilk);
            Controls.Add(lblStrength);
            Controls.Add(lblType);
            Controls.Add(lblPhoneNum);
            Controls.Add(lblName);
            Controls.Add(lblAddtoOrder);
            Name = "OrderForm";
            Text = "Add to Order";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddtoOrder;
        private Label lblName;
        private Label lblPhoneNum;
        private Label lblType;
        private Label lblStrength;
        private Label lblMilk;
        private Label lblSugar;
        private Label lblCup;
        private ComboBox cmbType;
        private ComboBox cmbMilk;
        private ComboBox cmbSugar;
        private ComboBox cmbStrength;
        private ComboBox cmbSize;
        private TextBox txtName;
        private TextBox txtPhoneNum;
        private Button btnSubmitOrder;
    }
}