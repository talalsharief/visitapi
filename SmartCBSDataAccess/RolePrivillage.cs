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
namespace SmartCBSDataAccess
{
	/// <summary>
	/// Strongly-typed collection for the RolePrivillage class.
	/// </summary>
    [Serializable]
	public partial class RolePrivillageCollection : ActiveList<RolePrivillage, RolePrivillageCollection>
	{	   
		public RolePrivillageCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RolePrivillageCollection</returns>
		public RolePrivillageCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RolePrivillage o = this[i];
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
	/// This is an ActiveRecord class which wraps the RolePrivillage table.
	/// </summary>
	[Serializable]
	public partial class RolePrivillage : ActiveRecord<RolePrivillage>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RolePrivillage()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RolePrivillage(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RolePrivillage(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RolePrivillage(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RolePrivillage", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRolePrivillageId = new TableSchema.TableColumn(schema);
				colvarRolePrivillageId.ColumnName = "RolePrivillageId";
				colvarRolePrivillageId.DataType = DbType.Int32;
				colvarRolePrivillageId.MaxLength = 0;
				colvarRolePrivillageId.AutoIncrement = true;
				colvarRolePrivillageId.IsNullable = false;
				colvarRolePrivillageId.IsPrimaryKey = true;
				colvarRolePrivillageId.IsForeignKey = false;
				colvarRolePrivillageId.IsReadOnly = false;
				colvarRolePrivillageId.DefaultSetting = @"";
				colvarRolePrivillageId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRolePrivillageId);
				
				TableSchema.TableColumn colvarPrivillageId = new TableSchema.TableColumn(schema);
				colvarPrivillageId.ColumnName = "PrivillageId";
				colvarPrivillageId.DataType = DbType.Int32;
				colvarPrivillageId.MaxLength = 0;
				colvarPrivillageId.AutoIncrement = false;
				colvarPrivillageId.IsNullable = true;
				colvarPrivillageId.IsPrimaryKey = false;
				colvarPrivillageId.IsForeignKey = false;
				colvarPrivillageId.IsReadOnly = false;
				colvarPrivillageId.DefaultSetting = @"";
				colvarPrivillageId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrivillageId);
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Int32;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = false;
				colvarRoleId.IsNullable = true;
				colvarRoleId.IsPrimaryKey = false;
				colvarRoleId.IsForeignKey = true;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				
					colvarRoleId.ForeignKeyTableName = "UserRole";
				schema.Columns.Add(colvarRoleId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("RolePrivillage",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RolePrivillageId")]
		[Bindable(true)]
		public int RolePrivillageId 
		{
			get { return GetColumnValue<int>(Columns.RolePrivillageId); }
			set { SetColumnValue(Columns.RolePrivillageId, value); }
		}
		  
		[XmlAttribute("PrivillageId")]
		[Bindable(true)]
		public int? PrivillageId 
		{
			get { return GetColumnValue<int?>(Columns.PrivillageId); }
			set { SetColumnValue(Columns.PrivillageId, value); }
		}
		  
		[XmlAttribute("RoleId")]
		[Bindable(true)]
		public int? RoleId 
		{
			get { return GetColumnValue<int?>(Columns.RoleId); }
			set { SetColumnValue(Columns.RoleId, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a UserRole ActiveRecord object related to this RolePrivillage
		/// 
		/// </summary>
		public SmartCBSDataAccess.UserRole UserRole
		{
			get { return SmartCBSDataAccess.UserRole.FetchByID(this.RoleId); }
			set { SetColumnValue("RoleId", value.UserRoleId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varPrivillageId,int? varRoleId)
		{
			RolePrivillage item = new RolePrivillage();
			
			item.PrivillageId = varPrivillageId;
			
			item.RoleId = varRoleId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRolePrivillageId,int? varPrivillageId,int? varRoleId)
		{
			RolePrivillage item = new RolePrivillage();
			
				item.RolePrivillageId = varRolePrivillageId;
			
				item.PrivillageId = varPrivillageId;
			
				item.RoleId = varRoleId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RolePrivillageIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PrivillageIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn RoleIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RolePrivillageId = @"RolePrivillageId";
			 public static string PrivillageId = @"PrivillageId";
			 public static string RoleId = @"RoleId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}