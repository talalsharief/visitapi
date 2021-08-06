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
	/// Strongly-typed collection for the TblTariffSlabsLog class.
	/// </summary>
    [Serializable]
	public partial class TblTariffSlabsLogCollection : ActiveList<TblTariffSlabsLog, TblTariffSlabsLogCollection>
	{	   
		public TblTariffSlabsLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblTariffSlabsLogCollection</returns>
		public TblTariffSlabsLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblTariffSlabsLog o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblTariffSlabsLog table.
	/// </summary>
	[Serializable]
	public partial class TblTariffSlabsLog : ActiveRecord<TblTariffSlabsLog>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblTariffSlabsLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblTariffSlabsLog(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblTariffSlabsLog(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblTariffSlabsLog(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblTariffSlabsLog", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarTariffSlabsLogID = new TableSchema.TableColumn(schema);
				colvarTariffSlabsLogID.ColumnName = "TariffSlabsLogID";
				colvarTariffSlabsLogID.DataType = DbType.Int32;
				colvarTariffSlabsLogID.MaxLength = 0;
				colvarTariffSlabsLogID.AutoIncrement = true;
				colvarTariffSlabsLogID.IsNullable = false;
				colvarTariffSlabsLogID.IsPrimaryKey = true;
				colvarTariffSlabsLogID.IsForeignKey = false;
				colvarTariffSlabsLogID.IsReadOnly = false;
				colvarTariffSlabsLogID.DefaultSetting = @"";
				colvarTariffSlabsLogID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTariffSlabsLogID);
				
				TableSchema.TableColumn colvarTariffSlabID = new TableSchema.TableColumn(schema);
				colvarTariffSlabID.ColumnName = "TariffSlabID";
				colvarTariffSlabID.DataType = DbType.Int32;
				colvarTariffSlabID.MaxLength = 0;
				colvarTariffSlabID.AutoIncrement = false;
				colvarTariffSlabID.IsNullable = true;
				colvarTariffSlabID.IsPrimaryKey = false;
				colvarTariffSlabID.IsForeignKey = false;
				colvarTariffSlabID.IsReadOnly = false;
				colvarTariffSlabID.DefaultSetting = @"";
				colvarTariffSlabID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTariffSlabID);
				
				TableSchema.TableColumn colvarTariffID = new TableSchema.TableColumn(schema);
				colvarTariffID.ColumnName = "TariffID";
				colvarTariffID.DataType = DbType.Int32;
				colvarTariffID.MaxLength = 0;
				colvarTariffID.AutoIncrement = false;
				colvarTariffID.IsNullable = true;
				colvarTariffID.IsPrimaryKey = false;
				colvarTariffID.IsForeignKey = false;
				colvarTariffID.IsReadOnly = false;
				colvarTariffID.DefaultSetting = @"";
				colvarTariffID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTariffID);
				
				TableSchema.TableColumn colvarUnitsFrom = new TableSchema.TableColumn(schema);
				colvarUnitsFrom.ColumnName = "UnitsFrom";
				colvarUnitsFrom.DataType = DbType.Int32;
				colvarUnitsFrom.MaxLength = 0;
				colvarUnitsFrom.AutoIncrement = false;
				colvarUnitsFrom.IsNullable = true;
				colvarUnitsFrom.IsPrimaryKey = false;
				colvarUnitsFrom.IsForeignKey = false;
				colvarUnitsFrom.IsReadOnly = false;
				colvarUnitsFrom.DefaultSetting = @"";
				colvarUnitsFrom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitsFrom);
				
				TableSchema.TableColumn colvarUnitsTo = new TableSchema.TableColumn(schema);
				colvarUnitsTo.ColumnName = "UnitsTo";
				colvarUnitsTo.DataType = DbType.Int32;
				colvarUnitsTo.MaxLength = 0;
				colvarUnitsTo.AutoIncrement = false;
				colvarUnitsTo.IsNullable = true;
				colvarUnitsTo.IsPrimaryKey = false;
				colvarUnitsTo.IsForeignKey = false;
				colvarUnitsTo.IsReadOnly = false;
				colvarUnitsTo.DefaultSetting = @"";
				colvarUnitsTo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitsTo);
				
				TableSchema.TableColumn colvarRate = new TableSchema.TableColumn(schema);
				colvarRate.ColumnName = "Rate";
				colvarRate.DataType = DbType.Decimal;
				colvarRate.MaxLength = 0;
				colvarRate.AutoIncrement = false;
				colvarRate.IsNullable = true;
				colvarRate.IsPrimaryKey = false;
				colvarRate.IsForeignKey = false;
				colvarRate.IsReadOnly = false;
				colvarRate.DefaultSetting = @"";
				colvarRate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRate);
				
				TableSchema.TableColumn colvarTrUpdatedOn = new TableSchema.TableColumn(schema);
				colvarTrUpdatedOn.ColumnName = "TrUpdatedOn";
				colvarTrUpdatedOn.DataType = DbType.DateTime;
				colvarTrUpdatedOn.MaxLength = 0;
				colvarTrUpdatedOn.AutoIncrement = false;
				colvarTrUpdatedOn.IsNullable = true;
				colvarTrUpdatedOn.IsPrimaryKey = false;
				colvarTrUpdatedOn.IsForeignKey = false;
				colvarTrUpdatedOn.IsReadOnly = false;
				colvarTrUpdatedOn.DefaultSetting = @"";
				colvarTrUpdatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrUpdatedOn);
				
				TableSchema.TableColumn colvarTrUpdatedBy = new TableSchema.TableColumn(schema);
				colvarTrUpdatedBy.ColumnName = "TrUpdatedBy";
				colvarTrUpdatedBy.DataType = DbType.Int32;
				colvarTrUpdatedBy.MaxLength = 0;
				colvarTrUpdatedBy.AutoIncrement = false;
				colvarTrUpdatedBy.IsNullable = true;
				colvarTrUpdatedBy.IsPrimaryKey = false;
				colvarTrUpdatedBy.IsForeignKey = true;
				colvarTrUpdatedBy.IsReadOnly = false;
				colvarTrUpdatedBy.DefaultSetting = @"";
				
					colvarTrUpdatedBy.ForeignKeyTableName = "UserLogin";
				schema.Columns.Add(colvarTrUpdatedBy);
				
				TableSchema.TableColumn colvarTrCreatedOn = new TableSchema.TableColumn(schema);
				colvarTrCreatedOn.ColumnName = "TrCreatedOn";
				colvarTrCreatedOn.DataType = DbType.DateTime;
				colvarTrCreatedOn.MaxLength = 0;
				colvarTrCreatedOn.AutoIncrement = false;
				colvarTrCreatedOn.IsNullable = true;
				colvarTrCreatedOn.IsPrimaryKey = false;
				colvarTrCreatedOn.IsForeignKey = false;
				colvarTrCreatedOn.IsReadOnly = false;
				colvarTrCreatedOn.DefaultSetting = @"";
				colvarTrCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrCreatedOn);
				
				TableSchema.TableColumn colvarTrCreatedBy = new TableSchema.TableColumn(schema);
				colvarTrCreatedBy.ColumnName = "TrCreatedBy";
				colvarTrCreatedBy.DataType = DbType.Int32;
				colvarTrCreatedBy.MaxLength = 0;
				colvarTrCreatedBy.AutoIncrement = false;
				colvarTrCreatedBy.IsNullable = true;
				colvarTrCreatedBy.IsPrimaryKey = false;
				colvarTrCreatedBy.IsForeignKey = false;
				colvarTrCreatedBy.IsReadOnly = false;
				colvarTrCreatedBy.DefaultSetting = @"";
				colvarTrCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrCreatedBy);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblTariffSlabsLog",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("TariffSlabsLogID")]
		[Bindable(true)]
		public int TariffSlabsLogID 
		{
			get { return GetColumnValue<int>(Columns.TariffSlabsLogID); }
			set { SetColumnValue(Columns.TariffSlabsLogID, value); }
		}
		  
		[XmlAttribute("TariffSlabID")]
		[Bindable(true)]
		public int? TariffSlabID 
		{
			get { return GetColumnValue<int?>(Columns.TariffSlabID); }
			set { SetColumnValue(Columns.TariffSlabID, value); }
		}
		  
		[XmlAttribute("TariffID")]
		[Bindable(true)]
		public int? TariffID 
		{
			get { return GetColumnValue<int?>(Columns.TariffID); }
			set { SetColumnValue(Columns.TariffID, value); }
		}
		  
		[XmlAttribute("UnitsFrom")]
		[Bindable(true)]
		public int? UnitsFrom 
		{
			get { return GetColumnValue<int?>(Columns.UnitsFrom); }
			set { SetColumnValue(Columns.UnitsFrom, value); }
		}
		  
		[XmlAttribute("UnitsTo")]
		[Bindable(true)]
		public int? UnitsTo 
		{
			get { return GetColumnValue<int?>(Columns.UnitsTo); }
			set { SetColumnValue(Columns.UnitsTo, value); }
		}
		  
		[XmlAttribute("Rate")]
		[Bindable(true)]
		public decimal? Rate 
		{
			get { return GetColumnValue<decimal?>(Columns.Rate); }
			set { SetColumnValue(Columns.Rate, value); }
		}
		  
		[XmlAttribute("TrUpdatedOn")]
		[Bindable(true)]
		public DateTime? TrUpdatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.TrUpdatedOn); }
			set { SetColumnValue(Columns.TrUpdatedOn, value); }
		}
		  
		[XmlAttribute("TrUpdatedBy")]
		[Bindable(true)]
		public int? TrUpdatedBy 
		{
			get { return GetColumnValue<int?>(Columns.TrUpdatedBy); }
			set { SetColumnValue(Columns.TrUpdatedBy, value); }
		}
		  
		[XmlAttribute("TrCreatedOn")]
		[Bindable(true)]
		public DateTime? TrCreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.TrCreatedOn); }
			set { SetColumnValue(Columns.TrCreatedOn, value); }
		}
		  
		[XmlAttribute("TrCreatedBy")]
		[Bindable(true)]
		public int? TrCreatedBy 
		{
			get { return GetColumnValue<int?>(Columns.TrCreatedBy); }
			set { SetColumnValue(Columns.TrCreatedBy, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a UserLogin ActiveRecord object related to this TblTariffSlabsLog
		/// 
		/// </summary>
		public SmartCBSDataAccess.UserLogin UserLogin
		{
			get { return SmartCBSDataAccess.UserLogin.FetchByID(this.TrUpdatedBy); }
			set { SetColumnValue("TrUpdatedBy", value.UserLoginId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varTariffSlabID,int? varTariffID,int? varUnitsFrom,int? varUnitsTo,decimal? varRate,DateTime? varTrUpdatedOn,int? varTrUpdatedBy,DateTime? varTrCreatedOn,int? varTrCreatedBy)
		{
			TblTariffSlabsLog item = new TblTariffSlabsLog();
			
			item.TariffSlabID = varTariffSlabID;
			
			item.TariffID = varTariffID;
			
			item.UnitsFrom = varUnitsFrom;
			
			item.UnitsTo = varUnitsTo;
			
			item.Rate = varRate;
			
			item.TrUpdatedOn = varTrUpdatedOn;
			
			item.TrUpdatedBy = varTrUpdatedBy;
			
			item.TrCreatedOn = varTrCreatedOn;
			
			item.TrCreatedBy = varTrCreatedBy;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varTariffSlabsLogID,int? varTariffSlabID,int? varTariffID,int? varUnitsFrom,int? varUnitsTo,decimal? varRate,DateTime? varTrUpdatedOn,int? varTrUpdatedBy,DateTime? varTrCreatedOn,int? varTrCreatedBy)
		{
			TblTariffSlabsLog item = new TblTariffSlabsLog();
			
				item.TariffSlabsLogID = varTariffSlabsLogID;
			
				item.TariffSlabID = varTariffSlabID;
			
				item.TariffID = varTariffID;
			
				item.UnitsFrom = varUnitsFrom;
			
				item.UnitsTo = varUnitsTo;
			
				item.Rate = varRate;
			
				item.TrUpdatedOn = varTrUpdatedOn;
			
				item.TrUpdatedBy = varTrUpdatedBy;
			
				item.TrCreatedOn = varTrCreatedOn;
			
				item.TrCreatedBy = varTrCreatedBy;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn TariffSlabsLogIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TariffSlabIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TariffIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitsFromColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitsToColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn RateColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TrUpdatedOnColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TrUpdatedByColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TrCreatedOnColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TrCreatedByColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string TariffSlabsLogID = @"TariffSlabsLogID";
			 public static string TariffSlabID = @"TariffSlabID";
			 public static string TariffID = @"TariffID";
			 public static string UnitsFrom = @"UnitsFrom";
			 public static string UnitsTo = @"UnitsTo";
			 public static string Rate = @"Rate";
			 public static string TrUpdatedOn = @"TrUpdatedOn";
			 public static string TrUpdatedBy = @"TrUpdatedBy";
			 public static string TrCreatedOn = @"TrCreatedOn";
			 public static string TrCreatedBy = @"TrCreatedBy";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}