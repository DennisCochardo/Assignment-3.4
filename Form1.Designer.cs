namespace Assignment_3._4
{
    partial class MainForm
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
            lblHeader = new Label();
            lblIntroduction = new Label();
            dataCoffeeList = new DataGridView();
            btnOrder = new Button();
            btnDelete = new Button();
            btnSubmitOrder = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataCoffeeList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BorderStyle = BorderStyle.Fixed3D;
            lblHeader.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblHeader.Location = new Point(282, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(180, 48);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Welcome!";
            // 
            // lblIntroduction
            // 
            lblIntroduction.AutoSize = true;
            lblIntroduction.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblIntroduction.Location = new Point(29, 88);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new System.Drawing.Size(316, 19);
            lblIntroduction.TabIndex = 1;
            lblIntroduction.Text = "Below is the list of drinks currently in your order :";
            // 
            // dataCoffeeList
            // 
            dataCoffeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCoffeeList.Location = new Point(29, 128);
            dataCoffeeList.Name = "dataCoffeeList";
            dataCoffeeList.Size = new System.Drawing.Size(744, 217);
            dataCoffeeList.TabIndex = 2;
            dataCoffeeList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOrder.Location = new Point(104, 385);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(75, 23);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(367, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubmitOrder.Location = new Point(629, 385);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new System.Drawing.Size(75, 23);
            btnSubmitOrder.TabIndex = 5;
            btnSubmitOrder.Text = "Submit";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(629, 99);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnSubmitOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnOrder);
            Controls.Add(dataCoffeeList);
            Controls.Add(lblIntroduction);
            Controls.Add(lblHeader);
            Name = "MainForm";
            Text = "Coffee List";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataCoffeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblIntroduction;
        private DataGridView dataCoffeeList;
        private Button btnOrder;
        private Button btnDelete;
        private Button btnSubmitOrder;
        private Button btnRefresh;
    }
}
