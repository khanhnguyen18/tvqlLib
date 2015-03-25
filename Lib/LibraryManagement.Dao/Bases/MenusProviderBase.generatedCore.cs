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
	/// This class is the base class for any <see cref="MenusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MenusProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Menus, LibraryManagement.Domain.MenusKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.MenusKey key)
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
		public override LibraryManagement.Domain.Menus Get(TransactionManager transactionManager, LibraryManagement.Domain.MenusKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblMenus_1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public LibraryManagement.Domain.Menus GetById(System.Int32 _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMenus_1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public LibraryManagement.Domain.Menus GetById(System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMenus_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public LibraryManagement.Domain.Menus GetById(TransactionManager transactionManager, System.Int32 _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMenus_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public LibraryManagement.Domain.Menus GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMenus_1 index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public LibraryManagement.Domain.Menus GetById(System.Int32 _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMenus_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Menus"/> class.</returns>
		public abstract LibraryManagement.Domain.Menus GetById(TransactionManager transactionManager, System.Int32 _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Menus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Menus&gt;"/></returns>
		public static TList<Menus> Fill(IDataReader reader, TList<Menus> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Menus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Menus")
					.Append("|").Append((System.Int32)reader[((int)MenusColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Menus>(
					key.ToString(), // EntityTrackingKey
					"Menus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Menus();
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
					c.Id = (System.Int32)reader[((int)MenusColumn.Id - 1)];
					c.Subitem = (reader.IsDBNull(((int)MenusColumn.Subitem - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Subitem - 1)];
					c.Parent = (reader.IsDBNull(((int)MenusColumn.Parent - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Parent - 1)];
					c.Menukey = (reader.IsDBNull(((int)MenusColumn.Menukey - 1)))?null:(System.String)reader[((int)MenusColumn.Menukey - 1)];
					c.Prompt = (reader.IsDBNull(((int)MenusColumn.Prompt - 1)))?null:(System.String)reader[((int)MenusColumn.Prompt - 1)];
					c.Type = (reader.IsDBNull(((int)MenusColumn.Type - 1)))?null:(System.String)reader[((int)MenusColumn.Type - 1)];
					c.Procerdue = (reader.IsDBNull(((int)MenusColumn.Procerdue - 1)))?null:(System.String)reader[((int)MenusColumn.Procerdue - 1)];
					c.Imageidx = (reader.IsDBNull(((int)MenusColumn.Imageidx - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Imageidx - 1)];
					c.Password = (reader.IsDBNull(((int)MenusColumn.Password - 1)))?null:(System.Boolean?)reader[((int)MenusColumn.Password - 1)];
					c.Basicright = (reader.IsDBNull(((int)MenusColumn.Basicright - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Basicright - 1)];
					c.Depcode = (reader.IsDBNull(((int)MenusColumn.Depcode - 1)))?null:(System.String)reader[((int)MenusColumn.Depcode - 1)];
					c.Skip = (reader.IsDBNull(((int)MenusColumn.Skip - 1)))?null:(System.Boolean?)reader[((int)MenusColumn.Skip - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Menus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Menus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Menus entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Int32)reader[((int)MenusColumn.Id - 1)];
			entity.Subitem = (reader.IsDBNull(((int)MenusColumn.Subitem - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Subitem - 1)];
			entity.Parent = (reader.IsDBNull(((int)MenusColumn.Parent - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Parent - 1)];
			entity.Menukey = (reader.IsDBNull(((int)MenusColumn.Menukey - 1)))?null:(System.String)reader[((int)MenusColumn.Menukey - 1)];
			entity.Prompt = (reader.IsDBNull(((int)MenusColumn.Prompt - 1)))?null:(System.String)reader[((int)MenusColumn.Prompt - 1)];
			entity.Type = (reader.IsDBNull(((int)MenusColumn.Type - 1)))?null:(System.String)reader[((int)MenusColumn.Type - 1)];
			entity.Procerdue = (reader.IsDBNull(((int)MenusColumn.Procerdue - 1)))?null:(System.String)reader[((int)MenusColumn.Procerdue - 1)];
			entity.Imageidx = (reader.IsDBNull(((int)MenusColumn.Imageidx - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Imageidx - 1)];
			entity.Password = (reader.IsDBNull(((int)MenusColumn.Password - 1)))?null:(System.Boolean?)reader[((int)MenusColumn.Password - 1)];
			entity.Basicright = (reader.IsDBNull(((int)MenusColumn.Basicright - 1)))?null:(System.Int32?)reader[((int)MenusColumn.Basicright - 1)];
			entity.Depcode = (reader.IsDBNull(((int)MenusColumn.Depcode - 1)))?null:(System.String)reader[((int)MenusColumn.Depcode - 1)];
			entity.Skip = (reader.IsDBNull(((int)MenusColumn.Skip - 1)))?null:(System.Boolean?)reader[((int)MenusColumn.Skip - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Menus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Menus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Menus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Int32)dataRow["id"];
			entity.Subitem = Convert.IsDBNull(dataRow["subitem"]) ? null : (System.Int32?)dataRow["subitem"];
			entity.Parent = Convert.IsDBNull(dataRow["parent"]) ? null : (System.Int32?)dataRow["parent"];
			entity.Menukey = Convert.IsDBNull(dataRow["menukey"]) ? null : (System.String)dataRow["menukey"];
			entity.Prompt = Convert.IsDBNull(dataRow["prompt"]) ? null : (System.String)dataRow["prompt"];
			entity.Type = Convert.IsDBNull(dataRow["type"]) ? null : (System.String)dataRow["type"];
			entity.Procerdue = Convert.IsDBNull(dataRow["procerdue"]) ? null : (System.String)dataRow["procerdue"];
			entity.Imageidx = Convert.IsDBNull(dataRow["imageidx"]) ? null : (System.Int32?)dataRow["imageidx"];
			entity.Password = Convert.IsDBNull(dataRow["password"]) ? null : (System.Boolean?)dataRow["password"];
			entity.Basicright = Convert.IsDBNull(dataRow["basicright"]) ? null : (System.Int32?)dataRow["basicright"];
			entity.Depcode = Convert.IsDBNull(dataRow["depcode"]) ? null : (System.String)dataRow["depcode"];
			entity.Skip = Convert.IsDBNull(dataRow["skip"]) ? null : (System.Boolean?)dataRow["skip"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Menus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Menus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Menus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Menus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Menus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Menus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Menus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region MenusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Menus</c>
	///</summary>
	public enum MenusChildEntityTypes
	{
	}
	
	#endregion MenusChildEntityTypes
	
	#region MenusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MenusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Menus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MenusFilterBuilder : SqlFilterBuilder<MenusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MenusFilterBuilder class.
		/// </summary>
		public MenusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MenusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MenusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MenusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MenusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MenusFilterBuilder
	
	#region MenusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MenusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Menus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MenusParameterBuilder : ParameterizedSqlFilterBuilder<MenusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MenusParameterBuilder class.
		/// </summary>
		public MenusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MenusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MenusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MenusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MenusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MenusParameterBuilder
	
	#region MenusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MenusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Menus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MenusSortBuilder : SqlSortBuilder<MenusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MenusSqlSortBuilder class.
		/// </summary>
		public MenusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MenusSortBuilder
	
} // end namespace
