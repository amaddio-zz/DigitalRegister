using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace DigitalCashDesk
{
    internal class CashPrintDocument
    {
        Order m_ToPrintOrder;
        PrintDocument m_OrderPrintDocument;
        float x;
        float y;
        float LineHeight;

        internal CashPrintDocument(Order o)
        {
            m_ToPrintOrder = o;
            m_OrderPrintDocument = new PrintDocument();
            m_OrderPrintDocument.DocumentName = "Rechnung";
            m_OrderPrintDocument.PrintPage += new PrintPageEventHandler(CashPrintDocument_PrintPage);
        }

        public PrintDocument GetPrintableDocument()
        {
            return m_OrderPrintDocument;
        }

        void CashPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics gObj = e.Graphics;
            Brush BrushBlack = Brushes.Black;
            Font VerdanaFont = new Font("Verdana", 9);
            LineHeight = VerdanaFont.GetHeight(gObj);

            x = e.MarginBounds.Left;
            y = e.MarginBounds.Top;

            gObj.DrawString("Willkommen im Esscafé", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("Ihre Bestellung:", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("", VerdanaFont, BrushBlack, x, y);

            foreach (KeyValuePair<Product,int> p in m_ToPrintOrder.BoughtProducts)
            {
                IncrementTextLine();
                gObj.DrawString(p.Key.Name + " ", VerdanaFont, BrushBlack, x, y);
                gObj.DrawString(p.Key.Price.ToString(), VerdanaFont, BrushBlack, x + 100, y);                
            }
        }

        private void IncrementTextLine()
        {
            y += LineHeight;
        }

        private void IncrementTextLine(int RowAmount)
        {
            y += (LineHeight + RowAmount);
        }
    }
}
