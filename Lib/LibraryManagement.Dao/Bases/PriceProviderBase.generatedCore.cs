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
	/// This class is the base class for any <see cref="PriceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PriceProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Price, LibraryManagement.Domain.PriceKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.PriceKey key)
		{
			return Delete(transactionManager, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _goodsId)
		{
			return Delete(null, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _goodsId);		
		
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
		public override LibraryManagement.Domain.Price Get(TransactionManager transactionManager, LibraryManagement.Domain.PriceKey key, int start, int pageLength)
		{
			return GetByGoodsId(transactionManager, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblPrice index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public LibraryManagement.Domain.Price GetByGoodsId(System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(null,_goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblPrice index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public LibraryManagement.Domain.Price GetByGoodsId(System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblPrice index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public LibraryManagement.Domain.Price GetByGoodsId(TransactionManager transactionManager, System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblPrice index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public LibraryManagement.Domain.Price GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblPrice index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public LibraryManagement.Domain.Price GetByGoodsId(System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblPrice index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Price"/> class.</returns>
		public abstract LibraryManagement.Domain.Price GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Price&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Price&gt;"/></returns>
		public static TList<Price> Fill(IDataReader reader, TList<Price> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Price c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Price")
					.Append("|").Append((System.String)reader[((int)PriceColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Price>(
					key.ToString(), // EntityTrackingKey
					"Price",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Price();
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
					c.GoodsId = (System.String)reader[((int)PriceColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.Rtprice = (reader.IsDBNull(((int)PriceColumn.Rtprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Rtprice - 1)];
					c.Averimppr = (reader.IsDBNull(((int)PriceColumn.Averimppr - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Averimppr - 1)];
					c.Lastimppr = (reader.IsDBNull(((int)PriceColumn.Lastimppr - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Lastimppr - 1)];
					c.Wsprice = (reader.IsDBNull(((int)PriceColumn.Wsprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Wsprice - 1)];
					c.Prefprice = (reader.IsDBNull(((int)PriceColumn.Prefprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Prefprice - 1)];
					c.Discpercent = (reader.IsDBNull(((int)PriceColumn.Discpercent - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Discpercent - 1)];
					c.DiscFrdate = (reader.IsDBNull(((int)PriceColumn.DiscFrdate - 1)))?null:(System.DateTime?)reader[((int)PriceColumn.DiscFrdate - 1)];
					c.DiscTodate = (reader.IsDBNull(((int)PriceColumn.DiscTodate - 1)))?null:(System.DateTime?)reader[((int)PriceColumn.DiscTodate - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Price"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Price"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Price entity)
		{
			if (!reader.Read()) return;
			
			entity.GoodsId = (System.String)reader[((int)PriceColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.Rtprice = (reader.IsDBNull(((int)PriceColumn.Rtprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Rtprice - 1)];
			entity.Averimppr = (reader.IsDBNull(((int)PriceColumn.Averimppr - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Averimppr - 1)];
			entity.Lastimppr = (reader.IsDBNull(((int)PriceColumn.Lastimppr - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Lastimppr - 1)];
			entity.Wsprice = (reader.IsDBNull(((int)PriceColumn.Wsprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Wsprice - 1)];
			entity.Prefprice = (reader.IsDBNull(((int)PriceColumn.Prefprice - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Prefprice - 1)];
			entity.Discpercent = (reader.IsDBNull(((int)PriceColumn.Discpercent - 1)))?null:(System.Decimal?)reader[((int)PriceColumn.Discpercent - 1)];
			entity.DiscFrdate = (reader.IsDBNull(((int)PriceColumn.DiscFrdate - 1)))?null:(System.DateTime?)reader[((int)PriceColumn.DiscFrdate - 1)];
			entity.DiscTodate = (reader.IsDBNull(((int)PriceColumn.DiscTodate - 1)))?null:(System.DateTime?)reader[((int)PriceColumn.DiscTodate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Price"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Price"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Price entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.Rtprice = Convert.IsDBNull(dataRow["rtprice"]) ? null : (System.Decimal?)dataRow["rtprice"];
			entity.Averimppr = Convert.IsDBNull(dataRow["averimppr"]) ? null : (System.Decimal?)dataRow["averimppr"];
			entity.Lastimppr = Convert.IsDBNull(dataRow["lastimppr"]) ? null : (System.Decimal?)dataRow["lastimppr"];
			entity.Wsprice = Convert.IsDBNull(dataRow["wsprice"]) ? null : (System.Decimal?)dataRow["wsprice"];
			entity.Prefprice = Convert.IsDBNull(dataRow["prefprice"]) ? null : (System.Decimal?)dataRow["prefprice"];
			entity.Discpercent = Convert.IsDBNull(dataRow["discpercent"]) ? null : (System.Decimal?)dataRow["discpercent"];
			entity.DiscFrdate = Convert.IsDBNull(dataRow["disc_frdate"]) ? null : (System.DateTime?)dataRow["disc_frdate"];
			entity.DiscTodate = Convert.IsDBNull(dataRow["disc_todate"]) ? null : (System.DateTime?)dataRow["disc_todate"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Price"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Price Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Price entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Price object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Price instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Price Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Price entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PriceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Price</c>
	///</summary>
	public enum PriceChildEntityTypes
	{
	}
	
	#endregion PriceChildEntityTypes
	
	#region PriceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PriceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Price"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PriceFilterBuilder : SqlFilterBuilder<PriceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PriceFilterBuilder class.
		/// </summary>
		public PriceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PriceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PriceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PriceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PriceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PriceFilterBuilder
	
	#region PriceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PriceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Price"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PriceParameterBuilder : ParameterizedSqlFilterBuilder<PriceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PriceParameterBuilder class.
		/// </summary>
		public PriceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PriceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PriceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PriceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PriceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PriceParameterBuilder
	
	#region PriceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PriceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Price"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PriceSortBuilder : SqlSortBuilder<PriceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PriceSqlSortBuilder class.
		/// </summary>
		public PriceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PriceSortBuilder
	
} // end namespace
