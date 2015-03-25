
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
	/// An component type implementation of the 'tblTrcode' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class TrcodeService : LibraryManagement.Service.TrcodeServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the TrcodeService class.
		/// </summary>
		public TrcodeService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
