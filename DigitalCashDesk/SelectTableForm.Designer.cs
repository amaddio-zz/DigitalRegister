namespace DigitalCashDesk
{
    partial class SelectTableForm
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
            this.fLP_tables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fLP_tables
            // 
            this.fLP_tables.Location = new System.Drawing.Point(12, 12);
            this.fLP_tables.Name = "fLP_tables";
            this.fLP_tables.Size = new System.Drawing.Size(260, 238);
            this.fLP_tables.TabIndex = 0;
            // 
            // SelectTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fLP_tables);
            this.Name = "SelectTableForm";
            this.ShowIcon = false;
            this.Text = "SelectTableForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_tables;
    }
}