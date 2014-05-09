using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalCashDesk
{
    public class Product : IEquatable<Product>
    {
        public const int IDCAFE = 4;
        public const int IDHEISS = 5;
        public const int IDKALT = 6;
        public const int IDCOCKTAIL = 7;
        public const int IDFOOD = 8;
        public const int IDDIVERS = 9;

        private string m_Name;
        private decimal m_Price;
        private int m_ProductID;
        private int m_ProductTypeID;

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public decimal Price
        {
            get { return m_Price; }
            set { m_Price = value; }
        }

        public int ProductID
        {
            get { return m_ProductID; }
            set { m_ProductID = value; }
        }

        public int ProductTypeID
        {
            get { return m_ProductTypeID; }
            set { m_ProductTypeID = value; }
        }

        public override bool Equals(object obj)
        {
            return productCompare(obj, this);
        }

        #region IEquatable<Product> Members

        public bool Equals(Product other)
        {
            return productCompare(other, this);
        }

        #endregion

        public static bool productCompare(object o, Product p) 
        {
            Product otherProduct = o as Product;
            if (null != otherProduct)
            {
                if (otherProduct.m_ProductID == p.m_ProductID)
                {
                    return true;
                }
            }

            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.m_ProductID;
        }
    }
}
