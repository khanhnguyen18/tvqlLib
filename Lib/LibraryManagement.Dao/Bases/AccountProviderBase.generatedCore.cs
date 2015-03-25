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
	/// This class is the base class for any <see cref="AccountProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccountProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Account, LibraryManagement.Domain.AccountKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.AccountKey key)
		{
			return Delete(transactionManager, key.Branch, key.AccountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_branch">. Primary Key.</param>
		/// <param name="_accountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _branch, System.String _accountId)
		{
			return Delete(null, _branch, _accountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_branch">. Primary Key.</param>
		/// <param name="_accountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _branch, System.String _accountId);		
		
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
		public override LibraryManagement.Domain.Account Get(TransactionManager transactionManager, LibraryManagement.Domain.AccountKey key, int start, int pageLength)
		{
			return GetByBranchAccountId(transactionManager, key.Branch, key.AccountId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblAccount_1 index.
		/// </summary>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public LibraryManagement.Domain.Account GetByBranchAccountId(System.Decimal _branch, System.String _accountId)
		{
			int count = -1;
			return GetByBranchAccountId(null,_branch, _accountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccount_1 index.
		/// </summary>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public LibraryManagement.Domain.Account GetByBranchAccountId(System.Decimal _branch, System.String _accountId, int start, int pageLength)
		{
			int count = -1;
			return GetByBranchAccountId(null, _branch, _accountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccount_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public LibraryManagement.Domain.Account GetByBranchAccountId(TransactionManager transactionManager, System.Decimal _branch, System.String _accountId)
		{
			int count = -1;
			return GetByBranchAccountId(transactionManager, _branch, _accountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccount_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public LibraryManagement.Domain.Account GetByBranchAccountId(TransactionManager transactionManager, System.Decimal _branch, System.String _accountId, int start, int pageLength)
		{
			int count = -1;
			return GetByBranchAccountId(transactionManager, _branch, _accountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccount_1 index.
		/// </summary>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public LibraryManagement.Domain.Account GetByBranchAccountId(System.Decimal _branch, System.String _accountId, int start, int pageLength, out int count)
		{
			return GetByBranchAccountId(null, _branch, _accountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccount_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_branch"></param>
		/// <param name="_accountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Account"/> class.</returns>
		public abstract LibraryManagement.Domain.Account GetByBranchAccountId(TransactionManager transactionManager, System.Decimal _branch, System.String _accountId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Account&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Account&gt;"/></returns>
		public static TList<Account> Fill(IDataReader reader, TList<Account> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Account c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Account")
					.Append("|").Append((System.Decimal)reader[((int)AccountColumn.Branch - 1)])
					.Append("|").Append((System.String)reader[((int)AccountColumn.AccountId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Account>(
					key.ToString(), // EntityTrackingKey
					"Account",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Account();
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
					c.Branch = (System.Decimal)reader[((int)AccountColumn.Branch - 1)];
					c.OriginalBranch = c.Branch;
					c.AccountId = (System.String)reader[((int)AccountColumn.AccountId - 1)];
					c.OriginalAccountId = c.AccountId;
					c.Abbreviat = (System.String)reader[((int)AccountColumn.Abbreviat - 1)];
					c.MofGl = (System.String)reader[((int)AccountColumn.MofGl - 1)];
					c.CustId = (System.String)reader[((int)AccountColumn.CustId - 1)];
					c.Name = (System.String)reader[((int)AccountColumn.Name - 1)];
					c.OpenDate = (System.DateTime)reader[((int)AccountColumn.OpenDate - 1)];
					c.PrevDate = (System.DateTime)reader[((int)AccountColumn.PrevDate - 1)];
					c.LastDate = (System.DateTime)reader[((int)AccountColumn.LastDate - 1)];
					c.Creamt = (System.Decimal)reader[((int)AccountColumn.Creamt - 1)];
					c.Debamt = (System.Decimal)reader[((int)AccountColumn.Debamt - 1)];
					c.Status = (System.Boolean)reader[((int)AccountColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Account"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Account"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Account entity)
		{
			if (!reader.Read()) return;
			
			entity.Branch = (System.Decimal)reader[((int)AccountColumn.Branch - 1)];
			entity.OriginalBranch = (System.Decimal)reader["branch"];
			entity.AccountId = (System.String)reader[((int)AccountColumn.AccountId - 1)];
			entity.OriginalAccountId = (System.String)reader["account_id"];
			entity.Abbreviat = (System.String)reader[((int)AccountColumn.Abbreviat - 1)];
			entity.MofGl = (System.String)reader[((int)AccountColumn.MofGl - 1)];
			entity.CustId = (System.String)reader[((int)AccountColumn.CustId - 1)];
			entity.Name = (System.String)reader[((int)AccountColumn.Name - 1)];
			entity.OpenDate = (System.DateTime)reader[((int)AccountColumn.OpenDate - 1)];
			entity.PrevDate = (System.DateTime)reader[((int)AccountColumn.PrevDate - 1)];
			entity.LastDate = (System.DateTime)reader[((int)AccountColumn.LastDate - 1)];
			entity.Creamt = (System.Decimal)reader[((int)AccountColumn.Creamt - 1)];
			entity.Debamt = (System.Decimal)reader[((int)AccountColumn.Debamt - 1)];
			entity.Status = (System.Boolean)reader[((int)AccountColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Account"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Account"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Account entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Branch = (System.Decimal)dataRow["branch"];
			entity.OriginalBranch = (System.Decimal)dataRow["branch"];
			entity.AccountId = (System.String)dataRow["account_id"];
			entity.OriginalAccountId = (System.String)dataRow["account_id"];
			entity.Abbreviat = (System.String)dataRow["abbreviat"];
			entity.MofGl = (System.String)dataRow["mof_gl"];
			entity.CustId = (System.String)dataRow["cust_id"];
			entity.Name = (System.String)dataRow["name"];
			entity.OpenDate = (System.DateTime)dataRow["open_date"];
			entity.PrevDate = (System.DateTime)dataRow["prev_date"];
			entity.LastDate = (System.DateTime)dataRow["last_date"];
			entity.Creamt = (System.Decimal)dataRow["creamt"];
			entity.Debamt = (System.Decimal)dataRow["debamt"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Account"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Account Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Account entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Account object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Account instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Account Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Account entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region AccountChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Account</c>
	///</summary>
	public enum AccountChildEntityTypes
	{
	}
	
	#endregion AccountChildEntityTypes
	
	#region AccountFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Account"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccountFilterBuilder : SqlFilterBuilder<AccountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccountFilterBuilder class.
		/// </summary>
		public AccountFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccountFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccountFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccountFilterBuilder
	
	#region AccountParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Account"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccountParameterBuilder : ParameterizedSqlFilterBuilder<AccountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccountParameterBuilder class.
		/// </summary>
		public AccountParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccountParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccountParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccountParameterBuilder
	
	#region AccountSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Account"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccountSortBuilder : SqlSortBuilder<AccountColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccountSqlSortBuilder class.
		/// </summary>
		public AccountSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccountSortBuilder
	
} // end namespace
