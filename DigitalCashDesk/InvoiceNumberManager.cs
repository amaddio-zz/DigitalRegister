using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace DigitalCashDesk
{
    public class InvoiceNumberManager
    {
        private long m_CurrentInvoiceNumber;
        private static InvoiceNumberManager m_singleton;
        private DigitalCashDeskDBDataSet digitalCashDeskDBDataSet;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.InvoiceNumberTableAdapter invoiceNumberTableAdapter;

        private InvoiceNumberManager() 
        {
            this.digitalCashDeskDBDataSet = new DigitalCashDesk.DigitalCashDeskDBDataSet();
            this.invoiceNumberTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.InvoiceNumberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).BeginInit();
            this.digitalCashDeskDBDataSet.DataSetName = "DigitalCashDeskDBDataSet";
            this.digitalCashDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.invoiceNumberTableAdapter.ClearBeforeFill = true;
            ((System.ComponentModel.ISupportInitialize)(this.digitalCashDeskDBDataSet)).EndInit();

            m_CurrentInvoiceNumber = Convert.ToInt32( invoiceNumberTableAdapter.GetMaxInvoiceNumber() + 1);
        }
        
        public static InvoiceNumberManager Instance
        {
            get
            {
                if (null == m_singleton)
                    m_singleton = new InvoiceNumberManager();

                return m_singleton;
            }
        }

        public long GetNumber()
        {
            return m_CurrentInvoiceNumber;
        }

        public void ConsumeNumber()
        {
            invoiceNumberTableAdapter.Insert(DateTime.Now);
            m_CurrentInvoiceNumber = invoiceNumberTableAdapter.GetMaxInvoiceNumber() + 1;
        }
    }
}
