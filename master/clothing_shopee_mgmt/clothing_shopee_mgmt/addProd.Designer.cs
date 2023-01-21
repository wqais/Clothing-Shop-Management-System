namespace clothing_shopee_mgmt
{
    partial class addProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProd));
            this.addProdForm = new System.Windows.Forms.GroupBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suplIdCB = new System.Windows.Forms.ComboBox();
            this.supplierDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet3 = new clothing_shopee_mgmt.shopDbDataSet3();
            this.snameTxt = new System.Windows.Forms.TextBox();
            this.snameLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.pidTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.refillLbl = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.sIDLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.supplierDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet3TableAdapters.supplierDbTableAdapter();
            this.addProdForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // addProdForm
            // 
            this.addProdForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProdForm.Controls.Add(this.priceTxt);
            this.addProdForm.Controls.Add(this.label1);
            this.addProdForm.Controls.Add(this.suplIdCB);
            this.addProdForm.Controls.Add(this.snameTxt);
            this.addProdForm.Controls.Add(this.snameLbl);
            this.addProdForm.Controls.Add(this.datePicker);
            this.addProdForm.Controls.Add(this.stockTxt);
            this.addProdForm.Controls.Add(this.typeTxt);
            this.addProdForm.Controls.Add(this.nameTxt);
            this.addProdForm.Controls.Add(this.pidTxt);
            this.addProdForm.Controls.Add(this.cancelBtn);
            this.addProdForm.Controls.Add(this.clearBtn);
            this.addProdForm.Controls.Add(this.saveBtn);
            this.addProdForm.Controls.Add(this.refillLbl);
            this.addProdForm.Controls.Add(this.stockLbl);
            this.addProdForm.Controls.Add(this.typeLbl);
            this.addProdForm.Controls.Add(this.sIDLbl);
            this.addProdForm.Controls.Add(this.nameLbl);
            this.addProdForm.Controls.Add(this.idLbl);
            this.addProdForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addProdForm.Location = new System.Drawing.Point(277, 99);
            this.addProdForm.Name = "addProdForm";
            this.addProdForm.Size = new System.Drawing.Size(607, 614);
            this.addProdForm.TabIndex = 41;
            this.addProdForm.TabStop = false;
            this.addProdForm.Text = "Enter Product Details";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(277, 414);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(255, 34);
            this.priceTxt.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(41, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Price";
            // 
            // suplIdCB
            // 
            this.suplIdCB.DataSource = this.supplierDbBindingSource;
            this.suplIdCB.DisplayMember = "Supl_ID";
            this.suplIdCB.FormattingEnabled = true;
            this.suplIdCB.Location = new System.Drawing.Point(277, 179);
            this.suplIdCB.Name = "suplIdCB";
            this.suplIdCB.Size = new System.Drawing.Size(255, 36);
            this.suplIdCB.TabIndex = 44;
            this.suplIdCB.ValueMember = "Supl_ID";
            this.suplIdCB.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // supplierDbBindingSource
            // 
            this.supplierDbBindingSource.DataMember = "supplierDb";
            this.supplierDbBindingSource.DataSource = this.shopDbDataSet3;
            // 
            // shopDbDataSet3
            // 
            this.shopDbDataSet3.DataSetName = "shopDbDataSet3";
            this.shopDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snameTxt
            // 
            this.snameTxt.Enabled = false;
            this.snameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameTxt.Location = new System.Drawing.Point(277, 242);
            this.snameTxt.Name = "snameTxt";
            this.snameTxt.Size = new System.Drawing.Size(255, 34);
            this.snameTxt.TabIndex = 43;
            // 
            // snameLbl
            // 
            this.snameLbl.AutoSize = true;
            this.snameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.snameLbl.Location = new System.Drawing.Point(41, 250);
            this.snameLbl.Name = "snameLbl";
            this.snameLbl.Size = new System.Drawing.Size(123, 23);
            this.snameLbl.TabIndex = 42;
            this.snameLbl.Text = "Supplier Name";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(277, 471);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(255, 34);
            this.datePicker.TabIndex = 41;
            // 
            // stockTxt
            // 
            this.stockTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTxt.Location = new System.Drawing.Point(277, 354);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(255, 34);
            this.stockTxt.TabIndex = 38;
            // 
            // typeTxt
            // 
            this.typeTxt.Enabled = false;
            this.typeTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTxt.Location = new System.Drawing.Point(277, 296);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(255, 34);
            this.typeTxt.TabIndex = 37;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(277, 119);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(255, 34);
            this.nameTxt.TabIndex = 35;
            // 
            // pidTxt
            // 
            this.pidTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidTxt.Location = new System.Drawing.Point(277, 65);
            this.pidTxt.Name = "pidTxt";
            this.pidTxt.Size = new System.Drawing.Size(255, 34);
            this.pidTxt.TabIndex = 34;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.cancelBtn.Location = new System.Drawing.Point(45, 538);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 45);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.clearBtn.Location = new System.Drawing.Point(277, 536);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(2);
            this.clearBtn.Size = new System.Drawing.Size(94, 45);
            this.clearBtn.TabIndex = 32;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.saveBtn.Location = new System.Drawing.Point(438, 536);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(2);
            this.saveBtn.Size = new System.Drawing.Size(94, 45);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // refillLbl
            // 
            this.refillLbl.AutoSize = true;
            this.refillLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.refillLbl.Location = new System.Drawing.Point(41, 481);
            this.refillLbl.Name = "refillLbl";
            this.refillLbl.Size = new System.Drawing.Size(90, 23);
            this.refillLbl.TabIndex = 30;
            this.refillLbl.Text = "Next Refill";
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.stockLbl.Location = new System.Drawing.Point(41, 365);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(52, 23);
            this.stockLbl.TabIndex = 29;
            this.stockLbl.Text = "Stock";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.typeLbl.Location = new System.Drawing.Point(41, 307);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(111, 23);
            this.typeLbl.TabIndex = 28;
            this.typeLbl.Text = "Product Type";
            // 
            // sIDLbl
            // 
            this.sIDLbl.AutoSize = true;
            this.sIDLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.sIDLbl.Location = new System.Drawing.Point(41, 187);
            this.sIDLbl.Name = "sIDLbl";
            this.sIDLbl.Size = new System.Drawing.Size(94, 23);
            this.sIDLbl.TabIndex = 27;
            this.sIDLbl.Text = "Supplier ID";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.nameLbl.Location = new System.Drawing.Point(41, 127);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(121, 23);
            this.nameLbl.TabIndex = 26;
            this.nameLbl.Text = "Product Name";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.idLbl.Location = new System.Drawing.Point(41, 73);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(92, 23);
            this.idLbl.TabIndex = 25;
            this.idLbl.Text = "Product ID";
            // 
            // supplierDbTableAdapter
            // 
            this.supplierDbTableAdapter.ClearBeforeFill = true;
            // 
            // addProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1162, 812);
            this.Controls.Add(this.addProdForm);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.addProd_Load);
            this.addProdForm.ResumeLayout(false);
            this.addProdForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addProdForm;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox pidTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label refillLbl;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label sIDLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox snameTxt;
        private System.Windows.Forms.Label snameLbl;
        private System.Windows.Forms.ComboBox suplIdCB;
        private shopDbDataSet3 shopDbDataSet3;
        private System.Windows.Forms.BindingSource supplierDbBindingSource;
        private shopDbDataSet3TableAdapters.supplierDbTableAdapter supplierDbTableAdapter;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label1;
    }
}