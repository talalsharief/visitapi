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
	/// Strongly-typed collection for the TblPMTReadMode class.
	/// </summary>
    [Serializable]
	public partial class TblPMTReadModeCollection : ActiveList<TblPMTReadMode, TblPMTReadModeCollection>
	{	   
		public TblPMTReadModeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblPMTReadModeCollection</returns>
		public TblPMTReadModeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblPMTReadMode o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblPMTReadMode table.
	/// </summary>
	[Serializable]
	public partial class TblPMTReadMode : ActiveRecord<TblPMTReadMode>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblPMTReadMode()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblPMTReadMode(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblPMTReadMode(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblPMTReadMode(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblPMTReadMode", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPMTReadID = new TableSchema.TableColumn(schema);
				colvarPMTReadID.ColumnName = "PMTReadID";
				colvarPMTReadID.DataType = DbType.Int32;
				colvarPMTReadID.MaxLength = 0;
				colvarPMTReadID.AutoIncrement = true;
				colvarPMTReadID.IsNullable = false;
				colvarPMTReadID.IsPrimaryKey = true;
				colvarPMTReadID.IsForeignKey = false;
				colvarPMTReadID.IsReadOnly = false;
				colvarPMTReadID.DefaultSetting = @"";
				colvarPMTReadID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPMTReadID);
				
				TableSchema.TableColumn colvarPMTReadModeName = new TableSchema.TableColumn(schema);
				colvarPMTReadModeName.ColumnName = "PMTReadModeName";
				colvarPMTReadModeName.DataType = DbType.AnsiString;
				colvarPMTReadModeName.MaxLength = 50;
				colvarPMTReadModeName.AutoIncrement = false;
				colvarPMTReadModeName.IsNullable = true;
				colvarPMTReadModeName.IsPrimaryKey = false;
				colvarPMTReadModeName.IsForeignKey = false;
				colvarPMTReadModeName.IsReadOnly = false;
				colvarPMTReadModeName.DefaultSetting = @"";
				colvarPMTReadModeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPMTReadModeName);
				
				TableSchema.TableColumn colvarPMTReadCode = new TableSchema.TableColumn(schema);
				colvarPMTReadCode.ColumnName = "PMTReadCode";
				colvarPMTReadCode.DataType = DbType.AnsiString;
				colvarPMTReadCode.MaxLength = 50;
				colvarPMTReadCode.AutoIncrement = false;
				colvarPMTReadCode.IsNullable = true;
				colvarPMTReadCode.IsPrimaryKey = false;
				colvarPMTReadCode.IsForeignKey = false;
				colvarPMTReadCode.IsReadOnly = false;
				colvarPMTReadCode.DefaultSetting = @"";
				colvarPMTReadCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPMTReadCode);
				
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
				DataService.Providers["PrimaryProvider"].AddSchema("TblPMTReadMode",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("PMTReadID")]
		[Bindable(true)]
		public int PMTReadID 
		{
			get { return GetColumnValue<int>(Columns.PMTReadID); }
			set { SetColumnValue(Columns.PMTReadID, value); }
		}
		  
		[XmlAttribute("PMTReadModeName")]
		[Bindable(true)]
		public string PMTReadModeName 
		{
			get { return GetColumnValue<string>(Columns.PMTReadModeName); }
			set { SetColumnValue(Columns.PMTReadModeName, value); }
		}
		  
		[XmlAttribute("PMTReadCode")]
		[Bindable(true)]
		public string PMTReadCode 
		{
			get { return GetColumnValue<string>(Columns.PMTReadCode); }
			set { SetColumnValue(Columns.PMTReadCode, value); }
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
        
		
		public SmartCBSDataAccess.TblPMTReadingCollection TblPMTReadingRecords()
		{
			return new SmartCBSDataAccess.TblPMTReadingCollection().Where(TblPMTReading.Columns.PMTReadModeID, PMTReadID).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varPMTReadModeName,string varPMTReadCode,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblPMTReadMode item = new TblPMTReadMode();
			
			item.PMTReadModeName = varPMTReadModeName;
			
			item.PMTReadCode = varPMTReadCode;
			
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
		public static void Update(int varPMTReadID,string varPMTReadModeName,string varPMTReadCode,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblPMTReadMode item = new TblPMTReadMode();
			
				item.PMTReadID = varPMTReadID;
			
				item.PMTReadModeName = varPMTReadModeName;
			
				item.PMTReadCode = varPMTReadCode;
			
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
        
        
        public static TableSchema.TableColumn PMTReadIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PMTReadModeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PMTReadCodeColumn
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
			 public static string PMTReadID = @"PMTReadID";
			 public static string PMTReadModeName = @"PMTReadModeName";
			 public static string PMTReadCode = @"PMTReadCode";
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