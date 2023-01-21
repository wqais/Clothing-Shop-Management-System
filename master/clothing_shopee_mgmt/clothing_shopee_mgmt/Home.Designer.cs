namespace clothing_shopee_mgmt
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.billingBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.enquiriesBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.empMgmtBtn = new System.Windows.Forms.Button();
            this.payrollBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dateUpdate = new System.Windows.Forms.Timer(this.components);
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.profileBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
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
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.timeLbl.Location = new System.Drawing.Point(1125, 95);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(129, 38);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "00:00:00";
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.dateLbl.Location = new System.Drawing.Point(1125, 41);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(187, 38);
            this.dateLbl.TabIndex = 11;
            this.dateLbl.Text = "dd/mm/yyyy";
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.inventoryBtn.Location = new System.Drawing.Point(340, 212);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(180, 90);
            this.inventoryBtn.TabIndex = 13;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suppliersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.suppliersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.suppliersBtn.Location = new System.Drawing.Point(340, 332);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(180, 90);
            this.suppliersBtn.TabIndex = 14;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.UseVisualStyleBackColor = false;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // billingBtn
            // 
            this.billingBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.billingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.billingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.billingBtn.Location = new System.Drawing.Point(340, 452);
            this.billingBtn.Name = "billingBtn";
            this.billingBtn.Size = new System.Drawing.Size(180, 90);
            this.billingBtn.TabIndex = 15;
            this.billingBtn.Text = "Billing";
            this.billingBtn.UseVisualStyleBackColor = false;
            this.billingBtn.Click += new System.EventHandler(this.billingBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.reportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.reportsBtn.Location = new System.Drawing.Point(340, 572);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(180, 90);
            this.reportsBtn.TabIndex = 16;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // enquiriesBtn
            // 
            this.enquiriesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enquiriesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.enquiriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enquiriesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiriesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.enquiriesBtn.Location = new System.Drawing.Point(756, 212);
            this.enquiriesBtn.Name = "enquiriesBtn";
            this.enquiriesBtn.Size = new System.Drawing.Size(180, 90);
            this.enquiriesBtn.TabIndex = 17;
            this.enquiriesBtn.Text = "Enquiries";
            this.enquiriesBtn.UseVisualStyleBackColor = false;
            this.enquiriesBtn.Click += new System.EventHandler(this.enquiriesBtn_Click);
            // 
            // customersBtn
            // 
            this.customersBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.customersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.customersBtn.Location = new System.Drawing.Point(756, 332);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(180, 90);
            this.customersBtn.TabIndex = 18;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = false;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // empMgmtBtn
            // 
            this.empMgmtBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.empMgmtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.empMgmtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empMgmtBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empMgmtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.empMgmtBtn.Location = new System.Drawing.Point(756, 452);
            this.empMgmtBtn.Name = "empMgmtBtn";
            this.empMgmtBtn.Size = new System.Drawing.Size(180, 90);
            this.empMgmtBtn.TabIndex = 19;
            this.empMgmtBtn.Text = "Employee Management";
            this.empMgmtBtn.UseVisualStyleBackColor = false;
            this.empMgmtBtn.Click += new System.EventHandler(this.empMgmtBtn_Click);
            // 
            // payrollBtn
            // 
            this.payrollBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.payrollBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.payrollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payrollBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.payrollBtn.Location = new System.Drawing.Point(756, 572);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(180, 90);
            this.payrollBtn.TabIndex = 20;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = false;
            this.payrollBtn.Click += new System.EventHandler(this.payrollBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.logoutBtn.Location = new System.Drawing.Point(1132, 212);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 50);
            this.logoutBtn.TabIndex = 21;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dateUpdate
            // 
            this.dateUpdate.Enabled = true;
            this.dateUpdate.Interval = 1000;
            this.dateUpdate.Tick += new System.EventHandler(this.dateUpdate_Tick);
            // 
            // timeUpdate
            // 
            this.timeUpdate.Enabled = true;
            this.timeUpdate.Interval = 1000;
            this.timeUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // profileBtn
            // 
            this.profileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileBtn.Location = new System.Drawing.Point(756, 29);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(180, 50);
            this.profileBtn.TabIndex = 43;
            this.profileBtn.Text = "My Profile";
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.Location = new System.Drawing.Point(1132, 281);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 50);
            this.exitBtn.TabIndex = 61;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1327, 738);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.payrollBtn);
            this.Controls.Add(this.empMgmtBtn);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.enquiriesBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.billingBtn);
            this.Controls.Add(this.suppliersBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.logoPb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button billingBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button enquiriesBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button empMgmtBtn;
        private System.Windows.Forms.Button payrollBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Timer dateUpdate;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}