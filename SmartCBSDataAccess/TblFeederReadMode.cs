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
	/// Strongly-typed collection for the TblFeederReadMode class.
	/// </summary>
    [Serializable]
	public partial class TblFeederReadModeCollection : ActiveList<TblFeederReadMode, TblFeederReadModeCollection>
	{	   
		public TblFeederReadModeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblFeederReadModeCollection</returns>
		public TblFeederReadModeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblFeederReadMode o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblFeederReadMode table.
	/// </summary>
	[Serializable]
	public partial class TblFeederReadMode : ActiveRecord<TblFeederReadMode>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblFeederReadMode()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblFeederReadMode(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblFeederReadMode(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblFeederReadMode(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblFeederReadMode", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFeederReadID = new TableSchema.TableColumn(schema);
				colvarFeederReadID.ColumnName = "FeederReadID";
				colvarFeederReadID.DataType = DbType.Int32;
				colvarFeederReadID.MaxLength = 0;
				colvarFeederReadID.AutoIncrement = true;
				colvarFeederReadID.IsNullable = false;
				colvarFeederReadID.IsPrimaryKey = true;
				colvarFeederReadID.IsForeignKey = false;
				colvarFeederReadID.IsReadOnly = false;
				colvarFeederReadID.DefaultSetting = @"";
				colvarFeederReadID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadID);
				
				TableSchema.TableColumn colvarFeederReadModeName = new TableSchema.TableColumn(schema);
				colvarFeederReadModeName.ColumnName = "FeederReadModeName";
				colvarFeederReadModeName.DataType = DbType.AnsiString;
				colvarFeederReadModeName.MaxLength = 50;
				colvarFeederReadModeName.AutoIncrement = false;
				colvarFeederReadModeName.IsNullable = true;
				colvarFeederReadModeName.IsPrimaryKey = false;
				colvarFeederReadModeName.IsForeignKey = false;
				colvarFeederReadModeName.IsReadOnly = false;
				colvarFeederReadModeName.DefaultSetting = @"";
				colvarFeederReadModeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadModeName);
				
				TableSchema.TableColumn colvarFeederReadCode = new TableSchema.TableColumn(schema);
				colvarFeederReadCode.ColumnName = "FeederReadCode";
				colvarFeederReadCode.DataType = DbType.AnsiString;
				colvarFeederReadCode.MaxLength = 50;
				colvarFeederReadCode.AutoIncrement = false;
				colvarFeederReadCode.IsNullable = true;
				colvarFeederReadCode.IsPrimaryKey = false;
				colvarFeederReadCode.IsForeignKey = false;
				colvarFeederReadCode.IsReadOnly = false;
				colvarFeederReadCode.DefaultSetting = @"";
				colvarFeederReadCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadCode);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = true;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				colvarCreatedOn.DefaultSetting = @"";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = true;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				colvarModifiedOn.DefaultSetting = @"";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblFeederReadMode",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FeederReadID")]
		[Bindable(true)]
		public int FeederReadID 
		{
			get { return GetColumnValue<int>(Columns.FeederReadID); }
			set { SetColumnValue(Columns.FeederReadID, value); }
		}
		  
		[XmlAttribute("FeederReadModeName")]
		[Bindable(true)]
		public string FeederReadModeName 
		{
			get { return GetColumnValue<string>(Columns.FeederReadModeName); }
			set { SetColumnValue(Columns.FeederReadModeName, value); }
		}
		  
		[XmlAttribute("FeederReadCode")]
		[Bindable(true)]
		public string FeederReadCode 
		{
			get { return GetColumnValue<string>(Columns.FeederReadCode); }
			set { SetColumnValue(Columns.FeederReadCode, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime? CreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("ModifiedOn")]
		[Bindable(true)]
		public DateTime? ModifiedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SmartCBSDataAccess.TblFeederReadingCollection TblFeederReadingRecords()
		{
			return new SmartCBSDataAccess.TblFeederReadingCollection().Where(TblFeederReading.Columns.FeederReadModeID, FeederReadID).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFeederReadModeName,string varFeederReadCode,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblFeederReadMode item = new TblFeederReadMode();
			
			item.FeederReadModeName = varFeederReadModeName;
			
			item.FeederReadCode = varFeederReadCode;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFeederReadID,string varFeederReadModeName,string varFeederReadCode,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblFeederReadMode item = new TblFeederReadMode();
			
				item.FeederReadID = varFeederReadID;
			
				item.FeederReadModeName = varFeederReadModeName;
			
				item.FeederReadCode = varFeederReadCode;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FeederReadIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadModeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadCodeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FeederReadID = @"FeederReadID";
			 public static string FeederReadModeName = @"FeederReadModeName";
			 public static string FeederReadCode = @"FeederReadCode";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
						
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