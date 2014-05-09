using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    public partial class CashMainMdi : Form
    {
        TableOrderOverview m_OrderOverview;
        NewOrder m_OrderWindow;

        public CashMainMdi()
        {
            InitializeComponent();
        }

        void tableOnOverviewClicked(TablePanel tablePanel)
        {
            ShowNewForm(tablePanel.TableID);
        }

        private void ShowNewForm()
        {
            ShowNewForm(null);
        }

        private void ShowNewForm(string tableID)
        {
            //tSB_addDiverseButton.Enabled = true;
            tSB_deleteItemFromOrder.Enabled = true;
            
            m_OrderWindow = new NewOrder(tSB_deleteItemFromOrder, tableID);
            m_OrderWindow.MdiParent = this;
            m_OrderWindow.Show();

            m_OrderWindow.Disposed += new EventHandler(BestellungsfensterGeschlossen);
        }

        private void ShowNewFormButtonHandler(object sender, EventArgs e)
        {
            ShowNewForm();
        }

        void BestellungsfensterGeschlossen(object sender, EventArgs e)
        {
            bool Found = false;

            foreach (Form f in this.MdiChildren)
            {
                if (typeof(NewOrder) == f.GetType())
                {
                    Found = true;
                    break;
                }
            }

            //tSB_addDiverseButton.Enabled = Found;
            tSB_deleteItemFromOrder.Enabled = Found;
            tSB_deleteItemFromOrder.Checked = false;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CashMainMdi_Shown(object sender, EventArgs e)
        {
            //CashConfig.Instance.MdiParent = this;
            CashConfigWithTabs.Instance.MdiParent = this;

            m_OrderOverview = new TableOrderOverview();
            m_OrderOverview.MdiParent = this;
            m_OrderOverview.tableClicked += new TableOrderOverview.tablePanelClickhandler(tableOnOverviewClicked);
            
            m_OrderOverview.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashConfigWithTabs.Instance.MdiParent = this;
            CashConfigWithTabs.Instance.Show();
        }

        //private void bestellübersichtToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OrderedProducts oProducts = new OrderedProducts();
        //    oProducts.MdiParent = this;

        //    oProducts.Show();
        //}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Wollen Sie die Anwendung wirklich schliessen?","Beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == dr)
                this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (null != m_OrderOverview)
                m_OrderOverview.BringToFront();
            else
            {
                m_OrderOverview = new TableOrderOverview();
                m_OrderOverview.MdiParent = this;
                m_OrderOverview.WindowState = FormWindowState.Maximized;

                m_OrderOverview.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (null != m_OrderWindow)
                m_OrderWindow.AddDiverseButton();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // it might be interesting to open several calculator windows
            // you might end up doing split bills in to seperate window

            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            // catch all exception because the opening of calc may not end the
            // main application
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler aufgetreten");
            }

            /*if (null == m_Calc)
            {
                m_Calc = new _Calculator();
                m_Calc.Show();
            }
            else
            {
                m_Calc.Close();
                if (m_Calc != null)
                    m_Calc = null;
            }*/
        }

        private void deleteItemFromOrderToggleButton_Click(object sender, EventArgs e) 
        {
            if (tSB_deleteItemFromOrder.Checked)
            {
                tSB_deleteItemFromOrder.Font = new Font(tSB_deleteItemFromOrder.Font, FontStyle.Bold & FontStyle.Underline);
                tSB_deleteItemFromOrder.Text = "! " + tSB_deleteItemFromOrder.Text + " !";
            }
            else
            {
                tSB_deleteItemFromOrder.Font = new Font(tSB_deleteItemFromOrder.Font, FontStyle.Regular);
                tSB_deleteItemFromOrder.Text = tSB_deleteItemFromOrder.Text.Trim();
                tSB_deleteItemFromOrder.Text = tSB_deleteItemFromOrder.Text.Replace("!", "");
            }
        }
    }
}