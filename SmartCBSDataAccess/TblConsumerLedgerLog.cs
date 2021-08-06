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
	/// Strongly-typed collection for the TblConsumerLedgerLog class.
	/// </summary>
    [Serializable]
	public partial class TblConsumerLedgerLogCollection : ActiveList<TblConsumerLedgerLog, TblConsumerLedgerLogCollection>
	{	   
		public TblConsumerLedgerLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblConsumerLedgerLogCollection</returns>
		public TblConsumerLedgerLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblConsumerLedgerLog o = this[i];
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
	/// This is an ActiveRecord class which wraps the tblConsumerLedgerLog table.
	/// </summary>
	[Serializable]
	public partial class TblConsumerLedgerLog : ActiveRecord<TblConsumerLedgerLog>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblConsumerLedgerLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblConsumerLedgerLog(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblConsumerLedgerLog(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblConsumerLedgerLog(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblConsumerLedgerLog", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarCustomerLedgerLogID = new TableSchema.TableColumn(schema);
				colvarCustomerLedgerLogID.ColumnName = "CustomerLedgerLogID";
				colvarCustomerLedgerLogID.DataType = DbType.Int32;
				colvarCustomerLedgerLogID.MaxLength = 0;
				colvarCustomerLedgerLogID.AutoIncrement = true;
				colvarCustomerLedgerLogID.IsNullable = false;
				colvarCustomerLedgerLogID.IsPrimaryKey = true;
				colvarCustomerLedgerLogID.IsForeignKey = false;
				colvarCustomerLedgerLogID.IsReadOnly = false;
				colvarCustomerLedgerLogID.DefaultSetting = @"";
				colvarCustomerLedgerLogID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCustomerLedgerLogID);
				
				TableSchema.TableColumn colvarAmount = new TableSchema.TableColumn(schema);
				colvarAmount.ColumnName = "Amount";
				colvarAmount.DataType = DbType.Int32;
				colvarAmount.MaxLength = 0;
				colvarAmount.AutoIncrement = false;
				colvarAmount.IsNullable = true;
				colvarAmount.IsPrimaryKey = false;
				colvarAmount.IsForeignKey = false;
				colvarAmount.IsReadOnly = false;
				colvarAmount.DefaultSetting = @"";
				colvarAmount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAmount);
				
				TableSchema.TableColumn colvarDateX = new TableSchema.TableColumn(schema);
				colvarDateX.ColumnName = "Date";
				colvarDateX.DataType = DbType.DateTime;
				colvarDateX.MaxLength = 0;
				colvarDateX.AutoIncrement = false;
				colvarDateX.IsNullable = true;
				colvarDateX.IsPrimaryKey = false;
				colvarDateX.IsForeignKey = false;
				colvarDateX.IsReadOnly = false;
				colvarDateX.DefaultSetting = @"";
				colvarDateX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDateX);
				
				TableSchema.TableColumn colvarPlus = new TableSchema.TableColumn(schema);
				colvarPlus.ColumnName = "Plus";
				colvarPlus.DataType = DbType.Boolean;
				colvarPlus.MaxLength = 0;
				colvarPlus.AutoIncrement = false;
				colvarPlus.IsNullable = true;
				colvarPlus.IsPrimaryKey = false;
				colvarPlus.IsForeignKey = false;
				colvarPlus.IsReadOnly = false;
				colvarPlus.DefaultSetting = @"";
				colvarPlus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlus);
				
				TableSchema.TableColumn colvarBillID = new TableSchema.TableColumn(schema);
				colvarBillID.ColumnName = "BillID";
				colvarBillID.DataType = DbType.Int32;
				colvarBillID.MaxLength = 0;
				colvarBillID.AutoIncrement = false;
				colvarBillID.IsNullable = true;
				colvarBillID.IsPrimaryKey = false;
				colvarBillID.IsForeignKey = true;
				colvarBillID.IsReadOnly = false;
				colvarBillID.DefaultSetting = @"";
				
					colvarBillID.ForeignKeyTableName = "TblBill";
				schema.Columns.Add(colvarBillID);
				
				TableSchema.TableColumn colvarCustomerLedgerID = new TableSchema.TableColumn(schema);
				colvarCustomerLedgerID.ColumnName = "CustomerLedgerID";
				colvarCustomerLedgerID.DataType = DbType.Int32;
				colvarCustomerLedgerID.MaxLength = 0;
				colvarCustomerLedgerID.AutoIncrement = false;
				colvarCustomerLedgerID.IsNullable = true;
				colvarCustomerLedgerID.IsPrimaryKey = false;
				colvarCustomerLedgerID.IsForeignKey = true;
				colvarCustomerLedgerID.IsReadOnly = false;
				colvarCustomerLedgerID.DefaultSetting = @"";
				
					colvarCustomerLedgerID.ForeignKeyTableName = "tblConsumerLedger";
				schema.Columns.Add(colvarCustomerLedgerID);
				
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
				
				TableSchema.TableColumn colvarMeterID = new TableSchema.TableColumn(schema);
				colvarMeterID.ColumnName = "MeterID";
				colvarMeterID.DataType = DbType.Int32;
				colvarMeterID.MaxLength = 0;
				colvarMeterID.AutoIncrement = false;
				colvarMeterID.IsNullable = true;
				colvarMeterID.IsPrimaryKey = false;
				colvarMeterID.IsForeignKey = true;
				colvarMeterID.IsReadOnly = false;
				colvarMeterID.DefaultSetting = @"";
				
					colvarMeterID.ForeignKeyTableName = "TblMeter";
				schema.Columns.Add(colvarMeterID);
				
				TableSchema.TableColumn colvarLoginID = new TableSchema.TableColumn(schema);
				colvarLoginID.ColumnName = "LoginID";
				colvarLoginID.DataType = DbType.Int32;
				colvarLoginID.MaxLength = 0;
				colvarLoginID.AutoIncrement = false;
				colvarLoginID.IsNullable = true;
				colvarLoginID.IsPrimaryKey = false;
				colvarLoginID.IsForeignKey = false;
				colvarLoginID.IsReadOnly = false;
				colvarLoginID.DefaultSetting = @"";
				colvarLoginID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoginID);
				
				TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
				colvarDescription.ColumnName = "Description";
				colvarDescription.DataType = DbType.AnsiString;
				colvarDescription.MaxLength = -1;
				colvarDescription.AutoIncrement = false;
				colvarDescription.IsNullable = true;
				colvarDescription.IsPrimaryKey = false;
				colvarDescription.IsForeignKey = false;
				colvarDescription.IsReadOnly = false;
				colvarDescription.DefaultSetting = @"";
				colvarDescription.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescription);
				
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
				DataService.Providers["PrimaryProvider"].AddSchema("tblConsumerLedgerLog",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("CustomerLedgerLogID")]
		[Bindable(true)]
		public int CustomerLedgerLogID 
		{
			get { return GetColumnValue<int>(Columns.CustomerLedgerLogID); }
			set { SetColumnValue(Columns.CustomerLedgerLogID, value); }
		}
		  
		[XmlAttribute("Amount")]
		[Bindable(true)]
		public int? Amount 
		{
			get { return GetColumnValue<int?>(Columns.Amount); }
			set { SetColumnValue(Columns.Amount, value); }
		}
		  
		[XmlAttribute("DateX")]
		[Bindable(true)]
		public DateTime? DateX 
		{
			get { return GetColumnValue<DateTime?>(Columns.DateX); }
			set { SetColumnValue(Columns.DateX, value); }
		}
		  
		[XmlAttribute("Plus")]
		[Bindable(true)]
		public bool? Plus 
		{
			get { return GetColumnValue<bool?>(Columns.Plus); }
			set { SetColumnValue(Columns.Plus, value); }
		}
		  
		[XmlAttribute("BillID")]
		[Bindable(true)]
		public int? BillID 
		{
			get { return GetColumnValue<int?>(Columns.BillID); }
			set { SetColumnValue(Columns.BillID, value); }
		}
		  
		[XmlAttribute("CustomerLedgerID")]
		[Bindable(true)]
		public int? CustomerLedgerID 
		{
			get { return GetColumnValue<int?>(Columns.CustomerLedgerID); }
			set { SetColumnValue(Columns.CustomerLedgerID, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime? CreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("MeterID")]
		[Bindable(true)]
		public int? MeterID 
		{
			get { return GetColumnValue<int?>(Columns.MeterID); }
			set { SetColumnValue(Columns.MeterID, value); }
		}
		  
		[XmlAttribute("LoginID")]
		[Bindable(true)]
		public int? LoginID 
		{
			get { return GetColumnValue<int?>(Columns.LoginID); }
			set { SetColumnValue(Columns.LoginID, value); }
		}
		  
		[XmlAttribute("Description")]
		[Bindable(true)]
		public string Description 
		{
			get { return GetColumnValue<string>(Columns.Description); }
			set { SetColumnValue(Columns.Description, value); }
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
		/// Returns a TblMeter ActiveRecord object related to this TblConsumerLedgerLog
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblMeter TblMeter
		{
			get { return SmartCBSDataAccess.TblMeter.FetchByID(this.MeterID); }
			set { SetColumnValue("MeterID", value.MeterID); }
		}
		
		
		/// <summary>
		/// Returns a TblBill ActiveRecord object related to this TblConsumerLedgerLog
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBill TblBill
		{
			get { return SmartCBSDataAccess.TblBill.FetchByID(this.BillID); }
			set { SetColumnValue("BillID", value.BillID); }
		}
		
		
		/// <summary>
		/// Returns a TblConsumerLedger ActiveRecord object related to this TblConsumerLedgerLog
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblConsumerLedger TblConsumerLedger
		{
			get { return SmartCBSDataAccess.TblConsumerLedger.FetchByID(this.CustomerLedgerID); }
			set { SetColumnValue("CustomerLedgerID", value.CustomerLedgerID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varAmount,DateTime? varDateX,bool? varPlus,int? varBillID,int? varCustomerLedgerID,DateTime? varCreatedOn,int? varMeterID,int? varLoginID,string varDescription,DateTime? varModifiedOn)
		{
			TblConsumerLedgerLog item = new TblConsumerLedgerLog();
			
			item.Amount = varAmount;
			
			item.DateX = varDateX;
			
			item.Plus = varPlus;
			
			item.BillID = varBillID;
			
			item.CustomerLedgerID = varCustomerLedgerID;
			
			item.CreatedOn = varCreatedOn;
			
			item.MeterID = varMeterID;
			
			item.LoginID = varLoginID;
			
			item.Description = varDescription;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varCustomerLedgerLogID,int? varAmount,DateTime? varDateX,bool? varPlus,int? varBillID,int? varCustomerLedgerID,DateTime? varCreatedOn,int? varMeterID,int? varLoginID,string varDescription,DateTime? varModifiedOn)
		{
			TblConsumerLedgerLog item = new TblConsumerLedgerLog();
			
				item.CustomerLedgerLogID = varCustomerLedgerLogID;
			
				item.Amount = varAmount;
			
				item.DateX = varDateX;
			
				item.Plus = varPlus;
			
				item.BillID = varBillID;
			
				item.CustomerLedgerID = varCustomerLedgerID;
			
				item.CreatedOn = varCreatedOn;
			
				item.MeterID = varMeterID;
			
				item.LoginID = varLoginID;
			
				item.Description = varDescription;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn CustomerLedgerLogIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn AmountColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DateXColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PlusColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn BillIDColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CustomerLedgerIDColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn MeterIDColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn LoginIDColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string CustomerLedgerLogID = @"CustomerLedgerLogID";
			 public static string Amount = @"Amount";
			 public static string DateX = @"Date";
			 public static string Plus = @"Plus";
			 public static string BillID = @"BillID";
			 public static string CustomerLedgerID = @"CustomerLedgerID";
			 public static string CreatedOn = @"CreatedOn";
			 public static string MeterID = @"MeterID";
			 public static string LoginID = @"LoginID";
			 public static string Description = @"Description";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}