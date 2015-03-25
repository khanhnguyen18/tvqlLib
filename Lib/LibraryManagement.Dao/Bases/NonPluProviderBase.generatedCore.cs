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
	/// This class is the base class for any <see cref="NonPluProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class NonPluProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.NonPlu, LibraryManagement.Domain.NonPluKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.NonPluKey key)
		{
			return Delete(transactionManager, key.NpluCode, key.GoodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_npluCode">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _npluCode, System.String _goodsId)
		{
			return Delete(null, _npluCode, _goodsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_npluCode">. Primary Key.</param>
		/// <param name="_goodsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _npluCode, System.String _goodsId);		
		
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
		public override LibraryManagement.Domain.NonPlu Get(TransactionManager transactionManager, LibraryManagement.Domain.NonPluKey key, int start, int pageLength)
		{
			return GetByNpluCodeGoodsId(transactionManager, key.NpluCode, key.GoodsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblNon_Plu index.
		/// </summary>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(System.String _npluCode, System.String _goodsId)
		{
			int count = -1;
			return GetByNpluCodeGoodsId(null,_npluCode, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblNon_Plu index.
		/// </summary>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(System.String _npluCode, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByNpluCodeGoodsId(null, _npluCode, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblNon_Plu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(TransactionManager transactionManager, System.String _npluCode, System.String _goodsId)
		{
			int count = -1;
			return GetByNpluCodeGoodsId(transactionManager, _npluCode, _goodsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblNon_Plu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(TransactionManager transactionManager, System.String _npluCode, System.String _goodsId, int start, int pageLength)
		{
			int count = -1;
			return GetByNpluCodeGoodsId(transactionManager, _npluCode, _goodsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblNon_Plu index.
		/// </summary>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(System.String _npluCode, System.String _goodsId, int start, int pageLength, out int count)
		{
			return GetByNpluCodeGoodsId(null, _npluCode, _goodsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblNon_Plu index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_npluCode"></param>
		/// <param name="_goodsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.NonPlu"/> class.</returns>
		public abstract LibraryManagement.Domain.NonPlu GetByNpluCodeGoodsId(TransactionManager transactionManager, System.String _npluCode, System.String _goodsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;NonPlu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;NonPlu&gt;"/></returns>
		public static TList<NonPlu> Fill(IDataReader reader, TList<NonPlu> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.NonPlu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("NonPlu")
					.Append("|").Append((System.String)reader[((int)NonPluColumn.NpluCode - 1)])
					.Append("|").Append((System.String)reader[((int)NonPluColumn.GoodsId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<NonPlu>(
					key.ToString(), // EntityTrackingKey
					"NonPlu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.NonPlu();
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
					c.NpluCode = (System.String)reader[((int)NonPluColumn.NpluCode - 1)];
					c.OriginalNpluCode = c.NpluCode;
					c.GoodsId = (System.String)reader[((int)NonPluColumn.GoodsId - 1)];
					c.OriginalGoodsId = c.GoodsId;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.NonPlu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.NonPlu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.NonPlu entity)
		{
			if (!reader.Read()) return;
			
			entity.NpluCode = (System.String)reader[((int)NonPluColumn.NpluCode - 1)];
			entity.OriginalNpluCode = (System.String)reader["nplu_code"];
			entity.GoodsId = (System.String)reader[((int)NonPluColumn.GoodsId - 1)];
			entity.OriginalGoodsId = (System.String)reader["goods_id"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.NonPlu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.NonPlu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.NonPlu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.NpluCode = (System.String)dataRow["nplu_code"];
			entity.OriginalNpluCode = (System.String)dataRow["nplu_code"];
			entity.GoodsId = (System.String)dataRow["goods_id"];
			entity.OriginalGoodsId = (System.String)dataRow["goods_id"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.NonPlu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.NonPlu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.NonPlu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.NonPlu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.NonPlu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.NonPlu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.NonPlu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region NonPluChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.NonPlu</c>
	///</summary>
	public enum NonPluChildEntityTypes
	{
	}
	
	#endregion NonPluChildEntityTypes
	
	#region NonPluFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;NonPluColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NonPlu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NonPluFilterBuilder : SqlFilterBuilder<NonPluColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NonPluFilterBuilder class.
		/// </summary>
		public NonPluFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NonPluFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NonPluFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NonPluFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NonPluFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NonPluFilterBuilder
	
	#region NonPluParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;NonPluColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NonPlu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NonPluParameterBuilder : ParameterizedSqlFilterBuilder<NonPluColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NonPluParameterBuilder class.
		/// </summary>
		public NonPluParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the NonPluParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NonPluParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NonPluParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NonPluParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NonPluParameterBuilder
	
	#region NonPluSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;NonPluColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NonPlu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class NonPluSortBuilder : SqlSortBuilder<NonPluColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NonPluSqlSortBuilder class.
		/// </summary>
		public NonPluSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion NonPluSortBuilder
	
} // end namespace
