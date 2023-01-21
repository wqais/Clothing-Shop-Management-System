namespace clothing_shopee_mgmt
{
    partial class addBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBill));
            this.backBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.billData = new System.Windows.Forms.DataGridView();
            this.sRNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempBillDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDbDataSet5 = new clothing_shopee_mgmt.shopDbDataSet5();
            this.itemCount = new System.Windows.Forms.NumericUpDown();
            this.printBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.discountLbl = new System.Windows.Forms.Label();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.suplLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.billForm = new System.Windows.Forms.GroupBox();
            this.custIdTxt = new System.Windows.Forms.TextBox();
            this.custIdLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.suplCb = new System.Windows.Forms.ComboBox();
            this.shopDbDataSet4 = new clothing_shopee_mgmt.shopDbDataSet4();
            this.inventoryDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet4TableAdapters.inventoryDbTableAdapter();
            this.tempBillDbTableAdapter = new clothing_shopee_mgmt.shopDbDataSet5TableAdapters.tempBillDbTableAdapter();
            this.printBill = new System.Drawing.Printing.PrintDocument();
            this.printBillDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.billData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBillDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).BeginInit();
            this.billForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.backBtn.Location = new System.Drawing.Point(1220, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 50);
            this.backBtn.TabIndex = 51;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(302, 115);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(256, 34);
            this.nameTxt.TabIndex = 53;
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.nameLbl.Location = new System.Drawing.Point(68, 123);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(121, 23);
            this.nameLbl.TabIndex = 52;
            this.nameLbl.Text = "Product Name";
            // 
            // billData
            // 
            this.billData.AutoGenerateColumns = false;
            this.billData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sRNODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.cartSum});
            this.billData.DataSource = this.tempBillDbBindingSource;
            this.billData.Location = new System.Drawing.Point(692, 46);
            this.billData.Name = "billData";
            this.billData.ReadOnly = true;
            this.billData.RowHeadersWidth = 51;
            this.billData.RowTemplate.Height = 24;
            this.billData.Size = new System.Drawing.Size(535, 464);
            this.billData.TabIndex = 54;
            // 
            // sRNODataGridViewTextBoxColumn
            // 
            this.sRNODataGridViewTextBoxColumn.DataPropertyName = "SR_NO";
            this.sRNODataGridViewTextBoxColumn.HeaderText = "SR_NO";
            this.sRNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sRNODataGridViewTextBoxColumn.Name = "sRNODataGridViewTextBoxColumn";
            this.sRNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartSum
            // 
            this.cartSum.HeaderText = "Total";
            this.cartSum.MinimumWidth = 6;
            this.cartSum.Name = "cartSum";
            this.cartSum.ReadOnly = true;
            // 
            // tempBillDbBindingSource
            // 
            this.tempBillDbBindingSource.DataMember = "tempBillDb";
            this.tempBillDbBindingSource.DataSource = this.shopDbDataSet5;
            // 
            // shopDbDataSet5
            // 
            this.shopDbDataSet5.DataSetName = "shopDbDataSet5";
            this.shopDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemCount
            // 
            this.itemCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCount.Location = new System.Drawing.Point(302, 324);
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(255, 34);
            this.itemCount.TabIndex = 55;
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.printBtn.Location = new System.Drawing.Point(1133, 554);
            this.printBtn.Name = "printBtn";
            this.printBtn.Padding = new System.Windows.Forms.Padding(2);
            this.printBtn.Size = new System.Drawing.Size(94, 45);
            this.printBtn.TabIndex = 57;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.addBtn.Location = new System.Drawing.Point(462, 552);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(2);
            this.addBtn.Size = new System.Drawing.Size(94, 45);
            this.addBtn.TabIndex = 58;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.clearBtn.Location = new System.Drawing.Point(71, 552);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 45);
            this.clearBtn.TabIndex = 59;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(68, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Quantity";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.priceLbl.Location = new System.Drawing.Point(68, 407);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(47, 23);
            this.priceLbl.TabIndex = 62;
            this.priceLbl.Text = "Price";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(303, 399);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(255, 34);
            this.priceTxt.TabIndex = 63;
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(302, 476);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(255, 34);
            this.discountTxt.TabIndex = 65;
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.discountLbl.Location = new System.Drawing.Point(68, 484);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(77, 23);
            this.discountLbl.TabIndex = 64;
            this.discountLbl.Text = "Discount";
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.clearAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.clearAllBtn.Location = new System.Drawing.Point(692, 552);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(94, 45);
            this.clearAllBtn.TabIndex = 66;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.UseVisualStyleBackColor = false;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // suplLbl
            // 
            this.suplLbl.AutoSize = true;
            this.suplLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.suplLbl.Location = new System.Drawing.Point(67, 267);
            this.suplLbl.Name = "suplLbl";
            this.suplLbl.Size = new System.Drawing.Size(55, 23);
            this.suplLbl.TabIndex = 67;
            this.suplLbl.Text = "Brand";
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(302, 189);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(256, 34);
            this.idTxt.TabIndex = 70;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.idLbl.Location = new System.Drawing.Point(68, 197);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(92, 23);
            this.idLbl.TabIndex = 69;
            this.idLbl.Text = "Product ID";
            // 
            // billForm
            // 
            this.billForm.Controls.Add(this.custIdTxt);
            this.billForm.Controls.Add(this.custIdLbl);
            this.billForm.Controls.Add(this.cancelBtn);
            this.billForm.Controls.Add(this.suplCb);
            this.billForm.Controls.Add(this.idTxt);
            this.billForm.Controls.Add(this.idLbl);
            this.billForm.Controls.Add(this.suplLbl);
            this.billForm.Controls.Add(this.clearAllBtn);
            this.billForm.Controls.Add(this.discountTxt);
            this.billForm.Controls.Add(this.discountLbl);
            this.billForm.Controls.Add(this.priceTxt);
            this.billForm.Controls.Add(this.priceLbl);
            this.billForm.Controls.Add(this.label1);
            this.billForm.Controls.Add(this.clearBtn);
            this.billForm.Controls.Add(this.addBtn);
            this.billForm.Controls.Add(this.printBtn);
            this.billForm.Controls.Add(this.itemCount);
            this.billForm.Controls.Add(this.billData);
            this.billForm.Controls.Add(this.nameTxt);
            this.billForm.Controls.Add(this.nameLbl);
            this.billForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.billForm.Location = new System.Drawing.Point(12, 68);
            this.billForm.Name = "billForm";
            this.billForm.Size = new System.Drawing.Size(1308, 658);
            this.billForm.TabIndex = 71;
            this.billForm.TabStop = false;
            this.billForm.Text = "Genrate Bill";
            // 
            // custIdTxt
            // 
            this.custIdTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIdTxt.Location = new System.Drawing.Point(303, 46);
            this.custIdTxt.Name = "custIdTxt";
            this.custIdTxt.Size = new System.Drawing.Size(256, 34);
            this.custIdTxt.TabIndex = 74;
            // 
            // custIdLbl
            // 
            this.custIdLbl.AutoSize = true;
            this.custIdLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.custIdLbl.Location = new System.Drawing.Point(69, 54);
            this.custIdLbl.Name = "custIdLbl";
            this.custIdLbl.Size = new System.Drawing.Size(106, 23);
            this.custIdLbl.TabIndex = 73;
            this.custIdLbl.Text = "Customer ID";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.cancelBtn.Location = new System.Drawing.Point(302, 552);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 45);
            this.cancelBtn.TabIndex = 72;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // suplCb
            // 
            this.suplCb.FormattingEnabled = true;
            this.suplCb.Location = new System.Drawing.Point(302, 262);
            this.suplCb.Name = "suplCb";
            this.suplCb.Size = new System.Drawing.Size(255, 36);
            this.suplCb.TabIndex = 71;
            this.suplCb.SelectedIndexChanged += new System.EventHandler(this.suplCb_SelectedIndexChanged);
            // 
            // shopDbDataSet4
            // 
            this.shopDbDataSet4.DataSetName = "shopDbDataSet4";
            this.shopDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDbBindingSource
            // 
            this.inventoryDbBindingSource.DataMember = "inventoryDb";
            this.inventoryDbBindingSource.DataSource = this.shopDbDataSet4;
            // 
            // inventoryDbTableAdapter
            // 
            this.inventoryDbTableAdapter.ClearBeforeFill = true;
            // 
            // tempBillDbTableAdapter
            // 
            this.tempBillDbTableAdapter.ClearBeforeFill = true;
            // 
            // printBill
            // 
            this.printBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBill_PrintPage);
            // 
            // printBillDialog
            // 
            this.printBillDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printBillDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printBillDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printBillDialog.Enabled = true;
            this.printBillDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printBillDialog.Icon")));
            this.printBillDialog.Name = "printBillDialog";
            this.printBillDialog.Visible = false;
            // 
            // addBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1335, 738);
            this.Controls.Add(this.billForm);
            this.Controls.Add(this.backBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addBill";
            this.Text = "Add Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.addBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBillDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).EndInit();
            this.billForm.ResumeLayout(false);
            this.billForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.DataGridView billData;
        private System.Windows.Forms.NumericUpDown itemCount;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Label suplLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.GroupBox billForm;
        private System.Windows.Forms.ComboBox suplCb;
        private shopDbDataSet4 shopDbDataSet4;
        private System.Windows.Forms.BindingSource inventoryDbBindingSource;
        private shopDbDataSet4TableAdapters.inventoryDbTableAdapter inventoryDbTableAdapter;
        private shopDbDataSet5 shopDbDataSet5;
        private System.Windows.Forms.BindingSource tempBillDbBindingSource;
        private shopDbDataSet5TableAdapters.tempBillDbTableAdapter tempBillDbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartSum;
        private System.Drawing.Printing.PrintDocument printBill;
        private System.Windows.Forms.PrintPreviewDialog printBillDialog;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox custIdTxt;
        private System.Windows.Forms.Label custIdLbl;
    }
}