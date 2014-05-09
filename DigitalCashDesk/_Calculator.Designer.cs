namespace DigitalCashDesk
{
    partial class _Calculator
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
            this.lBx_Amount = new System.Windows.Forms.ListBox();
            this.btn_DeleteLastCharachter = new DigitalCashDesk.CalculatorButton();
            this.btn_ClearEntry = new DigitalCashDesk.CalculatorButton();
            this.btn_FullClear = new DigitalCashDesk.CalculatorButton();
            this.btn_Plus = new DigitalCashDesk.CalculatorButton();
            this.btn_Divide = new DigitalCashDesk.CalculatorButton();
            this.btn_Multiplicate = new DigitalCashDesk.CalculatorButton();
            this.btn_Minus = new DigitalCashDesk.CalculatorButton();
            this.btn_Sum = new DigitalCashDesk.CalculatorButton();
            this.btn_Comma = new DigitalCashDesk.CalculatorButton();
            this.btn_9 = new DigitalCashDesk.CalculatorButton();
            this.btn_8 = new DigitalCashDesk.CalculatorButton();
            this.btn_7 = new DigitalCashDesk.CalculatorButton();
            this.btn_6 = new DigitalCashDesk.CalculatorButton();
            this.btn_5 = new DigitalCashDesk.CalculatorButton();
            this.btn_4 = new DigitalCashDesk.CalculatorButton();
            this.btn_3 = new DigitalCashDesk.CalculatorButton();
            this.btn_2 = new DigitalCashDesk.CalculatorButton();
            this.btn_0 = new DigitalCashDesk.CalculatorButton();
            this.btn_1 = new DigitalCashDesk.CalculatorButton();
            this.SuspendLayout();
            // 
            // lBx_Amount
            // 
            this.lBx_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lBx_Amount.FormattingEnabled = true;
            this.lBx_Amount.ItemHeight = 18;
            this.lBx_Amount.Location = new System.Drawing.Point(12, 12);
            this.lBx_Amount.Name = "lBx_Amount";
            this.lBx_Amount.Size = new System.Drawing.Size(144, 202);
            this.lBx_Amount.TabIndex = 19;
            // 
            // btn_DeleteLastCharachter
            // 
            this.btn_DeleteLastCharachter.CalculatorButtonValue = "Delete";
            this.btn_DeleteLastCharachter.ForeColor = System.Drawing.Color.Red;
            this.btn_DeleteLastCharachter.Location = new System.Drawing.Point(162, 12);
            this.btn_DeleteLastCharachter.Name = "btn_DeleteLastCharachter";
            this.btn_DeleteLastCharachter.Size = new System.Drawing.Size(102, 30);
            this.btn_DeleteLastCharachter.TabIndex = 39;
            this.btn_DeleteLastCharachter.Text = "&Rücktaste";
            this.btn_DeleteLastCharachter.UseVisualStyleBackColor = true;
            this.btn_DeleteLastCharachter.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_ClearEntry
            // 
            this.btn_ClearEntry.CalculatorButtonValue = "CE";
            this.btn_ClearEntry.ForeColor = System.Drawing.Color.Red;
            this.btn_ClearEntry.Location = new System.Drawing.Point(270, 12);
            this.btn_ClearEntry.Name = "btn_ClearEntry";
            this.btn_ClearEntry.Size = new System.Drawing.Size(61, 30);
            this.btn_ClearEntry.TabIndex = 38;
            this.btn_ClearEntry.Text = "&CE";
            this.btn_ClearEntry.UseVisualStyleBackColor = true;
            this.btn_ClearEntry.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_FullClear
            // 
            this.btn_FullClear.CalculatorButtonValue = "C";
            this.btn_FullClear.ForeColor = System.Drawing.Color.Red;
            this.btn_FullClear.Location = new System.Drawing.Point(337, 12);
            this.btn_FullClear.Name = "btn_FullClear";
            this.btn_FullClear.Size = new System.Drawing.Size(61, 30);
            this.btn_FullClear.TabIndex = 37;
            this.btn_FullClear.Text = "&C";
            this.btn_FullClear.UseVisualStyleBackColor = true;
            this.btn_FullClear.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_Plus
            // 
            this.btn_Plus.CalculatorButtonValue = "+";
            this.btn_Plus.ForeColor = System.Drawing.Color.Red;
            this.btn_Plus.Location = new System.Drawing.Point(337, 156);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(61, 30);
            this.btn_Plus.TabIndex = 36;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_Divide
            // 
            this.btn_Divide.CalculatorButtonValue = "/";
            this.btn_Divide.ForeColor = System.Drawing.Color.Red;
            this.btn_Divide.Location = new System.Drawing.Point(337, 48);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(61, 30);
            this.btn_Divide.TabIndex = 35;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_Multiplicate
            // 
            this.btn_Multiplicate.CalculatorButtonValue = "*";
            this.btn_Multiplicate.ForeColor = System.Drawing.Color.Red;
            this.btn_Multiplicate.Location = new System.Drawing.Point(337, 84);
            this.btn_Multiplicate.Name = "btn_Multiplicate";
            this.btn_Multiplicate.Size = new System.Drawing.Size(61, 30);
            this.btn_Multiplicate.TabIndex = 34;
            this.btn_Multiplicate.Text = "*";
            this.btn_Multiplicate.UseVisualStyleBackColor = true;
            this.btn_Multiplicate.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_Minus
            // 
            this.btn_Minus.CalculatorButtonValue = "-";
            this.btn_Minus.ForeColor = System.Drawing.Color.Red;
            this.btn_Minus.Location = new System.Drawing.Point(337, 120);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(61, 30);
            this.btn_Minus.TabIndex = 33;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.OperaterButtonClicked);
            // 
            // btn_Sum
            // 
            this.btn_Sum.CalculatorButtonValue = "=";
            this.btn_Sum.ForeColor = System.Drawing.Color.Red;
            this.btn_Sum.Location = new System.Drawing.Point(162, 193);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(236, 30);
            this.btn_Sum.TabIndex = 32;
            this.btn_Sum.Text = "=";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // btn_Comma
            // 
            this.btn_Comma.CalculatorButtonValue = ",";
            this.btn_Comma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Comma.Location = new System.Drawing.Point(221, 156);
            this.btn_Comma.Name = "btn_Comma";
            this.btn_Comma.Size = new System.Drawing.Size(53, 30);
            this.btn_Comma.TabIndex = 31;
            this.btn_Comma.Text = ",";
            this.btn_Comma.UseVisualStyleBackColor = true;
            this.btn_Comma.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_9
            // 
            this.btn_9.CalculatorButtonValue = "9";
            this.btn_9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_9.Location = new System.Drawing.Point(280, 48);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(53, 30);
            this.btn_9.TabIndex = 30;
            this.btn_9.Text = "&9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_8
            // 
            this.btn_8.CalculatorButtonValue = "8";
            this.btn_8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_8.Location = new System.Drawing.Point(221, 48);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(53, 30);
            this.btn_8.TabIndex = 29;
            this.btn_8.Text = "&8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_7
            // 
            this.btn_7.CalculatorButtonValue = "7";
            this.btn_7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_7.Location = new System.Drawing.Point(162, 48);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(53, 30);
            this.btn_7.TabIndex = 28;
            this.btn_7.Text = "&7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_6
            // 
            this.btn_6.CalculatorButtonValue = "6";
            this.btn_6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_6.Location = new System.Drawing.Point(280, 84);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(53, 30);
            this.btn_6.TabIndex = 27;
            this.btn_6.Text = "&6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_5
            // 
            this.btn_5.CalculatorButtonValue = "5";
            this.btn_5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_5.Location = new System.Drawing.Point(221, 84);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(53, 30);
            this.btn_5.TabIndex = 26;
            this.btn_5.Text = "&5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_4
            // 
            this.btn_4.CalculatorButtonValue = "4";
            this.btn_4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_4.Location = new System.Drawing.Point(162, 84);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(53, 30);
            this.btn_4.TabIndex = 25;
            this.btn_4.Text = "&4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_3
            // 
            this.btn_3.CalculatorButtonValue = "3";
            this.btn_3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_3.Location = new System.Drawing.Point(280, 120);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(53, 30);
            this.btn_3.TabIndex = 24;
            this.btn_3.Text = "&3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_2
            // 
            this.btn_2.CalculatorButtonValue = "2";
            this.btn_2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_2.Location = new System.Drawing.Point(221, 120);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(53, 30);
            this.btn_2.TabIndex = 23;
            this.btn_2.Text = "&2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_0
            // 
            this.btn_0.CalculatorButtonValue = "0";
            this.btn_0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_0.Location = new System.Drawing.Point(162, 156);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(53, 30);
            this.btn_0.TabIndex = 22;
            this.btn_0.Text = "&0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // btn_1
            // 
            this.btn_1.CalculatorButtonValue = "1";
            this.btn_1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_1.Location = new System.Drawing.Point(162, 120);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(53, 30);
            this.btn_1.TabIndex = 21;
            this.btn_1.Text = "&1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 235);
            this.Controls.Add(this.btn_DeleteLastCharachter);
            this.Controls.Add(this.btn_ClearEntry);
            this.Controls.Add(this.btn_FullClear);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Multiplicate);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Comma);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lBx_Amount);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBx_Amount;
        private CalculatorButton btn_1;
        private CalculatorButton btn_0;
        private CalculatorButton btn_2;
        private CalculatorButton btn_3;
        private CalculatorButton btn_4;
        private CalculatorButton btn_5;
        private CalculatorButton btn_6;
        private CalculatorButton btn_7;
        private CalculatorButton btn_8;
        private CalculatorButton btn_9;
        private CalculatorButton btn_Comma;
        private CalculatorButton btn_Sum;
        private CalculatorButton btn_Minus;
        private CalculatorButton btn_Multiplicate;
        private CalculatorButton btn_Divide;
        private CalculatorButton btn_Plus;
        private CalculatorButton btn_FullClear;
        private CalculatorButton btn_ClearEntry;
        private CalculatorButton btn_DeleteLastCharachter;
    }
}