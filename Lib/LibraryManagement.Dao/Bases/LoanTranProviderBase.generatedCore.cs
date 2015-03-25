#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using LibraryManagement.Domain;
using LibraryManagement.Dao;

#endregion

namespace LibraryManagement.Dao.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="LoanTranProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LoanTranProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.LoanTran, LibraryManagement.Domain.LoanTranKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.LoanTranKey key)
		{
			return Delete(transactionManager, key.TransNum, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_transNum">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _transNum, System.String _goodsId)
		{
			return Delete(null, _transNum, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _transNum, System.String _goodsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override LibraryManagement.Domain.LoanTran Get(TransactionManager transactionManager, LibraryManagement.Domain.LoanTranKey key, int start, int pageLength)
		{
			return GetByTransNumGoodsId(transactionManager, key.TransNum, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblLoanTran index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(System.String _transNum, System.String _goodsId)
		{
			int count = -1;
			return GetByTransNumGoodsId(null,_transNum, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(System.String _transNum, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNumGoodsId(null, _transNum, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId)
		{
			int count = -1;
			return GetByTransNumGoodsId(transactionManager, _transNum, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNumGoodsId(transactionManager, _transNum, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(System.String _transNum, System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByTransNumGoodsId(null, _transNum, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLoanTran index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.LoanTran"/> class.</returns>
		public abstract LibraryManagement.Domain.LoanTran GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;LoanTran&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;LoanTran&gt;"/></returns>
		public static TList<LoanTran> Fill(IDataReader reader, TList<LoanTran> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				LibraryManagement.Domain.LoanTran c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("LoanTran")
					.Append("|").Append((System.String)reader[((int)LoanTranColumn.TransNum - 1)])
					.Append("|").Append((System.String)reader[((int)LoanTranColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<LoanTran>(
					key.ToString(), // EntityTrackingKey
					"LoanTran",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.LoanTran();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.TransNum = (System.String)reader[((int)LoanTranColumn.TransNum - 1)];
					c.OriginalTransNum = c.TransNum;
					c.TranDate = (reader.IsDBNull(((int)LoanTranColumn.TranDate - 1)))?null:(System.DateTime?)reader[((int)LoanTranColumn.TranDate - 1)];
					c.TransCode = (reader.IsDBNull(((int)LoanTranColumn.TransCode - 1)))?null:(System.String)reader[((int)LoanTranColumn.TransCode - 1)];
					c.TranTime = (reader.IsDBNull(((int)LoanTranColumn.TranTime - 1)))?null:(System.String)reader[((int)LoanTranColumn.TranTime - 1)];
					c.ExpId = (reader.IsDBNull(((int)LoanTranColumn.ExpId - 1)))?null:(System.String)reader[((int)LoanTranColumn.ExpId - 1)];
					c.CsId = (reader.IsDBNull(((int)LoanTranColumn.CsId - 1)))?null:(System.String)reader[((int)LoanTranColumn.CsId - 1)];
					c.GoodsId = (System.String)reader[((int)LoanTranColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.Qty = (reader.IsDBNull(((int)LoanTranColumn.Qty - 1)))?null:(System.Decimal?)reader[((int)LoanTranColumn.Qty - 1)];
					c.DueDate = (reader.IsDBNull(((int)LoanTranColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)LoanTranColumn.DueDate - 1)];
					c.UserId = (reader.IsDBNull(((int)LoanTranColumn.UserId - 1)))?null:(System.Decimal?)reader[((int)LoanTranColumn.UserId - 1)];
					c.CorrTran = (reader.IsDBNull(((int)LoanTranColumn.CorrTran - 1)))?null:(System.String)reader[((int)LoanTranColumn.CorrTran - 1)];
					c.Remark = (reader.IsDBNull(((int)LoanTranColumn.Remark - 1)))?null:(System.String)reader[((int)LoanTranColumn.Remark - 1)];
					c.Status = (reader.IsDBNull(((int)LoanTranColumn.Status - 1)))?null:(System.Boolean?)reader[((int)LoanTranColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.LoanTran"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.LoanTran"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.LoanTran entity)
		{
			if (!reader.Read()) return;
			
			entity.TransNum = (System.String)reader[((int)LoanTranColumn.TransNum - 1)];
			entity.OriginalTransNum = (System.String)reader["trans_num"];
			entity.TranDate = (reader.IsDBNull(((int)LoanTranColumn.TranDate - 1)))?null:(System.DateTime?)reader[((int)LoanTranColumn.TranDate - 1)];
			entity.TransCode = (reader.IsDBNull(((int)LoanTranColumn.TransCode - 1)))?null:(System.String)reader[((int)LoanTranColumn.TransCode - 1)];
			entity.TranTime = (reader.IsDBNull(((int)LoanTranColumn.TranTime - 1)))?null:(System.String)reader[((int)LoanTranColumn.TranTime - 1)];
			entity.ExpId = (reader.IsDBNull(((int)LoanTranColumn.ExpId - 1)))?null:(System.String)reader[((int)LoanTranColumn.ExpId - 1)];
			entity.CsId = (reader.IsDBNull(((int)LoanTranColumn.CsId - 1)))?null:(System.String)reader[((int)LoanTranColumn.CsId - 1)];
			entity.GoodsId = (System.String)reader[((int)LoanTranColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.Qty = (reader.IsDBNull(((int)LoanTranColumn.Qty - 1)))?null:(System.Decimal?)reader[((int)LoanTranColumn.Qty - 1)];
			entity.DueDate = (reader.IsDBNull(((int)LoanTranColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)LoanTranColumn.DueDate - 1)];
			entity.UserId = (reader.IsDBNull(((int)LoanTranColumn.UserId - 1)))?null:(System.Decimal?)reader[((int)LoanTranColumn.UserId - 1)];
			entity.CorrTran = (reader.IsDBNull(((int)LoanTranColumn.CorrTran - 1)))?null:(System.String)reader[((int)LoanTranColumn.CorrTran - 1)];
			entity.Remark = (reader.IsDBNull(((int)LoanTranColumn.Remark - 1)))?null:(System.String)reader[((int)LoanTranColumn.Remark - 1)];
			entity.Status = (reader.IsDBNull(((int)LoanTranColumn.Status - 1)))?null:(System.Boolean?)reader[((int)LoanTranColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.LoanTran"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.LoanTran"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.LoanTran entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TransNum = (System.String)dataRow["trans_num"];
			entity.OriginalTransNum = (System.String)dataRow["trans_num"];
			entity.TranDate = Convert.IsDBNull(dataRow["tran_date"]) ? null : (System.DateTime?)dataRow["tran_date"];
			entity.TransCode = Convert.IsDBNull(dataRow["trans_code"]) ? null : (System.String)dataRow["trans_code"];
			entity.TranTime = Convert.IsDBNull(dataRow["tran_time"]) ? null : (System.String)dataRow["tran_time"];
			entity.ExpId = Convert.IsDBNull(dataRow["exp_id"]) ? null : (System.String)dataRow["exp_id"];
			entity.CsId = Convert.IsDBNull(dataRow["cs_id"]) ? null : (System.String)dataRow["cs_id"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.Qty = Convert.IsDBNull(dataRow["qty"]) ? null : (System.Decimal?)dataRow["qty"];
			entity.DueDate = Convert.IsDBNull(dataRow["due_date"]) ? null : (System.DateTime?)dataRow["due_date"];
			entity.UserId = Convert.IsDBNull(dataRow["user_id"]) ? null : (System.Decimal?)dataRow["user_id"];
			entity.CorrTran = Convert.IsDBNull(dataRow["corr_tran"]) ? null : (System.String)dataRow["corr_tran"];
			entity.Remark = Convert.IsDBNull(dataRow["remark"]) ? null : (System.String)dataRow["remark"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Boolean?)dataRow["status"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.LoanTran"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.LoanTran Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.LoanTran entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the LibraryManagement.Domain.LoanTran object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.LoanTran instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.LoanTran Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.LoanTran entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region LoanTranChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.LoanTran</c>
	///</summary>
	public enum LoanTranChildEntityTypes
	{
	}
	
	#endregion LoanTranChildEntityTypes
	
	#region LoanTranFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LoanTranColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoanTran"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoanTranFilterBuilder : SqlFilterBuilder<LoanTranColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoanTranFilterBuilder class.
		/// </summary>
		public LoanTranFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoanTranFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoanTranFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoanTranFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoanTranFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoanTranFilterBuilder
	
	#region LoanTranParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LoanTranColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoanTran"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoanTranParameterBuilder : ParameterizedSqlFilterBuilder<LoanTranColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoanTranParameterBuilder class.
		/// </summary>
		public LoanTranParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoanTranParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoanTranParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoanTranParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoanTranParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoanTranParameterBuilder
	
	#region LoanTranSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LoanTranColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoanTran"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LoanTranSortBuilder : SqlSortBuilder<LoanTranColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoanTranSqlSortBuilder class.
		/// </summary>
		public LoanTranSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LoanTranSortBuilder
	
} // end namespace
