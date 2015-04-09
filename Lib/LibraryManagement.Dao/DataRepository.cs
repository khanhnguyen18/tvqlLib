#region Using directives

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Provider;
using System.Web.Configuration;
using System.Web;
using LibraryManagement.Domain;
using LibraryManagement.Dao;
using LibraryManagement.Dao.Bases;

#endregion

namespace LibraryManagement.Dao
{
	/// <summary>
	/// This class represents the Data source repository and gives access to all the underlying providers.
	/// </summary>
	[CLSCompliant(true)]
	public sealed class DataRepository 
	{
		private static volatile NetTiersProvider _provider = null;
        private static volatile NetTiersProviderCollection _providers = null;
		private static volatile NetTiersServiceSection _section = null;
        
        private static object SyncRoot = new object();
				
		private DataRepository()
		{
		}
		
		#region Public LoadProvider
		/// <summary>
        /// Enables the DataRepository to programatically create and 
        /// pass in a <c>NetTiersProvider</c> during runtime.
        /// </summary>
        /// <param name="provider">An instatiated NetTiersProvider.</param>
        public static void LoadProvider(NetTiersProvider provider)
        {
			LoadProvider(provider, false);
        }
		
		/// <summary>
        /// Enables the DataRepository to programatically create and 
        /// pass in a <c>NetTiersProvider</c> during runtime.
        /// </summary>
        /// <param name="provider">An instatiated NetTiersProvider.</param>
        /// <param name="setAsDefault">ability to set any valid provider as the default provider for the DataRepository.</param>
		public static void LoadProvider(NetTiersProvider provider, bool setAsDefault)
        {
            if (provider == null)
                throw new ArgumentNullException("provider");

            if (_providers == null)
			{
				lock(SyncRoot)
				{
            		if (_providers == null)
						_providers = new NetTiersProviderCollection();
				}
			}
			
            if (_providers[provider.Name] == null)
            {
                lock (_providers.SyncRoot)
                {
                    _providers.Add(provider);
                }
            }

            if (_provider == null || setAsDefault)
            {
                lock (SyncRoot)
                {
                    if(_provider == null || setAsDefault)
                         _provider = provider;
                }
            }
        }
		#endregion 
		
		///<summary>
		/// Configuration based provider loading, will load the providers on first call.
		///</summary>
		private static void LoadProviders()
        {
            // Avoid claiming lock if providers are already loaded
            if (_provider == null)
            {
                lock (SyncRoot)
                {
                    // Do this again to make sure _provider is still null
                    if (_provider == null)
                    {
                        // Load registered providers and point _provider to the default provider
                        _providers = new NetTiersProviderCollection();

                        ProvidersHelper.InstantiateProviders(NetTiersSection.Providers, _providers, typeof(NetTiersProvider));
						_provider = _providers[NetTiersSection.DefaultProvider];

                        if (_provider == null)
                        {
                            throw new ProviderException("Unable to load default NetTiersProvider");
                        }
                    }
                }
            }
        }

		/// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>The provider.</value>
        public static NetTiersProvider Provider
        {
            get { LoadProviders(); return _provider; }
        }

		/// <summary>
        /// Gets the provider collection.
        /// </summary>
        /// <value>The providers.</value>
        public static NetTiersProviderCollection Providers
        {
            get { LoadProviders(); return _providers; }
        }
		
		/// <summary>
		/// Creates a new <see cref="TransactionManager"/> instance from the current datasource.
		/// </summary>
		/// <returns></returns>
		public TransactionManager CreateTransaction()
		{
			return _provider.CreateTransaction();
		}

		#region Configuration

		/// <summary>
		/// Gets a reference to the configured NetTiersServiceSection object.
		/// </summary>
		public static NetTiersServiceSection NetTiersSection
		{
			get
			{
				// Try to get a reference to the default <netTiersService> section
				_section = WebConfigurationManager.GetSection("netTiersService") as NetTiersServiceSection;

				if ( _section == null )
				{
					// otherwise look for section based on the assembly name
					_section = WebConfigurationManager.GetSection("LibraryManagement.Dao") as NetTiersServiceSection;
				}

				if ( _section == null )
				{
					throw new ProviderException("Unable to load NetTiersServiceSection");
				}

				return _section;
			}
		}

		#endregion Configuration

		#region Connections

