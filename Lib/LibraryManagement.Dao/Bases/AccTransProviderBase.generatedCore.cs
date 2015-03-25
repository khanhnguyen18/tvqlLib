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
	/// This class is the base class for any <see cref="AccTransProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccTransProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.AccTrans, LibraryManagement.Domain.AccTransKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.AccTransKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _id)
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
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _id);		
		
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
		public override LibraryManagement.Domain.AccTrans Get(TransactionManager transactionManager, LibraryManagement.Domain.AccTransKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblAccTrans index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public LibraryManagement.Domain.AccTrans GetById(System.Decimal _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccTrans index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public LibraryManagement.Domain.AccTrans GetById(System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccTrans index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public LibraryManagement.Domain.AccTrans GetById(TransactionManager transactionManager, System.Decimal _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccTrans index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public LibraryManagement.Domain.AccTrans GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccTrans index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public LibraryManagement.Domain.AccTrans GetById(System.Decimal _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblAccTrans index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.AccTrans"/> class.</returns>
		public abstract LibraryManagement.Domain.AccTrans GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccTrans&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccTrans&gt;"/></returns>
		public static TList<AccTrans> Fill(IDataReader reader, TList<AccTrans> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.AccTrans c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccTrans")
					.Append("|").Append((System.Decimal)reader[((int)AccTransColumn.Id - 1)]).ToString();
					c = EntityManager.LocateOrCreate<AccTrans>(
					key.ToString(), // EntityTrackingKey
					"AccTrans",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.AccTrans();
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
					c.Id = (System.Decimal)reader[((int)AccTransColumn.Id - 1)];
					c.TranDate = (System.DateTime)reader[((int)AccTransColumn.TranDate - 1)];
					c.TranTime = (reader.IsDBNull(((int)AccTransColumn.TranTime - 1)))?null:(System.String)reader[((int)AccTransColumn.TranTime - 1)];
					c.EfDate = (reader.IsDBNull(((int)AccTransColumn.EfDate - 1)))?null:(System.DateTime?)reader[((int)AccTransColumn.EfDate - 1)];
					c.TransNum = (System.String)reader[((int)AccTransColumn.TransNum - 1)];
					c.Voucher = (System.String)reader[((int)AccTransColumn.Voucher - 1)];
					c.TransCode = (System.String)reader[((int)AccTransColumn.TransCode - 1)];
					c.AccountId = (System.String)reader[((int)AccTransColumn.AccountId - 1)];
					c.DbAmount = (System.Decimal)reader[((int)AccTransColumn.DbAmount - 1)];
					c.CrAmount = (System.Decimal)reader[((int)AccTransColumn.CrAmount - 1)];
					c.UserId = (System.Decimal)reader[((int)AccTransColumn.UserId - 1)];
					c.CorrAcc = (System.String)reader[((int)AccTransColumn.CorrAcc - 1)];
					c.Remark = (System.String)reader[((int)AccTransColumn.Remark - 1)];
					c.Name = (reader.IsDBNull(((int)AccTransColumn.Name - 1)))?null:(System.String)reader[((int)AccTransColumn.Name - 1)];
					c.Address = (reader.IsDBNull(((int)AccTransColumn.Address - 1)))?null:(System.String)reader[((int)AccTransColumn.Address - 1)];
					c.PersonId = (reader.IsDBNull(((int)AccTransColumn.PersonId - 1)))?null:(System.String)reader[((int)AccTransColumn.PersonId - 1)];
					c.Updated = (System.Boolean)reader[((int)AccTransColumn.Updated - 1)];
					c.Recnum = (reader.IsDBNull(((int)AccTransColumn.Recnum - 1)))?null:(System.Decimal?)reader[((int)AccTransColumn.Recnum - 1)];
					c.Status = (System.Boolean)reader[((int)AccTransColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.AccTrans"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AccTrans"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.AccTrans entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Decimal)reader[((int)AccTransColumn.Id - 1)];
			entity.TranDate = (System.DateTime)reader[((int)AccTransColumn.TranDate - 1)];
			entity.TranTime = (reader.IsDBNull(((int)AccTransColumn.TranTime - 1)))?null:(System.String)reader[((int)AccTransColumn.TranTime - 1)];
			entity.EfDate = (reader.IsDBNull(((int)AccTransColumn.EfDate - 1)))?null:(System.DateTime?)reader[((int)AccTransColumn.EfDate - 1)];
			entity.TransNum = (System.String)reader[((int)AccTransColumn.TransNum - 1)];
			entity.Voucher = (System.String)reader[((int)AccTransColumn.Voucher - 1)];
			entity.TransCode = (System.String)reader[((int)AccTransColumn.TransCode - 1)];
			entity.AccountId = (System.String)reader[((int)AccTransColumn.AccountId - 1)];
			entity.DbAmount = (System.Decimal)reader[((int)AccTransColumn.DbAmount - 1)];
			entity.CrAmount = (System.Decimal)reader[((int)AccTransColumn.CrAmount - 1)];
			entity.UserId = (System.Decimal)reader[((int)AccTransColumn.UserId - 1)];
			entity.CorrAcc = (System.String)reader[((int)AccTransColumn.CorrAcc - 1)];
			entity.Remark = (System.String)reader[((int)AccTransColumn.Remark - 1)];
			entity.Name = (reader.IsDBNull(((int)AccTransColumn.Name - 1)))?null:(System.String)reader[((int)AccTransColumn.Name - 1)];
			entity.Address = (reader.IsDBNull(((int)AccTransColumn.Address - 1)))?null:(System.String)reader[((int)AccTransColumn.Address - 1)];
			entity.PersonId = (reader.IsDBNull(((int)AccTransColumn.PersonId - 1)))?null:(System.String)reader[((int)AccTransColumn.PersonId - 1)];
			entity.Updated = (System.Boolean)reader[((int)AccTransColumn.Updated - 1)];
			entity.Recnum = (reader.IsDBNull(((int)AccTransColumn.Recnum - 1)))?null:(System.Decimal?)reader[((int)AccTransColumn.Recnum - 1)];
			entity.Status = (System.Boolean)reader[((int)AccTransColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.AccTrans"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AccTrans"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.AccTrans entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Decimal)dataRow["id"];
			entity.TranDate = (System.DateTime)dataRow["tran_date"];
			entity.TranTime = Convert.IsDBNull(dataRow["tran_time"]) ? null : (System.String)dataRow["tran_time"];
			entity.EfDate = Convert.IsDBNull(dataRow["ef_date"]) ? null : (System.DateTime?)dataRow["ef_date"];
			entity.TransNum = (System.String)dataRow["trans_num"];
			entity.Voucher = (System.String)dataRow["voucher"];
			entity.TransCode = (System.String)dataRow["trans_code"];
			entity.AccountId = (System.String)dataRow["account_id"];
			entity.DbAmount = (System.Decimal)dataRow["db_amount"];
			entity.CrAmount = (System.Decimal)dataRow["cr_amount"];
			entity.UserId = (System.Decimal)dataRow["user_id"];
			entity.CorrAcc = (System.String)dataRow["corr_acc"];
			entity.Remark = (System.String)dataRow["remark"];
			entity.Name = Convert.IsDBNull(dataRow["name"]) ? null : (System.String)dataRow["name"];
			entity.Address = Convert.IsDBNull(dataRow["address"]) ? null : (System.String)dataRow["address"];
			entity.PersonId = Convert.IsDBNull(dataRow["person_id"]) ? null : (System.String)dataRow["person_id"];
			entity.Updated = (System.Boolean)dataRow["updated"];
			entity.Recnum = Convert.IsDBNull(dataRow["recnum"]) ? null : (System.Decimal?)dataRow["recnum"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.AccTrans"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.AccTrans Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.AccTrans entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.AccTrans object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.AccTrans instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.AccTrans Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.AccTrans entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region AccTransChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.AccTrans</c>
	///</summary>
	public enum AccTransChildEntityTypes
	{
	}
	
	#endregion AccTransChildEntityTypes
	
	#region AccTransFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccTransFilterBuilder : SqlFilterBuilder<AccTransColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccTransFilterBuilder class.
		/// </summary>
		public AccTransFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccTransFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccTransFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccTransFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccTransFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccTransFilterBuilder
	
	#region AccTransParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccTransParameterBuilder : ParameterizedSqlFilterBuilder<AccTransColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccTransParameterBuilder class.
		/// </summary>
		public AccTransParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccTransParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccTransParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccTransParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccTransParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccTransParameterBuilder
	
	#region AccTransSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccTransColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccTrans"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccTransSortBuilder : SqlSortBuilder<AccTransColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccTransSqlSortBuilder class.
		/// </summary>
		public AccTransSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccTransSortBuilder
	
} // end namespace
