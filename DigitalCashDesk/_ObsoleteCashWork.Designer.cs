namespace DigitalCashDesk
{
    partial class _ObsoleteCashWork
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
            this.btn_Print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter();
            this.lbl_Tables = new System.Windows.Forms.Label();
            this.tableTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_OrderSum = new System.Windows.Forms.Label();
            this.TLP_Products = new System.Windows.Forms.TableLayoutPanel();
            this.FLP_Tables = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Food = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP_Drinks = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.TLP_Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.Location = new System.Drawing.Point(770, 508);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(141, 38);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "&Drucken";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verfügbare Speisen:";
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
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Tables
            // 
            this.lbl_Tables.AutoSize = true;
            this.lbl_Tables.Location = new System.Drawing.Point(3, 0);
            this.lbl_Tables.Name = "lbl_Tables";
            this.lbl_Tables.Size = new System.Drawing.Size(49, 16);
            this.lbl_Tables.TabIndex = 6;
            this.lbl_Tables.Text = "Tisch:";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Summe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verfügbare Getränke:";
            // 
            // lbl_OrderSum
            // 
            this.lbl_OrderSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OrderSum.AutoSize = true;
            this.lbl_OrderSum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderSum.Location = new System.Drawing.Point(505, 519);
            this.lbl_OrderSum.Name = "lbl_OrderSum";
            this.lbl_OrderSum.Size = new System.Drawing.Size(19, 18);
            this.lbl_OrderSum.TabIndex = 10;
            this.lbl_OrderSum.Text = "0";
            // 
            // TLP_Products
            // 
            this.TLP_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_Products.ColumnCount = 1;
            this.TLP_Products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1035F));
            this.TLP_Products.Controls.Add(this.FLP_Tables, 0, 1);
            this.TLP_Products.Controls.Add(this.FLP_Food, 0, 5);
            this.TLP_Products.Controls.Add(this.lbl_Tables, 0, 0);
            this.TLP_Products.Controls.Add(this.label1, 0, 4);
            this.TLP_Products.Controls.Add(this.label3, 0, 2);
            this.TLP_Products.Controls.Add(this.FLP_Drinks, 0, 3);
            this.TLP_Products.Location = new System.Drawing.Point(14, 15);
            this.TLP_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TLP_Products.Name = "TLP_Products";
            this.TLP_Products.RowCount = 6;
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.TLP_Products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP_Products.Size = new System.Drawing.Size(897, 486);
            this.TLP_Products.TabIndex = 11;
            // 
            // FLP_Tables
            // 
            this.FLP_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Tables.Location = new System.Drawing.Point(3, 25);
            this.FLP_Tables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FLP_Tables.Name = "FLP_Tables";
            this.FLP_Tables.Size = new System.Drawing.Size(1029, 76);
            this.FLP_Tables.TabIndex = 12;
            // 
            // FLP_Food
            // 
            this.FLP_Food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Food.Location = new System.Drawing.Point(3, 362);
            this.FLP_Food.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FLP_Food.Name = "FLP_Food";
            this.FLP_Food.Size = new System.Drawing.Size(1029, 120);
            this.FLP_Food.TabIndex = 12;
            // 
            // FLP_Drinks
            // 
            this.FLP_Drinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_Drinks.Location = new System.Drawing.Point(3, 130);
            this.FLP_Drinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FLP_Drinks.Name = "FLP_Drinks";
            this.FLP_Drinks.Size = new System.Drawing.Size(1029, 203);
            this.FLP_Drinks.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(623, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TLP_Products);
            this.Controls.Add(this.lbl_OrderSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Print);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CashWork";
            this.ShowIcon = false;
            this.Text = "Bestellung";
            this.Load += new System.EventHandler(this.CashWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.TLP_Products.ResumeLayout(false);
            this.TLP_Products.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label1;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label lbl_Tables;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_OrderSum;
        private System.Windows.Forms.TableLayoutPanel TLP_Products;
        private System.Windows.Forms.FlowLayoutPanel FLP_Food;
        private System.Windows.Forms.FlowLayoutPanel FLP_Drinks;
        private System.Windows.Forms.FlowLayoutPanel FLP_Tables;
        private System.Windows.Forms.Button button1;
    }
}

