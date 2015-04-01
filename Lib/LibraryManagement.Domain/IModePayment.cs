﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblModePayment' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IModePayment 
	{
		/// <summary>			
		/// pmt_mode : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblModePayment"</remarks>
		System.String PmtMode { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalPmtMode { get; set; }
			
		/// <summary>			
		/// forex : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblModePayment"</remarks>
		System.String Forex { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalForex { get; set; }
			
		
		
		/// <summary>
		/// description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// forex_rate : 
		/// </summary>
		System.Decimal?  ForexRate  { get; set; }
		
		/// <summary>
		/// iscard : 
		/// </summary>
		System.String  Iscard  { get; set; }
		
		/// <summary>
		/// status : 
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

