﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblTransaction' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITransaction 
	{
		/// <summary>			
		/// idx : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblTransaction"</remarks>
		System.Decimal Idx { get; set; }
				
		
		
		/// <summary>
		/// tran_date : 
		/// </summary>
		System.DateTime?  TranDate  { get; set; }
		
		/// <summary>
		/// tran_time : 
		/// </summary>
		System.String  TranTime  { get; set; }
		
		/// <summary>
		/// trans_num : 
		/// </summary>
		System.String  TransNum  { get; set; }
		
		/// <summary>
		/// trans_code : 
		/// </summary>
		System.String  TransCode  { get; set; }
		
		/// <summary>
		/// voucher : 
		/// </summary>
		System.String  Voucher  { get; set; }
		
		/// <summary>
		/// invoice : 
		/// </summary>
		System.String  Invoice  { get; set; }
		
		/// <summary>
		/// post : 
		/// </summary>
		System.Boolean?  Post  { get; set; }
		
		/// <summary>
		/// exp_id : 
		/// </summary>
		System.String  ExpId  { get; set; }
		
		/// <summary>
		/// imp_id : 
		/// </summary>
		System.String  ImpId  { get; set; }
		
		/// <summary>
		/// goods_id : 
		/// </summary>
		System.String  GoodsId  { get; set; }
		
		/// <summary>
		/// kit_qty : 
		/// </summary>
		System.Decimal?  KitQty  { get; set; }
		
		/// <summary>
		/// kit_id : 
		/// </summary>
		System.String  KitId  { get; set; }
		
		/// <summary>
		/// qty : 
		/// </summary>
		System.Decimal?  Qty  { get; set; }
		
		/// <summary>
		/// unit_symb : 
		/// </summary>
		System.String  UnitSymb  { get; set; }
		
		/// <summary>
		/// amount : 
		/// </summary>
		System.Decimal  Amount  { get; set; }
		
		/// <summary>
		/// discount : 
		/// </summary>
		System.Decimal  Discount  { get; set; }
		
		/// <summary>
		/// carddisc_amt : 
		/// </summary>
		System.Decimal?  CarddiscAmt  { get; set; }
		
		/// <summary>
		/// vat_amt : 
		/// </summary>
		System.Decimal  VatAmt  { get; set; }
		
		/// <summary>
		/// surplus : 
		/// </summary>
		System.Decimal  Surplus  { get; set; }
		
		/// <summary>
		/// commis_amt : 
		/// </summary>
		System.Decimal?  CommisAmt  { get; set; }
		
		/// <summary>
		/// forex_cys : 
		/// </summary>
		System.String  ForexCys  { get; set; }
		
		/// <summary>
		/// forex_rate : 
		/// </summary>
		System.Decimal?  ForexRate  { get; set; }
		
		/// <summary>
		/// expiry_dt : 
		/// </summary>
		System.DateTime?  ExpiryDt  { get; set; }
		
		/// <summary>
		/// user_id : 
		/// </summary>
		System.Decimal?  UserId  { get; set; }
		
		/// <summary>
		/// station : 
		/// </summary>
		System.Int32?  Station  { get; set; }
		
		/// <summary>
		/// cs_id : 
		/// </summary>
		System.String  CsId  { get; set; }
		
		/// <summary>
		/// custax_id : 
		/// </summary>
		System.String  CustaxId  { get; set; }
		
		/// <summary>
		/// ref : 
		/// </summary>
		System.String  SafeNameRef  { get; set; }
		
		/// <summary>
		/// remark : 
		/// </summary>
		System.String  Remark  { get; set; }
		
		/// <summary>
		/// updated : 
		/// </summary>
		System.Boolean?  Updated  { get; set; }
		
		/// <summary>
		/// merc_type : 
		/// </summary>
		System.String  MercType  { get; set; }
		
		/// <summary>
		/// tax_code : 
		/// </summary>
		System.String  TaxCode  { get; set; }
		
		/// <summary>
		/// vat_incl : 
		/// </summary>
		System.Boolean?  VatIncl  { get; set; }
		
		/// <summary>
		/// discpervat : 
		/// </summary>
		System.Boolean?  Discpervat  { get; set; }
		
		/// <summary>
		/// disc_incl : 
		/// </summary>
		System.Boolean?  DiscIncl  { get; set; }
		
		/// <summary>
		/// copies : 
		/// </summary>
		System.Decimal?  Copies  { get; set; }
		
		/// <summary>
		/// recnum : 
		/// </summary>
		System.Decimal?  Recnum  { get; set; }
		
		/// <summary>
		/// card_id : 
		/// </summary>
		System.String  CardId  { get; set; }
		
		/// <summary>
		/// Shift : 
		/// </summary>
		System.Int32?  Shift  { get; set; }
		
		/// <summary>
		/// Status : 
		/// </summary>
		System.Boolean?  Status  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

