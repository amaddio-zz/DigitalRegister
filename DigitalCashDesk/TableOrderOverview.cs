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
    public partial class TableOrderOverview : Form
    {
        private const int PANELWIDTH = 187;
        private const int PANELHEIGHT = 95;
        private const int FORMLEFTMARGIN = 26;
        private const int FORMTOPMARGIN = 26;
        private const int PANELCOLUMNSPACING = 10;
        private const int PANELROWSPACING = 10;

        private int PanelColumnCounter = 0;
        private int PanelRowCounter = 0;
        private OrderManager m_OrderManager;

        private Dictionary<string, TablePanel> m_AllTables;

        internal event tablePanelClickhandler tableClicked;
        internal delegate void tablePanelClickhandler(TablePanel tablePanel);
        private void onTablePanelClicked(TablePanel tablePanel)
        {
            if (null != tableClicked)
            {
                tableClicked(tablePanel);
            }
        }
 
        public TableOrderOverview()
        {
            m_AllTables = new Dictionary<string, TablePanel>();
            InitializeComponent();

            this.tableTableAdapter.Fill(this.digitalCashDeskDBDataSet.Table);

            InsertTablesIntoForm();

            m_OrderManager = OrderManager.Instance;
            m_OrderManager.TableOrderChanged += new OrderManager.TableOrderChangedEventArgs(OrderChanged);
        }

        void OrderChanged(Table t)
        {
            if (m_AllTables.ContainsKey(t.NameOfTable))
            {
                SetTableContent(m_AllTables[t.NameOfTable].TableText, t);
            }
        }

        void SetTableContent(ListBox lBox, Table t)
        {
            lBox.Items.Clear();

            if (0 < t.Orders.GetOrderSum)
            {
                lBox.Items.Add("Anzahl Bestellungen: " + t.Orders.amountBoughtProducts + "\n");
                lBox.Items.Add("Summe: " + t.Orders.GetOrderSum + "\n");
            }
        }

        private void InsertTablesIntoForm()
        {
            foreach (DigitalCashDeskDBDataSet.TableRow t in this.digitalCashDeskDBDataSet.Table.Rows)
            {
                TablePanel CurrentPanel = new TablePanel(t.TableId);

                CurrentPanel.ButtonAbort.Click += new EventHandler(DeleteTableOrdersClick);
                CurrentPanel.OKButton.Click += new EventHandler(LetTablePayClick);
                CurrentPanel.TableText.Click += new EventHandler(ClickedOnTable);

                AlignControl(CurrentPanel);
                this.Controls.Add(CurrentPanel);

                m_AllTables.Add(t.TableId, CurrentPanel);
            }
        }

        void ClickedOnTable(object sender, EventArgs e)
        {
            if (sender is ListBox) 
            {
                TablePanel clickedTable = ((ListBox)sender).Parent as TablePanel;
                
                if (null != clickedTable)
                {
                    onTablePanelClicked(clickedTable);
                }
            }
        }

        void LetTablePayClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            TablePanel p = b.Parent as TablePanel;

            if (null != p)
            {
                Table t = null;

                t = m_OrderManager.GetTable(p.TableID);

                //OrderViewer oV = new OrderViewer(t);
                PaymentForm paymentForm = new PaymentForm(p.TableID);
                paymentForm.WindowState = FormWindowState.Maximized;
                DialogResult dr = paymentForm.ShowDialog();

                if (DialogResult.OK == dr)
                {
                    //m_OrderManager.PayCompleteOrder(p.TableID);
                }

            }
        }

        void DeleteTableOrdersClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            TablePanel p = b.Parent as TablePanel;

            if (null != p)
            {
                m_OrderManager.DeleteTableOrders(p.TableID);
            }
        }

        private void AlignControl(Panel pnl)
        {
            if (0 == PanelColumnCounter)
            {
                pnl.Left = FORMLEFTMARGIN;
                pnl.Top = FORMTOPMARGIN;
                PanelColumnCounter++;
            }
            else
            {
                if ((PanelColumnCounter * PANELWIDTH +
                    PanelColumnCounter * PANELCOLUMNSPACING)
                    > this.Width)
                {
                    PanelColumnCounter = 0;
                    PanelRowCounter++;
                }

                pnl.Left = FORMLEFTMARGIN +
                           PanelColumnCounter * PANELWIDTH +
                           PanelColumnCounter * PANELCOLUMNSPACING;

                pnl.Top = FORMTOPMARGIN +
                          PanelRowCounter * PANELHEIGHT +
                          PanelRowCounter * PANELROWSPACING;

                PanelColumnCounter++;

            }
        }

        private void TableOrderOverview_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
