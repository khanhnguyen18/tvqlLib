namespace LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters
{
    using LIBRARY_MANAGEMENT;
    using LIBRARY_MANAGEMENT.Properties;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Diagnostics;

    [HelpKeyword("vs.data.TableAdapter"), DesignerCategory("code"), ToolboxItem(true), DataObject(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public class BooksTableAdapter : Component
    {
        private bool kCnalMegv;
        private SqlCommand[] sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private SqlTransaction sqlTransaction_0;

        static BooksTableAdapter()
        {
            Class15.smethod_5();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public BooksTableAdapter()
        {
            Class17.smethod_0();
            this.ClearBeforeFill = true;
        }

        [DataObjectMethod(DataObjectMethodType.Fill, true), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(library_dataDataSet.BooksDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual library_dataDataSet.BooksDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            library_dataDataSet.BooksDataTable dataTable = new library_dataDataSet.BooksDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_0()
        {
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "Books"
            };
            mapping.ColumnMappings.Add("goods_id", "goods_id");
            mapping.ColumnMappings.Add("barcode", "barcode");
            mapping.ColumnMappings.Add("grp_id", "grp_id");
            mapping.ColumnMappings.Add("id", "id");
            mapping.ColumnMappings.Add("full_name", "full_name");
            mapping.ColumnMappings.Add("image", "image");
            mapping.ColumnMappings.Add("author", "author");
            mapping.ColumnMappings.Add("publish", "publish");
            mapping.ColumnMappings.Add("translator", "translator");
            mapping.ColumnMappings.Add("pl_month", "pl_month");
            mapping.ColumnMappings.Add("pl_year", "pl_year");
            mapping.ColumnMappings.Add("dimension", "dimension");
            mapping.ColumnMappings.Add("weight", "weight");
            mapping.ColumnMappings.Add("pages", "pages");
            mapping.ColumnMappings.Add("introinfo", "introinfo");
            mapping.ColumnMappings.Add("grpname", "grpname");
            mapping.ColumnMappings.Add("langguge", "langguge");
            mapping.ColumnMappings.Add("frmtype", "frmtype");
            this.sqlDataAdapter_0.TableMappings.Add(mapping);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_1()
        {
            this.sqlConnection_0 = new SqlConnection();
            this.sqlConnection_0.ConnectionString = Settings.Default.libraryConn;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            this.sqlCommand_0 = new SqlCommand[] { new SqlCommand() };
            this.sqlCommand_0[0].Connection = this.SqlConnection_0;
            this.sqlCommand_0[0].CommandText = "SELECT     gs.goods_id, gs.barcode, gs.grp_id, lang.id, gs.full_name, gs.image, attr.author, attr.publish, attr.translator, attr.pl_month, attr.pl_year, attr.dimension, \r\n                      attr.weight, attr.pages, attr.introinfo, grp.Description AS grpname, lang.description AS langguge, type.description AS frmtype\r\nFROM         tblFrmType AS type RIGHT OUTER JOIN\r\n                      tblGoods AS gs INNER JOIN\r\n                      tblBookAttr AS attr ON gs.goods_id = attr.goods_id INNER JOIN\r\n                      tblGoodsGrp AS grp ON gs.grp_id = grp.Id ON type.id = attr.form_type LEFT JOIN\r\n                      tblLanguage AS lang ON attr.language = lang.id";
            this.sqlCommand_0[0].CommandType = CommandType.Text;
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

