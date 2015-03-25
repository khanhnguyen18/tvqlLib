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
	/// This class is the base class for any <see cref="StockInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class StockInfoProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.StockInfo, LibraryManagement.Domain.StockInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.StockInfoKey key)
		{
			return Delete(transactionManager, key.Id, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _id, System.String _goodsId)
		{
			return Delete(null, _id, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _id, System.String _goodsId);		
		
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
		public override LibraryManagement.Domain.StockInfo Get(TransactionManager transactionManager, LibraryManagement.Domain.StockInfoKey key, int start, int pageLength)
		{
			return GetByIdGoodsId(transactionManager, key.Id, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblStockInfo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public LibraryManagement.Domain.StockInfo GetByIdGoodsId(System.String _id, System.String _goodsId)
		{
			int count = -1;
			return GetByIdGoodsId(null,_id, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStockInfo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public LibraryManagement.Domain.StockInfo GetByIdGoodsId(System.String _id, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByIdGoodsId(null, _id, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStockInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public LibraryManagement.Domain.StockInfo GetByIdGoodsId(TransactionManager transactionManager, System.String _id, System.String _goodsId)
		{
			int count = -1;
			return GetByIdGoodsId(transactionManager, _id, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStockInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public LibraryManagement.Domain.StockInfo GetByIdGoodsId(TransactionManager transactionManager, System.String _id, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByIdGoodsId(transactionManager, _id, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStockInfo index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public LibraryManagement.Domain.StockInfo GetByIdGoodsId(System.String _id, System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByIdGoodsId(null, _id, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStockInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.StockInfo"/> class.</returns>
		public abstract LibraryManagement.Domain.StockInfo GetByIdGoodsId(TransactionManager transactionManager, System.String _id, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;StockInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;StockInfo&gt;"/></returns>
		public static TList<StockInfo> Fill(IDataReader reader, TList<StockInfo> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.StockInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("StockInfo")
					.Append("|").Append((System.String)reader[((int)StockInfoColumn.Id - 1)])
					.Append("|").Append((System.String)reader[((int)StockInfoColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<StockInfo>(
					key.ToString(), // EntityTrackingKey
					"StockInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.StockInfo();
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
					c.Id = (System.String)reader[((int)StockInfoColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.GoodsId = (System.String)reader[((int)StockInfoColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.OpenDate = (reader.IsDBNull(((int)StockInfoColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.OpenDate - 1)];
					c.LastDate = (reader.IsDBNull(((int)StockInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.LastDate - 1)];
					c.MinusDate = (reader.IsDBNull(((int)StockInfoColumn.MinusDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.MinusDate - 1)];
					c.StktakeDt = (reader.IsDBNull(((int)StockInfoColumn.StktakeDt - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.StktakeDt - 1)];
					c.StktakeTm = (reader.IsDBNull(((int)StockInfoColumn.StktakeTm - 1)))?null:(System.String)reader[((int)StockInfoColumn.StktakeTm - 1)];
					c.BeginQty = (reader.IsDBNull(((int)StockInfoColumn.BeginQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.BeginQty - 1)];
					c.ExpQty = (reader.IsDBNull(((int)StockInfoColumn.ExpQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ExpQty - 1)];
					c.ImpQty = (reader.IsDBNull(((int)StockInfoColumn.ImpQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ImpQty - 1)];
					c.BeginAmt = (reader.IsDBNull(((int)StockInfoColumn.BeginAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.BeginAmt - 1)];
					c.ExpAmt = (reader.IsDBNull(((int)StockInfoColumn.ExpAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ExpAmt - 1)];
					c.ImpAmt = (reader.IsDBNull(((int)StockInfoColumn.ImpAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ImpAmt - 1)];
					c.Averimppr = (reader.IsDBNull(((int)StockInfoColumn.Averimppr - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.Averimppr - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.StockInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.StockInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.StockInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.String)reader[((int)StockInfoColumn.Id - 1)];
			entity.OriginalId = (System.String)reader["id"];
			entity.GoodsId = (System.String)reader[((int)StockInfoColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.OpenDate = (reader.IsDBNull(((int)StockInfoColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.OpenDate - 1)];
			entity.LastDate = (reader.IsDBNull(((int)StockInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.LastDate - 1)];
			entity.MinusDate = (reader.IsDBNull(((int)StockInfoColumn.MinusDate - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.MinusDate - 1)];
			entity.StktakeDt = (reader.IsDBNull(((int)StockInfoColumn.StktakeDt - 1)))?null:(System.DateTime?)reader[((int)StockInfoColumn.StktakeDt - 1)];
			entity.StktakeTm = (reader.IsDBNull(((int)StockInfoColumn.StktakeTm - 1)))?null:(System.String)reader[((int)StockInfoColumn.StktakeTm - 1)];
			entity.BeginQty = (reader.IsDBNull(((int)StockInfoColumn.BeginQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.BeginQty - 1)];
			entity.ExpQty = (reader.IsDBNull(((int)StockInfoColumn.ExpQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ExpQty - 1)];
			entity.ImpQty = (reader.IsDBNull(((int)StockInfoColumn.ImpQty - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ImpQty - 1)];
			entity.BeginAmt = (reader.IsDBNull(((int)StockInfoColumn.BeginAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.BeginAmt - 1)];
			entity.ExpAmt = (reader.IsDBNull(((int)StockInfoColumn.ExpAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ExpAmt - 1)];
			entity.ImpAmt = (reader.IsDBNull(((int)StockInfoColumn.ImpAmt - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.ImpAmt - 1)];
			entity.Averimppr = (reader.IsDBNull(((int)StockInfoColumn.Averimppr - 1)))?null:(System.Decimal?)reader[((int)StockInfoColumn.Averimppr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.StockInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.StockInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.StockInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.String)dataRow["id"];
			entity.OriginalId = (System.String)dataRow["id"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.OpenDate = Convert.IsDBNull(dataRow["open_date"]) ? null : (System.DateTime?)dataRow["open_date"];
			entity.LastDate = Convert.IsDBNull(dataRow["last_date"]) ? null : (System.DateTime?)dataRow["last_date"];
			entity.MinusDate = Convert.IsDBNull(dataRow["minus_date"]) ? null : (System.DateTime?)dataRow["minus_date"];
			entity.StktakeDt = Convert.IsDBNull(dataRow["stktake_dt"]) ? null : (System.DateTime?)dataRow["stktake_dt"];
			entity.StktakeTm = Convert.IsDBNull(dataRow["stktake_tm"]) ? null : (System.String)dataRow["stktake_tm"];
			entity.BeginQty = Convert.IsDBNull(dataRow["begin_qty"]) ? null : (System.Decimal?)dataRow["begin_qty"];
			entity.ExpQty = Convert.IsDBNull(dataRow["exp_qty"]) ? null : (System.Decimal?)dataRow["exp_qty"];
			entity.ImpQty = Convert.IsDBNull(dataRow["imp_qty"]) ? null : (System.Decimal?)dataRow["imp_qty"];
			entity.BeginAmt = Convert.IsDBNull(dataRow["begin_amt"]) ? null : (System.Decimal?)dataRow["begin_amt"];
			entity.ExpAmt = Convert.IsDBNull(dataRow["exp_amt"]) ? null : (System.Decimal?)dataRow["exp_amt"];
			entity.ImpAmt = Convert.IsDBNull(dataRow["imp_amt"]) ? null : (System.Decimal?)dataRow["imp_amt"];
			entity.Averimppr = Convert.IsDBNull(dataRow["averimppr"]) ? null : (System.Decimal?)dataRow["averimppr"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.StockInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.StockInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.StockInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.StockInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.StockInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.StockInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.StockInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region StockInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.StockInfo</c>
	///</summary>
	public enum StockInfoChildEntityTypes
	{
	}
	
	#endregion StockInfoChildEntityTypes
	
	#region StockInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;StockInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StockInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StockInfoFilterBuilder : SqlFilterBuilder<StockInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StockInfoFilterBuilder class.
		/// </summary>
		public StockInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StockInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StockInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StockInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StockInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StockInfoFilterBuilder
	
	#region StockInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;StockInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StockInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StockInfoParameterBuilder : ParameterizedSqlFilterBuilder<StockInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StockInfoParameterBuilder class.
		/// </summary>
		public StockInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StockInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StockInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StockInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StockInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StockInfoParameterBuilder
	
	#region StockInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;StockInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StockInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class StockInfoSortBuilder : SqlSortBuilder<StockInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StockInfoSqlSortBuilder class.
		/// </summary>
		public StockInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion StockInfoSortBuilder
	
} // end namespace
