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
	/// This class is the base class for any <see cref="PaymentOrderProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PaymentOrderProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.PaymentOrder, LibraryManagement.Domain.PaymentOrderKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.PaymentOrderKey key)
		{
			return Delete(transactionManager, key.TransNum);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_transNum">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _transNum)
		{
			return Delete(null, _transNum);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _transNum);		
		
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
		public override LibraryManagement.Domain.PaymentOrder Get(TransactionManager transactionManager, LibraryManagement.Domain.PaymentOrderKey key, int start, int pageLength)
		{
			return GetByTransNum(transactionManager, key.TransNum, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblAtransInfo index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public LibraryManagement.Domain.PaymentOrder GetByTransNum(System.String _transNum)
		{
			int count = -1;
			return GetByTransNum(null,_transNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtransInfo index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public LibraryManagement.Domain.PaymentOrder GetByTransNum(System.String _transNum, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNum(null, _transNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtransInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public LibraryManagement.Domain.PaymentOrder GetByTransNum(TransactionManager transactionManager, System.String _transNum)
		{
			int count = -1;
			return GetByTransNum(transactionManager, _transNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtransInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public LibraryManagement.Domain.PaymentOrder GetByTransNum(TransactionManager transactionManager, System.String _transNum, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNum(transactionManager, _transNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtransInfo index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public LibraryManagement.Domain.PaymentOrder GetByTransNum(System.String _transNum, int start, int pageLength, out int count)
		{
			return GetByTransNum(null, _transNum, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtransInfo index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.PaymentOrder"/> class.</returns>
		public abstract LibraryManagement.Domain.PaymentOrder GetByTransNum(TransactionManager transactionManager, System.String _transNum, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PaymentOrder&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PaymentOrder&gt;"/></returns>
		public static TList<PaymentOrder> Fill(IDataReader reader, TList<PaymentOrder> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.PaymentOrder c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PaymentOrder")
					.Append("|").Append((System.String)reader[((int)PaymentOrderColumn.TransNum - 1)]).ToString();
					c = EntityManager.LocateOrCreate<PaymentOrder>(
					key.ToString(), // EntityTrackingKey
					"PaymentOrder",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.PaymentOrder();
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
					c.TransNum = (System.String)reader[((int)PaymentOrderColumn.TransNum - 1)];
					c.OriginalTransNum = c.TransNum;
					c.Payer = (System.String)reader[((int)PaymentOrderColumn.Payer - 1)];
					c.PayerAcc = (System.String)reader[((int)PaymentOrderColumn.PayerAcc - 1)];
					c.PayerBank = (System.String)reader[((int)PaymentOrderColumn.PayerBank - 1)];
					c.PayerBranch = (System.String)reader[((int)PaymentOrderColumn.PayerBranch - 1)];
					c.Benef = (System.String)reader[((int)PaymentOrderColumn.Benef - 1)];
					c.BenefAcc = (System.String)reader[((int)PaymentOrderColumn.BenefAcc - 1)];
					c.BenefBank = (System.String)reader[((int)PaymentOrderColumn.BenefBank - 1)];
					c.BenefBranch = (System.String)reader[((int)PaymentOrderColumn.BenefBranch - 1)];
					c.Amount = (System.Decimal)reader[((int)PaymentOrderColumn.Amount - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.PaymentOrder"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.PaymentOrder"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.PaymentOrder entity)
		{
			if (!reader.Read()) return;
			
			entity.TransNum = (System.String)reader[((int)PaymentOrderColumn.TransNum - 1)];
			entity.OriginalTransNum = (System.String)reader["trans_num"];
			entity.Payer = (System.String)reader[((int)PaymentOrderColumn.Payer - 1)];
			entity.PayerAcc = (System.String)reader[((int)PaymentOrderColumn.PayerAcc - 1)];
			entity.PayerBank = (System.String)reader[((int)PaymentOrderColumn.PayerBank - 1)];
			entity.PayerBranch = (System.String)reader[((int)PaymentOrderColumn.PayerBranch - 1)];
			entity.Benef = (System.String)reader[((int)PaymentOrderColumn.Benef - 1)];
			entity.BenefAcc = (System.String)reader[((int)PaymentOrderColumn.BenefAcc - 1)];
			entity.BenefBank = (System.String)reader[((int)PaymentOrderColumn.BenefBank - 1)];
			entity.BenefBranch = (System.String)reader[((int)PaymentOrderColumn.BenefBranch - 1)];
			entity.Amount = (System.Decimal)reader[((int)PaymentOrderColumn.Amount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.PaymentOrder"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.PaymentOrder"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.PaymentOrder entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TransNum = (System.String)dataRow["trans_num"];
			entity.OriginalTransNum = (System.String)dataRow["trans_num"];
			entity.Payer = (System.String)dataRow["payer"];
			entity.PayerAcc = (System.String)dataRow["payer_acc"];
			entity.PayerBank = (System.String)dataRow["payer_bank"];
			entity.PayerBranch = (System.String)dataRow["payer_branch"];
			entity.Benef = (System.String)dataRow["benef"];
			entity.BenefAcc = (System.String)dataRow["benef_acc"];
			entity.BenefBank = (System.String)dataRow["benef_bank"];
			entity.BenefBranch = (System.String)dataRow["benef_branch"];
			entity.Amount = (System.Decimal)dataRow["amount"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.PaymentOrder"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.PaymentOrder Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.PaymentOrder entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.PaymentOrder object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.PaymentOrder instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.PaymentOrder Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.PaymentOrder entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region PaymentOrderChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.PaymentOrder</c>
	///</summary>
	public enum PaymentOrderChildEntityTypes
	{
	}
	
	#endregion PaymentOrderChildEntityTypes
	
	#region PaymentOrderFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PaymentOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PaymentOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PaymentOrderFilterBuilder : SqlFilterBuilder<PaymentOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilterBuilder class.
		/// </summary>
		public PaymentOrderFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PaymentOrderFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PaymentOrderFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PaymentOrderFilterBuilder
	
	#region PaymentOrderParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PaymentOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PaymentOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PaymentOrderParameterBuilder : ParameterizedSqlFilterBuilder<PaymentOrderColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaymentOrderParameterBuilder class.
		/// </summary>
		public PaymentOrderParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PaymentOrderParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PaymentOrderParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PaymentOrderParameterBuilder
	
	#region PaymentOrderSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PaymentOrderColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PaymentOrder"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PaymentOrderSortBuilder : SqlSortBuilder<PaymentOrderColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaymentOrderSqlSortBuilder class.
		/// </summary>
		public PaymentOrderSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PaymentOrderSortBuilder
	
} // end namespace
