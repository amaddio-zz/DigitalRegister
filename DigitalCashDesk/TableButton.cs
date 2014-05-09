using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    internal class TableButton : Button
    {
        private Table m_AssociatedTable;

        internal TableButton()
        {
            m_AssociatedTable = new Table();
        }

        public Table AssociatedTable
        {
            get { return m_AssociatedTable; }
            set { m_AssociatedTable = value; }
        }
    }
}
