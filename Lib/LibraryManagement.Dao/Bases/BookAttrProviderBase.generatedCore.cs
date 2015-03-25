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
	/// This class is the base class for any <see cref="BookAttrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class BookAttrProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.BookAttr, LibraryManagement.Domain.BookAttrKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.BookAttrKey key)
		{
			return Delete(transactionManager, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _goodsId)
		{
			return Delete(null, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _goodsId);		
		
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
		public override LibraryManagement.Domain.BookAttr Get(TransactionManager transactionManager, LibraryManagement.Domain.BookAttrKey key, int start, int pageLength)
		{
			return GetByGoodsId(transactionManager, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblBookAttr index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public LibraryManagement.Domain.BookAttr GetByGoodsId(System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(null,_goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblBookAttr index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public LibraryManagement.Domain.BookAttr GetByGoodsId(System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblBookAttr index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public LibraryManagement.Domain.BookAttr GetByGoodsId(TransactionManager transactionManager, System.String _goodsId)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblBookAttr index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public LibraryManagement.Domain.BookAttr GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByGoodsId(transactionManager, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblBookAttr index.
		/// </summary>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public LibraryManagement.Domain.BookAttr GetByGoodsId(System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByGoodsId(null, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblBookAttr index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.BookAttr"/> class.</returns>
		public abstract LibraryManagement.Domain.BookAttr GetByGoodsId(TransactionManager transactionManager, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;BookAttr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;BookAttr&gt;"/></returns>
		public static TList<BookAttr> Fill(IDataReader reader, TList<BookAttr> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.BookAttr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("BookAttr")
					.Append("|").Append((System.String)reader[((int)BookAttrColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<BookAttr>(
					key.ToString(), // EntityTrackingKey
					"BookAttr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.BookAttr();
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
					c.GoodsId = (System.String)reader[((int)BookAttrColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.Author = (System.String)reader[((int)BookAttrColumn.Author - 1)];
					c.Publish = (System.String)reader[((int)BookAttrColumn.Publish - 1)];
					c.Translator = (System.String)reader[((int)BookAttrColumn.Translator - 1)];
					c.FormType = (System.Int32)reader[((int)BookAttrColumn.FormType - 1)];
					c.Language = (System.Int32)reader[((int)BookAttrColumn.Language - 1)];
					c.PlMonth = (System.Int32)reader[((int)BookAttrColumn.PlMonth - 1)];
					c.PlYear = (System.Int32)reader[((int)BookAttrColumn.PlYear - 1)];
					c.Dimension = (System.String)reader[((int)BookAttrColumn.Dimension - 1)];
					c.Weight = (System.Int32)reader[((int)BookAttrColumn.Weight - 1)];
					c.Pages = (System.Int32)reader[((int)BookAttrColumn.Pages - 1)];
					c.Introinfo = (System.String)reader[((int)BookAttrColumn.Introinfo - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.BookAttr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.BookAttr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.BookAttr entity)
		{
			if (!reader.Read()) return;
			
			entity.GoodsId = (System.String)reader[((int)BookAttrColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.Author = (System.String)reader[((int)BookAttrColumn.Author - 1)];
			entity.Publish = (System.String)reader[((int)BookAttrColumn.Publish - 1)];
			entity.Translator = (System.String)reader[((int)BookAttrColumn.Translator - 1)];
			entity.FormType = (System.Int32)reader[((int)BookAttrColumn.FormType - 1)];
			entity.Language = (System.Int32)reader[((int)BookAttrColumn.Language - 1)];
			entity.PlMonth = (System.Int32)reader[((int)BookAttrColumn.PlMonth - 1)];
			entity.PlYear = (System.Int32)reader[((int)BookAttrColumn.PlYear - 1)];
			entity.Dimension = (System.String)reader[((int)BookAttrColumn.Dimension - 1)];
			entity.Weight = (System.Int32)reader[((int)BookAttrColumn.Weight - 1)];
			entity.Pages = (System.Int32)reader[((int)BookAttrColumn.Pages - 1)];
			entity.Introinfo = (System.String)reader[((int)BookAttrColumn.Introinfo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.BookAttr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.BookAttr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.BookAttr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
			entity.Author = (System.String)dataRow["author"];
			entity.Publish = (System.String)dataRow["publish"];
			entity.Translator = (System.String)dataRow["translator"];
			entity.FormType = (System.Int32)dataRow["form_type"];
			entity.Language = (System.Int32)dataRow["language"];
			entity.PlMonth = (System.Int32)dataRow["pl_month"];
			entity.PlYear = (System.Int32)dataRow["pl_year"];
			entity.Dimension = (System.String)dataRow["dimension"];
			entity.Weight = (System.Int32)dataRow["weight"];
			entity.Pages = (System.Int32)dataRow["pages"];
			entity.Introinfo = (System.String)dataRow["introinfo"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.BookAttr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.BookAttr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.BookAttr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.BookAttr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.BookAttr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.BookAttr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.BookAttr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region BookAttrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.BookAttr</c>
	///</summary>
	public enum BookAttrChildEntityTypes
	{
	}
	
	#endregion BookAttrChildEntityTypes
	
	#region BookAttrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;BookAttrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BookAttr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookAttrFilterBuilder : SqlFilterBuilder<BookAttrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookAttrFilterBuilder class.
		/// </summary>
		public BookAttrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookAttrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookAttrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookAttrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookAttrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookAttrFilterBuilder
	
	#region BookAttrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;BookAttrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BookAttr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookAttrParameterBuilder : ParameterizedSqlFilterBuilder<BookAttrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookAttrParameterBuilder class.
		/// </summary>
		public BookAttrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookAttrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookAttrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookAttrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookAttrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookAttrParameterBuilder
	
	#region BookAttrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;BookAttrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BookAttr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class BookAttrSortBuilder : SqlSortBuilder<BookAttrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookAttrSqlSortBuilder class.
		/// </summary>
		public BookAttrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion BookAttrSortBuilder
	
} // end namespace
