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
	/// This class is the base class for any <see cref="StaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class StaffProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Staff, LibraryManagement.Domain.StaffKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.StaffKey key)
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
		public override LibraryManagement.Domain.Staff Get(TransactionManager transactionManager, LibraryManagement.Domain.StaffKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblStaff index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public LibraryManagement.Domain.Staff GetById(System.String _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStaff index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public LibraryManagement.Domain.Staff GetById(System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public LibraryManagement.Domain.Staff GetById(TransactionManager transactionManager, System.String _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public LibraryManagement.Domain.Staff GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStaff index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public LibraryManagement.Domain.Staff GetById(System.String _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Staff"/> class.</returns>
		public abstract LibraryManagement.Domain.Staff GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Staff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Staff&gt;"/></returns>
		public static TList<Staff> Fill(IDataReader reader, TList<Staff> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Staff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Staff")
					.Append("|").Append((System.String)reader[((int)StaffColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Staff>(
					key.ToString(), // EntityTrackingKey
					"Staff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Staff();
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
					c.Id = (System.String)reader[((int)StaffColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.Name = (reader.IsDBNull(((int)StaffColumn.Name - 1)))?null:(System.String)reader[((int)StaffColumn.Name - 1)];
					c.Depart = (reader.IsDBNull(((int)StaffColumn.Depart - 1)))?null:(System.String)reader[((int)StaffColumn.Depart - 1)];
					c.OpenDate = (reader.IsDBNull(((int)StaffColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)StaffColumn.OpenDate - 1)];
					c.SalaryLevel = (reader.IsDBNull(((int)StaffColumn.SalaryLevel - 1)))?null:(System.Decimal?)reader[((int)StaffColumn.SalaryLevel - 1)];
					c.Address = (reader.IsDBNull(((int)StaffColumn.Address - 1)))?null:(System.String)reader[((int)StaffColumn.Address - 1)];
					c.Phone = (reader.IsDBNull(((int)StaffColumn.Phone - 1)))?null:(System.String)reader[((int)StaffColumn.Phone - 1)];
					c.PersonId = (reader.IsDBNull(((int)StaffColumn.PersonId - 1)))?null:(System.String)reader[((int)StaffColumn.PersonId - 1)];
					c.PersonIddate = (reader.IsDBNull(((int)StaffColumn.PersonIddate - 1)))?null:(System.DateTime?)reader[((int)StaffColumn.PersonIddate - 1)];
					c.Location = (reader.IsDBNull(((int)StaffColumn.Location - 1)))?null:(System.String)reader[((int)StaffColumn.Location - 1)];
					c.ContactPerson = (reader.IsDBNull(((int)StaffColumn.ContactPerson - 1)))?null:(System.String)reader[((int)StaffColumn.ContactPerson - 1)];
					c.Remark = (reader.IsDBNull(((int)StaffColumn.Remark - 1)))?null:(System.String)reader[((int)StaffColumn.Remark - 1)];
					c.Labelsprn = (reader.IsDBNull(((int)StaffColumn.Labelsprn - 1)))?null:(System.String)reader[((int)StaffColumn.Labelsprn - 1)];
					c.Status = (reader.IsDBNull(((int)StaffColumn.Status - 1)))?null:(System.Int32?)reader[((int)StaffColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Staff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Staff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Staff entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.String)reader[((int)StaffColumn.Id - 1)];
			entity.OriginalId = (System.String)reader["ID"];
			entity.Name = (reader.IsDBNull(((int)StaffColumn.Name - 1)))?null:(System.String)reader[((int)StaffColumn.Name - 1)];
			entity.Depart = (reader.IsDBNull(((int)StaffColumn.Depart - 1)))?null:(System.String)reader[((int)StaffColumn.Depart - 1)];
			entity.OpenDate = (reader.IsDBNull(((int)StaffColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)StaffColumn.OpenDate - 1)];
			entity.SalaryLevel = (reader.IsDBNull(((int)StaffColumn.SalaryLevel - 1)))?null:(System.Decimal?)reader[((int)StaffColumn.SalaryLevel - 1)];
			entity.Address = (reader.IsDBNull(((int)StaffColumn.Address - 1)))?null:(System.String)reader[((int)StaffColumn.Address - 1)];
			entity.Phone = (reader.IsDBNull(((int)StaffColumn.Phone - 1)))?null:(System.String)reader[((int)StaffColumn.Phone - 1)];
			entity.PersonId = (reader.IsDBNull(((int)StaffColumn.PersonId - 1)))?null:(System.String)reader[((int)StaffColumn.PersonId - 1)];
			entity.PersonIddate = (reader.IsDBNull(((int)StaffColumn.PersonIddate - 1)))?null:(System.DateTime?)reader[((int)StaffColumn.PersonIddate - 1)];
			entity.Location = (reader.IsDBNull(((int)StaffColumn.Location - 1)))?null:(System.String)reader[((int)StaffColumn.Location - 1)];
			entity.ContactPerson = (reader.IsDBNull(((int)StaffColumn.ContactPerson - 1)))?null:(System.String)reader[((int)StaffColumn.ContactPerson - 1)];
			entity.Remark = (reader.IsDBNull(((int)StaffColumn.Remark - 1)))?null:(System.String)reader[((int)StaffColumn.Remark - 1)];
			entity.Labelsprn = (reader.IsDBNull(((int)StaffColumn.Labelsprn - 1)))?null:(System.String)reader[((int)StaffColumn.Labelsprn - 1)];
			entity.Status = (reader.IsDBNull(((int)StaffColumn.Status - 1)))?null:(System.Int32?)reader[((int)StaffColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Staff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Staff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Staff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.String)dataRow["ID"];
			entity.OriginalId = (System.String)dataRow["ID"];
			entity.Name = Convert.IsDBNull(dataRow["Name"]) ? null : (System.String)dataRow["Name"];
			entity.Depart = Convert.IsDBNull(dataRow["Depart"]) ? null : (System.String)dataRow["Depart"];
			entity.OpenDate = Convert.IsDBNull(dataRow["Open_date"]) ? null : (System.DateTime?)dataRow["Open_date"];
			entity.SalaryLevel = Convert.IsDBNull(dataRow["SalaryLevel"]) ? null : (System.Decimal?)dataRow["SalaryLevel"];
			entity.Address = Convert.IsDBNull(dataRow["address"]) ? null : (System.String)dataRow["address"];
			entity.Phone = Convert.IsDBNull(dataRow["phone"]) ? null : (System.String)dataRow["phone"];
			entity.PersonId = Convert.IsDBNull(dataRow["PersonID"]) ? null : (System.String)dataRow["PersonID"];
			entity.PersonIddate = Convert.IsDBNull(dataRow["PersonIDdate"]) ? null : (System.DateTime?)dataRow["PersonIDdate"];
			entity.Location = Convert.IsDBNull(dataRow["Location"]) ? null : (System.String)dataRow["Location"];
			entity.ContactPerson = Convert.IsDBNull(dataRow["contactPerson"]) ? null : (System.String)dataRow["contactPerson"];
			entity.Remark = Convert.IsDBNull(dataRow["remark"]) ? null : (System.String)dataRow["remark"];
			entity.Labelsprn = Convert.IsDBNull(dataRow["labelsprn"]) ? null : (System.String)dataRow["labelsprn"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Int32?)dataRow["status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Staff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Staff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Staff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Staff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Staff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Staff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Staff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region StaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Staff</c>
	///</summary>
	public enum StaffChildEntityTypes
	{
	}
	
	#endregion StaffChildEntityTypes
	
	#region StaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;StaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Staff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffFilterBuilder : SqlFilterBuilder<StaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffFilterBuilder class.
		/// </summary>
		public StaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffFilterBuilder
	
	#region StaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;StaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Staff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffParameterBuilder : ParameterizedSqlFilterBuilder<StaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffParameterBuilder class.
		/// </summary>
		public StaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffParameterBuilder
	
	#region StaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;StaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Staff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class StaffSortBuilder : SqlSortBuilder<StaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffSqlSortBuilder class.
		/// </summary>
		public StaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion StaffSortBuilder
	
} // end namespace
