using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalCashDesk
{
    internal class TablePanel : Panel
    {
        Label TableName;
        Button ButtonOK;
        Button buttonAbort;
        ListBox OrderList;

        private const int PANELWIDTH = 187;
        private const int PANELHEIGHT = 95;
        private const int FORMLEFTMARGIN = 26;
        private const int FORMTOPMARGIN = 26;
        private const int PANELCOLUMNSPACING = 10;
        private const int PANELROWSPACING = 10;

        Font VerdanaBoldFont = new Font("Verdana", 12);
        private const int TABLENAMELEFT = 40;
        private const int TABLENAMETOP = 4;

        private const int BUTTONHEIGHT = 35;
        private const int BUTTONWIDTH = 35;
        private const int BUTTONLEFTMARGIN = 2;
        private const int BUTTONOKTOPMARGIN = 20;
        private const int BUTTONDELTOPMARGIN = 54;

        private const int ORDERLISTBOXLEFT = 43;
        private const int ORDERLISTBOXTOP = 20;
        private const int ORDERLISTBOXWIDTH = 139;
        private const int ORDERLISTBOXHEIGHT = 69;
        private string m_TableID;

        internal TablePanel(string NameOfTable)
        {
            m_TableID = NameOfTable;
            InitializeComponent(NameOfTable);
        }

        void InitializeComponent(string NameOfTable)
        {
            this.Width = PANELWIDTH;
            this.Height = PANELHEIGHT;

            TableName = new Label();
            TableName.AutoSize = true;
            TableName.Text = NameOfTable;
            TableName.Left = TABLENAMELEFT;
            TableName.Top = TABLENAMETOP;
            TableName.Font = VerdanaBoldFont;

            ButtonOK = new Button();
            ButtonOK.Left = BUTTONLEFTMARGIN;
            ButtonOK.Top = BUTTONOKTOPMARGIN;
            ButtonOK.Width = BUTTONWIDTH;
            ButtonOK.Height = BUTTONHEIGHT;
            ButtonOK.BackgroundImage = global::DigitalCashDesk.Properties.Resources.okSmall;
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.BackgroundImageLayout = ImageLayout.Zoom;

            ButtonAbort = new Button();
            ButtonAbort.Width = BUTTONWIDTH;
            ButtonAbort.Height = BUTTONHEIGHT;
            ButtonAbort.Top = BUTTONDELTOPMARGIN;
            ButtonAbort.Left = BUTTONLEFTMARGIN;
            ButtonAbort.BackgroundImage = global::DigitalCashDesk.Properties.Resources.deleteSmall;
            ButtonAbort.UseVisualStyleBackColor = true;
            ButtonAbort.BackgroundImageLayout = ImageLayout.Zoom;

            OrderList = new ListBox();
            OrderList.Top = ORDERLISTBOXTOP;
            OrderList.Left = ORDERLISTBOXLEFT;
            OrderList.Width = ORDERLISTBOXWIDTH;
            OrderList.Height = ORDERLISTBOXHEIGHT;
            OrderList.BackColor = SystemColors.ControlDarkDark;
            OrderList.ForeColor = SystemColors.ControlLightLight;
            OrderList.Text = string.Empty;

            this.Controls.Add(ButtonOK);
            this.Controls.Add(ButtonAbort);
            this.Controls.Add(OrderList);
            this.Controls.Add(TableName);
        }

        internal Button OKButton
        {
            get { return ButtonOK; }
            set { ButtonOK = value; }
        }

        internal Button ButtonAbort
        {
            get { return buttonAbort; }
            set { buttonAbort = value; }
        }

        internal ListBox TableText
        {
            get { return OrderList; }
            set { OrderList = value; }
        }

        internal string TableID
        {
            get { return m_TableID; }
        }
    }
}
