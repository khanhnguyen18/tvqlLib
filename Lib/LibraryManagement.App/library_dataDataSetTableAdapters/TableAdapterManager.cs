namespace LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters
{
    using LIBRARY_MANAGEMENT;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [DesignerCategory("code"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem(true), HelpKeyword("vs.data.TableAdapterManager")]
    public class TableAdapterManager : Component
    {
        private bool bool_0;
        private IDbConnection idbConnection_0;
        private LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblBookAttrTableAdapter tblBookAttrTableAdapter_0;
        private LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter_0;
        private LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblGoodsTableAdapter tblGoodsTableAdapter_0;
        private UpdateOrderOption updateOrderOption_0;

        static TableAdapterManager()
        {
            Class15.smethod_5();
        }

        public TableAdapterManager()
        {
            Class17.smethod_0();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
        {
            return ((this.idbConnection_0 != null) || (((this.Connection == null) || (inputConnection == null)) || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal)));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private int method_0(library_dataDataSet library_dataDataSet_0, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
        {
            DataRow[] rowArray;
            int num = 0;
            if (this.tblGoodsTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblGoods.Select(null, null, DataViewRowState.ModifiedCurrent);
                rowArray = this.method_3(rowArray, allAddedRows);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblGoodsTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this.tblBookAttrTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblBookAttr.Select(null, null, DataViewRowState.ModifiedCurrent);
                rowArray = this.method_3(rowArray, allAddedRows);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblBookAttrTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this.tblCustomerTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblCustomer.Select(null, null, DataViewRowState.ModifiedCurrent);
                rowArray = this.method_3(rowArray, allAddedRows);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblCustomerTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int method_1(library_dataDataSet library_dataDataSet_0, List<DataRow> allAddedRows)
        {
            DataRow[] rowArray;
            int num = 0;
            if (this.tblGoodsTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblGoods.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblGoodsTableAdapter_0.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this.tblBookAttrTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblBookAttr.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblBookAttrTableAdapter_0.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            if (this.tblCustomerTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblCustomer.Select(null, null, DataViewRowState.Added);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblCustomerTableAdapter_0.Update(rowArray);
                    allAddedRows.AddRange(rowArray);
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int method_2(library_dataDataSet library_dataDataSet_0, List<DataRow> allChangedRows)
        {
            DataRow[] rowArray;
            int num = 0;
            if (this.tblCustomerTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblCustomer.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblCustomerTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this.tblBookAttrTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblBookAttr.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblBookAttrTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            if (this.tblGoodsTableAdapter_0 != null)
            {
                rowArray = library_dataDataSet_0.tblGoods.Select(null, null, DataViewRowState.Deleted);
                if ((rowArray != null) && (0 < rowArray.Length))
                {
                    num += this.tblGoodsTableAdapter_0.Update(rowArray);
                    allChangedRows.AddRange(rowArray);
                }
            }
            return num;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private DataRow[] method_3(DataRow[] dataRow_0, List<DataRow> allAddedRows)
        {
            if ((dataRow_0 == null) || (dataRow_0.Length < 1))
            {
                return dataRow_0;
            }
            if ((allAddedRows == null) || (allAddedRows.Count < 1))
            {
                return dataRow_0;
            }
            List<DataRow> list = new List<DataRow>();
            for (int i = 0; i < dataRow_0.Length; i++)
            {
                DataRow item = dataRow_0[i];
                if (!allAddedRows.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
        {
            Array.Sort<DataRow>(rows, new Class5(relation, childFirst));
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(library_dataDataSet dataSet)
        {
            DataRow[] rowArray;
            int num2;
            DataRow row;
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (!dataSet.HasChanges())
            {
                return 0;
            }
            if (!((this.tblBookAttrTableAdapter_0 == null) || this.MatchTableAdapterConnection(this.tblBookAttrTableAdapter_0.SqlConnection_0)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this.tblCustomerTableAdapter_0 == null) || this.MatchTableAdapterConnection(this.tblCustomerTableAdapter_0.SqlConnection_0)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            if (!((this.tblGoodsTableAdapter_0 == null) || this.MatchTableAdapterConnection(this.tblGoodsTableAdapter_0.SqlConnection_0)))
            {
                throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
            }
            IDbConnection connection = this.Connection;
            if (connection == null)
            {
                throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
            }
            bool flag = false;
            if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
            {
                connection.Close();
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                flag = true;
            }
            IDbTransaction transaction = connection.BeginTransaction();
            if (transaction == null)
            {
                throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
            }
            List<DataRow> allChangedRows = new List<DataRow>();
            List<DataRow> allAddedRows = new List<DataRow>();
            List<DataAdapter> list3 = new List<DataAdapter>();
            Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
            int num = 0;
            DataSet set = null;
            if (this.BackupDataSetBeforeUpdate)
            {
                set = new DataSet();
                set.Merge(dataSet);
            }
            try
            {
                if (this.tblBookAttrTableAdapter_0 != null)
                {
                    dictionary.Add(this.tblBookAttrTableAdapter_0, this.tblBookAttrTableAdapter_0.SqlConnection_0);
                    this.tblBookAttrTableAdapter_0.SqlConnection_0 = (SqlConnection) connection;
                    this.tblBookAttrTableAdapter_0.SqlTransaction_0 = (SqlTransaction) transaction;
                    if (this.tblBookAttrTableAdapter_0.Adapter.AcceptChangesDuringUpdate)
                    {
                        this.tblBookAttrTableAdapter_0.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this.tblBookAttrTableAdapter_0.Adapter);
                    }
                }
                if (this.tblCustomerTableAdapter_0 != null)
                {
                    dictionary.Add(this.tblCustomerTableAdapter_0, this.tblCustomerTableAdapter_0.SqlConnection_0);
                    this.tblCustomerTableAdapter_0.SqlConnection_0 = (SqlConnection) connection;
                    this.tblCustomerTableAdapter_0.SqlTransaction_0 = (SqlTransaction) transaction;
                    if (this.tblCustomerTableAdapter_0.Adapter.AcceptChangesDuringUpdate)
                    {
                        this.tblCustomerTableAdapter_0.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this.tblCustomerTableAdapter_0.Adapter);
                    }
                }
                if (this.tblGoodsTableAdapter_0 != null)
                {
                    dictionary.Add(this.tblGoodsTableAdapter_0, this.tblGoodsTableAdapter_0.SqlConnection_0);
                    this.tblGoodsTableAdapter_0.SqlConnection_0 = (SqlConnection) connection;
                    this.tblGoodsTableAdapter_0.SqlTransaction_0 = (SqlTransaction) transaction;
                    if (this.tblGoodsTableAdapter_0.Adapter.AcceptChangesDuringUpdate)
                    {
                        this.tblGoodsTableAdapter_0.Adapter.AcceptChangesDuringUpdate = false;
                        list3.Add(this.tblGoodsTableAdapter_0.Adapter);
                    }
                }
                if (this.UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
                {
                    num += this.method_0(dataSet, allChangedRows, allAddedRows);
                    num += this.method_1(dataSet, allAddedRows);
                }
                else
                {
                    num += this.method_1(dataSet, allAddedRows);
                    num += this.method_0(dataSet, allChangedRows, allAddedRows);
                }
                num += this.method_2(dataSet, allChangedRows);
                transaction.Commit();
                if (0 < allAddedRows.Count)
                {
                    rowArray = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rowArray);
                    for (num2 = 0; num2 < rowArray.Length; num2++)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                    }
                }
                if (0 < allChangedRows.Count)
                {
                    rowArray = new DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rowArray);
                    num2 = 0;
                    while (num2 < rowArray.Length)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                        num2++;
                    }
                }
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                if (this.BackupDataSetBeforeUpdate)
                {
                    Debug.Assert(set != null);
                    dataSet.Clear();
                    dataSet.Merge(set);
                }
                else if (0 < allAddedRows.Count)
                {
                    rowArray = new DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rowArray);
                    num2 = 0;
                    while (num2 < rowArray.Length)
                    {
                        row = rowArray[num2];
                        row.AcceptChanges();
                        row.SetAdded();
                        num2++;
                    }
                }
                throw exception;
            }
            finally
            {
                if (flag)
                {
                    connection.Close();
                }
                if (this.tblBookAttrTableAdapter_0 != null)
                {
                    this.tblBookAttrTableAdapter_0.SqlConnection_0 = (SqlConnection) dictionary[this.tblBookAttrTableAdapter_0];
                    this.tblBookAttrTableAdapter_0.SqlTransaction_0 = null;
                }
                if (this.tblCustomerTableAdapter_0 != null)
                {
                    this.tblCustomerTableAdapter_0.SqlConnection_0 = (SqlConnection) dictionary[this.tblCustomerTableAdapter_0];
                    this.tblCustomerTableAdapter_0.SqlTransaction_0 = null;
                }
                if (this.tblGoodsTableAdapter_0 != null)
                {
                    this.tblGoodsTableAdapter_0.SqlConnection_0 = (SqlConnection) dictionary[this.tblGoodsTableAdapter_0];
                    this.tblGoodsTableAdapter_0.SqlTransaction_0 = null;
                }
                if (0 < list3.Count)
                {
                    DataAdapter[] array = new DataAdapter[list3.Count];
                    list3.CopyTo(array);
                    for (num2 = 0; num2 < array.Length; num2++)
                    {
                        DataAdapter adapter = array[num2];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return num;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public bool BackupDataSetBeforeUpdate
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
        public IDbConnection Connection
        {
            get
            {
                if (this.idbConnection_0 != null)
                {
                    return this.idbConnection_0;
                }
                if ((this.tblBookAttrTableAdapter_0 != null) && (this.tblBookAttrTableAdapter_0.SqlConnection_0 != null))
                {
                    return this.tblBookAttrTableAdapter_0.SqlConnection_0;
                }
                if ((this.tblCustomerTableAdapter_0 != null) && (this.tblCustomerTableAdapter_0.SqlConnection_0 != null))
                {
                    return this.tblCustomerTableAdapter_0.SqlConnection_0;
                }
                if ((this.tblGoodsTableAdapter_0 != null) && (this.tblGoodsTableAdapter_0.SqlConnection_0 != null))
                {
                    return this.tblGoodsTableAdapter_0.SqlConnection_0;
                }
                return null;
            }
            set
            {
                this.idbConnection_0 = value;
            }
        }

        [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int TableAdapterInstanceCount
        {
            get
            {
                throw -559038242;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblBookAttrTableAdapter tblBookAttrTableAdapter
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.tblBookAttrTableAdapter_0 = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode]
        public LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.tblCustomerTableAdapter_0 = value;
            }
        }

        [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters.tblGoodsTableAdapter tblGoodsTableAdapter
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.tblGoodsTableAdapter_0 = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public UpdateOrderOption UpdateOrder
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.updateOrderOption_0 = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class Class5 : IComparer<DataRow>
        {
            private DataRelation dataRelation_0;
            private int int_0;

            static Class5()
            {
                Class15.smethod_5();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class5(DataRelation dataRelation_1, bool bool_0)
            {
                Class17.smethod_0();
                this.dataRelation_0 = dataRelation_1;
                if (bool_0)
                {
                    this.int_0 = -1;
                }
                else
                {
                    this.int_0 = 1;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Compare(DataRow x, DataRow y)
            {
                if (object.ReferenceEquals(x, y))
                {
                    return 0;
                }
                if (x == null)
                {
                    return -1;
                }
                if (y != null)
                {
                    int num2 = 0;
                    DataRow objA = this.method_0(x, out num2);
                    int num3 = 0;
                    DataRow objB = this.method_0(y, out num3);
                    if (object.ReferenceEquals(objA, objB))
                    {
                        return (this.int_0 * num2.CompareTo(num3));
                    }
                    Debug.Assert((objA.Table != null) && (objB.Table != null));
                    if (objA.Table.Rows.IndexOf(objA) < objB.Table.Rows.IndexOf(objB))
                    {
                        return -1;
                    }
                }
                return 1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private DataRow method_0(DataRow dataRow_0, out int int_1)
            {
                // This item is obfuscated and can not be translated.
                Debug.Assert(dataRow_0 != null);
                DataRow row = dataRow_0;
                int_1 = 0;
                IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
                dictionary[dataRow_0] = dataRow_0;
                for (DataRow parentRow = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Default); parentRow == null; parentRow = parentRow.GetParentRow(this.dataRelation_0, DataRowVersion.Default))
                {
                    if (0 == 0)
                    {
                        if (int_1 != 0)
                        {
                            return row;
                        }
                        dictionary.Clear();
                        dictionary[dataRow_0] = dataRow_0;
                        parentRow = dataRow_0.GetParentRow(this.dataRelation_0, DataRowVersion.Original);
                        while (parentRow == null)
                        {
                            if (0 == 0)
                            {
                                return row;
                            }
                            int_1++;
                            row = parentRow;
                            dictionary[parentRow] = parentRow;
                            parentRow = parentRow.GetParentRow(this.dataRelation_0, DataRowVersion.Original);
                        }
                        goto Label_0098;
                    }
                    int_1++;
                    row = parentRow;
                    dictionary[parentRow] = parentRow;
                }
                goto Label_0034;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {
            InsertUpdateDelete,
            UpdateInsertDelete
        }
    }
}

