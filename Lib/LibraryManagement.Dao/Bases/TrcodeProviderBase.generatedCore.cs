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
	/// This class is the base class for any <see cref="TrcodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrcodeProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Trcode, LibraryManagement.Domain.TrcodeKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.TrcodeKey key)
		{
			return Delete(transactionManager, key.TrCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _trCode)
		{
			return Delete(null, _trCode);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trCode">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _trCode);		
		
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
		public override LibraryManagement.Domain.Trcode Get(TransactionManager transactionManager, LibraryManagement.Domain.TrcodeKey key, int start, int pageLength)
		{
			return GetByTrCode(transactionManager, key.TrCode, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblTrcode index.
		/// </summary>
		/// <param name="_trCode"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public LibraryManagement.Domain.Trcode GetByTrCode(System.String _trCode)
		{
			int count = -1;
			return GetByTrCode(null,_trCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTrcode index.
		/// </summary>
		/// <param name="_trCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public LibraryManagement.Domain.Trcode GetByTrCode(System.String _trCode, int start, int pageLength)
		{
			int count = -1;
			return GetByTrCode(null, _trCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTrcode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public LibraryManagement.Domain.Trcode GetByTrCode(TransactionManager transactionManager, System.String _trCode)
		{
			int count = -1;
			return GetByTrCode(transactionManager, _trCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTrcode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public LibraryManagement.Domain.Trcode GetByTrCode(TransactionManager transactionManager, System.String _trCode, int start, int pageLength)
		{
			int count = -1;
			return GetByTrCode(transactionManager, _trCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTrcode index.
		/// </summary>
		/// <param name="_trCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public LibraryManagement.Domain.Trcode GetByTrCode(System.String _trCode, int start, int pageLength, out int count)
		{
			return GetByTrCode(null, _trCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTrcode index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Trcode"/> class.</returns>
		public abstract LibraryManagement.Domain.Trcode GetByTrCode(TransactionManager transactionManager, System.String _trCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Trcode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Trcode&gt;"/></returns>
		public static TList<Trcode> Fill(IDataReader reader, TList<Trcode> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Trcode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Trcode")
					.Append("|").Append((System.String)reader[((int)TrcodeColumn.TrCode - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Trcode>(
					key.ToString(), // EntityTrackingKey
					"Trcode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Trcode();
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
					c.TrCode = (System.String)reader[((int)TrcodeColumn.TrCode - 1)];
					c.OriginalTrCode = c.TrCode;
					c.TrName = (reader.IsDBNull(((int)TrcodeColumn.TrName - 1)))?null:(System.String)reader[((int)TrcodeColumn.TrName - 1)];
					c.Description = (System.String)reader[((int)TrcodeColumn.Description - 1)];
					c.TrDepart = (reader.IsDBNull(((int)TrcodeColumn.TrDepart - 1)))?null:(System.String)reader[((int)TrcodeColumn.TrDepart - 1)];
					c.FrmCaption = (reader.IsDBNull(((int)TrcodeColumn.FrmCaption - 1)))?null:(System.String)reader[((int)TrcodeColumn.FrmCaption - 1)];
					c.VoucherFile = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile - 1)];
					c.VoucherFile1 = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile1 - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile1 - 1)];
					c.VoucherFile2 = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile2 - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile2 - 1)];
					c.Status = (reader.IsDBNull(((int)TrcodeColumn.Status - 1)))?null:(System.Boolean?)reader[((int)TrcodeColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Trcode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Trcode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Trcode entity)
		{
			if (!reader.Read()) return;
			
			entity.TrCode = (System.String)reader[((int)TrcodeColumn.TrCode - 1)];
			entity.OriginalTrCode = (System.String)reader["trCode"];
			entity.TrName = (reader.IsDBNull(((int)TrcodeColumn.TrName - 1)))?null:(System.String)reader[((int)TrcodeColumn.TrName - 1)];
			entity.Description = (System.String)reader[((int)TrcodeColumn.Description - 1)];
			entity.TrDepart = (reader.IsDBNull(((int)TrcodeColumn.TrDepart - 1)))?null:(System.String)reader[((int)TrcodeColumn.TrDepart - 1)];
			entity.FrmCaption = (reader.IsDBNull(((int)TrcodeColumn.FrmCaption - 1)))?null:(System.String)reader[((int)TrcodeColumn.FrmCaption - 1)];
			entity.VoucherFile = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile - 1)];
			entity.VoucherFile1 = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile1 - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile1 - 1)];
			entity.VoucherFile2 = (reader.IsDBNull(((int)TrcodeColumn.VoucherFile2 - 1)))?null:(System.String)reader[((int)TrcodeColumn.VoucherFile2 - 1)];
			entity.Status = (reader.IsDBNull(((int)TrcodeColumn.Status - 1)))?null:(System.Boolean?)reader[((int)TrcodeColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Trcode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Trcode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Trcode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrCode = (System.String)dataRow["trCode"];
			entity.OriginalTrCode = (System.String)dataRow["trCode"];
			entity.TrName = Convert.IsDBNull(dataRow["trName"]) ? null : (System.String)dataRow["trName"];
			entity.Description = (System.String)dataRow["description"];
			entity.TrDepart = Convert.IsDBNull(dataRow["trDepart"]) ? null : (System.String)dataRow["trDepart"];
			entity.FrmCaption = Convert.IsDBNull(dataRow["frmCaption"]) ? null : (System.String)dataRow["frmCaption"];
			entity.VoucherFile = Convert.IsDBNull(dataRow["voucherFile"]) ? null : (System.String)dataRow["voucherFile"];
			entity.VoucherFile1 = Convert.IsDBNull(dataRow["voucherFile1"]) ? null : (System.String)dataRow["voucherFile1"];
			entity.VoucherFile2 = Convert.IsDBNull(dataRow["voucherFile2"]) ? null : (System.String)dataRow["voucherFile2"];
			entity.Status = Convert.IsDBNull(dataRow["Status"]) ? null : (System.Boolean?)dataRow["Status"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Trcode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Trcode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Trcode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Trcode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Trcode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Trcode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Trcode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TrcodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Trcode</c>
	///</summary>
	public enum TrcodeChildEntityTypes
	{
	}
	
	#endregion TrcodeChildEntityTypes
	
	#region TrcodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrcodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Trcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrcodeFilterBuilder : SqlFilterBuilder<TrcodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrcodeFilterBuilder class.
		/// </summary>
		public TrcodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrcodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrcodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrcodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrcodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrcodeFilterBuilder
	
	#region TrcodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrcodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Trcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrcodeParameterBuilder : ParameterizedSqlFilterBuilder<TrcodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrcodeParameterBuilder class.
		/// </summary>
		public TrcodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrcodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrcodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrcodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrcodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrcodeParameterBuilder
	
	#region TrcodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrcodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Trcode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrcodeSortBuilder : SqlSortBuilder<TrcodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrcodeSqlSortBuilder class.
		/// </summary>
		public TrcodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrcodeSortBuilder
	
} // end namespace
