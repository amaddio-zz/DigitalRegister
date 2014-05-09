namespace DigitalCashDesk
{
    partial class PaymentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.productTypeTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter();
            this.tableTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter();
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.productTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter();
            this.dGV_Products = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.split = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_move = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Abort
            // 
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abort.Location = new System.Drawing.Point(670, 13);
            this.btn_Abort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(150, 32);
            this.btn_Abort.TabIndex = 39;
            this.btn_Abort.Text = "Abbrechen";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(670, 53);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(150, 32);
            this.btn_Print.TabIndex = 40;
            this.btn_Print.Text = "Drucken";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
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
            // dGV_Products
            // 
            this.dGV_Products.AllowUserToAddRows = false;
            this.dGV_Products.AllowUserToDeleteRows = false;
            this.dGV_Products.AllowUserToResizeColumns = false;
            this.dGV_Products.AllowUserToResizeRows = false;
            this.dGV_Products.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Preis,
            this.split});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Products.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV_Products.Location = new System.Drawing.Point(12, 12);
            this.dGV_Products.MultiSelect = false;
            this.dGV_Products.Name = "dGV_Products";
            this.dGV_Products.RowHeadersVisible = false;
            this.dGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_Products.ShowEditingIcon = false;
            this.dGV_Products.Size = new System.Drawing.Size(651, 705);
            this.dGV_Products.TabIndex = 44;
            this.dGV_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Products_CellClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Preis
            // 
            this.Preis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.ReadOnly = true;
            this.Preis.Width = 68;
            // 
            // split
            // 
            this.split.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.split.HeaderText = "Split";
            this.split.Name = "split";
            this.split.Width = 64;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(669, 171);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(150, 32);
            this.btn_move.TabIndex = 45;
            this.btn_move.Text = "Tisch umziehen";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.btn_Print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abort;
            this.ClientSize = new System.Drawing.Size(945, 729);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.dGV_Products);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Abort);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.Text = "Bezahlen";
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_Print;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dGV_Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn split;
        private System.Windows.Forms.Button btn_move;
    }
}