namespace DigitalCashDesk
{
    partial class _OrderViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.dGV_Products = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.invoiceNumberTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.InvoiceNumberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Abort
            // 
            this.btn_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Abort.Location = new System.Drawing.Point(437, 443);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(89, 35);
            this.btn_Abort.TabIndex = 1;
            this.btn_Abort.Text = "&Abbruch";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Accept.Location = new System.Drawing.Point(532, 443);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(88, 35);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "&OK";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.Location = new System.Drawing.Point(300, 443);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(131, 35);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "&Beleg drucken";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // dGV_Products
            // 
            this.dGV_Products.AllowUserToAddRows = false;
            this.dGV_Products.AllowUserToDeleteRows = false;
            this.dGV_Products.AllowUserToResizeColumns = false;
            this.dGV_Products.AllowUserToResizeRows = false;
            this.dGV_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Anzahl,
            this.Preis});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Products.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV_Products.Location = new System.Drawing.Point(14, 12);
            this.dGV_Products.Name = "dGV_Products";
            this.dGV_Products.ReadOnly = true;
            this.dGV_Products.RowHeadersVisible = false;
            this.dGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Products.ShowEditingIcon = false;
            this.dGV_Products.Size = new System.Drawing.Size(606, 425);
            this.dGV_Products.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            // 
            // digitalCashDeskDBDataSet
            // 
            this.digitalCashDeskDBDataSet.DataSetName = "DigitalCashDeskDBDataSet";
            this.digitalCashDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceNumberTableAdapter
            // 
            this.invoiceNumberTableAdapter.ClearBeforeFill = true;
            // 
            // OrderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 490);
            this.Controls.Add(this.dGV_Products);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_Abort);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIcon = false;
            this.Text = "Offene Bestellung";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridView dGV_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.InvoiceNumberTableAdapter invoiceNumberTableAdapter;
    }
}