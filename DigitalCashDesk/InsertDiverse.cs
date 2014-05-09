using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    public partial class InsertDiverse : Form
    {
        public InsertDiverse()
        {
            InitializeComponent();
        }

        private void UpdateGuiValues(object sender, EventArgs e)
        {
            Button button = sender as Button;

            tbx_Price.Text += button.Text;
            //tbx_Name.Text += button.Text;
        }

        private void DeleteGUIValues(object sender, EventArgs e)
        {
            tbx_Price.Text = string.Empty;
            //tbx_Name.Text = "DIVERS";
        }

        public string WarengruppenName
        {
            get { return comboBox1.GetItemText(comboBox1.SelectedItem); }
        }

        public decimal Price
        {
            get { return Convert.ToDecimal( tbx_Price.Text ); }
        }

        private void InsertDiverse_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "digitalCashDeskDBDataSet.ProductType". Sie können sie bei Bedarf verschieben oder entfernen.
            this.productTypeTableAdapter.Fill(this.digitalCashDeskDBDataSet.ProductType);

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.GetItemText(comboBox1.Items[i]).ToLower().Contains("div"))
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
