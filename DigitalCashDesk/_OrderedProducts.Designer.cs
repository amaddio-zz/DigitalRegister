//namespace DigitalCashDesk
//{
//    partial class OrderedProducts
//    {
//        /// <summary>
//        /// Erforderliche Designervariable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Verwendete Ressourcen bereinigen.
//        /// </summary>
//        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Vom Windows Form-Designer generierter Code

//        /// <summary>
//        /// Erforderliche Methode für die Designerunterstützung.
//        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.dGV_OrderedProducts = new System.Windows.Forms.DataGridView();
//            this.Produktname = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.lbl_VonInfo = new System.Windows.Forms.Label();
//            this.lbl_TotalInfo = new System.Windows.Forms.Label();
//            this.lbl_Total = new System.Windows.Forms.Label();
//            this.dTP_Von = new System.Windows.Forms.DateTimePicker();
//            this.lbl_BisInfo = new System.Windows.Forms.Label();
//            this.dTP_Bis = new System.Windows.Forms.DateTimePicker();
//            this.lbl_GetraenkInfo = new System.Windows.Forms.Label();
//            this.lbl_SpeisenInfo = new System.Windows.Forms.Label();
//            this.lbl_GetraenkeTotal = new System.Windows.Forms.Label();
//            this.lbl_SpeisenTotal = new System.Windows.Forms.Label();
//            this.boughtProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
//            this.productTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter();
//            //this.boughtProductsTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.BoughtProductsTableAdapter();
//            this.btn_Update = new System.Windows.Forms.Button();
//            this.btn_Close = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dGV_OrderedProducts)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.boughtProductsBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dGV_OrderedProducts
//            // 
//            this.dGV_OrderedProducts.AllowUserToAddRows = false;
//            this.dGV_OrderedProducts.AllowUserToDeleteRows = false;
//            this.dGV_OrderedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//                        | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.dGV_OrderedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dGV_OrderedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dGV_OrderedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.Produktname,
//            this.Preis,
//            this.Datum});
//            this.dGV_OrderedProducts.Location = new System.Drawing.Point(16, 15);
//            this.dGV_OrderedProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.dGV_OrderedProducts.Name = "dGV_OrderedProducts";
//            this.dGV_OrderedProducts.ReadOnly = true;
//            this.dGV_OrderedProducts.RowHeadersVisible = false;
//            this.dGV_OrderedProducts.Size = new System.Drawing.Size(598, 233);
//            this.dGV_OrderedProducts.TabIndex = 0;
//            // 
//            // Produktname
//            // 
//            this.Produktname.HeaderText = "Produktname";
//            this.Produktname.Name = "Produktname";
//            this.Produktname.ReadOnly = true;
//            // 
//            // Preis
//            // 
//            this.Preis.HeaderText = "Preis";
//            this.Preis.Name = "Preis";
//            this.Preis.ReadOnly = true;
//            // 
//            // Datum
//            // 
//            this.Datum.HeaderText = "Datum";
//            this.Datum.Name = "Datum";
//            this.Datum.ReadOnly = true;
//            // 
//            // lbl_VonInfo
//            // 
//            this.lbl_VonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.lbl_VonInfo.AutoSize = true;
//            this.lbl_VonInfo.Location = new System.Drawing.Point(16, 278);
//            this.lbl_VonInfo.Name = "lbl_VonInfo";
//            this.lbl_VonInfo.Size = new System.Drawing.Size(39, 16);
//            this.lbl_VonInfo.TabIndex = 1;
//            this.lbl_VonInfo.Text = "Von:";
//            // 
//            // lbl_TotalInfo
//            // 
//            this.lbl_TotalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_TotalInfo.AutoSize = true;
//            this.lbl_TotalInfo.Location = new System.Drawing.Point(384, 345);
//            this.lbl_TotalInfo.Name = "lbl_TotalInfo";
//            this.lbl_TotalInfo.Size = new System.Drawing.Size(116, 16);
//            this.lbl_TotalInfo.TabIndex = 2;
//            this.lbl_TotalInfo.Text = "Umsatz Gesamt:";
//            // 
//            // lbl_Total
//            // 
//            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_Total.AutoSize = true;
//            this.lbl_Total.Location = new System.Drawing.Point(538, 345);
//            this.lbl_Total.Name = "lbl_Total";
//            this.lbl_Total.Size = new System.Drawing.Size(16, 16);
//            this.lbl_Total.TabIndex = 4;
//            this.lbl_Total.Text = "0";
//            // 
//            // dTP_Von
//            // 
//            this.dTP_Von.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.dTP_Von.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
//            this.dTP_Von.Location = new System.Drawing.Point(75, 271);
//            this.dTP_Von.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.dTP_Von.Name = "dTP_Von";
//            this.dTP_Von.Size = new System.Drawing.Size(263, 23);
//            this.dTP_Von.TabIndex = 5;
//            // 
//            // lbl_BisInfo
//            // 
//            this.lbl_BisInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.lbl_BisInfo.AutoSize = true;
//            this.lbl_BisInfo.Location = new System.Drawing.Point(16, 311);
//            this.lbl_BisInfo.Name = "lbl_BisInfo";
//            this.lbl_BisInfo.Size = new System.Drawing.Size(32, 16);
//            this.lbl_BisInfo.TabIndex = 6;
//            this.lbl_BisInfo.Text = "Bis:";
//            // 
//            // dTP_Bis
//            // 
//            this.dTP_Bis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.dTP_Bis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
//            this.dTP_Bis.Location = new System.Drawing.Point(75, 304);
//            this.dTP_Bis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.dTP_Bis.Name = "dTP_Bis";
//            this.dTP_Bis.Size = new System.Drawing.Size(263, 23);
//            this.dTP_Bis.TabIndex = 7;
//            // 
//            // lbl_GetraenkInfo
//            // 
//            this.lbl_GetraenkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_GetraenkInfo.AutoSize = true;
//            this.lbl_GetraenkInfo.Location = new System.Drawing.Point(384, 311);
//            this.lbl_GetraenkInfo.Name = "lbl_GetraenkInfo";
//            this.lbl_GetraenkInfo.Size = new System.Drawing.Size(126, 16);
//            this.lbl_GetraenkInfo.TabIndex = 8;
//            this.lbl_GetraenkInfo.Text = "Umsatz Getränke:";
//            // 
//            // lbl_SpeisenInfo
//            // 
//            this.lbl_SpeisenInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_SpeisenInfo.AutoSize = true;
//            this.lbl_SpeisenInfo.Location = new System.Drawing.Point(384, 278);
//            this.lbl_SpeisenInfo.Name = "lbl_SpeisenInfo";
//            this.lbl_SpeisenInfo.Size = new System.Drawing.Size(118, 16);
//            this.lbl_SpeisenInfo.TabIndex = 9;
//            this.lbl_SpeisenInfo.Text = "Umsatz Speisen:";
//            // 
//            // lbl_GetraenkeTotal
//            // 
//            this.lbl_GetraenkeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_GetraenkeTotal.AutoSize = true;
//            this.lbl_GetraenkeTotal.Location = new System.Drawing.Point(538, 311);
//            this.lbl_GetraenkeTotal.Name = "lbl_GetraenkeTotal";
//            this.lbl_GetraenkeTotal.Size = new System.Drawing.Size(16, 16);
//            this.lbl_GetraenkeTotal.TabIndex = 10;
//            this.lbl_GetraenkeTotal.Text = "0";
//            // 
//            // lbl_SpeisenTotal
//            // 
//            this.lbl_SpeisenTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.lbl_SpeisenTotal.AutoSize = true;
//            this.lbl_SpeisenTotal.Location = new System.Drawing.Point(538, 278);
//            this.lbl_SpeisenTotal.Name = "lbl_SpeisenTotal";
//            this.lbl_SpeisenTotal.Size = new System.Drawing.Size(16, 16);
//            this.lbl_SpeisenTotal.TabIndex = 11;
//            this.lbl_SpeisenTotal.Text = "0";
//            // 
//            // boughtProductsBindingSource
//            // 
//            this.boughtProductsBindingSource.DataMember = "BoughtProducts";
//            this.boughtProductsBindingSource.DataSource = this.digitalCashDeskDBDataSet;
//            // 
//            // digitalCashDeskDBDataSet
//            // 
//            this.digitalCashDeskDBDataSet.DataSetName = "DigitalCashDeskDBDataSet";
//            this.digitalCashDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//            // 
//            // productTableAdapter
//            // 
//            this.productTableAdapter.ClearBeforeFill = true;
//            // 
//            // boughtProductsTableAdapter
//            // 
//            this.boughtProductsTableAdapter.ClearBeforeFill = true;
//            // 
//            // btn_Update
//            // 
//            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.btn_Update.Location = new System.Drawing.Point(75, 338);
//            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.btn_Update.Name = "btn_Update";
//            this.btn_Update.Size = new System.Drawing.Size(264, 28);
//            this.btn_Update.TabIndex = 12;
//            this.btn_Update.Text = "&Aktualisieren";
//            this.btn_Update.UseVisualStyleBackColor = true;
//            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
//            // 
//            // btn_Close
//            // 
//            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.btn_Close.Location = new System.Drawing.Point(75, 374);
//            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.btn_Close.Name = "btn_Close";
//            this.btn_Close.Size = new System.Drawing.Size(264, 28);
//            this.btn_Close.TabIndex = 13;
//            this.btn_Close.Text = "&Schliessen";
//            this.btn_Close.UseVisualStyleBackColor = true;
//            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
//            // 
//            // OrderedProducts
//            // 
//            this.AcceptButton = this.btn_Update;
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.CancelButton = this.btn_Close;
//            this.ClientSize = new System.Drawing.Size(630, 430);
//            this.Controls.Add(this.btn_Close);
//            this.Controls.Add(this.btn_Update);
//            this.Controls.Add(this.lbl_SpeisenTotal);
//            this.Controls.Add(this.lbl_GetraenkeTotal);
//            this.Controls.Add(this.lbl_SpeisenInfo);
//            this.Controls.Add(this.lbl_GetraenkInfo);
//            this.Controls.Add(this.dTP_Bis);
//            this.Controls.Add(this.lbl_BisInfo);
//            this.Controls.Add(this.dTP_Von);
//            this.Controls.Add(this.lbl_Total);
//            this.Controls.Add(this.lbl_TotalInfo);
//            this.Controls.Add(this.lbl_VonInfo);
//            this.Controls.Add(this.dGV_OrderedProducts);
//            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Name = "OrderedProducts";
//            this.ShowIcon = false;
//            this.Text = "OrderedProducts";
//            ((System.ComponentModel.ISupportInitialize)(this.dGV_OrderedProducts)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.boughtProductsBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.DataGridView dGV_OrderedProducts;
//        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
//        private System.Windows.Forms.Label lbl_VonInfo;
//        private System.Windows.Forms.Label lbl_TotalInfo;
//        private System.Windows.Forms.Label lbl_Total;
//        private System.Windows.Forms.DateTimePicker dTP_Von;
//        private System.Windows.Forms.Label lbl_BisInfo;
//        private System.Windows.Forms.DateTimePicker dTP_Bis;
//        private System.Windows.Forms.Label lbl_GetraenkInfo;
//        private System.Windows.Forms.Label lbl_SpeisenInfo;
//        private System.Windows.Forms.Label lbl_GetraenkeTotal;
//        private System.Windows.Forms.Label lbl_SpeisenTotal;
//        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
//        private System.Windows.Forms.BindingSource boughtProductsBindingSource;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Produktname;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
//        //private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.BoughtProductsTableAdapter boughtProductsTableAdapter;
//        private System.Windows.Forms.Button btn_Update;
//        private System.Windows.Forms.Button btn_Close;
//    }
//}