		/// <summary>
		/// Gets a reference to the ConnectionStringSettings collection.
		/// </summary>
		public static ConnectionStringSettingsCollection ConnectionStrings
		{
			get
			{
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string netTiersConnectionString = @"Data Source=[DataSource];Initial Catalog=LibraryManagement;Persist Security Info=True;
                                       User ID=[User];Password=[Pass]";

                netTiersConnectionString = netTiersConnectionString.Replace("[DataSource]", ArtDe.Decode.DecodeCode(ConfigurationManager.AppSettings["sdfew"]));
                netTiersConnectionString = netTiersConnectionString.Replace("[User]", ArtDe.Decode.DecodeCode(ConfigurationManager.AppSettings["dffeew"]));
                netTiersConnectionString = netTiersConnectionString.Replace("[Pass]", ArtDe.Decode.DecodeCode(ConfigurationManager.AppSettings["fdff"]));
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("netTiersConnectionString", netTiersConnectionString));
                //<add name="netTiersConnectionString" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=LibraryManagement;Persist Security Info=True;User ID=sa;Password=123456" />
                //config.ConnectionStrings.ConnectionStrings["netTiersConnectionString"].ConnectionString =
                //config.ConnectionStrings.ConnectionStrings["netTiersConnectionString"].ConnectionString.Replace("123456",
                //ArtDe.Decode.DecodeCode(ConfigurationManager.AppSettings["My"]));
                return config.ConnectionStrings.ConnectionStrings;
			}
		}

		// dictionary of connection providers
		private static Dictionary<String, ConnectionProvider> _connections;

		/// <summary>
		/// Gets the dictionary of connection providers.
		/// </summary>
		public static Dictionary<String, ConnectionProvider> Connections
		{
			get
			{
				if ( _connections == null )
				{
					lock (SyncRoot)
                	{
						if (_connections == null)
						{
							_connections = new Dictionary<String, ConnectionProvider>();
		
							// add a connection provider for each configured connection string
							foreach ( ConnectionStringSettings conn in ConnectionStrings )
							{
								_connections.Add(conn.Name, new ConnectionProvider(conn.Name, conn.ConnectionString));
							}
						}
					}
				}

				return _connections;
			}
		}

		/// <summary>
		/// Adds the specified connection string to the map of connection strings.
		/// </summary>
		/// <param name="connectionStringName">The connection string name.</param>
		/// <param name="connectionString">The provider specific connection information.</param>
		public static void AddConnection(String connectionStringName, String connectionString)
		{
			lock (SyncRoot)
            {
				Connections.Remove(connectionStringName);
				ConnectionProvider connection = new ConnectionProvider(connectionStringName, connectionString);
				Connections.Add(connectionStringName, connection);
			}
		}

		/// <summary>
		/// Provides ability to switch connection string at runtime.
		/// </summary>
		public sealed class ConnectionProvider
		{
			private NetTiersProvider _provider;
			private NetTiersProviderCollection _providers;
			private String _connectionStringName;
			private String _connectionString;


			/// <summary>
			/// Initializes a new instance of the ConnectionProvider class.
			/// </summary>
			/// <param name="connectionStringName">The connection string name.</param>
			/// <param name="connectionString">The provider specific connection information.</param>
			public ConnectionProvider(String connectionStringName, String connectionString)
			{
				_connectionString = connectionString;
				_connectionStringName = connectionStringName;
			}

			/// <summary>
			/// Gets the provider.
			/// </summary>
			public NetTiersProvider Provider
			{
				get { LoadProviders(); return _provider; }
			}

			/// <summary>
			/// Gets the provider collection.
			/// </summary>
			public NetTiersProviderCollection Providers
			{
				get { LoadProviders(); return _providers; }
			}

			/// <summary>
			/// Instantiates the configured providers based on the supplied connection string.
			/// </summary>
			private void LoadProviders()
			{
				DataRepository.LoadProviders();

				// Avoid claiming lock if providers are already loaded
				if ( _providers == null )
				{
					lock ( SyncRoot )
					{
						// Do this again to make sure _provider is still null
						if ( _providers == null )
						{
							// apply connection information to each provider
							for ( int i = 0; i < NetTiersSection.Providers.Count; i++ )
							{
								NetTiersSection.Providers[i].Parameters["connectionStringName"] = _connectionStringName;
								// remove previous connection string, if any
								NetTiersSection.Providers[i].Parameters.Remove("connectionString");

								if ( !String.IsNullOrEmpty(_connectionString) )
								{
									NetTiersSection.Providers[i].Parameters["connectionString"] = _connectionString;
								}
							}

							// Load registered providers and point _provider to the default provider
							_providers = new NetTiersProviderCollection();

							ProvidersHelper.InstantiateProviders(NetTiersSection.Providers, _providers, typeof(NetTiersProvider));
							_provider = _providers[NetTiersSection.DefaultProvider];
						}
					}
				}
			}
		}

		#endregion Connections

		#region Static properties
		
		#region ReportsProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Reports"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static ReportsProviderBase ReportsProvider
		{
			get 
			{
				LoadProviders();
				return _provider.ReportsProvider;
			}
		}
		
		#endregion
		
		#region AccountProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Account"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static AccountProviderBase AccountProvider
		{
			get 
			{
				LoadProviders();
				return _provider.AccountProvider;
			}
		}
		
		#endregion
		
