﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblUserGrp' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IUserGrp 
	{
		/// <summary>			
		/// ID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblUserGrp"</remarks>
		System.String Id { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.String OriginalId { get; set; }
			
		
		
		/// <summary>
		/// Name : 
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// Descript : 
		/// </summary>
		System.String  Descript  { get; set; }
		
		/// <summary>
		/// MenuPer : 
		/// </summary>
		System.String  MenuPer  { get; set; }
		
		/// <summary>
		/// rpright : 
		/// </summary>
		System.String  Rpright  { get; set; }
		
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

