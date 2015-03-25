#region Using directives

using System;
using System.Collections;
using System.Collections.Specialized;


using System.Web.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using LibraryManagement.Domain;
using LibraryManagement.Dao;
using LibraryManagement.Dao.Bases;

#endregion

namespace LibraryManagement.Dao.SqlClient
{
	/// <summary>
	/// This class is the Sql implementation of the NetTiersProvider.
	/// </summary>
	public sealed class SqlNetTiersProvider : LibraryManagement.Dao.Bases.NetTiersProvider
	{
		private static object syncRoot = new Object();
		private string _applicationName;
        private string _connectionString;
        private bool _useStoredProcedure;
        string _providerInvariantName;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SqlNetTiersProvider"/> class.
		///</summary>
		public SqlNetTiersProvider()
		{	
		}		
		
		/// <summary>
        /// Initializes the provider.
        /// </summary>
        /// <param name="name">The friendly name of the provider.</param>
        /// <param name="config">A collection of the name/value pairs representing the provider-specific attributes specified in the configuration for this provider.</param>
        /// <exception cref="T:System.ArgumentNullException">The name of the provider is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">An attempt is made to call <see cref="M:System.Configuration.Provider.ProviderBase.Initialize(System.String,System.Collections.Specialized.NameValueCollection)"></see> on a provider after the provider has already been initialized.</exception>
        /// <exception cref="T:System.ArgumentException">The name of the provider has a length of zero.</exception>
		public override void Initialize(string name, NameValueCollection config)
        {
            // Verify that config isn't null
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            // Assign the provider a default name if it doesn't have one
            if (String.IsNullOrEmpty(name))
            {
                name = "SqlNetTiersProvider";
            }

            // Add a default "description" attribute to config if the
            // attribute doesn't exist or is empty
            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "NetTiers Sql provider");
            }

            // Call the base class's Initialize method
            base.Initialize(name, config);

            // Initialize _applicationName
            _applicationName = config["applicationName"];

            if (string.IsNullOrEmpty(_applicationName))
            {
                _applicationName = "/";
            }
            config.Remove("applicationName");