		#region StaffProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Staff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static StaffProviderBase StaffProvider
		{
			get 
			{
				LoadProviders();
				return _provider.StaffProvider;
			}
		}
		
		#endregion
		
		#region PriceProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Price"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static PriceProviderBase PriceProvider
		{
			get 
			{
				LoadProviders();
				return _provider.PriceProvider;
			}
		}
		
		#endregion
		
		#region StationsProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Stations"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static StationsProviderBase StationsProvider
		{
			get 
			{
				LoadProviders();
				return _provider.StationsProvider;
			}
		}
		
		#endregion
		
		#region MofSysProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="MofSys"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static MofSysProviderBase MofSysProvider
		{
			get 
			{
				LoadProviders();
				return _provider.MofSysProvider;
			}
		}
		
		#endregion
		
		#region PaymentOrderProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="PaymentOrder"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static PaymentOrderProviderBase PaymentOrderProvider
		{
			get 
			{
				LoadProviders();
				return _provider.PaymentOrderProvider;
			}
		}
		
		#endregion
		
		#region NonPluProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="NonPlu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static NonPluProviderBase NonPluProvider
		{
			get 
			{
				LoadProviders();
				return _provider.NonPluProvider;
			}
		}
		
		#endregion
		
		#region StockInfoProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="StockInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static StockInfoProviderBase StockInfoProvider
		{
			get 
			{
				LoadProviders();
				return _provider.StockInfoProvider;
			}
		}
		
		#endregion
		
		#region OnOrderProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="OnOrder"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static OnOrderProviderBase OnOrderProvider
		{
			get 
			{
				LoadProviders();
				return _provider.OnOrderProvider;
			}
		}
		
		#endregion
		
		#region UnitProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Unit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static UnitProviderBase UnitProvider
		{
			get 
			{
				LoadProviders();
				return _provider.UnitProvider;
			}
		}
		
		#endregion
		
		#region StoreProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Store"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static StoreProviderBase StoreProvider
		{
			get 
			{
				LoadProviders();
				return _provider.StoreProvider;
			}
		}
		
		#endregion
		
		#region UserProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="User"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static UserProviderBase UserProvider
		{
			get 
			{
				LoadProviders();
				return _provider.UserProvider;
			}
		}
		
		#endregion
		
		#region TrcodeProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Trcode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static TrcodeProviderBase TrcodeProvider
		{
			get 
			{
				LoadProviders();
				return _provider.TrcodeProvider;
			}
		}
		
		#endregion
		
		#region UserGrpProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="UserGrp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static UserGrpProviderBase UserGrpProvider
		{
			get 
			{
				LoadProviders();
				return _provider.UserGrpProvider;
			}
		}
		
		#endregion
		
		#region SysvarProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Sysvar"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static SysvarProviderBase SysvarProvider
		{
			get 
			{
				LoadProviders();
				return _provider.SysvarProvider;
			}
		}
		
		#endregion
		
		#region TransValueProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="TransValue"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static TransValueProviderBase TransValueProvider
		{
			get 
			{
				LoadProviders();
				return _provider.TransValueProvider;
			}
		}
		
		#endregion
		
		#region TransactionProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Transaction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static TransactionProviderBase TransactionProvider
		{
			get 
			{
				LoadProviders();
				return _provider.TransactionProvider;
			}
		}
		
		#endregion
		
		#region ModePaymentProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="ModePayment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static ModePaymentProviderBase ModePaymentProvider
		{
			get 
			{
				LoadProviders();
				return _provider.ModePaymentProvider;
			}
		}
		
		#endregion
		
		#region TransnumProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Transnum"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static TransnumProviderBase TransnumProvider
		{
			get 
			{
				LoadProviders();
				return _provider.TransnumProvider;
			}
		}
		
		#endregion
		
		#region MercLocationProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="MercLocation"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static MercLocationProviderBase MercLocationProvider
		{
			get 
			{
				LoadProviders();
				return _provider.MercLocationProvider;
			}
		}
		
		#endregion
		
		#region CurrencyProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Currency"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static CurrencyProviderBase CurrencyProvider
		{
			get 
			{
				LoadProviders();
				return _provider.CurrencyProvider;
			}
		}
		
		#endregion
		
		#region MenusProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Menus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static MenusProviderBase MenusProvider
		{
			get 
			{
				LoadProviders();
				return _provider.MenusProvider;
			}
		}
		
		#endregion
		
		#region CustInfoProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="CustInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static CustInfoProviderBase CustInfoProvider
		{
			get 
			{
				LoadProviders();
				return _provider.CustInfoProvider;
			}
		}
		
		#endregion
		
		#region CsCardProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="CsCard"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static CsCardProviderBase CsCardProvider
		{
			get 
			{
				LoadProviders();
				return _provider.CsCardProvider;
			}
		}
		
		#endregion
		
