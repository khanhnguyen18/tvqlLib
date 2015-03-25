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
	/// This class is the base class for any <see cref="SysvarProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SysvarProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Sysvar, LibraryManagement.Domain.SysvarKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.SysvarKey key)
		{
			return Delete(transactionManager, key.MCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _mCode)
		{
			return Delete(null, _mCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _mCode);		
		
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
		public override LibraryManagement.Domain.Sysvar Get(TransactionManager transactionManager, LibraryManagement.Domain.SysvarKey key, int start, int pageLength)
		{
			return GetByMCode(transactionManager, key.MCode, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblSysvar index.
		/// </summary>
		/// <param name="_mCode"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public LibraryManagement.Domain.Sysvar GetByMCode(System.String _mCode)
		{
			int count = -1;
			return GetByMCode(null,_mCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblSysvar index.
		/// </summary>
		/// <param name="_mCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public LibraryManagement.Domain.Sysvar GetByMCode(System.String _mCode, int start, int pageLength)
		{
			int count = -1;
			return GetByMCode(null, _mCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblSysvar index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public LibraryManagement.Domain.Sysvar GetByMCode(TransactionManager transactionManager, System.String _mCode)
		{
			int count = -1;
			return GetByMCode(transactionManager, _mCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblSysvar index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public LibraryManagement.Domain.Sysvar GetByMCode(TransactionManager transactionManager, System.String _mCode, int start, int pageLength)
		{
			int count = -1;
			return GetByMCode(transactionManager, _mCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblSysvar index.
		/// </summary>
		/// <param name="_mCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public LibraryManagement.Domain.Sysvar GetByMCode(System.String _mCode, int start, int pageLength, out int count)
		{
			return GetByMCode(null, _mCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblSysvar index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Sysvar"/> class.</returns>
		public abstract LibraryManagement.Domain.Sysvar GetByMCode(TransactionManager transactionManager, System.String _mCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Sysvar&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Sysvar&gt;"/></returns>
		public static TList<Sysvar> Fill(IDataReader reader, TList<Sysvar> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Sysvar c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Sysvar")
					.Append("|").Append((System.String)reader[((int)SysvarColumn.MCode - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Sysvar>(
					key.ToString(), // EntityTrackingKey
					"Sysvar",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Sysvar();
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
					c.MCode = (System.String)reader[((int)SysvarColumn.MCode - 1)];
					c.OriginalMCode = c.MCode;
					c.MType = (System.String)reader[((int)SysvarColumn.MType - 1)];
					c.MValue = (reader.IsDBNull(((int)SysvarColumn.MValue - 1)))?null:(System.String)reader[((int)SysvarColumn.MValue - 1)];
					c.Description = (reader.IsDBNull(((int)SysvarColumn.Description - 1)))?null:(System.String)reader[((int)SysvarColumn.Description - 1)];
					c.Type = (System.String)reader[((int)SysvarColumn.Type - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Sysvar"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Sysvar"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Sysvar entity)
		{
			if (!reader.Read()) return;
			
			entity.MCode = (System.String)reader[((int)SysvarColumn.MCode - 1)];
			entity.OriginalMCode = (System.String)reader["m_code"];
			entity.MType = (System.String)reader[((int)SysvarColumn.MType - 1)];
			entity.MValue = (reader.IsDBNull(((int)SysvarColumn.MValue - 1)))?null:(System.String)reader[((int)SysvarColumn.MValue - 1)];
			entity.Description = (reader.IsDBNull(((int)SysvarColumn.Description - 1)))?null:(System.String)reader[((int)SysvarColumn.Description - 1)];
			entity.Type = (System.String)reader[((int)SysvarColumn.Type - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Sysvar"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Sysvar"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Sysvar entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MCode = (System.String)dataRow["m_code"];
			entity.OriginalMCode = (System.String)dataRow["m_code"];
			entity.MType = (System.String)dataRow["m_type"];
			entity.MValue = Convert.IsDBNull(dataRow["m_value"]) ? null : (System.String)dataRow["m_value"];
			entity.Description = Convert.IsDBNull(dataRow["description"]) ? null : (System.String)dataRow["description"];
			entity.Type = (System.String)dataRow["Type"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Sysvar"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Sysvar Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Sysvar entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Sysvar object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Sysvar instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Sysvar Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Sysvar entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SysvarChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Sysvar</c>
	///</summary>
	public enum SysvarChildEntityTypes
	{
	}
	
	#endregion SysvarChildEntityTypes
	
	#region SysvarFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SysvarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Sysvar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysvarFilterBuilder : SqlFilterBuilder<SysvarColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysvarFilterBuilder class.
		/// </summary>
		public SysvarFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysvarFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysvarFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysvarFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysvarFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysvarFilterBuilder
	
	#region SysvarParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SysvarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Sysvar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysvarParameterBuilder : ParameterizedSqlFilterBuilder<SysvarColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysvarParameterBuilder class.
		/// </summary>
		public SysvarParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysvarParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysvarParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysvarParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysvarParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysvarParameterBuilder
	
	#region SysvarSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SysvarColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Sysvar"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SysvarSortBuilder : SqlSortBuilder<SysvarColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysvarSqlSortBuilder class.
		/// </summary>
		public SysvarSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SysvarSortBuilder
	
} // end namespace
