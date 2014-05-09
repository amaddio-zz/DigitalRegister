using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DigitalCashDesk
{
    internal class Order : ICloneable
    {
        public event OrderSum OrderSumChanged;
        public delegate void OrderSum(decimal OrderAmount);

        private void OnOrderSumChanged(decimal OrderAmount)
        {
            if (OrderSumChanged != null)
                OrderSumChanged(OrderAmount);
        }

        Dictionary<Product, int> m_BoughtProducts;
        //Table m_CustomerPosition;
        decimal m_OrderSum;

        internal Order()
        {
            m_BoughtProducts = new Dictionary<Product, int>();
        }

        internal Dictionary<Product, int> BoughtProducts
        {
            get { return m_BoughtProducts; }
        }

        /// <summary>
        /// Returns the counted amount of ordered products e.g. 4 for 4 Cokes
        /// </summary>
        internal int amountBoughtProducts
        {
            get
            {
                int amountBoughtProducts = 0;
                // we have to add up the orders. There might be duplicate bookings. e.g. 4 Cokes
                foreach (KeyValuePair<Product,int> p in m_BoughtProducts)
                {
                    amountBoughtProducts += p.Value;
                }

                return amountBoughtProducts;
            }
        }

        internal void AddProduct(Product ToAddProduct)
        {
            if (m_BoughtProducts.ContainsKey(ToAddProduct))
            {
                m_BoughtProducts[ToAddProduct]++;
            }
            else
            {
                m_BoughtProducts.Add(ToAddProduct, 1);
            }

            m_OrderSum += ToAddProduct.Price;
            OnOrderSumChanged(m_OrderSum);
        }

        public void RemoveProduct(Product ToRemoveProduct)
        {
            if (m_BoughtProducts.ContainsKey(ToRemoveProduct))
            {
                // delete the entire product from the list if there is only one left
                if (1 == m_BoughtProducts[ToRemoveProduct])
                {
                    m_BoughtProducts.Remove(ToRemoveProduct);
                }
                // we can't have negative amount of products in our orders
                else if (0 < m_BoughtProducts[ToRemoveProduct]) 
                {
                    m_BoughtProducts[ToRemoveProduct]--;
                }
                else
                {
                    throw new NotImplementedException("whateeefuuuuuck");
                    return;
                }

                m_OrderSum -= ToRemoveProduct.Price;
                OnOrderSumChanged(m_OrderSum);
            }
        }

        public decimal GetOrderSum
        {
            get
            {
                return m_OrderSum;
            }
        }

        //public Table CustomerPosition
        //{
        //    get { return m_CustomerPosition; }
        //    set { m_CustomerPosition = value; }
        //}

        internal void RemoveProducts(Product product)
        {
            //for (int i = 0; i < m_BoughtProducts.Count; i++)
            //{
            //    if (m_BoughtProducts[i].Name == product.Name)
            //    {
            //        m_OrderSum -= m_BoughtProducts[i].Price;
            //        m_BoughtProducts.Remove(m_BoughtProducts[i]);
            //        i--;
            //    }
            //}

            if (m_BoughtProducts.ContainsKey(product))
            {
                m_OrderSum -= (product.Price * m_BoughtProducts[product]);
                m_BoughtProducts.Remove(product);
            }

            OnOrderSumChanged(m_OrderSum);
        }

        #region ICloneable Members

        public object Clone()
        {
            Order clone = new Order();
            foreach (KeyValuePair<Product,int> toCopyProduct in this.BoughtProducts)
            {
                for (int i = 0; i < toCopyProduct.Value; i++)
                {
                    clone.AddProduct(toCopyProduct.Key);
                }
            }

            return clone;
        }

        #endregion
    }
}
