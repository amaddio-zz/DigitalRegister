using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DigitalCashDesk
{
    internal class Table
    {
        private string m_NameOfTable;
        private int m_Seats;
        // we treat this table as if there would be only one order
        // we dont need to distinguish between the individual orders
        private Order m_AllOrders;

        internal string NameOfTable
        {
            get { return m_NameOfTable; }
            set { m_NameOfTable = value; }
        }

        internal int Seats
        {
            get { return m_Seats; }
            set { m_Seats = value; }
        }

        internal Order Orders
        {
            get 
            {
                if (null == m_AllOrders)
                    m_AllOrders = new Order();
            
                return m_AllOrders; 
            }
            set { m_AllOrders = value; }
        }

        public override string ToString()
        {
            return "name: " + m_NameOfTable;
        }
    }
}
