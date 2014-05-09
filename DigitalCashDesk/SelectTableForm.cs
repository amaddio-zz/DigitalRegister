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
    public partial class SelectTableForm : Form
    {
        private string m_selectedTable;

        public SelectTableForm(List<string> orderNamesWithIndexKeys)
        {
            InitializeComponent();

            foreach (string tableName in orderNamesWithIndexKeys)
            {
                Button b = new Button();
                b.Click += new EventHandler(buttonClick);
                b.Text = tableName;
                fLP_tables.Controls.Add(b);
            }

            m_selectedTable = string.Empty;
        }

        void buttonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

             m_selectedTable = ((Button)sender).Text;

            //m_selectedOrderKey = ((Button)sender).Text;
            this.Close();
        }

        public string SelectedOrderNameKey
        {
            get { return m_selectedTable; }
        }
    }
}
