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
	/// Strongly-typed collection for the TblFeederReading class.
	/// </summary>
    [Serializable]
	public partial class TblFeederReadingCollection : ActiveList<TblFeederReading, TblFeederReadingCollection>
	{	   
		public TblFeederReadingCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblFeederReadingCollection</returns>
		public TblFeederReadingCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblFeederReading o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblFeederReading table.
	/// </summary>
	[Serializable]
	public partial class TblFeederReading : ActiveRecord<TblFeederReading>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblFeederReading()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblFeederReading(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblFeederReading(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblFeederReading(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblFeederReading", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFeederReadingID = new TableSchema.TableColumn(schema);
				colvarFeederReadingID.ColumnName = "FeederReadingID";
				colvarFeederReadingID.DataType = DbType.Int32;
				colvarFeederReadingID.MaxLength = 0;
				colvarFeederReadingID.AutoIncrement = true;
				colvarFeederReadingID.IsNullable = false;
				colvarFeederReadingID.IsPrimaryKey = true;
				colvarFeederReadingID.IsForeignKey = false;
				colvarFeederReadingID.IsReadOnly = false;
				colvarFeederReadingID.DefaultSetting = @"";
				colvarFeederReadingID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadingID);
				
				TableSchema.TableColumn colvarFeederID = new TableSchema.TableColumn(schema);
				colvarFeederID.ColumnName = "FeederID";
				colvarFeederID.DataType = DbType.Int32;
				colvarFeederID.MaxLength = 0;
				colvarFeederID.AutoIncrement = false;
				colvarFeederID.IsNullable = true;
				colvarFeederID.IsPrimaryKey = false;
				colvarFeederID.IsForeignKey = true;
				colvarFeederID.IsReadOnly = false;
				colvarFeederID.DefaultSetting = @"";
				
					colvarFeederID.ForeignKeyTableName = "TblFeeder";
				schema.Columns.Add(colvarFeederID);
				
				TableSchema.TableColumn colvarFeederReadModeID = new TableSchema.TableColumn(schema);
				colvarFeederReadModeID.ColumnName = "FeederReadModeID";
				colvarFeederReadModeID.DataType = DbType.Int32;
				colvarFeederReadModeID.MaxLength = 0;
				colvarFeederReadModeID.AutoIncrement = false;
				colvarFeederReadModeID.IsNullable = true;
				colvarFeederReadModeID.IsPrimaryKey = false;
				colvarFeederReadModeID.IsForeignKey = true;
				colvarFeederReadModeID.IsReadOnly = false;
				colvarFeederReadModeID.DefaultSetting = @"";
				
					colvarFeederReadModeID.ForeignKeyTableName = "TblFeederReadMode";
				schema.Columns.Add(colvarFeederReadModeID);
				
				TableSchema.TableColumn colvarFeederReadingMonth = new TableSchema.TableColumn(schema);
				colvarFeederReadingMonth.ColumnName = "FeederReadingMonth";
				colvarFeederReadingMonth.DataType = DbType.AnsiString;
				colvarFeederReadingMonth.MaxLength = 50;
				colvarFeederReadingMonth.AutoIncrement = false;
				colvarFeederReadingMonth.IsNullable = true;
				colvarFeederReadingMonth.IsPrimaryKey = false;
				colvarFeederReadingMonth.IsForeignKey = false;
				colvarFeederReadingMonth.IsReadOnly = false;
				colvarFeederReadingMonth.DefaultSetting = @"";
				colvarFeederReadingMonth.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadingMonth);
				
				TableSchema.TableColumn colvarFeederReadingYear = new TableSchema.TableColumn(schema);
				colvarFeederReadingYear.ColumnName = "FeederReadingYear";
				colvarFeederReadingYear.DataType = DbType.AnsiString;
				colvarFeederReadingYear.MaxLength = 50;
				colvarFeederReadingYear.AutoIncrement = false;
				colvarFeederReadingYear.IsNullable = true;
				colvarFeederReadingYear.IsPrimaryKey = false;
				colvarFeederReadingYear.IsForeignKey = false;
				colvarFeederReadingYear.IsReadOnly = false;
				colvarFeederReadingYear.DefaultSetting = @"";
				colvarFeederReadingYear.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederReadingYear);
				
				TableSchema.TableColumn colvarPreviousReading = new TableSchema.TableColumn(schema);
				colvarPreviousReading.ColumnName = "PreviousReading";
				colvarPreviousReading.DataType = DbType.Decimal;
				colvarPreviousReading.MaxLength = 0;
				colvarPreviousReading.AutoIncrement = false;
				colvarPreviousReading.IsNullable = true;
				colvarPreviousReading.IsPrimaryKey = false;
				colvarPreviousReading.IsForeignKey = false;
				colvarPreviousReading.IsReadOnly = false;
				colvarPreviousReading.DefaultSetting = @"";
				colvarPreviousReading.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreviousReading);
				
				TableSchema.TableColumn colvarCurrentReading = new TableSchema.TableColumn(schema);
				colvarCurrentReading.ColumnName = "CurrentReading";
				colvarCurrentReading.DataType = DbType.Decimal;
				colvarCurrentReading.MaxLength = 0;
				colvarCurrentReading.AutoIncrement = false;
				colvarCurrentReading.IsNullable = true;
				colvarCurrentReading.IsPrimaryKey = false;
				colvarCurrentReading.IsForeignKey = false;
				colvarCurrentReading.IsReadOnly = false;
				colvarCurrentReading.DefaultSetting = @"";
				colvarCurrentReading.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCurrentReading);
				
				TableSchema.TableColumn colvarTotalUnits = new TableSchema.TableColumn(schema);
				colvarTotalUnits.ColumnName = "TotalUnits";
				colvarTotalUnits.DataType = DbType.Decimal;
				colvarTotalUnits.MaxLength = 0;
				colvarTotalUnits.AutoIncrement = false;
				colvarTotalUnits.IsNullable = true;
				colvarTotalUnits.IsPrimaryKey = false;
				colvarTotalUnits.IsForeignKey = false;
				colvarTotalUnits.IsReadOnly = false;
				colvarTotalUnits.DefaultSetting = @"";
				colvarTotalUnits.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalUnits);
				
				TableSchema.TableColumn colvarMultiplyingFactor = new TableSchema.TableColumn(schema);
				colvarMultiplyingFactor.ColumnName = "MultiplyingFactor";
				colvarMultiplyingFactor.DataType = DbType.Decimal;
				colvarMultiplyingFactor.MaxLength = 0;
				colvarMultiplyingFactor.AutoIncrement = false;
				colvarMultiplyingFactor.IsNullable = true;
				colvarMultiplyingFactor.IsPrimaryKey = false;
				colvarMultiplyingFactor.IsForeignKey = false;
				colvarMultiplyingFactor.IsReadOnly = false;
				colvarMultiplyingFactor.DefaultSetting = @"";
				colvarMultiplyingFactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMultiplyingFactor);
				
				TableSchema.TableColumn colvarUnitsConsumed = new TableSchema.TableColumn(schema);
				colvarUnitsConsumed.ColumnName = "UnitsConsumed";
				colvarUnitsConsumed.DataType = DbType.Decimal;
				colvarUnitsConsumed.MaxLength = 0;
				colvarUnitsConsumed.AutoIncrement = false;
				colvarUnitsConsumed.IsNullable = true;
				colvarUnitsConsumed.IsPrimaryKey = false;
				colvarUnitsConsumed.IsForeignKey = false;
				colvarUnitsConsumed.IsReadOnly = false;
				colvarUnitsConsumed.DefaultSetting = @"";
				colvarUnitsConsumed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitsConsumed);
				
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
				
				TableSchema.TableColumn colvarFeederReadBy = new TableSchema.TableColumn(schema);
				colvarFeederReadBy.ColumnName = "FeederReadBy";
				colvarFeederReadBy.DataType = DbType.Int32;
				colvarFeederReadBy.MaxLength = 0;
				colvarFeederReadBy.AutoIncrement = false;
				colvarFeederReadBy.IsNullable = true;
				colvarFeederReadBy.IsPrimaryKey = false;
				colvarFeederReadBy.IsForeignKey = true;
				colvarFeederReadBy.IsReadOnly = false;
				colvarFeederReadBy.DefaultSetting = @"";
				
					colvarFeederReadBy.ForeignKeyTableName = "tblEmployee";
				schema.Columns.Add(colvarFeederReadBy);
				
				TableSchema.TableColumn colvarULCreatedBy = new TableSchema.TableColumn(schema);
				colvarULCreatedBy.ColumnName = "ULCreatedBy";
				colvarULCreatedBy.DataType = DbType.Int32;
				colvarULCreatedBy.MaxLength = 0;
				colvarULCreatedBy.AutoIncrement = false;
				colvarULCreatedBy.IsNullable = true;
				colvarULCreatedBy.IsPrimaryKey = false;
				colvarULCreatedBy.IsForeignKey = true;
				colvarULCreatedBy.IsReadOnly = false;
				colvarULCreatedBy.DefaultSetting = @"";
				
					colvarULCreatedBy.ForeignKeyTableName = "UserLogin";
				schema.Columns.Add(colvarULCreatedBy);
				
				TableSchema.TableColumn colvarULUpdatedBy = new TableSchema.TableColumn(schema);
				colvarULUpdatedBy.ColumnName = "ULUpdatedBy";
				colvarULUpdatedBy.DataType = DbType.Int32;
				colvarULUpdatedBy.MaxLength = 0;
				colvarULUpdatedBy.AutoIncrement = false;
				colvarULUpdatedBy.IsNullable = true;
				colvarULUpdatedBy.IsPrimaryKey = false;
				colvarULUpdatedBy.IsForeignKey = false;
				colvarULUpdatedBy.IsReadOnly = false;
				colvarULUpdatedBy.DefaultSetting = @"";
				colvarULUpdatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarULUpdatedBy);
				
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
				
				TableSchema.TableColumn colvarFeederImage = new TableSchema.TableColumn(schema);
				colvarFeederImage.ColumnName = "FeederImage";
				colvarFeederImage.DataType = DbType.AnsiString;
				colvarFeederImage.MaxLength = -1;
				colvarFeederImage.AutoIncrement = false;
				colvarFeederImage.IsNullable = true;
				colvarFeederImage.IsPrimaryKey = false;
				colvarFeederImage.IsForeignKey = false;
				colvarFeederImage.IsReadOnly = false;
				colvarFeederImage.DefaultSetting = @"";
				colvarFeederImage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFeederImage);
				
				TableSchema.TableColumn colvarBranchID = new TableSchema.TableColumn(schema);
				colvarBranchID.ColumnName = "BranchID";
				colvarBranchID.DataType = DbType.Int32;
				colvarBranchID.MaxLength = 0;
				colvarBranchID.AutoIncrement = false;
				colvarBranchID.IsNullable = true;
				colvarBranchID.IsPrimaryKey = false;
				colvarBranchID.IsForeignKey = true;
				colvarBranchID.IsReadOnly = false;
				colvarBranchID.DefaultSetting = @"";
				
					colvarBranchID.ForeignKeyTableName = "TblBranch";
				schema.Columns.Add(colvarBranchID);
				
				TableSchema.TableColumn colvarReadingInsertedBy = new TableSchema.TableColumn(schema);
				colvarReadingInsertedBy.ColumnName = "ReadingInsertedBy";
				colvarReadingInsertedBy.DataType = DbType.Int32;
				colvarReadingInsertedBy.MaxLength = 0;
				colvarReadingInsertedBy.AutoIncrement = false;
				colvarReadingInsertedBy.IsNullable = true;
				colvarReadingInsertedBy.IsPrimaryKey = false;
				colvarReadingInsertedBy.IsForeignKey = false;
				colvarReadingInsertedBy.IsReadOnly = false;
				colvarReadingInsertedBy.DefaultSetting = @"";
				colvarReadingInsertedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReadingInsertedBy);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblFeederReading",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FeederReadingID")]
		[Bindable(true)]
		public int FeederReadingID 
		{
			get { return GetColumnValue<int>(Columns.FeederReadingID); }
			set { SetColumnValue(Columns.FeederReadingID, value); }
		}
		  
		[XmlAttribute("FeederID")]
		[Bindable(true)]
		public int? FeederID 
		{
			get { return GetColumnValue<int?>(Columns.FeederID); }
			set { SetColumnValue(Columns.FeederID, value); }
		}
		  
		[XmlAttribute("FeederReadModeID")]
		[Bindable(true)]
		public int? FeederReadModeID 
		{
			get { return GetColumnValue<int?>(Columns.FeederReadModeID); }
			set { SetColumnValue(Columns.FeederReadModeID, value); }
		}
		  
		[XmlAttribute("FeederReadingMonth")]
		[Bindable(true)]
		public string FeederReadingMonth 
		{
			get { return GetColumnValue<string>(Columns.FeederReadingMonth); }
			set { SetColumnValue(Columns.FeederReadingMonth, value); }
		}
		  
		[XmlAttribute("FeederReadingYear")]
		[Bindable(true)]
		public string FeederReadingYear 
		{
			get { return GetColumnValue<string>(Columns.FeederReadingYear); }
			set { SetColumnValue(Columns.FeederReadingYear, value); }
		}
		  
		[XmlAttribute("PreviousReading")]
		[Bindable(true)]
		public decimal? PreviousReading 
		{
			get { return GetColumnValue<decimal?>(Columns.PreviousReading); }
			set { SetColumnValue(Columns.PreviousReading, value); }
		}
		  
		[XmlAttribute("CurrentReading")]
		[Bindable(true)]
		public decimal? CurrentReading 
		{
			get { return GetColumnValue<decimal?>(Columns.CurrentReading); }
			set { SetColumnValue(Columns.CurrentReading, value); }
		}
		  
		[XmlAttribute("TotalUnits")]
		[Bindable(true)]
		public decimal? TotalUnits 
		{
			get { return GetColumnValue<decimal?>(Columns.TotalUnits); }
			set { SetColumnValue(Columns.TotalUnits, value); }
		}
		  
		[XmlAttribute("MultiplyingFactor")]
		[Bindable(true)]
		public decimal? MultiplyingFactor 
		{
			get { return GetColumnValue<decimal?>(Columns.MultiplyingFactor); }
			set { SetColumnValue(Columns.MultiplyingFactor, value); }
		}
		  
		[XmlAttribute("UnitsConsumed")]
		[Bindable(true)]
		public decimal? UnitsConsumed 
		{
			get { return GetColumnValue<decimal?>(Columns.UnitsConsumed); }
			set { SetColumnValue(Columns.UnitsConsumed, value); }
		}
		  
		[XmlAttribute("FeederReadingDate")]
		[Bindable(true)]
		public DateTime? FeederReadingDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.FeederReadingDate); }
			set { SetColumnValue(Columns.FeederReadingDate, value); }
		}
		  
		[XmlAttribute("FeederReadBy")]
		[Bindable(true)]
		public int? FeederReadBy 
		{
			get { return GetColumnValue<int?>(Columns.FeederReadBy); }
			set { SetColumnValue(Columns.FeederReadBy, value); }
		}
		  
		[XmlAttribute("ULCreatedBy")]
		[Bindable(true)]
		public int? ULCreatedBy 
		{
			get { return GetColumnValue<int?>(Columns.ULCreatedBy); }
			set { SetColumnValue(Columns.ULCreatedBy, value); }
		}
		  
		[XmlAttribute("ULUpdatedBy")]
		[Bindable(true)]
		public int? ULUpdatedBy 
		{
			get { return GetColumnValue<int?>(Columns.ULUpdatedBy); }
			set { SetColumnValue(Columns.ULUpdatedBy, value); }
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
		  
		[XmlAttribute("FeederImage")]
		[Bindable(true)]
		public string FeederImage 
		{
			get { return GetColumnValue<string>(Columns.FeederImage); }
			set { SetColumnValue(Columns.FeederImage, value); }
		}
		  
		[XmlAttribute("BranchID")]
		[Bindable(true)]
		public int? BranchID 
		{
			get { return GetColumnValue<int?>(Columns.BranchID); }
			set { SetColumnValue(Columns.BranchID, value); }
		}
		  
		[XmlAttribute("ReadingInsertedBy")]
		[Bindable(true)]
		public int? ReadingInsertedBy 
		{
			get { return GetColumnValue<int?>(Columns.ReadingInsertedBy); }
			set { SetColumnValue(Columns.ReadingInsertedBy, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblBranch ActiveRecord object related to this TblFeederReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBranch TblBranch
		{
			get { return SmartCBSDataAccess.TblBranch.FetchByID(this.BranchID); }
			set { SetColumnValue("BranchID", value.BranchID); }
		}
		
		
		/// <summary>
		/// Returns a TblEmployee ActiveRecord object related to this TblFeederReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblEmployee TblEmployee
		{
			get { return SmartCBSDataAccess.TblEmployee.FetchByID(this.FeederReadBy); }
			set { SetColumnValue("FeederReadBy", value.EmployeeID); }
		}
		
		
		/// <summary>
		/// Returns a TblFeeder ActiveRecord object related to this TblFeederReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblFeeder TblFeeder
		{
			get { return SmartCBSDataAccess.TblFeeder.FetchByID(this.FeederID); }
			set { SetColumnValue("FeederID", value.FeederID); }
		}
		
		
		/// <summary>
		/// Returns a TblFeederReadMode ActiveRecord object related to this TblFeederReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblFeederReadMode TblFeederReadMode
		{
			get { return SmartCBSDataAccess.TblFeederReadMode.FetchByID(this.FeederReadModeID); }
			set { SetColumnValue("FeederReadModeID", value.FeederReadID); }
		}
		
		
		/// <summary>
		/// Returns a UserLogin ActiveRecord object related to this TblFeederReading
		/// 
		/// </summary>
		public SmartCBSDataAccess.UserLogin UserLogin
		{
			get { return SmartCBSDataAccess.UserLogin.FetchByID(this.ULCreatedBy); }
			set { SetColumnValue("ULCreatedBy", value.UserLoginId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varFeederID,int? varFeederReadModeID,string varFeederReadingMonth,string varFeederReadingYear,decimal? varPreviousReading,decimal? varCurrentReading,decimal? varTotalUnits,decimal? varMultiplyingFactor,decimal? varUnitsConsumed,DateTime? varFeederReadingDate,int? varFeederReadBy,int? varULCreatedBy,int? varULUpdatedBy,DateTime? varCreatedOn,DateTime? varModifiedOn,string varFeederImage,int? varBranchID,int? varReadingInsertedBy)
		{
			TblFeederReading item = new TblFeederReading();
			
			item.FeederID = varFeederID;
			
			item.FeederReadModeID = varFeederReadModeID;
			
			item.FeederReadingMonth = varFeederReadingMonth;
			
			item.FeederReadingYear = varFeederReadingYear;
			
			item.PreviousReading = varPreviousReading;
			
			item.CurrentReading = varCurrentReading;
			
			item.TotalUnits = varTotalUnits;
			
			item.MultiplyingFactor = varMultiplyingFactor;
			
			item.UnitsConsumed = varUnitsConsumed;
			
			item.FeederReadingDate = varFeederReadingDate;
			
			item.FeederReadBy = varFeederReadBy;
			
			item.ULCreatedBy = varULCreatedBy;
			
			item.ULUpdatedBy = varULUpdatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedOn = varModifiedOn;
			
			item.FeederImage = varFeederImage;
			
			item.BranchID = varBranchID;
			
			item.ReadingInsertedBy = varReadingInsertedBy;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFeederReadingID,int? varFeederID,int? varFeederReadModeID,string varFeederReadingMonth,string varFeederReadingYear,decimal? varPreviousReading,decimal? varCurrentReading,decimal? varTotalUnits,decimal? varMultiplyingFactor,decimal? varUnitsConsumed,DateTime? varFeederReadingDate,int? varFeederReadBy,int? varULCreatedBy,int? varULUpdatedBy,DateTime? varCreatedOn,DateTime? varModifiedOn,string varFeederImage,int? varBranchID,int? varReadingInsertedBy)
		{
			TblFeederReading item = new TblFeederReading();
			
				item.FeederReadingID = varFeederReadingID;
			
				item.FeederID = varFeederID;
			
				item.FeederReadModeID = varFeederReadModeID;
			
				item.FeederReadingMonth = varFeederReadingMonth;
			
				item.FeederReadingYear = varFeederReadingYear;
			
				item.PreviousReading = varPreviousReading;
			
				item.CurrentReading = varCurrentReading;
			
				item.TotalUnits = varTotalUnits;
			
				item.MultiplyingFactor = varMultiplyingFactor;
			
				item.UnitsConsumed = varUnitsConsumed;
			
				item.FeederReadingDate = varFeederReadingDate;
			
				item.FeederReadBy = varFeederReadBy;
			
				item.ULCreatedBy = varULCreatedBy;
			
				item.ULUpdatedBy = varULUpdatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedOn = varModifiedOn;
			
				item.FeederImage = varFeederImage;
			
				item.BranchID = varBranchID;
			
				item.ReadingInsertedBy = varReadingInsertedBy;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FeederReadingIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadModeIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadingMonthColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadingYearColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PreviousReadingColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CurrentReadingColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalUnitsColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn MultiplyingFactorColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitsConsumedColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadingDateColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederReadByColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ULCreatedByColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ULUpdatedByColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn FeederImageColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn BranchIDColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn ReadingInsertedByColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FeederReadingID = @"FeederReadingID";
			 public static string FeederID = @"FeederID";
			 public static string FeederReadModeID = @"FeederReadModeID";
			 public static string FeederReadingMonth = @"FeederReadingMonth";
			 public static string FeederReadingYear = @"FeederReadingYear";
			 public static string PreviousReading = @"PreviousReading";
			 public static string CurrentReading = @"CurrentReading";
			 public static string TotalUnits = @"TotalUnits";
			 public static string MultiplyingFactor = @"MultiplyingFactor";
			 public static string UnitsConsumed = @"UnitsConsumed";
			 public static string FeederReadingDate = @"FeederReadingDate";
			 public static string FeederReadBy = @"FeederReadBy";
			 public static string ULCreatedBy = @"ULCreatedBy";
			 public static string ULUpdatedBy = @"ULUpdatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string FeederImage = @"FeederImage";
			 public static string BranchID = @"BranchID";
			 public static string ReadingInsertedBy = @"ReadingInsertedBy";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
