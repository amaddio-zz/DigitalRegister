using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Globalization;

namespace DigitalCashDesk
{
    public partial class _CashConfig : Form
    {
        private static _CashConfig m_singleton;
        private bool m_Aborted;
        private const int INDEXNAME = 0;
        private const int INDEXPRICE = 1;
        private const int INDEXTYPE = 2;

        DataGridView m_LastActiveDataGridView;

        private _CashConfig()
        {
            InitializeComponent();
        }

        public static _CashConfig Instance
        {
            get
            {
                if (null == m_singleton)
                    m_singleton = new _CashConfig();

                return m_singleton;
            }
        }

        private void CashConfig_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "digitalCashDeskDBDataSet.Product". Sie können sie bei Bedarf verschieben oder entfernen.
            this.productTableAdapter.Fill(this.digitalCashDeskDBDataSet.Product);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "digitalCashDeskDBDataSet.Table". Sie können sie bei Bedarf verschieben oder entfernen.
            this.tableTableAdapter.Fill(this.digitalCashDeskDBDataSet.Table);
            this.productTypeTableAdapter.Fill(this.digitalCashDeskDBDataSet.ProductType);
        }

        private void CashConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (false == m_Aborted)
            {
                SaveData();
            }
            else
            {
                this.digitalCashDeskDBDataSet.Clear();
                this.productTableAdapter.Fill(this.digitalCashDeskDBDataSet.Product);
                this.tableTableAdapter.Fill(this.digitalCashDeskDBDataSet.Table);
                this.productTypeTableAdapter.Fill(this.digitalCashDeskDBDataSet.ProductType);
            }
            m_singleton = null;
        }

        private void SaveData()
        {
            this.productTableAdapter.Update(this.digitalCashDeskDBDataSet.Product);
            this.tableTableAdapter.Update(this.digitalCashDeskDBDataSet.Table);
            this.productTypeTableAdapter.Update(this.digitalCashDeskDBDataSet.ProductType);
            this.digitalCashDeskDBDataSet.AcceptChanges();
        }

        private void btn_SaveExit_Click(object sender, EventArgs e)
        {
            m_Aborted = false;
            this.Close();
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            m_Aborted = true;
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (null != m_LastActiveDataGridView)
            {
                DialogResult dr = MessageBox.Show("Sicher, dass Sie die Zeilen löschen möchten?", "Zeilen löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == dr)
                {
                    foreach (DataGridViewRow row in m_LastActiveDataGridView.SelectedRows)
                    {
                        m_LastActiveDataGridView.Rows.Remove(row);
                    }
                }
            }
        }

        private void dGV_Products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            m_LastActiveDataGridView = (DataGridView)sender;
        }

        private void dGV_Products_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dGV_Products[e.ColumnIndex, e.RowIndex].ErrorText = "";
            e.Cancel = false;
            //dGV_Products_DataError
            if (INDEXNAME == e.ColumnIndex)
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dGV_Products[e.ColumnIndex, e.RowIndex].ErrorText =
                        "Bitte Namen eingeben";
                    e.Cancel = true;
                }
            }
            else if (INDEXPRICE == e.ColumnIndex)
            {
                float price = (float)0.0;

                if (String.IsNullOrEmpty(e.FormattedValue.ToString()) || !float.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.GetCultureInfo("de-DE").NumberFormat, out price))
                {
                    dGV_Products[e.ColumnIndex, e.RowIndex].ErrorText = "Bitte Preis eingeben";
                    e.Cancel = true;
                }
            }
            else if (INDEXTYPE == e.ColumnIndex)
            {
                if(String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dGV_Products[e.ColumnIndex, e.RowIndex].ErrorText = "Bitte Produktart zuweisen";
                    e.Cancel = true;
                }
            }
        }

        private void dGV_Products_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            if ((anError.Exception) is ConstraintException ||
                (anError.Exception) is NoNullAllowedException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
    }
}