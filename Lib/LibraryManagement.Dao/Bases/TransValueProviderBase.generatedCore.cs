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
	/// This class is the base class for any <see cref="TransValueProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TransValueProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.TransValue, LibraryManagement.Domain.TransValueKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.TransValueKey key)
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
		public override LibraryManagement.Domain.TransValue Get(TransactionManager transactionManager, LibraryManagement.Domain.TransValueKey key, int start, int pageLength)
		{
			return GetByTransNum(transactionManager, key.TransNum, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblTransValue index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public LibraryManagement.Domain.TransValue GetByTransNum(System.String _transNum)
		{
			int count = -1;
			return GetByTransNum(null,_transNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransValue index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public LibraryManagement.Domain.TransValue GetByTransNum(System.String _transNum, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNum(null, _transNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransValue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public LibraryManagement.Domain.TransValue GetByTransNum(TransactionManager transactionManager, System.String _transNum)
		{
			int count = -1;
			return GetByTransNum(transactionManager, _transNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransValue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public LibraryManagement.Domain.TransValue GetByTransNum(TransactionManager transactionManager, System.String _transNum, int start, int pageLength)
		{
			int count = -1;
			return GetByTransNum(transactionManager, _transNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransValue index.
		/// </summary>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public LibraryManagement.Domain.TransValue GetByTransNum(System.String _transNum, int start, int pageLength, out int count)
		{
			return GetByTransNum(null, _transNum, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransValue index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transNum"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.TransValue"/> class.</returns>
		public abstract LibraryManagement.Domain.TransValue GetByTransNum(TransactionManager transactionManager, System.String _transNum, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TransValue&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TransValue&gt;"/></returns>
		public static TList<TransValue> Fill(IDataReader reader, TList<TransValue> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.TransValue c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TransValue")
					.Append("|").Append((System.String)reader[((int)TransValueColumn.TransNum - 1)]).ToString();
					c = EntityManager.LocateOrCreate<TransValue>(
					key.ToString(), // EntityTrackingKey
					"TransValue",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.TransValue();
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
					c.TransNum = (System.String)reader[((int)TransValueColumn.TransNum - 1)];
					c.OriginalTransNum = c.TransNum;
					c.Amount = (reader.IsDBNull(((int)TransValueColumn.Amount - 1)))?null:(System.Decimal?)reader[((int)TransValueColumn.Amount - 1)];
					c.Frcustomer = (reader.IsDBNull(((int)TransValueColumn.Frcustomer - 1)))?null:(System.Decimal?)reader[((int)TransValueColumn.Frcustomer - 1)];
					c.Forex = (reader.IsDBNull(((int)TransValueColumn.Forex - 1)))?null:(System.String)reader[((int)TransValueColumn.Forex - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.TransValue"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.TransValue"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.TransValue entity)
		{
			if (!reader.Read()) return;
			
			entity.TransNum = (System.String)reader[((int)TransValueColumn.TransNum - 1)];
			entity.OriginalTransNum = (System.String)reader["trans_num"];
			entity.Amount = (reader.IsDBNull(((int)TransValueColumn.Amount - 1)))?null:(System.Decimal?)reader[((int)TransValueColumn.Amount - 1)];
			entity.Frcustomer = (reader.IsDBNull(((int)TransValueColumn.Frcustomer - 1)))?null:(System.Decimal?)reader[((int)TransValueColumn.Frcustomer - 1)];
			entity.Forex = (reader.IsDBNull(((int)TransValueColumn.Forex - 1)))?null:(System.String)reader[((int)TransValueColumn.Forex - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.TransValue"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.TransValue"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.TransValue entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TransNum = (System.String)dataRow["trans_num"];
			entity.OriginalTransNum = (System.String)dataRow["trans_num"];
			entity.Amount = Convert.IsDBNull(dataRow["amount"]) ? null : (System.Decimal?)dataRow["amount"];
			entity.Frcustomer = Convert.IsDBNull(dataRow["frcustomer"]) ? null : (System.Decimal?)dataRow["frcustomer"];
			entity.Forex = Convert.IsDBNull(dataRow["forex"]) ? null : (System.String)dataRow["forex"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.TransValue"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.TransValue Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.TransValue entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.TransValue object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.TransValue instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.TransValue Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.TransValue entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TransValueChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.TransValue</c>
	///</summary>
	public enum TransValueChildEntityTypes
	{
	}
	
	#endregion TransValueChildEntityTypes
	
	#region TransValueFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TransValueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TransValue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransValueFilterBuilder : SqlFilterBuilder<TransValueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransValueFilterBuilder class.
		/// </summary>
		public TransValueFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransValueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransValueFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransValueFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransValueFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransValueFilterBuilder
	
	#region TransValueParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TransValueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TransValue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransValueParameterBuilder : ParameterizedSqlFilterBuilder<TransValueColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransValueParameterBuilder class.
		/// </summary>
		public TransValueParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransValueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransValueParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransValueParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransValueParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransValueParameterBuilder
	
	#region TransValueSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TransValueColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TransValue"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TransValueSortBuilder : SqlSortBuilder<TransValueColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransValueSqlSortBuilder class.
		/// </summary>
		public TransValueSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TransValueSortBuilder
	
} // end namespace
