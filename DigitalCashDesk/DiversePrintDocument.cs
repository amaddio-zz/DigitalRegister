using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;

namespace DigitalCashDesk
{
    internal class DiverseDocument
    {
        Order m_ToPrintOrder;
        PrintDocument m_OrderPrintDocument;
        float x;
        float y;
        float LineHeight;
        string m_TableName;
        bool m_BarProductFound;

        internal DiverseDocument(Order o, string TableName)
        {
            m_ToPrintOrder = o;
            m_OrderPrintDocument = new PrintDocument();
            m_OrderPrintDocument.DocumentName = "Rechnung";
            m_OrderPrintDocument.PrintPage += new PrintPageEventHandler(CashPrintDocument_PrintPage);
            m_TableName = TableName;
        }

        public PrintDocument GetPrintableDocument()
        {
            return m_OrderPrintDocument;
        }

        void CashPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics gObj = e.Graphics;
            Brush BrushBlack = Brushes.Black;
            Font VerdanaFont = new Font("Verdana", 14);
            //Font BoldVerdanaFont = new Font(VerdanaFont, FontStyle.Bold);
            LineHeight = VerdanaFont.GetHeight(gObj);

            x = 10;//e.MarginBounds.Left;
            y = 10; //e.MarginBounds.Top;

            gObj.DrawString("DIVERSE | ", VerdanaFont, BrushBlack, x, y);

            if (m_TableName.StartsWith("Tisch"))
                m_TableName = m_TableName.Replace("Tisch", string.Empty);

            gObj.DrawString("Tisch: " + m_TableName, VerdanaFont, BrushBlack, x + 110, y);
            IncrementTextLine();
            gObj.DrawString("", VerdanaFont, BrushBlack, x, y);

            foreach (KeyValuePair<Product,int> p in m_ToPrintOrder.BoughtProducts)
            {
                if (Product.IDDIVERS == p.Key.ProductTypeID)
                {
                    IncrementTextLine();
                    gObj.DrawString(p.Key.Name + " ", VerdanaFont, BrushBlack, x, y);
                    gObj.DrawString(p.Value + " x", VerdanaFont, BrushBlack, x + 160, y);
                    gObj.DrawString(p.Key.Price * p.Value + "€", VerdanaFont, BrushBlack, x + 210, y);
                    m_BarProductFound = true;
                }
            }

            if (false == m_BarProductFound)
                e.Cancel = true;
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
