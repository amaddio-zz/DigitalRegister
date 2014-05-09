using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DigitalCashDesk
{
    internal partial class PaymentForm : Form
    {
        //TableLayoutPanel TLP_Products;
        //SortedList<int, FlowLayoutPanel> m_productFlowLayoutPanels;
        Font VerdanaButtonFont;
        Font BoldFont;
        Order m_MainOrder;
        // keeps all changes, will get committed to m_MainOrder when saved
        Order m_TempMainOrder;
        Order m_splitBill;
        OrderManager m_OrderManager;
        DataGridViewTextBoxCell m_AmountNotPayedYetCell;
        DataGridViewTextBoxCell m_totalAmountSplits;
        DataGridViewRow m_sumRow;
        const int INDEXDIVERSE = 5;
        const int MAINORDERPRICECOLUMN = 1;
        Table m_Table;
        private const string PRINTBUTTONSPLIT = "Split drucken";
        private const string PRINTBUTTON = "Drucken";

        /// <summary>
        /// Creates a new order form. Use this constructor to initialize the form with values
        /// </summary>
        /// <param name="tableId"></param>
        internal PaymentForm(string tableId)
        {
            VerdanaButtonFont = new Font("Verdana", 12, FontStyle.Regular);
            BoldFont = new Font("Verdana", 10, FontStyle.Bold);
            InitializeComponent();
            this.productTypeTableAdapter.Fill(digitalCashDeskDBDataSet.ProductType);
            this.tableTableAdapter.Fill(digitalCashDeskDBDataSet.Table);
            this.productTableAdapter.Fill(digitalCashDeskDBDataSet.Product);
            // in case there are orders booked on this table we
            // initialize the order form with the existing bookings
            m_OrderManager = OrderManager.Instance;
            m_splitBill = new Order();
            m_Table = m_OrderManager.GetTable(tableId);
            if (null == m_Table) 
            {
                m_TempMainOrder = new Order();
            }
            else
            {
                m_MainOrder = m_Table.Orders;
                m_TempMainOrder = (Order)m_MainOrder.Clone();
            }

            //preselect the table which would otherwise manually be done in this form
            //m_SelectedTableButton = initTableButton(tableId);
            FillContent(m_Table);
        }

        /// <summary>
        /// get amount of products already ordered at this table
        /// </summary>
        /// <returns>amount of ordered products. 0 if none yet.</returns>
        private int getOrderedProducts(int productId)
        {
            if (null != m_Table)
            {
                // get the current order from the ordermanager
                foreach (KeyValuePair<Product, int> products in m_Table.Orders.BoughtProducts)
                {
                    if (productId == products.Key.ProductID)
                    {
                        return products.Value;
                    }
                }
            }

            return 0;
        }

        private bool doesProductExistForId(int productId)
        {
            for (int i = 0; i < digitalCashDeskDBDataSet.Product.Rows.Count; i++)
            {
                DigitalCashDeskDBDataSet.ProductRow pr = digitalCashDeskDBDataSet.Product[i];

                if (productId == pr.ProductTypeId)
                {
                    return true;
                }
            }

            return false;
        }

        /*private TableButton initTableButton(string tableId)
        {
            TableButton tablebutton = new TableButton();
            tablebutton.AssociatedTable.NameOfTable = tableId;
            tablebutton.Font = VerdanaButtonFont;
            tablebutton.AutoSize = true;
            tablebutton.Text = tableId;
            tablebutton.Click += new EventHandler(tablebutton_Click);

            return tablebutton;
        }*/

        /*void tablebutton_Click(object sender, EventArgs e)
        {
            TableButton TableButton = sender as TableButton;

            if (TableButton != null)
            {
                if (TableButton != m_SelectedTableButton)
                {
                    TableButton.BackColor = Color.Gray; //System.Drawing.SystemColors.ButtonHighlight;

                    if (null != m_SelectedTableButton)
                    {
                        m_SelectedTableButton.BackColor = Color.Transparent;
                    }

                    m_SelectedTableButton = TableButton;
                }
            }
        }*/

        void productbutton_Click(ProductButton prodButton)
        {
            if (null != prodButton)
            {
                if (prodButton.CountUpwards)
                {
                    m_TempMainOrder.AddProduct(prodButton.AssociatedProduct);
                }
                else
                {
                    // we delete one item if the toggle button of the main window is toggled
                    m_TempMainOrder.RemoveProduct(prodButton.AssociatedProduct);
                }
            }
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveOrder()
        {
            /*if (null == m_SelectedTableButton)
            {
                MessageBox.Show("Bestellung einem Tisch zuordnen", "Kein Tisch ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            // there has to be either bookings on the table already, or this initial submition needs some selections
            /*if (m_Table == null && m_TempMainOrder.BoughtProducts.Count == 0)
            {
                MessageBox.Show("Erst Produkt auswählen", "Kein Produkt selektiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            //m_OrderManager.AddOrderToTable(m_newOrder, m_SelectedTableButton.AssociatedTable);
            m_OrderManager.UpdateOrdersOnTable(m_TempMainOrder, m_Table);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            const string MAINBILLNAME = "Hauptrechnung";
            bool splitBookingExist = false;
            // in case we have a split bill we have the user to select which one he wants to print
            if (0 < m_splitBill.GetOrderSum) 
            {
                splitBookingExist = true;
            }

            CustomerReceiptDocument crd = null;

            // print the main bill (open bill minus splits)
            if (!splitBookingExist)
            {
                crd = new CustomerReceiptDocument(m_Table.NameOfTable, m_TempMainOrder, InvoiceNumberManager.Instance.GetNumber());
                // we have to reset the main bill in case the user wants to let the main bill pay
                m_TempMainOrder = new Order();
            }
            // find out which split bill the user wants to print
            else
            {
                // we have to reduce the split number by one because the
                // main bill has index 0 reserved
                crd = new CustomerReceiptDocument(m_Table.NameOfTable, m_splitBill, InvoiceNumberManager.Instance.GetNumber());
            }

            //ReceiptPreviewer rP = new ReceiptPreviewer();
            //rP.ShowPrintDocumentWindow(crd.GetPrintableDocument());

            // PRINT THE DOCUMENT
            crd.GetPrintableDocument().Print();
            // use this invoice number. They have to increment by one and may never get used again
            InvoiceNumberManager.Instance.ConsumeNumber();

            // save the main order, split orders have been removed from main bill already

            this.saveOrder();

            this.Close();
        }

        private void FillContent(Table table)
        {
            dGV_Products.Rows.Add();

            if (null != table)
            {
                // add all ordered products to the list
                foreach (KeyValuePair<Product, int> p in table.Orders.BoughtProducts)
                {
                    for (int i = 0; i < p.Value; i++)
                    {
                        dGV_Products.Rows.Add(createDataGridViewProductRow(p.Key, p.Key.Name, p.Key.Price));
                        //dGV_Products.Rows.Add(p.Key.Name, p.Key.Price);
                    }
                }

                dGV_Products.Rows.Add();

                // cell which represents the amount which is not payed yet
                m_AmountNotPayedYetCell = new DataGridViewTextBoxCell();
                m_AmountNotPayedYetCell.Style.Font = BoldFont;
                m_AmountNotPayedYetCell.Value = table.Orders.GetOrderSum;
                dGV_Products.Rows.Add(createDataGridViewRow("Offen", m_AmountNotPayedYetCell));

                // cell which represents the total amount of the split bills
                m_totalAmountSplits = new DataGridViewTextBoxCell();
                m_totalAmountSplits.Style.Font = BoldFont;
                m_totalAmountSplits.Value = "0";
                dGV_Products.Rows.Add(createDataGridViewRow("+ Splitzahlungen", m_totalAmountSplits));

                // cell which represents the total amount of the bill
                m_sumRow = createDataGridViewRow("Gesamt", table.Orders.GetOrderSum);
                dGV_Products.Rows.Add(m_sumRow);

                dGV_Products.Rows[dGV_Products.Rows.Count - 1].DefaultCellStyle.Font = BoldFont;
            }
        }

        private DataGridViewProductRow createDataGridViewProductRow(Product product, params object[] data) 
        {
            DataGridViewProductRow newRow = new DataGridViewProductRow();
            if (null != product) 
            {
                newRow.Product = product;
            }

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is DataGridViewTextBoxCell)
                {
                    newRow.Cells.Add((DataGridViewTextBoxCell)data[i]);
                }
                else
                {
                    DataGridViewTextBoxCell tempCell = new DataGridViewTextBoxCell();
                    tempCell.Value = Convert.ToString(data[i]);
                    newRow.Cells.Add(tempCell);
                }
                /*else
                {
                    MessageBox.Show("DATATYPE NOT IMPLEMENTED YET");
                    throw new NotImplementedException("DATATYPE NOT IMPLEMENTED YET");
                }*/
            }

            return newRow;
        }

        private DataGridViewRow createDataGridViewRow(params object[] data)
        {
            return (DataGridViewRow)createDataGridViewProductRow(null, data);
        }

        private void dGV_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // then we have to find out if the selection is in the section where the products are located
            // this would mean the user wants to move ordered products from the main bill to seperate bills.
            // he literally wants to split the bill
            // -- the list of products end on row above the index of m_AmountNotPayedYetCell
            if (0 < e.RowIndex && e.RowIndex < m_AmountNotPayedYetCell.RowIndex - 1)
            {
                if (dGV_Products.Rows[e.RowIndex] is DataGridViewProductRow)
                {
                    // which product got selected
                    Product productOfRow = ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).Product;

                    // the first three columns represent the name of the product, the price and a sum column
                    // beginning with the 4th column they represent the guests. The amount is set dinamically.
                    
                    // if the user clicks on the main order column (3) he wants to put back seperated orders
                    if(1 == e.ColumnIndex)
                    {
                        // shift the order from one to another
                        //Order FromOrder = m_splitBill[((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).PriceShownInColumn - 3];
                        // do not shift the booking if it already is set onto the main order
                        if (1 == ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).PriceShownInColumn) 
                        {
                            return;
                        }

                        shiftProductFromBillToAnother(getProductFromRowIndex(e.RowIndex), m_splitBill, m_TempMainOrder);

                        // visually shift the product from guest column to main bill column
                        ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).showProductPriceInColum(MAINORDERPRICECOLUMN);

                        //MessageBox.Show("Zurück auf Hauptrechnung");
                    }
                    // if the user clicks on a guest column he wants to add a product from the main bill
                    // to the split bill, or shifts an item from one split bill to another split bill
                    if (2 == e.ColumnIndex) 
                    {
                        //int productAssignedtoColumn = ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).PriceShownInColumn;

                        // do not shift the booking if it already is set onto the main order
                        if (2 == ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).PriceShownInColumn)
                        {
                            return;
                        }

                        // shift the order from one to another
                        shiftProductFromBillToAnother(getProductFromRowIndex(e.RowIndex), m_TempMainOrder, m_splitBill);

                        // visually shift the product from one column to the other
                        ((DataGridViewProductRow)dGV_Products.Rows[e.RowIndex]).showProductPriceInColum(e.ColumnIndex);
                        //MessageBox.Show("Splitübernahme Gast: " + (GuestNumber));
                    }

                    if (0 == m_splitBill.GetOrderSum) 
                    {
                        btn_Print.Text = PRINTBUTTON;
                    }
                    else
                    {
                        btn_Print.Text = PRINTBUTTONSPLIT;
                    }

                    updateSumLabels();
                }
            }
        }

        private void updateSumLabels() 
        {
            m_totalAmountSplits.Value = m_splitBill.GetOrderSum; // update the total sum of splits
            m_AmountNotPayedYetCell.Value = m_TempMainOrder.GetOrderSum; // update the sum which shows the total amount left on the mail bill

            // update the sum for each split bill
            m_sumRow.Cells[2].Value = m_splitBill.GetOrderSum;
        }

        private Product getProductFromRowIndex(int rowIndex) 
        {
            Product p = null;

            if(dGV_Products.Rows.Count < rowIndex )
            {
                MessageBox.Show("Index does not exist in DataGridView");
            }
            else
            {
                p = ((DataGridViewProductRow)dGV_Products.Rows[rowIndex]).Product;
            }

            return p;
        }

        /*private Order getSplitOrderFromIndex(int guestIndex)
        {
            Order splitOrder = null;
            m_splitBill.TryGetValue(guestIndex, out splitOrder);

            if (null == splitOrder) 
            {
                MessageBox.Show("ERROR UNDEFINED SPLIT INDEX !!");
            }

            return splitOrder;
        }*/

        private void shiftProductFromBillToAnother(Product shiftThisProduct, Order fromOrder, Order toOrder) 
        {
            fromOrder.RemoveProduct(shiftThisProduct);
            toOrder.AddProduct(shiftThisProduct);
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            SelectTableForm selectTableForm = new SelectTableForm(m_OrderManager.GetTableNames());
            selectTableForm.ShowDialog();
            string selectedTableName = selectTableForm.SelectedOrderNameKey;
            Table selectedTable = m_OrderManager.GetTable(selectedTableName);

            // does this table exist
            if (string.Empty == selectedTableName || null == selectedTable)
            {
                MessageBox.Show("unbekannte Tischbezeichnung. Tisch kann nicht umgezogen werden.", "unbekannter Tisch");
            }
            else
            {
                // dont book on a table with other bookings
                if (0 < selectedTable.Orders.GetOrderSum)
                {
                    MessageBox.Show("Es kann nur auf einen Tisch umgezogen werden, wenn er leer ist.", "Dieser Tisch ist belegt");
                }
                else
                {
                    // table empty so shift orders over
                    m_OrderManager.UpdateOrdersOnTable(m_MainOrder, selectedTable);
                    // empty order on this table
                    m_TempMainOrder = new Order();
                    this.saveOrder();
                    this.Close();
                }
            }
        }
    }
}