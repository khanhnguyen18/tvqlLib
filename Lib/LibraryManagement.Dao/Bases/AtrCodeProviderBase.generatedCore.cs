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
	/// This class is the base class for any <see cref="AtrCodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AtrCodeProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.AtrCode, LibraryManagement.Domain.AtrCodeKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.AtrCodeKey key)
		{
			return Delete(transactionManager, key.TransCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_transCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _transCode)
		{
			return Delete(null, _transCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _transCode);		
		
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
		public override LibraryManagement.Domain.AtrCode Get(TransactionManager transactionManager, LibraryManagement.Domain.AtrCodeKey key, int start, int pageLength)
		{
			return GetByTransCode(transactionManager, key.TransCode, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblAtrCode index.
		/// </summary>
		/// <param name="_transCode"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public LibraryManagement.Domain.AtrCode GetByTransCode(System.String _transCode)
		{
			int count = -1;
			return GetByTransCode(null,_transCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtrCode index.
		/// </summary>
		/// <param name="_transCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public LibraryManagement.Domain.AtrCode GetByTransCode(System.String _transCode, int start, int pageLength)
		{
			int count = -1;
			return GetByTransCode(null, _transCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtrCode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public LibraryManagement.Domain.AtrCode GetByTransCode(TransactionManager transactionManager, System.String _transCode)
		{
			int count = -1;
			return GetByTransCode(transactionManager, _transCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtrCode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public LibraryManagement.Domain.AtrCode GetByTransCode(TransactionManager transactionManager, System.String _transCode, int start, int pageLength)
		{
			int count = -1;
			return GetByTransCode(transactionManager, _transCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtrCode index.
		/// </summary>
		/// <param name="_transCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public LibraryManagement.Domain.AtrCode GetByTransCode(System.String _transCode, int start, int pageLength, out int count)
		{
			return GetByTransCode(null, _transCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAtrCode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_transCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AtrCode"/> class.</returns>
		public abstract LibraryManagement.Domain.AtrCode GetByTransCode(TransactionManager transactionManager, System.String _transCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AtrCode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AtrCode&gt;"/></returns>
		public static TList<AtrCode> Fill(IDataReader reader, TList<AtrCode> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.AtrCode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AtrCode")
					.Append("|").Append((System.String)reader[((int)AtrCodeColumn.TransCode - 1)]).ToString();
					c = EntityManager.LocateOrCreate<AtrCode>(
					key.ToString(), // EntityTrackingKey
					"AtrCode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.AtrCode();
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
					c.TransCode = (System.String)reader[((int)AtrCodeColumn.TransCode - 1)];
					c.OriginalTransCode = c.TransCode;
					c.TransName = (reader.IsDBNull(((int)AtrCodeColumn.TransName - 1)))?null:(System.String)reader[((int)AtrCodeColumn.TransName - 1)];
					c.Status = (reader.IsDBNull(((int)AtrCodeColumn.Status - 1)))?null:(System.Boolean?)reader[((int)AtrCodeColumn.Status - 1)];
					c.DbAccid = (reader.IsDBNull(((int)AtrCodeColumn.DbAccid - 1)))?null:(System.String)reader[((int)AtrCodeColumn.DbAccid - 1)];
					c.CrAccid = (reader.IsDBNull(((int)AtrCodeColumn.CrAccid - 1)))?null:(System.String)reader[((int)AtrCodeColumn.CrAccid - 1)];
					c.Accid1 = (reader.IsDBNull(((int)AtrCodeColumn.Accid1 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid1 - 1)];
					c.Accid2 = (reader.IsDBNull(((int)AtrCodeColumn.Accid2 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid2 - 1)];
					c.Accid3 = (reader.IsDBNull(((int)AtrCodeColumn.Accid3 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid3 - 1)];
					c.Pcommand = (reader.IsDBNull(((int)AtrCodeColumn.Pcommand - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Pcommand - 1)];
					c.Form = (reader.IsDBNull(((int)AtrCodeColumn.Form - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Form - 1)];
					c.Voucher = (reader.IsDBNull(((int)AtrCodeColumn.Voucher - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Voucher - 1)];
					c.Fvoucher = (reader.IsDBNull(((int)AtrCodeColumn.Fvoucher - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Fvoucher - 1)];
					c.Nov = (reader.IsDBNull(((int)AtrCodeColumn.Nov - 1)))?null:(System.Decimal?)reader[((int)AtrCodeColumn.Nov - 1)];
					c.TrType = (reader.IsDBNull(((int)AtrCodeColumn.TrType - 1)))?null:(System.String)reader[((int)AtrCodeColumn.TrType - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.AtrCode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AtrCode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.AtrCode entity)
		{
			if (!reader.Read()) return;
			
			entity.TransCode = (System.String)reader[((int)AtrCodeColumn.TransCode - 1)];
			entity.OriginalTransCode = (System.String)reader["trans_code"];
			entity.TransName = (reader.IsDBNull(((int)AtrCodeColumn.TransName - 1)))?null:(System.String)reader[((int)AtrCodeColumn.TransName - 1)];
			entity.Status = (reader.IsDBNull(((int)AtrCodeColumn.Status - 1)))?null:(System.Boolean?)reader[((int)AtrCodeColumn.Status - 1)];
			entity.DbAccid = (reader.IsDBNull(((int)AtrCodeColumn.DbAccid - 1)))?null:(System.String)reader[((int)AtrCodeColumn.DbAccid - 1)];
			entity.CrAccid = (reader.IsDBNull(((int)AtrCodeColumn.CrAccid - 1)))?null:(System.String)reader[((int)AtrCodeColumn.CrAccid - 1)];
			entity.Accid1 = (reader.IsDBNull(((int)AtrCodeColumn.Accid1 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid1 - 1)];
			entity.Accid2 = (reader.IsDBNull(((int)AtrCodeColumn.Accid2 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid2 - 1)];
			entity.Accid3 = (reader.IsDBNull(((int)AtrCodeColumn.Accid3 - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Accid3 - 1)];
			entity.Pcommand = (reader.IsDBNull(((int)AtrCodeColumn.Pcommand - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Pcommand - 1)];
			entity.Form = (reader.IsDBNull(((int)AtrCodeColumn.Form - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Form - 1)];
			entity.Voucher = (reader.IsDBNull(((int)AtrCodeColumn.Voucher - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Voucher - 1)];
			entity.Fvoucher = (reader.IsDBNull(((int)AtrCodeColumn.Fvoucher - 1)))?null:(System.String)reader[((int)AtrCodeColumn.Fvoucher - 1)];
			entity.Nov = (reader.IsDBNull(((int)AtrCodeColumn.Nov - 1)))?null:(System.Decimal?)reader[((int)AtrCodeColumn.Nov - 1)];
			entity.TrType = (reader.IsDBNull(((int)AtrCodeColumn.TrType - 1)))?null:(System.String)reader[((int)AtrCodeColumn.TrType - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.AtrCode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AtrCode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.AtrCode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TransCode = (System.String)dataRow["trans_code"];
			entity.OriginalTransCode = (System.String)dataRow["trans_code"];
			entity.TransName = Convert.IsDBNull(dataRow["trans_name"]) ? null : (System.String)dataRow["trans_name"];
			entity.Status = Convert.IsDBNull(dataRow["status"]) ? null : (System.Boolean?)dataRow["status"];
			entity.DbAccid = Convert.IsDBNull(dataRow["db_accid"]) ? null : (System.String)dataRow["db_accid"];
			entity.CrAccid = Convert.IsDBNull(dataRow["cr_accid"]) ? null : (System.String)dataRow["cr_accid"];
			entity.Accid1 = Convert.IsDBNull(dataRow["accid1"]) ? null : (System.String)dataRow["accid1"];
			entity.Accid2 = Convert.IsDBNull(dataRow["accid2"]) ? null : (System.String)dataRow["accid2"];
			entity.Accid3 = Convert.IsDBNull(dataRow["accid3"]) ? null : (System.String)dataRow["accid3"];
			entity.Pcommand = Convert.IsDBNull(dataRow["pcommand"]) ? null : (System.String)dataRow["pcommand"];
			entity.Form = Convert.IsDBNull(dataRow["form"]) ? null : (System.String)dataRow["form"];
			entity.Voucher = Convert.IsDBNull(dataRow["voucher"]) ? null : (System.String)dataRow["voucher"];
			entity.Fvoucher = Convert.IsDBNull(dataRow["fvoucher"]) ? null : (System.String)dataRow["fvoucher"];
			entity.Nov = Convert.IsDBNull(dataRow["nov"]) ? null : (System.Decimal?)dataRow["nov"];
			entity.TrType = Convert.IsDBNull(dataRow["tr_type"]) ? null : (System.String)dataRow["tr_type"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AtrCode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.AtrCode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.AtrCode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.AtrCode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.AtrCode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.AtrCode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.AtrCode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region AtrCodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.AtrCode</c>
	///</summary>
	public enum AtrCodeChildEntityTypes
	{
	}
	
	#endregion AtrCodeChildEntityTypes
	
	#region AtrCodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AtrCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AtrCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AtrCodeFilterBuilder : SqlFilterBuilder<AtrCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilterBuilder class.
		/// </summary>
		public AtrCodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AtrCodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AtrCodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AtrCodeFilterBuilder
	
	#region AtrCodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AtrCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AtrCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AtrCodeParameterBuilder : ParameterizedSqlFilterBuilder<AtrCodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AtrCodeParameterBuilder class.
		/// </summary>
		public AtrCodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AtrCodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AtrCodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AtrCodeParameterBuilder
	
	#region AtrCodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AtrCodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AtrCode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AtrCodeSortBuilder : SqlSortBuilder<AtrCodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AtrCodeSqlSortBuilder class.
		/// </summary>
		public AtrCodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AtrCodeSortBuilder
	
} // end namespace
