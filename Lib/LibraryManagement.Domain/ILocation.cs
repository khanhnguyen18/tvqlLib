﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblLocation' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ILocation 
	{
		/// <summary>			
		/// stk_id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblLocation"</remarks>
		System.String StkId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalStkId { get; set; }
			
		/// <summary>			
		/// loc_id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblLocation"</remarks>
		System.String LocId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalLocId { get; set; }
			
		
		
		/// <summary>
		/// description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// status : 
		/// </summary>
		System.Boolean  Status  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


