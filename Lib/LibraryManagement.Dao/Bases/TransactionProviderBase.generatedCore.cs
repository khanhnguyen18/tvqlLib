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
	/// This class is the base class for any <see cref="TransactionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TransactionProviderBaseCore : EntityProviderBase<LibraryManagement.Domain.Transaction, LibraryManagement.Domain.TransactionKey>
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
		public override bool Delete(TransactionManager transactionManager, LibraryManagement.Domain.TransactionKey key)
		{
			return Delete(transactionManager, key.Idx);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_idx">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _idx)
		{
			return Delete(null, _idx);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _idx);		
		
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
		public override LibraryManagement.Domain.Transaction Get(TransactionManager transactionManager, LibraryManagement.Domain.TransactionKey key, int start, int pageLength)
		{
			return GetByIdx(transactionManager, key.Idx, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_tblTransaction_new index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public LibraryManagement.Domain.Transaction GetByIdx(System.Decimal _idx)
		{
			int count = -1;
			return GetByIdx(null,_idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransaction_new index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public LibraryManagement.Domain.Transaction GetByIdx(System.Decimal _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransaction_new index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public LibraryManagement.Domain.Transaction GetByIdx(TransactionManager transactionManager, System.Decimal _idx)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransaction_new index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public LibraryManagement.Domain.Transaction GetByIdx(TransactionManager transactionManager, System.Decimal _idx, int start, int pageLength)
		{
			int count = -1;
			return GetByIdx(transactionManager, _idx, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransaction_new index.
		/// </summary>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public LibraryManagement.Domain.Transaction GetByIdx(System.Decimal _idx, int start, int pageLength, out int count)
		{
			return GetByIdx(null, _idx, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_tblTransaction_new index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_idx"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="LibraryManagement.Domain.Transaction"/> class.</returns>
		public abstract LibraryManagement.Domain.Transaction GetByIdx(TransactionManager transactionManager, System.Decimal _idx, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;Transaction&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;Transaction&gt;"/></returns>
		public static TList<Transaction> Fill(IDataReader reader, TList<Transaction> rows, int start, int pageLength)
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
				
				LibraryManagement.Domain.Transaction c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("Transaction")
					.Append("|").Append((System.Decimal)reader[((int)TransactionColumn.Idx - 1)]).ToString();
					c = EntityManager.LocateOrCreate<Transaction>(
					key.ToString(), // EntityTrackingKey
					"Transaction",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new LibraryManagement.Domain.Transaction();
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
					c.Idx = (System.Decimal)reader[((int)TransactionColumn.Idx - 1)];
					c.TranDate = (reader.IsDBNull(((int)TransactionColumn.TranDate - 1)))?null:(System.DateTime?)reader[((int)TransactionColumn.TranDate - 1)];
					c.TranTime = (reader.IsDBNull(((int)TransactionColumn.TranTime - 1)))?null:(System.String)reader[((int)TransactionColumn.TranTime - 1)];
					c.TransNum = (reader.IsDBNull(((int)TransactionColumn.TransNum - 1)))?null:(System.String)reader[((int)TransactionColumn.TransNum - 1)];
					c.TransCode = (reader.IsDBNull(((int)TransactionColumn.TransCode - 1)))?null:(System.String)reader[((int)TransactionColumn.TransCode - 1)];
					c.Voucher = (reader.IsDBNull(((int)TransactionColumn.Voucher - 1)))?null:(System.String)reader[((int)TransactionColumn.Voucher - 1)];
					c.Invoice = (reader.IsDBNull(((int)TransactionColumn.Invoice - 1)))?null:(System.String)reader[((int)TransactionColumn.Invoice - 1)];
					c.Post = (reader.IsDBNull(((int)TransactionColumn.Post - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Post - 1)];
					c.ExpId = (reader.IsDBNull(((int)TransactionColumn.ExpId - 1)))?null:(System.String)reader[((int)TransactionColumn.ExpId - 1)];
					c.ImpId = (reader.IsDBNull(((int)TransactionColumn.ImpId - 1)))?null:(System.String)reader[((int)TransactionColumn.ImpId - 1)];
					c.GoodsId = (reader.IsDBNull(((int)TransactionColumn.GoodsId - 1)))?null:(System.String)reader[((int)TransactionColumn.GoodsId - 1)];
					c.KitQty = (reader.IsDBNull(((int)TransactionColumn.KitQty - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.KitQty - 1)];
					c.KitId = (reader.IsDBNull(((int)TransactionColumn.KitId - 1)))?null:(System.String)reader[((int)TransactionColumn.KitId - 1)];
					c.Qty = (reader.IsDBNull(((int)TransactionColumn.Qty - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Qty - 1)];
					c.UnitSymb = (reader.IsDBNull(((int)TransactionColumn.UnitSymb - 1)))?null:(System.String)reader[((int)TransactionColumn.UnitSymb - 1)];
					c.Amount = (System.Decimal)reader[((int)TransactionColumn.Amount - 1)];
					c.Discount = (System.Decimal)reader[((int)TransactionColumn.Discount - 1)];
					c.CarddiscAmt = (reader.IsDBNull(((int)TransactionColumn.CarddiscAmt - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.CarddiscAmt - 1)];
					c.VatAmt = (System.Decimal)reader[((int)TransactionColumn.VatAmt - 1)];
					c.Surplus = (System.Decimal)reader[((int)TransactionColumn.Surplus - 1)];
					c.CommisAmt = (reader.IsDBNull(((int)TransactionColumn.CommisAmt - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.CommisAmt - 1)];
					c.ForexCys = (reader.IsDBNull(((int)TransactionColumn.ForexCys - 1)))?null:(System.String)reader[((int)TransactionColumn.ForexCys - 1)];
					c.ForexRate = (reader.IsDBNull(((int)TransactionColumn.ForexRate - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.ForexRate - 1)];
					c.ExpiryDt = (reader.IsDBNull(((int)TransactionColumn.ExpiryDt - 1)))?null:(System.DateTime?)reader[((int)TransactionColumn.ExpiryDt - 1)];
					c.UserId = (reader.IsDBNull(((int)TransactionColumn.UserId - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.UserId - 1)];
					c.Station = (reader.IsDBNull(((int)TransactionColumn.Station - 1)))?null:(System.Int32?)reader[((int)TransactionColumn.Station - 1)];
					c.CsId = (reader.IsDBNull(((int)TransactionColumn.CsId - 1)))?null:(System.String)reader[((int)TransactionColumn.CsId - 1)];
					c.CustaxId = (reader.IsDBNull(((int)TransactionColumn.CustaxId - 1)))?null:(System.String)reader[((int)TransactionColumn.CustaxId - 1)];
					c.SafeNameRef = (reader.IsDBNull(((int)TransactionColumn.SafeNameRef - 1)))?null:(System.String)reader[((int)TransactionColumn.SafeNameRef - 1)];
					c.Remark = (reader.IsDBNull(((int)TransactionColumn.Remark - 1)))?null:(System.String)reader[((int)TransactionColumn.Remark - 1)];
					c.Updated = (reader.IsDBNull(((int)TransactionColumn.Updated - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Updated - 1)];
					c.MercType = (reader.IsDBNull(((int)TransactionColumn.MercType - 1)))?null:(System.String)reader[((int)TransactionColumn.MercType - 1)];
					c.TaxCode = (reader.IsDBNull(((int)TransactionColumn.TaxCode - 1)))?null:(System.String)reader[((int)TransactionColumn.TaxCode - 1)];
					c.VatIncl = (reader.IsDBNull(((int)TransactionColumn.VatIncl - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.VatIncl - 1)];
					c.Discpervat = (reader.IsDBNull(((int)TransactionColumn.Discpervat - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Discpervat - 1)];
					c.DiscIncl = (reader.IsDBNull(((int)TransactionColumn.DiscIncl - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.DiscIncl - 1)];
					c.Copies = (reader.IsDBNull(((int)TransactionColumn.Copies - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Copies - 1)];
					c.Recnum = (reader.IsDBNull(((int)TransactionColumn.Recnum - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Recnum - 1)];
					c.CardId = (reader.IsDBNull(((int)TransactionColumn.CardId - 1)))?null:(System.String)reader[((int)TransactionColumn.CardId - 1)];
					c.Shift = (reader.IsDBNull(((int)TransactionColumn.Shift - 1)))?null:(System.Int32?)reader[((int)TransactionColumn.Shift - 1)];
					c.Status = (reader.IsDBNull(((int)TransactionColumn.Status - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Status - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Transaction"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Transaction"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, LibraryManagement.Domain.Transaction entity)
		{
			if (!reader.Read()) return;
			
			entity.Idx = (System.Decimal)reader[((int)TransactionColumn.Idx - 1)];
			entity.TranDate = (reader.IsDBNull(((int)TransactionColumn.TranDate - 1)))?null:(System.DateTime?)reader[((int)TransactionColumn.TranDate - 1)];
			entity.TranTime = (reader.IsDBNull(((int)TransactionColumn.TranTime - 1)))?null:(System.String)reader[((int)TransactionColumn.TranTime - 1)];
			entity.TransNum = (reader.IsDBNull(((int)TransactionColumn.TransNum - 1)))?null:(System.String)reader[((int)TransactionColumn.TransNum - 1)];
			entity.TransCode = (reader.IsDBNull(((int)TransactionColumn.TransCode - 1)))?null:(System.String)reader[((int)TransactionColumn.TransCode - 1)];
			entity.Voucher = (reader.IsDBNull(((int)TransactionColumn.Voucher - 1)))?null:(System.String)reader[((int)TransactionColumn.Voucher - 1)];
			entity.Invoice = (reader.IsDBNull(((int)TransactionColumn.Invoice - 1)))?null:(System.String)reader[((int)TransactionColumn.Invoice - 1)];
			entity.Post = (reader.IsDBNull(((int)TransactionColumn.Post - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Post - 1)];
			entity.ExpId = (reader.IsDBNull(((int)TransactionColumn.ExpId - 1)))?null:(System.String)reader[((int)TransactionColumn.ExpId - 1)];
			entity.ImpId = (reader.IsDBNull(((int)TransactionColumn.ImpId - 1)))?null:(System.String)reader[((int)TransactionColumn.ImpId - 1)];
			entity.GoodsId = (reader.IsDBNull(((int)TransactionColumn.GoodsId - 1)))?null:(System.String)reader[((int)TransactionColumn.GoodsId - 1)];
			entity.KitQty = (reader.IsDBNull(((int)TransactionColumn.KitQty - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.KitQty - 1)];
			entity.KitId = (reader.IsDBNull(((int)TransactionColumn.KitId - 1)))?null:(System.String)reader[((int)TransactionColumn.KitId - 1)];
			entity.Qty = (reader.IsDBNull(((int)TransactionColumn.Qty - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Qty - 1)];
			entity.UnitSymb = (reader.IsDBNull(((int)TransactionColumn.UnitSymb - 1)))?null:(System.String)reader[((int)TransactionColumn.UnitSymb - 1)];
			entity.Amount = (System.Decimal)reader[((int)TransactionColumn.Amount - 1)];
			entity.Discount = (System.Decimal)reader[((int)TransactionColumn.Discount - 1)];
			entity.CarddiscAmt = (reader.IsDBNull(((int)TransactionColumn.CarddiscAmt - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.CarddiscAmt - 1)];
			entity.VatAmt = (System.Decimal)reader[((int)TransactionColumn.VatAmt - 1)];
			entity.Surplus = (System.Decimal)reader[((int)TransactionColumn.Surplus - 1)];
			entity.CommisAmt = (reader.IsDBNull(((int)TransactionColumn.CommisAmt - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.CommisAmt - 1)];
			entity.ForexCys = (reader.IsDBNull(((int)TransactionColumn.ForexCys - 1)))?null:(System.String)reader[((int)TransactionColumn.ForexCys - 1)];
			entity.ForexRate = (reader.IsDBNull(((int)TransactionColumn.ForexRate - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.ForexRate - 1)];
			entity.ExpiryDt = (reader.IsDBNull(((int)TransactionColumn.ExpiryDt - 1)))?null:(System.DateTime?)reader[((int)TransactionColumn.ExpiryDt - 1)];
			entity.UserId = (reader.IsDBNull(((int)TransactionColumn.UserId - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.UserId - 1)];
			entity.Station = (reader.IsDBNull(((int)TransactionColumn.Station - 1)))?null:(System.Int32?)reader[((int)TransactionColumn.Station - 1)];
			entity.CsId = (reader.IsDBNull(((int)TransactionColumn.CsId - 1)))?null:(System.String)reader[((int)TransactionColumn.CsId - 1)];
			entity.CustaxId = (reader.IsDBNull(((int)TransactionColumn.CustaxId - 1)))?null:(System.String)reader[((int)TransactionColumn.CustaxId - 1)];
			entity.SafeNameRef = (reader.IsDBNull(((int)TransactionColumn.SafeNameRef - 1)))?null:(System.String)reader[((int)TransactionColumn.SafeNameRef - 1)];
			entity.Remark = (reader.IsDBNull(((int)TransactionColumn.Remark - 1)))?null:(System.String)reader[((int)TransactionColumn.Remark - 1)];
			entity.Updated = (reader.IsDBNull(((int)TransactionColumn.Updated - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Updated - 1)];
			entity.MercType = (reader.IsDBNull(((int)TransactionColumn.MercType - 1)))?null:(System.String)reader[((int)TransactionColumn.MercType - 1)];
			entity.TaxCode = (reader.IsDBNull(((int)TransactionColumn.TaxCode - 1)))?null:(System.String)reader[((int)TransactionColumn.TaxCode - 1)];
			entity.VatIncl = (reader.IsDBNull(((int)TransactionColumn.VatIncl - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.VatIncl - 1)];
			entity.Discpervat = (reader.IsDBNull(((int)TransactionColumn.Discpervat - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Discpervat - 1)];
			entity.DiscIncl = (reader.IsDBNull(((int)TransactionColumn.DiscIncl - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.DiscIncl - 1)];
			entity.Copies = (reader.IsDBNull(((int)TransactionColumn.Copies - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Copies - 1)];
			entity.Recnum = (reader.IsDBNull(((int)TransactionColumn.Recnum - 1)))?null:(System.Decimal?)reader[((int)TransactionColumn.Recnum - 1)];
			entity.CardId = (reader.IsDBNull(((int)TransactionColumn.CardId - 1)))?null:(System.String)reader[((int)TransactionColumn.CardId - 1)];
			entity.Shift = (reader.IsDBNull(((int)TransactionColumn.Shift - 1)))?null:(System.Int32?)reader[((int)TransactionColumn.Shift - 1)];
			entity.Status = (reader.IsDBNull(((int)TransactionColumn.Status - 1)))?null:(System.Boolean?)reader[((int)TransactionColumn.Status - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="LibraryManagement.Domain.Transaction"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Transaction"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, LibraryManagement.Domain.Transaction entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Idx = (System.Decimal)dataRow["idx"];
			entity.TranDate = Convert.IsDBNull(dataRow["tran_date"]) ? null : (System.DateTime?)dataRow["tran_date"];
			entity.TranTime = Convert.IsDBNull(dataRow["tran_time"]) ? null : (System.String)dataRow["tran_time"];
			entity.TransNum = Convert.IsDBNull(dataRow["trans_num"]) ? null : (System.String)dataRow["trans_num"];
			entity.TransCode = Convert.IsDBNull(dataRow["trans_code"]) ? null : (System.String)dataRow["trans_code"];
			entity.Voucher = Convert.IsDBNull(dataRow["voucher"]) ? null : (System.String)dataRow["voucher"];
			entity.Invoice = Convert.IsDBNull(dataRow["invoice"]) ? null : (System.String)dataRow["invoice"];
			entity.Post = Convert.IsDBNull(dataRow["post"]) ? null : (System.Boolean?)dataRow["post"];
			entity.ExpId = Convert.IsDBNull(dataRow["exp_id"]) ? null : (System.String)dataRow["exp_id"];
			entity.ImpId = Convert.IsDBNull(dataRow["imp_id"]) ? null : (System.String)dataRow["imp_id"];
			entity.GoodsId = Convert.IsDBNull(dataRow["goods_id"]) ? null : (System.String)dataRow["goods_id"];
			entity.KitQty = Convert.IsDBNull(dataRow["kit_qty"]) ? null : (System.Decimal?)dataRow["kit_qty"];
			entity.KitId = Convert.IsDBNull(dataRow["kit_id"]) ? null : (System.String)dataRow["kit_id"];
			entity.Qty = Convert.IsDBNull(dataRow["qty"]) ? null : (System.Decimal?)dataRow["qty"];
			entity.UnitSymb = Convert.IsDBNull(dataRow["unit_symb"]) ? null : (System.String)dataRow["unit_symb"];
			entity.Amount = (System.Decimal)dataRow["amount"];
			entity.Discount = (System.Decimal)dataRow["discount"];
			entity.CarddiscAmt = Convert.IsDBNull(dataRow["carddisc_amt"]) ? null : (System.Decimal?)dataRow["carddisc_amt"];
			entity.VatAmt = (System.Decimal)dataRow["vat_amt"];
			entity.Surplus = (System.Decimal)dataRow["surplus"];
			entity.CommisAmt = Convert.IsDBNull(dataRow["commis_amt"]) ? null : (System.Decimal?)dataRow["commis_amt"];
			entity.ForexCys = Convert.IsDBNull(dataRow["forex_cys"]) ? null : (System.String)dataRow["forex_cys"];
			entity.ForexRate = Convert.IsDBNull(dataRow["forex_rate"]) ? null : (System.Decimal?)dataRow["forex_rate"];
			entity.ExpiryDt = Convert.IsDBNull(dataRow["expiry_dt"]) ? null : (System.DateTime?)dataRow["expiry_dt"];
			entity.UserId = Convert.IsDBNull(dataRow["user_id"]) ? null : (System.Decimal?)dataRow["user_id"];
			entity.Station = Convert.IsDBNull(dataRow["station"]) ? null : (System.Int32?)dataRow["station"];
			entity.CsId = Convert.IsDBNull(dataRow["cs_id"]) ? null : (System.String)dataRow["cs_id"];
			entity.CustaxId = Convert.IsDBNull(dataRow["custax_id"]) ? null : (System.String)dataRow["custax_id"];
			entity.SafeNameRef = Convert.IsDBNull(dataRow["ref"]) ? null : (System.String)dataRow["ref"];
			entity.Remark = Convert.IsDBNull(dataRow["remark"]) ? null : (System.String)dataRow["remark"];
			entity.Updated = Convert.IsDBNull(dataRow["updated"]) ? null : (System.Boolean?)dataRow["updated"];
			entity.MercType = Convert.IsDBNull(dataRow["merc_type"]) ? null : (System.String)dataRow["merc_type"];
			entity.TaxCode = Convert.IsDBNull(dataRow["tax_code"]) ? null : (System.String)dataRow["tax_code"];
			entity.VatIncl = Convert.IsDBNull(dataRow["vat_incl"]) ? null : (System.Boolean?)dataRow["vat_incl"];
			entity.Discpervat = Convert.IsDBNull(dataRow["discpervat"]) ? null : (System.Boolean?)dataRow["discpervat"];
			entity.DiscIncl = Convert.IsDBNull(dataRow["disc_incl"]) ? null : (System.Boolean?)dataRow["disc_incl"];
			entity.Copies = Convert.IsDBNull(dataRow["copies"]) ? null : (System.Decimal?)dataRow["copies"];
			entity.Recnum = Convert.IsDBNull(dataRow["recnum"]) ? null : (System.Decimal?)dataRow["recnum"];
			entity.CardId = Convert.IsDBNull(dataRow["card_id"]) ? null : (System.String)dataRow["card_id"];
			entity.Shift = Convert.IsDBNull(dataRow["Shift"]) ? null : (System.Int32?)dataRow["Shift"];
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
		/// <param name="entity">The <see cref="LibraryManagement.Domain.Transaction"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Transaction Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, LibraryManagement.Domain.Transaction entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the LibraryManagement.Domain.Transaction object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">LibraryManagement.Domain.Transaction instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">LibraryManagement.Domain.Transaction Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, LibraryManagement.Domain.Transaction entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region TransactionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>LibraryManagement.Domain.Transaction</c>
	///</summary>
	public enum TransactionChildEntityTypes
	{
	}
	
	#endregion TransactionChildEntityTypes
	
	#region TransactionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TransactionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Transaction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransactionFilterBuilder : SqlFilterBuilder<TransactionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionFilterBuilder class.
		/// </summary>
		public TransactionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransactionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransactionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransactionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransactionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransactionFilterBuilder
	
	#region TransactionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TransactionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Transaction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransactionParameterBuilder : ParameterizedSqlFilterBuilder<TransactionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionParameterBuilder class.
		/// </summary>
		public TransactionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransactionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransactionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransactionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransactionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransactionParameterBuilder
	
	#region TransactionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TransactionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Transaction"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TransactionSortBuilder : SqlSortBuilder<TransactionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionSqlSortBuilder class.
		/// </summary>
		public TransactionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TransactionSortBuilder
	
} // end namespace
