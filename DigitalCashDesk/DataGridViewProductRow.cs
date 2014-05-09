using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    internal class DataGridViewProductRow : DataGridViewRow
    {
        private Product m_product;
        private int priceShownInColumn;

        internal Product Product
        {
            get { return m_product; }
            set { m_product = value; }
        }

        internal DataGridViewProductRow() : base()
        {
            // show the price in the standard column
            priceShownInColumn = 1;
        }

        /// <summary>
        /// update the row so that the price of the current which this row represents gets shown in
        /// the column with the overgiven index
        /// </summary>
        /// <param name="showPriceInColumn"></param>
        internal void showProductPriceInColum(int showPriceInColumn)
        {
            this.Cells[priceShownInColumn].Value = "";
            this.Cells[showPriceInColumn].Value = this.Product.Price;
            priceShownInColumn = showPriceInColumn;
        }

        internal int PriceShownInColumn 
        {
            get { return this.priceShownInColumn; }
        }
    }
}
