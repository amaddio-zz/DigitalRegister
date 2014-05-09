//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//namespace DigitalCashDesk
//{
//    public partial class OrderedProducts : Form
//    {
//        decimal AmountFood;
//        decimal AmountDrinks;

//        public OrderedProducts()
//        {
//            InitializeComponent();

//            dTP_Von.Value = DateTime.Today;
//            dTP_Bis.Value = DateTime.Today;

//            //boughtProductsTableAdapter.Fill(digitalCashDeskDBDataSet.BoughtProducts);
//            productTableAdapter.Fill(digitalCashDeskDBDataSet.Product);

//            FillDataGrid();
//            UpdateGUIValues();
//        }

//        private void UpdateGUIValues()
//        {
//            lbl_GetraenkeTotal.Text = AmountDrinks.ToString();
//            lbl_SpeisenTotal.Text = AmountFood.ToString();

//            lbl_Total.Text = Convert.ToString(AmountDrinks + AmountFood);
//        }

//        private void FillDataGrid()
//        {
//            dGV_OrderedProducts.Rows.Clear();
//            AmountFood = 0;
//            AmountDrinks = 0;

//            for (int i = 0; i < digitalCashDeskDBDataSet.BoughtProducts.Count; i++)
//            {
//                if (IsWithinTimeRange(digitalCashDeskDBDataSet.BoughtProducts[i].OrderDate))
//                {
//                    string ProdName = GetProductName(digitalCashDeskDBDataSet.BoughtProducts[i].ProductID);
//                    decimal Price = GetPrice(digitalCashDeskDBDataSet.BoughtProducts[i].ProductID);

//                    dGV_OrderedProducts.Rows.Add(ProdName,
//                                                 Price,
//                                                 digitalCashDeskDBDataSet.BoughtProducts[i].OrderDate);

//                    if (IsFood(digitalCashDeskDBDataSet.BoughtProducts[i].ProductID))
//                    {
//                        AmountFood += Price;
//                    }
//                    else
//                    {
//                        AmountDrinks += Price;
//                    }
//                }
//            }
//        }

//        private bool IsWithinTimeRange(DateTime orderDate)
//        {
//            if (dTP_Von.Value.Date <= orderDate.Date && dTP_Bis.Value.Date >= orderDate.Date)
//                return true;
//            else
//                return false;
//        }

//        private bool IsFood(int ProductID)
//        {
//            for (int i = 0; i < digitalCashDeskDBDataSet.Product.Count; i++)
//            {
//                if (digitalCashDeskDBDataSet.Product[i].ProductID.Equals(ProductID))
//                {
//                    if (digitalCashDeskDBDataSet.Product[i].ProductTypeId.Equals(Product.IDFOOD))
//                        return true;
//                    else
//                        return false;
//                }
//            }

//            return false;
//        }

//        private decimal GetPrice(int ProductID)
//        {
//            for (int i = 0; i < digitalCashDeskDBDataSet.Product.Count; i++)
//            {
//                if (digitalCashDeskDBDataSet.Product[i].ProductID.Equals(ProductID))
//                {
//                    return digitalCashDeskDBDataSet.Product[i].Price;
//                }
//            }

//            return 0;
//        }

//        private string GetProductName(int ProductID)
//        {
//            for (int i = 0; i < digitalCashDeskDBDataSet.Product.Count; i++)
//            {
//                if (digitalCashDeskDBDataSet.Product[i].ProductID.Equals(ProductID))
//                {
//                    return digitalCashDeskDBDataSet.Product[i].Name;
//                }
//            }

//            return string.Empty;
//        }

//        private void btn_Update_Click(object sender, EventArgs e)
//        {
//            FillDataGrid();
//            UpdateGUIValues();
//        }

//        private void btn_Close_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}
