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
	/// This class is the base class for any <see cref="StationsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class StationsProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Stations, LibraryManagement.Domain.StationsKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.StationsKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _id);		
		
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
		public override LibraryManagement.Domain.Stations Get(TransactionManager transactionManager, LibraryManagement.Domain.StationsKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblStations index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public LibraryManagement.Domain.Stations GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStations index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public LibraryManagement.Domain.Stations GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStations index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public LibraryManagement.Domain.Stations GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStations index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public LibraryManagement.Domain.Stations GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStations index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public LibraryManagement.Domain.Stations GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStations index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Stations"/> class.</returns>
		public abstract LibraryManagement.Domain.Stations GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Stations&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Stations&gt;"/></returns>
		public static TList<Stations> Fill(IDataReader reader, TList<Stations> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Stations c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Stations")
					.Append("|").Append((System.Int32)reader[((int)StationsColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Stations>(
					key.ToString(), // EntityTrackingKey
					"Stations",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Stations();
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
					c.Id = (System.Int32)reader[((int)StationsColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.Name = (reader.IsDBNull(((int)StationsColumn.Name - 1)))?null:(System.String)reader[((int)StationsColumn.Name - 1)];
					c.Description = (reader.IsDBNull(((int)StationsColumn.Description - 1)))?null:(System.String)reader[((int)StationsColumn.Description - 1)];
					c.Login = (reader.IsDBNull(((int)StationsColumn.Login - 1)))?null:(System.Int32?)reader[((int)StationsColumn.Login - 1)];
					c.UserId = (reader.IsDBNull(((int)StationsColumn.UserId - 1)))?null:(System.Int32?)reader[((int)StationsColumn.UserId - 1)];
					c.PosId = (reader.IsDBNull(((int)StationsColumn.PosId - 1)))?null:(System.String)reader[((int)StationsColumn.PosId - 1)];
					c.Prnport = (reader.IsDBNull(((int)StationsColumn.Prnport - 1)))?null:(System.Int32?)reader[((int)StationsColumn.Prnport - 1)];
					c.Ipaddress = (reader.IsDBNull(((int)StationsColumn.Ipaddress - 1)))?null:(System.String)reader[((int)StationsColumn.Ipaddress - 1)];
					c.Message = (reader.IsDBNull(((int)StationsColumn.Message - 1)))?null:(System.Boolean?)reader[((int)StationsColumn.Message - 1)];
					c.Serialkey = (reader.IsDBNull(((int)StationsColumn.Serialkey - 1)))?null:(System.String)reader[((int)StationsColumn.Serialkey - 1)];
					c.Status = (System.Boolean)reader[((int)StationsColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Stations"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Stations"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Stations entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[((int)StationsColumn.Id - 1)];
			entity.OriginalId = (System.Int32)reader["id"];
			entity.Name = (reader.IsDBNull(((int)StationsColumn.Name - 1)))?null:(System.String)reader[((int)StationsColumn.Name - 1)];
			entity.Description = (reader.IsDBNull(((int)StationsColumn.Description - 1)))?null:(System.String)reader[((int)StationsColumn.Description - 1)];
			entity.Login = (reader.IsDBNull(((int)StationsColumn.Login - 1)))?null:(System.Int32?)reader[((int)StationsColumn.Login - 1)];
			entity.UserId = (reader.IsDBNull(((int)StationsColumn.UserId - 1)))?null:(System.Int32?)reader[((int)StationsColumn.UserId - 1)];
			entity.PosId = (reader.IsDBNull(((int)StationsColumn.PosId - 1)))?null:(System.String)reader[((int)StationsColumn.PosId - 1)];
			entity.Prnport = (reader.IsDBNull(((int)StationsColumn.Prnport - 1)))?null:(System.Int32?)reader[((int)StationsColumn.Prnport - 1)];
			entity.Ipaddress = (reader.IsDBNull(((int)StationsColumn.Ipaddress - 1)))?null:(System.String)reader[((int)StationsColumn.Ipaddress - 1)];
			entity.Message = (reader.IsDBNull(((int)StationsColumn.Message - 1)))?null:(System.Boolean?)reader[((int)StationsColumn.Message - 1)];
			entity.Serialkey = (reader.IsDBNull(((int)StationsColumn.Serialkey - 1)))?null:(System.String)reader[((int)StationsColumn.Serialkey - 1)];
			entity.Status = (System.Boolean)reader[((int)StationsColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Stations"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Stations"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Stations entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["id"];
			entity.OriginalId = (System.Int32)dataRow["id"];
			entity.Name = Convert.IsDBNull(dataRow["name"]) ? null : (System.String)dataRow["name"];
			entity.Description = Convert.IsDBNull(dataRow["Description"]) ? null : (System.String)dataRow["Description"];
			entity.Login = Convert.IsDBNull(dataRow["login"]) ? null : (System.Int32?)dataRow["login"];
			entity.UserId = Convert.IsDBNull(dataRow["user_id"]) ? null : (System.Int32?)dataRow["user_id"];
			entity.PosId = Convert.IsDBNull(dataRow["pos_id"]) ? null : (System.String)dataRow["pos_id"];
			entity.Prnport = Convert.IsDBNull(dataRow["prnport"]) ? null : (System.Int32?)dataRow["prnport"];
			entity.Ipaddress = Convert.IsDBNull(dataRow["ipaddress"]) ? null : (System.String)dataRow["ipaddress"];
			entity.Message = Convert.IsDBNull(dataRow["message"]) ? null : (System.Boolean?)dataRow["message"];
			entity.Serialkey = Convert.IsDBNull(dataRow["serialkey"]) ? null : (System.String)dataRow["serialkey"];
			entity.Status = (System.Boolean)dataRow["Status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Stations"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Stations Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Stations entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Stations object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Stations instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Stations Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Stations entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region StationsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Stations</c>
	///</summary>
	public enum StationsChildEntityTypes
	{
	}
	
	#endregion StationsChildEntityTypes
	
	#region StationsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;StationsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Stations"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StationsFilterBuilder : SqlFilterBuilder<StationsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationsFilterBuilder class.
		/// </summary>
		public StationsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StationsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StationsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StationsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StationsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StationsFilterBuilder
	
	#region StationsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;StationsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Stations"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StationsParameterBuilder : ParameterizedSqlFilterBuilder<StationsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationsParameterBuilder class.
		/// </summary>
		public StationsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StationsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StationsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StationsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StationsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StationsParameterBuilder
	
	#region StationsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;StationsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Stations"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class StationsSortBuilder : SqlSortBuilder<StationsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationsSqlSortBuilder class.
		/// </summary>
		public StationsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion StationsSortBuilder
	
} // end namespace
