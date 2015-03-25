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
	/// This class is the base class for any <see cref="ReportsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ReportsProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Reports, LibraryManagement.Domain.ReportsKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.ReportsKey key)
		{
			return Delete(transactionManager, key.Idx);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idx">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _idx)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _idx);		
		
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
		public override LibraryManagement.Domain.Reports Get(TransactionManager transactionManager, LibraryManagement.Domain.ReportsKey key, int start, int pageLength)
		{
			return GetByIdx(transactionManager, key.Idx, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblReports1 index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public LibraryManagement.Domain.Reports GetByIdx(System.Int32 _idx)
		{
			int count = -1;
			return GetByIdx(null,_idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblReports1 index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public LibraryManagement.Domain.Reports GetByIdx(System.Int32 _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblReports1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public LibraryManagement.Domain.Reports GetByIdx(TransactionManager transactionManager, System.Int32 _idx)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblReports1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public LibraryManagement.Domain.Reports GetByIdx(TransactionManager transactionManager, System.Int32 _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblReports1 index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public LibraryManagement.Domain.Reports GetByIdx(System.Int32 _idx, int start, int pageLength, out int count)
		{
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblReports1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Reports"/> class.</returns>
		public abstract LibraryManagement.Domain.Reports GetByIdx(TransactionManager transactionManager, System.Int32 _idx, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Reports&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Reports&gt;"/></returns>
		public static TList<Reports> Fill(IDataReader reader, TList<Reports> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Reports c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Reports")
					.Append("|").Append((System.Int32)reader[((int)ReportsColumn.Idx - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Reports>(
					key.ToString(), // EntityTrackingKey
					"Reports",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Reports();
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
					c.Idx = (System.Int32)reader[((int)ReportsColumn.Idx - 1)];
					c.OriginalIdx = c.Idx;
					c.DepId = (reader.IsDBNull(((int)ReportsColumn.DepId - 1)))?null:(System.Int32?)reader[((int)ReportsColumn.DepId - 1)];
					c.RepName = (reader.IsDBNull(((int)ReportsColumn.RepName - 1)))?null:(System.String)reader[((int)ReportsColumn.RepName - 1)];
					c.Description = (reader.IsDBNull(((int)ReportsColumn.Description - 1)))?null:(System.String)reader[((int)ReportsColumn.Description - 1)];
					c.Procedure = (reader.IsDBNull(((int)ReportsColumn.Procedure - 1)))?null:(System.String)reader[((int)ReportsColumn.Procedure - 1)];
					c.DepCode = (reader.IsDBNull(((int)ReportsColumn.DepCode - 1)))?null:(System.String)reader[((int)ReportsColumn.DepCode - 1)];
					c.Status = (reader.IsDBNull(((int)ReportsColumn.Status - 1)))?null:(System.Boolean?)reader[((int)ReportsColumn.Status - 1)];
					c.SafeNameChecked = (System.Boolean)reader[((int)ReportsColumn.SafeNameChecked - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Reports"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Reports"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Reports entity)
		{
			if (!reader.Read()) return;
			
			entity.Idx = (System.Int32)reader[((int)ReportsColumn.Idx - 1)];
			entity.OriginalIdx = (System.Int32)reader["idx"];
			entity.DepId = (reader.IsDBNull(((int)ReportsColumn.DepId - 1)))?null:(System.Int32?)reader[((int)ReportsColumn.DepId - 1)];
			entity.RepName = (reader.IsDBNull(((int)ReportsColumn.RepName - 1)))?null:(System.String)reader[((int)ReportsColumn.RepName - 1)];
			entity.Description = (reader.IsDBNull(((int)ReportsColumn.Description - 1)))?null:(System.String)reader[((int)ReportsColumn.Description - 1)];
			entity.Procedure = (reader.IsDBNull(((int)ReportsColumn.Procedure - 1)))?null:(System.String)reader[((int)ReportsColumn.Procedure - 1)];
			entity.DepCode = (reader.IsDBNull(((int)ReportsColumn.DepCode - 1)))?null:(System.String)reader[((int)ReportsColumn.DepCode - 1)];
			entity.Status = (reader.IsDBNull(((int)ReportsColumn.Status - 1)))?null:(System.Boolean?)reader[((int)ReportsColumn.Status - 1)];
			entity.SafeNameChecked = (System.Boolean)reader[((int)ReportsColumn.SafeNameChecked - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Reports"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Reports"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Reports entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Idx = (System.Int32)dataRow["idx"];
			entity.OriginalIdx = (System.Int32)dataRow["idx"];
			entity.DepId = Convert.IsDBNull(dataRow["dep_id"]) ? null : (System.Int32?)dataRow["dep_id"];
			entity.RepName = Convert.IsDBNull(dataRow["rep_name"]) ? null : (System.String)dataRow["rep_name"];
			entity.Description = Convert.IsDBNull(dataRow["description"]) ? null : (System.String)dataRow["description"];
			entity.Procedure = Convert.IsDBNull(dataRow["procedure"]) ? null : (System.String)dataRow["procedure"];
			entity.DepCode = Convert.IsDBNull(dataRow["dep_code"]) ? null : (System.String)dataRow["dep_code"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Boolean?)dataRow["status"];
			entity.SafeNameChecked = (System.Boolean)dataRow["checked"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Reports"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Reports Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Reports entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Reports object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Reports instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Reports Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Reports entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ReportsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Reports</c>
	///</summary>
	public enum ReportsChildEntityTypes
	{
	}
	
	#endregion ReportsChildEntityTypes
	
	#region ReportsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ReportsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Reports"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportsFilterBuilder : SqlFilterBuilder<ReportsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportsFilterBuilder class.
		/// </summary>
		public ReportsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportsFilterBuilder
	
	#region ReportsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ReportsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Reports"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportsParameterBuilder : ParameterizedSqlFilterBuilder<ReportsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportsParameterBuilder class.
		/// </summary>
		public ReportsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportsParameterBuilder
	
	#region ReportsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ReportsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Reports"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ReportsSortBuilder : SqlSortBuilder<ReportsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportsSqlSortBuilder class.
		/// </summary>
		public ReportsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ReportsSortBuilder
	
} // end namespace
