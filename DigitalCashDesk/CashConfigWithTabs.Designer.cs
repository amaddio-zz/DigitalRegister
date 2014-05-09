namespace DigitalCashDesk
{
    partial class CashConfigWithTabs
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_SaveExit = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.productTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.productTypeTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter();
            this.tableTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter();
            this.productTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter();
            this.tP_Products = new System.Windows.Forms.TabPage();
            this.dGV_Products = new System.Windows.Forms.DataGridView();
            this.productTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tP_ProductTypes = new System.Windows.Forms.TabPage();
            this.dGV_ProductTypes = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tP_tables = new System.Windows.Forms.TabPage();
            this.dGV_Tables = new System.Windows.Forms.DataGridView();
            this.amountSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).BeginInit();
            this.tP_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).BeginInit();
            this.tP_ProductTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductTypes)).BeginInit();
            this.tP_tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tables)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveExit
            // 
            this.btn_SaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveExit.Location = new System.Drawing.Point(17, 433);
            this.btn_SaveExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveExit.Name = "btn_SaveExit";
            this.btn_SaveExit.Size = new System.Drawing.Size(189, 28);
            this.btn_SaveExit.TabIndex = 5;
            this.btn_SaveExit.Text = "Speichern und Schließen";
            this.btn_SaveExit.UseVisualStyleBackColor = true;
            this.btn_SaveExit.Click += new System.EventHandler(this.btn_SaveExit_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Location = new System.Drawing.Point(309, 433);
            this.btn_Abort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(110, 28);
            this.btn_Abort.TabIndex = 6;
            this.btn_Abort.Text = "A&bbrechen";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.digitalCashDeskDBDataSet;
            // 
            // digitalCashDeskDBDataSet
            // 
            this.digitalCashDeskDBDataSet.DataSetName = "DigitalCashDeskDBDataSet";
            this.digitalCashDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.digitalCashDeskDBDataSet;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.digitalCashDeskDBDataSet;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Location = new System.Drawing.Point(213, 433);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 28);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "&Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // productTypeBindingSource1
            // 
            this.productTypeBindingSource1.DataMember = "ProductType";
            this.productTypeBindingSource1.DataSource = this.digitalCashDeskDBDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(425, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Löschen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tP_Products
            // 
            this.tP_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tP_Products.Controls.Add(this.dGV_Products);
            this.tP_Products.Location = new System.Drawing.Point(4, 25);
            this.tP_Products.Name = "tP_Products";
            this.tP_Products.Size = new System.Drawing.Size(490, 385);
            this.tP_Products.TabIndex = 2;
            this.tP_Products.Text = "Produkte";
            this.tP_Products.UseVisualStyleBackColor = true;
            // 
            // dGV_Products
            // 
            this.dGV_Products.AutoGenerateColumns = false;
            this.dGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.productTypeIdDataGridViewTextBoxColumn});
            this.dGV_Products.DataSource = this.productBindingSource;
            this.dGV_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Products.Location = new System.Drawing.Point(0, 0);
            this.dGV_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGV_Products.Name = "dGV_Products";
            this.dGV_Products.Size = new System.Drawing.Size(490, 385);
            this.dGV_Products.TabIndex = 7;
            this.dGV_Products.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dGV_Products_CellValidating);
            this.dGV_Products.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGV_Products_DataError);
            this.dGV_Products.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Products_RowHeaderMouseClick);
            // 
            // productTypeIdDataGridViewTextBoxColumn
            // 
            this.productTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeId";
            this.productTypeIdDataGridViewTextBoxColumn.DataSource = this.productTypeBindingSource;
            this.productTypeIdDataGridViewTextBoxColumn.DisplayMember = "ProductTypeName";
            this.productTypeIdDataGridViewTextBoxColumn.HeaderText = "Warengruppe";
            this.productTypeIdDataGridViewTextBoxColumn.Name = "productTypeIdDataGridViewTextBoxColumn";
            this.productTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productTypeIdDataGridViewTextBoxColumn.ValueMember = "ProductId";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tP_ProductTypes
            // 
            this.tP_ProductTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tP_ProductTypes.Controls.Add(this.dGV_ProductTypes);
            this.tP_ProductTypes.Location = new System.Drawing.Point(4, 25);
            this.tP_ProductTypes.Name = "tP_ProductTypes";
            this.tP_ProductTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tP_ProductTypes.Size = new System.Drawing.Size(490, 385);
            this.tP_ProductTypes.TabIndex = 1;
            this.tP_ProductTypes.Text = "Warengruppen";
            this.tP_ProductTypes.UseVisualStyleBackColor = true;
            // 
            // dGV_ProductTypes
            // 
            this.dGV_ProductTypes.AutoGenerateColumns = false;
            this.dGV_ProductTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_ProductTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ProductTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeNameDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn});
            this.dGV_ProductTypes.DataSource = this.productTypeBindingSource1;
            this.dGV_ProductTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_ProductTypes.Location = new System.Drawing.Point(3, 3);
            this.dGV_ProductTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGV_ProductTypes.Name = "dGV_ProductTypes";
            this.dGV_ProductTypes.Size = new System.Drawing.Size(484, 379);
            this.dGV_ProductTypes.TabIndex = 12;
            this.dGV_ProductTypes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Products_RowHeaderMouseClick);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProduktId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTypeNameDataGridViewTextBoxColumn
            // 
            this.productTypeNameDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeName";
            this.productTypeNameDataGridViewTextBoxColumn.HeaderText = "WarengruppenName";
            this.productTypeNameDataGridViewTextBoxColumn.Name = "productTypeNameDataGridViewTextBoxColumn";
            // 
            // tP_tables
            // 
            this.tP_tables.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tP_tables.Controls.Add(this.dGV_Tables);
            this.tP_tables.Location = new System.Drawing.Point(4, 25);
            this.tP_tables.Name = "tP_tables";
            this.tP_tables.Padding = new System.Windows.Forms.Padding(3);
            this.tP_tables.Size = new System.Drawing.Size(490, 385);
            this.tP_tables.TabIndex = 0;
            this.tP_tables.Text = "Tische";
            this.tP_tables.UseVisualStyleBackColor = true;
            // 
            // dGV_Tables
            // 
            this.dGV_Tables.AutoGenerateColumns = false;
            this.dGV_Tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableIdDataGridViewTextBoxColumn,
            this.amountSeatsDataGridViewTextBoxColumn});
            this.dGV_Tables.DataSource = this.tableBindingSource;
            this.dGV_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Tables.Location = new System.Drawing.Point(3, 3);
            this.dGV_Tables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGV_Tables.Name = "dGV_Tables";
            this.dGV_Tables.Size = new System.Drawing.Size(484, 379);
            this.dGV_Tables.TabIndex = 9;
            this.dGV_Tables.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Products_RowHeaderMouseClick);
            // 
            // amountSeatsDataGridViewTextBoxColumn
            // 
            this.amountSeatsDataGridViewTextBoxColumn.DataPropertyName = "AmountSeats";
            this.amountSeatsDataGridViewTextBoxColumn.HeaderText = "AmountSeats";
            this.amountSeatsDataGridViewTextBoxColumn.Name = "amountSeatsDataGridViewTextBoxColumn";
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "TableId";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tP_tables);
            this.tabControl1.Controls.Add(this.tP_ProductTypes);
            this.tabControl1.Controls.Add(this.tP_Products);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 414);
            this.tabControl1.TabIndex = 14;
            // 
            // CashConfigWithTabs
            // 
            this.AcceptButton = this.btn_SaveExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abort;
            this.ClientSize = new System.Drawing.Size(528, 476);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_SaveExit);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CashConfigWithTabs";
            this.ShowIcon = false;
            this.Text = "CashConfig";
            this.Load += new System.EventHandler(this.CashConfig_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashConfig_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).EndInit();
            this.tP_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).EndInit();
            this.tP_ProductTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ProductTypes)).EndInit();
            this.tP_tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Tables)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveExit;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_Save;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tP_Products;
        private System.Windows.Forms.DataGridView dGV_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tP_ProductTypes;
        private System.Windows.Forms.DataGridView dGV_ProductTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tP_tables;
        private System.Windows.Forms.DataGridView dGV_Tables;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;

    }
}