namespace clothing_shopee_mgmt
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.removeEmpBtn = new System.Windows.Forms.Button();
            this.updatEmpBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.empDt = new System.Windows.Forms.DataGridView();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDOJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet4 = new clothing_shopee_mgmt.shopDbDataSet4();
            this.employeeDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet2 = new clothing_shopee_mgmt.shopDbDataSet2();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.shopDbDataSet1 = new clothing_shopee_mgmt.shopDbDataSet1();
            this.shopDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet2TableAdapters.employeeDbTableAdapter();
            this.updateBtn = new System.Windows.Forms.Button();
            this.employeeDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDbTableAdapter1 = new clothing_shopee_mgmt.shopDbDataSet4TableAdapters.employeeDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).BeginInit();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(22, 12);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 5;
            this.logoPb.TabStop = false;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addEmpBtn.Location = new System.Drawing.Point(22, 228);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addEmpBtn.Size = new System.Drawing.Size(218, 45);
            this.addEmpBtn.TabIndex = 8;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // removeEmpBtn
            // 
            this.removeEmpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.removeEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeEmpBtn.Enabled = false;
            this.removeEmpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.removeEmpBtn.Location = new System.Drawing.Point(22, 312);
            this.removeEmpBtn.Name = "removeEmpBtn";
            this.removeEmpBtn.Padding = new System.Windows.Forms.Padding(2);
            this.removeEmpBtn.Size = new System.Drawing.Size(218, 45);
            this.removeEmpBtn.TabIndex = 9;
            this.removeEmpBtn.Text = "Remove Employee";
            this.removeEmpBtn.UseVisualStyleBackColor = false;
            this.removeEmpBtn.Click += new System.EventHandler(this.removeEmpBtn_Click);
            // 
            // updatEmpBtn
            // 
            this.updatEmpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updatEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updatEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatEmpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatEmpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updatEmpBtn.Location = new System.Drawing.Point(22, 402);
            this.updatEmpBtn.Name = "updatEmpBtn";
            this.updatEmpBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updatEmpBtn.Size = new System.Drawing.Size(218, 45);
            this.updatEmpBtn.TabIndex = 10;
            this.updatEmpBtn.Text = "Update Employee";
            this.updatEmpBtn.UseVisualStyleBackColor = false;
            this.updatEmpBtn.Click += new System.EventHandler(this.updatEmpBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.logoutBtn.Location = new System.Drawing.Point(1085, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 50);
            this.logoutBtn.TabIndex = 22;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.backBtn.Location = new System.Drawing.Point(958, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 50);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchLbl.Location = new System.Drawing.Point(6, 48);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(187, 28);
            this.searchLbl.TabIndex = 26;
            this.searchLbl.Text = "Enter Employee ID";
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
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // empDt
            // 
            this.empDt.AllowUserToAddRows = false;
            this.empDt.AllowUserToDeleteRows = false;
            this.empDt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empDt.AutoGenerateColumns = false;
            this.empDt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.empDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eIDDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.eEmailDataGridViewTextBoxColumn,
            this.ePhNoDataGridViewTextBoxColumn,
            this.eAddrDataGridViewTextBoxColumn,
            this.eDOJDataGridViewTextBoxColumn});
            this.empDt.DataSource = this.employeeDbBindingSource2;
            this.empDt.GridColor = System.Drawing.Color.Silver;
            this.empDt.Location = new System.Drawing.Point(28, 106);
            this.empDt.Name = "empDt";
            this.empDt.ReadOnly = true;
            this.empDt.RowHeadersWidth = 51;
            this.empDt.RowTemplate.Height = 24;
            this.empDt.Size = new System.Drawing.Size(811, 437);
            this.empDt.TabIndex = 28;
            this.empDt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDt_CellContentClick);
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "E_ID";
            this.eIDDataGridViewTextBoxColumn.FillWeight = 98.9446F;
            this.eIDDataGridViewTextBoxColumn.HeaderText = "E_ID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "E_Name";
            this.eNameDataGridViewTextBoxColumn.FillWeight = 99.46864F;
            this.eNameDataGridViewTextBoxColumn.HeaderText = "E_Name";
            this.eNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            this.eNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNameDataGridViewTextBoxColumn.Width = 126;
            // 
            // eEmailDataGridViewTextBoxColumn
            // 
            this.eEmailDataGridViewTextBoxColumn.DataPropertyName = "E_Email";
            this.eEmailDataGridViewTextBoxColumn.FillWeight = 99.90627F;
            this.eEmailDataGridViewTextBoxColumn.HeaderText = "E_Email";
            this.eEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eEmailDataGridViewTextBoxColumn.Name = "eEmailDataGridViewTextBoxColumn";
            this.eEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.eEmailDataGridViewTextBoxColumn.Width = 126;
            // 
            // ePhNoDataGridViewTextBoxColumn
            // 
            this.ePhNoDataGridViewTextBoxColumn.DataPropertyName = "E_PhNo";
            this.ePhNoDataGridViewTextBoxColumn.FillWeight = 100.2717F;
            this.ePhNoDataGridViewTextBoxColumn.HeaderText = "E_PhNo";
            this.ePhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePhNoDataGridViewTextBoxColumn.Name = "ePhNoDataGridViewTextBoxColumn";
            this.ePhNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ePhNoDataGridViewTextBoxColumn.Width = 127;
            // 
            // eAddrDataGridViewTextBoxColumn
            // 
            this.eAddrDataGridViewTextBoxColumn.DataPropertyName = "E_Addr";
            this.eAddrDataGridViewTextBoxColumn.FillWeight = 100.577F;
            this.eAddrDataGridViewTextBoxColumn.HeaderText = "E_Addr";
            this.eAddrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eAddrDataGridViewTextBoxColumn.Name = "eAddrDataGridViewTextBoxColumn";
            this.eAddrDataGridViewTextBoxColumn.ReadOnly = true;
            this.eAddrDataGridViewTextBoxColumn.Width = 127;
            // 
            // eDOJDataGridViewTextBoxColumn
            // 
            this.eDOJDataGridViewTextBoxColumn.DataPropertyName = "E_DOJ";
            this.eDOJDataGridViewTextBoxColumn.FillWeight = 100.8318F;
            this.eDOJDataGridViewTextBoxColumn.HeaderText = "E_DOJ";
            this.eDOJDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDOJDataGridViewTextBoxColumn.Name = "eDOJDataGridViewTextBoxColumn";
            this.eDOJDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDOJDataGridViewTextBoxColumn.Width = 127;
            // 
            // employeeDbBindingSource2
            // 
            this.employeeDbBindingSource2.DataMember = "employeeDb";
            this.employeeDbBindingSource2.DataSource = this.shopDbDataSet4;
            // 
            // shopDbDataSet4
            // 
            this.shopDbDataSet4.DataSetName = "shopDbDataSet4";
            this.shopDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.exitBtn.Location = new System.Drawing.Point(1208, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 29;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Controls.Add(this.searchBtn);
            this.searchBox.Controls.Add(this.empDt);
            this.searchBox.Controls.Add(this.searchTxt);
            this.searchBox.Controls.Add(this.searchLbl);
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBox.Location = new System.Drawing.Point(296, 122);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(877, 575);
            this.searchBox.TabIndex = 30;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search Employee";
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
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // shopDbDataSet1
            // 
            this.shopDbDataSet1.DataSetName = "shopDbDataSet1";
            this.shopDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopDbDataSet1BindingSource
            // 
            this.shopDbDataSet1BindingSource.DataSource = this.shopDbDataSet1;
            this.shopDbDataSet1BindingSource.Position = 0;
            // 
            // employeeDbTableAdapter
            // 
            this.employeeDbTableAdapter.ClearBeforeFill = true;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updateBtn.Location = new System.Drawing.Point(22, 488);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateBtn.Size = new System.Drawing.Size(218, 45);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "Refresh Window";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // employeeDbBindingSource1
            // 
            this.employeeDbBindingSource1.DataMember = "employeeDb";
            this.employeeDbBindingSource1.DataSource = this.shopDbDataSet4;
            // 
            // employeeDbTableAdapter1
            // 
            this.employeeDbTableAdapter1.ClearBeforeFill = true;
            // 
            // Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updatEmpBtn);
            this.Controls.Add(this.removeEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.logoPb);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.Text = "Employee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDbBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button removeEmpBtn;
        private System.Windows.Forms.Button updatEmpBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView empDt;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.BindingSource shopDbDataSet1BindingSource;
        private shopDbDataSet1 shopDbDataSet1;
        private shopDbDataSet2 shopDbDataSet2;
        private System.Windows.Forms.BindingSource employeeDbBindingSource;
        private shopDbDataSet2TableAdapters.employeeDbTableAdapter employeeDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDOJDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private shopDbDataSet4 shopDbDataSet4;
        private System.Windows.Forms.BindingSource employeeDbBindingSource1;
        private shopDbDataSet4TableAdapters.employeeDbTableAdapter employeeDbTableAdapter1;
        private System.Windows.Forms.BindingSource employeeDbBindingSource2;
    }
}