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
	/// This class is the base class for any <see cref="MofSysProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MofSysProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.MofSys, LibraryManagement.Domain.MofSysKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.MofSysKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _id)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _id);		
		
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
		public override LibraryManagement.Domain.MofSys Get(TransactionManager transactionManager, LibraryManagement.Domain.MofSysKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblMof_sys index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public LibraryManagement.Domain.MofSys GetById(System.Decimal _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMof_sys index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public LibraryManagement.Domain.MofSys GetById(System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMof_sys index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public LibraryManagement.Domain.MofSys GetById(TransactionManager transactionManager, System.Decimal _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMof_sys index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public LibraryManagement.Domain.MofSys GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMof_sys index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public LibraryManagement.Domain.MofSys GetById(System.Decimal _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblMof_sys index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.MofSys"/> class.</returns>
		public abstract LibraryManagement.Domain.MofSys GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MofSys&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MofSys&gt;"/></returns>
		public static TList<MofSys> Fill(IDataReader reader, TList<MofSys> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.MofSys c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MofSys")
					.Append("|").Append((System.Decimal)reader[((int)MofSysColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MofSys>(
					key.ToString(), // EntityTrackingKey
					"MofSys",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.MofSys();
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
					c.Id = (System.Decimal)reader[((int)MofSysColumn.Id - 1)];
					c.MofGl = (System.String)reader[((int)MofSysColumn.MofGl - 1)];
					c.MofName = (reader.IsDBNull(((int)MofSysColumn.MofName - 1)))?null:(System.String)reader[((int)MofSysColumn.MofName - 1)];
					c.MofNameb = (reader.IsDBNull(((int)MofSysColumn.MofNameb - 1)))?null:(System.String)reader[((int)MofSysColumn.MofNameb - 1)];
					c.AcType = (reader.IsDBNull(((int)MofSysColumn.AcType - 1)))?null:(System.String)reader[((int)MofSysColumn.AcType - 1)];
					c.Negative = (reader.IsDBNull(((int)MofSysColumn.Negative - 1)))?null:(System.String)reader[((int)MofSysColumn.Negative - 1)];
					c.Master = (reader.IsDBNull(((int)MofSysColumn.Master - 1)))?null:(System.Boolean?)reader[((int)MofSysColumn.Master - 1)];
					c.Glevel = (reader.IsDBNull(((int)MofSysColumn.Glevel - 1)))?null:(System.Int32?)reader[((int)MofSysColumn.Glevel - 1)];
					c.LastLevel = (System.Boolean)reader[((int)MofSysColumn.LastLevel - 1)];
					c.OtherEqui = (reader.IsDBNull(((int)MofSysColumn.OtherEqui - 1)))?null:(System.String)reader[((int)MofSysColumn.OtherEqui - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.MofSys"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MofSys"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.MofSys entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Decimal)reader[((int)MofSysColumn.Id - 1)];
			entity.MofGl = (System.String)reader[((int)MofSysColumn.MofGl - 1)];
			entity.MofName = (reader.IsDBNull(((int)MofSysColumn.MofName - 1)))?null:(System.String)reader[((int)MofSysColumn.MofName - 1)];
			entity.MofNameb = (reader.IsDBNull(((int)MofSysColumn.MofNameb - 1)))?null:(System.String)reader[((int)MofSysColumn.MofNameb - 1)];
			entity.AcType = (reader.IsDBNull(((int)MofSysColumn.AcType - 1)))?null:(System.String)reader[((int)MofSysColumn.AcType - 1)];
			entity.Negative = (reader.IsDBNull(((int)MofSysColumn.Negative - 1)))?null:(System.String)reader[((int)MofSysColumn.Negative - 1)];
			entity.Master = (reader.IsDBNull(((int)MofSysColumn.Master - 1)))?null:(System.Boolean?)reader[((int)MofSysColumn.Master - 1)];
			entity.Glevel = (reader.IsDBNull(((int)MofSysColumn.Glevel - 1)))?null:(System.Int32?)reader[((int)MofSysColumn.Glevel - 1)];
			entity.LastLevel = (System.Boolean)reader[((int)MofSysColumn.LastLevel - 1)];
			entity.OtherEqui = (reader.IsDBNull(((int)MofSysColumn.OtherEqui - 1)))?null:(System.String)reader[((int)MofSysColumn.OtherEqui - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.MofSys"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MofSys"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.MofSys entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Decimal)dataRow["id"];
			entity.MofGl = (System.String)dataRow["mof_gl"];
			entity.MofName = Convert.IsDBNull(dataRow["mof_name"]) ? null : (System.String)dataRow["mof_name"];
			entity.MofNameb = Convert.IsDBNull(dataRow["mof_nameb"]) ? null : (System.String)dataRow["mof_nameb"];
			entity.AcType = Convert.IsDBNull(dataRow["ac_type"]) ? null : (System.String)dataRow["ac_type"];
			entity.Negative = Convert.IsDBNull(dataRow["negative"]) ? null : (System.String)dataRow["negative"];
			entity.Master = Convert.IsDBNull(dataRow["master"]) ? null : (System.Boolean?)dataRow["master"];
			entity.Glevel = Convert.IsDBNull(dataRow["glevel"]) ? null : (System.Int32?)dataRow["glevel"];
			entity.LastLevel = (System.Boolean)dataRow["last_level"];
			entity.OtherEqui = Convert.IsDBNull(dataRow["other_equi"]) ? null : (System.String)dataRow["other_equi"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.MofSys"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.MofSys Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.MofSys entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.MofSys object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.MofSys instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.MofSys Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.MofSys entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region MofSysChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.MofSys</c>
	///</summary>
	public enum MofSysChildEntityTypes
	{
	}
	
	#endregion MofSysChildEntityTypes
	
	#region MofSysFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MofSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MofSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MofSysFilterBuilder : SqlFilterBuilder<MofSysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MofSysFilterBuilder class.
		/// </summary>
		public MofSysFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MofSysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MofSysFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MofSysFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MofSysFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MofSysFilterBuilder
	
	#region MofSysParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MofSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MofSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MofSysParameterBuilder : ParameterizedSqlFilterBuilder<MofSysColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MofSysParameterBuilder class.
		/// </summary>
		public MofSysParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MofSysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MofSysParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MofSysParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MofSysParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MofSysParameterBuilder
	
	#region MofSysSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MofSysColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MofSys"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MofSysSortBuilder : SqlSortBuilder<MofSysColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MofSysSqlSortBuilder class.
		/// </summary>
		public MofSysSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MofSysSortBuilder
	
} // end namespace
