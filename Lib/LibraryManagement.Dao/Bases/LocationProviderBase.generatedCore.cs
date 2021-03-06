﻿#region Using directives

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
	/// This class is the base class for any <see cref="LocationProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class LocationProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Location, LibraryManagement.Domain.LocationKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.LocationKey key)
		{
			return Delete(transactionManager, key.StkId, key.LocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_stkId">. Primary Key.</param>
		/// <param name="_locId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _stkId, System.String _locId)
		{
			return Delete(null, _stkId, _locId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stkId">. Primary Key.</param>
		/// <param name="_locId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _stkId, System.String _locId);		
		
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
		public override LibraryManagement.Domain.Location Get(TransactionManager transactionManager, LibraryManagement.Domain.LocationKey key, int start, int pageLength)
		{
			return GetByStkIdLocId(transactionManager, key.StkId, key.LocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblLocation index.
		/// </summary>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public LibraryManagement.Domain.Location GetByStkIdLocId(System.String _stkId, System.String _locId)
		{
			int count = -1;
			return GetByStkIdLocId(null,_stkId, _locId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLocation index.
		/// </summary>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public LibraryManagement.Domain.Location GetByStkIdLocId(System.String _stkId, System.String _locId, int start, int pageLength)
		{
			int count = -1;
			return GetByStkIdLocId(null, _stkId, _locId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public LibraryManagement.Domain.Location GetByStkIdLocId(TransactionManager transactionManager, System.String _stkId, System.String _locId)
		{
			int count = -1;
			return GetByStkIdLocId(transactionManager, _stkId, _locId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public LibraryManagement.Domain.Location GetByStkIdLocId(TransactionManager transactionManager, System.String _stkId, System.String _locId, int start, int pageLength)
		{
			int count = -1;
			return GetByStkIdLocId(transactionManager, _stkId, _locId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLocation index.
		/// </summary>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public LibraryManagement.Domain.Location GetByStkIdLocId(System.String _stkId, System.String _locId, int start, int pageLength, out int count)
		{
			return GetByStkIdLocId(null, _stkId, _locId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblLocation index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_stkId"></param>
		/// <param name="_locId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Location"/> class.</returns>
		public abstract LibraryManagement.Domain.Location GetByStkIdLocId(TransactionManager transactionManager, System.String _stkId, System.String _locId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Location&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Location&gt;"/></returns>
		public static TList<Location> Fill(IDataReader reader, TList<Location> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Location c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Location")
					.Append("|").Append((System.String)reader[((int)LocationColumn.StkId - 1)])
					.Append("|").Append((System.String)reader[((int)LocationColumn.LocId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Location>(
					key.ToString(), // EntityTrackingKey
					"Location",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Location();
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
					c.StkId = (System.String)reader[((int)LocationColumn.StkId - 1)];
					c.OriginalStkId = c.StkId;
					c.LocId = (System.String)reader[((int)LocationColumn.LocId - 1)];
					c.OriginalLocId = c.LocId;
					c.Description = (System.String)reader[((int)LocationColumn.Description - 1)];
					c.Status = (System.Boolean)reader[((int)LocationColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Location"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Location"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Location entity)
		{
			if (!reader.Read()) return;
			
			entity.StkId = (System.String)reader[((int)LocationColumn.StkId - 1)];
			entity.OriginalStkId = (System.String)reader["stk_id"];
			entity.LocId = (System.String)reader[((int)LocationColumn.LocId - 1)];
			entity.OriginalLocId = (System.String)reader["loc_id"];
			entity.Description = (System.String)reader[((int)LocationColumn.Description - 1)];
			entity.Status = (System.Boolean)reader[((int)LocationColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Location"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Location"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Location entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.StkId = (System.String)dataRow["stk_id"];
			entity.OriginalStkId = (System.String)dataRow["stk_id"];
			entity.LocId = (System.String)dataRow["loc_id"];
			entity.OriginalLocId = (System.String)dataRow["loc_id"];
			entity.Description = (System.String)dataRow["description"];
			entity.Status = (System.Boolean)dataRow["status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Location"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Location Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Location entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Location object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Location instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Location Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Location entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region LocationChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Location</c>
	///</summary>
	public enum LocationChildEntityTypes
	{
	}
	
	#endregion LocationChildEntityTypes
	
	#region LocationFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;LocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Location"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LocationFilterBuilder : SqlFilterBuilder<LocationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LocationFilterBuilder class.
		/// </summary>
		public LocationFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LocationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LocationFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LocationFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LocationFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LocationFilterBuilder
	
	#region LocationParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;LocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Location"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LocationParameterBuilder : ParameterizedSqlFilterBuilder<LocationColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LocationParameterBuilder class.
		/// </summary>
		public LocationParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the LocationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LocationParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LocationParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LocationParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LocationParameterBuilder
	
	#region LocationSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;LocationColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Location"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class LocationSortBuilder : SqlSortBuilder<LocationColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LocationSqlSortBuilder class.
		/// </summary>
		public LocationSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion LocationSortBuilder
	
} // end namespace
