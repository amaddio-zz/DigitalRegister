using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DigitalCashDesk
{
    internal sealed class OrderManager
    {
        private static OrderManager m_singleton;
        private Dictionary<string, Table> m_AllTables;
        //private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.BoughtProductsTableAdapter BoughtproductsTableAdapter;
        private DigitalCashDeskDBDataSet digitalcashdeskdbdataset;
        private DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;

        internal delegate void TableOrderChangedEventArgs(Table t);
        internal event TableOrderChangedEventArgs TableOrderChanged;

        private void OnTableOrderChanged(Table t)
        {
            if (null != TableOrderChanged)
                TableOrderChanged(t);
        }

        //internal delegate void OrderPayed(Order o);
        //internal event OrderPayed OrderPayment;

        //private void OnOrderPayment(Order o)
        //{
        //    if (null != OrderPayment)
        //        OrderPayment(o);
        //}

        private OrderManager()
        {
            m_AllTables = new Dictionary<string, Table>();
            digitalcashdeskdbdataset = new DigitalCashDeskDBDataSet();
            //BoughtproductsTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.BoughtProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(digitalcashdeskdbdataset)).BeginInit();

            digitalcashdeskdbdataset.DataSetName = "DigitalCashDeskDBDataSet";
            digitalcashdeskdbdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            ((System.ComponentModel.ISupportInitialize)(digitalcashdeskdbdataset)).EndInit();
            
            initTables();
        }

        internal static OrderManager Instance
        {
            get 
            {
                if (null == m_singleton)
                    m_singleton = new OrderManager();

                return m_singleton;
            }
        }

        private void initTables()
        {
            this.tableTableAdapter = new DigitalCashDesk.DigitalCashDeskDBDataSetTableAdapters.TableTableAdapter();
            this.tableTableAdapter.ClearBeforeFill = true;
            this.tableTableAdapter.Fill(digitalcashdeskdbdataset.Table);

            //DigitalCashDeskDBDataSet.TableDataTable foo = digitalcashdeskdbdataset.Table;
            foreach (DigitalCashDeskDBDataSet.TableRow o in digitalcashdeskdbdataset.Table.Rows)
            {
                if (false == m_AllTables.ContainsKey(o.TableId))
                {
                    Table newTable = new Table();
                    newTable.NameOfTable = o.TableId;
                    newTable.Seats = Convert.ToInt32(o.AmountSeats);
                    m_AllTables.Add(o.TableId, newTable);
                }
            }
        }

        /// <summary>
        /// simply replace the existing order with the overgiven one
        /// </summary>
        /// <param name="o"></param>
        /// <param name="table"></param>
        internal void UpdateOrdersOnTable(Order o, Table table)
        {
            Table FoundTable = null;

            m_AllTables.TryGetValue(table.NameOfTable, out FoundTable);

            if (null == FoundTable)
            {
                // if the table does not exist we simple assign the overgiven order
                // we assume that this is the initial order on this table
                table.Orders = o;
                m_AllTables.Add(table.NameOfTable, table);
            }
            else
            {
                m_AllTables[table.NameOfTable].Orders = o;
            }

            OnTableOrderChanged(m_AllTables[table.NameOfTable]);
        }

        internal void AddOrderToTable(Order o, Table table)
        {
            Table FoundTable = null;

            m_AllTables.TryGetValue(table.NameOfTable, out FoundTable);

            if (null == FoundTable)
            {
                // if the table does not exist we simple assign the overgiven order
                // we assume that this is the initial order on this table
                table.Orders = o;
                m_AllTables.Add(table.NameOfTable, table);
            }
            else
            {
                //FoundTable.Orders = o;
                foreach (KeyValuePair<Product, int> p in o.BoughtProducts)
                {
                    //m_AllTables[table.NameOfTable].Orders.BoughtProducts.Add(p.Key, p.Value);
                    //FoundTable.Orders.BoughtProducts.Add(p.Key, p.Value);
                    for (int i = 0; i < p.Value; i++)
                    {
                        FoundTable.Orders.AddProduct(p.Key);
                    }
                }
            }

            OnTableOrderChanged(m_AllTables[table.NameOfTable]);
        }

        //internal void DeleteOrder(Order o, Table table)
        //{
            
        //    for (int i = 0; i < m_AllTables.Count; i++)
        //    {
        //        if (m_AllTables[i].NameOfTable == table.NameOfTable)
        //        {
        //            m_AllTables[i].Orders.Remove(o);
        //        }
        //    }

        //    OnTableOrderPlacement(
        //}

        internal void PayCompleteOrder(string TableID)
        {
            if (m_AllTables.ContainsKey(TableID))
            {
                //foreach (Order o in m_AllTables[TableID].Orders)
                //{
                //    foreach (KeyValuePair<Product, int> p in o.BoughtProducts)
                //    {
                //        for (int h = 0; h < p.Value; h++)
                //        {
                //            BoughtproductsTableAdapter.Insert(DateTime.Now, p.Key.ProductID);
                //            BoughtproductsTableAdapter.Update(digitalcashdeskdbdataset);
                //            digitalcashdeskdbdataset.AcceptChanges();
                //        }
                //    }
                //}

                // we allocate a new empty object and overwrite the current one
                //m_AllTables[TableID].Orders = new Order();

                OnTableOrderChanged(m_AllTables[TableID]);
            }
        }

        internal Table GetTable(string TableID)
        {
            Table retTable = null;

            m_AllTables.TryGetValue(TableID, out retTable);

            return retTable;
        }

        internal List<string> GetTableNames() 
        {
            //List<string> tableNames = new List<string>();
            //foreach (KeyValuePair<string,Table> t in m_AllTables)
            //{
            //    tableNames.Add(t.Key);
            //}
            return m_AllTables.Keys.ToList();
            //return tableNames;
        }

        internal void DeleteTableOrders(Table table)
        {
            //Table intendetTable = null;
            
            //for (int i = 0; i < m_AllTables.Count; i++)
            //{
            //    if (m_AllTables[i].NameOfTable == table.NameOfTable)
            //    {
            //        m_AllTables[i].Orders.Clear();
            //        intendetTable = m_AllTables[i];
            //    }
            //}

            if (null != table)
                table.Orders = new Order();

            //if (m_AllTables.TryGetValue(table.NameOfTable, out intendetTable))
            //{
                
            //}

            if (null != table)
                OnTableOrderChanged(table);
        }

        internal void DeleteTableOrders(string TableID)
        {
            Table FoundTable = null;

            //for (int i = 0; i < m_AllTables.Count; i++)
            //{
            //    if (m_AllTables[i].NameOfTable == TableID)
            //    {
            //        FoundTable = m_AllTables[i];
            //    }
            //}

            m_AllTables.TryGetValue(TableID, out FoundTable);
            

            if (null != FoundTable)
                DeleteTableOrders(FoundTable);
        }
    }
}