﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblDate' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDate 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblDate"</remarks>
		System.Int32 Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalId { get; set; }
			
		
		
		/// <summary>
		/// org_date : 
		/// </summary>
		System.DateTime?  OrgDate  { get; set; }
		
		/// <summary>
		/// Complete : 
		/// </summary>
		System.String  Complete  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