		#region CustomerProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Customer"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static CustomerProviderBase CustomerProvider
		{
			get 
			{
				LoadProviders();
				return _provider.CustomerProvider;
			}
		}
		
		#endregion
		
		#region AccTransProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="AccTrans"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static AccTransProviderBase AccTransProvider
		{
			get 
			{
				LoadProviders();
				return _provider.AccTransProvider;
			}
		}
		
		#endregion
		
		#region BookAttrProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="BookAttr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static BookAttrProviderBase BookAttrProvider
		{
			get 
			{
				LoadProviders();
				return _provider.BookAttrProvider;
			}
		}
		
		#endregion
		
		#region AtrCodeProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="AtrCode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static AtrCodeProviderBase AtrCodeProvider
		{
			get 
			{
				LoadProviders();
				return _provider.AtrCodeProvider;
			}
		}
		
		#endregion
		
		#region DateProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Date"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static DateProviderBase DateProvider
		{
			get 
			{
				LoadProviders();
				return _provider.DateProvider;
			}
		}
		
		#endregion
		
		#region BarcodeProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Barcode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static BarcodeProviderBase BarcodeProvider
		{
			get 
			{
				LoadProviders();
				return _provider.BarcodeProvider;
			}
		}
		
		#endregion
		
		#region LanguageProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Language"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static LanguageProviderBase LanguageProvider
		{
			get 
			{
				LoadProviders();
				return _provider.LanguageProvider;
			}
		}
		
		#endregion
		
		#region FilesProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Files"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static FilesProviderBase FilesProvider
		{
			get 
			{
				LoadProviders();
				return _provider.FilesProvider;
			}
		}
		
		#endregion
		
		#region LoanTranProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="LoanTran"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static LoanTranProviderBase LoanTranProvider
		{
			get 
			{
				LoadProviders();
				return _provider.LoanTranProvider;
			}
		}
		
		#endregion
		
		#region KitInfoProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="KitInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static KitInfoProviderBase KitInfoProvider
		{
			get 
			{
				LoadProviders();
				return _provider.KitInfoProvider;
			}
		}
		
		#endregion
		
		#region LocationProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Location"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static LocationProviderBase LocationProvider
		{
			get 
			{
				LoadProviders();
				return _provider.LocationProvider;
			}
		}
		
		#endregion
		
		#region FrmTypeProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="FrmType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static FrmTypeProviderBase FrmTypeProvider
		{
			get 
			{
				LoadProviders();
				return _provider.FrmTypeProvider;
			}
		}
		
		#endregion
		
		#region KitProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Kit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static KitProviderBase KitProvider
		{
			get 
			{
				LoadProviders();
				return _provider.KitProvider;
			}
		}
		
		#endregion
		
		#region GoodsProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Goods"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static GoodsProviderBase GoodsProvider
		{
			get 
			{
				LoadProviders();
				return _provider.GoodsProvider;
			}
		}
		
		#endregion
		
		#region UtilsProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="Utils"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static UtilsProviderBase UtilsProvider
		{
			get 
			{
				LoadProviders();
				return _provider.UtilsProvider;
			}
		}
		
		#endregion
		
		#region GoodsGrpProvider

		///<summary>
		/// Gets the current instance of the Data Access Logic Component for the <see cref="GoodsGrp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		public static GoodsGrpProviderBase GoodsGrpProvider
		{
			get 
			{
				LoadProviders();
				return _provider.GoodsGrpProvider;
			}
		}
		
