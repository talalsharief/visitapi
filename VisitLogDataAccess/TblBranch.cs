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
	/// Strongly-typed collection for the TblBranch class.
	/// </summary>
    [Serializable]
	public partial class TblBranchCollection : ActiveList<TblBranch, TblBranchCollection>
	{	   
		public TblBranchCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblBranchCollection</returns>
		public TblBranchCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblBranch o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblBranch table.
	/// </summary>
	[Serializable]
	public partial class TblBranch : ActiveRecord<TblBranch>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblBranch()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblBranch(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblBranch(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblBranch(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblBranch", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarBranchID = new TableSchema.TableColumn(schema);
				colvarBranchID.ColumnName = "BranchID";
				colvarBranchID.DataType = DbType.Int32;
				colvarBranchID.MaxLength = 0;
				colvarBranchID.AutoIncrement = true;
				colvarBranchID.IsNullable = false;
				colvarBranchID.IsPrimaryKey = true;
				colvarBranchID.IsForeignKey = false;
				colvarBranchID.IsReadOnly = false;
				colvarBranchID.DefaultSetting = @"";
				colvarBranchID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBranchID);
				
				TableSchema.TableColumn colvarBranchCode = new TableSchema.TableColumn(schema);
				colvarBranchCode.ColumnName = "BranchCode";
				colvarBranchCode.DataType = DbType.AnsiString;
				colvarBranchCode.MaxLength = 50;
				colvarBranchCode.AutoIncrement = false;
				colvarBranchCode.IsNullable = true;
				colvarBranchCode.IsPrimaryKey = false;
				colvarBranchCode.IsForeignKey = false;
				colvarBranchCode.IsReadOnly = false;
				colvarBranchCode.DefaultSetting = @"";
				colvarBranchCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBranchCode);
				
				TableSchema.TableColumn colvarBranchName = new TableSchema.TableColumn(schema);
				colvarBranchName.ColumnName = "BranchName";
				colvarBranchName.DataType = DbType.AnsiString;
				colvarBranchName.MaxLength = 150;
				colvarBranchName.AutoIncrement = false;
				colvarBranchName.IsNullable = true;
				colvarBranchName.IsPrimaryKey = false;
				colvarBranchName.IsForeignKey = false;
				colvarBranchName.IsReadOnly = false;
				colvarBranchName.DefaultSetting = @"";
				colvarBranchName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBranchName);
				
				TableSchema.TableColumn colvarIsActive = new TableSchema.TableColumn(schema);
				colvarIsActive.ColumnName = "IsActive";
				colvarIsActive.DataType = DbType.Boolean;
				colvarIsActive.MaxLength = 0;
				colvarIsActive.AutoIncrement = false;
				colvarIsActive.IsNullable = true;
				colvarIsActive.IsPrimaryKey = false;
				colvarIsActive.IsForeignKey = false;
				colvarIsActive.IsReadOnly = false;
				colvarIsActive.DefaultSetting = @"";
				colvarIsActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsActive);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblBranch",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("BranchID")]
		[Bindable(true)]
		public int BranchID 
		{
			get { return GetColumnValue<int>(Columns.BranchID); }
			set { SetColumnValue(Columns.BranchID, value); }
		}
		  
		[XmlAttribute("BranchCode")]
		[Bindable(true)]
		public string BranchCode 
		{
			get { return GetColumnValue<string>(Columns.BranchCode); }
			set { SetColumnValue(Columns.BranchCode, value); }
		}
		  
		[XmlAttribute("BranchName")]
		[Bindable(true)]
		public string BranchName 
		{
			get { return GetColumnValue<string>(Columns.BranchName); }
			set { SetColumnValue(Columns.BranchName, value); }
		}
		  
		[XmlAttribute("IsActive")]
		[Bindable(true)]
		public bool? IsActive 
		{
			get { return GetColumnValue<bool?>(Columns.IsActive); }
			set { SetColumnValue(Columns.IsActive, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public VisitLogDataAccess.SystemLoggingCollection SystemLoggingRecords()
		{
			return new VisitLogDataAccess.SystemLoggingCollection().Where(SystemLogging.Columns.BranchID, BranchID).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varBranchCode,string varBranchName,bool? varIsActive)
		{
			TblBranch item = new TblBranch();
			
			item.BranchCode = varBranchCode;
			
			item.BranchName = varBranchName;
			
			item.IsActive = varIsActive;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varBranchID,string varBranchCode,string varBranchName,bool? varIsActive)
		{
			TblBranch item = new TblBranch();
			
				item.BranchID = varBranchID;
			
				item.BranchCode = varBranchCode;
			
				item.BranchName = varBranchName;
			
				item.IsActive = varIsActive;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn BranchIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn BranchCodeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BranchNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsActiveColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string BranchID = @"BranchID";
			 public static string BranchCode = @"BranchCode";
			 public static string BranchName = @"BranchName";
			 public static string IsActive = @"IsActive";
						
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
