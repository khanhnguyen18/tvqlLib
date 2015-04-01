﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblPrice' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IPrice 
	{
		/// <summary>			
		/// goods_id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblPrice"</remarks>
		System.String GoodsId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalGoodsId { get; set; }
			
		
		
		/// <summary>
		/// rtprice : 
		/// </summary>
		System.Decimal?  Rtprice  { get; set; }
		
		/// <summary>
		/// averimppr : 
		/// </summary>
		System.Decimal?  Averimppr  { get; set; }
		
		/// <summary>
		/// lastimppr : 
		/// </summary>
		System.Decimal?  Lastimppr  { get; set; }
		
		/// <summary>
		/// wsprice : 
		/// </summary>
		System.Decimal?  Wsprice  { get; set; }
		
		/// <summary>
		/// prefprice : 
		/// </summary>
		System.Decimal?  Prefprice  { get; set; }
		
		/// <summary>
		/// discpercent : 
		/// </summary>
		System.Decimal?  Discpercent  { get; set; }
		
		/// <summary>
		/// disc_frdate : 
		/// </summary>
		System.DateTime?  DiscFrdate  { get; set; }
		
		/// <summary>
		/// disc_todate : 
		/// </summary>
		System.DateTime?  DiscTodate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

