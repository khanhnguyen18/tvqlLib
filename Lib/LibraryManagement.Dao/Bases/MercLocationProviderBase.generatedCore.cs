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
	/// This class is the base class for any <see cref="MercLocationProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MercLocationProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.MercLocation, LibraryManagement.Domain.MercLocationKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.MercLocationKey key)
		{
			return Delete(transactionManager, key.Idx);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idx">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _idx)
		{
			return Delete(null, _idx);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _idx);		
		
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
		public override LibraryManagement.Domain.MercLocation Get(TransactionManager transactionManager, LibraryManagement.Domain.MercLocationKey key, int start, int pageLength)
		{
			return GetByIdx(transactionManager, key.Idx, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblMercLocation index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public LibraryManagement.Domain.MercLocation GetByIdx(System.Decimal _idx)
		{
			int count = -1;
			return GetByIdx(null,_idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMercLocation index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public LibraryManagement.Domain.MercLocation GetByIdx(System.Decimal _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMercLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public LibraryManagement.Domain.MercLocation GetByIdx(TransactionManager transactionManager, System.Decimal _idx)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMercLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public LibraryManagement.Domain.MercLocation GetByIdx(TransactionManager transactionManager, System.Decimal _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMercLocation index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public LibraryManagement.Domain.MercLocation GetByIdx(System.Decimal _idx, int start, int pageLength, out int count)
		{
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMercLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MercLocation"/> class.</returns>
		public abstract LibraryManagement.Domain.MercLocation GetByIdx(TransactionManager transactionManager, System.Decimal _idx, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MercLocation&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MercLocation&gt;"/></returns>
		public static TList<MercLocation> Fill(IDataReader reader, TList<MercLocation> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.MercLocation c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MercLocation")
					.Append("|").Append((System.Decimal)reader[((int)MercLocationColumn.Idx - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MercLocation>(
					key.ToString(), // EntityTrackingKey
					"MercLocation",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.MercLocation();
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
					c.Idx = (System.Decimal)reader[((int)MercLocationColumn.Idx - 1)];
					c.StkId = (System.String)reader[((int)MercLocationColumn.StkId - 1)];
					c.LocId = (System.String)reader[((int)MercLocationColumn.LocId - 1)];
					c.GoodsId = (System.String)reader[((int)MercLocationColumn.GoodsId - 1)];
					c.Check = (System.Boolean)reader[((int)MercLocationColumn.Check - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.MercLocation"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MercLocation"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.MercLocation entity)
		{
			if (!reader.Read()) return;
			
			entity.Idx = (System.Decimal)reader[((int)MercLocationColumn.Idx - 1)];
			entity.StkId = (System.String)reader[((int)MercLocationColumn.StkId - 1)];
			entity.LocId = (System.String)reader[((int)MercLocationColumn.LocId - 1)];
			entity.GoodsId = (System.String)reader[((int)MercLocationColumn.GoodsId - 1)];
			entity.Check = (System.Boolean)reader[((int)MercLocationColumn.Check - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.MercLocation"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MercLocation"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.MercLocation entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Idx = (System.Decimal)dataRow["idx"];
			entity.StkId = (System.String)dataRow["stk_id"];
			entity.LocId = (System.String)dataRow["loc_id"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.Check = (System.Boolean)dataRow["check"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MercLocation"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.MercLocation Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.MercLocation entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.MercLocation object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.MercLocation instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.MercLocation Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.MercLocation entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region MercLocationChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.MercLocation</c>
	///</summary>
	public enum MercLocationChildEntityTypes
	{
	}
	
	#endregion MercLocationChildEntityTypes
	
	#region MercLocationFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MercLocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MercLocation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MercLocationFilterBuilder : SqlFilterBuilder<MercLocationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MercLocationFilterBuilder class.
		/// </summary>
		public MercLocationFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MercLocationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MercLocationFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MercLocationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MercLocationFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MercLocationFilterBuilder
	
	#region MercLocationParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MercLocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MercLocation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MercLocationParameterBuilder : ParameterizedSqlFilterBuilder<MercLocationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MercLocationParameterBuilder class.
		/// </summary>
		public MercLocationParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MercLocationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MercLocationParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MercLocationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MercLocationParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MercLocationParameterBuilder
	
	#region MercLocationSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MercLocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MercLocation"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MercLocationSortBuilder : SqlSortBuilder<MercLocationColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MercLocationSqlSortBuilder class.
		/// </summary>
		public MercLocationSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MercLocationSortBuilder
	
} // end namespace
