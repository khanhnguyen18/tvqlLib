
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using LibraryManagement.Domain;
using LibraryManagement.Domain.Validation;

using LibraryManagement.Dao;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace LibraryManagement.Service
{		
	/// <summary>
	/// An component type implementation of the 'tblStockInfo' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class StockInfoService : LibraryManagement.Service.StockInfoServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the StockInfoService class.
		/// </summary>
		public StockInfoService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
