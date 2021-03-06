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
	/// Strongly-typed collection for the UserMenu class.
	/// </summary>
    [Serializable]
	public partial class UserMenuCollection : ActiveList<UserMenu, UserMenuCollection>
	{	   
		public UserMenuCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>UserMenuCollection</returns>
		public UserMenuCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                UserMenu o = this[i];
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
	/// This is an ActiveRecord class which wraps the UserMenu table.
	/// </summary>
	[Serializable]
	public partial class UserMenu : ActiveRecord<UserMenu>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public UserMenu()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public UserMenu(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public UserMenu(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public UserMenu(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("UserMenu", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUserMenuId = new TableSchema.TableColumn(schema);
				colvarUserMenuId.ColumnName = "UserMenuId";
				colvarUserMenuId.DataType = DbType.Int32;
				colvarUserMenuId.MaxLength = 0;
				colvarUserMenuId.AutoIncrement = true;
				colvarUserMenuId.IsNullable = false;
				colvarUserMenuId.IsPrimaryKey = true;
				colvarUserMenuId.IsForeignKey = false;
				colvarUserMenuId.IsReadOnly = false;
				colvarUserMenuId.DefaultSetting = @"";
				colvarUserMenuId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserMenuId);
				
				TableSchema.TableColumn colvarMenuTitle = new TableSchema.TableColumn(schema);
				colvarMenuTitle.ColumnName = "MenuTitle";
				colvarMenuTitle.DataType = DbType.AnsiString;
				colvarMenuTitle.MaxLength = 50;
				colvarMenuTitle.AutoIncrement = false;
				colvarMenuTitle.IsNullable = false;
				colvarMenuTitle.IsPrimaryKey = false;
				colvarMenuTitle.IsForeignKey = false;
				colvarMenuTitle.IsReadOnly = false;
				colvarMenuTitle.DefaultSetting = @"";
				colvarMenuTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenuTitle);
				
				TableSchema.TableColumn colvarPageUrl = new TableSchema.TableColumn(schema);
				colvarPageUrl.ColumnName = "PageUrl";
				colvarPageUrl.DataType = DbType.AnsiString;
				colvarPageUrl.MaxLength = 50;
				colvarPageUrl.AutoIncrement = false;
				colvarPageUrl.IsNullable = false;
				colvarPageUrl.IsPrimaryKey = false;
				colvarPageUrl.IsForeignKey = false;
				colvarPageUrl.IsReadOnly = false;
				colvarPageUrl.DefaultSetting = @"";
				colvarPageUrl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPageUrl);
				
				TableSchema.TableColumn colvarPrivillageId = new TableSchema.TableColumn(schema);
				colvarPrivillageId.ColumnName = "PrivillageId";
				colvarPrivillageId.DataType = DbType.Int32;
				colvarPrivillageId.MaxLength = 0;
				colvarPrivillageId.AutoIncrement = false;
				colvarPrivillageId.IsNullable = false;
				colvarPrivillageId.IsPrimaryKey = false;
				colvarPrivillageId.IsForeignKey = false;
				colvarPrivillageId.IsReadOnly = false;
				colvarPrivillageId.DefaultSetting = @"";
				colvarPrivillageId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrivillageId);
				
				TableSchema.TableColumn colvarIsTopMenu = new TableSchema.TableColumn(schema);
				colvarIsTopMenu.ColumnName = "IsTopMenu";
				colvarIsTopMenu.DataType = DbType.Boolean;
				colvarIsTopMenu.MaxLength = 0;
				colvarIsTopMenu.AutoIncrement = false;
				colvarIsTopMenu.IsNullable = false;
				colvarIsTopMenu.IsPrimaryKey = false;
				colvarIsTopMenu.IsForeignKey = false;
				colvarIsTopMenu.IsReadOnly = false;
				
						colvarIsTopMenu.DefaultSetting = @"((0))";
				colvarIsTopMenu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsTopMenu);
				
				TableSchema.TableColumn colvarTopMenuTitle = new TableSchema.TableColumn(schema);
				colvarTopMenuTitle.ColumnName = "TopMenuTitle";
				colvarTopMenuTitle.DataType = DbType.AnsiString;
				colvarTopMenuTitle.MaxLength = 50;
				colvarTopMenuTitle.AutoIncrement = false;
				colvarTopMenuTitle.IsNullable = false;
				colvarTopMenuTitle.IsPrimaryKey = false;
				colvarTopMenuTitle.IsForeignKey = false;
				colvarTopMenuTitle.IsReadOnly = false;
				
						colvarTopMenuTitle.DefaultSetting = @"('Not Defined')";
				colvarTopMenuTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTopMenuTitle);
				
				TableSchema.TableColumn colvarTopMenuDisplayOrder = new TableSchema.TableColumn(schema);
				colvarTopMenuDisplayOrder.ColumnName = "TopMenuDisplayOrder";
				colvarTopMenuDisplayOrder.DataType = DbType.Int32;
				colvarTopMenuDisplayOrder.MaxLength = 0;
				colvarTopMenuDisplayOrder.AutoIncrement = false;
				colvarTopMenuDisplayOrder.IsNullable = true;
				colvarTopMenuDisplayOrder.IsPrimaryKey = false;
				colvarTopMenuDisplayOrder.IsForeignKey = false;
				colvarTopMenuDisplayOrder.IsReadOnly = false;
				
						colvarTopMenuDisplayOrder.DefaultSetting = @"((100000))";
				colvarTopMenuDisplayOrder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTopMenuDisplayOrder);
				
				TableSchema.TableColumn colvarSubMenuDisplayOrder = new TableSchema.TableColumn(schema);
				colvarSubMenuDisplayOrder.ColumnName = "SubMenuDisplayOrder";
				colvarSubMenuDisplayOrder.DataType = DbType.Int32;
				colvarSubMenuDisplayOrder.MaxLength = 0;
				colvarSubMenuDisplayOrder.AutoIncrement = false;
				colvarSubMenuDisplayOrder.IsNullable = true;
				colvarSubMenuDisplayOrder.IsPrimaryKey = false;
				colvarSubMenuDisplayOrder.IsForeignKey = false;
				colvarSubMenuDisplayOrder.IsReadOnly = false;
				colvarSubMenuDisplayOrder.DefaultSetting = @"";
				colvarSubMenuDisplayOrder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSubMenuDisplayOrder);
				
				TableSchema.TableColumn colvarTopMenuId = new TableSchema.TableColumn(schema);
				colvarTopMenuId.ColumnName = "TopMenuId";
				colvarTopMenuId.DataType = DbType.Int32;
				colvarTopMenuId.MaxLength = 0;
				colvarTopMenuId.AutoIncrement = false;
				colvarTopMenuId.IsNullable = true;
				colvarTopMenuId.IsPrimaryKey = false;
				colvarTopMenuId.IsForeignKey = true;
				colvarTopMenuId.IsReadOnly = false;
				colvarTopMenuId.DefaultSetting = @"";
				
					colvarTopMenuId.ForeignKeyTableName = "UserMenu";
				schema.Columns.Add(colvarTopMenuId);
				
				TableSchema.TableColumn colvarIsActive = new TableSchema.TableColumn(schema);
				colvarIsActive.ColumnName = "IsActive";
				colvarIsActive.DataType = DbType.Boolean;
				colvarIsActive.MaxLength = 0;
				colvarIsActive.AutoIncrement = false;
				colvarIsActive.IsNullable = false;
				colvarIsActive.IsPrimaryKey = false;
				colvarIsActive.IsForeignKey = false;
				colvarIsActive.IsReadOnly = false;
				
						colvarIsActive.DefaultSetting = @"((1))";
				colvarIsActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsActive);
				
				TableSchema.TableColumn colvarShortcutKey = new TableSchema.TableColumn(schema);
				colvarShortcutKey.ColumnName = "ShortcutKey";
				colvarShortcutKey.DataType = DbType.AnsiString;
				colvarShortcutKey.MaxLength = 50;
				colvarShortcutKey.AutoIncrement = false;
				colvarShortcutKey.IsNullable = true;
				colvarShortcutKey.IsPrimaryKey = false;
				colvarShortcutKey.IsForeignKey = false;
				colvarShortcutKey.IsReadOnly = false;
				colvarShortcutKey.DefaultSetting = @"";
				colvarShortcutKey.ForeignKeyTableName = "";
				schema.Columns.Add(colvarShortcutKey);
				
				TableSchema.TableColumn colvarModuleID = new TableSchema.TableColumn(schema);
				colvarModuleID.ColumnName = "ModuleID";
				colvarModuleID.DataType = DbType.Int32;
				colvarModuleID.MaxLength = 0;
				colvarModuleID.AutoIncrement = false;
				colvarModuleID.IsNullable = true;
				colvarModuleID.IsPrimaryKey = false;
				colvarModuleID.IsForeignKey = true;
				colvarModuleID.IsReadOnly = false;
				colvarModuleID.DefaultSetting = @"";
				
					colvarModuleID.ForeignKeyTableName = "tblModule";
				schema.Columns.Add(colvarModuleID);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("UserMenu",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("UserMenuId")]
		[Bindable(true)]
		public int UserMenuId 
		{
			get { return GetColumnValue<int>(Columns.UserMenuId); }
			set { SetColumnValue(Columns.UserMenuId, value); }
		}
		  
		[XmlAttribute("MenuTitle")]
		[Bindable(true)]
		public string MenuTitle 
		{
			get { return GetColumnValue<string>(Columns.MenuTitle); }
			set { SetColumnValue(Columns.MenuTitle, value); }
		}
		  
		[XmlAttribute("PageUrl")]
		[Bindable(true)]
		public string PageUrl 
		{
			get { return GetColumnValue<string>(Columns.PageUrl); }
			set { SetColumnValue(Columns.PageUrl, value); }
		}
		  
		[XmlAttribute("PrivillageId")]
		[Bindable(true)]
		public int PrivillageId 
		{
			get { return GetColumnValue<int>(Columns.PrivillageId); }
			set { SetColumnValue(Columns.PrivillageId, value); }
		}
		  
		[XmlAttribute("IsTopMenu")]
		[Bindable(true)]
		public bool IsTopMenu 
		{
			get { return GetColumnValue<bool>(Columns.IsTopMenu); }
			set { SetColumnValue(Columns.IsTopMenu, value); }
		}
		  
		[XmlAttribute("TopMenuTitle")]
		[Bindable(true)]
		public string TopMenuTitle 
		{
			get { return GetColumnValue<string>(Columns.TopMenuTitle); }
			set { SetColumnValue(Columns.TopMenuTitle, value); }
		}
		  
		[XmlAttribute("TopMenuDisplayOrder")]
		[Bindable(true)]
		public int? TopMenuDisplayOrder 
		{
			get { return GetColumnValue<int?>(Columns.TopMenuDisplayOrder); }
			set { SetColumnValue(Columns.TopMenuDisplayOrder, value); }
		}
		  
		[XmlAttribute("SubMenuDisplayOrder")]
		[Bindable(true)]
		public int? SubMenuDisplayOrder 
		{
			get { return GetColumnValue<int?>(Columns.SubMenuDisplayOrder); }
			set { SetColumnValue(Columns.SubMenuDisplayOrder, value); }
		}
		  
		[XmlAttribute("TopMenuId")]
		[Bindable(true)]
		public int? TopMenuId 
		{
			get { return GetColumnValue<int?>(Columns.TopMenuId); }
			set { SetColumnValue(Columns.TopMenuId, value); }
		}
		  
		[XmlAttribute("IsActive")]
		[Bindable(true)]
		public bool IsActive 
		{
			get { return GetColumnValue<bool>(Columns.IsActive); }
			set { SetColumnValue(Columns.IsActive, value); }
		}
		  
		[XmlAttribute("ShortcutKey")]
		[Bindable(true)]
		public string ShortcutKey 
		{
			get { return GetColumnValue<string>(Columns.ShortcutKey); }
			set { SetColumnValue(Columns.ShortcutKey, value); }
		}
		  
		[XmlAttribute("ModuleID")]
		[Bindable(true)]
		public int? ModuleID 
		{
			get { return GetColumnValue<int?>(Columns.ModuleID); }
			set { SetColumnValue(Columns.ModuleID, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public VisitLogDataAccess.UserMenuCollection ChildUserMenuRecords()
		{
			return new VisitLogDataAccess.UserMenuCollection().Where(UserMenu.Columns.TopMenuId, UserMenuId).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblModule ActiveRecord object related to this UserMenu
		/// 
		/// </summary>
		public VisitLogDataAccess.TblModule TblModule
		{
			get { return VisitLogDataAccess.TblModule.FetchByID(this.ModuleID); }
			set { SetColumnValue("ModuleID", value.ModuleID); }
		}
		
		
		/// <summary>
		/// Returns a UserMenu ActiveRecord object related to this UserMenu
		/// 
		/// </summary>
		public VisitLogDataAccess.UserMenu ParentUserMenu
		{
			get { return VisitLogDataAccess.UserMenu.FetchByID(this.TopMenuId); }
			set { SetColumnValue("TopMenuId", value.UserMenuId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMenuTitle,string varPageUrl,int varPrivillageId,bool varIsTopMenu,string varTopMenuTitle,int? varTopMenuDisplayOrder,int? varSubMenuDisplayOrder,int? varTopMenuId,bool varIsActive,string varShortcutKey,int? varModuleID)
		{
			UserMenu item = new UserMenu();
			
			item.MenuTitle = varMenuTitle;
			
			item.PageUrl = varPageUrl;
			
			item.PrivillageId = varPrivillageId;
			
			item.IsTopMenu = varIsTopMenu;
			
			item.TopMenuTitle = varTopMenuTitle;
			
			item.TopMenuDisplayOrder = varTopMenuDisplayOrder;
			
			item.SubMenuDisplayOrder = varSubMenuDisplayOrder;
			
			item.TopMenuId = varTopMenuId;
			
			item.IsActive = varIsActive;
			
			item.ShortcutKey = varShortcutKey;
			
			item.ModuleID = varModuleID;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varUserMenuId,string varMenuTitle,string varPageUrl,int varPrivillageId,bool varIsTopMenu,string varTopMenuTitle,int? varTopMenuDisplayOrder,int? varSubMenuDisplayOrder,int? varTopMenuId,bool varIsActive,string varShortcutKey,int? varModuleID)
		{
			UserMenu item = new UserMenu();
			
				item.UserMenuId = varUserMenuId;
			
				item.MenuTitle = varMenuTitle;
			
				item.PageUrl = varPageUrl;
			
				item.PrivillageId = varPrivillageId;
			
				item.IsTopMenu = varIsTopMenu;
			
				item.TopMenuTitle = varTopMenuTitle;
			
				item.TopMenuDisplayOrder = varTopMenuDisplayOrder;
			
				item.SubMenuDisplayOrder = varSubMenuDisplayOrder;
			
				item.TopMenuId = varTopMenuId;
			
				item.IsActive = varIsActive;
			
				item.ShortcutKey = varShortcutKey;
			
				item.ModuleID = varModuleID;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn UserMenuIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MenuTitleColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PageUrlColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PrivillageIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IsTopMenuColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TopMenuTitleColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TopMenuDisplayOrderColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SubMenuDisplayOrderColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TopMenuIdColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IsActiveColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ShortcutKeyColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ModuleIDColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string UserMenuId = @"UserMenuId";
			 public static string MenuTitle = @"MenuTitle";
			 public static string PageUrl = @"PageUrl";
			 public static string PrivillageId = @"PrivillageId";
			 public static string IsTopMenu = @"IsTopMenu";
			 public static string TopMenuTitle = @"TopMenuTitle";
			 public static string TopMenuDisplayOrder = @"TopMenuDisplayOrder";
			 public static string SubMenuDisplayOrder = @"SubMenuDisplayOrder";
			 public static string TopMenuId = @"TopMenuId";
			 public static string IsActive = @"IsActive";
			 public static string ShortcutKey = @"ShortcutKey";
			 public static string ModuleID = @"ModuleID";
						
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
