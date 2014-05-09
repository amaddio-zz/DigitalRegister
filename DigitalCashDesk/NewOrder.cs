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
    internal partial class NewOrder : Form
    {
        TableLayoutPanel TLP_Products;
        SortedList<int, FlowLayoutPanel> m_productFlowLayoutPanels;
        Font VerdanaButtonFont;
        Order m_newOrder;
        OrderManager m_OrderManager;
        const int INDEXDIVERSE = 5;
        Table m_Table;

        /// <summary>
        /// Creates a new order form. Use this constructor to initialize the form with values
        /// </summary>
        /// <param name="tableId"></param>
        internal NewOrder(ToolStripButton cancelItemToggleButton, string tableId)
        {
            VerdanaButtonFont = new Font("Verdana", 12, FontStyle.Regular);
            InitializeComponent();
            this.productTypeTableAdapter.Fill(digitalCashDeskDBDataSet.ProductType);
            //this.tableTableAdapter.Fill(digitalCashDeskDBDataSet.Table);
            this.productTableAdapter.Fill(digitalCashDeskDBDataSet.Product);
            cancelItemToggleButton.CheckStateChanged += new EventHandler(cancelItemToggleButton_CheckStateChanged);
            // in case there are orders booked on this table we
            // initialize the order form with the existing bookings
            m_OrderManager = OrderManager.Instance;
            m_Table = m_OrderManager.GetTable(tableId);
            if (null == m_Table) 
            {
                m_newOrder = new Order();
            }
            else
            {
                m_newOrder = (Order)m_Table.Orders.Clone();
            }
            m_newOrder.OrderSumChanged += new Order.OrderSum(UpdateOrderSum);
            //preselect the table which would otherwise manually be done in this form
            //m_SelectedTableButton = initTableButton(tableId);
            InitGUIData();
        }

        private void cancelItemToggleButton_CheckStateChanged(object sender, EventArgs e)
        {
            IList<FlowLayoutPanel> productButtonControls = m_productFlowLayoutPanels.Values;
            foreach (FlowLayoutPanel panel in productButtonControls)
            {
                foreach (Control c in panel.Controls)
                {
                    if (c is ProductButton)
                    {
                        ((ProductButton)c).CountUpwards = (!((ToolStripButton)sender).Checked);
                    }
                }
            }
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

        void UpdateOrderSum(decimal OrderAmount)
        {
            lbl_OrderSum.Text = OrderAmount.ToString();
        }

        public void InitGUIData()
        {
            TLP_Products = new TableLayoutPanel();
            TLP_Products.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TLP_Products.Location = new System.Drawing.Point(1, 1);
            TLP_Products.Size = new System.Drawing.Size(921, 665);
            int startingRow = 0;

            //TLP_Products.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //TLP_Products.Size = new Size(this.Width,this.Height - (this.Height - button53.Bounds.Y));

            // in case we do want to show the tables we skip the first row for the
            // tables. In case the user clicked on the table on the overview, we already
            // know which table he is booking on. Hence we can hide that row.
            /*if (false)
            {
                Label lbl_Tablel = new Label();
                lbl_Tablel.Font = VerdanaButtonFont;
                lbl_Tablel.Text = "Tisch:";
                lbl_Tablel.ForeColor = Color.Blue;
                lbl_Tablel.Margin = new Padding(4, 6, 4, 0);

                TLP_Products.Controls.Add(lbl_Tablel, 0, 0);

                FlowLayoutPanel flp_Tables = new FlowLayoutPanel();
                flp_Tables.Dock = DockStyle.Fill;

                for (int x = 0; x < digitalCashDeskDBDataSet.Table.Rows.Count; x++)
                {
                    DigitalCashDeskDBDataSet.TableRow tr = digitalCashDeskDBDataSet.Table[x];

                    TableButton tablebutton = initTableButton(tr.TableId);

                    flp_Tables.Controls.Add(tablebutton);
                }

                TLP_Products.Controls.Add(flp_Tables, 1, 0);
            }*/

            m_productFlowLayoutPanels = new SortedList<int, FlowLayoutPanel>();

            for (int i = 0, currentRow = 0; i < digitalCashDeskDBDataSet.ProductType.Rows.Count; i++)
            {
                DigitalCashDeskDBDataSet.ProductTypeRow pt = digitalCashDeskDBDataSet.ProductType[i];

                Label lbl = new Label();
                lbl.Font = VerdanaButtonFont;
                lbl.ForeColor = Color.Blue;
                lbl.AutoSize = true;
                lbl.Text = pt.ProductTypeName;
                if (0 == i)
                    lbl.Margin = new Padding(4, 6, 4, 0);
                else
                    lbl.Margin = new Padding(4, 26, 4, 0);

                // only add the category in case there are products
                // no need to a category per row when there is no product associated
                if (doesProductExistForId(pt.ProductId))
                {
                    TLP_Products.Controls.Add(lbl, 0, (currentRow++) + startingRow);

                    if (false == m_productFlowLayoutPanels.ContainsKey(pt.ProductId))
                    {
                        FlowLayoutPanel fpanel = new FlowLayoutPanel();
                        fpanel.Dock = DockStyle.Fill;
                        fpanel.AutoSize = true;

                        if (0 != i)
                            fpanel.Margin = new Padding(3, 20, 3, 3);

                        m_productFlowLayoutPanels.Add(pt.ProductId, fpanel);
                    }
                    else
                    {
                        // todo: log that the database contains duplicate ids
                        // this may never occure since the database constraint should
                        // prevent this behaviour
                    }
                }
                else
                {
                    // we basically ignore these here. Cash desks are usually running on smaller screens.
                    // so save a bit space on the screen with that
                }
            }

            for (int z = 0; z < digitalCashDeskDBDataSet.Product.Rows.Count; z++)
            {
                DigitalCashDeskDBDataSet.ProductRow pr = digitalCashDeskDBDataSet.Product[z];

                ProductButton productbutton = new ProductButton();

                // if the table is preset there could be bookings on the table already
                // prefill the form as well in that case
                if (true)
                {
                    int amountOrdered = getOrderedProducts(pr.ProductID);
                    if (0 < amountOrdered)
                    {
                        productbutton = new ProductButton(amountOrdered);
                    }
                }

                productbutton.Font = VerdanaButtonFont;
                productbutton.AutoSize = true;
                productbutton.Name = pr.Name;
                productbutton.Text = pr.Name /*+ "\n" + dr.Price.ToString()*/;
                productbutton.AssociatedProduct = new Product();
                productbutton.AssociatedProduct.Name = pr.Name;
                productbutton.AssociatedProduct.Price = pr.Price;
                productbutton.AssociatedProduct.ProductID = pr.ProductID;
                productbutton.AssociatedProduct.ProductTypeID = pr.ProductTypeId;

                productbutton.Click += new ProductButton.ClickHandler(productbutton_Click);

                if (m_productFlowLayoutPanels.ContainsKey(pr.ProductTypeId))
                {
                    m_productFlowLayoutPanels[pr.ProductTypeId].Controls.Add(productbutton);
                }
            }

            // update the order sum. For the case that there might be existing bookings
            UpdateOrderSum(m_newOrder.GetOrderSum);

            for (int p = 0; p < m_productFlowLayoutPanels.Count; p++)
            {
                TLP_Products.Controls.Add(m_productFlowLayoutPanels.Values[p], 1, p + startingRow);
            }

            FlowLayoutPanel flp_Divers = new FlowLayoutPanel();
            flp_Divers.Dock = DockStyle.Fill;

            TLP_Products.Controls.Add(flp_Divers);

            this.Controls.Add(TLP_Products);
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

        /*private TableButton initTableButton(string tableId, int numberOfSeats)
        {
            TableButton tablebutton = new TableButton();
            tablebutton.AssociatedTable.NameOfTable = tableId;
            tablebutton.AssociatedTable.Seats = numberOfSeats;
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
                    m_newOrder.AddProduct(prodButton.AssociatedProduct);
                }
                else
                {
                    // we delete one item if the toggle button of the main window is toggled
                    m_newOrder.RemoveProduct(prodButton.AssociatedProduct);
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
            if (m_Table == null && m_newOrder.BoughtProducts.Count == 0)
            {
                MessageBox.Show("Erst Produkt auswählen", "Kein Produkt selektiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //m_OrderManager.AddOrderToTable(m_newOrder, m_SelectedTableButton.AssociatedTable);
            m_OrderManager.UpdateOrdersOnTable(m_newOrder, m_Table);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.saveOrder();

            KitchenPrintDocument cpd = new KitchenPrintDocument(m_newOrder, m_Table.NameOfTable);
            BarPrintDocument bpd = new BarPrintDocument(m_newOrder, m_Table.NameOfTable);
            DiverseDocument dpd = new DiverseDocument(m_newOrder, m_Table.NameOfTable);

            //ReceiptPreviewer rP = new ReceiptPreviewer();
            //rP.ShowPrintDocumentWindow(cpd.GetPrintableDocument());
            //rP.ShowPrintDocumentWindow(bpd.GetPrintableDocument());

            cpd.GetPrintableDocument().Print();
            bpd.GetPrintableDocument().Print();
            dpd.GetPrintableDocument().Print();

            this.Close();
        }

        public void AddDiverseButton()
        {
            InsertDiverse id = new InsertDiverse();
            DialogResult dr = id.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Product NewProdcut = new Product();
                NewProdcut.Name = "DIV " + id.Price;
                NewProdcut.Price = id.Price;

                DigitalCashDeskDBDataSet.ProductTypeRow DivRow = null;

                foreach (DigitalCashDeskDBDataSet.ProductTypeRow ptype in digitalCashDeskDBDataSet.ProductType)
                {
                    if (ptype.ProductTypeName == id.WarengruppenName)
                    {
                        DivRow = ptype;
                        NewProdcut.ProductTypeID = ptype.ProductId;
                        break;
                    }
                }

                this.digitalCashDeskDBDataSet.Product.AddProductRow(NewProdcut.Name,
                    NewProdcut.Price, DivRow);

                this.productTableAdapter.Update(this.digitalCashDeskDBDataSet.Product);
                this.productTableAdapter.Fill(digitalCashDeskDBDataSet.Product);

                //FillProductFlowLayoutTable(false);

                foreach (DigitalCashDeskDBDataSet.ProductRow pr in digitalCashDeskDBDataSet.Product)
                {
                    if (NewProdcut.Name == pr.Name)
                        NewProdcut.ProductID = pr.ProductID;
                }

                ProductButton productbutton = new ProductButton();
                productbutton.Font = VerdanaButtonFont;

                productbutton.AutoSize = true;
                productbutton.Name = NewProdcut.Name;
                productbutton.Text = NewProdcut.Name /*+ "\n" + dr.Price.ToString()*/;

                productbutton.AssociatedProduct = NewProdcut;

                productbutton.Click += new ProductButton.ClickHandler(productbutton_Click);

                if (m_productFlowLayoutPanels.ContainsKey(DivRow.ProductId))
                {
                    m_productFlowLayoutPanels[DivRow.ProductId].Controls.Add(productbutton);
                }
            }

            //if (ProductFlowLayoutPanels.ContainsKey(INDEXDIVERSE))
            //{
            //    ProductFlowLayoutPanels[INDEXDIVERSE].Controls.Add();
            //}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.saveOrder();
            this.Close();
        }
    }
}
