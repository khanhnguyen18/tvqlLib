﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblUtils' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IUtils 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblUtils"</remarks>
		System.Byte Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Byte OriginalId { get; set; }
			
		
		
		/// <summary>
		/// name : 
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// Description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// subname : 
		/// </summary>
		System.String  Subname  { get; set; }
		
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


