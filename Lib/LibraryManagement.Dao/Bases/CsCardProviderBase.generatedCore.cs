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
	/// This class is the base class for any <see cref="CsCardProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CsCardProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.CsCard, LibraryManagement.Domain.CsCardKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.CsCardKey key)
		{
			return Delete(transactionManager, key.CardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_cardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _cardId)
		{
			return Delete(null, _cardId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cardId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _cardId);		
		
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
		public override LibraryManagement.Domain.CsCard Get(TransactionManager transactionManager, LibraryManagement.Domain.CsCardKey key, int start, int pageLength)
		{
			return GetByCardId(transactionManager, key.CardId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblCustCard index.
		/// </summary>
		/// <param name="_cardId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public LibraryManagement.Domain.CsCard GetByCardId(System.String _cardId)
		{
			int count = -1;
			return GetByCardId(null,_cardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustCard index.
		/// </summary>
		/// <param name="_cardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public LibraryManagement.Domain.CsCard GetByCardId(System.String _cardId, int start, int pageLength)
		{
			int count = -1;
			return GetByCardId(null, _cardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustCard index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cardId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public LibraryManagement.Domain.CsCard GetByCardId(TransactionManager transactionManager, System.String _cardId)
		{
			int count = -1;
			return GetByCardId(transactionManager, _cardId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustCard index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public LibraryManagement.Domain.CsCard GetByCardId(TransactionManager transactionManager, System.String _cardId, int start, int pageLength)
		{
			int count = -1;
			return GetByCardId(transactionManager, _cardId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustCard index.
		/// </summary>
		/// <param name="_cardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public LibraryManagement.Domain.CsCard GetByCardId(System.String _cardId, int start, int pageLength, out int count)
		{
			return GetByCardId(null, _cardId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblCustCard index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cardId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.CsCard"/> class.</returns>
		public abstract LibraryManagement.Domain.CsCard GetByCardId(TransactionManager transactionManager, System.String _cardId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CsCard&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CsCard&gt;"/></returns>
		public static TList<CsCard> Fill(IDataReader reader, TList<CsCard> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.CsCard c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CsCard")
					.Append("|").Append((System.String)reader[((int)CsCardColumn.CardId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<CsCard>(
					key.ToString(), // EntityTrackingKey
					"CsCard",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.CsCard();
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
					c.CardId = (System.String)reader[((int)CsCardColumn.CardId - 1)];
					c.OriginalCardId = c.CardId;
					c.IsVip = (reader.IsDBNull(((int)CsCardColumn.IsVip - 1)))?null:(System.Boolean?)reader[((int)CsCardColumn.IsVip - 1)];
					c.CsSex = (reader.IsDBNull(((int)CsCardColumn.CsSex - 1)))?null:(System.Boolean?)reader[((int)CsCardColumn.CsSex - 1)];
					c.PersonId = (reader.IsDBNull(((int)CsCardColumn.PersonId - 1)))?null:(System.String)reader[((int)CsCardColumn.PersonId - 1)];
					c.Birthday = (reader.IsDBNull(((int)CsCardColumn.Birthday - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.Birthday - 1)];
					c.PsIssuedate = (reader.IsDBNull(((int)CsCardColumn.PsIssuedate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.PsIssuedate - 1)];
					c.PsPlaceissuse = (reader.IsDBNull(((int)CsCardColumn.PsPlaceissuse - 1)))?null:(System.String)reader[((int)CsCardColumn.PsPlaceissuse - 1)];
					c.Fullname = (System.String)reader[((int)CsCardColumn.Fullname - 1)];
					c.Address = (System.String)reader[((int)CsCardColumn.Address - 1)];
					c.Phone = (reader.IsDBNull(((int)CsCardColumn.Phone - 1)))?null:(System.String)reader[((int)CsCardColumn.Phone - 1)];
					c.Email = (reader.IsDBNull(((int)CsCardColumn.Email - 1)))?null:(System.String)reader[((int)CsCardColumn.Email - 1)];
					c.DiscPc = (reader.IsDBNull(((int)CsCardColumn.DiscPc - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.DiscPc - 1)];
					c.IssDate = (reader.IsDBNull(((int)CsCardColumn.IssDate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.IssDate - 1)];
					c.DueDate = (reader.IsDBNull(((int)CsCardColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.DueDate - 1)];
					c.Image = (reader.IsDBNull(((int)CsCardColumn.Image - 1)))?null:(System.Byte[])reader[((int)CsCardColumn.Image - 1)];
					c.Remark = (reader.IsDBNull(((int)CsCardColumn.Remark - 1)))?null:(System.String)reader[((int)CsCardColumn.Remark - 1)];
					c.Begmark = (reader.IsDBNull(((int)CsCardColumn.Begmark - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.Begmark - 1)];
					c.Endmark = (reader.IsDBNull(((int)CsCardColumn.Endmark - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.Endmark - 1)];
					c.Status = (System.Boolean)reader[((int)CsCardColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.CsCard"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CsCard"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.CsCard entity)
		{
			if (!reader.Read()) return;
			
			entity.CardId = (System.String)reader[((int)CsCardColumn.CardId - 1)];
			entity.OriginalCardId = (System.String)reader["card_id"];
			entity.IsVip = (reader.IsDBNull(((int)CsCardColumn.IsVip - 1)))?null:(System.Boolean?)reader[((int)CsCardColumn.IsVip - 1)];
			entity.CsSex = (reader.IsDBNull(((int)CsCardColumn.CsSex - 1)))?null:(System.Boolean?)reader[((int)CsCardColumn.CsSex - 1)];
			entity.PersonId = (reader.IsDBNull(((int)CsCardColumn.PersonId - 1)))?null:(System.String)reader[((int)CsCardColumn.PersonId - 1)];
			entity.Birthday = (reader.IsDBNull(((int)CsCardColumn.Birthday - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.Birthday - 1)];
			entity.PsIssuedate = (reader.IsDBNull(((int)CsCardColumn.PsIssuedate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.PsIssuedate - 1)];
			entity.PsPlaceissuse = (reader.IsDBNull(((int)CsCardColumn.PsPlaceissuse - 1)))?null:(System.String)reader[((int)CsCardColumn.PsPlaceissuse - 1)];
			entity.Fullname = (System.String)reader[((int)CsCardColumn.Fullname - 1)];
			entity.Address = (System.String)reader[((int)CsCardColumn.Address - 1)];
			entity.Phone = (reader.IsDBNull(((int)CsCardColumn.Phone - 1)))?null:(System.String)reader[((int)CsCardColumn.Phone - 1)];
			entity.Email = (reader.IsDBNull(((int)CsCardColumn.Email - 1)))?null:(System.String)reader[((int)CsCardColumn.Email - 1)];
			entity.DiscPc = (reader.IsDBNull(((int)CsCardColumn.DiscPc - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.DiscPc - 1)];
			entity.IssDate = (reader.IsDBNull(((int)CsCardColumn.IssDate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.IssDate - 1)];
			entity.DueDate = (reader.IsDBNull(((int)CsCardColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)CsCardColumn.DueDate - 1)];
			entity.Image = (reader.IsDBNull(((int)CsCardColumn.Image - 1)))?null:(System.Byte[])reader[((int)CsCardColumn.Image - 1)];
			entity.Remark = (reader.IsDBNull(((int)CsCardColumn.Remark - 1)))?null:(System.String)reader[((int)CsCardColumn.Remark - 1)];
			entity.Begmark = (reader.IsDBNull(((int)CsCardColumn.Begmark - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.Begmark - 1)];
			entity.Endmark = (reader.IsDBNull(((int)CsCardColumn.Endmark - 1)))?null:(System.Decimal?)reader[((int)CsCardColumn.Endmark - 1)];
			entity.Status = (System.Boolean)reader[((int)CsCardColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.CsCard"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CsCard"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.CsCard entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CardId = (System.String)dataRow["card_id"];
			entity.OriginalCardId = (System.String)dataRow["card_id"];
			entity.IsVip = Convert.IsDBNull(dataRow["is_vip"]) ? null : (System.Boolean?)dataRow["is_vip"];
			entity.CsSex = Convert.IsDBNull(dataRow["cs_sex"]) ? null : (System.Boolean?)dataRow["cs_sex"];
			entity.PersonId = Convert.IsDBNull(dataRow["person_id"]) ? null : (System.String)dataRow["person_id"];
			entity.Birthday = Convert.IsDBNull(dataRow["birthday"]) ? null : (System.DateTime?)dataRow["birthday"];
			entity.PsIssuedate = Convert.IsDBNull(dataRow["ps_issuedate"]) ? null : (System.DateTime?)dataRow["ps_issuedate"];
			entity.PsPlaceissuse = Convert.IsDBNull(dataRow["ps_placeissuse"]) ? null : (System.String)dataRow["ps_placeissuse"];
			entity.Fullname = (System.String)dataRow["fullname"];
			entity.Address = (System.String)dataRow["address"];
			entity.Phone = Convert.IsDBNull(dataRow["phone"]) ? null : (System.String)dataRow["phone"];
			entity.Email = Convert.IsDBNull(dataRow["email"]) ? null : (System.String)dataRow["email"];
			entity.DiscPc = Convert.IsDBNull(dataRow["disc_pc"]) ? null : (System.Decimal?)dataRow["disc_pc"];
			entity.IssDate = Convert.IsDBNull(dataRow["iss_date"]) ? null : (System.DateTime?)dataRow["iss_date"];
			entity.DueDate = Convert.IsDBNull(dataRow["due_date"]) ? null : (System.DateTime?)dataRow["due_date"];
			entity.Image = Convert.IsDBNull(dataRow["image"]) ? null : (System.Byte[])dataRow["image"];
			entity.Remark = Convert.IsDBNull(dataRow["remark"]) ? null : (System.String)dataRow["remark"];
			entity.Begmark = Convert.IsDBNull(dataRow["begmark"]) ? null : (System.Decimal?)dataRow["begmark"];
			entity.Endmark = Convert.IsDBNull(dataRow["endmark"]) ? null : (System.Decimal?)dataRow["endmark"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.CsCard"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.CsCard Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.CsCard entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.CsCard object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.CsCard instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.CsCard Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.CsCard entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CsCardChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.CsCard</c>
	///</summary>
	public enum CsCardChildEntityTypes
	{
	}
	
	#endregion CsCardChildEntityTypes
	
	#region CsCardFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CsCardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CsCard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CsCardFilterBuilder : SqlFilterBuilder<CsCardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CsCardFilterBuilder class.
		/// </summary>
		public CsCardFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CsCardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CsCardFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CsCardFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CsCardFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CsCardFilterBuilder
	
	#region CsCardParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CsCardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CsCard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CsCardParameterBuilder : ParameterizedSqlFilterBuilder<CsCardColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CsCardParameterBuilder class.
		/// </summary>
		public CsCardParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CsCardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CsCardParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CsCardParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CsCardParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CsCardParameterBuilder
	
	#region CsCardSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CsCardColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CsCard"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CsCardSortBuilder : SqlSortBuilder<CsCardColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CsCardSqlSortBuilder class.
		/// </summary>
		public CsCardSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CsCardSortBuilder
	
} // end namespace
