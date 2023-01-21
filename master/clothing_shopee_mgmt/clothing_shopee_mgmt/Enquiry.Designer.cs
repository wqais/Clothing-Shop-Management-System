namespace clothing_shopee_mgmt
{
    partial class Enquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enquiry));
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.enqDt = new System.Windows.Forms.DataGridView();
            this.enqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquirySubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet4 = new clothing_shopee_mgmt.shopDbDataSet4();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.enquiryDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet4TableAdapters.enquiryDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enqDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).BeginInit();
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
            this.exitBtn.Location = new System.Drawing.Point(1209, 12);
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
            this.backBtn.Location = new System.Drawing.Point(959, 12);
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
            this.logoutBtn.Location = new System.Drawing.Point(1086, 12);
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
            this.logoPb.Location = new System.Drawing.Point(12, 12);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(171, 171);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPb.TabIndex = 30;
            this.logoPb.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Controls.Add(this.searchBtn);
            this.searchBox.Controls.Add(this.enqDt);
            this.searchBox.Controls.Add(this.searchTxt);
            this.searchBox.Controls.Add(this.searchLbl);
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBox.Location = new System.Drawing.Point(291, 156);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(877, 575);
            this.searchBox.TabIndex = 36;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search Enquires";
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
            // 
            // enqDt
            // 
            this.enqDt.AllowUserToAddRows = false;
            this.enqDt.AllowUserToDeleteRows = false;
            this.enqDt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enqDt.AutoGenerateColumns = false;
            this.enqDt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enqDt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.enqDt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.enqDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enqDt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enqIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.enquirySubjectDataGridViewTextBoxColumn,
            this.ticketStatusDataGridViewTextBoxColumn});
            this.enqDt.DataSource = this.enquiryDbBindingSource;
            this.enqDt.GridColor = System.Drawing.Color.Silver;
            this.enqDt.Location = new System.Drawing.Point(28, 106);
            this.enqDt.Name = "enqDt";
            this.enqDt.ReadOnly = true;
            this.enqDt.RowHeadersWidth = 51;
            this.enqDt.RowTemplate.Height = 24;
            this.enqDt.Size = new System.Drawing.Size(811, 437);
            this.enqDt.TabIndex = 28;
            this.enqDt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enqDt_CellContentClick);
            // 
            // enqIDDataGridViewTextBoxColumn
            // 
            this.enqIDDataGridViewTextBoxColumn.DataPropertyName = "Enq_ID";
            this.enqIDDataGridViewTextBoxColumn.HeaderText = "Enq_ID";
            this.enqIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enqIDDataGridViewTextBoxColumn.Name = "enqIDDataGridViewTextBoxColumn";
            this.enqIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enquirySubjectDataGridViewTextBoxColumn
            // 
            this.enquirySubjectDataGridViewTextBoxColumn.DataPropertyName = "Enquiry_Subject";
            this.enquirySubjectDataGridViewTextBoxColumn.HeaderText = "Enquiry_Subject";
            this.enquirySubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enquirySubjectDataGridViewTextBoxColumn.Name = "enquirySubjectDataGridViewTextBoxColumn";
            this.enquirySubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketStatusDataGridViewTextBoxColumn
            // 
            this.ticketStatusDataGridViewTextBoxColumn.DataPropertyName = "Ticket_Status";
            this.ticketStatusDataGridViewTextBoxColumn.HeaderText = "Ticket_Status";
            this.ticketStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketStatusDataGridViewTextBoxColumn.Name = "ticketStatusDataGridViewTextBoxColumn";
            this.ticketStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enquiryDbBindingSource
            // 
            this.enquiryDbBindingSource.DataMember = "enquiryDb";
            this.enquiryDbBindingSource.DataSource = this.shopDbDataSet4;
            // 
            // shopDbDataSet4
            // 
            this.shopDbDataSet4.DataSetName = "shopDbDataSet4";
            this.shopDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.searchLbl.Size = new System.Drawing.Size(168, 28);
            this.searchLbl.TabIndex = 26;
            this.searchLbl.Text = "Enter Enquiry ID";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Enabled = false;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.closeBtn.Location = new System.Drawing.Point(17, 346);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(2);
            this.closeBtn.Size = new System.Drawing.Size(218, 45);
            this.closeBtn.TabIndex = 35;
            this.closeBtn.Text = "Close Ticket";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addBtn.Location = new System.Drawing.Point(17, 262);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addBtn.Size = new System.Drawing.Size(218, 45);
            this.addBtn.TabIndex = 34;
            this.addBtn.Text = "Open Ticket";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.refreshBtn.Location = new System.Drawing.Point(17, 436);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Padding = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Size = new System.Drawing.Size(218, 45);
            this.refreshBtn.TabIndex = 37;
            this.refreshBtn.Text = "Refresh Window";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // enquiryDbTableAdapter
            // 
            this.enquiryDbTableAdapter.ClearBeforeFill = true;
            // 
            // Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1320, 743);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.logoPb);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enquiry";
            this.Text = "Enquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Enquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enqDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView enqDt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshBtn;
        private shopDbDataSet4 shopDbDataSet4;
        private System.Windows.Forms.BindingSource enquiryDbBindingSource;
        private shopDbDataSet4TableAdapters.enquiryDbTableAdapter enquiryDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquirySubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStatusDataGridViewTextBoxColumn;
    }
}