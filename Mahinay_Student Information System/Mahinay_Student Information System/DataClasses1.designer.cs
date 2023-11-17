﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mahinay_Student_Information_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_student")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertinfo(info instance);
    partial void Updateinfo(info instance);
    partial void Deleteinfo(info instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Mahinay_Student_Information_System.Properties.Settings.Default.db_studentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<info> infos
		{
			get
			{
				return this.GetTable<info>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_delete")]
		public int sp_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_save")]
		public int sp_save([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> bday, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string s_address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fname, lname, bday, s_address, phone, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_search")]
		public ISingleResult<sp_searchResult> sp_search([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string key)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), key);
			return ((ISingleResult<sp_searchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_update")]
		public int sp_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> bday, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string s_address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, fname, lname, bday, s_address, phone, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_view")]
		public ISingleResult<sp_viewResult> sp_view()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_viewResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.info")]
	public partial class info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _stud_no;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<System.DateTime> _bday;
		
		private string _s_address;
		
		private string _phone;
		
		private string _email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onstud_noChanging(string value);
    partial void Onstud_noChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OnbdayChanging(System.Nullable<System.DateTime> value);
    partial void OnbdayChanged();
    partial void Ons_addressChanging(string value);
    partial void Ons_addressChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stud_no", AutoSync=AutoSync.Always, DbType="VarChar(12)", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public string stud_no
		{
			get
			{
				return this._stud_no;
			}
			set
			{
				if ((this._stud_no != value))
				{
					this.Onstud_noChanging(value);
					this.SendPropertyChanging();
					this._stud_no = value;
					this.SendPropertyChanged("stud_no");
					this.Onstud_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bday", DbType="Date")]
		public System.Nullable<System.DateTime> bday
		{
			get
			{
				return this._bday;
			}
			set
			{
				if ((this._bday != value))
				{
					this.OnbdayChanging(value);
					this.SendPropertyChanging();
					this._bday = value;
					this.SendPropertyChanged("bday");
					this.OnbdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_s_address", DbType="VarChar(50)")]
		public string s_address
		{
			get
			{
				return this._s_address;
			}
			set
			{
				if ((this._s_address != value))
				{
					this.Ons_addressChanging(value);
					this.SendPropertyChanging();
					this._s_address = value;
					this.SendPropertyChanged("s_address");
					this.Ons_addressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(50)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
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
	
	public partial class sp_searchResult
	{
		
		private int _ID;
		
		private string _STUD_NO;
		
		private string _FIRST_NAME;
		
		private string _LAST_NAME;
		
		private System.Nullable<System.DateTime> _BIRTH_DATE;
		
		private System.Nullable<int> _AGE;
		
		private string _ADDRESS;
		
		private string _PHONE;
		
		private string _EMAIL;
		
		public sp_searchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STUD_NO", DbType="VarChar(12)")]
		public string STUD_NO
		{
			get
			{
				return this._STUD_NO;
			}
			set
			{
				if ((this._STUD_NO != value))
				{
					this._STUD_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[FIRST NAME]", Storage="_FIRST_NAME", DbType="VarChar(50)")]
		public string FIRST_NAME
		{
			get
			{
				return this._FIRST_NAME;
			}
			set
			{
				if ((this._FIRST_NAME != value))
				{
					this._FIRST_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[LAST NAME]", Storage="_LAST_NAME", DbType="VarChar(50)")]
		public string LAST_NAME
		{
			get
			{
				return this._LAST_NAME;
			}
			set
			{
				if ((this._LAST_NAME != value))
				{
					this._LAST_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BIRTH DATE]", Storage="_BIRTH_DATE", DbType="Date")]
		public System.Nullable<System.DateTime> BIRTH_DATE
		{
			get
			{
				return this._BIRTH_DATE;
			}
			set
			{
				if ((this._BIRTH_DATE != value))
				{
					this._BIRTH_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AGE", DbType="Int")]
		public System.Nullable<int> AGE
		{
			get
			{
				return this._AGE;
			}
			set
			{
				if ((this._AGE != value))
				{
					this._AGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADDRESS", DbType="VarChar(50)")]
		public string ADDRESS
		{
			get
			{
				return this._ADDRESS;
			}
			set
			{
				if ((this._ADDRESS != value))
				{
					this._ADDRESS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE", DbType="VarChar(50)")]
		public string PHONE
		{
			get
			{
				return this._PHONE;
			}
			set
			{
				if ((this._PHONE != value))
				{
					this._PHONE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this._EMAIL = value;
				}
			}
		}
	}
	
	public partial class sp_viewResult
	{
		
		private int _ID;
		
		private string _STUD_NO;
		
		private string _FIRST_NAME;
		
		private string _LAST_NAME;
		
		private System.Nullable<System.DateTime> _BIRTH_DATE;
		
		private System.Nullable<int> _AGE;
		
		private string _ADDRESS;
		
		private string _PHONE;
		
		private string _EMAIL;
		
		public sp_viewResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STUD_NO", DbType="VarChar(12)")]
		public string STUD_NO
		{
			get
			{
				return this._STUD_NO;
			}
			set
			{
				if ((this._STUD_NO != value))
				{
					this._STUD_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[FIRST NAME]", Storage="_FIRST_NAME", DbType="VarChar(50)")]
		public string FIRST_NAME
		{
			get
			{
				return this._FIRST_NAME;
			}
			set
			{
				if ((this._FIRST_NAME != value))
				{
					this._FIRST_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[LAST NAME]", Storage="_LAST_NAME", DbType="VarChar(50)")]
		public string LAST_NAME
		{
			get
			{
				return this._LAST_NAME;
			}
			set
			{
				if ((this._LAST_NAME != value))
				{
					this._LAST_NAME = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BIRTH DATE]", Storage="_BIRTH_DATE", DbType="Date")]
		public System.Nullable<System.DateTime> BIRTH_DATE
		{
			get
			{
				return this._BIRTH_DATE;
			}
			set
			{
				if ((this._BIRTH_DATE != value))
				{
					this._BIRTH_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AGE", DbType="Int")]
		public System.Nullable<int> AGE
		{
			get
			{
				return this._AGE;
			}
			set
			{
				if ((this._AGE != value))
				{
					this._AGE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ADDRESS", DbType="VarChar(50)")]
		public string ADDRESS
		{
			get
			{
				return this._ADDRESS;
			}
			set
			{
				if ((this._ADDRESS != value))
				{
					this._ADDRESS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE", DbType="VarChar(50)")]
		public string PHONE
		{
			get
			{
				return this._PHONE;
			}
			set
			{
				if ((this._PHONE != value))
				{
					this._PHONE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(50)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this._EMAIL = value;
				}
			}
		}
	}
}
#pragma warning restore 1591