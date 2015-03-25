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
	/// This class is the base class for any <see cref="OnOrderProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class OnOrderProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.OnOrder, LibraryManagement.Domain.OnOrderKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.OnOrderKey key)
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
		public override LibraryManagement.Domain.OnOrder Get(TransactionManager transactionManager, LibraryManagement.Domain.OnOrderKey key, int start, int pageLength)
		{
			return GetByTransNumGoodsId(transactionManager, key.TransNum, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblOn_order index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(System.String _transNum, System.String _goodsId)
		{
			int count = -1;
			return GetByTransNumGoodsId(null,_transNum, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblOn_order index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(System.String _transNum, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNumGoodsId(null, _transNum, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblOn_order index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId)
		{
			int count = -1;
			return GetByTransNumGoodsId(transactionManager, _transNum, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblOn_order index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNumGoodsId(transactionManager, _transNum, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblOn_order index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(System.String _transNum, System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByTransNumGoodsId(null, _transNum, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblOn_order index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.OnOrder"/> class.</returns>
		public abstract LibraryManagement.Domain.OnOrder GetByTransNumGoodsId(TransactionManager transactionManager, System.String _transNum, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;OnOrder&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;OnOrder&gt;"/></returns>
		public static TList<OnOrder> Fill(IDataReader reader, TList<OnOrder> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.OnOrder c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("OnOrder")
					.Append("|").Append((System.String)reader[((int)OnOrderColumn.TransNum - 1)])
					.Append("|").Append((System.String)reader[((int)OnOrderColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<OnOrder>(
					key.ToString(), // EntityTrackingKey
					"OnOrder",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.OnOrder();
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
					c.TranDate = (System.DateTime)reader[((int)OnOrderColumn.TranDate - 1)];
					c.TranTime = (System.String)reader[((int)OnOrderColumn.TranTime - 1)];
					c.DeliverDt = (reader.IsDBNull(((int)OnOrderColumn.DeliverDt - 1)))?null:(System.DateTime?)reader[((int)OnOrderColumn.DeliverDt - 1)];
					c.TransNum = (System.String)reader[((int)OnOrderColumn.TransNum - 1)];
					c.OriginalTransNum = c.TransNum;
					c.TransCode = (System.String)reader[((int)OnOrderColumn.TransCode - 1)];
					c.ExpId = (System.String)reader[((int)OnOrderColumn.ExpId - 1)];
					c.GoodsId = (System.String)reader[((int)OnOrderColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.Qty = (System.Decimal)reader[((int)OnOrderColumn.Qty - 1)];
					c.UnitSymb = (System.String)reader[((int)OnOrderColumn.UnitSymb - 1)];
					c.Price = (System.Decimal)reader[((int)OnOrderColumn.Price - 1)];
					c.MercType = (System.String)reader[((int)OnOrderColumn.MercType - 1)];
					c.UserId = (System.Decimal)reader[((int)OnOrderColumn.UserId - 1)];
					c.Remark = (System.String)reader[((int)OnOrderColumn.Remark - 1)];
					c.Recnum = (System.Decimal)reader[((int)OnOrderColumn.Recnum - 1)];
					c.Status = (reader.IsDBNull(((int)OnOrderColumn.Status - 1)))?null:(System.Boolean?)reader[((int)OnOrderColumn.Status - 1)];
					c.EndQty = (reader.IsDBNull(((int)OnOrderColumn.EndQty - 1)))?null:(System.Decimal?)reader[((int)OnOrderColumn.EndQty - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.OnOrder"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.OnOrder"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.OnOrder entity)
		{
			if (!reader.Read()) return;
			
			entity.TranDate = (System.DateTime)reader[((int)OnOrderColumn.TranDate - 1)];
			entity.TranTime = (System.String)reader[((int)OnOrderColumn.TranTime - 1)];
			entity.DeliverDt = (reader.IsDBNull(((int)OnOrderColumn.DeliverDt - 1)))?null:(System.DateTime?)reader[((int)OnOrderColumn.DeliverDt - 1)];
			entity.TransNum = (System.String)reader[((int)OnOrderColumn.TransNum - 1)];
			entity.OriginalTransNum = (System.String)reader["trans_num"];
			entity.TransCode = (System.String)reader[((int)OnOrderColumn.TransCode - 1)];
			entity.ExpId = (System.String)reader[((int)OnOrderColumn.ExpId - 1)];
			entity.GoodsId = (System.String)reader[((int)OnOrderColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.Qty = (System.Decimal)reader[((int)OnOrderColumn.Qty - 1)];
			entity.UnitSymb = (System.String)reader[((int)OnOrderColumn.UnitSymb - 1)];
			entity.Price = (System.Decimal)reader[((int)OnOrderColumn.Price - 1)];
			entity.MercType = (System.String)reader[((int)OnOrderColumn.MercType - 1)];
			entity.UserId = (System.Decimal)reader[((int)OnOrderColumn.UserId - 1)];
			entity.Remark = (System.String)reader[((int)OnOrderColumn.Remark - 1)];
			entity.Recnum = (System.Decimal)reader[((int)OnOrderColumn.Recnum - 1)];
			entity.Status = (reader.IsDBNull(((int)OnOrderColumn.Status - 1)))?null:(System.Boolean?)reader[((int)OnOrderColumn.Status - 1)];
			entity.EndQty = (reader.IsDBNull(((int)OnOrderColumn.EndQty - 1)))?null:(System.Decimal?)reader[((int)OnOrderColumn.EndQty - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.OnOrder"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.OnOrder"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.OnOrder entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TranDate = (System.DateTime)dataRow["tran_date"];
			entity.TranTime = (System.String)dataRow["tran_time"];
			entity.DeliverDt = Convert.IsDBNull(dataRow["deliver_dt"]) ? null : (System.DateTime?)dataRow["deliver_dt"];
			entity.TransNum = (System.String)dataRow["trans_num"];
			entity.OriginalTransNum = (System.String)dataRow["trans_num"];
			entity.TransCode = (System.String)dataRow["trans_code"];
			entity.ExpId = (System.String)dataRow["exp_id"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.Qty = (System.Decimal)dataRow["qty"];
			entity.UnitSymb = (System.String)dataRow["unit_symb"];
			entity.Price = (System.Decimal)dataRow["price"];
			entity.MercType = (System.String)dataRow["merc_type"];
			entity.UserId = (System.Decimal)dataRow["user_id"];
			entity.Remark = (System.String)dataRow["remark"];
			entity.Recnum = (System.Decimal)dataRow["recnum"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Boolean?)dataRow["status"];
			entity.EndQty = Convert.IsDBNull(dataRow["end_qty"]) ? null : (System.Decimal?)dataRow["end_qty"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.OnOrder"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.OnOrder Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.OnOrder entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.OnOrder object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.OnOrder instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.OnOrder Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.OnOrder entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region OnOrderChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.OnOrder</c>
	///</summary>
	public enum OnOrderChildEntityTypes
	{
	}
	
	#endregion OnOrderChildEntityTypes
	
	#region OnOrderFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;OnOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="OnOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class OnOrderFilterBuilder : SqlFilterBuilder<OnOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OnOrderFilterBuilder class.
		/// </summary>
		public OnOrderFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the OnOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public OnOrderFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the OnOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public OnOrderFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion OnOrderFilterBuilder
	
	#region OnOrderParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;OnOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="OnOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class OnOrderParameterBuilder : ParameterizedSqlFilterBuilder<OnOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OnOrderParameterBuilder class.
		/// </summary>
		public OnOrderParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the OnOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public OnOrderParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the OnOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public OnOrderParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion OnOrderParameterBuilder
	
	#region OnOrderSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;OnOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="OnOrder"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class OnOrderSortBuilder : SqlSortBuilder<OnOrderColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OnOrderSqlSortBuilder class.
		/// </summary>
		public OnOrderSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion OnOrderSortBuilder
	
} // end namespace
