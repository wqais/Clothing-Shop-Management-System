namespace clothing_shopee_mgmt
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.refreshBtn = new System.Windows.Forms.Button();
            this.shopDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet1 = new clothing_shopee_mgmt.shopDbDataSet1();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.custDt = new System.Windows.Forms.DataGridView();
            this.customersDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet3 = new clothing_shopee_mgmt.shopDbDataSet3();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.employeeDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet2 = new clothing_shopee_mgmt.shopDbDataSet2();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeeDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet2TableAdapters.employeeDbTableAdapter();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.customersDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet3TableAdapters.customersDbTableAdapter();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custRegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).BeginInit();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.refreshBtn.Location = new System.Drawing.Point(17, 415);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Padding = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Size = new System.Drawing.Size(218, 45);
            this.refreshBtn.TabIndex = 40;
            this.refreshBtn.Text = "Refresh Window";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // shopDbDataSet1BindingSource
            // 
            this.shopDbDataSet1BindingSource.DataSource = this.shopDbDataSet1;
            this.shopDbDataSet1BindingSource.Position = 0;
            // 
            // shopDbDataSet1
            // 
            this.shopDbDataSet1.DataSetName = "shopDbDataSet1";
            this.shopDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBtn.Location = new System.Drawing.Point(786, 46);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(53, 29);
            this.searchBtn.TabIndex = 32;
            this.searchBtn.Text = "Go";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Controls.Add(this.searchBtn);
            this.searchBox.Controls.Add(this.custDt);
            this.searchBox.Controls.Add(this.searchTxt);
            this.searchBox.Controls.Add(this.searchLbl);
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBox.Location = new System.Drawing.Point(291, 139);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(877, 575);
            this.searchBox.TabIndex = 39;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search Customers";
            // 
            // custDt
            // 
            this.custDt.AllowUserToAddRows = false;
            this.custDt.AllowUserToDeleteRows = false;
            this.custDt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custDt.AutoGenerateColumns = false;
            this.custDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custDt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.custDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.custDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custRegDateDataGridViewTextBoxColumn,
            this.custPhNoDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn});
            this.custDt.DataSource = this.customersDbBindingSource1;
            this.custDt.GridColor = System.Drawing.Color.Silver;
            this.custDt.Location = new System.Drawing.Point(28, 106);
            this.custDt.Name = "custDt";
            this.custDt.ReadOnly = true;
            this.custDt.RowHeadersWidth = 51;
            this.custDt.RowTemplate.Height = 24;
            this.custDt.Size = new System.Drawing.Size(811, 437);
            this.custDt.TabIndex = 28;
            // 
            // customersDbBindingSource1
            // 
            this.customersDbBindingSource1.DataMember = "customersDb";
            this.customersDbBindingSource1.DataSource = this.shopDbDataSet3;
            // 
            // shopDbDataSet3
            // 
            this.shopDbDataSet3.DataSetName = "shopDbDataSet3";
            this.shopDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Location = new System.Drawing.Point(196, 46);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(584, 34);
            this.searchTxt.TabIndex = 27;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchLbl.Location = new System.Drawing.Point(6, 48);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(185, 28);
            this.searchLbl.TabIndex = 26;
            this.searchLbl.Text = "Enter Customer ID";
            // 
            // employeeDbBindingSource
            // 
            this.employeeDbBindingSource.DataMember = "employeeDb";
            this.employeeDbBindingSource.DataSource = this.shopDbDataSet2;
            // 
            // shopDbDataSet2
            // 
            this.shopDbDataSet2.DataSetName = "shopDbDataSet2";
            this.shopDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.exitBtn.Location = new System.Drawing.Point(1203, 29);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 38;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.backBtn.Location = new System.Drawing.Point(953, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 50);
            this.backBtn.TabIndex = 37;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.logoutBtn.Location = new System.Drawing.Point(1080, 29);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 50);
            this.logoutBtn.TabIndex = 36;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updateBtn.Location = new System.Drawing.Point(17, 329);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateBtn.Size = new System.Drawing.Size(218, 45);
            this.updateBtn.TabIndex = 35;
            this.updateBtn.Text = "Update Customer";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addBtn.Location = new System.Drawing.Point(17, 245);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addBtn.Size = new System.Drawing.Size(218, 45);
            this.addBtn.TabIndex = 33;
            this.addBtn.Text = "Add Customer";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeeDbTableAdapter
            // 
            this.employeeDbTableAdapter.ClearBeforeFill = true;
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(17, 29);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 32;
            this.logoPb.TabStop = false;
            // 
            // customersDbBindingSource
            // 
            this.customersDbBindingSource.DataMember = "customersDb";
            this.customersDbBindingSource.DataSource = this.shopDbDataSet3;
            // 
            // customersDbTableAdapter
            // 
            this.customersDbTableAdapter.ClearBeforeFill = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Name";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Cust_Name";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custRegDateDataGridViewTextBoxColumn
            // 
            this.custRegDateDataGridViewTextBoxColumn.DataPropertyName = "Cust_Reg_Date";
            this.custRegDateDataGridViewTextBoxColumn.HeaderText = "Cust_Reg_Date";
            this.custRegDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custRegDateDataGridViewTextBoxColumn.Name = "custRegDateDataGridViewTextBoxColumn";
            this.custRegDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custPhNoDataGridViewTextBoxColumn
            // 
            this.custPhNoDataGridViewTextBoxColumn.DataPropertyName = "Cust_PhNo";
            this.custPhNoDataGridViewTextBoxColumn.HeaderText = "Cust_PhNo";
            this.custPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custPhNoDataGridViewTextBoxColumn.Name = "custPhNoDataGridViewTextBoxColumn";
            this.custPhNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            this.custEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.logoPb);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.BindingSource shopDbDataSet1BindingSource;
        private shopDbDataSet1 shopDbDataSet1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.DataGridView custDt;
        private System.Windows.Forms.BindingSource employeeDbBindingSource;
        private shopDbDataSet2 shopDbDataSet2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private shopDbDataSet2TableAdapters.employeeDbTableAdapter employeeDbTableAdapter;
        private System.Windows.Forms.PictureBox logoPb;
        private shopDbDataSet3 shopDbDataSet3;
        private System.Windows.Forms.BindingSource customersDbBindingSource;
        private shopDbDataSet3TableAdapters.customersDbTableAdapter customersDbTableAdapter;
        private System.Windows.Forms.BindingSource customersDbBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custRegDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
    }
}