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
	/// This class is the base class for any <see cref="ModePaymentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ModePaymentProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.ModePayment, LibraryManagement.Domain.ModePaymentKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.ModePaymentKey key)
		{
			return Delete(transactionManager, key.PmtMode, key.Forex);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pmtMode">. Primary Key.</param>
		/// <param name="_forex">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _pmtMode, System.String _forex)
		{
			return Delete(null, _pmtMode, _forex);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pmtMode">. Primary Key.</param>
		/// <param name="_forex">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _pmtMode, System.String _forex);		
		
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
		public override LibraryManagement.Domain.ModePayment Get(TransactionManager transactionManager, LibraryManagement.Domain.ModePaymentKey key, int start, int pageLength)
		{
			return GetByPmtModeForex(transactionManager, key.PmtMode, key.Forex, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblModePayment index.
		/// </summary>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public LibraryManagement.Domain.ModePayment GetByPmtModeForex(System.String _pmtMode, System.String _forex)
		{
			int count = -1;
			return GetByPmtModeForex(null,_pmtMode, _forex, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblModePayment index.
		/// </summary>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public LibraryManagement.Domain.ModePayment GetByPmtModeForex(System.String _pmtMode, System.String _forex, int start, int pageLength)
		{
			int count = -1;
			return GetByPmtModeForex(null, _pmtMode, _forex, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblModePayment index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public LibraryManagement.Domain.ModePayment GetByPmtModeForex(TransactionManager transactionManager, System.String _pmtMode, System.String _forex)
		{
			int count = -1;
			return GetByPmtModeForex(transactionManager, _pmtMode, _forex, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblModePayment index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public LibraryManagement.Domain.ModePayment GetByPmtModeForex(TransactionManager transactionManager, System.String _pmtMode, System.String _forex, int start, int pageLength)
		{
			int count = -1;
			return GetByPmtModeForex(transactionManager, _pmtMode, _forex, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblModePayment index.
		/// </summary>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public LibraryManagement.Domain.ModePayment GetByPmtModeForex(System.String _pmtMode, System.String _forex, int start, int pageLength, out int count)
		{
			return GetByPmtModeForex(null, _pmtMode, _forex, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblModePayment index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pmtMode"></param>
		/// <param name="_forex"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.ModePayment"/> class.</returns>
		public abstract LibraryManagement.Domain.ModePayment GetByPmtModeForex(TransactionManager transactionManager, System.String _pmtMode, System.String _forex, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ModePayment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ModePayment&gt;"/></returns>
		public static TList<ModePayment> Fill(IDataReader reader, TList<ModePayment> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.ModePayment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ModePayment")
					.Append("|").Append((System.String)reader[((int)ModePaymentColumn.PmtMode - 1)])
					.Append("|").Append((System.String)reader[((int)ModePaymentColumn.Forex - 1)]).ToString();
					c = EntityManager.LocateOrCreate<ModePayment>(
					key.ToString(), // EntityTrackingKey
					"ModePayment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.ModePayment();
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
					c.PmtMode = (System.String)reader[((int)ModePaymentColumn.PmtMode - 1)];
					c.OriginalPmtMode = c.PmtMode;
					c.Description = (reader.IsDBNull(((int)ModePaymentColumn.Description - 1)))?null:(System.String)reader[((int)ModePaymentColumn.Description - 1)];
					c.Forex = (System.String)reader[((int)ModePaymentColumn.Forex - 1)];
					c.OriginalForex = c.Forex;
					c.ForexRate = (reader.IsDBNull(((int)ModePaymentColumn.ForexRate - 1)))?null:(System.Decimal?)reader[((int)ModePaymentColumn.ForexRate - 1)];
					c.Iscard = (reader.IsDBNull(((int)ModePaymentColumn.Iscard - 1)))?null:(System.String)reader[((int)ModePaymentColumn.Iscard - 1)];
					c.Status = (reader.IsDBNull(((int)ModePaymentColumn.Status - 1)))?null:(System.Boolean?)reader[((int)ModePaymentColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.ModePayment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.ModePayment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.ModePayment entity)
		{
			if (!reader.Read()) return;
			
			entity.PmtMode = (System.String)reader[((int)ModePaymentColumn.PmtMode - 1)];
			entity.OriginalPmtMode = (System.String)reader["pmt_mode"];
			entity.Description = (reader.IsDBNull(((int)ModePaymentColumn.Description - 1)))?null:(System.String)reader[((int)ModePaymentColumn.Description - 1)];
			entity.Forex = (System.String)reader[((int)ModePaymentColumn.Forex - 1)];
			entity.OriginalForex = (System.String)reader["forex"];
			entity.ForexRate = (reader.IsDBNull(((int)ModePaymentColumn.ForexRate - 1)))?null:(System.Decimal?)reader[((int)ModePaymentColumn.ForexRate - 1)];
			entity.Iscard = (reader.IsDBNull(((int)ModePaymentColumn.Iscard - 1)))?null:(System.String)reader[((int)ModePaymentColumn.Iscard - 1)];
			entity.Status = (reader.IsDBNull(((int)ModePaymentColumn.Status - 1)))?null:(System.Boolean?)reader[((int)ModePaymentColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.ModePayment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.ModePayment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.ModePayment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PmtMode = (System.String)dataRow["pmt_mode"];
			entity.OriginalPmtMode = (System.String)dataRow["pmt_mode"];
			entity.Description = Convert.IsDBNull(dataRow["description"]) ? null : (System.String)dataRow["description"];
			entity.Forex = (System.String)dataRow["forex"];
			entity.OriginalForex = (System.String)dataRow["forex"];
			entity.ForexRate = Convert.IsDBNull(dataRow["forex_rate"]) ? null : (System.Decimal?)dataRow["forex_rate"];
			entity.Iscard = Convert.IsDBNull(dataRow["iscard"]) ? null : (System.String)dataRow["iscard"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Boolean?)dataRow["status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.ModePayment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.ModePayment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.ModePayment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.ModePayment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.ModePayment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.ModePayment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.ModePayment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ModePaymentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.ModePayment</c>
	///</summary>
	public enum ModePaymentChildEntityTypes
	{
	}
	
	#endregion ModePaymentChildEntityTypes
	
	#region ModePaymentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ModePaymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModePayment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModePaymentFilterBuilder : SqlFilterBuilder<ModePaymentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilterBuilder class.
		/// </summary>
		public ModePaymentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModePaymentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModePaymentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModePaymentFilterBuilder
	
	#region ModePaymentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ModePaymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModePayment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModePaymentParameterBuilder : ParameterizedSqlFilterBuilder<ModePaymentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModePaymentParameterBuilder class.
		/// </summary>
		public ModePaymentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModePaymentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModePaymentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModePaymentParameterBuilder
	
	#region ModePaymentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ModePaymentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModePayment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ModePaymentSortBuilder : SqlSortBuilder<ModePaymentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModePaymentSqlSortBuilder class.
		/// </summary>
		public ModePaymentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ModePaymentSortBuilder
	
} // end namespace
