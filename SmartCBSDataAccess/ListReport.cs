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
	/// Strongly-typed collection for the ListReport class.
	/// </summary>
    [Serializable]
	public partial class ListReportCollection : ActiveList<ListReport, ListReportCollection>
	{	   
		public ListReportCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ListReportCollection</returns>
		public ListReportCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ListReport o = this[i];
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
	/// This is an ActiveRecord class which wraps the ListReport table.
	/// </summary>
	[Serializable]
	public partial class ListReport : ActiveRecord<ListReport>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ListReport()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ListReport(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ListReport(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ListReport(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ListReport", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarListReportId = new TableSchema.TableColumn(schema);
				colvarListReportId.ColumnName = "ListReportId";
				colvarListReportId.DataType = DbType.Int32;
				colvarListReportId.MaxLength = 0;
				colvarListReportId.AutoIncrement = true;
				colvarListReportId.IsNullable = false;
				colvarListReportId.IsPrimaryKey = true;
				colvarListReportId.IsForeignKey = false;
				colvarListReportId.IsReadOnly = false;
				colvarListReportId.DefaultSetting = @"";
				colvarListReportId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarListReportId);
				
				TableSchema.TableColumn colvarListReportName = new TableSchema.TableColumn(schema);
				colvarListReportName.ColumnName = "ListReportName";
				colvarListReportName.DataType = DbType.AnsiString;
				colvarListReportName.MaxLength = 50;
				colvarListReportName.AutoIncrement = false;
				colvarListReportName.IsNullable = true;
				colvarListReportName.IsPrimaryKey = false;
				colvarListReportName.IsForeignKey = false;
				colvarListReportName.IsReadOnly = false;
				colvarListReportName.DefaultSetting = @"";
				colvarListReportName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarListReportName);
				
				TableSchema.TableColumn colvarTableName = new TableSchema.TableColumn(schema);
				colvarTableName.ColumnName = "TableName";
				colvarTableName.DataType = DbType.AnsiString;
				colvarTableName.MaxLength = 50;
				colvarTableName.AutoIncrement = false;
				colvarTableName.IsNullable = true;
				colvarTableName.IsPrimaryKey = false;
				colvarTableName.IsForeignKey = false;
				colvarTableName.IsReadOnly = false;
				colvarTableName.DefaultSetting = @"";
				colvarTableName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTableName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("ListReport",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ListReportId")]
		[Bindable(true)]
		public int ListReportId 
		{
			get { return GetColumnValue<int>(Columns.ListReportId); }
			set { SetColumnValue(Columns.ListReportId, value); }
		}
		  
		[XmlAttribute("ListReportName")]
		[Bindable(true)]
		public string ListReportName 
		{
			get { return GetColumnValue<string>(Columns.ListReportName); }
			set { SetColumnValue(Columns.ListReportName, value); }
		}
		  
		[XmlAttribute("TableName")]
		[Bindable(true)]
		public string TableName 
		{
			get { return GetColumnValue<string>(Columns.TableName); }
			set { SetColumnValue(Columns.TableName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SmartCBSDataAccess.ListReportDetailCollection ListReportDetailRecords()
		{
			return new SmartCBSDataAccess.ListReportDetailCollection().Where(ListReportDetail.Columns.ListReportId, ListReportId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varListReportName,string varTableName)
		{
			ListReport item = new ListReport();
			
			item.ListReportName = varListReportName;
			
			item.TableName = varTableName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varListReportId,string varListReportName,string varTableName)
		{
			ListReport item = new ListReport();
			
				item.ListReportId = varListReportId;
			
				item.ListReportName = varListReportName;
			
				item.TableName = varTableName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ListReportIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ListReportNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TableNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ListReportId = @"ListReportId";
			 public static string ListReportName = @"ListReportName";
			 public static string TableName = @"TableName";
						
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