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
	/// This class is the base class for any <see cref="UserGrpProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class UserGrpProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.UserGrp, LibraryManagement.Domain.UserGrpKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.UserGrpKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _id)
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
		public abstract bool Delete(TransactionManager transactionManager, System.String _id);		
		
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
		public override LibraryManagement.Domain.UserGrp Get(TransactionManager transactionManager, LibraryManagement.Domain.UserGrpKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblUserGrp index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public LibraryManagement.Domain.UserGrp GetById(System.String _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblUserGrp index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public LibraryManagement.Domain.UserGrp GetById(System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblUserGrp index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public LibraryManagement.Domain.UserGrp GetById(TransactionManager transactionManager, System.String _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblUserGrp index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public LibraryManagement.Domain.UserGrp GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblUserGrp index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public LibraryManagement.Domain.UserGrp GetById(System.String _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblUserGrp index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.UserGrp"/> class.</returns>
		public abstract LibraryManagement.Domain.UserGrp GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;UserGrp&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;UserGrp&gt;"/></returns>
		public static TList<UserGrp> Fill(IDataReader reader, TList<UserGrp> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.UserGrp c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("UserGrp")
					.Append("|").Append((System.String)reader[((int)UserGrpColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<UserGrp>(
					key.ToString(), // EntityTrackingKey
					"UserGrp",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.UserGrp();
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
					c.Id = (System.String)reader[((int)UserGrpColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.Name = (reader.IsDBNull(((int)UserGrpColumn.Name - 1)))?null:(System.String)reader[((int)UserGrpColumn.Name - 1)];
					c.Descript = (reader.IsDBNull(((int)UserGrpColumn.Descript - 1)))?null:(System.String)reader[((int)UserGrpColumn.Descript - 1)];
					c.MenuPer = (reader.IsDBNull(((int)UserGrpColumn.MenuPer - 1)))?null:(System.String)reader[((int)UserGrpColumn.MenuPer - 1)];
					c.Rpright = (reader.IsDBNull(((int)UserGrpColumn.Rpright - 1)))?null:(System.String)reader[((int)UserGrpColumn.Rpright - 1)];
					c.Status = (reader.IsDBNull(((int)UserGrpColumn.Status - 1)))?null:(System.Boolean?)reader[((int)UserGrpColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.UserGrp"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.UserGrp"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.UserGrp entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.String)reader[((int)UserGrpColumn.Id - 1)];
			entity.OriginalId = (System.String)reader["ID"];
			entity.Name = (reader.IsDBNull(((int)UserGrpColumn.Name - 1)))?null:(System.String)reader[((int)UserGrpColumn.Name - 1)];
			entity.Descript = (reader.IsDBNull(((int)UserGrpColumn.Descript - 1)))?null:(System.String)reader[((int)UserGrpColumn.Descript - 1)];
			entity.MenuPer = (reader.IsDBNull(((int)UserGrpColumn.MenuPer - 1)))?null:(System.String)reader[((int)UserGrpColumn.MenuPer - 1)];
			entity.Rpright = (reader.IsDBNull(((int)UserGrpColumn.Rpright - 1)))?null:(System.String)reader[((int)UserGrpColumn.Rpright - 1)];
			entity.Status = (reader.IsDBNull(((int)UserGrpColumn.Status - 1)))?null:(System.Boolean?)reader[((int)UserGrpColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.UserGrp"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.UserGrp"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.UserGrp entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.String)dataRow["ID"];
			entity.OriginalId = (System.String)dataRow["ID"];
			entity.Name = Convert.IsDBNull(dataRow["Name"]) ? null : (System.String)dataRow["Name"];
			entity.Descript = Convert.IsDBNull(dataRow["Descript"]) ? null : (System.String)dataRow["Descript"];
			entity.MenuPer = Convert.IsDBNull(dataRow["MenuPer"]) ? null : (System.String)dataRow["MenuPer"];
			entity.Rpright = Convert.IsDBNull(dataRow["rpright"]) ? null : (System.String)dataRow["rpright"];
			entity.Status = Convert.IsDBNull(dataRow["Status"]) ? null : (System.Boolean?)dataRow["Status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.UserGrp"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.UserGrp Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.UserGrp entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.UserGrp object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.UserGrp instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.UserGrp Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.UserGrp entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region UserGrpChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.UserGrp</c>
	///</summary>
	public enum UserGrpChildEntityTypes
	{
	}
	
	#endregion UserGrpChildEntityTypes
	
	#region UserGrpFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;UserGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UserGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserGrpFilterBuilder : SqlFilterBuilder<UserGrpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserGrpFilterBuilder class.
		/// </summary>
		public UserGrpFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserGrpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserGrpFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserGrpFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserGrpFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserGrpFilterBuilder
	
	#region UserGrpParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;UserGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UserGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserGrpParameterBuilder : ParameterizedSqlFilterBuilder<UserGrpColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserGrpParameterBuilder class.
		/// </summary>
		public UserGrpParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserGrpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserGrpParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserGrpParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserGrpParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserGrpParameterBuilder
	
	#region UserGrpSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;UserGrpColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UserGrp"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class UserGrpSortBuilder : SqlSortBuilder<UserGrpColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserGrpSqlSortBuilder class.
		/// </summary>
		public UserGrpSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion UserGrpSortBuilder
	
} // end namespace
