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
	/// This class is the base class for any <see cref="CustInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CustInfoProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.CustInfo, LibraryManagement.Domain.CustInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.CustInfoKey key)
		{
			return Delete(transactionManager, key.CustId, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_custId">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _custId, System.String _goodsId)
		{
			return Delete(null, _custId, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_custId">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _custId, System.String _goodsId);		
		
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
		public override LibraryManagement.Domain.CustInfo Get(TransactionManager transactionManager, LibraryManagement.Domain.CustInfoKey key, int start, int pageLength)
		{
			return GetByCustIdGoodsId(transactionManager, key.CustId, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblCust_info index.
		/// </summary>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(System.String _custId, System.String _goodsId)
		{
			int count = -1;
			return GetByCustIdGoodsId(null,_custId, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCust_info index.
		/// </summary>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(System.String _custId, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByCustIdGoodsId(null, _custId, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCust_info index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(TransactionManager transactionManager, System.String _custId, System.String _goodsId)
		{
			int count = -1;
			return GetByCustIdGoodsId(transactionManager, _custId, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCust_info index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(TransactionManager transactionManager, System.String _custId, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByCustIdGoodsId(transactionManager, _custId, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCust_info index.
		/// </summary>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(System.String _custId, System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByCustIdGoodsId(null, _custId, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCust_info index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_custId"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CustInfo"/> class.</returns>
		public abstract LibraryManagement.Domain.CustInfo GetByCustIdGoodsId(TransactionManager transactionManager, System.String _custId, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CustInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CustInfo&gt;"/></returns>
		public static TList<CustInfo> Fill(IDataReader reader, TList<CustInfo> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.CustInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CustInfo")
					.Append("|").Append((System.String)reader[((int)CustInfoColumn.CustId - 1)])
					.Append("|").Append((System.String)reader[((int)CustInfoColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CustInfo>(
					key.ToString(), // EntityTrackingKey
					"CustInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.CustInfo();
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
					c.CustId = (System.String)reader[((int)CustInfoColumn.CustId - 1)];
					c.OriginalCustId = c.CustId;
					c.GoodsId = (System.String)reader[((int)CustInfoColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.ImpQty = (reader.IsDBNull(((int)CustInfoColumn.ImpQty - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ImpQty - 1)];
					c.ImpAmt = (reader.IsDBNull(((int)CustInfoColumn.ImpAmt - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ImpAmt - 1)];
					c.ExpQty = (reader.IsDBNull(((int)CustInfoColumn.ExpQty - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ExpQty - 1)];
					c.ExpAmt = (reader.IsDBNull(((int)CustInfoColumn.ExpAmt - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ExpAmt - 1)];
					c.Lastwspr = (reader.IsDBNull(((int)CustInfoColumn.Lastwspr - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.Lastwspr - 1)];
					c.LastDate = (reader.IsDBNull(((int)CustInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)CustInfoColumn.LastDate - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.CustInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CustInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.CustInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.CustId = (System.String)reader[((int)CustInfoColumn.CustId - 1)];
			entity.OriginalCustId = (System.String)reader["Cust_id"];
			entity.GoodsId = (System.String)reader[((int)CustInfoColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.ImpQty = (reader.IsDBNull(((int)CustInfoColumn.ImpQty - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ImpQty - 1)];
			entity.ImpAmt = (reader.IsDBNull(((int)CustInfoColumn.ImpAmt - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ImpAmt - 1)];
			entity.ExpQty = (reader.IsDBNull(((int)CustInfoColumn.ExpQty - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ExpQty - 1)];
			entity.ExpAmt = (reader.IsDBNull(((int)CustInfoColumn.ExpAmt - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.ExpAmt - 1)];
			entity.Lastwspr = (reader.IsDBNull(((int)CustInfoColumn.Lastwspr - 1)))?null:(System.Decimal?)reader[((int)CustInfoColumn.Lastwspr - 1)];
			entity.LastDate = (reader.IsDBNull(((int)CustInfoColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)CustInfoColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.CustInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CustInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.CustInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CustId = (System.String)dataRow["Cust_id"];
			entity.OriginalCustId = (System.String)dataRow["Cust_id"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.ImpQty = Convert.IsDBNull(dataRow["imp_qty"]) ? null : (System.Decimal?)dataRow["imp_qty"];
			entity.ImpAmt = Convert.IsDBNull(dataRow["imp_amt"]) ? null : (System.Decimal?)dataRow["imp_amt"];
			entity.ExpQty = Convert.IsDBNull(dataRow["exp_qty"]) ? null : (System.Decimal?)dataRow["exp_qty"];
			entity.ExpAmt = Convert.IsDBNull(dataRow["exp_amt"]) ? null : (System.Decimal?)dataRow["exp_amt"];
			entity.Lastwspr = Convert.IsDBNull(dataRow["lastwspr"]) ? null : (System.Decimal?)dataRow["lastwspr"];
			entity.LastDate = Convert.IsDBNull(dataRow["last_date"]) ? null : (System.DateTime?)dataRow["last_date"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CustInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.CustInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.CustInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.CustInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.CustInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.CustInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.CustInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CustInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.CustInfo</c>
	///</summary>
	public enum CustInfoChildEntityTypes
	{
	}
	
	#endregion CustInfoChildEntityTypes
	
	#region CustInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CustInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CustInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustInfoFilterBuilder : SqlFilterBuilder<CustInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustInfoFilterBuilder class.
		/// </summary>
		public CustInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustInfoFilterBuilder
	
	#region CustInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CustInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CustInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustInfoParameterBuilder : ParameterizedSqlFilterBuilder<CustInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustInfoParameterBuilder class.
		/// </summary>
		public CustInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustInfoParameterBuilder
	
	#region CustInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CustInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CustInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CustInfoSortBuilder : SqlSortBuilder<CustInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustInfoSqlSortBuilder class.
		/// </summary>
		public CustInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CustInfoSortBuilder
	
} // end namespace
