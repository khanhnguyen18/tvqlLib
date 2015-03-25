#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using LibraryManagement.Domain;
using LibraryManagement.Dao;

#endregion

namespace LibraryManagement.Dao.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="StockInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class StockInfoProviderBase : StockInfoProviderBaseCore
	{
	} // end class
} // end namespace
