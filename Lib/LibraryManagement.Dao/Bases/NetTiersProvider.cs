#region Using directives

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using LibraryManagement.Domain;

#endregion

namespace LibraryManagement.Dao.Bases
{	
	///<summary>
	/// The base class to implements to create a .NetTiers provider.
	///</summary>
	public abstract class NetTiersProvider : NetTiersProviderBase
	{
		
		///<summary>
		/// Current BookProviderBase instance.
		///</summary>
		public virtual BookProviderBase BookProvider{get {throw new NotImplementedException();}}
		
		
	}
}
