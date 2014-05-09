using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    internal class CustomerReceiptDocument
    {
        Order m_ToPrintOrder;
        PrintDocument m_OrderPrintDocument;
        float x;
        float y;
        float LineHeight;
        string m_TableName;
        long m_Invoicenumber;

        internal CustomerReceiptDocument(string tableName, Order o, long InvoiceNumber)
        {
            m_ToPrintOrder = o;
            m_OrderPrintDocument = new PrintDocument();
            m_OrderPrintDocument.DocumentName = "Rechnung";
            m_OrderPrintDocument.PrintPage += new PrintPageEventHandler(CashPrintDocument_PrintPage);
            m_TableName = tableName;
            m_Invoicenumber = InvoiceNumber;
        }

        public PrintDocument GetPrintableDocument()
        {
            return m_OrderPrintDocument;
        }

        void CashPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics gObj = e.Graphics;
            Brush BrushBlack = Brushes.Black;
            Font VerdanaFont = new Font("Verdana", 10);
            Font HeaderFont = new Font("Verdana", 14);
            Font BoldHeaderFont = new Font(HeaderFont, FontStyle.Bold | FontStyle.Underline);
            LineHeight = VerdanaFont.GetHeight(gObj);
            
            x = 10; //e.MarginBounds.Left;
            y = 10; //e.MarginBounds.Top;

            gObj.DrawString("ESSCAFÉ", BoldHeaderFont, BrushBlack, x, y);
            IncrementTextLine();
            IncrementTextLine();

            gObj.DrawString("Konrad-Zuse-Str. 18 ", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("91052 Erlangen ", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("TEL: 09131 5333499", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            IncrementTextLine();
            gObj.DrawString("RECHNUNG", VerdanaFont, BrushBlack, x, y);
            gObj.DrawString(m_Invoicenumber.ToString(), VerdanaFont, BrushBlack, x + 140, y);
            IncrementTextLine();
            IncrementTextLine();
            gObj.DrawString(DateTime.Now.ToShortDateString(), VerdanaFont, BrushBlack, x + 140, y);

            gObj.DrawString("Tisch " + m_TableName, VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("------------------------------------", VerdanaFont, BrushBlack, x, y);


            foreach (KeyValuePair<Product,int> p in m_ToPrintOrder.BoughtProducts)
            {
                    IncrementTextLine();
                    gObj.DrawString(p.Key.Name + " ", VerdanaFont, BrushBlack, x, y);
                    gObj.DrawString(p.Value + " x", VerdanaFont, BrushBlack, x + 200, y);
                    IncrementTextLine();
                    gObj.DrawString((FormatDecimalNumber(Math.Round(p.Key.Price, 2))), VerdanaFont, BrushBlack, x, y);
                    gObj.DrawString((FormatDecimalNumber(Math.Round((p.Key.Price * p.Value), 2))), VerdanaFont, BrushBlack, x + 150, y);
            }
            

            IncrementTextLine();
            gObj.DrawString("------------------------------------", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("BAR", VerdanaFont, BrushBlack, x, y);
            gObj.DrawString("€ " + FormatDecimalNumber((Math.Round(m_ToPrintOrder.GetOrderSum, 2))), VerdanaFont, BrushBlack, x + 140, y);
            IncrementTextLine();
            if (false == m_TableName.ToLower().Contains("2go"))
            {
                gObj.DrawString("MWST 19%", VerdanaFont, BrushBlack, x, y);
                gObj.DrawString("€ " + FormatDecimalNumber(Math.Round((m_ToPrintOrder.GetOrderSum * 19 / 119), 2)), VerdanaFont, BrushBlack, x + 140, y);
            }
            else
            {
                gObj.DrawString("MWST 7%", VerdanaFont, BrushBlack, x, y);
                gObj.DrawString("€ " + FormatDecimalNumber(Math.Round((m_ToPrintOrder.GetOrderSum * 7 / 107), 2)), VerdanaFont, BrushBlack, x + 140, y);
            }

            IncrementTextLine();
            gObj.DrawString("NETTO", VerdanaFont, BrushBlack, x, y);
            if (false == m_TableName.ToLower().Contains("2go"))
            {
                gObj.DrawString("€ " + FormatDecimalNumber(Math.Round((m_ToPrintOrder.GetOrderSum * 100 / 119), 2)), VerdanaFont, BrushBlack, x + 140, y);
            }
            else
            {
                gObj.DrawString("€ " + FormatDecimalNumber(Math.Round((m_ToPrintOrder.GetOrderSum * 100 / 107), 2)), VerdanaFont, BrushBlack, x + 140, y);
            }
            IncrementTextLine();
            IncrementTextLine();
            gObj.DrawString("Vielen Dank für Ihren Besuch", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            gObj.DrawString("Auf Wiedersehen!", VerdanaFont, BrushBlack, x, y);
            IncrementTextLine();
            IncrementTextLine();
            gObj.DrawString("St.Nr: 216/200/70030", VerdanaFont, BrushBlack, x, y);

            if (y == (float)116.879608)
                e.Cancel = true;
        }

        private void IncrementTextLine()
        {
            y += LineHeight;
        }

        private string FormatDecimalNumber(decimal number)
        {
            string[] ret = number.ToString().Split(',');
            if (1 == ret.Length)
                return ret[0] + ".00";
            else
            {
                if (ret[1].Length == 1)
                    return ret[0] + "." + ret[1] + "0";
            }

            return number.ToString();
        }

        private void IncrementTextLine(int RowAmount)
        {
            y += (LineHeight + RowAmount);
        }
    }
}
