using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Drawing.Drawing2D;

namespace DigitalCashDesk
{
    public partial class _ObsoleteCashWork : Form
    {
        private const int IDDRINK = 2;
        private const int IDFOOD = 1;

        //private const int ITEMSCOLUMN = 0;
        //private const int TABLEROWINDEX = 1;
        //private const int DRINKROWINDEX = 3;
        //private const int FOODROWINDEX = 5;

        Order m_Order;
        TableButton m_LastTableButton;
        OrderManager m_OrderManager;

        public _ObsoleteCashWork()
        {
            InitializeComponent();
            m_Order = new Order();
            m_Order.OrderSumChanged += new Order.OrderSum(UpdateOrderSum);
            m_OrderManager = OrderManager.Instance;
        }

        void UpdateOrderSum(decimal OrderAmount)
        {
            lbl_OrderSum.Text = OrderAmount.ToString();
        }

        private void PerformTableLayout()
        {
            foreach (DigitalCashDeskDBDataSet.TableRow dr in this.digitalCashDeskDBDataSet.Table.Rows)
            {
                TableButton tableButton = new TableButton();
                tableButton.AssociatedTable.NameOfTable = dr.TableId;
                //tableButton.AssociatedTable.Seats = Convert.ToInt32(dr.AmountSeats);

                tableButton.Click += new EventHandler(TableButtonClicked);

                tableButton.AutoSize = true;
                tableButton.Name = "TableNr" + dr.TableId;
                tableButton.Text = dr.TableId.ToString();

                FLP_Tables.Controls.Add(tableButton);
            }
        }

        private void PerformProductLayout()
        {
            for (int i = 0; i < this.digitalCashDeskDBDataSet.Product.Rows.Count; i++)
            {
                DigitalCashDeskDBDataSet.ProductRow dr = this.digitalCashDeskDBDataSet.Product[i];

                ProductButton ProdButton = new ProductButton();

                ProdButton.AutoSize = true;
                ProdButton.Name = dr.Name;
                ProdButton.Text = dr.Name /*+ "\n" + dr.Price.ToString()*/;
                ProdButton.AssociatedProduct = new Product();
                ProdButton.AssociatedProduct.Name = dr.Name;
                ProdButton.AssociatedProduct.Price = dr.Price;
                ProdButton.AssociatedProduct.ProductID = dr.ProductID;
                ProdButton.AssociatedProduct.ProductTypeID = dr.ProductTypeId;

                ProdButton.Click += new ProductButton.ClickHandler(ProductButton_Click);
                //ProdButton.DoubleClick += new ProductButton.DoubleClickHandler(ProductButton_DoubleClick);

                if (dr.ProductTypeId == IDDRINK)
                    FLP_Drinks.Controls.Add(ProdButton);
                else if (dr.ProductTypeId == IDFOOD)
                    FLP_Food.Controls.Add(ProdButton);
            }
            TLP_Products.PerformLayout();
        }

        void ProductButton_DoubleClick(ProductButton prodButton)
        {
            if (null != prodButton)
            {
                m_Order.RemoveProducts(prodButton.AssociatedProduct);
            }
        }

        void ProductButton_Click(ProductButton prodButton)
        {
            if (null != prodButton)
            {
                m_Order.AddProduct(prodButton.AssociatedProduct);
            }
        }

        private void CashWork_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.digitalCashDeskDBDataSet.Product);
            this.tableTableAdapter.Fill(this.digitalCashDeskDBDataSet.Table);
            PerformProductLayout();
            PerformTableLayout();
        }

        private void TableButtonClicked(object sender, EventArgs e)
        {
            TableButton TableButton = sender as TableButton;

            if (TableButton != null)
            {
                TableButton.BackColor = Color.Gray; //System.Drawing.SystemColors.ButtonHighlight;

                if (null != m_LastTableButton)
                {
                    m_LastTableButton.BackColor = Color.Transparent;
                }

                m_LastTableButton = TableButton;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (null == m_LastTableButton)
            {
                MessageBox.Show("Bestellung einem Tisch zuordnen", "Kein Tisch ausgewählt");
                return;
            }

            KitchenPrintDocument cpd = new KitchenPrintDocument(m_Order, m_LastTableButton.AssociatedTable.NameOfTable);
            BarPrintDocument bpd = new BarPrintDocument(m_Order, m_LastTableButton.AssociatedTable.NameOfTable);

            //ReceiptPreviewer rP = new ReceiptPreviewer();

            //rP.ShowPrintDocumentWindow(cpd.GetPrintableDocument());
            //rP.ShowPrintDocumentWindow(bpd.GetPrintableDocument());

            m_OrderManager.AddOrderToTable(m_Order, m_LastTableButton.AssociatedTable);

            cpd.GetPrintableDocument().Print();
            bpd.GetPrintableDocument().Print();
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Table_Button_Paint(object sender, PaintEventArgs e)
        //{
        //    Rectangle BaseRectangle =
        //        new Rectangle(0, 0, this.Width - 1, this.Height - 1);

        //    Brush Gradient_Brush =
        //        new LinearGradientBrush(
        //        BaseRectangle,
        //        System.Drawing.SystemColors.ButtonShadow, System.Drawing.SystemColors.ButtonFace,
        //        LinearGradientMode.Vertical);

        //    e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        //}


        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    Rectangle BaseRectangle =
        //        new Rectangle(0, 0, this.Width - 1, this.Height - 1);
           
        //    Brush Gradient_Brush =
        //        new LinearGradientBrush(
        //        BaseRectangle,
        //        Color.Navy, Color.LightSlateGray,
        //        LinearGradientMode.Vertical);

        //    e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle);
        //}

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    // Invalidate, or last rendered image will just be scaled
        //    // to new size
        //    this.Invalidate();
        //} 
    }
}
