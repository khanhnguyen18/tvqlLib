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
		/// Current ReportsProviderBase instance.
		///</summary>
		public virtual ReportsProviderBase ReportsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccountProviderBase instance.
		///</summary>
		public virtual AccountProviderBase AccountProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StaffProviderBase instance.
		///</summary>
		public virtual StaffProviderBase StaffProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PriceProviderBase instance.
		///</summary>
		public virtual PriceProviderBase PriceProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StationsProviderBase instance.
		///</summary>
		public virtual StationsProviderBase StationsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MofSysProviderBase instance.
		///</summary>
		public virtual MofSysProviderBase MofSysProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current PaymentOrderProviderBase instance.
		///</summary>
		public virtual PaymentOrderProviderBase PaymentOrderProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current NonPluProviderBase instance.
		///</summary>
		public virtual NonPluProviderBase NonPluProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StockInfoProviderBase instance.
		///</summary>
		public virtual StockInfoProviderBase StockInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current OnOrderProviderBase instance.
		///</summary>
		public virtual OnOrderProviderBase OnOrderProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UnitProviderBase instance.
		///</summary>
		public virtual UnitProviderBase UnitProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current StoreProviderBase instance.
		///</summary>
		public virtual StoreProviderBase StoreProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UserProviderBase instance.
		///</summary>
		public virtual UserProviderBase UserProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TrcodeProviderBase instance.
		///</summary>
		public virtual TrcodeProviderBase TrcodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UserGrpProviderBase instance.
		///</summary>
		public virtual UserGrpProviderBase UserGrpProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current SysvarProviderBase instance.
		///</summary>
		public virtual SysvarProviderBase SysvarProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TransValueProviderBase instance.
		///</summary>
		public virtual TransValueProviderBase TransValueProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TransactionProviderBase instance.
		///</summary>
		public virtual TransactionProviderBase TransactionProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current ModePaymentProviderBase instance.
		///</summary>
		public virtual ModePaymentProviderBase ModePaymentProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current TransnumProviderBase instance.
		///</summary>
		public virtual TransnumProviderBase TransnumProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MercLocationProviderBase instance.
		///</summary>
		public virtual MercLocationProviderBase MercLocationProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CurrencyProviderBase instance.
		///</summary>
		public virtual CurrencyProviderBase CurrencyProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MenusProviderBase instance.
		///</summary>
		public virtual MenusProviderBase MenusProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CustInfoProviderBase instance.
		///</summary>
		public virtual CustInfoProviderBase CustInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CsCardProviderBase instance.
		///</summary>
		public virtual CsCardProviderBase CsCardProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current CustomerProviderBase instance.
		///</summary>
		public virtual CustomerProviderBase CustomerProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AccTransProviderBase instance.
		///</summary>
		public virtual AccTransProviderBase AccTransProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current BookAttrProviderBase instance.
		///</summary>
		public virtual BookAttrProviderBase BookAttrProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current AtrCodeProviderBase instance.
		///</summary>
		public virtual AtrCodeProviderBase AtrCodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current DateProviderBase instance.
		///</summary>
		public virtual DateProviderBase DateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current BarcodeProviderBase instance.
		///</summary>
		public virtual BarcodeProviderBase BarcodeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LanguageProviderBase instance.
		///</summary>
		public virtual LanguageProviderBase LanguageProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FilesProviderBase instance.
		///</summary>
		public virtual FilesProviderBase FilesProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LoanTranProviderBase instance.
		///</summary>
		public virtual LoanTranProviderBase LoanTranProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KitInfoProviderBase instance.
		///</summary>
		public virtual KitInfoProviderBase KitInfoProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current LocationProviderBase instance.
		///</summary>
		public virtual LocationProviderBase LocationProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current FrmTypeProviderBase instance.
		///</summary>
		public virtual FrmTypeProviderBase FrmTypeProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current KitProviderBase instance.
		///</summary>
		public virtual KitProviderBase KitProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GoodsProviderBase instance.
		///</summary>
		public virtual GoodsProviderBase GoodsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current UtilsProviderBase instance.
		///</summary>
		public virtual UtilsProviderBase UtilsProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current GoodsGrpProviderBase instance.
		///</summary>
		public virtual GoodsGrpProviderBase GoodsGrpProvider{get {throw new NotImplementedException();}}
		
		
	}
}
