using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace DigitalCashDesk
{
    public partial class ReceiptPreviewer : Form
    {
        public ReceiptPreviewer()
        {
            InitializeComponent();
        }

        public void ShowPrintDocumentWindow(PrintDocument pDoc)
        {
            printPreviewControl1.Document = pDoc;

            this.Show();
        }
    }
}