		#endregion
		
		
		#endregion
	}
	
	#region Query/Filters
		
	#region ReportsFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Reports"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportsFilters : ReportsFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportsFilters class.
		/// </summary>
		public ReportsFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportsFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportsFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportsFilters
	
	#region ReportsQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ReportsParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Reports"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportsQuery : ReportsParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportsQuery class.
		/// </summary>
		public ReportsQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the ReportsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ReportsQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ReportsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ReportsQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ReportsQuery
		
	#region AccountFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Account"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccountFilters : AccountFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccountFilters class.
		/// </summary>
		public AccountFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccountFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccountFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccountFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccountFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccountFilters
	
	#region AccountQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="AccountParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Account"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccountQuery : AccountParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccountQuery class.
		/// </summary>
		public AccountQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccountQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccountQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccountQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccountQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccountQuery
		
	#region StaffFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Staff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffFilters : StaffFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffFilters class.
		/// </summary>
		public StaffFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffFilters
	
	#region StaffQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="StaffParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Staff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StaffQuery : StaffParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StaffQuery class.
		/// </summary>
		public StaffQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the StaffQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StaffQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StaffQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StaffQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StaffQuery
		
	#region PriceFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Price"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PriceFilters : PriceFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PriceFilters class.
		/// </summary>
		public PriceFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the PriceFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PriceFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PriceFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PriceFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PriceFilters
	
	#region PriceQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="PriceParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Price"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PriceQuery : PriceParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PriceQuery class.
		/// </summary>
		public PriceQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the PriceQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PriceQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PriceQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PriceQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PriceQuery
		
	#region StationsFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Stations"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StationsFilters : StationsFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationsFilters class.
		/// </summary>
		public StationsFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the StationsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StationsFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StationsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StationsFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StationsFilters
	
	#region StationsQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="StationsParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Stations"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StationsQuery : StationsParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationsQuery class.
		/// </summary>
		public StationsQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the StationsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StationsQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StationsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StationsQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StationsQuery
		
	#region MofSysFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MofSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MofSysFilters : MofSysFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MofSysFilters class.
		/// </summary>
		public MofSysFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the MofSysFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MofSysFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MofSysFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MofSysFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MofSysFilters
	
	#region MofSysQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="MofSysParameterBuilder"/> class
	/// that is used exclusively with a <see cref="MofSys"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MofSysQuery : MofSysParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MofSysQuery class.
		/// </summary>
		public MofSysQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the MofSysQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MofSysQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MofSysQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MofSysQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MofSysQuery
		
	#region PaymentOrderFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PaymentOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PaymentOrderFilters : PaymentOrderFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilters class.
		/// </summary>
		public PaymentOrderFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PaymentOrderFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PaymentOrderFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PaymentOrderFilters
	
	#region PaymentOrderQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="PaymentOrderParameterBuilder"/> class
	/// that is used exclusively with a <see cref="PaymentOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PaymentOrderQuery : PaymentOrderParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PaymentOrderQuery class.
		/// </summary>
		public PaymentOrderQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PaymentOrderQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PaymentOrderQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PaymentOrderQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PaymentOrderQuery
		
	#region NonPluFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NonPlu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NonPluFilters : NonPluFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NonPluFilters class.
		/// </summary>
		public NonPluFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the NonPluFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NonPluFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NonPluFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NonPluFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NonPluFilters
	
	#region NonPluQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="NonPluParameterBuilder"/> class
	/// that is used exclusively with a <see cref="NonPlu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NonPluQuery : NonPluParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NonPluQuery class.
		/// </summary>
		public NonPluQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the NonPluQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public NonPluQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the NonPluQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public NonPluQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion NonPluQuery
		
	#region StockInfoFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="StockInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StockInfoFilters : StockInfoFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StockInfoFilters class.
		/// </summary>
		public StockInfoFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the StockInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StockInfoFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StockInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StockInfoFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StockInfoFilters
	
	#region StockInfoQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="StockInfoParameterBuilder"/> class
	/// that is used exclusively with a <see cref="StockInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StockInfoQuery : StockInfoParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StockInfoQuery class.
		/// </summary>
		public StockInfoQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the StockInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StockInfoQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StockInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StockInfoQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StockInfoQuery
		
	#region OnOrderFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="OnOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class OnOrderFilters : OnOrderFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OnOrderFilters class.
		/// </summary>
		public OnOrderFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the OnOrderFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public OnOrderFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the OnOrderFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public OnOrderFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion OnOrderFilters
	
	#region OnOrderQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="OnOrderParameterBuilder"/> class
	/// that is used exclusively with a <see cref="OnOrder"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class OnOrderQuery : OnOrderParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the OnOrderQuery class.
		/// </summary>
		public OnOrderQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the OnOrderQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public OnOrderQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the OnOrderQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public OnOrderQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion OnOrderQuery
		
	#region UnitFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Unit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UnitFilters : UnitFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UnitFilters class.
		/// </summary>
		public UnitFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the UnitFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UnitFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UnitFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UnitFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UnitFilters
	
	#region UnitQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="UnitParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Unit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UnitQuery : UnitParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UnitQuery class.
		/// </summary>
		public UnitQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the UnitQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UnitQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UnitQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UnitQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UnitQuery
		
	#region StoreFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Store"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StoreFilters : StoreFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StoreFilters class.
		/// </summary>
		public StoreFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the StoreFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StoreFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StoreFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StoreFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StoreFilters
	
	#region StoreQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="StoreParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Store"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class StoreQuery : StoreParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StoreQuery class.
		/// </summary>
		public StoreQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the StoreQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public StoreQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the StoreQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public StoreQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion StoreQuery
		
	#region UserFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="User"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserFilters : UserFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserFilters class.
		/// </summary>
		public UserFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserFilters
	
	#region UserQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="UserParameterBuilder"/> class
	/// that is used exclusively with a <see cref="User"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserQuery : UserParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserQuery class.
		/// </summary>
		public UserQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserQuery
		
	#region TrcodeFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Trcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrcodeFilters : TrcodeFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrcodeFilters class.
		/// </summary>
		public TrcodeFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrcodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrcodeFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrcodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrcodeFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrcodeFilters
	
	#region TrcodeQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="TrcodeParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Trcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrcodeQuery : TrcodeParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrcodeQuery class.
		/// </summary>
		public TrcodeQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrcodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrcodeQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrcodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrcodeQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrcodeQuery
		
	#region UserGrpFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UserGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserGrpFilters : UserGrpFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserGrpFilters class.
		/// </summary>
		public UserGrpFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserGrpFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserGrpFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserGrpFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserGrpFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserGrpFilters
	
	#region UserGrpQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="UserGrpParameterBuilder"/> class
	/// that is used exclusively with a <see cref="UserGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UserGrpQuery : UserGrpParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserGrpQuery class.
		/// </summary>
		public UserGrpQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the UserGrpQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UserGrpQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UserGrpQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UserGrpQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UserGrpQuery
		
	#region SysvarFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Sysvar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysvarFilters : SysvarFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysvarFilters class.
		/// </summary>
		public SysvarFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysvarFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysvarFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysvarFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysvarFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysvarFilters
	
	#region SysvarQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SysvarParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Sysvar"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SysvarQuery : SysvarParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SysvarQuery class.
		/// </summary>
		public SysvarQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the SysvarQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SysvarQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SysvarQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SysvarQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SysvarQuery
		
	#region TransValueFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TransValue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransValueFilters : TransValueFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransValueFilters class.
		/// </summary>
		public TransValueFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransValueFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransValueFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransValueFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransValueFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransValueFilters
	
	#region TransValueQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="TransValueParameterBuilder"/> class
	/// that is used exclusively with a <see cref="TransValue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransValueQuery : TransValueParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransValueQuery class.
		/// </summary>
		public TransValueQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransValueQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransValueQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransValueQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransValueQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransValueQuery
		
	#region TransactionFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Transaction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransactionFilters : TransactionFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionFilters class.
		/// </summary>
		public TransactionFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransactionFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransactionFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransactionFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransactionFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransactionFilters
	
	#region TransactionQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="TransactionParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Transaction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransactionQuery : TransactionParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionQuery class.
		/// </summary>
		public TransactionQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransactionQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransactionQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransactionQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransactionQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransactionQuery
		
	#region ModePaymentFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ModePayment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModePaymentFilters : ModePaymentFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilters class.
		/// </summary>
		public ModePaymentFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModePaymentFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModePaymentFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModePaymentFilters
	
	#region ModePaymentQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ModePaymentParameterBuilder"/> class
	/// that is used exclusively with a <see cref="ModePayment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ModePaymentQuery : ModePaymentParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ModePaymentQuery class.
		/// </summary>
		public ModePaymentQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ModePaymentQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ModePaymentQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ModePaymentQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ModePaymentQuery
		
	#region TransnumFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Transnum"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransnumFilters : TransnumFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransnumFilters class.
		/// </summary>
		public TransnumFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransnumFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransnumFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransnumFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransnumFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransnumFilters
	
	#region TransnumQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="TransnumParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Transnum"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TransnumQuery : TransnumParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransnumQuery class.
		/// </summary>
		public TransnumQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the TransnumQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TransnumQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TransnumQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TransnumQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TransnumQuery
		
	#region MercLocationFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MercLocation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MercLocationFilters : MercLocationFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MercLocationFilters class.
		/// </summary>
		public MercLocationFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the MercLocationFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MercLocationFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MercLocationFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MercLocationFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MercLocationFilters
	
	#region MercLocationQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="MercLocationParameterBuilder"/> class
	/// that is used exclusively with a <see cref="MercLocation"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MercLocationQuery : MercLocationParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MercLocationQuery class.
		/// </summary>
		public MercLocationQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the MercLocationQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MercLocationQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MercLocationQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MercLocationQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MercLocationQuery
		
	#region CurrencyFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Currency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CurrencyFilters : CurrencyFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CurrencyFilters class.
		/// </summary>
		public CurrencyFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the CurrencyFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CurrencyFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CurrencyFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CurrencyFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CurrencyFilters
	
	#region CurrencyQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="CurrencyParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Currency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CurrencyQuery : CurrencyParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CurrencyQuery class.
		/// </summary>
		public CurrencyQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the CurrencyQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CurrencyQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CurrencyQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CurrencyQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CurrencyQuery
		
	#region MenusFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Menus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MenusFilters : MenusFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MenusFilters class.
		/// </summary>
		public MenusFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the MenusFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MenusFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MenusFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MenusFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MenusFilters
	
	#region MenusQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="MenusParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Menus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MenusQuery : MenusParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MenusQuery class.
		/// </summary>
		public MenusQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the MenusQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MenusQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MenusQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MenusQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MenusQuery
		
	#region CustInfoFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CustInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustInfoFilters : CustInfoFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustInfoFilters class.
		/// </summary>
		public CustInfoFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustInfoFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustInfoFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustInfoFilters
	
	#region CustInfoQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="CustInfoParameterBuilder"/> class
	/// that is used exclusively with a <see cref="CustInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustInfoQuery : CustInfoParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustInfoQuery class.
		/// </summary>
		public CustInfoQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustInfoQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustInfoQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustInfoQuery
		
	#region CsCardFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CsCard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CsCardFilters : CsCardFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CsCardFilters class.
		/// </summary>
		public CsCardFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the CsCardFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CsCardFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CsCardFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CsCardFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CsCardFilters
	
	#region CsCardQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="CsCardParameterBuilder"/> class
	/// that is used exclusively with a <see cref="CsCard"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CsCardQuery : CsCardParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CsCardQuery class.
		/// </summary>
		public CsCardQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the CsCardQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CsCardQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CsCardQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CsCardQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CsCardQuery
		
	#region CustomerFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Customer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustomerFilters : CustomerFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomerFilters class.
		/// </summary>
		public CustomerFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustomerFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustomerFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustomerFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustomerFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustomerFilters
	
	#region CustomerQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="CustomerParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Customer"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CustomerQuery : CustomerParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomerQuery class.
		/// </summary>
		public CustomerQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the CustomerQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CustomerQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CustomerQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CustomerQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CustomerQuery
		
	#region AccTransFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccTransFilters : AccTransFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccTransFilters class.
		/// </summary>
		public AccTransFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccTransFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccTransFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccTransFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccTransFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccTransFilters
	
	#region AccTransQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="AccTransParameterBuilder"/> class
	/// that is used exclusively with a <see cref="AccTrans"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccTransQuery : AccTransParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccTransQuery class.
		/// </summary>
		public AccTransQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccTransQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccTransQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccTransQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccTransQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccTransQuery
		
	#region BookAttrFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BookAttr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookAttrFilters : BookAttrFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookAttrFilters class.
		/// </summary>
		public BookAttrFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookAttrFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookAttrFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookAttrFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookAttrFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookAttrFilters
	
	#region BookAttrQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="BookAttrParameterBuilder"/> class
	/// that is used exclusively with a <see cref="BookAttr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BookAttrQuery : BookAttrParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BookAttrQuery class.
		/// </summary>
		public BookAttrQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the BookAttrQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BookAttrQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BookAttrQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BookAttrQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BookAttrQuery
		
	#region AtrCodeFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AtrCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AtrCodeFilters : AtrCodeFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilters class.
		/// </summary>
		public AtrCodeFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AtrCodeFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AtrCodeFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AtrCodeFilters
	
	#region AtrCodeQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="AtrCodeParameterBuilder"/> class
	/// that is used exclusively with a <see cref="AtrCode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AtrCodeQuery : AtrCodeParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AtrCodeQuery class.
		/// </summary>
		public AtrCodeQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AtrCodeQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AtrCodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AtrCodeQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AtrCodeQuery
		
	#region DateFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Date"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DateFilters : DateFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DateFilters class.
		/// </summary>
		public DateFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the DateFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DateFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DateFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DateFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DateFilters
	
	#region DateQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="DateParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Date"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DateQuery : DateParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DateQuery class.
		/// </summary>
		public DateQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the DateQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public DateQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the DateQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public DateQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion DateQuery
		
	#region BarcodeFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Barcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BarcodeFilters : BarcodeFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BarcodeFilters class.
		/// </summary>
		public BarcodeFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the BarcodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BarcodeFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BarcodeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BarcodeFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BarcodeFilters
	
	#region BarcodeQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="BarcodeParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Barcode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BarcodeQuery : BarcodeParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BarcodeQuery class.
		/// </summary>
		public BarcodeQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the BarcodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public BarcodeQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the BarcodeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public BarcodeQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion BarcodeQuery
		
	#region LanguageFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Language"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LanguageFilters : LanguageFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LanguageFilters class.
		/// </summary>
		public LanguageFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the LanguageFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LanguageFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LanguageFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LanguageFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LanguageFilters
	
	#region LanguageQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="LanguageParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Language"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LanguageQuery : LanguageParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LanguageQuery class.
		/// </summary>
		public LanguageQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the LanguageQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LanguageQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LanguageQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LanguageQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LanguageQuery
		
	#region FilesFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Files"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FilesFilters : FilesFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FilesFilters class.
		/// </summary>
		public FilesFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the FilesFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FilesFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FilesFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FilesFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FilesFilters
	
	#region FilesQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="FilesParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Files"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FilesQuery : FilesParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FilesQuery class.
		/// </summary>
		public FilesQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the FilesQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FilesQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FilesQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FilesQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FilesQuery
		
	#region LoanTranFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoanTran"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoanTranFilters : LoanTranFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoanTranFilters class.
		/// </summary>
		public LoanTranFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoanTranFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoanTranFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoanTranFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoanTranFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoanTranFilters
	
	#region LoanTranQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="LoanTranParameterBuilder"/> class
	/// that is used exclusively with a <see cref="LoanTran"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoanTranQuery : LoanTranParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoanTranQuery class.
		/// </summary>
		public LoanTranQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the LoanTranQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LoanTranQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LoanTranQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LoanTranQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LoanTranQuery
		
	#region KitInfoFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KitInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KitInfoFilters : KitInfoFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KitInfoFilters class.
		/// </summary>
		public KitInfoFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the KitInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KitInfoFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KitInfoFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KitInfoFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KitInfoFilters
	
	#region KitInfoQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="KitInfoParameterBuilder"/> class
	/// that is used exclusively with a <see cref="KitInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KitInfoQuery : KitInfoParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KitInfoQuery class.
		/// </summary>
		public KitInfoQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the KitInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KitInfoQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KitInfoQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KitInfoQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KitInfoQuery
		
	#region LocationFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Location"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LocationFilters : LocationFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LocationFilters class.
		/// </summary>
		public LocationFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the LocationFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LocationFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LocationFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LocationFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LocationFilters
	
	#region LocationQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="LocationParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Location"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LocationQuery : LocationParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LocationQuery class.
		/// </summary>
		public LocationQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the LocationQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public LocationQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the LocationQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public LocationQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion LocationQuery
		
	#region FrmTypeFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FrmType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FrmTypeFilters : FrmTypeFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FrmTypeFilters class.
		/// </summary>
		public FrmTypeFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the FrmTypeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FrmTypeFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FrmTypeFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FrmTypeFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FrmTypeFilters
	
	#region FrmTypeQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="FrmTypeParameterBuilder"/> class
	/// that is used exclusively with a <see cref="FrmType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FrmTypeQuery : FrmTypeParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FrmTypeQuery class.
		/// </summary>
		public FrmTypeQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the FrmTypeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FrmTypeQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FrmTypeQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FrmTypeQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FrmTypeQuery
		
	#region KitFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Kit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KitFilters : KitFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KitFilters class.
		/// </summary>
		public KitFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the KitFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KitFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KitFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KitFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KitFilters
	
	#region KitQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="KitParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Kit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KitQuery : KitParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KitQuery class.
		/// </summary>
		public KitQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the KitQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public KitQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the KitQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public KitQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion KitQuery
		
	#region GoodsFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Goods"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsFilters : GoodsFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsFilters class.
		/// </summary>
		public GoodsFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsFilters
	
	#region GoodsQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="GoodsParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Goods"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsQuery : GoodsParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsQuery class.
		/// </summary>
		public GoodsQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsQuery
		
	#region UtilsFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="Utils"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UtilsFilters : UtilsFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UtilsFilters class.
		/// </summary>
		public UtilsFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the UtilsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UtilsFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UtilsFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UtilsFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UtilsFilters
	
	#region UtilsQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="UtilsParameterBuilder"/> class
	/// that is used exclusively with a <see cref="Utils"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UtilsQuery : UtilsParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UtilsQuery class.
		/// </summary>
		public UtilsQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the UtilsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public UtilsQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the UtilsQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public UtilsQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion UtilsQuery
		
	#region GoodsGrpFilters
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GoodsGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsGrpFilters : GoodsGrpFilterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsGrpFilters class.
		/// </summary>
		public GoodsGrpFilters() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsGrpFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsGrpFilters(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsGrpFilters class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsGrpFilters(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsGrpFilters
	
	#region GoodsGrpQuery
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="GoodsGrpParameterBuilder"/> class
	/// that is used exclusively with a <see cref="GoodsGrp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GoodsGrpQuery : GoodsGrpParameterBuilder
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GoodsGrpQuery class.
		/// </summary>
		public GoodsGrpQuery() : base() { }

		/// <summary>
		/// Initializes a new instance of the GoodsGrpQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GoodsGrpQuery(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GoodsGrpQuery class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GoodsGrpQuery(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GoodsGrpQuery
	#endregion

	
}
