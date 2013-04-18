﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCrawler
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebInformation")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertURL_T(URL_T instance);
    partial void UpdateURL_T(URL_T instance);
    partial void DeleteURL_T(URL_T instance);
    partial void InsertWebID_T(WebID_T instance);
    partial void UpdateWebID_T(WebID_T instance);
    partial void DeleteWebID_T(WebID_T instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertError_T(Error_T instance);
    partial void UpdateError_T(Error_T instance);
    partial void DeleteError_T(Error_T instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::WebCrawler.Properties.Settings.Default.WebInformationConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<URL_T> URL_Ts
		{
			get
			{
				return this.GetTable<URL_T>();
			}
		}
		
		public System.Data.Linq.Table<WebID_T> WebID_Ts
		{
			get
			{
				return this.GetTable<WebID_T>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Error_T> Error_Ts
		{
			get
			{
				return this.GetTable<Error_T>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.URL_T")]
	public partial class URL_T : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _WebID;
		
		private string _URL_VC;
		
		private string _TextContent_VC;
		
		private System.Nullable<System.DateTime> _DateAccessed_DT;
		
		private EntityRef<WebID_T> _WebID_T;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWebIDChanging(long value);
    partial void OnWebIDChanged();
    partial void OnURL_VCChanging(string value);
    partial void OnURL_VCChanged();
    partial void OnTextContent_VCChanging(string value);
    partial void OnTextContent_VCChanged();
    partial void OnDateAccessed_DTChanging(System.Nullable<System.DateTime> value);
    partial void OnDateAccessed_DTChanged();
    #endregion
		
		public URL_T()
		{
			this._WebID_T = default(EntityRef<WebID_T>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long WebID
		{
			get
			{
				return this._WebID;
			}
			set
			{
				if ((this._WebID != value))
				{
					if (this._WebID_T.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnWebIDChanging(value);
					this.SendPropertyChanging();
					this._WebID = value;
					this.SendPropertyChanged("WebID");
					this.OnWebIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL_VC", DbType="VarChar(MAX)")]
		public string URL_VC
		{
			get
			{
				return this._URL_VC;
			}
			set
			{
				if ((this._URL_VC != value))
				{
					this.OnURL_VCChanging(value);
					this.SendPropertyChanging();
					this._URL_VC = value;
					this.SendPropertyChanged("URL_VC");
					this.OnURL_VCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TextContent_VC", DbType="VarChar(MAX)")]
		public string TextContent_VC
		{
			get
			{
				return this._TextContent_VC;
			}
			set
			{
				if ((this._TextContent_VC != value))
				{
					this.OnTextContent_VCChanging(value);
					this.SendPropertyChanging();
					this._TextContent_VC = value;
					this.SendPropertyChanged("TextContent_VC");
					this.OnTextContent_VCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAccessed_DT", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateAccessed_DT
		{
			get
			{
				return this._DateAccessed_DT;
			}
			set
			{
				if ((this._DateAccessed_DT != value))
				{
					this.OnDateAccessed_DTChanging(value);
					this.SendPropertyChanging();
					this._DateAccessed_DT = value;
					this.SendPropertyChanged("DateAccessed_DT");
					this.OnDateAccessed_DTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="WebID_T_URL_T", Storage="_WebID_T", ThisKey="WebID", OtherKey="Entry_ID", IsForeignKey=true)]
		public WebID_T WebID_T
		{
			get
			{
				return this._WebID_T.Entity;
			}
			set
			{
				WebID_T previousValue = this._WebID_T.Entity;
				if (((previousValue != value) 
							|| (this._WebID_T.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._WebID_T.Entity = null;
						previousValue.URL_T = null;
					}
					this._WebID_T.Entity = value;
					if ((value != null))
					{
						value.URL_T = this;
						this._WebID = value.Entry_ID;
					}
					else
					{
						this._WebID = default(long);
					}
					this.SendPropertyChanged("WebID_T");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WebID_T")]
	public partial class WebID_T : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Entry_ID;
		
		private string _URL;
		
		private string _Contents_VC;
		
		private System.Nullable<System.DateTime> _DateAccessed_DT;
		
		private EntityRef<URL_T> _URL_T;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEntry_IDChanging(long value);
    partial void OnEntry_IDChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnContents_VCChanging(string value);
    partial void OnContents_VCChanged();
    partial void OnDateAccessed_DTChanging(System.Nullable<System.DateTime> value);
    partial void OnDateAccessed_DTChanged();
    #endregion
		
		public WebID_T()
		{
			this._URL_T = default(EntityRef<URL_T>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Entry_ID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Entry_ID
		{
			get
			{
				return this._Entry_ID;
			}
			set
			{
				if ((this._Entry_ID != value))
				{
					this.OnEntry_IDChanging(value);
					this.SendPropertyChanging();
					this._Entry_ID = value;
					this.SendPropertyChanged("Entry_ID");
					this.OnEntry_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="VarChar(50)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contents_VC", DbType="VarChar(MAX)")]
		public string Contents_VC
		{
			get
			{
				return this._Contents_VC;
			}
			set
			{
				if ((this._Contents_VC != value))
				{
					this.OnContents_VCChanging(value);
					this.SendPropertyChanging();
					this._Contents_VC = value;
					this.SendPropertyChanged("Contents_VC");
					this.OnContents_VCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAccessed_DT", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateAccessed_DT
		{
			get
			{
				return this._DateAccessed_DT;
			}
			set
			{
				if ((this._DateAccessed_DT != value))
				{
					this.OnDateAccessed_DTChanging(value);
					this.SendPropertyChanging();
					this._DateAccessed_DT = value;
					this.SendPropertyChanged("DateAccessed_DT");
					this.OnDateAccessed_DTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="WebID_T_URL_T", Storage="_URL_T", ThisKey="Entry_ID", OtherKey="WebID", IsUnique=true, IsForeignKey=false)]
		public URL_T URL_T
		{
			get
			{
				return this._URL_T.Entity;
			}
			set
			{
				URL_T previousValue = this._URL_T.Entity;
				if (((previousValue != value) 
							|| (this._URL_T.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._URL_T.Entity = null;
						previousValue.WebID_T = null;
					}
					this._URL_T.Entity = value;
					if ((value != null))
					{
						value.WebID_T = this;
					}
					this.SendPropertyChanged("URL_T");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private string _CustomerID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private string _ShipName;
		
		private string _ShipAddress;
		
		private string _ShipCity;
		
		private string _ShipCountry;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnShipNameChanging(string value);
    partial void OnShipNameChanged();
    partial void OnShipAddressChanging(string value);
    partial void OnShipAddressChanged();
    partial void OnShipCityChanging(string value);
    partial void OnShipCityChanged();
    partial void OnShipCountryChanging(string value);
    partial void OnShipCountryChanged();
    #endregion
		
		public Order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="VarChar(50)")]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipName", DbType="VarChar(50)")]
		public string ShipName
		{
			get
			{
				return this._ShipName;
			}
			set
			{
				if ((this._ShipName != value))
				{
					this.OnShipNameChanging(value);
					this.SendPropertyChanging();
					this._ShipName = value;
					this.SendPropertyChanged("ShipName");
					this.OnShipNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipAddress", DbType="VarChar(50)")]
		public string ShipAddress
		{
			get
			{
				return this._ShipAddress;
			}
			set
			{
				if ((this._ShipAddress != value))
				{
					this.OnShipAddressChanging(value);
					this.SendPropertyChanging();
					this._ShipAddress = value;
					this.SendPropertyChanged("ShipAddress");
					this.OnShipAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipCity", DbType="VarChar(50)")]
		public string ShipCity
		{
			get
			{
				return this._ShipCity;
			}
			set
			{
				if ((this._ShipCity != value))
				{
					this.OnShipCityChanging(value);
					this.SendPropertyChanging();
					this._ShipCity = value;
					this.SendPropertyChanged("ShipCity");
					this.OnShipCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipCountry", DbType="VarChar(50)")]
		public string ShipCountry
		{
			get
			{
				return this._ShipCountry;
			}
			set
			{
				if ((this._ShipCountry != value))
				{
					this.OnShipCountryChanging(value);
					this.SendPropertyChanging();
					this._ShipCountry = value;
					this.SendPropertyChanged("ShipCountry");
					this.OnShipCountryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Error_T")]
	public partial class Error_T : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Error_ID;
		
		private System.Nullable<System.DateTime> _DateCreated_DT;
		
		private string _Message_VC;
		
		private string _ExceptionThrower_VC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnError_IDChanging(int value);
    partial void OnError_IDChanged();
    partial void OnDateCreated_DTChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCreated_DTChanged();
    partial void OnMessage_VCChanging(string value);
    partial void OnMessage_VCChanged();
    partial void OnExceptionThrower_VCChanging(string value);
    partial void OnExceptionThrower_VCChanged();
    #endregion
		
		public Error_T()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Error_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Error_ID
		{
			get
			{
				return this._Error_ID;
			}
			set
			{
				if ((this._Error_ID != value))
				{
					this.OnError_IDChanging(value);
					this.SendPropertyChanging();
					this._Error_ID = value;
					this.SendPropertyChanged("Error_ID");
					this.OnError_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated_DT", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCreated_DT
		{
			get
			{
				return this._DateCreated_DT;
			}
			set
			{
				if ((this._DateCreated_DT != value))
				{
					this.OnDateCreated_DTChanging(value);
					this.SendPropertyChanging();
					this._DateCreated_DT = value;
					this.SendPropertyChanged("DateCreated_DT");
					this.OnDateCreated_DTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message_VC", DbType="VarChar(50)")]
		public string Message_VC
		{
			get
			{
				return this._Message_VC;
			}
			set
			{
				if ((this._Message_VC != value))
				{
					this.OnMessage_VCChanging(value);
					this.SendPropertyChanging();
					this._Message_VC = value;
					this.SendPropertyChanged("Message_VC");
					this.OnMessage_VCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExceptionThrower_VC", DbType="VarChar(MAX)")]
		public string ExceptionThrower_VC
		{
			get
			{
				return this._ExceptionThrower_VC;
			}
			set
			{
				if ((this._ExceptionThrower_VC != value))
				{
					this.OnExceptionThrower_VCChanging(value);
					this.SendPropertyChanging();
					this._ExceptionThrower_VC = value;
					this.SendPropertyChanged("ExceptionThrower_VC");
					this.OnExceptionThrower_VCChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
