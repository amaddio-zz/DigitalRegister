using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace DigitalCashDesk
{
    internal partial class _OrderViewer : Form
    {
        Font BoldFont;
        Table m_Table;
        long m_InvoiceNumber;

        internal _OrderViewer(Table tableOrder)
        {
            m_InvoiceNumber = -1;
            m_Table = tableOrder;
            InitializeComponent();
            BoldFont = new Font("Verdana", 10, FontStyle.Bold);

            FillContent(tableOrder);

            dGV_Products.CurrentCell = null;
        }

        private void FillContent(Table table)
        {
            dGV_Products.Rows.Add();

            if (null != table)
            {
                foreach (KeyValuePair<Product, int> p in table.Orders.BoughtProducts)
                {
                    dGV_Products.Rows.Add(p.Key.Name,
                                          p.Value + " x",
                                          p.Key.Price * p.Value);
                }

                dGV_Products.Rows.Add();

                dGV_Products.Rows.Add(string.Empty, "Gesamt", table.Orders.GetOrderSum);

                dGV_Products.Rows[dGV_Products.Rows.Count - 1].DefaultCellStyle.Font = BoldFont;
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            InvoiceNumberManager.Instance.ConsumeNumber();

            this.Close();
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            m_InvoiceNumber = InvoiceNumberManager.Instance.GetNumber();

            //CustomerReceiptDocument crd = new CustomerReceiptDocument(, m_Table, m_InvoiceNumber);
            //crd.GetPrintableDocument().Print();

            //ReceiptPreviewer rp = new ReceiptPreviewer();

            //rp.ShowPrintDocumentWindow(crd.GetPrintableDocument());
        }
    }
}