            #region "Initialize UseStoredProcedure"
            string storedProcedure  = config["useStoredProcedure"];
           	if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new ProviderException("Empty or missing useStoredProcedure");
            }
            this._useStoredProcedure = Convert.ToBoolean(config["useStoredProcedure"]);
            config.Remove("useStoredProcedure");
            #endregion

			#region ConnectionString

			// Initialize _connectionString
			_connectionString = config["connectionString"];
			config.Remove("connectionString");

			string connect = config["connectionStringName"];
			config.Remove("connectionStringName");

			if ( String.IsNullOrEmpty(_connectionString) )
			{
				if ( String.IsNullOrEmpty(connect) )
				{
					throw new ProviderException("Empty or missing connectionStringName");
				}

				if ( DataRepository.ConnectionStrings[connect] == null )
				{
					throw new ProviderException("Missing connection string");
				}

				_connectionString = DataRepository.ConnectionStrings[connect].ConnectionString;
			}

            if ( String.IsNullOrEmpty(_connectionString) )
            {
                throw new ProviderException("Empty connection string");
			}

			#endregion
            
             #region "_providerInvariantName"

            // initialize _providerInvariantName
            this._providerInvariantName = config["providerInvariantName"];

            if (String.IsNullOrEmpty(_providerInvariantName))
            {
                throw new ProviderException("Empty or missing providerInvariantName");
            }
            config.Remove("providerInvariantName");

            #endregion

        }
		
		/// <summary>
		/// Creates a new <see cref="TransactionManager"/> instance from the current datasource.
		/// </summary>
		/// <returns></returns>
		public override TransactionManager CreateTransaction()
		{
			return new TransactionManager(this._connectionString);
		}
		
		/// <summary>
		/// Gets a value indicating whether to use stored procedure or not.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this repository use stored procedures; otherwise, <c>false</c>.
		/// </value>
		public bool UseStoredProcedure
		{
			get {return this._useStoredProcedure;}
			set {this._useStoredProcedure = value;}
		}
		
		 /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
		public string ConnectionString
		{
			get {return this._connectionString;}
			set {this._connectionString = value;}
		}
		
		/// <summary>
	    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
	    /// </summary>
	    /// <value>The name of the provider invariant.</value>
	    public string ProviderInvariantName
	    {
	        get { return this._providerInvariantName; }
	        set { this._providerInvariantName = value; }
	    }		
		
		///<summary>
		/// Indicates if the current <see cref="NetTiersProvider"/> implementation supports Transacton.
		///</summary>
		public override bool IsTransactionSupported
		{
			get
			{
				return true;
			}
		}

		
		#region "ReportsProvider"
			
		private SqlReportsProvider innerSqlReportsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Reports"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ReportsProviderBase ReportsProvider
		{
			get
			{
				if (innerSqlReportsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlReportsProvider == null)
						{
							this.innerSqlReportsProvider = new SqlReportsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlReportsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlReportsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlReportsProvider SqlReportsProvider
		{
			get {return ReportsProvider as SqlReportsProvider;}
		}
		
		#endregion
		
		
		#region "AccountProvider"
			
		private SqlAccountProvider innerSqlAccountProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Account"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccountProviderBase AccountProvider
		{
			get
			{
				if (innerSqlAccountProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccountProvider == null)
						{
							this.innerSqlAccountProvider = new SqlAccountProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccountProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlAccountProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccountProvider SqlAccountProvider
		{
			get {return AccountProvider as SqlAccountProvider;}
		}
		
		#endregion
		
		
		#region "StaffProvider"
			
		private SqlStaffProvider innerSqlStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Staff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StaffProviderBase StaffProvider
		{
			get
			{
				if (innerSqlStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStaffProvider == null)
						{
							this.innerSqlStaffProvider = new SqlStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStaffProvider SqlStaffProvider
		{
			get {return StaffProvider as SqlStaffProvider;}
		}
		
		#endregion
		
		
		#region "PriceProvider"
			
		private SqlPriceProvider innerSqlPriceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Price"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PriceProviderBase PriceProvider
		{
			get
			{
				if (innerSqlPriceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPriceProvider == null)
						{
							this.innerSqlPriceProvider = new SqlPriceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPriceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPriceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPriceProvider SqlPriceProvider
		{
			get {return PriceProvider as SqlPriceProvider;}
		}
		
		#endregion
		
		
		#region "StationsProvider"
			
		private SqlStationsProvider innerSqlStationsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Stations"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StationsProviderBase StationsProvider
		{
			get
			{
				if (innerSqlStationsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStationsProvider == null)
						{
							this.innerSqlStationsProvider = new SqlStationsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStationsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlStationsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStationsProvider SqlStationsProvider
		{
			get {return StationsProvider as SqlStationsProvider;}
		}
		
		#endregion
		
		
		#region "MofSysProvider"
			
		private SqlMofSysProvider innerSqlMofSysProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MofSys"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MofSysProviderBase MofSysProvider
		{
			get
			{
				if (innerSqlMofSysProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMofSysProvider == null)
						{
							this.innerSqlMofSysProvider = new SqlMofSysProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMofSysProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMofSysProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMofSysProvider SqlMofSysProvider
		{
			get {return MofSysProvider as SqlMofSysProvider;}
		}
		
		#endregion
		
		
		#region "PaymentOrderProvider"
			
		private SqlPaymentOrderProvider innerSqlPaymentOrderProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PaymentOrder"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PaymentOrderProviderBase PaymentOrderProvider
		{
			get
			{
				if (innerSqlPaymentOrderProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPaymentOrderProvider == null)
						{
							this.innerSqlPaymentOrderProvider = new SqlPaymentOrderProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPaymentOrderProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPaymentOrderProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPaymentOrderProvider SqlPaymentOrderProvider
		{
			get {return PaymentOrderProvider as SqlPaymentOrderProvider;}
		}
		
		#endregion
		
		
		#region "NonPluProvider"
			
		private SqlNonPluProvider innerSqlNonPluProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NonPlu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NonPluProviderBase NonPluProvider
		{
			get
			{
				if (innerSqlNonPluProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNonPluProvider == null)
						{
							this.innerSqlNonPluProvider = new SqlNonPluProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNonPluProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNonPluProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNonPluProvider SqlNonPluProvider
		{
			get {return NonPluProvider as SqlNonPluProvider;}
		}
		
		#endregion
		
		
		#region "StockInfoProvider"
			
		private SqlStockInfoProvider innerSqlStockInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="StockInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StockInfoProviderBase StockInfoProvider
		{
			get
			{
				if (innerSqlStockInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStockInfoProvider == null)
						{
							this.innerSqlStockInfoProvider = new SqlStockInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStockInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlStockInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStockInfoProvider SqlStockInfoProvider
		{
			get {return StockInfoProvider as SqlStockInfoProvider;}
		}
		
		#endregion
		
		
		#region "OnOrderProvider"
			
		private SqlOnOrderProvider innerSqlOnOrderProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="OnOrder"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override OnOrderProviderBase OnOrderProvider
		{
			get
			{
				if (innerSqlOnOrderProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlOnOrderProvider == null)
						{
							this.innerSqlOnOrderProvider = new SqlOnOrderProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlOnOrderProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlOnOrderProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlOnOrderProvider SqlOnOrderProvider
		{
			get {return OnOrderProvider as SqlOnOrderProvider;}
		}
		
		#endregion
		
		
		#region "UnitProvider"
			
		private SqlUnitProvider innerSqlUnitProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Unit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UnitProviderBase UnitProvider
		{
			get
			{
				if (innerSqlUnitProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUnitProvider == null)
						{
							this.innerSqlUnitProvider = new SqlUnitProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUnitProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUnitProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUnitProvider SqlUnitProvider
		{
			get {return UnitProvider as SqlUnitProvider;}
		}
		
		#endregion
		
		
		#region "StoreProvider"
			
		private SqlStoreProvider innerSqlStoreProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Store"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StoreProviderBase StoreProvider
		{
			get
			{
				if (innerSqlStoreProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStoreProvider == null)
						{
							this.innerSqlStoreProvider = new SqlStoreProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStoreProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlStoreProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStoreProvider SqlStoreProvider
		{
			get {return StoreProvider as SqlStoreProvider;}
		}
		
		#endregion
		
		
		#region "UserProvider"
			
		private SqlUserProvider innerSqlUserProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="User"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UserProviderBase UserProvider
		{
			get
			{
				if (innerSqlUserProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUserProvider == null)
						{
							this.innerSqlUserProvider = new SqlUserProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUserProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUserProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUserProvider SqlUserProvider
		{
			get {return UserProvider as SqlUserProvider;}
		}
		
		#endregion
		
		
		#region "TrcodeProvider"
			
		private SqlTrcodeProvider innerSqlTrcodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Trcode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrcodeProviderBase TrcodeProvider
		{
			get
			{
				if (innerSqlTrcodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrcodeProvider == null)
						{
							this.innerSqlTrcodeProvider = new SqlTrcodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrcodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrcodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrcodeProvider SqlTrcodeProvider
		{
			get {return TrcodeProvider as SqlTrcodeProvider;}
		}
		
		#endregion
		
		
		#region "UserGrpProvider"
			
		private SqlUserGrpProvider innerSqlUserGrpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UserGrp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UserGrpProviderBase UserGrpProvider
		{
			get
			{
				if (innerSqlUserGrpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUserGrpProvider == null)
						{
							this.innerSqlUserGrpProvider = new SqlUserGrpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUserGrpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUserGrpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUserGrpProvider SqlUserGrpProvider
		{
			get {return UserGrpProvider as SqlUserGrpProvider;}
		}
		
		#endregion
		
		
		#region "SysvarProvider"
			
		private SqlSysvarProvider innerSqlSysvarProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Sysvar"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysvarProviderBase SysvarProvider
		{
			get
			{
				if (innerSqlSysvarProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysvarProvider == null)
						{
							this.innerSqlSysvarProvider = new SqlSysvarProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysvarProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSysvarProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysvarProvider SqlSysvarProvider
		{
			get {return SysvarProvider as SqlSysvarProvider;}
		}
		
		#endregion
		
		
		#region "TransValueProvider"
			
		private SqlTransValueProvider innerSqlTransValueProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TransValue"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TransValueProviderBase TransValueProvider
		{
			get
			{
				if (innerSqlTransValueProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTransValueProvider == null)
						{
							this.innerSqlTransValueProvider = new SqlTransValueProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTransValueProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTransValueProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTransValueProvider SqlTransValueProvider
		{
			get {return TransValueProvider as SqlTransValueProvider;}
		}
		
		#endregion
		
		
		#region "TransactionProvider"
			
		private SqlTransactionProvider innerSqlTransactionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Transaction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TransactionProviderBase TransactionProvider
		{
			get
			{
				if (innerSqlTransactionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTransactionProvider == null)
						{
							this.innerSqlTransactionProvider = new SqlTransactionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTransactionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTransactionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTransactionProvider SqlTransactionProvider
		{
			get {return TransactionProvider as SqlTransactionProvider;}
		}
		
		#endregion
		
		
		#region "ModePaymentProvider"
			
		private SqlModePaymentProvider innerSqlModePaymentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ModePayment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ModePaymentProviderBase ModePaymentProvider
		{
			get
			{
				if (innerSqlModePaymentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlModePaymentProvider == null)
						{
							this.innerSqlModePaymentProvider = new SqlModePaymentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlModePaymentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlModePaymentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlModePaymentProvider SqlModePaymentProvider
		{
			get {return ModePaymentProvider as SqlModePaymentProvider;}
		}
		
		#endregion
		
		
		#region "TransnumProvider"
			
		private SqlTransnumProvider innerSqlTransnumProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Transnum"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TransnumProviderBase TransnumProvider
		{
			get
			{
				if (innerSqlTransnumProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTransnumProvider == null)
						{
							this.innerSqlTransnumProvider = new SqlTransnumProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTransnumProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTransnumProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTransnumProvider SqlTransnumProvider
		{
			get {return TransnumProvider as SqlTransnumProvider;}
		}
		
		#endregion
		
		
		#region "MercLocationProvider"
			
		private SqlMercLocationProvider innerSqlMercLocationProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MercLocation"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MercLocationProviderBase MercLocationProvider
		{
			get
			{
				if (innerSqlMercLocationProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMercLocationProvider == null)
						{
							this.innerSqlMercLocationProvider = new SqlMercLocationProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMercLocationProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMercLocationProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMercLocationProvider SqlMercLocationProvider
		{
			get {return MercLocationProvider as SqlMercLocationProvider;}
		}
		
		#endregion
		
		
		#region "CurrencyProvider"
			
		private SqlCurrencyProvider innerSqlCurrencyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Currency"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CurrencyProviderBase CurrencyProvider
		{
			get
			{
				if (innerSqlCurrencyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCurrencyProvider == null)
						{
							this.innerSqlCurrencyProvider = new SqlCurrencyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCurrencyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCurrencyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCurrencyProvider SqlCurrencyProvider
		{
			get {return CurrencyProvider as SqlCurrencyProvider;}
		}
		
		#endregion
		
		
		#region "MenusProvider"
			
		private SqlMenusProvider innerSqlMenusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Menus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MenusProviderBase MenusProvider
		{
			get
			{
				if (innerSqlMenusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMenusProvider == null)
						{
							this.innerSqlMenusProvider = new SqlMenusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMenusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMenusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMenusProvider SqlMenusProvider
		{
			get {return MenusProvider as SqlMenusProvider;}
		}
		
		#endregion
		
		
		#region "CustInfoProvider"
			
		private SqlCustInfoProvider innerSqlCustInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CustInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CustInfoProviderBase CustInfoProvider
		{
			get
			{
				if (innerSqlCustInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCustInfoProvider == null)
						{
							this.innerSqlCustInfoProvider = new SqlCustInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCustInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCustInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCustInfoProvider SqlCustInfoProvider
		{
			get {return CustInfoProvider as SqlCustInfoProvider;}
		}
		
		#endregion
		
		
		#region "CsCardProvider"
			
		private SqlCsCardProvider innerSqlCsCardProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CsCard"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CsCardProviderBase CsCardProvider
		{
			get
			{
				if (innerSqlCsCardProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCsCardProvider == null)
						{
							this.innerSqlCsCardProvider = new SqlCsCardProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCsCardProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCsCardProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCsCardProvider SqlCsCardProvider
		{
			get {return CsCardProvider as SqlCsCardProvider;}
		}
		
		#endregion
		
		
		#region "CustomerProvider"
			
		private SqlCustomerProvider innerSqlCustomerProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Customer"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CustomerProviderBase CustomerProvider
		{
			get
			{
				if (innerSqlCustomerProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCustomerProvider == null)
						{
							this.innerSqlCustomerProvider = new SqlCustomerProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCustomerProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCustomerProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCustomerProvider SqlCustomerProvider
		{
			get {return CustomerProvider as SqlCustomerProvider;}
		}
		
		#endregion
		
		
		#region "AccTransProvider"
			
		private SqlAccTransProvider innerSqlAccTransProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccTrans"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccTransProviderBase AccTransProvider
		{
			get
			{
				if (innerSqlAccTransProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccTransProvider == null)
						{
							this.innerSqlAccTransProvider = new SqlAccTransProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccTransProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlAccTransProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccTransProvider SqlAccTransProvider
		{
			get {return AccTransProvider as SqlAccTransProvider;}
		}
		
		#endregion
		
		
		#region "BookAttrProvider"
			
		private SqlBookAttrProvider innerSqlBookAttrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="BookAttr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override BookAttrProviderBase BookAttrProvider
		{
			get
			{
				if (innerSqlBookAttrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlBookAttrProvider == null)
						{
							this.innerSqlBookAttrProvider = new SqlBookAttrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlBookAttrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlBookAttrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlBookAttrProvider SqlBookAttrProvider
		{
			get {return BookAttrProvider as SqlBookAttrProvider;}
		}
		
		#endregion
		
		
		#region "AtrCodeProvider"
			
		private SqlAtrCodeProvider innerSqlAtrCodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AtrCode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AtrCodeProviderBase AtrCodeProvider
		{
			get
			{
				if (innerSqlAtrCodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAtrCodeProvider == null)
						{
							this.innerSqlAtrCodeProvider = new SqlAtrCodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAtrCodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlAtrCodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAtrCodeProvider SqlAtrCodeProvider
		{
			get {return AtrCodeProvider as SqlAtrCodeProvider;}
		}
		
		#endregion
		
		
		#region "DateProvider"
			
		private SqlDateProvider innerSqlDateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Date"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DateProviderBase DateProvider
		{
			get
			{
				if (innerSqlDateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDateProvider == null)
						{
							this.innerSqlDateProvider = new SqlDateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDateProvider SqlDateProvider
		{
			get {return DateProvider as SqlDateProvider;}
		}
		
		#endregion
		
		
		#region "BarcodeProvider"
			
		private SqlBarcodeProvider innerSqlBarcodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Barcode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override BarcodeProviderBase BarcodeProvider
		{
			get
			{
				if (innerSqlBarcodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlBarcodeProvider == null)
						{
							this.innerSqlBarcodeProvider = new SqlBarcodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlBarcodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlBarcodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlBarcodeProvider SqlBarcodeProvider
		{
			get {return BarcodeProvider as SqlBarcodeProvider;}
		}
		
		#endregion
		
		
		#region "LanguageProvider"
			
		private SqlLanguageProvider innerSqlLanguageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Language"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LanguageProviderBase LanguageProvider
		{
			get
			{
				if (innerSqlLanguageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLanguageProvider == null)
						{
							this.innerSqlLanguageProvider = new SqlLanguageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLanguageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLanguageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLanguageProvider SqlLanguageProvider
		{
			get {return LanguageProvider as SqlLanguageProvider;}
		}
		
		#endregion
		
		
		#region "FilesProvider"
			
		private SqlFilesProvider innerSqlFilesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Files"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FilesProviderBase FilesProvider
		{
			get
			{
				if (innerSqlFilesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFilesProvider == null)
						{
							this.innerSqlFilesProvider = new SqlFilesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFilesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlFilesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFilesProvider SqlFilesProvider
		{
			get {return FilesProvider as SqlFilesProvider;}
		}
		
		#endregion
		
		
		#region "LoanTranProvider"
			
		private SqlLoanTranProvider innerSqlLoanTranProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoanTran"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoanTranProviderBase LoanTranProvider
		{
			get
			{
				if (innerSqlLoanTranProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoanTranProvider == null)
						{
							this.innerSqlLoanTranProvider = new SqlLoanTranProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoanTranProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoanTranProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoanTranProvider SqlLoanTranProvider
		{
			get {return LoanTranProvider as SqlLoanTranProvider;}
		}
		
		#endregion
		
		
		#region "KitInfoProvider"
			
		private SqlKitInfoProvider innerSqlKitInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KitInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KitInfoProviderBase KitInfoProvider
		{
			get
			{
				if (innerSqlKitInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKitInfoProvider == null)
						{
							this.innerSqlKitInfoProvider = new SqlKitInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKitInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKitInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKitInfoProvider SqlKitInfoProvider
		{
			get {return KitInfoProvider as SqlKitInfoProvider;}
		}
		
		#endregion
		
		
		#region "LocationProvider"
			
		private SqlLocationProvider innerSqlLocationProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Location"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LocationProviderBase LocationProvider
		{
			get
			{
				if (innerSqlLocationProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLocationProvider == null)
						{
							this.innerSqlLocationProvider = new SqlLocationProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLocationProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLocationProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLocationProvider SqlLocationProvider
		{
			get {return LocationProvider as SqlLocationProvider;}
		}
		
		#endregion
		
		
		#region "FrmTypeProvider"
			
		private SqlFrmTypeProvider innerSqlFrmTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FrmType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FrmTypeProviderBase FrmTypeProvider
		{
			get
			{
				if (innerSqlFrmTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFrmTypeProvider == null)
						{
							this.innerSqlFrmTypeProvider = new SqlFrmTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFrmTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlFrmTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFrmTypeProvider SqlFrmTypeProvider
		{
			get {return FrmTypeProvider as SqlFrmTypeProvider;}
		}
		
		#endregion
		
		
		#region "KitProvider"
			
		private SqlKitProvider innerSqlKitProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Kit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KitProviderBase KitProvider
		{
			get
			{
				if (innerSqlKitProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKitProvider == null)
						{
							this.innerSqlKitProvider = new SqlKitProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKitProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKitProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKitProvider SqlKitProvider
		{
			get {return KitProvider as SqlKitProvider;}
		}
		
		#endregion
		
		
		#region "GoodsProvider"
			
		private SqlGoodsProvider innerSqlGoodsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Goods"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GoodsProviderBase GoodsProvider
		{
			get
			{
				if (innerSqlGoodsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGoodsProvider == null)
						{
							this.innerSqlGoodsProvider = new SqlGoodsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGoodsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGoodsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGoodsProvider SqlGoodsProvider
		{
			get {return GoodsProvider as SqlGoodsProvider;}
		}
		
		#endregion
		
		
		#region "UtilsProvider"
			
		private SqlUtilsProvider innerSqlUtilsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="Utils"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UtilsProviderBase UtilsProvider
		{
			get
			{
				if (innerSqlUtilsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUtilsProvider == null)
						{
							this.innerSqlUtilsProvider = new SqlUtilsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUtilsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUtilsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUtilsProvider SqlUtilsProvider
		{
			get {return UtilsProvider as SqlUtilsProvider;}
		}
		
		#endregion
		
		
		#region "GoodsGrpProvider"
			
		private SqlGoodsGrpProvider innerSqlGoodsGrpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GoodsGrp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GoodsGrpProviderBase GoodsGrpProvider
		{
			get
			{
				if (innerSqlGoodsGrpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGoodsGrpProvider == null)
						{
							this.innerSqlGoodsGrpProvider = new SqlGoodsGrpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGoodsGrpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGoodsGrpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGoodsGrpProvider SqlGoodsGrpProvider
		{
			get {return GoodsGrpProvider as SqlGoodsGrpProvider;}
		}
		
		#endregion
		
		
		
		#region "General data access methods"

		#region "ExecuteNonQuery"
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper);	
			
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(commandType, commandText);	
		}
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteNonQuery(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataReader"
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(commandWrapper);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteReader(commandType, commandText);	
		}
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteReader(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataSet"
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(commandWrapper);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteDataSet(commandType, commandText);	
		}
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteDataSet(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteScalar"
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(commandWrapper);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(commandWrapper, transactionManager.TransactionObject);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteScalar(commandType, commandText);	
		}
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteScalar(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#endregion


	}
}
