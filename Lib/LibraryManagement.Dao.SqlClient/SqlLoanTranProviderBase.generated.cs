﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SqlLoanTranProvider.cs instead.
*/

#region using directives

using System;
using System.Data;
using System.Data.Common;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Specialized;

using System.Diagnostics;
using LibraryManagement.Domain;
using LibraryManagement.Dao;
using LibraryManagement.Dao.Bases;

#endregion

namespace LibraryManagement.Dao.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="LoanTran"/> entity.
	///</summary>
	public abstract partial class SqlLoanTranProviderBase : LoanTranProviderBase
	{
		#region Declarations
		
		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;
			
		#endregion "Declarations"
			
		#region Constructors
		
		/// <summary>
		/// Creates a new <see cref="SqlLoanTranProviderBase"/> instance.
		/// </summary>
		public SqlLoanTranProviderBase()
		{
		}
	
	/// <summary>
	/// Creates a new <see cref="SqlLoanTranProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlLoanTranProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}
		
	#endregion "Constructors"
	
		#region Public properties
	/// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string ConnectionString
	{
		get {return this._connectionString;}
		set {this._connectionString = value;}
	}
	
	/// <summary>
    /// Gets or sets a value indicating whether to use stored procedures.
    /// </summary>
    /// <value><c>true</c> if we choose to use use stored procedures; otherwise, <c>false</c>.</value>
	public bool UseStoredProcedure
	{
		get {return this._useStoredProcedure;}
		set {this._useStoredProcedure = value;}
	}
	
	/// <summary>
    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
    /// </summary>
    /// <value>The name of the provider invariant.</value>
    public string ProviderInvariantName
    {
        get { return this._providerInvariantName; }
        set { this._providerInvariantName = value; }
    }
	#endregion
	
		#region Get Many To Many Relationship Functions
		#endregion
	
		#region Delete Functions
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_transNum">. Primary Key.</param>	
		/// <param name="_goodsId">. Primary Key.</param>	
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Delete(TransactionManager transactionManager, System.String _transNum, System.String _goodsId)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@TransNum", DbType.StringFixedLength, _transNum);
			database.AddInParameter(commandWrapper, "@GoodsId", DbType.StringFixedLength, _goodsId);
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete")); 

			int results = 0;
			
			if (transactionManager != null)
			{	
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
			{
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(LoanTran)
					,_transNum,_goodsId);
                EntityManager.StopTracking(entityKey);
                
			}
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Delete")); 

			commandWrapper = null;
			
			return Convert.ToBoolean(results);
		}//end Delete
		#endregion

		#region Find Functions

		#region Parsed Find Methods
		/// <summary>
		/// 	Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks>Operators must be capitalized (OR, AND).</remarks>
		/// <returns>Returns a typed collection of LibraryManagement.Domain.LoanTran objects.</returns>
		public override TList<LoanTran> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<LoanTran>();
	
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;
		
		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);
		
		database.AddInParameter(commandWrapper, "@TransNum", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TranDate", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TransCode", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@TranTime", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@ExpId", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@CsId", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@GoodsId", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Qty", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DueDate", DbType.DateTime, DBNull.Value);
		database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, DBNull.Value);
		database.AddInParameter(commandWrapper, "@CorrTran", DbType.StringFixedLength, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Remark", DbType.String, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Status", DbType.Boolean, DBNull.Value);
	
			// replace all instances of 'AND' and 'OR' because we already set searchUsingOR
			whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|") ; 
			string[] clauses = whereClause.ToLower().Split('|');
		
			// Here's what's going on below: Find a field, then to get the value we
			// drop the field name from the front, trim spaces, drop the '=' sign,
			// trim more spaces, and drop any outer single quotes.
			// Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"
				
			char[] equalSign = {'='};
			char[] singleQuote = {'\''};
	   		foreach (string clause in clauses)
			{
				if (clause.Trim().StartsWith("trans_num ") || clause.Trim().StartsWith("trans_num="))
				{
					database.SetParameterValue(commandWrapper, "@TransNum", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tran_date ") || clause.Trim().StartsWith("tran_date="))
				{
					database.SetParameterValue(commandWrapper, "@TranDate", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("trans_code ") || clause.Trim().StartsWith("trans_code="))
				{
					database.SetParameterValue(commandWrapper, "@TransCode", 
						clause.Trim().Remove(0,10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("tran_time ") || clause.Trim().StartsWith("tran_time="))
				{
					database.SetParameterValue(commandWrapper, "@TranTime", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("exp_id ") || clause.Trim().StartsWith("exp_id="))
				{
					database.SetParameterValue(commandWrapper, "@ExpId", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("cs_id ") || clause.Trim().StartsWith("cs_id="))
				{
					database.SetParameterValue(commandWrapper, "@CsId", 
						clause.Trim().Remove(0,5).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("goods_id ") || clause.Trim().StartsWith("goods_id="))
				{
					database.SetParameterValue(commandWrapper, "@GoodsId", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("qty ") || clause.Trim().StartsWith("qty="))
				{
					database.SetParameterValue(commandWrapper, "@Qty", 
						clause.Trim().Remove(0,3).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("due_date ") || clause.Trim().StartsWith("due_date="))
				{
					database.SetParameterValue(commandWrapper, "@DueDate", 
						clause.Trim().Remove(0,8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("user_id ") || clause.Trim().StartsWith("user_id="))
				{
					database.SetParameterValue(commandWrapper, "@UserId", 
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("corr_tran ") || clause.Trim().StartsWith("corr_tran="))
				{
					database.SetParameterValue(commandWrapper, "@CorrTran", 
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("remark ") || clause.Trim().StartsWith("remark="))
				{
					database.SetParameterValue(commandWrapper, "@Remark", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("status ") || clause.Trim().StartsWith("status="))
				{
					database.SetParameterValue(commandWrapper, "@Status", 
						clause.Trim().Remove(0,6).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
	
				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}
					
			IDataReader reader = null;
			//Create Collection
			TList<LoanTran> rows = new TList<LoanTran>();
	
				
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
				
				Fill(reader, rows, start, pageLength);
				
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if (reader != null) 
					reader.Close();	
					
				commandWrapper = null;
			}
			return rows;
		}

		#endregion Parsed Find Methods
		
		#region Parameterized Find Methods
		
		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of LibraryManagement.Domain.LoanTran objects.</returns>
		public override TList<LoanTran> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;
			
			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else 
				filter = parameters.GetParameters();
				
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Find_Dynamic", typeof(LoanTranColumn), filter, orderBy, start, pageLength);
		
			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<LoanTran> rows = new TList<LoanTran>();
			IDataReader reader = null;
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows)); 

				if ( transactionManager != null )
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;
				
				if ( reader.NextResult() )
				{
					if ( reader.Read() )
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows)); 
			}
			finally
			{
				if ( reader != null )
					reader.Close();
					
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion Parameterized Find Methods
		
		#endregion Find Functions
	
		#region GetAll Methods
				
		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of LibraryManagement.Domain.LoanTran objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<LoanTran> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Get_List", _useStoredProcedure);
			
			IDataReader reader = null;
		
			//Create Collection
			TList<LoanTran> rows = new TList<LoanTran>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
					
				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				Fill(reader, rows, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows)); 
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;	
			}
			return rows;
		}//end getall
		
		#endregion
				
		#region GetPaged Methods
				
		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of LibraryManagement.Domain.LoanTran objects.</returns>
		public override TList<LoanTran> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_GetPaged", _useStoredProcedure);
		
			
            if (commandWrapper.CommandType == CommandType.Text
                && commandWrapper.CommandText != null)
            {
                commandWrapper.CommandText = commandWrapper.CommandText.Replace(SqlUtil.PAGE_INDEX, string.Concat(SqlUtil.PAGE_INDEX, Guid.NewGuid().ToString("N").Substring(0, 8)));
            }
			
			database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
			database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
			database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
			database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);
		
			IDataReader reader = null;
			//Create Collection
			TList<LoanTran> rows = new TList<LoanTran>();
			
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}
				
				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;

				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetPaged", rows)); 

			}
			catch(Exception)
			{			
				throw;
			}
			finally
			{
				if (reader != null) 
					reader.Close();
				
				commandWrapper = null;
			}
			
			return rows;
		}
		
		#endregion	
		
		#region Get By Foreign Key Functions
	#endregion
	
		#region Get By Index Functions

		#region GetByTransNumGoodsId
					
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_GetByTransNumGoodsId", _useStoredProcedure);
			
				database.AddInParameter(commandWrapper, "@TransNum", DbType.StringFixedLength, _transNum);
				database.AddInParameter(commandWrapper, "@GoodsId", DbType.StringFixedLength, _goodsId);
			
			IDataReader reader = null;
			TList<LoanTran> tmp = new TList<LoanTran>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByTransNumGoodsId", tmp)); 

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}		
		
				//Create collection and fill
				Fill(reader, tmp, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}
				
				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByTransNumGoodsId", tmp));
			}
			finally 
			{
				if (reader != null) 
					reader.Close();
					
				commandWrapper = null;
			}
			
			if (tmp.Count == 1)
			{
				return tmp[0];
			}
			else if (tmp.Count == 0)
			{
				return null;
			}
			else
			{
				throw new DataException("Cannot find the unique instance of the class.");
			}
			
			//return rows;
		}
		
		#endregion

	#endregion Get By Index Functions

		#region Insert Methods
		/// <summary>
		/// Lets you efficiently bulk insert many entities to the database.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		///		After inserting into the datasource, the LibraryManagement.Domain.LoanTran object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		public override void BulkInsert(TransactionManager transactionManager, TList<LibraryManagement.Domain.LoanTran> entities)
		{
			//System.Data.SqlClient.SqlBulkCopy bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			
			System.Data.SqlClient.SqlBulkCopy bulkCopy = null;
	
			if (transactionManager != null && transactionManager.IsOpen)
			{			
				System.Data.SqlClient.SqlConnection cnx = transactionManager.TransactionObject.Connection as System.Data.SqlClient.SqlConnection;
				System.Data.SqlClient.SqlTransaction transaction = transactionManager.TransactionObject as System.Data.SqlClient.SqlTransaction;
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(cnx, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints, transaction); //, null);
			}
			else
			{
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			}
			
			bulkCopy.BulkCopyTimeout = 360;
			bulkCopy.DestinationTableName = "tblLoanTran";
			
			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("trans_num", typeof(System.String));
			col0.AllowDBNull = false;		
			DataColumn col1 = dataTable.Columns.Add("tran_date", typeof(System.DateTime));
			col1.AllowDBNull = true;		
			DataColumn col2 = dataTable.Columns.Add("trans_code", typeof(System.String));
			col2.AllowDBNull = true;		
			DataColumn col3 = dataTable.Columns.Add("tran_time", typeof(System.String));
			col3.AllowDBNull = true;		
			DataColumn col4 = dataTable.Columns.Add("exp_id", typeof(System.String));
			col4.AllowDBNull = true;		
			DataColumn col5 = dataTable.Columns.Add("cs_id", typeof(System.String));
			col5.AllowDBNull = true;		
			DataColumn col6 = dataTable.Columns.Add("goods_id", typeof(System.String));
			col6.AllowDBNull = false;		
			DataColumn col7 = dataTable.Columns.Add("qty", typeof(System.Decimal));
			col7.AllowDBNull = true;		
			DataColumn col8 = dataTable.Columns.Add("due_date", typeof(System.DateTime));
			col8.AllowDBNull = true;		
			DataColumn col9 = dataTable.Columns.Add("user_id", typeof(System.Decimal));
			col9.AllowDBNull = true;		
			DataColumn col10 = dataTable.Columns.Add("corr_tran", typeof(System.String));
			col10.AllowDBNull = true;		
			DataColumn col11 = dataTable.Columns.Add("remark", typeof(System.String));
			col11.AllowDBNull = true;		
			DataColumn col12 = dataTable.Columns.Add("status", typeof(System.Boolean));
			col12.AllowDBNull = true;		
			
			bulkCopy.ColumnMappings.Add("trans_num", "trans_num");
			bulkCopy.ColumnMappings.Add("tran_date", "tran_date");
			bulkCopy.ColumnMappings.Add("trans_code", "trans_code");
			bulkCopy.ColumnMappings.Add("tran_time", "tran_time");
			bulkCopy.ColumnMappings.Add("exp_id", "exp_id");
			bulkCopy.ColumnMappings.Add("cs_id", "cs_id");
			bulkCopy.ColumnMappings.Add("goods_id", "goods_id");
			bulkCopy.ColumnMappings.Add("qty", "qty");
			bulkCopy.ColumnMappings.Add("due_date", "due_date");
			bulkCopy.ColumnMappings.Add("user_id", "user_id");
			bulkCopy.ColumnMappings.Add("corr_tran", "corr_tran");
			bulkCopy.ColumnMappings.Add("remark", "remark");
			bulkCopy.ColumnMappings.Add("status", "status");
			
			foreach(LibraryManagement.Domain.LoanTran entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
					
				DataRow row = dataTable.NewRow();
				
					row["trans_num"] = entity.TransNum;
							
				
					row["tran_date"] = entity.TranDate.HasValue ? (object) entity.TranDate  : System.DBNull.Value;
							
				
					row["trans_code"] = entity.TransCode;
							
				
					row["tran_time"] = entity.TranTime;
							
				
					row["exp_id"] = entity.ExpId;
							
				
					row["cs_id"] = entity.CsId;
							
				
					row["goods_id"] = entity.GoodsId;
							
				
					row["qty"] = entity.Qty.HasValue ? (object) entity.Qty  : System.DBNull.Value;
							
				
					row["due_date"] = entity.DueDate.HasValue ? (object) entity.DueDate  : System.DBNull.Value;
							
				
					row["user_id"] = entity.UserId.HasValue ? (object) entity.UserId  : System.DBNull.Value;
							
				
					row["corr_tran"] = entity.CorrTran;
							
				
					row["remark"] = entity.Remark;
							
				
					row["status"] = entity.Status.HasValue ? (object) entity.Status  : System.DBNull.Value;
							
				
				dataTable.Rows.Add(row);
			}		
			
			// send the data to the server		
			bulkCopy.WriteToServer(dataTable);		
			
			// update back the state
			foreach(LibraryManagement.Domain.LoanTran entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;
			
				entity.AcceptChanges();
			}
		}
				
		/// <summary>
		/// 	Inserts a LibraryManagement.Domain.LoanTran object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">LibraryManagement.Domain.LoanTran object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the LibraryManagement.Domain.LoanTran object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>	
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, LibraryManagement.Domain.LoanTran entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Insert", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@TransNum", DbType.StringFixedLength, entity.TransNum );
			database.AddInParameter(commandWrapper, "@TranDate", DbType.DateTime, (entity.TranDate.HasValue ? (object) entity.TranDate  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TransCode", DbType.StringFixedLength, entity.TransCode );
            database.AddInParameter(commandWrapper, "@TranTime", DbType.StringFixedLength, entity.TranTime );
            database.AddInParameter(commandWrapper, "@ExpId", DbType.StringFixedLength, entity.ExpId );
            database.AddInParameter(commandWrapper, "@CsId", DbType.StringFixedLength, entity.CsId );
            database.AddInParameter(commandWrapper, "@GoodsId", DbType.StringFixedLength, entity.GoodsId );
			database.AddInParameter(commandWrapper, "@Qty", DbType.Decimal, (entity.Qty.HasValue ? (object) entity.Qty  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@DueDate", DbType.DateTime, (entity.DueDate.HasValue ? (object) entity.DueDate  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, (entity.UserId.HasValue ? (object) entity.UserId  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CorrTran", DbType.StringFixedLength, entity.CorrTran );
            database.AddInParameter(commandWrapper, "@Remark", DbType.String, entity.Remark );
			database.AddInParameter(commandWrapper, "@Status", DbType.Boolean, (entity.Status.HasValue ? (object) entity.Status  : System.DBNull.Value));
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));
				
			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
					
			
			entity.OriginalTransNum = entity.TransNum;
			entity.OriginalGoodsId = entity.GoodsId;
			
			entity.AcceptChanges();
	
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

			return Convert.ToBoolean(results);
		}	
		#endregion

		#region Update Methods
				
		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">LibraryManagement.Domain.LoanTran object to update.</param>
		/// <remarks>
		///		After updating the datasource, the LibraryManagement.Domain.LoanTran object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Update(TransactionManager transactionManager, LibraryManagement.Domain.LoanTran entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.usptblLoanTran_Update", _useStoredProcedure);
			
            database.AddInParameter(commandWrapper, "@TransNum", DbType.StringFixedLength, entity.TransNum );
			database.AddInParameter(commandWrapper, "@OriginalTransNum", DbType.StringFixedLength, entity.OriginalTransNum);
			database.AddInParameter(commandWrapper, "@TranDate", DbType.DateTime, (entity.TranDate.HasValue ? (object) entity.TranDate : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@TransCode", DbType.StringFixedLength, entity.TransCode );
            database.AddInParameter(commandWrapper, "@TranTime", DbType.StringFixedLength, entity.TranTime );
            database.AddInParameter(commandWrapper, "@ExpId", DbType.StringFixedLength, entity.ExpId );
            database.AddInParameter(commandWrapper, "@CsId", DbType.StringFixedLength, entity.CsId );
            database.AddInParameter(commandWrapper, "@GoodsId", DbType.StringFixedLength, entity.GoodsId );
			database.AddInParameter(commandWrapper, "@OriginalGoodsId", DbType.StringFixedLength, entity.OriginalGoodsId);
			database.AddInParameter(commandWrapper, "@Qty", DbType.Decimal, (entity.Qty.HasValue ? (object) entity.Qty : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@DueDate", DbType.DateTime, (entity.DueDate.HasValue ? (object) entity.DueDate : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, (entity.UserId.HasValue ? (object) entity.UserId : System.DBNull.Value) );
            database.AddInParameter(commandWrapper, "@CorrTran", DbType.StringFixedLength, entity.CorrTran );
            database.AddInParameter(commandWrapper, "@Remark", DbType.String, entity.Remark );
			database.AddInParameter(commandWrapper, "@Status", DbType.Boolean, (entity.Status.HasValue ? (object) entity.Status : System.DBNull.Value) );
			
			int results = 0;
			
			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
			
			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
            {
                EntityManager.StopTracking(entity.EntityTrackingKey);				
            }
			
			entity.OriginalTransNum = entity.TransNum;
			entity.OriginalGoodsId = entity.GoodsId;
			
			entity.AcceptChanges();
			
			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

			return Convert.ToBoolean(results);
		}
			
		#endregion
		
		#region Custom Methods
	
		#endregion
	}//end class
} // end namespace
