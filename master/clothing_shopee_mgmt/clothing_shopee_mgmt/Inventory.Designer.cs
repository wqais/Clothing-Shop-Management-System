namespace clothing_shopee_mgmt
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.productDt = new System.Windows.Forms.DataGridView();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodLastRefillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDbBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet3 = new clothing_shopee_mgmt.shopDbDataSet3();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.shopDbDataSet2 = new clothing_shopee_mgmt.shopDbDataSet2();
            this.inventoryDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet2TableAdapters.inventoryDbTableAdapter();
            this.inventoryDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDbTableAdapter1 = new clothing_shopee_mgmt.shopDbDataSet3TableAdapters.inventoryDbTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.exitBtn.Location = new System.Drawing.Point(1207, 15);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 33;
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
            this.backBtn.Location = new System.Drawing.Point(958, 15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 50);
            this.backBtn.TabIndex = 32;
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
            this.logoutBtn.Location = new System.Drawing.Point(1081, 15);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 50);
            this.logoutBtn.TabIndex = 31;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(15, 15);
            this.logoPb.Margin = new System.Windows.Forms.Padding(4);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 30;
            this.logoPb.TabStop = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.refreshBtn.Location = new System.Drawing.Point(12, 494);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Padding = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Size = new System.Drawing.Size(218, 45);
            this.refreshBtn.TabIndex = 37;
            this.refreshBtn.Text = "Refresh Window";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.updateBtn.Location = new System.Drawing.Point(12, 355);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Padding = new System.Windows.Forms.Padding(2);
            this.updateBtn.Size = new System.Drawing.Size(218, 45);
            this.updateBtn.TabIndex = 36;
            this.updateBtn.Text = "Update Product";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addProductBtn.Location = new System.Drawing.Point(13, 282);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addProductBtn.Size = new System.Drawing.Size(218, 45);
            this.addProductBtn.TabIndex = 34;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Controls.Add(this.searchBtn);
            this.searchBox.Controls.Add(this.productDt);
            this.searchBox.Controls.Add(this.searchTxt);
            this.searchBox.Controls.Add(this.searchLbl);
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBox.Location = new System.Drawing.Point(296, 122);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(877, 575);
            this.searchBox.TabIndex = 38;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search Products";
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
            // productDt
            // 
            this.productDt.AllowUserToAddRows = false;
            this.productDt.AllowUserToDeleteRows = false;
            this.productDt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productDt.AutoGenerateColumns = false;
            this.productDt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.productDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodTypeDataGridViewTextBoxColumn,
            this.prodStockDataGridViewTextBoxColumn,
            this.suplIDDataGridViewTextBoxColumn,
            this.suplNameDataGridViewTextBoxColumn,
            this.prodLastRefillDataGridViewTextBoxColumn});
            this.productDt.DataSource = this.inventoryDbBindingSource4;
            this.productDt.GridColor = System.Drawing.Color.Silver;
            this.productDt.Location = new System.Drawing.Point(28, 106);
            this.productDt.Name = "productDt";
            this.productDt.ReadOnly = true;
            this.productDt.RowHeadersWidth = 51;
            this.productDt.RowTemplate.Height = 24;
            this.productDt.Size = new System.Drawing.Size(811, 437);
            this.productDt.TabIndex = 28;
            this.productDt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDt_CellContentClick);
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "Prod_ID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "Prod_ID";
            this.prodIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "Prod_Name";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Prod_Name";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodTypeDataGridViewTextBoxColumn
            // 
            this.prodTypeDataGridViewTextBoxColumn.DataPropertyName = "Prod_Type";
            this.prodTypeDataGridViewTextBoxColumn.HeaderText = "Prod_Type";
            this.prodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodTypeDataGridViewTextBoxColumn.Name = "prodTypeDataGridViewTextBoxColumn";
            this.prodTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodStockDataGridViewTextBoxColumn
            // 
            this.prodStockDataGridViewTextBoxColumn.DataPropertyName = "Prod_Stock";
            this.prodStockDataGridViewTextBoxColumn.HeaderText = "Prod_Stock";
            this.prodStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodStockDataGridViewTextBoxColumn.Name = "prodStockDataGridViewTextBoxColumn";
            this.prodStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // suplIDDataGridViewTextBoxColumn
            // 
            this.suplIDDataGridViewTextBoxColumn.DataPropertyName = "Supl_ID";
            this.suplIDDataGridViewTextBoxColumn.HeaderText = "Supl_ID";
            this.suplIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplIDDataGridViewTextBoxColumn.Name = "suplIDDataGridViewTextBoxColumn";
            this.suplIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.suplIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // suplNameDataGridViewTextBoxColumn
            // 
            this.suplNameDataGridViewTextBoxColumn.DataPropertyName = "Supl_Name";
            this.suplNameDataGridViewTextBoxColumn.HeaderText = "Supl_Name";
            this.suplNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suplNameDataGridViewTextBoxColumn.Name = "suplNameDataGridViewTextBoxColumn";
            this.suplNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.suplNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodLastRefillDataGridViewTextBoxColumn
            // 
            this.prodLastRefillDataGridViewTextBoxColumn.DataPropertyName = "Prod_Last_Refill";
            this.prodLastRefillDataGridViewTextBoxColumn.HeaderText = "Prod_Last_Refill";
            this.prodLastRefillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodLastRefillDataGridViewTextBoxColumn.Name = "prodLastRefillDataGridViewTextBoxColumn";
            this.prodLastRefillDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodLastRefillDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryDbBindingSource4
            // 
            this.inventoryDbBindingSource4.DataMember = "inventoryDb";
            this.inventoryDbBindingSource4.DataSource = this.shopDbDataSet3;
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
            this.searchLbl.Size = new System.Drawing.Size(169, 28);
            this.searchLbl.TabIndex = 26;
            this.searchLbl.Text = "Enter Product ID";
            // 
            // shopDbDataSet2
            // 
            this.shopDbDataSet2.DataSetName = "shopDbDataSet2";
            this.shopDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDbBindingSource
            // 
            this.inventoryDbBindingSource.DataMember = "inventoryDb";
            this.inventoryDbBindingSource.DataSource = this.shopDbDataSet2;
            // 
            // inventoryDbTableAdapter
            // 
            this.inventoryDbTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDbBindingSource1
            // 
            this.inventoryDbBindingSource1.DataMember = "inventoryDb";
            this.inventoryDbBindingSource1.DataSource = this.shopDbDataSet2;
            // 
            // inventoryDbBindingSource2
            // 
            this.inventoryDbBindingSource2.DataMember = "inventoryDb";
            this.inventoryDbBindingSource2.DataSource = this.shopDbDataSet2;
            // 
            // inventoryDbBindingSource3
            // 
            this.inventoryDbBindingSource3.DataMember = "inventoryDb";
            this.inventoryDbBindingSource3.DataSource = this.shopDbDataSet2;
            // 
            // inventoryDbTableAdapter1
            // 
            this.inventoryDbTableAdapter1.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.deleteBtn.Location = new System.Drawing.Point(12, 427);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Size = new System.Drawing.Size(218, 45);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Delete Product";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.logoPb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView productDt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private shopDbDataSet2 shopDbDataSet2;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource;
        private shopDbDataSet2TableAdapters.inventoryDbTableAdapter inventoryDbTableAdapter;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource3;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource1;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource2;
        private shopDbDataSet3 shopDbDataSet3;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource4;
        private shopDbDataSet3TableAdapters.inventoryDbTableAdapter inventoryDbTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodLastRefillDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteBtn;
    }
}