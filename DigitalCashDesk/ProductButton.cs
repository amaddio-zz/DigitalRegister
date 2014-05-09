using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DigitalCashDesk
{
    public class ProductButton : Button
    {
        Product m_Product;
        int m_AmountHits;
        bool m_NeedToCustomPaint;
        int previousClick;
        bool m_countUpwards;

        //public delegate void DoubleClickHandler(ProductButton prodButton);
        //public new event DoubleClickHandler DoubleClick;

        public delegate void ClickHandler(ProductButton prodButton);
        public new event ClickHandler Click;

        //public new void OnDoubleClick(ProductButton prodButton)
        //{
        //    if (null != DoubleClick)
        //        DoubleClick(prodButton);
        //}

        public new void OnClick(ProductButton prodButton)
        {
            if (null != Click)
                Click(prodButton);
        }

        public ProductButton()
        {
            m_Product = new Product();
            m_countUpwards = true;
            base.Click += new EventHandler(ProductButton_Click);
        }

        public ProductButton(int buttonPreselected)
        {
            m_AmountHits = buttonPreselected;
            m_countUpwards = true;
            highlightButton();
            m_NeedToCustomPaint = true;

            m_Product = new Product();
            base.Click += new EventHandler(ProductButton_Click);
        }

        void ProductButton_Click(object sender, EventArgs e)
        {
            // old double click functionality, keep here in case it shall get reactivated
            //int now = System.Environment.TickCount;
            //if (now - previousClick <= SystemInformation.DoubleClickTime)

            // count upwards or downwards onClick
            if(m_countUpwards)
            {
                IncrementGuiCounter();
            }
            else
            {
                DecrementGuiCounter();
                //OnDoubleClick(this);
            }

            OnClick(this);

            //previousClick = now;

            this.Invalidate();
        }

        void DecrementGuiCounter()
        {
            if (0 == m_AmountHits) 
            {
                // wrong call
                return;
            }
            else if (1 == m_AmountHits)
            {
                m_NeedToCustomPaint = false;
                this.BackColor = Color.Transparent;
            }
            
            m_AmountHits--;
        }

        void resetButton()
        {
            m_NeedToCustomPaint = false;
            this.BackColor = Color.Transparent;
            m_AmountHits = 0;
        }

        void IncrementGuiCounter()
        {
            m_AmountHits++;
            highlightButton();
            m_NeedToCustomPaint = true;
        }

        void highlightButton() 
        {
            this.BackColor = Color.Gray;
        }

        public Product AssociatedProduct
        {
            get { return m_Product; }
            set { m_Product = value; }
        }

        public int AmountHits
        {
            get { return m_AmountHits; }
            set { m_AmountHits = value; }
        }

        public bool CountUpwards 
        {
            get { return m_countUpwards; }
            set { m_countUpwards = value; }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (m_NeedToCustomPaint)
            {
                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                RectangleF rf = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(AmountHits.ToString(), new Font("tahoma", 10.0f), Brushes.White, rf, sf);
            }
            //if (mousedown == false)
            //{
            //    Graphics g = pevent.Graphics;
            //    g.SmoothingMode = SmoothingMode.AntiAlias;
            //    Rectangle outerRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //    Rectangle innerRectangle = new Rectangle(1, 1, this.Width - 3, this.Height - 3);
            //    Pen pen1 = new Pen(Color.FromArgb(183, 183, 183));
            //    Pen pen2 = new Pen(Color.FromArgb(255, 255, 255));
            //    LinearGradientBrush lgb1 = new LinearGradientBrush(outerRectangle, Color.FromArgb(255, 247, 247, 247), Color.FromArgb(255, 219, 219, 219), LinearGradientMode.Vertical);
            //    g.FillRectangle(lgb1, outerRectangle);
            //    g.DrawRectangle(pen1, outerRectangle);
            //    g.DrawRectangle(pen2, innerRectangle);

            //    SolidBrush Brush = new SolidBrush(Color.FromArgb(84, 125, 190));
            //    RectangleF rf = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            //    StringFormat sf = new StringFormat();
            //    sf.Alignment = StringAlignment.Center;
            //    sf.LineAlignment = StringAlignment.Center;

            //    g.DrawString(this.Text, new Font("tahoma", 10.0f), Brush, rf, sf);
            //}

            //else
            //{
            //    Graphics g = pevent.Graphics;
            //    g.SmoothingMode = SmoothingMode.AntiAlias;
            //    Rectangle outerRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //    Rectangle innerRectangle = new Rectangle(1, 1, this.Width - 3, this.Height - 3);
            //    Pen pen1 = new Pen(Color.FromArgb(183, 183, 183));
            //    Pen pen2 = new Pen(Color.FromArgb(255, 255, 255));
            //    LinearGradientBrush lgb1 = new LinearGradientBrush(outerRectangle, Color.FromArgb(255, 204, 204, 204), Color.FromArgb(255, 243, 243, 243), LinearGradientMode.Vertical);
            //    g.FillRectangle(lgb1, outerRectangle);
            //    g.DrawRectangle(pen1, outerRectangle);
            //    g.DrawRectangle(pen2, innerRectangle);

            //    SolidBrush Brush = new SolidBrush(Color.FromArgb(84, 125, 190));
            //    RectangleF rf = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            //    StringFormat sf = new StringFormat();
            //    sf.Alignment = StringAlignment.Center;
            //    sf.LineAlignment = StringAlignment.Center;

            //    g.DrawString(this.Text, new Font("tahoma", 10.0f), Brush, rf, sf);
            //}


            //if (mouseenter == true)
            //{
            //    Graphics g = pevent.Graphics;
            //    g.SmoothingMode = SmoothingMode.AntiAlias;
            //    Rectangle outerRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //    Rectangle innerRectangle = new Rectangle(1, 1, this.Width - 3, this.Height - 3);
            //    Pen pen1 = new Pen(Color.FromArgb(84, 125, 190));
            //    Pen pen2 = new Pen(Color.FromArgb(255, 255, 255));
            //    LinearGradientBrush lgb1 = new LinearGradientBrush(outerRectangle, Color.FromArgb(255, 247, 247, 247), Color.FromArgb(255, 219, 219, 219), LinearGradientMode.Vertical);
            //    g.FillRectangle(lgb1, outerRectangle);
            //    g.DrawRectangle(pen1, outerRectangle);
            //    g.DrawRectangle(pen2, innerRectangle);

            //    SolidBrush Brush = new SolidBrush(Color.FromArgb(84, 125, 190));
            //    RectangleF rf = new RectangleF(0, 0, this.Width - 1, this.Height - 1);
            //    StringFormat sf = new StringFormat();
            //    sf.Alignment = StringAlignment.Center;
            //    sf.LineAlignment = StringAlignment.Center;

            //    g.DrawString(this.Text, new Font("tahoma", 10.0f), Brush, rf, sf);
            //    mouseenter = false;
            //}
        }

        //protected override void OnMouseDown(MouseEventArgs mevent)
        //{
        //    this.mousedown = true;
        //    base.OnMouseDown(mevent);
        //}

        //protected override void OnMouseUp(MouseEventArgs mevent)
        //{
        //    this.mousedown = false;
        //    base.OnMouseUp(mevent);
        //}

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    this.mouseenter = true;
        //    base.OnMouseEnter(e);
        //}
    }
}
