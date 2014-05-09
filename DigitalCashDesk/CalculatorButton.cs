using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    internal class CalculatorButton : Button
    {
        private string m_CalculatorButtonValue;

        public string CalculatorButtonValue
        {
            get { return m_CalculatorButtonValue; }
            set { m_CalculatorButtonValue = value; }
        }
    }
}
