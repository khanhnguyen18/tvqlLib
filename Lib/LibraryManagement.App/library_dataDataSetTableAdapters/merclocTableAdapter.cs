using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LibraryManagement.App
{

    

    [DesignerCategory("code"), DataObject(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem(true), HelpKeyword("vs.data.TableAdapter")]
    public class merclocTableAdapter : Component
    {
        private bool kCnalMegv;
        private SqlCommand[] sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private SqlTransaction sqlTransaction_0;

        static merclocTableAdapter()
        {
            Class15.smethod_5();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public merclocTableAdapter()
        {
            Class17.smethod_0();
            this.ClearBeforeFill = true;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true)]
        public virtual int Fill(library_dataDataSet.merclocDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [DataObjectMethod(DataObjectMethodType.Fill, false), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int FillBy(library_dataDataSet.merclocDataTable dataTable, string locid, string stkid)
        {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if (locid == null)
            {
                throw new ArgumentNullException("locid");
            }
            this.Adapter.SelectCommand.Parameters[0].Value = locid;
            if (stkid == null)
            {
                throw new ArgumentNullException("stkid");
            }
            this.Adapter.SelectCommand.Parameters[1].Value = stkid;
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual library_dataDataSet.merclocDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            library_dataDataSet.merclocDataTable dataTable = new library_dataDataSet.merclocDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, false)]
        public virtual library_dataDataSet.merclocDataTable GetDataBy(string locid, string stkid)
        {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            if (locid == null)
            {
                throw new ArgumentNullException("locid");
            }
            this.Adapter.SelectCommand.Parameters[0].Value = locid;
            if (stkid == null)
            {
                throw new ArgumentNullException("stkid");
            }
            this.Adapter.SelectCommand.Parameters[1].Value = stkid;
            library_dataDataSet.merclocDataTable dataTable = new library_dataDataSet.merclocDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_0()
        {
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "mercloc"
            };
            mapping.ColumnMappings.Add("goods_id", "goods_id");
            mapping.ColumnMappings.Add("full_name", "full_name");
            mapping.ColumnMappings.Add("grp_id", "grp_id");
            mapping.ColumnMappings.Add("image", "image");
            mapping.ColumnMappings.Add("check", "check");
            this.sqlDataAdapter_0.TableMappings.Add(mapping);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_1()
        {
            this.sqlConnection_0 = new SqlConnection();
            this.sqlConnection_0.ConnectionString = Settings.Default.libraryConn;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_2()
        {
            this.sqlCommand_0 = new SqlCommand[2];
            this.sqlCommand_0[0] = new SqlCommand();
            this.sqlCommand_0[0].Connection = this.SqlConnection_0;
            this.sqlCommand_0[0].CommandText = "SELECT     gs.goods_id, gs.full_name, gs.grp_id, gs.image, loc.[check]\r\nFROM         tblGoods AS gs LEFT OUTER JOIN\r\n                      tblMercLocation AS loc ON gs.goods_id = loc.goods_id\r\nWHERE gs.status = 1";
            this.sqlCommand_0[0].CommandType = CommandType.Text;
            this.sqlCommand_0[1] = new SqlCommand();
            this.sqlCommand_0[1].Connection = this.SqlConnection_0;
            this.sqlCommand_0[1].CommandText = "SELECT     gs.goods_id, gs.full_name, gs.grp_id, gs.image, loc.[check]\r\nFROM         tblGoods AS gs LEFT OUTER JOIN\r\n                     (SELECT * FROM  tblMercLocation WHERE loc_id = @locid AND stk_id = @stkid)  AS loc ON gs.goods_id = loc.goods_id\r\nWHERE gs.status = 1 ";
            this.sqlCommand_0[1].CommandType = CommandType.Text;
            this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@locid", SqlDbType.NVarChar, 4, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@stkid", SqlDbType.NVarChar, 5, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, false, null, "", "", ""));
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected internal SqlDataAdapter Adapter
        {
            get
            {
                if (this.sqlDataAdapter_0 == null)
                {
                    this.method_0();
                }
                return this.sqlDataAdapter_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public bool ClearBeforeFill
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.kCnalMegv = value;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected SqlCommand[] CommandCollection
        {
            get
            {
                if (this.sqlCommand_0 == null)
                {
                    this.method_2();
                }
                return this.sqlCommand_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal SqlConnection SqlConnection_0
        {
            get
            {
                if (this.sqlConnection_0 == null)
                {
                    this.method_1();
                }
                return this.sqlConnection_0;
            }
            set
            {
                this.sqlConnection_0 = value;
                if (this.Adapter.InsertCommand != null)
                {
                    this.Adapter.InsertCommand.Connection = value;
                }
                if (this.Adapter.DeleteCommand != null)
                {
                    this.Adapter.DeleteCommand.Connection = value;
                }
                if (this.Adapter.UpdateCommand != null)
                {
                    this.Adapter.UpdateCommand.Connection = value;
                }
                for (int i = 0; i < this.CommandCollection.Length; i++)
                {
                    if (this.CommandCollection[i] != null)
                    {
                        this.CommandCollection[i].Connection = value;
                    }
                }
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal SqlTransaction SqlTransaction_0
        {
            get
            {
                throw -559038242;
            }
            set
            {
                this.sqlTransaction_0 = value;
                for (int i = 0; i < this.CommandCollection.Length; i++)
                {
                    this.CommandCollection[i].Transaction = this.sqlTransaction_0;
                }
                if ((this.Adapter != null) && (this.Adapter.DeleteCommand != null))
                {
                    this.Adapter.DeleteCommand.Transaction = this.sqlTransaction_0;
                }
                if ((this.Adapter != null) && (this.Adapter.InsertCommand != null))
                {
                    this.Adapter.InsertCommand.Transaction = this.sqlTransaction_0;
                }
                if ((this.Adapter != null) && (this.Adapter.UpdateCommand != null))
                {
                    this.Adapter.UpdateCommand.Transaction = this.sqlTransaction_0;
                }
            }
        }
    }
}

