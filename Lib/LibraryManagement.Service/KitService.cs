
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
	/// An component type implementation of the 'tblKit' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class KitService : LibraryManagement.Service.KitServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the KitService class.
		/// </summary>
		public KitService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
