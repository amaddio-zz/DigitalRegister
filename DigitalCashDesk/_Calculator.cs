using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    public partial class _Calculator : Form
    {
        private decimal m_LastTotal;
        private string m_Currentinput;
        private string m_CurrentOperator;
        //private bool m_IsLastRowOperator;

        public _Calculator()
        {
            InitializeComponent();

            //lBx_Amount.Items.Add(" = 0");
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            CalculatorButton IntendedButton = sender as CalculatorButton;

            if (null != IntendedButton)
            {
                if (IntendedButton.CalculatorButtonValue.Equals(","))
                {
                    if (m_Currentinput.Contains(","))
                        return;
                    else
                        m_Currentinput += ",";
                }
                else
                {
                    //if (m_IsLastRowOperator)
                    m_Currentinput += IntendedButton.CalculatorButtonValue;
                }

                //    lBx_Amount.Items.RemoveAt(lBx_Amount.Items.Count - 1);
                if (lBx_Amount.Items.Count > 0)
                    lBx_Amount.Items[lBx_Amount.Items.Count - 1] = m_Currentinput;
                else
                {
                    lBx_Amount.Items.Add(m_Currentinput);
                }
                //lBx_Amount.Items.Add(m_Currentinput);            
            }
        }

        //private void CalculateTotalAmount(object sender, EventArgs e)
        //{
            
        //}

        private void OperaterButtonClicked(object sender, EventArgs e)
        {
            CalculatorButton IntendedButton = sender as CalculatorButton;

            if (null != IntendedButton)
            {
                if (string.IsNullOrEmpty(m_Currentinput))
                    return;
                else
                    lBx_Amount.Items.Add(" " + IntendedButton.CalculatorButtonValue);
                //m_IsLastRowOperator = true;

                //if (IntendedButton.CalculatorButtonValue.Equals("+"))
                //{                    
                //    m_LastTotal += Convert.ToDecimal(m_Currentinput);
                //    m_CurrentOperator = IntendedButton.CalculatorButtonValue;
                //}
                //else if (IntendedButton.CalculatorButtonValue.Equals("-"))
                //{
                //    m_LastTotal -= Convert.ToDecimal(m_Currentinput);
                //    m_CurrentOperator = IntendedButton.CalculatorButtonValue;
                //}
                //else if (IntendedButton.CalculatorButtonValue.Equals("*"))
                //{
                //    m_LastTotal *= Convert.ToDecimal(m_Currentinput);
                //    m_CurrentOperator = IntendedButton.CalculatorButtonValue;
                //}
                //else if (IntendedButton.CalculatorButtonValue.Equals("/"))
                //{
                //    m_LastTotal /= Convert.ToDecimal(m_Currentinput);
                //    m_CurrentOperator = IntendedButton.CalculatorButtonValue;
                //}

                m_Currentinput = string.Empty;
                lBx_Amount.Items.Add(m_Currentinput);

                //lBx_Amount.Items.Add( " = " + m_LastTotal);

                if (lBx_Amount.Items.Count > 0)
                {
                    lBx_Amount.SelectedIndex = lBx_Amount.Items.Count - 1;
                    lBx_Amount.SetSelected(lBx_Amount.SelectedIndex, false);
                }
            }
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            if (0 == lBx_Amount.Items.Count)
            {
                m_LastTotal = 0;
            }
            else if (1 == lBx_Amount.Items.Count || 2 == lBx_Amount.Items.Count)
            {
                m_LastTotal = Convert.ToDecimal(lBx_Amount.Items[0]);
            }
            else
            {
                m_LastTotal = Convert.ToDecimal(lBx_Amount.Items[0]);

                for (int i = 0; i <= lBx_Amount.Items.Count; i = i + 2)
                {
                    if (lBx_Amount.Items[i + 1].ToString().Contains("+"))
                    {
                        m_LastTotal += Convert.ToDecimal(lBx_Amount.Items[i + 2]);
                    }
                    else if (lBx_Amount.Items[i + 1].Equals("-"))
                    {
                        m_LastTotal -= Convert.ToDecimal(lBx_Amount.Items[i + 2]);
                    }
                    else if (lBx_Amount.Items[i + 1].Equals("*"))
                    {
                        m_LastTotal *= Convert.ToDecimal(lBx_Amount.Items[i + 2]);
                    }
                    else if (lBx_Amount.Items[i + 1].Equals("/"))
                    {
                        m_LastTotal /=  Convert.ToDecimal(lBx_Amount.Items[i + 2]);
                    }
                }
            }

            lBx_Amount.Items.Add(" = " + m_LastTotal);
        }
    }
}
