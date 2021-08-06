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
	/// Strongly-typed collection for the TblRecoveryTarget class.
	/// </summary>
    [Serializable]
	public partial class TblRecoveryTargetCollection : ActiveList<TblRecoveryTarget, TblRecoveryTargetCollection>
	{	   
		public TblRecoveryTargetCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblRecoveryTargetCollection</returns>
		public TblRecoveryTargetCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblRecoveryTarget o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblRecoveryTarget table.
	/// </summary>
	[Serializable]
	public partial class TblRecoveryTarget : ActiveRecord<TblRecoveryTarget>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblRecoveryTarget()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblRecoveryTarget(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblRecoveryTarget(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblRecoveryTarget(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblRecoveryTarget", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRecoveryTargetID = new TableSchema.TableColumn(schema);
				colvarRecoveryTargetID.ColumnName = "RecoveryTargetID";
				colvarRecoveryTargetID.DataType = DbType.Int32;
				colvarRecoveryTargetID.MaxLength = 0;
				colvarRecoveryTargetID.AutoIncrement = true;
				colvarRecoveryTargetID.IsNullable = false;
				colvarRecoveryTargetID.IsPrimaryKey = true;
				colvarRecoveryTargetID.IsForeignKey = false;
				colvarRecoveryTargetID.IsReadOnly = false;
				colvarRecoveryTargetID.DefaultSetting = @"";
				colvarRecoveryTargetID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecoveryTargetID);
				
				TableSchema.TableColumn colvarAmount = new TableSchema.TableColumn(schema);
				colvarAmount.ColumnName = "Amount";
				colvarAmount.DataType = DbType.Decimal;
				colvarAmount.MaxLength = 0;
				colvarAmount.AutoIncrement = false;
				colvarAmount.IsNullable = true;
				colvarAmount.IsPrimaryKey = false;
				colvarAmount.IsForeignKey = false;
				colvarAmount.IsReadOnly = false;
				colvarAmount.DefaultSetting = @"";
				colvarAmount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAmount);
				
				TableSchema.TableColumn colvarMonth = new TableSchema.TableColumn(schema);
				colvarMonth.ColumnName = "Month";
				colvarMonth.DataType = DbType.AnsiString;
				colvarMonth.MaxLength = 50;
				colvarMonth.AutoIncrement = false;
				colvarMonth.IsNullable = true;
				colvarMonth.IsPrimaryKey = false;
				colvarMonth.IsForeignKey = false;
				colvarMonth.IsReadOnly = false;
				colvarMonth.DefaultSetting = @"";
				colvarMonth.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMonth);
				
				TableSchema.TableColumn colvarYear = new TableSchema.TableColumn(schema);
				colvarYear.ColumnName = "Year";
				colvarYear.DataType = DbType.AnsiString;
				colvarYear.MaxLength = 50;
				colvarYear.AutoIncrement = false;
				colvarYear.IsNullable = true;
				colvarYear.IsPrimaryKey = false;
				colvarYear.IsForeignKey = false;
				colvarYear.IsReadOnly = false;
				colvarYear.DefaultSetting = @"";
				colvarYear.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYear);
				
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
				
				TableSchema.TableColumn colvarBrickID = new TableSchema.TableColumn(schema);
				colvarBrickID.ColumnName = "BrickID";
				colvarBrickID.DataType = DbType.Int32;
				colvarBrickID.MaxLength = 0;
				colvarBrickID.AutoIncrement = false;
				colvarBrickID.IsNullable = true;
				colvarBrickID.IsPrimaryKey = false;
				colvarBrickID.IsForeignKey = true;
				colvarBrickID.IsReadOnly = false;
				colvarBrickID.DefaultSetting = @"";
				
					colvarBrickID.ForeignKeyTableName = "TblBrick";
				schema.Columns.Add(colvarBrickID);
				
				TableSchema.TableColumn colvarBrickTypeID = new TableSchema.TableColumn(schema);
				colvarBrickTypeID.ColumnName = "BrickTypeID";
				colvarBrickTypeID.DataType = DbType.Int32;
				colvarBrickTypeID.MaxLength = 0;
				colvarBrickTypeID.AutoIncrement = false;
				colvarBrickTypeID.IsNullable = true;
				colvarBrickTypeID.IsPrimaryKey = false;
				colvarBrickTypeID.IsForeignKey = true;
				colvarBrickTypeID.IsReadOnly = false;
				colvarBrickTypeID.DefaultSetting = @"";
				
					colvarBrickTypeID.ForeignKeyTableName = "TblBrickType";
				schema.Columns.Add(colvarBrickTypeID);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblRecoveryTarget",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RecoveryTargetID")]
		[Bindable(true)]
		public int RecoveryTargetID 
		{
			get { return GetColumnValue<int>(Columns.RecoveryTargetID); }
			set { SetColumnValue(Columns.RecoveryTargetID, value); }
		}
		  
		[XmlAttribute("Amount")]
		[Bindable(true)]
		public decimal? Amount 
		{
			get { return GetColumnValue<decimal?>(Columns.Amount); }
			set { SetColumnValue(Columns.Amount, value); }
		}
		  
		[XmlAttribute("Month")]
		[Bindable(true)]
		public string Month 
		{
			get { return GetColumnValue<string>(Columns.Month); }
			set { SetColumnValue(Columns.Month, value); }
		}
		  
		[XmlAttribute("Year")]
		[Bindable(true)]
		public string Year 
		{
			get { return GetColumnValue<string>(Columns.Year); }
			set { SetColumnValue(Columns.Year, value); }
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
		  
		[XmlAttribute("BrickID")]
		[Bindable(true)]
		public int? BrickID 
		{
			get { return GetColumnValue<int?>(Columns.BrickID); }
			set { SetColumnValue(Columns.BrickID, value); }
		}
		  
		[XmlAttribute("BrickTypeID")]
		[Bindable(true)]
		public int? BrickTypeID 
		{
			get { return GetColumnValue<int?>(Columns.BrickTypeID); }
			set { SetColumnValue(Columns.BrickTypeID, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblBrick ActiveRecord object related to this TblRecoveryTarget
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBrick TblBrick
		{
			get { return SmartCBSDataAccess.TblBrick.FetchByID(this.BrickID); }
			set { SetColumnValue("BrickID", value.BrickID); }
		}
		
		
		/// <summary>
		/// Returns a TblBrickType ActiveRecord object related to this TblRecoveryTarget
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBrickType TblBrickType
		{
			get { return SmartCBSDataAccess.TblBrickType.FetchByID(this.BrickTypeID); }
			set { SetColumnValue("BrickTypeID", value.BrickTypeID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal? varAmount,string varMonth,string varYear,DateTime? varCreatedOn,DateTime? varModifiedOn,int? varBrickID,int? varBrickTypeID)
		{
			TblRecoveryTarget item = new TblRecoveryTarget();
			
			item.Amount = varAmount;
			
			item.Month = varMonth;
			
			item.Year = varYear;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedOn = varModifiedOn;
			
			item.BrickID = varBrickID;
			
			item.BrickTypeID = varBrickTypeID;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRecoveryTargetID,decimal? varAmount,string varMonth,string varYear,DateTime? varCreatedOn,DateTime? varModifiedOn,int? varBrickID,int? varBrickTypeID)
		{
			TblRecoveryTarget item = new TblRecoveryTarget();
			
				item.RecoveryTargetID = varRecoveryTargetID;
			
				item.Amount = varAmount;
			
				item.Month = varMonth;
			
				item.Year = varYear;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedOn = varModifiedOn;
			
				item.BrickID = varBrickID;
			
				item.BrickTypeID = varBrickTypeID;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RecoveryTargetIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn AmountColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MonthColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn YearColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BrickIDColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn BrickTypeIDColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RecoveryTargetID = @"RecoveryTargetID";
			 public static string Amount = @"Amount";
			 public static string Month = @"Month";
			 public static string Year = @"Year";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string BrickID = @"BrickID";
			 public static string BrickTypeID = @"BrickTypeID";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}