namespace DigitalCashDesk
{
    partial class NewOrder
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.lbl_SumInfo = new System.Windows.Forms.Label();
            this.lbl_OrderSum = new System.Windows.Forms.Label();
            this.productTypeTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter();
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.productTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Abort
            // 
            this.btn_Abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abort.Location = new System.Drawing.Point(715, 684);
            this.btn_Abort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(107, 32);
            this.btn_Abort.TabIndex = 39;
            this.btn_Abort.Text = "Abbrechen";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(327, 684);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(107, 32);
            this.btn_Print.TabIndex = 40;
            this.btn_Print.Text = "Drucken";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Visible = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // lbl_SumInfo
            // 
            this.lbl_SumInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SumInfo.AutoSize = true;
            this.lbl_SumInfo.Location = new System.Drawing.Point(566, 691);
            this.lbl_SumInfo.Name = "lbl_SumInfo";
            this.lbl_SumInfo.Size = new System.Drawing.Size(73, 18);
            this.lbl_SumInfo.TabIndex = 41;
            this.lbl_SumInfo.Text = "Summe:";
            // 
            // lbl_OrderSum
            // 
            this.lbl_OrderSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OrderSum.AutoSize = true;
            this.lbl_OrderSum.Location = new System.Drawing.Point(645, 691);
            this.lbl_OrderSum.Name = "lbl_OrderSum";
            this.lbl_OrderSum.Size = new System.Drawing.Size(18, 18);
            this.lbl_OrderSum.TabIndex = 42;
            this.lbl_OrderSum.Text = "0";
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // digitalCashDeskDBDataSet
            // 
            this.digitalCashDeskDBDataSet.DataSetName = "DigitalCashDeskDBDataSet";
            this.digitalCashDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(829, 684);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 32);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // NewOrder
            // 
            this.AcceptButton = this.btn_Print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abort;
            this.ClientSize = new System.Drawing.Size(945, 729);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_OrderSum);
            this.Controls.Add(this.lbl_SumInfo);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Abort);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewOrder";
            this.ShowIcon = false;
            this.Text = "Neue Bestellung";
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label lbl_SumInfo;
        private System.Windows.Forms.Label lbl_OrderSum;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btn_save;
    }
}

