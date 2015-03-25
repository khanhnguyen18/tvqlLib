﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblStockInfo' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IStockInfo 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblStockInfo"</remarks>
		System.String Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalId { get; set; }
			
		/// <summary>			
		/// goods_id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblStockInfo"</remarks>
		System.String GoodsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalGoodsId { get; set; }
			
		
		
		/// <summary>
		/// open_date : 
		/// </summary>
		System.DateTime?  OpenDate  { get; set; }
		
		/// <summary>
		/// last_date : 
		/// </summary>
		System.DateTime?  LastDate  { get; set; }
		
		/// <summary>
		/// minus_date : 
		/// </summary>
		System.DateTime?  MinusDate  { get; set; }
		
		/// <summary>
		/// stktake_dt : 
		/// </summary>
		System.DateTime?  StktakeDt  { get; set; }
		
		/// <summary>
		/// stktake_tm : 
		/// </summary>
		System.String  StktakeTm  { get; set; }
		
		/// <summary>
		/// begin_qty : 
		/// </summary>
		System.Decimal?  BeginQty  { get; set; }
		
		/// <summary>
		/// exp_qty : 
		/// </summary>
		System.Decimal?  ExpQty  { get; set; }
		
		/// <summary>
		/// imp_qty : 
		/// </summary>
		System.Decimal?  ImpQty  { get; set; }
		
		/// <summary>
		/// begin_amt : 
		/// </summary>
		System.Decimal?  BeginAmt  { get; set; }
		
		/// <summary>
		/// exp_amt : 
		/// </summary>
		System.Decimal?  ExpAmt  { get; set; }
		
		/// <summary>
		/// imp_amt : 
		/// </summary>
		System.Decimal?  ImpAmt  { get; set; }
		
		/// <summary>
		/// averimppr : 
		/// </summary>
		System.Decimal?  Averimppr  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


