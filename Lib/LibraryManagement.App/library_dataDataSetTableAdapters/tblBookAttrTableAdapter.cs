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

    [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), ToolboxItem(true), DesignerCategory("code"), DataObject(true), HelpKeyword("vs.data.TableAdapter")]
    public class tblBookAttrTableAdapter : Component
    {
        private bool kCnalMegv;
        private SqlCommand[] sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private SqlTransaction sqlTransaction_0;

        static tblBookAttrTableAdapter()
        {
            Class15.smethod_5();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblBookAttrTableAdapter()
        {
            Class17.smethod_0();
            this.ClearBeforeFill = true;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Delete, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Delete(string Original_goods_id, string Original_author, string Original_publish, string Original_translator, int Original_form_type, int Original_language, int Original_pl_month, int Original_pl_year, string Original_dimension, int Original_weight, int Original_pages, string Original_introinfo)
        {
            int num2;
            if (Original_goods_id == null)
            {
                throw new ArgumentNullException("Original_goods_id");
            }
            this.Adapter.DeleteCommand.Parameters[0].Value = Original_goods_id;
            if (Original_author == null)
            {
                throw new ArgumentNullException("Original_author");
            }
            this.Adapter.DeleteCommand.Parameters[1].Value = Original_author;
            if (Original_publish == null)
            {
                throw new ArgumentNullException("Original_publish");
            }
            this.Adapter.DeleteCommand.Parameters[2].Value = Original_publish;
            if (Original_translator == null)
            {
                throw new ArgumentNullException("Original_translator");
            }
            this.Adapter.DeleteCommand.Parameters[3].Value = Original_translator;
            this.Adapter.DeleteCommand.Parameters[4].Value = Original_form_type;
            this.Adapter.DeleteCommand.Parameters[5].Value = Original_language;
            this.Adapter.DeleteCommand.Parameters[6].Value = Original_pl_month;
            this.Adapter.DeleteCommand.Parameters[7].Value = Original_pl_year;
            if (Original_dimension == null)
            {
                throw new ArgumentNullException("Original_dimension");
            }
            this.Adapter.DeleteCommand.Parameters[8].Value = Original_dimension;
            this.Adapter.DeleteCommand.Parameters[9].Value = Original_weight;
            this.Adapter.DeleteCommand.Parameters[10].Value = Original_pages;
            if (Original_introinfo == null)
            {
                throw new ArgumentNullException("Original_introinfo");
            }
            this.Adapter.DeleteCommand.Parameters[11].Value = Original_introinfo;
            ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
            if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.DeleteCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.DeleteCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.DeleteCommand.Connection.Close();
                }
            }
            return num2;
        }

        [DataObjectMethod(DataObjectMethodType.Fill, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Fill(library_dataDataSet.tblBookAttrDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true), HelpKeyword("vs.data.TableAdapter")]
        public virtual library_dataDataSet.tblBookAttrDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            library_dataDataSet.tblBookAttrDataTable dataTable = new library_dataDataSet.tblBookAttrDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Insert, true)]
        public virtual int Insert(string goods_id, string author, string publish, string translator, int form_type, int language, int pl_month, int pl_year, string dimension, int weight, int pages, string introinfo)
        {
            int num2;
            if (goods_id == null)
            {
                throw new ArgumentNullException("goods_id");
            }
            this.Adapter.InsertCommand.Parameters[0].Value = goods_id;
            if (author == null)
            {
                throw new ArgumentNullException("author");
            }
            this.Adapter.InsertCommand.Parameters[1].Value = author;
            if (publish == null)
            {
                throw new ArgumentNullException("publish");
            }
            this.Adapter.InsertCommand.Parameters[2].Value = publish;
            if (translator == null)
            {
                throw new ArgumentNullException("translator");
            }
            this.Adapter.InsertCommand.Parameters[3].Value = translator;
            this.Adapter.InsertCommand.Parameters[4].Value = form_type;
            this.Adapter.InsertCommand.Parameters[5].Value = language;
            this.Adapter.InsertCommand.Parameters[6].Value = pl_month;
            this.Adapter.InsertCommand.Parameters[7].Value = pl_year;
            if (dimension == null)
            {
                throw new ArgumentNullException("dimension");
            }
            this.Adapter.InsertCommand.Parameters[8].Value = dimension;
            this.Adapter.InsertCommand.Parameters[9].Value = weight;
            this.Adapter.InsertCommand.Parameters[10].Value = pages;
            if (introinfo == null)
            {
                throw new ArgumentNullException("introinfo");
            }
            this.Adapter.InsertCommand.Parameters[11].Value = introinfo;
            ConnectionState state = this.Adapter.InsertCommand.Connection.State;
            if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.InsertCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.InsertCommand.Connection.Close();
                }
            }
            return num2;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_0()
        {
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            DataTableMapping mapping = new DataTableMapping {
                SourceTable = "Table",
                DataSetTable = "tblBookAttr"
            };
            mapping.ColumnMappings.Add("goods_id", "goods_id");
            mapping.ColumnMappings.Add("author", "author");
            mapping.ColumnMappings.Add("publish", "publish");
            mapping.ColumnMappings.Add("translator", "translator");
            mapping.ColumnMappings.Add("form_type", "form_type");
            mapping.ColumnMappings.Add("language", "language");
            mapping.ColumnMappings.Add("pl_month", "pl_month");
            mapping.ColumnMappings.Add("pl_year", "pl_year");
            mapping.ColumnMappings.Add("dimension", "dimension");
            mapping.ColumnMappings.Add("weight", "weight");
            mapping.ColumnMappings.Add("pages", "pages");
            mapping.ColumnMappings.Add("introinfo", "introinfo");
            this.sqlDataAdapter_0.TableMappings.Add(mapping);
            this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
            this.sqlDataAdapter_0.DeleteCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM [dbo].[tblBookAttr] WHERE (([goods_id] = @Original_goods_id) AND ([author] = @Original_author) AND ([publish] = @Original_publish) AND ([translator] = @Original_translator) AND ([form_type] = @Original_form_type) AND ([language] = @Original_language) AND ([pl_month] = @Original_pl_month) AND ([pl_year] = @Original_pl_year) AND ([dimension] = @Original_dimension) AND ([weight] = @Original_weight) AND ([pages] = @Original_pages) AND ([introinfo] = @Original_introinfo))";
            this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_goods_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_author", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "author", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_publish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "publish", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_translator", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "translator", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_form_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "form_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_language", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "language", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_pl_month", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_month", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_pl_year", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_year", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dimension", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "dimension", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_weight", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "weight", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_pages", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pages", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_introinfo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "introinfo", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
            this.sqlDataAdapter_0.InsertCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO [dbo].[tblBookAttr] ([goods_id], [author], [publish], [translator], [form_type], [language], [pl_month], [pl_year], [dimension], [weight], [pages], [introinfo]) VALUES (@goods_id, @author, @publish, @translator, @form_type, @language, @pl_month, @pl_year, @dimension, @weight, @pages, @introinfo);\r\nSELECT goods_id, author, publish, translator, form_type, language, pl_month, pl_year, dimension, weight, pages, introinfo FROM tblBookAttr WHERE (goods_id = @goods_id)";
            this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@goods_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@author", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "author", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@publish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "publish", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@translator", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "translator", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@form_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "form_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@language", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "language", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@pl_month", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_month", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@pl_year", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_year", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@dimension", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "dimension", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@weight", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "weight", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@pages", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pages", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@introinfo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "introinfo", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
            this.sqlDataAdapter_0.UpdateCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE [dbo].[tblBookAttr] SET [goods_id] = @goods_id, [author] = @author, [publish] = @publish, [translator] = @translator, [form_type] = @form_type, [language] = @language, [pl_month] = @pl_month, [pl_year] = @pl_year, [dimension] = @dimension, [weight] = @weight, [pages] = @pages, [introinfo] = @introinfo WHERE (([goods_id] = @Original_goods_id) AND ([author] = @Original_author) AND ([publish] = @Original_publish) AND ([translator] = @Original_translator) AND ([form_type] = @Original_form_type) AND ([language] = @Original_language) AND ([pl_month] = @Original_pl_month) AND ([pl_year] = @Original_pl_year) AND ([dimension] = @Original_dimension) AND ([weight] = @Original_weight) AND ([pages] = @Original_pages) AND ([introinfo] = @Original_introinfo));\r\nSELECT goods_id, author, publish, translator, form_type, language, pl_month, pl_year, dimension, weight, pages, introinfo FROM tblBookAttr WHERE (goods_id = @goods_id)";
            this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@goods_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@author", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "author", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@publish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "publish", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@translator", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "translator", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@form_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "form_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@language", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "language", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@pl_month", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_month", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@pl_year", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_year", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@dimension", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "dimension", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@weight", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "weight", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@pages", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pages", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@introinfo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "introinfo", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_goods_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_author", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "author", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_publish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "publish", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_translator", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "translator", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_form_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "form_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_language", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "language", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_pl_month", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_month", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_pl_year", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pl_year", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dimension", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "dimension", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_weight", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "weight", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_pages", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "pages", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_introinfo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "introinfo", DataRowVersion.Original, false, null, "", "", ""));
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_1()
        {
            this.sqlConnection_0 = new SqlConnection();
            this.sqlConnection_0.ConnectionString = Settings.Default.libraryConn;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_2()
        {
            this.sqlCommand_0 = new SqlCommand[] { new SqlCommand() };
            this.sqlCommand_0[0].Connection = this.SqlConnection_0;
            this.sqlCommand_0[0].CommandText = "SELECT goods_id, author, publish, translator, form_type, language, pl_month, pl_year, dimension, weight, pages, introinfo FROM dbo.tblBookAttr";
            this.sqlCommand_0[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual int Update(library_dataDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tblBookAttr");
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(library_dataDataSet.tblBookAttrDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string author, string publish, string translator, int form_type, int language, int pl_month, int pl_year, string dimension, int weight, int pages, string introinfo, string Original_goods_id, string Original_author, string Original_publish, string Original_translator, int Original_form_type, int Original_language, int Original_pl_month, int Original_pl_year, string Original_dimension, int Original_weight, int Original_pages, string Original_introinfo)
        {
            return this.Update(Original_goods_id, author, publish, translator, form_type, language, pl_month, pl_year, dimension, weight, pages, introinfo, Original_goods_id, Original_author, Original_publish, Original_translator, Original_form_type, Original_language, Original_pl_month, Original_pl_year, Original_dimension, Original_weight, Original_pages, Original_introinfo);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string goods_id, string author, string publish, string translator, int form_type, int language, int pl_month, int pl_year, string dimension, int weight, int pages, string introinfo, string Original_goods_id, string Original_author, string Original_publish, string Original_translator, int Original_form_type, int Original_language, int Original_pl_month, int Original_pl_year, string Original_dimension, int Original_weight, int Original_pages, string Original_introinfo)
        {
            int num2;
            if (goods_id == null)
            {
                throw new ArgumentNullException("goods_id");
            }
            this.Adapter.UpdateCommand.Parameters[0].Value = goods_id;
            if (author == null)
            {
                throw new ArgumentNullException("author");
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = author;
            if (publish == null)
            {
                throw new ArgumentNullException("publish");
            }
            this.Adapter.UpdateCommand.Parameters[2].Value = publish;
            if (translator == null)
            {
                throw new ArgumentNullException("translator");
            }
            this.Adapter.UpdateCommand.Parameters[3].Value = translator;
            this.Adapter.UpdateCommand.Parameters[4].Value = form_type;
            this.Adapter.UpdateCommand.Parameters[5].Value = language;
            this.Adapter.UpdateCommand.Parameters[6].Value = pl_month;
            this.Adapter.UpdateCommand.Parameters[7].Value = pl_year;
            if (dimension == null)
            {
                throw new ArgumentNullException("dimension");
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = dimension;
            this.Adapter.UpdateCommand.Parameters[9].Value = weight;
            this.Adapter.UpdateCommand.Parameters[10].Value = pages;
            if (introinfo == null)
            {
                throw new ArgumentNullException("introinfo");
            }
            this.Adapter.UpdateCommand.Parameters[11].Value = introinfo;
            if (Original_goods_id == null)
            {
                throw new ArgumentNullException("Original_goods_id");
            }
            this.Adapter.UpdateCommand.Parameters[12].Value = Original_goods_id;
            if (Original_author == null)
            {
                throw new ArgumentNullException("Original_author");
            }
            this.Adapter.UpdateCommand.Parameters[13].Value = Original_author;
            if (Original_publish == null)
            {
                throw new ArgumentNullException("Original_publish");
            }
            this.Adapter.UpdateCommand.Parameters[14].Value = Original_publish;
            if (Original_translator == null)
            {
                throw new ArgumentNullException("Original_translator");
            }
            this.Adapter.UpdateCommand.Parameters[15].Value = Original_translator;
            this.Adapter.UpdateCommand.Parameters[0x10].Value = Original_form_type;
            this.Adapter.UpdateCommand.Parameters[0x11].Value = Original_language;
            this.Adapter.UpdateCommand.Parameters[0x12].Value = Original_pl_month;
            this.Adapter.UpdateCommand.Parameters[0x13].Value = Original_pl_year;
            if (Original_dimension == null)
            {
                throw new ArgumentNullException("Original_dimension");
            }
            this.Adapter.UpdateCommand.Parameters[20].Value = Original_dimension;
            this.Adapter.UpdateCommand.Parameters[0x15].Value = Original_weight;
            this.Adapter.UpdateCommand.Parameters[0x16].Value = Original_pages;
            if (Original_introinfo == null)
            {
                throw new ArgumentNullException("Original_introinfo");
            }
            this.Adapter.UpdateCommand.Parameters[0x17].Value = Original_introinfo;
            ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
            if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                this.Adapter.UpdateCommand.Connection.Open();
            }
            try
            {
                num2 = this.Adapter.UpdateCommand.ExecuteNonQuery();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    this.Adapter.UpdateCommand.Connection.Close();
                }
            }
            return num2;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

