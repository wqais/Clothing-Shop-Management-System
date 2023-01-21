namespace clothing_shopee_mgmt
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.shopDbDataSet = new clothing_shopee_mgmt.shopDbDataSet();
            this.shopDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet1 = new clothing_shopee_mgmt.shopDbDataSet1();
            this.shopDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet1TableAdapters.supplierDbTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.updateSuplBtn = new System.Windows.Forms.Button();
            this.removeSuplBtn = new System.Windows.Forms.Button();
            this.addSuplBtn = new System.Windows.Forms.Button();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.suplDt = new System.Windows.Forms.DataGridView();
            this.Supl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplPhNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplAddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet2 = new clothing_shopee_mgmt.shopDbDataSet2();
            this.supplierDbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.searchSuplBox = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.supplierDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateBtn = new System.Windows.Forms.Button();
            this.supplierDbTableAdapter1 = new clothing_shopee_mgmt.shopDbDataSet2TableAdapters.supplierDbTableAdapter();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource2)).BeginInit();
            this.searchSuplBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDbDataSet
            // 
            this.shopDbDataSet.DataSetName = "shopDbDataSet";
            this.shopDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopDbDataSetBindingSource
            // 
            this.shopDbDataSetBindingSource.DataSource = this.shopDbDataSet;
            this.shopDbDataSetBindingSource.Position = 0;
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
            // supplierDbBindingSource
            // 
            this.supplierDbBindingSource.DataMember = "supplierDb";
            this.supplierDbBindingSource.DataSource = this.shopDbDataSet1BindingSource;
            // 
            // supplierDbTableAdapter
            // 
            this.supplierDbTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.backBtn.Location = new System.Drawing.Point(951, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 50);
            this.backBtn.TabIndex = 36;
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
            this.logoutBtn.Location = new System.Drawing.Point(1078, 27);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 50);
            this.logoutBtn.TabIndex = 35;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // updateSuplBtn
            // 
            this.updateSuplBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateSuplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updateSuplBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSuplBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSuplBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updateSuplBtn.Location = new System.Drawing.Point(15, 411);
            this.updateSuplBtn.Name = "updateSuplBtn";
            this.updateSuplBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateSuplBtn.Size = new System.Drawing.Size(218, 45);
            this.updateSuplBtn.TabIndex = 34;
            this.updateSuplBtn.Text = "Update Supplier";
            this.updateSuplBtn.UseVisualStyleBackColor = false;
            this.updateSuplBtn.Click += new System.EventHandler(this.updateSuplBtn_Click);
            // 
            // removeSuplBtn
            // 
            this.removeSuplBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeSuplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.removeSuplBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSuplBtn.Enabled = false;
            this.removeSuplBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSuplBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.removeSuplBtn.Location = new System.Drawing.Point(15, 327);
            this.removeSuplBtn.Name = "removeSuplBtn";
            this.removeSuplBtn.Padding = new System.Windows.Forms.Padding(2);
            this.removeSuplBtn.Size = new System.Drawing.Size(218, 45);
            this.removeSuplBtn.TabIndex = 33;
            this.removeSuplBtn.Text = "Remove Supplier";
            this.removeSuplBtn.UseVisualStyleBackColor = false;
            this.removeSuplBtn.Click += new System.EventHandler(this.removeSuplBtn_Click);
            // 
            // addSuplBtn
            // 
            this.addSuplBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addSuplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addSuplBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSuplBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSuplBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addSuplBtn.Location = new System.Drawing.Point(15, 243);
            this.addSuplBtn.Name = "addSuplBtn";
            this.addSuplBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addSuplBtn.Size = new System.Drawing.Size(218, 45);
            this.addSuplBtn.TabIndex = 32;
            this.addSuplBtn.Text = "Add Supplier";
            this.addSuplBtn.UseVisualStyleBackColor = false;
            this.addSuplBtn.Click += new System.EventHandler(this.addSuplBtn_Click);
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(15, 27);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 31;
            this.logoPb.TabStop = false;
            // 
            // suplDt
            // 
            this.suplDt.AllowUserToAddRows = false;
            this.suplDt.AllowUserToDeleteRows = false;
            this.suplDt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.suplDt.AutoGenerateColumns = false;
            this.suplDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.suplDt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.suplDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.suplDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suplDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supl_ID,
            this.suplNameDataGridViewTextBoxColumn,
            this.suplPhNoDataGridViewTextBoxColumn,
            this.suplEmailDataGridViewTextBoxColumn,
            this.suplAddrDataGridViewTextBoxColumn,
            this.suplTypeDataGridViewTextBoxColumn});
            this.suplDt.DataSource = this.supplierDbBindingSource3;
            this.suplDt.GridColor = System.Drawing.Color.Silver;
            this.suplDt.Location = new System.Drawing.Point(28, 106);
            this.suplDt.Name = "suplDt";
            this.suplDt.ReadOnly = true;
            this.suplDt.RowHeadersWidth = 51;
            this.suplDt.RowTemplate.Height = 24;
            this.suplDt.Size = new System.Drawing.Size(811, 437);
            this.suplDt.TabIndex = 28;
            this.suplDt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suplDt_CellContentClick);
            // 
            // Supl_ID
            // 
            this.Supl_ID.DataPropertyName = "Supl_ID";
            this.Supl_ID.HeaderText = "Supl_ID";
            this.Supl_ID.MinimumWidth = 6;
            this.Supl_ID.Name = "Supl_ID";
            this.Supl_ID.ReadOnly = true;
            // 
            // suplNameDataGridViewTextBoxColumn
            // 
            this.suplNameDataGridViewTextBoxColumn.DataPropertyName = "Supl_Name";
            this.suplNameDataGridViewTextBoxColumn.HeaderText = "Supl_Name";
            this.suplNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplNameDataGridViewTextBoxColumn.Name = "suplNameDataGridViewTextBoxColumn";
            this.suplNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suplPhNoDataGridViewTextBoxColumn
            // 
            this.suplPhNoDataGridViewTextBoxColumn.DataPropertyName = "Supl_PhNo";
            this.suplPhNoDataGridViewTextBoxColumn.HeaderText = "Supl_PhNo";
            this.suplPhNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplPhNoDataGridViewTextBoxColumn.Name = "suplPhNoDataGridViewTextBoxColumn";
            this.suplPhNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suplEmailDataGridViewTextBoxColumn
            // 
            this.suplEmailDataGridViewTextBoxColumn.DataPropertyName = "Supl_Email";
            this.suplEmailDataGridViewTextBoxColumn.HeaderText = "Supl_Email";
            this.suplEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplEmailDataGridViewTextBoxColumn.Name = "suplEmailDataGridViewTextBoxColumn";
            this.suplEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suplAddrDataGridViewTextBoxColumn
            // 
            this.suplAddrDataGridViewTextBoxColumn.DataPropertyName = "Supl_Addr";
            this.suplAddrDataGridViewTextBoxColumn.HeaderText = "Supl_Addr";
            this.suplAddrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplAddrDataGridViewTextBoxColumn.Name = "suplAddrDataGridViewTextBoxColumn";
            this.suplAddrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suplTypeDataGridViewTextBoxColumn
            // 
            this.suplTypeDataGridViewTextBoxColumn.DataPropertyName = "Supl_Type";
            this.suplTypeDataGridViewTextBoxColumn.HeaderText = "Supl_Type";
            this.suplTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplTypeDataGridViewTextBoxColumn.Name = "suplTypeDataGridViewTextBoxColumn";
            this.suplTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDbBindingSource3
            // 
            this.supplierDbBindingSource3.DataMember = "supplierDb";
            this.supplierDbBindingSource3.DataSource = this.shopDbDataSet2;
            // 
            // shopDbDataSet2
            // 
            this.shopDbDataSet2.DataSetName = "shopDbDataSet2";
            this.shopDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierDbBindingSource2
            // 
            this.supplierDbBindingSource2.DataMember = "supplierDb";
            this.supplierDbBindingSource2.DataSource = this.shopDbDataSet1BindingSource;
            // 
            // searchSuplBox
            // 
            this.searchSuplBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSuplBox.Controls.Add(this.searchBtn);
            this.searchSuplBox.Controls.Add(this.searchTxt);
            this.searchSuplBox.Controls.Add(this.searchLbl);
            this.searchSuplBox.Controls.Add(this.suplDt);
            this.searchSuplBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSuplBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchSuplBox.Location = new System.Drawing.Point(289, 137);
            this.searchSuplBox.Name = "searchSuplBox";
            this.searchSuplBox.Size = new System.Drawing.Size(877, 575);
            this.searchSuplBox.TabIndex = 38;
            this.searchSuplBox.TabStop = false;
            this.searchSuplBox.Text = "Search Suppliers";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.exitBtn.Location = new System.Drawing.Point(1201, 27);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // supplierDbBindingSource1
            // 
            this.supplierDbBindingSource1.DataMember = "supplierDb";
            this.supplierDbBindingSource1.DataSource = this.shopDbDataSet1BindingSource;
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updateBtn.Location = new System.Drawing.Point(15, 496);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateBtn.Size = new System.Drawing.Size(218, 45);
            this.updateBtn.TabIndex = 39;
            this.updateBtn.Text = "Update Window";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // supplierDbTableAdapter1
            // 
            this.supplierDbTableAdapter1.ClearBeforeFill = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBtn.Location = new System.Drawing.Point(794, 50);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(53, 29);
            this.searchBtn.TabIndex = 35;
            this.searchBtn.Text = "Go";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Location = new System.Drawing.Point(204, 50);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(584, 34);
            this.searchTxt.TabIndex = 34;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // searchLbl
            // 
            this.searchLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchLbl.Location = new System.Drawing.Point(14, 52);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(173, 28);
            this.searchLbl.TabIndex = 33;
            this.searchLbl.Text = "Enter Supplier ID";
            // 
            // Supplier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1317, 738);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updateSuplBtn);
            this.Controls.Add(this.removeSuplBtn);
            this.Controls.Add(this.addSuplBtn);
            this.Controls.Add(this.logoPb);
            this.Controls.Add(this.searchSuplBox);
            this.Controls.Add(this.exitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource2)).EndInit();
            this.searchSuplBox.ResumeLayout(false);
            this.searchSuplBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private shopDbDataSet shopDbDataSet;
        private System.Windows.Forms.BindingSource shopDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource shopDbDataSet1BindingSource;
        private shopDbDataSet1 shopDbDataSet1;
        private System.Windows.Forms.BindingSource supplierDbBindingSource;
        private shopDbDataSet1TableAdapters.supplierDbTableAdapter supplierDbTableAdapter;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button updateSuplBtn;
        private System.Windows.Forms.Button removeSuplBtn;
        private System.Windows.Forms.Button addSuplBtn;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.DataGridView suplDt;
        private System.Windows.Forms.GroupBox searchSuplBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.BindingSource supplierDbBindingSource1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.BindingSource supplierDbBindingSource2;
        private shopDbDataSet2 shopDbDataSet2;
        private System.Windows.Forms.BindingSource supplierDbBindingSource3;
        private shopDbDataSet2TableAdapters.supplierDbTableAdapter supplierDbTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplPhNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplAddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
    }
}