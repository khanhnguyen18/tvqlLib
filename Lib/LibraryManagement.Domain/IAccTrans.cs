﻿using System;
using System.ComponentModel;

namespace LibraryManagement.Domain
{
	/// <summary>
	///		The data structure representation of the 'tblAccTrans' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IAccTrans 
	{
		/// <summary>			
		/// id : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblAccTrans"</remarks>
		System.Decimal Id { get; set; }
				
		
		
		/// <summary>
		/// tran_date : 
		/// </summary>
		System.DateTime  TranDate  { get; set; }
		
		/// <summary>
		/// tran_time : 
		/// </summary>
		System.String  TranTime  { get; set; }
		
		/// <summary>
		/// ef_date : 
		/// </summary>
		System.DateTime?  EfDate  { get; set; }
		
		/// <summary>
		/// trans_num : 
		/// </summary>
		System.String  TransNum  { get; set; }
		
		/// <summary>
		/// voucher : 
		/// </summary>
		System.String  Voucher  { get; set; }
		
		/// <summary>
		/// trans_code : 
		/// </summary>
		System.String  TransCode  { get; set; }
		
		/// <summary>
		/// account_id : 
		/// </summary>
		System.String  AccountId  { get; set; }
		
		/// <summary>
		/// db_amount : 
		/// </summary>
		System.Decimal  DbAmount  { get; set; }
		
		/// <summary>
		/// cr_amount : 
		/// </summary>
		System.Decimal  CrAmount  { get; set; }
		
		/// <summary>
		/// user_id : 
		/// </summary>
		System.Decimal  UserId  { get; set; }
		
		/// <summary>
		/// corr_acc : 
		/// </summary>
		System.String  CorrAcc  { get; set; }
		
		/// <summary>
		/// remark : 
		/// </summary>
		System.String  Remark  { get; set; }
		
		/// <summary>
		/// name : 
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// address : 
		/// </summary>
		System.String  Address  { get; set; }
		
		/// <summary>
		/// person_id : 
		/// </summary>
		System.String  PersonId  { get; set; }
		
		/// <summary>
		/// updated : 
		/// </summary>
		System.Boolean  Updated  { get; set; }
		
		/// <summary>
		/// recnum : 
		/// </summary>
		System.Decimal?  Recnum  { get; set; }
		
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


