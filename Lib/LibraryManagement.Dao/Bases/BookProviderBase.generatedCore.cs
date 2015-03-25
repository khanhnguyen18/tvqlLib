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
	/// This class is the base class for any <see cref="BookProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class BookProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Book, LibraryManagement.Domain.BookKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.BookKey key)
		{
			return Delete(transactionManager, key.BookId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_bookId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int64 _bookId)
		{
			return Delete(null, _bookId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bookId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int64 _bookId);		
		
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
		public override LibraryManagement.Domain.Book Get(TransactionManager transactionManager, LibraryManagement.Domain.BookKey key, int start, int pageLength)
		{
			return GetByBookId(transactionManager, key.BookId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_QUYENSACH index.
		/// </summary>
		/// <param name="_bookId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public LibraryManagement.Domain.Book GetByBookId(System.Int64 _bookId)
		{
			int count = -1;
			return GetByBookId(null,_bookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QUYENSACH index.
		/// </summary>
		/// <param name="_bookId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public LibraryManagement.Domain.Book GetByBookId(System.Int64 _bookId, int start, int pageLength)
		{
			int count = -1;
			return GetByBookId(null, _bookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QUYENSACH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bookId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public LibraryManagement.Domain.Book GetByBookId(TransactionManager transactionManager, System.Int64 _bookId)
		{
			int count = -1;
			return GetByBookId(transactionManager, _bookId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QUYENSACH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bookId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public LibraryManagement.Domain.Book GetByBookId(TransactionManager transactionManager, System.Int64 _bookId, int start, int pageLength)
		{
			int count = -1;
			return GetByBookId(transactionManager, _bookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QUYENSACH index.
		/// </summary>
		/// <param name="_bookId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public LibraryManagement.Domain.Book GetByBookId(System.Int64 _bookId, int start, int pageLength, out int count)
		{
			return GetByBookId(null, _bookId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_QUYENSACH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_bookId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Book"/> class.</returns>
		public abstract LibraryManagement.Domain.Book GetByBookId(TransactionManager transactionManager, System.Int64 _bookId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Book&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Book&gt;"/></returns>
		public static TList<Book> Fill(IDataReader reader, TList<Book> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Book c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Book")
					.Append("|").Append((System.Int64)reader[((int)BookColumn.BookId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Book>(
					key.ToString(), // EntityTrackingKey
					"Book",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Book();
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
					c.BookId = (System.Int64)reader[((int)BookColumn.BookId - 1)];
					c.BookCode = (reader.IsDBNull(((int)BookColumn.BookCode - 1)))?null:(System.String)reader[((int)BookColumn.BookCode - 1)];
					c.BookName = (reader.IsDBNull(((int)BookColumn.BookName - 1)))?null:(System.String)reader[((int)BookColumn.BookName - 1)];
					c.Author = (reader.IsDBNull(((int)BookColumn.Author - 1)))?null:(System.String)reader[((int)BookColumn.Author - 1)];
					c.PublisherId = (reader.IsDBNull(((int)BookColumn.PublisherId - 1)))?null:(System.String)reader[((int)BookColumn.PublisherId - 1)];
					c.BookCategoryId = (reader.IsDBNull(((int)BookColumn.BookCategoryId - 1)))?null:(System.String)reader[((int)BookColumn.BookCategoryId - 1)];
					c.YearPublisher = (reader.IsDBNull(((int)BookColumn.YearPublisher - 1)))?null:(System.String)reader[((int)BookColumn.YearPublisher - 1)];
					c.Quantity = (reader.IsDBNull(((int)BookColumn.Quantity - 1)))?null:(System.Int32?)reader[((int)BookColumn.Quantity - 1)];
					c.Description = (reader.IsDBNull(((int)BookColumn.Description - 1)))?null:(System.String)reader[((int)BookColumn.Description - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Book"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Book"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Book entity)
		{
			if (!reader.Read()) return;
			
			entity.BookId = (System.Int64)reader[((int)BookColumn.BookId - 1)];
			entity.BookCode = (reader.IsDBNull(((int)BookColumn.BookCode - 1)))?null:(System.String)reader[((int)BookColumn.BookCode - 1)];
			entity.BookName = (reader.IsDBNull(((int)BookColumn.BookName - 1)))?null:(System.String)reader[((int)BookColumn.BookName - 1)];
			entity.Author = (reader.IsDBNull(((int)BookColumn.Author - 1)))?null:(System.String)reader[((int)BookColumn.Author - 1)];
			entity.PublisherId = (reader.IsDBNull(((int)BookColumn.PublisherId - 1)))?null:(System.String)reader[((int)BookColumn.PublisherId - 1)];
			entity.BookCategoryId = (reader.IsDBNull(((int)BookColumn.BookCategoryId - 1)))?null:(System.String)reader[((int)BookColumn.BookCategoryId - 1)];
			entity.YearPublisher = (reader.IsDBNull(((int)BookColumn.YearPublisher - 1)))?null:(System.String)reader[((int)BookColumn.YearPublisher - 1)];
			entity.Quantity = (reader.IsDBNull(((int)BookColumn.Quantity - 1)))?null:(System.Int32?)reader[((int)BookColumn.Quantity - 1)];
			entity.Description = (reader.IsDBNull(((int)BookColumn.Description - 1)))?null:(System.String)reader[((int)BookColumn.Description - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Book"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Book"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Book entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.BookId = (System.Int64)dataRow["BookId"];
			entity.BookCode = Convert.IsDBNull(dataRow["BookCode"]) ? null : (System.String)dataRow["BookCode"];
			entity.BookName = Convert.IsDBNull(dataRow["BookName"]) ? null : (System.String)dataRow["BookName"];
			entity.Author = Convert.IsDBNull(dataRow["Author"]) ? null : (System.String)dataRow["Author"];
			entity.PublisherId = Convert.IsDBNull(dataRow["PublisherId"]) ? null : (System.String)dataRow["PublisherId"];
			entity.BookCategoryId = Convert.IsDBNull(dataRow["BookCategoryId"]) ? null : (System.String)dataRow["BookCategoryId"];
			entity.YearPublisher = Convert.IsDBNull(dataRow["YearPublisher"]) ? null : (System.String)dataRow["YearPublisher"];
			entity.Quantity = Convert.IsDBNull(dataRow["Quantity"]) ? null : (System.Int32?)dataRow["Quantity"];
			entity.Description = Convert.IsDBNull(dataRow["Description"]) ? null : (System.String)dataRow["Description"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Book"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Book Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Book entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Book object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Book instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Book Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Book entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region BookChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Book</c>
	///</summary>
	public enum BookChildEntityTypes
	{
	}
	
	#endregion BookChildEntityTypes
	
	#region BookFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;BookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Book"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookFilterBuilder : SqlFilterBuilder<BookColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookFilterBuilder class.
		/// </summary>
		public BookFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookFilterBuilder
	
	#region BookParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;BookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Book"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookParameterBuilder : ParameterizedSqlFilterBuilder<BookColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookParameterBuilder class.
		/// </summary>
		public BookParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookParameterBuilder
	
	#region BookSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;BookColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Book"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class BookSortBuilder : SqlSortBuilder<BookColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookSqlSortBuilder class.
		/// </summary>
		public BookSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion BookSortBuilder
	
} // end namespace
