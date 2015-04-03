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



    [ToolboxItem(true), DataObject(true), HelpKeyword("vs.data.TableAdapter"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DesignerCategory("code")]
    public class tblGoodsTableAdapter : Component
    {
        private bool kCnalMegv;
        private SqlCommand[] sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private SqlTransaction sqlTransaction_0;

        static tblGoodsTableAdapter()
        {
            Class15.smethod_5();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblGoodsTableAdapter()
        {
            Class17.smethod_0();
            this.ClearBeforeFill = true;
        }

        [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Delete, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual int Delete(string Original_goods_id, string Original_barcode, bool Original_mbc, string Original_ref, string Original_grp_id, string Original_short_name, string Original_full_name, string Original_packunit, string Original_piceunit, decimal Original_unitconv, string Original_supp_id, DateTime? Original_open_date, string Original_tax_code, string Original_merc_type, string Original_attr_type, bool? Original_domestic, bool? Original_warranty, bool? Original_status)
        {
            int num2;
            if (Original_goods_id == null)
            {
                throw new ArgumentNullException("Original_goods_id");
            }
            this.Adapter.DeleteCommand.Parameters[0].Value = Original_goods_id;
            if (Original_barcode == null)
            {
                throw new ArgumentNullException("Original_barcode");
            }
            this.Adapter.DeleteCommand.Parameters[1].Value = Original_barcode;
            this.Adapter.DeleteCommand.Parameters[2].Value = Original_mbc;
            if (Original_ref == null)
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = 1;
                this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = 0;
                this.Adapter.DeleteCommand.Parameters[4].Value = Original_ref;
            }
            if (Original_grp_id == null)
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = 1;
                this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = 0;
                this.Adapter.DeleteCommand.Parameters[6].Value = Original_grp_id;
            }
            if (Original_short_name == null)
            {
                throw new ArgumentNullException("Original_short_name");
            }
            this.Adapter.DeleteCommand.Parameters[7].Value = Original_short_name;
            if (Original_full_name == null)
            {
                throw new ArgumentNullException("Original_full_name");
            }
            this.Adapter.DeleteCommand.Parameters[8].Value = Original_full_name;
            if (Original_packunit == null)
            {
                throw new ArgumentNullException("Original_packunit");
            }
            this.Adapter.DeleteCommand.Parameters[9].Value = Original_packunit;
            if (Original_piceunit == null)
            {
                throw new ArgumentNullException("Original_piceunit");
            }
            this.Adapter.DeleteCommand.Parameters[10].Value = Original_piceunit;
            this.Adapter.DeleteCommand.Parameters[11].Value = Original_unitconv;
            if (Original_supp_id == null)
            {
                this.Adapter.DeleteCommand.Parameters[12].Value = 1;
                this.Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[12].Value = 0;
                this.Adapter.DeleteCommand.Parameters[13].Value = Original_supp_id;
            }
            if (Original_open_date.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[14].Value = 0;
                this.Adapter.DeleteCommand.Parameters[15].Value = Original_open_date.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[14].Value = 1;
                this.Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
            }
            if (Original_tax_code == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x10].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x11].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x10].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x11].Value = Original_tax_code;
            }
            if (Original_merc_type == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x12].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x12].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x13].Value = Original_merc_type;
            }
            if (Original_attr_type == null)
            {
                this.Adapter.DeleteCommand.Parameters[20].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x15].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[20].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x15].Value = Original_attr_type;
            }
            if (Original_domestic.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[0x16].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x17].Value = Original_domestic.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x16].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x17].Value = DBNull.Value;
            }
            if (Original_warranty.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[0x18].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x19].Value = Original_warranty.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x18].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x19].Value = DBNull.Value;
            }
            if (Original_status.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[0x1a].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x1b].Value = Original_status.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x1a].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x1b].Value = DBNull.Value;
            }
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

        [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Fill(library_dataDataSet.tblGoodsDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true)]
        public virtual library_dataDataSet.tblGoodsDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            library_dataDataSet.tblGoodsDataTable dataTable = new library_dataDataSet.tblGoodsDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Insert(string goods_id, string barcode, bool mbc, string _ref, string grp_id, string short_name, string full_name, string packunit, string piceunit, decimal unitconv, string supp_id, byte[] image, DateTime? open_date, string tax_code, string merc_type, string attr_type, bool? domestic, bool? warranty, bool? status)
        {
            int num2;
            if (goods_id == null)
            {
                throw new ArgumentNullException("goods_id");
            }
            this.Adapter.InsertCommand.Parameters[0].Value = goods_id;
            if (barcode == null)
            {
                throw new ArgumentNullException("barcode");
            }
            this.Adapter.InsertCommand.Parameters[1].Value = barcode;
            this.Adapter.InsertCommand.Parameters[2].Value = mbc;
            if (_ref == null)
            {
                this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = _ref;
            }
            if (grp_id == null)
            {
                this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = grp_id;
            }
            if (short_name == null)
            {
                throw new ArgumentNullException("short_name");
            }
            this.Adapter.InsertCommand.Parameters[5].Value = short_name;
            if (full_name == null)
            {
                throw new ArgumentNullException("full_name");
            }
            this.Adapter.InsertCommand.Parameters[6].Value = full_name;
            if (packunit == null)
            {
                throw new ArgumentNullException("packunit");
            }
            this.Adapter.InsertCommand.Parameters[7].Value = packunit;
            if (piceunit == null)
            {
                throw new ArgumentNullException("piceunit");
            }
            this.Adapter.InsertCommand.Parameters[8].Value = piceunit;
            this.Adapter.InsertCommand.Parameters[9].Value = unitconv;
            if (supp_id == null)
            {
                this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[10].Value = supp_id;
            }
            if (image == null)
            {
                this.Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[11].Value = image;
            }
            if (open_date.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[12].Value = open_date.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
            }
            if (tax_code == null)
            {
                this.Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[13].Value = tax_code;
            }
            if (merc_type == null)
            {
                this.Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[14].Value = merc_type;
            }
            if (attr_type == null)
            {
                this.Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[15].Value = attr_type;
            }
            if (domestic.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[0x10].Value = domestic.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0x10].Value = DBNull.Value;
            }
            if (warranty.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[0x11].Value = warranty.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0x11].Value = DBNull.Value;
            }
            if (status.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[0x12].Value = status.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0x12].Value = DBNull.Value;
            }
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
            DataTableMapping mapping = new DataTableMapping();
            mapping.SourceTable = "Table";
            mapping.DataSetTable = "tblGoods";
            mapping.ColumnMappings.Add("goods_id", "goods_id");
            mapping.ColumnMappings.Add("barcode", "barcode");
            mapping.ColumnMappings.Add("mbc", "mbc");
            mapping.ColumnMappings.Add("ref", "ref");
            mapping.ColumnMappings.Add("grp_id", "grp_id");
            mapping.ColumnMappings.Add("short_name", "short_name");
            mapping.ColumnMappings.Add("full_name", "full_name");
            mapping.ColumnMappings.Add("packunit", "packunit");
            mapping.ColumnMappings.Add("piceunit", "piceunit");
            mapping.ColumnMappings.Add("unitconv", "unitconv");
            mapping.ColumnMappings.Add("supp_id", "supp_id");
            mapping.ColumnMappings.Add("image", "image");
            mapping.ColumnMappings.Add("open_date", "open_date");
            mapping.ColumnMappings.Add("tax_code", "tax_code");
            mapping.ColumnMappings.Add("merc_type", "merc_type");
            mapping.ColumnMappings.Add("attr_type", "attr_type");
            mapping.ColumnMappings.Add("domestic", "domestic");
            mapping.ColumnMappings.Add("warranty", "warranty");
            mapping.ColumnMappings.Add("status", "status");
            this.sqlDataAdapter_0.TableMappings.Add(mapping);
            this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
            this.sqlDataAdapter_0.DeleteCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM [dbo].[tblGoods] WHERE (([goods_id] = @Original_goods_id) AND ([barcode] = @Original_barcode) AND ([mbc] = @Original_mbc) AND ((@IsNull_ref = 1 AND [ref] IS NULL) OR ([ref] = @Original_ref)) AND ((@IsNull_grp_id = 1 AND [grp_id] IS NULL) OR ([grp_id] = @Original_grp_id)) AND ([short_name] = @Original_short_name) AND ([full_name] = @Original_full_name) AND ([packunit] = @Original_packunit) AND ([piceunit] = @Original_piceunit) AND ([unitconv] = @Original_unitconv) AND ((@IsNull_supp_id = 1 AND [supp_id] IS NULL) OR ([supp_id] = @Original_supp_id)) AND ((@IsNull_open_date = 1 AND [open_date] IS NULL) OR ([open_date] = @Original_open_date)) AND ((@IsNull_tax_code = 1 AND [tax_code] IS NULL) OR ([tax_code] = @Original_tax_code)) AND ((@IsNull_merc_type = 1 AND [merc_type] IS NULL) OR ([merc_type] = @Original_merc_type)) AND ((@IsNull_attr_type = 1 AND [attr_type] IS NULL) OR ([attr_type] = @Original_attr_type)) AND ((@IsNull_domestic = 1 AND [domestic] IS NULL) OR ([domestic] = @Original_domestic)) AND ((@IsNull_warranty = 1 AND [warranty] IS NULL) OR ([warranty] = @Original_warranty)) AND ((@IsNull_status = 1 AND [status] IS NULL) OR ([status] = @Original_status)))";
            this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_goods_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_barcode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "barcode", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_mbc", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "mbc", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ref", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ref", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_grp_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_grp_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_short_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "short_name", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_full_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "full_name", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_packunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "packunit", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_piceunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "piceunit", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_unitconv", SqlDbType.Decimal, 0, ParameterDirection.Input, 4, 0, "unitconv", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_supp_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_supp_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_open_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_tax_code", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_tax_code", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_merc_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_merc_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_attr_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_attr_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_domestic", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_domestic", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_warranty", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_warranty", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_status", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
            this.sqlDataAdapter_0.InsertCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO [dbo].[tblGoods] ([goods_id], [barcode], [mbc], [ref], [grp_id], [short_name], [full_name], [packunit], [piceunit], [unitconv], [supp_id], [image], [open_date], [tax_code], [merc_type], [attr_type], [domestic], [warranty], [status]) VALUES (@goods_id, @barcode, @mbc, @ref, @grp_id, @short_name, @full_name, @packunit, @piceunit, @unitconv, @supp_id, @image, @open_date, @tax_code, @merc_type, @attr_type, @domestic, @warranty, @status);\r\nSELECT goods_id, barcode, mbc, ref, grp_id, short_name, full_name, packunit, piceunit, unitconv, supp_id, image, open_date, tax_code, merc_type, attr_type, domestic, warranty, status FROM tblGoods WHERE (goods_id = @goods_id)";
            this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@goods_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@barcode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "barcode", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@mbc", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "mbc", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@ref", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@grp_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@short_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "short_name", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@full_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "full_name", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@packunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "packunit", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@piceunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "piceunit", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@unitconv", SqlDbType.Decimal, 0, ParameterDirection.Input, 4, 0, "unitconv", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@supp_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@image", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "image", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@tax_code", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@merc_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@attr_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@domestic", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@warranty", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
            this.sqlDataAdapter_0.UpdateCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE [dbo].[tblGoods] SET [goods_id] = @goods_id, [barcode] = @barcode, [mbc] = @mbc, [ref] = @ref, [grp_id] = @grp_id, [short_name] = @short_name, [full_name] = @full_name, [packunit] = @packunit, [piceunit] = @piceunit, [unitconv] = @unitconv, [supp_id] = @supp_id, [image] = @image, [open_date] = @open_date, [tax_code] = @tax_code, [merc_type] = @merc_type, [attr_type] = @attr_type, [domestic] = @domestic, [warranty] = @warranty, [status] = @status WHERE (([goods_id] = @Original_goods_id) AND ([barcode] = @Original_barcode) AND ([mbc] = @Original_mbc) AND ((@IsNull_ref = 1 AND [ref] IS NULL) OR ([ref] = @Original_ref)) AND ((@IsNull_grp_id = 1 AND [grp_id] IS NULL) OR ([grp_id] = @Original_grp_id)) AND ([short_name] = @Original_short_name) AND ([full_name] = @Original_full_name) AND ([packunit] = @Original_packunit) AND ([piceunit] = @Original_piceunit) AND ([unitconv] = @Original_unitconv) AND ((@IsNull_supp_id = 1 AND [supp_id] IS NULL) OR ([supp_id] = @Original_supp_id)) AND ((@IsNull_open_date = 1 AND [open_date] IS NULL) OR ([open_date] = @Original_open_date)) AND ((@IsNull_tax_code = 1 AND [tax_code] IS NULL) OR ([tax_code] = @Original_tax_code)) AND ((@IsNull_merc_type = 1 AND [merc_type] IS NULL) OR ([merc_type] = @Original_merc_type)) AND ((@IsNull_attr_type = 1 AND [attr_type] IS NULL) OR ([attr_type] = @Original_attr_type)) AND ((@IsNull_domestic = 1 AND [domestic] IS NULL) OR ([domestic] = @Original_domestic)) AND ((@IsNull_warranty = 1 AND [warranty] IS NULL) OR ([warranty] = @Original_warranty)) AND ((@IsNull_status = 1 AND [status] IS NULL) OR ([status] = @Original_status)));\r\nSELECT goods_id, barcode, mbc, ref, grp_id, short_name, full_name, packunit, piceunit, unitconv, supp_id, image, open_date, tax_code, merc_type, attr_type, domestic, warranty, status FROM tblGoods WHERE (goods_id = @goods_id)";
            this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@goods_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@barcode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "barcode", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@mbc", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "mbc", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@ref", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@grp_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@short_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "short_name", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@full_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "full_name", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@packunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "packunit", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@piceunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "piceunit", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@unitconv", SqlDbType.Decimal, 0, ParameterDirection.Input, 4, 0, "unitconv", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@supp_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@image", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "image", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@tax_code", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@merc_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@attr_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@domestic", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@warranty", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_goods_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "goods_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_barcode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "barcode", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_mbc", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "mbc", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ref", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ref", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "ref", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_grp_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_grp_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "grp_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_short_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "short_name", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_full_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "full_name", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_packunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "packunit", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_piceunit", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "piceunit", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_unitconv", SqlDbType.Decimal, 0, ParameterDirection.Input, 4, 0, "unitconv", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_supp_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_supp_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "supp_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_open_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_tax_code", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_tax_code", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "tax_code", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_merc_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_merc_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "merc_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_attr_type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_attr_type", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "attr_type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_domestic", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_domestic", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "domestic", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_warranty", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_warranty", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "warranty", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_status", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "status", DataRowVersion.Original, false, null, "", "", ""));
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
            this.sqlCommand_0 = new SqlCommand[] { new SqlCommand() };
            this.sqlCommand_0[0].Connection = this.SqlConnection_0;
            this.sqlCommand_0[0].CommandText = "SELECT goods_id, barcode, mbc, ref, grp_id, short_name, full_name, packunit, piceunit, unitconv, supp_id, image, open_date, tax_code, merc_type, attr_type, domestic, warranty, status FROM dbo.tblGoods";
            this.sqlCommand_0[0].CommandType = CommandType.Text;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(library_dataDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tblGoods");
        }

        [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(library_dataDataSet.tblGoodsDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int Update(string barcode, bool mbc, string _ref, string grp_id, string short_name, string full_name, string packunit, string piceunit, decimal unitconv, string supp_id, byte[] image, DateTime? open_date, string tax_code, string merc_type, string attr_type, bool? domestic, bool? warranty, bool? status, string Original_goods_id, string Original_barcode, bool Original_mbc, string Original_ref, string Original_grp_id, string Original_short_name, string Original_full_name, string Original_packunit, string Original_piceunit, decimal Original_unitconv, string Original_supp_id, DateTime? Original_open_date, string Original_tax_code, string Original_merc_type, string Original_attr_type, bool? Original_domestic, bool? Original_warranty, bool? Original_status)
        {
            return this.Update(Original_goods_id, barcode, mbc, _ref, grp_id, short_name, full_name, packunit, piceunit, unitconv, supp_id, image, open_date, tax_code, merc_type, attr_type, domestic, warranty, status, Original_goods_id, Original_barcode, Original_mbc, Original_ref, Original_grp_id, Original_short_name, Original_full_name, Original_packunit, Original_piceunit, Original_unitconv, Original_supp_id, Original_open_date, Original_tax_code, Original_merc_type, Original_attr_type, Original_domestic, Original_warranty, Original_status);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(string goods_id, string barcode, bool mbc, string _ref, string grp_id, string short_name, string full_name, string packunit, string piceunit, decimal unitconv, string supp_id, byte[] image, DateTime? open_date, string tax_code, string merc_type, string attr_type, bool? domestic, bool? warranty, bool? status, string Original_goods_id, string Original_barcode, bool Original_mbc, string Original_ref, string Original_grp_id, string Original_short_name, string Original_full_name, string Original_packunit, string Original_piceunit, decimal Original_unitconv, string Original_supp_id, DateTime? Original_open_date, string Original_tax_code, string Original_merc_type, string Original_attr_type, bool? Original_domestic, bool? Original_warranty, bool? Original_status)
        {
            int num2;
            if (goods_id == null)
            {
                throw new ArgumentNullException("goods_id");
            }
            this.Adapter.UpdateCommand.Parameters[0].Value = goods_id;
            if (barcode == null)
            {
                throw new ArgumentNullException("barcode");
            }
            this.Adapter.UpdateCommand.Parameters[1].Value = barcode;
            this.Adapter.UpdateCommand.Parameters[2].Value = mbc;
            if (_ref == null)
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = _ref;
            }
            if (grp_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = grp_id;
            }
            if (short_name == null)
            {
                throw new ArgumentNullException("short_name");
            }
            this.Adapter.UpdateCommand.Parameters[5].Value = short_name;
            if (full_name == null)
            {
                throw new ArgumentNullException("full_name");
            }
            this.Adapter.UpdateCommand.Parameters[6].Value = full_name;
            if (packunit == null)
            {
                throw new ArgumentNullException("packunit");
            }
            this.Adapter.UpdateCommand.Parameters[7].Value = packunit;
            if (piceunit == null)
            {
                throw new ArgumentNullException("piceunit");
            }
            this.Adapter.UpdateCommand.Parameters[8].Value = piceunit;
            this.Adapter.UpdateCommand.Parameters[9].Value = unitconv;
            if (supp_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = supp_id;
            }
            if (image == null)
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = image;
            }
            if (open_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = open_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
            }
            if (tax_code == null)
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = tax_code;
            }
            if (merc_type == null)
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = merc_type;
            }
            if (attr_type == null)
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = attr_type;
            }
            if (domestic.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x10].Value = domestic.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x10].Value = DBNull.Value;
            }
            if (warranty.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x11].Value = warranty.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x11].Value = DBNull.Value;
            }
            if (status.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x12].Value = status.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x12].Value = DBNull.Value;
            }
            if (Original_goods_id == null)
            {
                throw new ArgumentNullException("Original_goods_id");
            }
            this.Adapter.UpdateCommand.Parameters[0x13].Value = Original_goods_id;
            if (Original_barcode == null)
            {
                throw new ArgumentNullException("Original_barcode");
            }
            this.Adapter.UpdateCommand.Parameters[20].Value = Original_barcode;
            this.Adapter.UpdateCommand.Parameters[0x15].Value = Original_mbc;
            if (Original_ref == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x16].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x17].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x16].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x17].Value = Original_ref;
            }
            if (Original_grp_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x18].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x19].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x18].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x19].Value = Original_grp_id;
            }
            if (Original_short_name == null)
            {
                throw new ArgumentNullException("Original_short_name");
            }
            this.Adapter.UpdateCommand.Parameters[0x1a].Value = Original_short_name;
            if (Original_full_name == null)
            {
                throw new ArgumentNullException("Original_full_name");
            }
            this.Adapter.UpdateCommand.Parameters[0x1b].Value = Original_full_name;
            if (Original_packunit == null)
            {
                throw new ArgumentNullException("Original_packunit");
            }
            this.Adapter.UpdateCommand.Parameters[0x1c].Value = Original_packunit;
            if (Original_piceunit == null)
            {
                throw new ArgumentNullException("Original_piceunit");
            }
            this.Adapter.UpdateCommand.Parameters[0x1d].Value = Original_piceunit;
            this.Adapter.UpdateCommand.Parameters[30].Value = Original_unitconv;
            if (Original_supp_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x1f].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x20].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x1f].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x20].Value = Original_supp_id;
            }
            if (Original_open_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x21].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x22].Value = Original_open_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x21].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x22].Value = DBNull.Value;
            }
            if (Original_tax_code == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x23].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x24].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x23].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x24].Value = Original_tax_code;
            }
            if (Original_merc_type == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x25].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x26].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x25].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x26].Value = Original_merc_type;
            }
            if (Original_attr_type == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x27].Value = 1;
                this.Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x27].Value = 0;
                this.Adapter.UpdateCommand.Parameters[40].Value = Original_attr_type;
            }
            if (Original_domestic.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x29].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2a].Value = Original_domestic.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x29].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2a].Value = DBNull.Value;
            }
            if (Original_warranty.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x2b].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2c].Value = Original_warranty.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x2b].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2c].Value = DBNull.Value;
            }
            if (Original_status.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x2d].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2e].Value = Original_status.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x2d].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2e].Value = DBNull.Value;
            }
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

