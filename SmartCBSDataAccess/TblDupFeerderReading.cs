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
	/// Strongly-typed collection for the TblDupFeerderReading class.
	/// </summary>
    [Serializable]
	public partial class TblDupFeerderReadingCollection : ActiveList<TblDupFeerderReading, TblDupFeerderReadingCollection>
	{	   
		public TblDupFeerderReadingCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblDupFeerderReadingCollection</returns>
		public TblDupFeerderReadingCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblDupFeerderReading o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblDupFeerderReading table.
	/// </summary>
	[Serializable]
	public partial class TblDupFeerderReading : ActiveRecord<TblDupFeerderReading>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblDupFeerderReading()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblDupFeerderReading(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblDupFeerderReading(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblDupFeerderReading(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblDupFeerderReading", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarDuplicateDataID = new TableSchema.TableColumn(schema);
				colvarDuplicateDataID.ColumnName = "DuplicateDataID";
				colvarDuplicateDataID.DataType = DbType.Int32;
				colvarDuplicateDataID.MaxLength = 0;
				colvarDuplicateDataID.AutoIncrement = true;
				colvarDuplicateDataID.IsNullable = false;
				colvarDuplicateDataID.IsPrimaryKey = true;
				colvarDuplicateDataID.IsForeignKey = false;
				colvarDuplicateDataID.IsReadOnly = false;
				colvarDuplicateDataID.DefaultSetting = @"";
				colvarDuplicateDataID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDuplicateDataID);
				
				TableSchema.TableColumn colvarDataID = new TableSchema.TableColumn(schema);
				colvarDataID.ColumnName = "DataID";
				colvarDataID.DataType = DbType.Int32;
				colvarDataID.MaxLength = 0;
				colvarDataID.AutoIncrement = false;
				colvarDataID.IsNullable = true;
				colvarDataID.IsPrimaryKey = false;
				colvarDataID.IsForeignKey = true;
				colvarDataID.IsReadOnly = false;
				colvarDataID.DefaultSetting = @"";
				
					colvarDataID.ForeignKeyTableName = "TblFeederReadingData";
				schema.Columns.Add(colvarDataID);
				
				TableSchema.TableColumn colvarFeederNo = new TableSchema.TableColumn(schema);
				colvarFeederNo.ColumnName = "FeederNo";
				colvarFeederNo.DataType = DbType.AnsiString;
				colvarFeederNo.MaxLength = 100;
				colvarFeederNo.AutoIncrement = false;
				colvarFeederNo.IsNullable = true;
				colvarFeederNo.IsPrimaryKey = false;
				colvarFeederNo.IsForeignKey = false;
				colvarFeederNo.IsReadOnly = false;
				colvarFeederNo.DefaultSetting = @"";
				colvarFeederNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederNo);
				
				TableSchema.TableColumn colvarFeederReading = new TableSchema.TableColumn(schema);
				colvarFeederReading.ColumnName = "FeederReading";
				colvarFeederReading.DataType = DbType.Decimal;
				colvarFeederReading.MaxLength = 0;
				colvarFeederReading.AutoIncrement = false;
				colvarFeederReading.IsNullable = true;
				colvarFeederReading.IsPrimaryKey = false;
				colvarFeederReading.IsForeignKey = false;
				colvarFeederReading.IsReadOnly = false;
				colvarFeederReading.DefaultSetting = @"";
				colvarFeederReading.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReading);
				
				TableSchema.TableColumn colvarFeederReadingDate = new TableSchema.TableColumn(schema);
				colvarFeederReadingDate.ColumnName = "FeederReadingDate";
				colvarFeederReadingDate.DataType = DbType.DateTime;
				colvarFeederReadingDate.MaxLength = 0;
				colvarFeederReadingDate.AutoIncrement = false;
				colvarFeederReadingDate.IsNullable = true;
				colvarFeederReadingDate.IsPrimaryKey = false;
				colvarFeederReadingDate.IsForeignKey = false;
				colvarFeederReadingDate.IsReadOnly = false;
				colvarFeederReadingDate.DefaultSetting = @"";
				colvarFeederReadingDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadingDate);
				
				TableSchema.TableColumn colvarUploadedBy = new TableSchema.TableColumn(schema);
				colvarUploadedBy.ColumnName = "UploadedBy";
				colvarUploadedBy.DataType = DbType.Int32;
				colvarUploadedBy.MaxLength = 0;
				colvarUploadedBy.AutoIncrement = false;
				colvarUploadedBy.IsNullable = true;
				colvarUploadedBy.IsPrimaryKey = false;
				colvarUploadedBy.IsForeignKey = true;
				colvarUploadedBy.IsReadOnly = false;
				colvarUploadedBy.DefaultSetting = @"";
				
					colvarUploadedBy.ForeignKeyTableName = "tblEmployee";
				schema.Columns.Add(colvarUploadedBy);
				
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
				DataService.Providers["PrimaryProvider"].AddSchema("TblDupFeerderReading",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("DuplicateDataID")]
		[Bindable(true)]
		public int DuplicateDataID 
		{
			get { return GetColumnValue<int>(Columns.DuplicateDataID); }
			set { SetColumnValue(Columns.DuplicateDataID, value); }
		}
		  
		[XmlAttribute("DataID")]
		[Bindable(true)]
		public int? DataID 
		{
			get { return GetColumnValue<int?>(Columns.DataID); }
			set { SetColumnValue(Columns.DataID, value); }
		}
		  
		[XmlAttribute("FeederNo")]
		[Bindable(true)]
		public string FeederNo 
		{
			get { return GetColumnValue<string>(Columns.FeederNo); }
			set { SetColumnValue(Columns.FeederNo, value); }
		}
		  
		[XmlAttribute("FeederReading")]
		[Bindable(true)]
		public decimal? FeederReading 
		{
			get { return GetColumnValue<decimal?>(Columns.FeederReading); }
			set { SetColumnValue(Columns.FeederReading, value); }
		}
		  
		[XmlAttribute("FeederReadingDate")]
		[Bindable(true)]
		public DateTime? FeederReadingDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.FeederReadingDate); }
			set { SetColumnValue(Columns.FeederReadingDate, value); }
		}
		  
		[XmlAttribute("UploadedBy")]
		[Bindable(true)]
		public int? UploadedBy 
		{
			get { return GetColumnValue<int?>(Columns.UploadedBy); }
			set { SetColumnValue(Columns.UploadedBy, value); }
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
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblEmployee ActiveRecord object related to this TblDupFeerderReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblEmployee TblEmployee
		{
			get { return SmartCBSDataAccess.TblEmployee.FetchByID(this.UploadedBy); }
			set { SetColumnValue("UploadedBy", value.EmployeeID); }
		}
		
		
		/// <summary>
		/// Returns a TblFeederReadingDatum ActiveRecord object related to this TblDupFeerderReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblFeederReadingDatum TblFeederReadingDatum
		{
			get { return SmartCBSDataAccess.TblFeederReadingDatum.FetchByID(this.DataID); }
			set { SetColumnValue("DataID", value.DataID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varDataID,string varFeederNo,decimal? varFeederReading,DateTime? varFeederReadingDate,int? varUploadedBy,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblDupFeerderReading item = new TblDupFeerderReading();
			
			item.DataID = varDataID;
			
			item.FeederNo = varFeederNo;
			
			item.FeederReading = varFeederReading;
			
			item.FeederReadingDate = varFeederReadingDate;
			
			item.UploadedBy = varUploadedBy;
			
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
		public static void Update(int varDuplicateDataID,int? varDataID,string varFeederNo,decimal? varFeederReading,DateTime? varFeederReadingDate,int? varUploadedBy,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblDupFeerderReading item = new TblDupFeerderReading();
			
				item.DuplicateDataID = varDuplicateDataID;
			
				item.DataID = varDataID;
			
				item.FeederNo = varFeederNo;
			
				item.FeederReading = varFeederReading;
			
				item.FeederReadingDate = varFeederReadingDate;
			
				item.UploadedBy = varUploadedBy;
			
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
        
        
        public static TableSchema.TableColumn DuplicateDataIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DataIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederNoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadingColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadingDateColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn UploadedByColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string DuplicateDataID = @"DuplicateDataID";
			 public static string DataID = @"DataID";
			 public static string FeederNo = @"FeederNo";
			 public static string FeederReading = @"FeederReading";
			 public static string FeederReadingDate = @"FeederReadingDate";
			 public static string UploadedBy = @"UploadedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}