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
	/// This class is the base class for any <see cref="GoodsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GoodsProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Goods, LibraryManagement.Domain.GoodsKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.GoodsKey key)
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
		public override LibraryManagement.Domain.Goods Get(TransactionManager transactionManager, LibraryManagement.Domain.GoodsKey key, int start, int pageLength)
		{
			return GetByGoodsId(transactionManager, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblGoods index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public LibraryManagement.Domain.Goods GetByGoodsId(System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(null,_goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblGoods index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public LibraryManagement.Domain.Goods GetByGoodsId(System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblGoods index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public LibraryManagement.Domain.Goods GetByGoodsId(TransactionManager transactionManager, System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblGoods index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public LibraryManagement.Domain.Goods GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblGoods index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public LibraryManagement.Domain.Goods GetByGoodsId(System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblGoods index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Goods"/> class.</returns>
		public abstract LibraryManagement.Domain.Goods GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Goods&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Goods&gt;"/></returns>
		public static TList<Goods> Fill(IDataReader reader, TList<Goods> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Goods c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Goods")
					.Append("|").Append((System.String)reader[((int)GoodsColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Goods>(
					key.ToString(), // EntityTrackingKey
					"Goods",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Goods();
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
					c.GoodsId = (System.String)reader[((int)GoodsColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.Barcode = (System.String)reader[((int)GoodsColumn.Barcode - 1)];
					c.Mbc = (System.Boolean)reader[((int)GoodsColumn.Mbc - 1)];
					c.SafeNameRef = (reader.IsDBNull(((int)GoodsColumn.SafeNameRef - 1)))?null:(System.String)reader[((int)GoodsColumn.SafeNameRef - 1)];
					c.GrpId = (reader.IsDBNull(((int)GoodsColumn.GrpId - 1)))?null:(System.String)reader[((int)GoodsColumn.GrpId - 1)];
					c.ShortName = (System.String)reader[((int)GoodsColumn.ShortName - 1)];
					c.FullName = (System.String)reader[((int)GoodsColumn.FullName - 1)];
					c.Packunit = (System.String)reader[((int)GoodsColumn.Packunit - 1)];
					c.Piceunit = (System.String)reader[((int)GoodsColumn.Piceunit - 1)];
					c.Unitconv = (System.Decimal)reader[((int)GoodsColumn.Unitconv - 1)];
					c.SuppId = (reader.IsDBNull(((int)GoodsColumn.SuppId - 1)))?null:(System.String)reader[((int)GoodsColumn.SuppId - 1)];
					c.Image = (reader.IsDBNull(((int)GoodsColumn.Image - 1)))?null:(System.Byte[])reader[((int)GoodsColumn.Image - 1)];
					c.OpenDate = (reader.IsDBNull(((int)GoodsColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)GoodsColumn.OpenDate - 1)];
					c.TaxCode = (reader.IsDBNull(((int)GoodsColumn.TaxCode - 1)))?null:(System.String)reader[((int)GoodsColumn.TaxCode - 1)];
					c.MercType = (reader.IsDBNull(((int)GoodsColumn.MercType - 1)))?null:(System.String)reader[((int)GoodsColumn.MercType - 1)];
					c.AttrType = (reader.IsDBNull(((int)GoodsColumn.AttrType - 1)))?null:(System.String)reader[((int)GoodsColumn.AttrType - 1)];
					c.Domestic = (reader.IsDBNull(((int)GoodsColumn.Domestic - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Domestic - 1)];
					c.Warranty = (reader.IsDBNull(((int)GoodsColumn.Warranty - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Warranty - 1)];
					c.Status = (reader.IsDBNull(((int)GoodsColumn.Status - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Goods"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Goods"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Goods entity)
		{
			if (!reader.Read()) return;
			
			entity.GoodsId = (System.String)reader[((int)GoodsColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.Barcode = (System.String)reader[((int)GoodsColumn.Barcode - 1)];
			entity.Mbc = (System.Boolean)reader[((int)GoodsColumn.Mbc - 1)];
			entity.SafeNameRef = (reader.IsDBNull(((int)GoodsColumn.SafeNameRef - 1)))?null:(System.String)reader[((int)GoodsColumn.SafeNameRef - 1)];
			entity.GrpId = (reader.IsDBNull(((int)GoodsColumn.GrpId - 1)))?null:(System.String)reader[((int)GoodsColumn.GrpId - 1)];
			entity.ShortName = (System.String)reader[((int)GoodsColumn.ShortName - 1)];
			entity.FullName = (System.String)reader[((int)GoodsColumn.FullName - 1)];
			entity.Packunit = (System.String)reader[((int)GoodsColumn.Packunit - 1)];
			entity.Piceunit = (System.String)reader[((int)GoodsColumn.Piceunit - 1)];
			entity.Unitconv = (System.Decimal)reader[((int)GoodsColumn.Unitconv - 1)];
			entity.SuppId = (reader.IsDBNull(((int)GoodsColumn.SuppId - 1)))?null:(System.String)reader[((int)GoodsColumn.SuppId - 1)];
			entity.Image = (reader.IsDBNull(((int)GoodsColumn.Image - 1)))?null:(System.Byte[])reader[((int)GoodsColumn.Image - 1)];
			entity.OpenDate = (reader.IsDBNull(((int)GoodsColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)GoodsColumn.OpenDate - 1)];
			entity.TaxCode = (reader.IsDBNull(((int)GoodsColumn.TaxCode - 1)))?null:(System.String)reader[((int)GoodsColumn.TaxCode - 1)];
			entity.MercType = (reader.IsDBNull(((int)GoodsColumn.MercType - 1)))?null:(System.String)reader[((int)GoodsColumn.MercType - 1)];
			entity.AttrType = (reader.IsDBNull(((int)GoodsColumn.AttrType - 1)))?null:(System.String)reader[((int)GoodsColumn.AttrType - 1)];
			entity.Domestic = (reader.IsDBNull(((int)GoodsColumn.Domestic - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Domestic - 1)];
			entity.Warranty = (reader.IsDBNull(((int)GoodsColumn.Warranty - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Warranty - 1)];
			entity.Status = (reader.IsDBNull(((int)GoodsColumn.Status - 1)))?null:(System.Boolean?)reader[((int)GoodsColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Goods"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Goods"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Goods entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.Barcode = (System.String)dataRow["barcode"];
			entity.Mbc = (System.Boolean)dataRow["mbc"];
			entity.SafeNameRef = Convert.IsDBNull(dataRow["ref"]) ? null : (System.String)dataRow["ref"];
			entity.GrpId = Convert.IsDBNull(dataRow["grp_id"]) ? null : (System.String)dataRow["grp_id"];
			entity.ShortName = (System.String)dataRow["short_name"];
			entity.FullName = (System.String)dataRow["full_name"];
			entity.Packunit = (System.String)dataRow["packunit"];
			entity.Piceunit = (System.String)dataRow["piceunit"];
			entity.Unitconv = (System.Decimal)dataRow["unitconv"];
			entity.SuppId = Convert.IsDBNull(dataRow["supp_id"]) ? null : (System.String)dataRow["supp_id"];
			entity.Image = Convert.IsDBNull(dataRow["image"]) ? null : (System.Byte[])dataRow["image"];
			entity.OpenDate = Convert.IsDBNull(dataRow["open_date"]) ? null : (System.DateTime?)dataRow["open_date"];
			entity.TaxCode = Convert.IsDBNull(dataRow["tax_code"]) ? null : (System.String)dataRow["tax_code"];
			entity.MercType = Convert.IsDBNull(dataRow["merc_type"]) ? null : (System.String)dataRow["merc_type"];
			entity.AttrType = Convert.IsDBNull(dataRow["attr_type"]) ? null : (System.String)dataRow["attr_type"];
			entity.Domestic = Convert.IsDBNull(dataRow["domestic"]) ? null : (System.Boolean?)dataRow["domestic"];
			entity.Warranty = Convert.IsDBNull(dataRow["warranty"]) ? null : (System.Boolean?)dataRow["warranty"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Goods"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Goods Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Goods entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Goods object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Goods instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Goods Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Goods entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GoodsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Goods</c>
	///</summary>
	public enum GoodsChildEntityTypes
	{
	}
	
	#endregion GoodsChildEntityTypes
	
	#region GoodsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GoodsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Goods"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsFilterBuilder : SqlFilterBuilder<GoodsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsFilterBuilder class.
		/// </summary>
		public GoodsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsFilterBuilder
	
	#region GoodsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GoodsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Goods"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsParameterBuilder : ParameterizedSqlFilterBuilder<GoodsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsParameterBuilder class.
		/// </summary>
		public GoodsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsParameterBuilder
	
	#region GoodsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GoodsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Goods"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GoodsSortBuilder : SqlSortBuilder<GoodsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsSqlSortBuilder class.
		/// </summary>
		public GoodsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GoodsSortBuilder
	
} // end namespace
