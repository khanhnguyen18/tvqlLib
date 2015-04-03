using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using LibraryManagement.App.Properties;

namespace LibraryManagement.App
{
    
    [DesignerCategory("code"), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DataObject(true), ToolboxItem(true), HelpKeyword("vs.data.TableAdapter")]
    public class tblCustomerTableAdapter : Component
    {
        private bool kCnalMegv;
        private SqlCommand[] sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private SqlTransaction sqlTransaction_0;

        static tblCustomerTableAdapter()
        {
            Class15.smethod_5();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblCustomerTableAdapter()
        {
            Class17.smethod_0();
            this.ClearBeforeFill = true;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Delete(string Original_id, int? Original_Type, string Original_fullname, string Original_address, string Original_phone, string Original_fax, string Original_person_id, string Original_place_issue, string Original_email, DateTime? Original_due_date, string Original_bankname, string Original_bank_br, string Original_accnum, string Original_Vatnum, string Original_contactps, string Original_remark, DateTime? Original_open_date, bool Original_Status)
        {
            int num2;
            if (Original_id == null)
            {
                throw new ArgumentNullException("Original_id");
            }
            this.Adapter.DeleteCommand.Parameters[0].Value = Original_id;
            if (Original_Type.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = 0;
                this.Adapter.DeleteCommand.Parameters[2].Value = Original_Type.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[1].Value = 1;
                this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
            }
            if (Original_fullname == null)
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = 1;
                this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[3].Value = 0;
                this.Adapter.DeleteCommand.Parameters[4].Value = Original_fullname;
            }
            if (Original_address == null)
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = 1;
                this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[5].Value = 0;
                this.Adapter.DeleteCommand.Parameters[6].Value = Original_address;
            }
            if (Original_phone == null)
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = 1;
                this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[7].Value = 0;
                this.Adapter.DeleteCommand.Parameters[8].Value = Original_phone;
            }
            if (Original_fax == null)
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = 1;
                this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[9].Value = 0;
                this.Adapter.DeleteCommand.Parameters[10].Value = Original_fax;
            }
            if (Original_person_id == null)
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = 1;
                this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[11].Value = 0;
                this.Adapter.DeleteCommand.Parameters[12].Value = Original_person_id;
            }
            if (Original_place_issue == null)
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = 1;
                this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[13].Value = 0;
                this.Adapter.DeleteCommand.Parameters[14].Value = Original_place_issue;
            }
            if (Original_email == null)
            {
                this.Adapter.DeleteCommand.Parameters[15].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[15].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x10].Value = Original_email;
            }
            if (Original_due_date.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[0x11].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x12].Value = Original_due_date.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x11].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x12].Value = DBNull.Value;
            }
            if (Original_bankname == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x13].Value = 1;
                this.Adapter.DeleteCommand.Parameters[20].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x13].Value = 0;
                this.Adapter.DeleteCommand.Parameters[20].Value = Original_bankname;
            }
            if (Original_bank_br == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x15].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x16].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x15].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x16].Value = Original_bank_br;
            }
            if (Original_accnum == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x17].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x18].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x17].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x18].Value = Original_accnum;
            }
            if (Original_Vatnum == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x19].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x1a].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x19].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x1a].Value = Original_Vatnum;
            }
            if (Original_contactps == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x1b].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x1c].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x1b].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x1c].Value = Original_contactps;
            }
            if (Original_remark == null)
            {
                this.Adapter.DeleteCommand.Parameters[0x1d].Value = 1;
                this.Adapter.DeleteCommand.Parameters[30].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x1d].Value = 0;
                this.Adapter.DeleteCommand.Parameters[30].Value = Original_remark;
            }
            if (Original_open_date.HasValue)
            {
                this.Adapter.DeleteCommand.Parameters[0x1f].Value = 0;
                this.Adapter.DeleteCommand.Parameters[0x20].Value = Original_open_date.Value;
            }
            else
            {
                this.Adapter.DeleteCommand.Parameters[0x1f].Value = 1;
                this.Adapter.DeleteCommand.Parameters[0x20].Value = DBNull.Value;
            }
            this.Adapter.DeleteCommand.Parameters[0x21].Value = Original_Status;
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Fill(library_dataDataSet.tblCustomerDataTable dataTable)
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            if (this.ClearBeforeFill)
            {
                dataTable.Clear();
            }
            return this.Adapter.Fill(dataTable);
        }

        [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual library_dataDataSet.tblCustomerDataTable GetData()
        {
            this.Adapter.SelectCommand = this.CommandCollection[0];
            library_dataDataSet.tblCustomerDataTable dataTable = new library_dataDataSet.tblCustomerDataTable();
            this.Adapter.Fill(dataTable);
            return dataTable;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Insert, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Insert(string id, int? Type, string fullname, string address, string phone, string fax, string person_id, string place_issue, string email, DateTime? due_date, byte[] image, string bankname, string bank_br, string accnum, string Vatnum, string contactps, string remark, DateTime? open_date, bool Status)
        {
            int num2;
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            this.Adapter.InsertCommand.Parameters[0].Value = id;
            if (Type.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[1].Value = Type.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
            }
            if (fullname == null)
            {
                this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[2].Value = fullname;
            }
            if (address == null)
            {
                this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[3].Value = address;
            }
            if (phone == null)
            {
                this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[4].Value = phone;
            }
            if (fax == null)
            {
                this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[5].Value = fax;
            }
            if (person_id == null)
            {
                this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[6].Value = person_id;
            }
            if (place_issue == null)
            {
                this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[7].Value = place_issue;
            }
            if (email == null)
            {
                this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[8].Value = email;
            }
            if (due_date.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[9].Value = due_date.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
            }
            if (image == null)
            {
                this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[10].Value = image;
            }
            if (bankname == null)
            {
                this.Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[11].Value = bankname;
            }
            if (bank_br == null)
            {
                this.Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[12].Value = bank_br;
            }
            if (accnum == null)
            {
                this.Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[13].Value = accnum;
            }
            if (Vatnum == null)
            {
                this.Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[14].Value = Vatnum;
            }
            if (contactps == null)
            {
                this.Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[15].Value = contactps;
            }
            if (remark == null)
            {
                this.Adapter.InsertCommand.Parameters[0x10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0x10].Value = remark;
            }
            if (open_date.HasValue)
            {
                this.Adapter.InsertCommand.Parameters[0x11].Value = open_date.Value;
            }
            else
            {
                this.Adapter.InsertCommand.Parameters[0x11].Value = DBNull.Value;
            }
            this.Adapter.InsertCommand.Parameters[0x12].Value = Status;
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
            mapping.DataSetTable = "tblCustomer";
            mapping.ColumnMappings.Add("id", "id");
            mapping.ColumnMappings.Add("Type", "Type");
            mapping.ColumnMappings.Add("fullname", "fullname");
            mapping.ColumnMappings.Add("address", "address");
            mapping.ColumnMappings.Add("phone", "phone");
            mapping.ColumnMappings.Add("fax", "fax");
            mapping.ColumnMappings.Add("person_id", "person_id");
            mapping.ColumnMappings.Add("place_issue", "place_issue");
            mapping.ColumnMappings.Add("email", "email");
            mapping.ColumnMappings.Add("due_date", "due_date");
            mapping.ColumnMappings.Add("image", "image");
            mapping.ColumnMappings.Add("bankname", "bankname");
            mapping.ColumnMappings.Add("bank_br", "bank_br");
            mapping.ColumnMappings.Add("accnum", "accnum");
            mapping.ColumnMappings.Add("Vatnum", "Vatnum");
            mapping.ColumnMappings.Add("contactps", "contactps");
            mapping.ColumnMappings.Add("remark", "remark");
            mapping.ColumnMappings.Add("open_date", "open_date");
            mapping.ColumnMappings.Add("Status", "Status");
            this.sqlDataAdapter_0.TableMappings.Add(mapping);
            this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
            this.sqlDataAdapter_0.DeleteCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM [dbo].[tblCustomer] WHERE (([id] = @Original_id) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND ((@IsNull_fullname = 1 AND [fullname] IS NULL) OR ([fullname] = @Original_fullname)) AND ((@IsNull_address = 1 AND [address] IS NULL) OR ([address] = @Original_address)) AND ((@IsNull_phone = 1 AND [phone] IS NULL) OR ([phone] = @Original_phone)) AND ((@IsNull_fax = 1 AND [fax] IS NULL) OR ([fax] = @Original_fax)) AND ((@IsNull_person_id = 1 AND [person_id] IS NULL) OR ([person_id] = @Original_person_id)) AND ((@IsNull_place_issue = 1 AND [place_issue] IS NULL) OR ([place_issue] = @Original_place_issue)) AND ((@IsNull_email = 1 AND [email] IS NULL) OR ([email] = @Original_email)) AND ((@IsNull_due_date = 1 AND [due_date] IS NULL) OR ([due_date] = @Original_due_date)) AND ((@IsNull_bankname = 1 AND [bankname] IS NULL) OR ([bankname] = @Original_bankname)) AND ((@IsNull_bank_br = 1 AND [bank_br] IS NULL) OR ([bank_br] = @Original_bank_br)) AND ((@IsNull_accnum = 1 AND [accnum] IS NULL) OR ([accnum] = @Original_accnum)) AND ((@IsNull_Vatnum = 1 AND [Vatnum] IS NULL) OR ([Vatnum] = @Original_Vatnum)) AND ((@IsNull_contactps = 1 AND [contactps] IS NULL) OR ([contactps] = @Original_contactps)) AND ((@IsNull_remark = 1 AND [remark] IS NULL) OR ([remark] = @Original_remark)) AND ((@IsNull_open_date = 1 AND [open_date] IS NULL) OR ([open_date] = @Original_open_date)) AND ([Status] = @Original_Status))";
            this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fullname", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fullname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_address", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_address", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_phone", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_phone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fax", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fax", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_person_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_person_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_place_issue", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_place_issue", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_email", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_email", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_due_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_due_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_bankname", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_bankname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_bank_br", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_bank_br", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_accnum", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_accnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Vatnum", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Vatnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_contactps", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_contactps", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_remark", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_remark", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_open_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Status", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
            this.sqlDataAdapter_0.InsertCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO [dbo].[tblCustomer] ([id], [Type], [fullname], [address], [phone], [fax], [person_id], [place_issue], [email], [due_date], [image], [bankname], [bank_br], [accnum], [Vatnum], [contactps], [remark], [open_date], [Status]) VALUES (@id, @Type, @fullname, @address, @phone, @fax, @person_id, @place_issue, @email, @due_date, @image, @bankname, @bank_br, @accnum, @Vatnum, @contactps, @remark, @open_date, @Status);\r\nSELECT id, Type, fullname, address, phone, fax, person_id, place_issue, email, due_date, image, bankname, bank_br, accnum, Vatnum, contactps, remark, open_date, Status FROM tblCustomer WHERE (id = @id)";
            this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@fullname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@fax", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@person_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@place_issue", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@image", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "image", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@bankname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@bank_br", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@accnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Vatnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@contactps", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@remark", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Status", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
            this.sqlDataAdapter_0.UpdateCommand.Connection = this.SqlConnection_0;
            this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE [dbo].[tblCustomer] SET [id] = @id, [Type] = @Type, [fullname] = @fullname, [address] = @address, [phone] = @phone, [fax] = @fax, [person_id] = @person_id, [place_issue] = @place_issue, [email] = @email, [due_date] = @due_date, [image] = @image, [bankname] = @bankname, [bank_br] = @bank_br, [accnum] = @accnum, [Vatnum] = @Vatnum, [contactps] = @contactps, [remark] = @remark, [open_date] = @open_date, [Status] = @Status WHERE (([id] = @Original_id) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND ((@IsNull_fullname = 1 AND [fullname] IS NULL) OR ([fullname] = @Original_fullname)) AND ((@IsNull_address = 1 AND [address] IS NULL) OR ([address] = @Original_address)) AND ((@IsNull_phone = 1 AND [phone] IS NULL) OR ([phone] = @Original_phone)) AND ((@IsNull_fax = 1 AND [fax] IS NULL) OR ([fax] = @Original_fax)) AND ((@IsNull_person_id = 1 AND [person_id] IS NULL) OR ([person_id] = @Original_person_id)) AND ((@IsNull_place_issue = 1 AND [place_issue] IS NULL) OR ([place_issue] = @Original_place_issue)) AND ((@IsNull_email = 1 AND [email] IS NULL) OR ([email] = @Original_email)) AND ((@IsNull_due_date = 1 AND [due_date] IS NULL) OR ([due_date] = @Original_due_date)) AND ((@IsNull_bankname = 1 AND [bankname] IS NULL) OR ([bankname] = @Original_bankname)) AND ((@IsNull_bank_br = 1 AND [bank_br] IS NULL) OR ([bank_br] = @Original_bank_br)) AND ((@IsNull_accnum = 1 AND [accnum] IS NULL) OR ([accnum] = @Original_accnum)) AND ((@IsNull_Vatnum = 1 AND [Vatnum] IS NULL) OR ([Vatnum] = @Original_Vatnum)) AND ((@IsNull_contactps = 1 AND [contactps] IS NULL) OR ([contactps] = @Original_contactps)) AND ((@IsNull_remark = 1 AND [remark] IS NULL) OR ([remark] = @Original_remark)) AND ((@IsNull_open_date = 1 AND [open_date] IS NULL) OR ([open_date] = @Original_open_date)) AND ([Status] = @Original_Status));\r\nSELECT id, Type, fullname, address, phone, fax, person_id, place_issue, email, due_date, image, bankname, bank_br, accnum, Vatnum, contactps, remark, open_date, Status FROM tblCustomer WHERE (id = @id)";
            this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@fullname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@fax", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@person_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@place_issue", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@due_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@image", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "image", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@bankname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@bank_br", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@accnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Vatnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@contactps", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@remark", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Status", DataRowVersion.Current, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Type", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Type", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fullname", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fullname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fullname", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_address", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_address", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "address", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_phone", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_phone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fax", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fax", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "fax", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_person_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_person_id", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "person_id", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_place_issue", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_place_issue", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "place_issue", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_email", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_email", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "email", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_due_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_due_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "due_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_bankname", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_bankname", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bankname", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_bank_br", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_bank_br", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "bank_br", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_accnum", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_accnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "accnum", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Vatnum", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Vatnum", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Vatnum", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_contactps", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_contactps", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "contactps", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_remark", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_remark", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "remark", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_open_date", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, true, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_open_date", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "open_date", DataRowVersion.Original, false, null, "", "", ""));
            this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Status", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Status", DataRowVersion.Original, false, null, "", "", ""));
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_1()
        {
            this.sqlConnection_0 = new SqlConnection();
            this.sqlConnection_0.ConnectionString = DataProvider.GetConnectionString();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            this.sqlCommand_0 = new SqlCommand[] { new SqlCommand() };
            this.sqlCommand_0[0].Connection = this.SqlConnection_0;
            this.sqlCommand_0[0].CommandText = "SELECT id, Type, fullname, address, phone, fax, person_id, place_issue, email, due_date, image, bankname, bank_br, accnum, Vatnum, contactps, remark, open_date, Status FROM dbo.tblCustomer";
            this.sqlCommand_0[0].CommandType = CommandType.Text;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(DataRow[] dataRows)
        {
            return this.Adapter.Update(dataRows);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(library_dataDataSet dataSet)
        {
            return this.Adapter.Update(dataSet, "tblCustomer");
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
        public virtual int Update(library_dataDataSet.tblCustomerDataTable dataTable)
        {
            return this.Adapter.Update(dataTable);
        }

        [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public virtual int Update(DataRow dataRow)
        {
            return this.Adapter.Update(new DataRow[] { dataRow });
        }

        [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Update, true)]
        public virtual int Update(int? Type, string fullname, string address, string phone, string fax, string person_id, string place_issue, string email, DateTime? due_date, byte[] image, string bankname, string bank_br, string accnum, string Vatnum, string contactps, string remark, DateTime? open_date, bool Status, string Original_id, int? Original_Type, string Original_fullname, string Original_address, string Original_phone, string Original_fax, string Original_person_id, string Original_place_issue, string Original_email, DateTime? Original_due_date, string Original_bankname, string Original_bank_br, string Original_accnum, string Original_Vatnum, string Original_contactps, string Original_remark, DateTime? Original_open_date, bool Original_Status)
        {
            return this.Update(Original_id, Type, fullname, address, phone, fax, person_id, place_issue, email, due_date, image, bankname, bank_br, accnum, Vatnum, contactps, remark, open_date, Status, Original_id, Original_Type, Original_fullname, Original_address, Original_phone, Original_fax, Original_person_id, Original_place_issue, Original_email, Original_due_date, Original_bankname, Original_bank_br, Original_accnum, Original_Vatnum, Original_contactps, Original_remark, Original_open_date, Original_Status);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
        public virtual int Update(string id, int? Type, string fullname, string address, string phone, string fax, string person_id, string place_issue, string email, DateTime? due_date, byte[] image, string bankname, string bank_br, string accnum, string Vatnum, string contactps, string remark, DateTime? open_date, bool Status, string Original_id, int? Original_Type, string Original_fullname, string Original_address, string Original_phone, string Original_fax, string Original_person_id, string Original_place_issue, string Original_email, DateTime? Original_due_date, string Original_bankname, string Original_bank_br, string Original_accnum, string Original_Vatnum, string Original_contactps, string Original_remark, DateTime? Original_open_date, bool Original_Status)
        {
            int num2;
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            this.Adapter.UpdateCommand.Parameters[0].Value = id;
            if (Type.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = Type.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
            }
            if (fullname == null)
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[2].Value = fullname;
            }
            if (address == null)
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[3].Value = address;
            }
            if (phone == null)
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[4].Value = phone;
            }
            if (fax == null)
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[5].Value = fax;
            }
            if (person_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[6].Value = person_id;
            }
            if (place_issue == null)
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[7].Value = place_issue;
            }
            if (email == null)
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[8].Value = email;
            }
            if (due_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[9].Value = due_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
            }
            if (image == null)
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[10].Value = image;
            }
            if (bankname == null)
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[11].Value = bankname;
            }
            if (bank_br == null)
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[12].Value = bank_br;
            }
            if (accnum == null)
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[13].Value = accnum;
            }
            if (Vatnum == null)
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[14].Value = Vatnum;
            }
            if (contactps == null)
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[15].Value = contactps;
            }
            if (remark == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x10].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x10].Value = remark;
            }
            if (open_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x11].Value = open_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x11].Value = DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[0x12].Value = Status;
            if (Original_id == null)
            {
                throw new ArgumentNullException("Original_id");
            }
            this.Adapter.UpdateCommand.Parameters[0x13].Value = Original_id;
            if (Original_Type.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x15].Value = Original_Type.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[20].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x15].Value = DBNull.Value;
            }
            if (Original_fullname == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x16].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x17].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x16].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x17].Value = Original_fullname;
            }
            if (Original_address == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x18].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x19].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x18].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x19].Value = Original_address;
            }
            if (Original_phone == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x1a].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x1b].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x1a].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x1b].Value = Original_phone;
            }
            if (Original_fax == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x1c].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x1d].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x1c].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x1d].Value = Original_fax;
            }
            if (Original_person_id == null)
            {
                this.Adapter.UpdateCommand.Parameters[30].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x1f].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[30].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x1f].Value = Original_person_id;
            }
            if (Original_place_issue == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x20].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x21].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x20].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x21].Value = Original_place_issue;
            }
            if (Original_email == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x22].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x23].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x22].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x23].Value = Original_email;
            }
            if (Original_due_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[0x24].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x25].Value = Original_due_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x24].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x25].Value = DBNull.Value;
            }
            if (Original_bankname == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x26].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x27].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x26].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x27].Value = Original_bankname;
            }
            if (Original_bank_br == null)
            {
                this.Adapter.UpdateCommand.Parameters[40].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x29].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[40].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x29].Value = Original_bank_br;
            }
            if (Original_accnum == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x2a].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2b].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x2a].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2b].Value = Original_accnum;
            }
            if (Original_Vatnum == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x2c].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2d].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x2c].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2d].Value = Original_Vatnum;
            }
            if (Original_contactps == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x2e].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x2f].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x2e].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x2f].Value = Original_contactps;
            }
            if (Original_remark == null)
            {
                this.Adapter.UpdateCommand.Parameters[0x30].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x31].Value = DBNull.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[0x30].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x31].Value = Original_remark;
            }
            if (Original_open_date.HasValue)
            {
                this.Adapter.UpdateCommand.Parameters[50].Value = 0;
                this.Adapter.UpdateCommand.Parameters[0x33].Value = Original_open_date.Value;
            }
            else
            {
                this.Adapter.UpdateCommand.Parameters[50].Value = 1;
                this.Adapter.UpdateCommand.Parameters[0x33].Value = DBNull.Value;
            }
            this.Adapter.UpdateCommand.Parameters[0x34].Value = Original_Status;
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

