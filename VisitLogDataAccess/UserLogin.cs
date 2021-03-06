using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VisitLogDataAccess
{
	/// <summary>
	/// Strongly-typed collection for the UserLogin class.
	/// </summary>
    [Serializable]
	public partial class UserLoginCollection : ActiveList<UserLogin, UserLoginCollection>
	{	   
		public UserLoginCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>UserLoginCollection</returns>
		public UserLoginCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                UserLogin o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the UserLogin table.
	/// </summary>
	[Serializable]
	public partial class UserLogin : ActiveRecord<UserLogin>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public UserLogin()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public UserLogin(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public UserLogin(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public UserLogin(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("UserLogin", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUserLoginId = new TableSchema.TableColumn(schema);
				colvarUserLoginId.ColumnName = "UserLoginId";
				colvarUserLoginId.DataType = DbType.Int32;
				colvarUserLoginId.MaxLength = 0;
				colvarUserLoginId.AutoIncrement = true;
				colvarUserLoginId.IsNullable = false;
				colvarUserLoginId.IsPrimaryKey = true;
				colvarUserLoginId.IsForeignKey = false;
				colvarUserLoginId.IsReadOnly = false;
				colvarUserLoginId.DefaultSetting = @"";
				colvarUserLoginId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserLoginId);
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "UserName";
				colvarUserName.DataType = DbType.AnsiString;
				colvarUserName.MaxLength = 50;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = false;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarPassworrd = new TableSchema.TableColumn(schema);
				colvarPassworrd.ColumnName = "Passworrd";
				colvarPassworrd.DataType = DbType.AnsiString;
				colvarPassworrd.MaxLength = 50;
				colvarPassworrd.AutoIncrement = false;
				colvarPassworrd.IsNullable = false;
				colvarPassworrd.IsPrimaryKey = false;
				colvarPassworrd.IsForeignKey = false;
				colvarPassworrd.IsReadOnly = false;
				colvarPassworrd.DefaultSetting = @"";
				colvarPassworrd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPassworrd);
				
				TableSchema.TableColumn colvarEmailAddress = new TableSchema.TableColumn(schema);
				colvarEmailAddress.ColumnName = "EmailAddress";
				colvarEmailAddress.DataType = DbType.AnsiString;
				colvarEmailAddress.MaxLength = 50;
				colvarEmailAddress.AutoIncrement = false;
				colvarEmailAddress.IsNullable = true;
				colvarEmailAddress.IsPrimaryKey = false;
				colvarEmailAddress.IsForeignKey = false;
				colvarEmailAddress.IsReadOnly = false;
				colvarEmailAddress.DefaultSetting = @"";
				colvarEmailAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmailAddress);
				
				TableSchema.TableColumn colvarUserRoleId = new TableSchema.TableColumn(schema);
				colvarUserRoleId.ColumnName = "UserRoleId";
				colvarUserRoleId.DataType = DbType.Int32;
				colvarUserRoleId.MaxLength = 0;
				colvarUserRoleId.AutoIncrement = false;
				colvarUserRoleId.IsNullable = false;
				colvarUserRoleId.IsPrimaryKey = false;
				colvarUserRoleId.IsForeignKey = true;
				colvarUserRoleId.IsReadOnly = false;
				colvarUserRoleId.DefaultSetting = @"";
				
					colvarUserRoleId.ForeignKeyTableName = "UserRole";
				schema.Columns.Add(colvarUserRoleId);
				
				TableSchema.TableColumn colvarIsActive = new TableSchema.TableColumn(schema);
				colvarIsActive.ColumnName = "IsActive";
				colvarIsActive.DataType = DbType.Boolean;
				colvarIsActive.MaxLength = 0;
				colvarIsActive.AutoIncrement = false;
				colvarIsActive.IsNullable = false;
				colvarIsActive.IsPrimaryKey = false;
				colvarIsActive.IsForeignKey = false;
				colvarIsActive.IsReadOnly = false;
				colvarIsActive.DefaultSetting = @"";
				colvarIsActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsActive);
				
				TableSchema.TableColumn colvarUserType = new TableSchema.TableColumn(schema);
				colvarUserType.ColumnName = "UserType";
				colvarUserType.DataType = DbType.AnsiString;
				colvarUserType.MaxLength = 200;
				colvarUserType.AutoIncrement = false;
				colvarUserType.IsNullable = true;
				colvarUserType.IsPrimaryKey = false;
				colvarUserType.IsForeignKey = false;
				colvarUserType.IsReadOnly = false;
				colvarUserType.DefaultSetting = @"";
				colvarUserType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserType);
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = false;
				colvarEmployeeId.IsNullable = true;
				colvarEmployeeId.IsPrimaryKey = false;
				colvarEmployeeId.IsForeignKey = true;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				
					colvarEmployeeId.ForeignKeyTableName = "tblEmployee";
				schema.Columns.Add(colvarEmployeeId);
				
				TableSchema.TableColumn colvarAttempt = new TableSchema.TableColumn(schema);
				colvarAttempt.ColumnName = "Attempt";
				colvarAttempt.DataType = DbType.Int32;
				colvarAttempt.MaxLength = 0;
				colvarAttempt.AutoIncrement = false;
				colvarAttempt.IsNullable = true;
				colvarAttempt.IsPrimaryKey = false;
				colvarAttempt.IsForeignKey = false;
				colvarAttempt.IsReadOnly = false;
				colvarAttempt.DefaultSetting = @"";
				colvarAttempt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAttempt);
				
				TableSchema.TableColumn colvarIsAdmin = new TableSchema.TableColumn(schema);
				colvarIsAdmin.ColumnName = "IsAdmin";
				colvarIsAdmin.DataType = DbType.Boolean;
				colvarIsAdmin.MaxLength = 0;
				colvarIsAdmin.AutoIncrement = false;
				colvarIsAdmin.IsNullable = true;
				colvarIsAdmin.IsPrimaryKey = false;
				colvarIsAdmin.IsForeignKey = false;
				colvarIsAdmin.IsReadOnly = false;
				colvarIsAdmin.DefaultSetting = @"";
				colvarIsAdmin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsAdmin);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("UserLogin",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("UserLoginId")]
		[Bindable(true)]
		public int UserLoginId 
		{
			get { return GetColumnValue<int>(Columns.UserLoginId); }
			set { SetColumnValue(Columns.UserLoginId, value); }
		}
		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }
			set { SetColumnValue(Columns.UserName, value); }
		}
		  
		[XmlAttribute("Passworrd")]
		[Bindable(true)]
		public string Passworrd 
		{
			get { return GetColumnValue<string>(Columns.Passworrd); }
			set { SetColumnValue(Columns.Passworrd, value); }
		}
		  
		[XmlAttribute("EmailAddress")]
		[Bindable(true)]
		public string EmailAddress 
		{
			get { return GetColumnValue<string>(Columns.EmailAddress); }
			set { SetColumnValue(Columns.EmailAddress, value); }
		}
		  
		[XmlAttribute("UserRoleId")]
		[Bindable(true)]
		public int UserRoleId 
		{
			get { return GetColumnValue<int>(Columns.UserRoleId); }
			set { SetColumnValue(Columns.UserRoleId, value); }
		}
		  
		[XmlAttribute("IsActive")]
		[Bindable(true)]
		public bool IsActive 
		{
			get { return GetColumnValue<bool>(Columns.IsActive); }
			set { SetColumnValue(Columns.IsActive, value); }
		}
		  
		[XmlAttribute("UserType")]
		[Bindable(true)]
		public string UserType 
		{
			get { return GetColumnValue<string>(Columns.UserType); }
			set { SetColumnValue(Columns.UserType, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("Attempt")]
		[Bindable(true)]
		public int? Attempt 
		{
			get { return GetColumnValue<int?>(Columns.Attempt); }
			set { SetColumnValue(Columns.Attempt, value); }
		}
		  
		[XmlAttribute("IsAdmin")]
		[Bindable(true)]
		public bool? IsAdmin 
		{
			get { return GetColumnValue<bool?>(Columns.IsAdmin); }
			set { SetColumnValue(Columns.IsAdmin, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public VisitLogDataAccess.TblActivityCollection TblActivityRecords()
		{
			return new VisitLogDataAccess.TblActivityCollection().Where(TblActivity.Columns.UserID, UserLoginId).Load();
		}
		public VisitLogDataAccess.TblAppDatumCollection TblAppData()
		{
			return new VisitLogDataAccess.TblAppDatumCollection().Where(TblAppDatum.Columns.UserID, UserLoginId).Load();
		}
		public VisitLogDataAccess.TblExceptionCollection TblExceptionRecords()
		{
			return new VisitLogDataAccess.TblExceptionCollection().Where(TblException.Columns.CurrentUserID, UserLoginId).Load();
		}
		public VisitLogDataAccess.TblSystemLoggingCollection TblSystemLoggingRecords()
		{
			return new VisitLogDataAccess.TblSystemLoggingCollection().Where(TblSystemLogging.Columns.UserID, UserLoginId).Load();
		}
		public VisitLogDataAccess.SystemLoggingCollection SystemLoggingRecords()
		{
			return new VisitLogDataAccess.SystemLoggingCollection().Where(SystemLogging.Columns.UserID, UserLoginId).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblEmployee ActiveRecord object related to this UserLogin
		/// 
		/// </summary>
		public VisitLogDataAccess.TblEmployee TblEmployee
		{
			get { return VisitLogDataAccess.TblEmployee.FetchByID(this.EmployeeId); }
			set { SetColumnValue("EmployeeId", value.EmployeeID); }
		}
		
		
		/// <summary>
		/// Returns a UserRole ActiveRecord object related to this UserLogin
		/// 
		/// </summary>
		public VisitLogDataAccess.UserRole UserRole
		{
			get { return VisitLogDataAccess.UserRole.FetchByID(this.UserRoleId); }
			set { SetColumnValue("UserRoleId", value.UserRoleId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUserName,string varPassworrd,string varEmailAddress,int varUserRoleId,bool varIsActive,string varUserType,int? varEmployeeId,int? varAttempt,bool? varIsAdmin)
		{
			UserLogin item = new UserLogin();
			
			item.UserName = varUserName;
			
			item.Passworrd = varPassworrd;
			
			item.EmailAddress = varEmailAddress;
			
			item.UserRoleId = varUserRoleId;
			
			item.IsActive = varIsActive;
			
			item.UserType = varUserType;
			
			item.EmployeeId = varEmployeeId;
			
			item.Attempt = varAttempt;
			
			item.IsAdmin = varIsAdmin;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varUserLoginId,string varUserName,string varPassworrd,string varEmailAddress,int varUserRoleId,bool varIsActive,string varUserType,int? varEmployeeId,int? varAttempt,bool? varIsAdmin)
		{
			UserLogin item = new UserLogin();
			
				item.UserLoginId = varUserLoginId;
			
				item.UserName = varUserName;
			
				item.Passworrd = varPassworrd;
			
				item.EmailAddress = varEmailAddress;
			
				item.UserRoleId = varUserRoleId;
			
				item.IsActive = varIsActive;
			
				item.UserType = varUserType;
			
				item.EmployeeId = varEmployeeId;
			
				item.Attempt = varAttempt;
			
				item.IsAdmin = varIsAdmin;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn UserLoginIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PassworrdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailAddressColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UserRoleIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IsActiveColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn UserTypeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn AttemptColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IsAdminColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string UserLoginId = @"UserLoginId";
			 public static string UserName = @"UserName";
			 public static string Passworrd = @"Passworrd";
			 public static string EmailAddress = @"EmailAddress";
			 public static string UserRoleId = @"UserRoleId";
			 public static string IsActive = @"IsActive";
			 public static string UserType = @"UserType";
			 public static string EmployeeId = @"EmployeeId";
			 public static string Attempt = @"Attempt";
			 public static string IsAdmin = @"IsAdmin";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
