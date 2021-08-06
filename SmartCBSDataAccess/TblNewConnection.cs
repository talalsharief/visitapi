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
	/// Strongly-typed collection for the TblNewConnection class.
	/// </summary>
    [Serializable]
	public partial class TblNewConnectionCollection : ActiveList<TblNewConnection, TblNewConnectionCollection>
	{	   
		public TblNewConnectionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblNewConnectionCollection</returns>
		public TblNewConnectionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblNewConnection o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblNewConnection table.
	/// </summary>
	[Serializable]
	public partial class TblNewConnection : ActiveRecord<TblNewConnection>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblNewConnection()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblNewConnection(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblNewConnection(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblNewConnection(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblNewConnection", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarNewConnectionID = new TableSchema.TableColumn(schema);
				colvarNewConnectionID.ColumnName = "NewConnectionID";
				colvarNewConnectionID.DataType = DbType.Int32;
				colvarNewConnectionID.MaxLength = 0;
				colvarNewConnectionID.AutoIncrement = true;
				colvarNewConnectionID.IsNullable = false;
				colvarNewConnectionID.IsPrimaryKey = true;
				colvarNewConnectionID.IsForeignKey = false;
				colvarNewConnectionID.IsReadOnly = false;
				colvarNewConnectionID.DefaultSetting = @"";
				colvarNewConnectionID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNewConnectionID);
				
				TableSchema.TableColumn colvarConsumerID = new TableSchema.TableColumn(schema);
				colvarConsumerID.ColumnName = "ConsumerID";
				colvarConsumerID.DataType = DbType.Int32;
				colvarConsumerID.MaxLength = 0;
				colvarConsumerID.AutoIncrement = false;
				colvarConsumerID.IsNullable = true;
				colvarConsumerID.IsPrimaryKey = false;
				colvarConsumerID.IsForeignKey = true;
				colvarConsumerID.IsReadOnly = false;
				colvarConsumerID.DefaultSetting = @"";
				
					colvarConsumerID.ForeignKeyTableName = "TblConsumer";
				schema.Columns.Add(colvarConsumerID);
				
				TableSchema.TableColumn colvarRequestCode = new TableSchema.TableColumn(schema);
				colvarRequestCode.ColumnName = "RequestCode";
				colvarRequestCode.DataType = DbType.AnsiString;
				colvarRequestCode.MaxLength = 100;
				colvarRequestCode.AutoIncrement = false;
				colvarRequestCode.IsNullable = true;
				colvarRequestCode.IsPrimaryKey = false;
				colvarRequestCode.IsForeignKey = false;
				colvarRequestCode.IsReadOnly = false;
				colvarRequestCode.DefaultSetting = @"";
				colvarRequestCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRequestCode);
				
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
				
				TableSchema.TableColumn colvarIsApprove = new TableSchema.TableColumn(schema);
				colvarIsApprove.ColumnName = "IsApprove";
				colvarIsApprove.DataType = DbType.Boolean;
				colvarIsApprove.MaxLength = 0;
				colvarIsApprove.AutoIncrement = false;
				colvarIsApprove.IsNullable = true;
				colvarIsApprove.IsPrimaryKey = false;
				colvarIsApprove.IsForeignKey = false;
				colvarIsApprove.IsReadOnly = false;
				colvarIsApprove.DefaultSetting = @"";
				colvarIsApprove.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApprove);
				
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
				
				TableSchema.TableColumn colvarNCCreatedBy = new TableSchema.TableColumn(schema);
				colvarNCCreatedBy.ColumnName = "NCCreatedBy";
				colvarNCCreatedBy.DataType = DbType.Int32;
				colvarNCCreatedBy.MaxLength = 0;
				colvarNCCreatedBy.AutoIncrement = false;
				colvarNCCreatedBy.IsNullable = true;
				colvarNCCreatedBy.IsPrimaryKey = false;
				colvarNCCreatedBy.IsForeignKey = true;
				colvarNCCreatedBy.IsReadOnly = false;
				colvarNCCreatedBy.DefaultSetting = @"";
				
					colvarNCCreatedBy.ForeignKeyTableName = "tblEmployee";
				schema.Columns.Add(colvarNCCreatedBy);
				
				TableSchema.TableColumn colvarMeterTypeID = new TableSchema.TableColumn(schema);
				colvarMeterTypeID.ColumnName = "MeterTypeID";
				colvarMeterTypeID.DataType = DbType.Int32;
				colvarMeterTypeID.MaxLength = 0;
				colvarMeterTypeID.AutoIncrement = false;
				colvarMeterTypeID.IsNullable = true;
				colvarMeterTypeID.IsPrimaryKey = false;
				colvarMeterTypeID.IsForeignKey = true;
				colvarMeterTypeID.IsReadOnly = false;
				colvarMeterTypeID.DefaultSetting = @"";
				
					colvarMeterTypeID.ForeignKeyTableName = "TblMeterType";
				schema.Columns.Add(colvarMeterTypeID);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblNewConnection",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("NewConnectionID")]
		[Bindable(true)]
		public int NewConnectionID 
		{
			get { return GetColumnValue<int>(Columns.NewConnectionID); }
			set { SetColumnValue(Columns.NewConnectionID, value); }
		}
		  
		[XmlAttribute("ConsumerID")]
		[Bindable(true)]
		public int? ConsumerID 
		{
			get { return GetColumnValue<int?>(Columns.ConsumerID); }
			set { SetColumnValue(Columns.ConsumerID, value); }
		}
		  
		[XmlAttribute("RequestCode")]
		[Bindable(true)]
		public string RequestCode 
		{
			get { return GetColumnValue<string>(Columns.RequestCode); }
			set { SetColumnValue(Columns.RequestCode, value); }
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
		  
		[XmlAttribute("IsApprove")]
		[Bindable(true)]
		public bool? IsApprove 
		{
			get { return GetColumnValue<bool?>(Columns.IsApprove); }
			set { SetColumnValue(Columns.IsApprove, value); }
		}
		  
		[XmlAttribute("BranchID")]
		[Bindable(true)]
		public int? BranchID 
		{
			get { return GetColumnValue<int?>(Columns.BranchID); }
			set { SetColumnValue(Columns.BranchID, value); }
		}
		  
		[XmlAttribute("NCCreatedBy")]
		[Bindable(true)]
		public int? NCCreatedBy 
		{
			get { return GetColumnValue<int?>(Columns.NCCreatedBy); }
			set { SetColumnValue(Columns.NCCreatedBy, value); }
		}
		  
		[XmlAttribute("MeterTypeID")]
		[Bindable(true)]
		public int? MeterTypeID 
		{
			get { return GetColumnValue<int?>(Columns.MeterTypeID); }
			set { SetColumnValue(Columns.MeterTypeID, value); }
		}
		  
		[XmlAttribute("BrickTypeID")]
		[Bindable(true)]
		public int? BrickTypeID 
		{
			get { return GetColumnValue<int?>(Columns.BrickTypeID); }
			set { SetColumnValue(Columns.BrickTypeID, value); }
		}
		  
		[XmlAttribute("BrickID")]
		[Bindable(true)]
		public int? BrickID 
		{
			get { return GetColumnValue<int?>(Columns.BrickID); }
			set { SetColumnValue(Columns.BrickID, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SmartCBSDataAccess.TblMeterIssueCollection TblMeterIssueRecords()
		{
			return new SmartCBSDataAccess.TblMeterIssueCollection().Where(TblMeterIssue.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblMeterIssueRequestCollection TblMeterIssueRequests()
		{
			return new SmartCBSDataAccess.TblMeterIssueRequestCollection().Where(TblMeterIssueRequest.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConComRepProfileCollection TblNewConComRepProfileRecords()
		{
			return new SmartCBSDataAccess.TblNewConComRepProfileCollection().Where(TblNewConComRepProfile.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConDocumentRequiredDetCollection TblNewConDocumentRequiredDetRecords()
		{
			return new SmartCBSDataAccess.TblNewConDocumentRequiredDetCollection().Where(TblNewConDocumentRequiredDet.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConLocationCollection TblNewConLocationRecords()
		{
			return new SmartCBSDataAccess.TblNewConLocationCollection().Where(TblNewConLocation.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConPermisesDetailCollection TblNewConPermisesDetailRecords()
		{
			return new SmartCBSDataAccess.TblNewConPermisesDetailCollection().Where(TblNewConPermisesDetail.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConRefrencesDetailCollection TblNewConRefrencesDetailRecords()
		{
			return new SmartCBSDataAccess.TblNewConRefrencesDetailCollection().Where(TblNewConRefrencesDetail.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConServiceReqDetailCollection TblNewConServiceReqDetailRecords()
		{
			return new SmartCBSDataAccess.TblNewConServiceReqDetailCollection().Where(TblNewConServiceReqDetail.Columns.NewConnectionID, NewConnectionID).Load();
		}
		public SmartCBSDataAccess.TblNewConTypeOfConDetailCollection TblNewConTypeOfConDetailRecords()
		{
			return new SmartCBSDataAccess.TblNewConTypeOfConDetailCollection().Where(TblNewConTypeOfConDetail.Columns.NewConnectionID, NewConnectionID).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblBranch ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBranch TblBranch
		{
			get { return SmartCBSDataAccess.TblBranch.FetchByID(this.BranchID); }
			set { SetColumnValue("BranchID", value.BranchID); }
		}
		
		
		/// <summary>
		/// Returns a TblBrick ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBrick TblBrick
		{
			get { return SmartCBSDataAccess.TblBrick.FetchByID(this.BrickID); }
			set { SetColumnValue("BrickID", value.BrickID); }
		}
		
		
		/// <summary>
		/// Returns a TblBrickType ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBrickType TblBrickType
		{
			get { return SmartCBSDataAccess.TblBrickType.FetchByID(this.BrickTypeID); }
			set { SetColumnValue("BrickTypeID", value.BrickTypeID); }
		}
		
		
		/// <summary>
		/// Returns a TblConsumer ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblConsumer TblConsumer
		{
			get { return SmartCBSDataAccess.TblConsumer.FetchByID(this.ConsumerID); }
			set { SetColumnValue("ConsumerID", value.CunsumerID); }
		}
		
		
		/// <summary>
		/// Returns a TblEmployee ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblEmployee TblEmployee
		{
			get { return SmartCBSDataAccess.TblEmployee.FetchByID(this.NCCreatedBy); }
			set { SetColumnValue("NCCreatedBy", value.EmployeeID); }
		}
		
		
		/// <summary>
		/// Returns a TblMeterType ActiveRecord object related to this TblNewConnection
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblMeterType TblMeterType
		{
			get { return SmartCBSDataAccess.TblMeterType.FetchByID(this.MeterTypeID); }
			set { SetColumnValue("MeterTypeID", value.MeterTypeID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varConsumerID,string varRequestCode,DateTime? varCreatedOn,DateTime? varModifiedOn,bool? varIsApprove,int? varBranchID,int? varNCCreatedBy,int? varMeterTypeID,int? varBrickTypeID,int? varBrickID)
		{
			TblNewConnection item = new TblNewConnection();
			
			item.ConsumerID = varConsumerID;
			
			item.RequestCode = varRequestCode;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedOn = varModifiedOn;
			
			item.IsApprove = varIsApprove;
			
			item.BranchID = varBranchID;
			
			item.NCCreatedBy = varNCCreatedBy;
			
			item.MeterTypeID = varMeterTypeID;
			
			item.BrickTypeID = varBrickTypeID;
			
			item.BrickID = varBrickID;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varNewConnectionID,int? varConsumerID,string varRequestCode,DateTime? varCreatedOn,DateTime? varModifiedOn,bool? varIsApprove,int? varBranchID,int? varNCCreatedBy,int? varMeterTypeID,int? varBrickTypeID,int? varBrickID)
		{
			TblNewConnection item = new TblNewConnection();
			
				item.NewConnectionID = varNewConnectionID;
			
				item.ConsumerID = varConsumerID;
			
				item.RequestCode = varRequestCode;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedOn = varModifiedOn;
			
				item.IsApprove = varIsApprove;
			
				item.BranchID = varBranchID;
			
				item.NCCreatedBy = varNCCreatedBy;
			
				item.MeterTypeID = varMeterTypeID;
			
				item.BrickTypeID = varBrickTypeID;
			
				item.BrickID = varBrickID;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn NewConnectionIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ConsumerIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn RequestCodeColumn
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
        
        
        
        public static TableSchema.TableColumn IsApproveColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BranchIDColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NCCreatedByColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn MeterTypeIDColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn BrickTypeIDColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BrickIDColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string NewConnectionID = @"NewConnectionID";
			 public static string ConsumerID = @"ConsumerID";
			 public static string RequestCode = @"RequestCode";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string IsApprove = @"IsApprove";
			 public static string BranchID = @"BranchID";
			 public static string NCCreatedBy = @"NCCreatedBy";
			 public static string MeterTypeID = @"MeterTypeID";
			 public static string BrickTypeID = @"BrickTypeID";
			 public static string BrickID = @"BrickID";
						
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