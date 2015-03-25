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
	/// This class is the base class for any <see cref="CustomerProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CustomerProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Customer, LibraryManagement.Domain.CustomerKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.CustomerKey key)
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
		public override LibraryManagement.Domain.Customer Get(TransactionManager transactionManager, LibraryManagement.Domain.CustomerKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblCustomer index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public LibraryManagement.Domain.Customer GetById(System.String _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustomer index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public LibraryManagement.Domain.Customer GetById(System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustomer index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public LibraryManagement.Domain.Customer GetById(TransactionManager transactionManager, System.String _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustomer index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public LibraryManagement.Domain.Customer GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustomer index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public LibraryManagement.Domain.Customer GetById(System.String _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustomer index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Customer"/> class.</returns>
		public abstract LibraryManagement.Domain.Customer GetById(TransactionManager transactionManager, System.String _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Customer&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Customer&gt;"/></returns>
		public static TList<Customer> Fill(IDataReader reader, TList<Customer> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Customer c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Customer")
					.Append("|").Append((System.String)reader[((int)CustomerColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Customer>(
					key.ToString(), // EntityTrackingKey
					"Customer",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Customer();
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
					c.Id = (System.String)reader[((int)CustomerColumn.Id - 1)];
					c.OriginalId = c.Id;
					c.Type = (reader.IsDBNull(((int)CustomerColumn.Type - 1)))?null:(System.Int32?)reader[((int)CustomerColumn.Type - 1)];
					c.Fullname = (reader.IsDBNull(((int)CustomerColumn.Fullname - 1)))?null:(System.String)reader[((int)CustomerColumn.Fullname - 1)];
					c.Address = (reader.IsDBNull(((int)CustomerColumn.Address - 1)))?null:(System.String)reader[((int)CustomerColumn.Address - 1)];
					c.Phone = (reader.IsDBNull(((int)CustomerColumn.Phone - 1)))?null:(System.String)reader[((int)CustomerColumn.Phone - 1)];
					c.Fax = (reader.IsDBNull(((int)CustomerColumn.Fax - 1)))?null:(System.String)reader[((int)CustomerColumn.Fax - 1)];
					c.PersonId = (reader.IsDBNull(((int)CustomerColumn.PersonId - 1)))?null:(System.String)reader[((int)CustomerColumn.PersonId - 1)];
					c.PlaceIssue = (reader.IsDBNull(((int)CustomerColumn.PlaceIssue - 1)))?null:(System.String)reader[((int)CustomerColumn.PlaceIssue - 1)];
					c.Email = (reader.IsDBNull(((int)CustomerColumn.Email - 1)))?null:(System.String)reader[((int)CustomerColumn.Email - 1)];
					c.DueDate = (reader.IsDBNull(((int)CustomerColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)CustomerColumn.DueDate - 1)];
					c.Image = (reader.IsDBNull(((int)CustomerColumn.Image - 1)))?null:(System.Byte[])reader[((int)CustomerColumn.Image - 1)];
					c.Bankname = (reader.IsDBNull(((int)CustomerColumn.Bankname - 1)))?null:(System.String)reader[((int)CustomerColumn.Bankname - 1)];
					c.BankBr = (reader.IsDBNull(((int)CustomerColumn.BankBr - 1)))?null:(System.String)reader[((int)CustomerColumn.BankBr - 1)];
					c.Accnum = (reader.IsDBNull(((int)CustomerColumn.Accnum - 1)))?null:(System.String)reader[((int)CustomerColumn.Accnum - 1)];
					c.Vatnum = (reader.IsDBNull(((int)CustomerColumn.Vatnum - 1)))?null:(System.String)reader[((int)CustomerColumn.Vatnum - 1)];
					c.Contactps = (reader.IsDBNull(((int)CustomerColumn.Contactps - 1)))?null:(System.String)reader[((int)CustomerColumn.Contactps - 1)];
					c.Remark = (reader.IsDBNull(((int)CustomerColumn.Remark - 1)))?null:(System.String)reader[((int)CustomerColumn.Remark - 1)];
					c.OpenDate = (reader.IsDBNull(((int)CustomerColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)CustomerColumn.OpenDate - 1)];
					c.Status = (System.Boolean)reader[((int)CustomerColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Customer"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Customer"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Customer entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.String)reader[((int)CustomerColumn.Id - 1)];
			entity.OriginalId = (System.String)reader["id"];
			entity.Type = (reader.IsDBNull(((int)CustomerColumn.Type - 1)))?null:(System.Int32?)reader[((int)CustomerColumn.Type - 1)];
			entity.Fullname = (reader.IsDBNull(((int)CustomerColumn.Fullname - 1)))?null:(System.String)reader[((int)CustomerColumn.Fullname - 1)];
			entity.Address = (reader.IsDBNull(((int)CustomerColumn.Address - 1)))?null:(System.String)reader[((int)CustomerColumn.Address - 1)];
			entity.Phone = (reader.IsDBNull(((int)CustomerColumn.Phone - 1)))?null:(System.String)reader[((int)CustomerColumn.Phone - 1)];
			entity.Fax = (reader.IsDBNull(((int)CustomerColumn.Fax - 1)))?null:(System.String)reader[((int)CustomerColumn.Fax - 1)];
			entity.PersonId = (reader.IsDBNull(((int)CustomerColumn.PersonId - 1)))?null:(System.String)reader[((int)CustomerColumn.PersonId - 1)];
			entity.PlaceIssue = (reader.IsDBNull(((int)CustomerColumn.PlaceIssue - 1)))?null:(System.String)reader[((int)CustomerColumn.PlaceIssue - 1)];
			entity.Email = (reader.IsDBNull(((int)CustomerColumn.Email - 1)))?null:(System.String)reader[((int)CustomerColumn.Email - 1)];
			entity.DueDate = (reader.IsDBNull(((int)CustomerColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)CustomerColumn.DueDate - 1)];
			entity.Image = (reader.IsDBNull(((int)CustomerColumn.Image - 1)))?null:(System.Byte[])reader[((int)CustomerColumn.Image - 1)];
			entity.Bankname = (reader.IsDBNull(((int)CustomerColumn.Bankname - 1)))?null:(System.String)reader[((int)CustomerColumn.Bankname - 1)];
			entity.BankBr = (reader.IsDBNull(((int)CustomerColumn.BankBr - 1)))?null:(System.String)reader[((int)CustomerColumn.BankBr - 1)];
			entity.Accnum = (reader.IsDBNull(((int)CustomerColumn.Accnum - 1)))?null:(System.String)reader[((int)CustomerColumn.Accnum - 1)];
			entity.Vatnum = (reader.IsDBNull(((int)CustomerColumn.Vatnum - 1)))?null:(System.String)reader[((int)CustomerColumn.Vatnum - 1)];
			entity.Contactps = (reader.IsDBNull(((int)CustomerColumn.Contactps - 1)))?null:(System.String)reader[((int)CustomerColumn.Contactps - 1)];
			entity.Remark = (reader.IsDBNull(((int)CustomerColumn.Remark - 1)))?null:(System.String)reader[((int)CustomerColumn.Remark - 1)];
			entity.OpenDate = (reader.IsDBNull(((int)CustomerColumn.OpenDate - 1)))?null:(System.DateTime?)reader[((int)CustomerColumn.OpenDate - 1)];
			entity.Status = (System.Boolean)reader[((int)CustomerColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Customer"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Customer"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Customer entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.String)dataRow["id"];
			entity.OriginalId = (System.String)dataRow["id"];
			entity.Type = Convert.IsDBNull(dataRow["Type"]) ? null : (System.Int32?)dataRow["Type"];
			entity.Fullname = Convert.IsDBNull(dataRow["fullname"]) ? null : (System.String)dataRow["fullname"];
			entity.Address = Convert.IsDBNull(dataRow["address"]) ? null : (System.String)dataRow["address"];
			entity.Phone = Convert.IsDBNull(dataRow["phone"]) ? null : (System.String)dataRow["phone"];
			entity.Fax = Convert.IsDBNull(dataRow["fax"]) ? null : (System.String)dataRow["fax"];
			entity.PersonId = Convert.IsDBNull(dataRow["person_id"]) ? null : (System.String)dataRow["person_id"];
			entity.PlaceIssue = Convert.IsDBNull(dataRow["place_issue"]) ? null : (System.String)dataRow["place_issue"];
			entity.Email = Convert.IsDBNull(dataRow["email"]) ? null : (System.String)dataRow["email"];
			entity.DueDate = Convert.IsDBNull(dataRow["due_date"]) ? null : (System.DateTime?)dataRow["due_date"];
			entity.Image = Convert.IsDBNull(dataRow["image"]) ? null : (System.Byte[])dataRow["image"];
			entity.Bankname = Convert.IsDBNull(dataRow["bankname"]) ? null : (System.String)dataRow["bankname"];
			entity.BankBr = Convert.IsDBNull(dataRow["bank_br"]) ? null : (System.String)dataRow["bank_br"];
			entity.Accnum = Convert.IsDBNull(dataRow["accnum"]) ? null : (System.String)dataRow["accnum"];
			entity.Vatnum = Convert.IsDBNull(dataRow["Vatnum"]) ? null : (System.String)dataRow["Vatnum"];
			entity.Contactps = Convert.IsDBNull(dataRow["contactps"]) ? null : (System.String)dataRow["contactps"];
			entity.Remark = Convert.IsDBNull(dataRow["remark"]) ? null : (System.String)dataRow["remark"];
			entity.OpenDate = Convert.IsDBNull(dataRow["open_date"]) ? null : (System.DateTime?)dataRow["open_date"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Customer"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Customer Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Customer entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Customer object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Customer instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Customer Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Customer entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CustomerChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Customer</c>
	///</summary>
	public enum CustomerChildEntityTypes
	{
	}
	
	#endregion CustomerChildEntityTypes
	
	#region CustomerFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CustomerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustomerFilterBuilder : SqlFilterBuilder<CustomerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomerFilterBuilder class.
		/// </summary>
		public CustomerFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustomerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustomerFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustomerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustomerFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustomerFilterBuilder
	
	#region CustomerParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CustomerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustomerParameterBuilder : ParameterizedSqlFilterBuilder<CustomerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomerParameterBuilder class.
		/// </summary>
		public CustomerParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustomerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustomerParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustomerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustomerParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustomerParameterBuilder
	
	#region CustomerSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CustomerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CustomerSortBuilder : SqlSortBuilder<CustomerColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomerSqlSortBuilder class.
		/// </summary>
		public CustomerSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CustomerSortBuilder
	
} // end namespace
