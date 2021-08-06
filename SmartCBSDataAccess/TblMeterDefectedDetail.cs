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
	/// Strongly-typed collection for the TblMeterDefectedDetail class.
	/// </summary>
    [Serializable]
	public partial class TblMeterDefectedDetailCollection : ActiveList<TblMeterDefectedDetail, TblMeterDefectedDetailCollection>
	{	   
		public TblMeterDefectedDetailCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblMeterDefectedDetailCollection</returns>
		public TblMeterDefectedDetailCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblMeterDefectedDetail o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblMeterDefectedDetail table.
	/// </summary>
	[Serializable]
	public partial class TblMeterDefectedDetail : ActiveRecord<TblMeterDefectedDetail>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblMeterDefectedDetail()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblMeterDefectedDetail(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblMeterDefectedDetail(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblMeterDefectedDetail(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblMeterDefectedDetail", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMeterDefectedDetailID = new TableSchema.TableColumn(schema);
				colvarMeterDefectedDetailID.ColumnName = "MeterDefectedDetailID";
				colvarMeterDefectedDetailID.DataType = DbType.Int32;
				colvarMeterDefectedDetailID.MaxLength = 0;
				colvarMeterDefectedDetailID.AutoIncrement = true;
				colvarMeterDefectedDetailID.IsNullable = false;
				colvarMeterDefectedDetailID.IsPrimaryKey = true;
				colvarMeterDefectedDetailID.IsForeignKey = false;
				colvarMeterDefectedDetailID.IsReadOnly = false;
				colvarMeterDefectedDetailID.DefaultSetting = @"";
				colvarMeterDefectedDetailID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMeterDefectedDetailID);
				
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
				
				TableSchema.TableColumn colvarIsDefected = new TableSchema.TableColumn(schema);
				colvarIsDefected.ColumnName = "IsDefected";
				colvarIsDefected.DataType = DbType.Boolean;
				colvarIsDefected.MaxLength = 0;
				colvarIsDefected.AutoIncrement = false;
				colvarIsDefected.IsNullable = true;
				colvarIsDefected.IsPrimaryKey = false;
				colvarIsDefected.IsForeignKey = false;
				colvarIsDefected.IsReadOnly = false;
				colvarIsDefected.DefaultSetting = @"";
				colvarIsDefected.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsDefected);
				
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
				
				TableSchema.TableColumn colvarMeterDefectedID = new TableSchema.TableColumn(schema);
				colvarMeterDefectedID.ColumnName = "MeterDefectedID";
				colvarMeterDefectedID.DataType = DbType.Int32;
				colvarMeterDefectedID.MaxLength = 0;
				colvarMeterDefectedID.AutoIncrement = false;
				colvarMeterDefectedID.IsNullable = true;
				colvarMeterDefectedID.IsPrimaryKey = false;
				colvarMeterDefectedID.IsForeignKey = true;
				colvarMeterDefectedID.IsReadOnly = false;
				colvarMeterDefectedID.DefaultSetting = @"";
				
					colvarMeterDefectedID.ForeignKeyTableName = "TblMeterDefected";
				schema.Columns.Add(colvarMeterDefectedID);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblMeterDefectedDetail",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MeterDefectedDetailID")]
		[Bindable(true)]
		public int MeterDefectedDetailID 
		{
			get { return GetColumnValue<int>(Columns.MeterDefectedDetailID); }
			set { SetColumnValue(Columns.MeterDefectedDetailID, value); }
		}
		  
		[XmlAttribute("MeterID")]
		[Bindable(true)]
		public int? MeterID 
		{
			get { return GetColumnValue<int?>(Columns.MeterID); }
			set { SetColumnValue(Columns.MeterID, value); }
		}
		  
		[XmlAttribute("ConsumerID")]
		[Bindable(true)]
		public int? ConsumerID 
		{
			get { return GetColumnValue<int?>(Columns.ConsumerID); }
			set { SetColumnValue(Columns.ConsumerID, value); }
		}
		  
		[XmlAttribute("IsDefected")]
		[Bindable(true)]
		public bool? IsDefected 
		{
			get { return GetColumnValue<bool?>(Columns.IsDefected); }
			set { SetColumnValue(Columns.IsDefected, value); }
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
		  
		[XmlAttribute("MeterDefectedID")]
		[Bindable(true)]
		public int? MeterDefectedID 
		{
			get { return GetColumnValue<int?>(Columns.MeterDefectedID); }
			set { SetColumnValue(Columns.MeterDefectedID, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SmartCBSDataAccess.TblInventoryLogCollection TblInventoryLogRecords()
		{
			return new SmartCBSDataAccess.TblInventoryLogCollection().Where(TblInventoryLog.Columns.DefectedID, MeterDefectedDetailID).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblConsumer ActiveRecord object related to this TblMeterDefectedDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblConsumer TblConsumer
		{
			get { return SmartCBSDataAccess.TblConsumer.FetchByID(this.ConsumerID); }
			set { SetColumnValue("ConsumerID", value.CunsumerID); }
		}
		
		
		/// <summary>
		/// Returns a TblMeterDefected ActiveRecord object related to this TblMeterDefectedDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblMeterDefected TblMeterDefected
		{
			get { return SmartCBSDataAccess.TblMeterDefected.FetchByID(this.MeterDefectedID); }
			set { SetColumnValue("MeterDefectedID", value.MeterDefectedID); }
		}
		
		
		/// <summary>
		/// Returns a TblMeter ActiveRecord object related to this TblMeterDefectedDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblMeter TblMeter
		{
			get { return SmartCBSDataAccess.TblMeter.FetchByID(this.MeterID); }
			set { SetColumnValue("MeterID", value.MeterID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varMeterID,int? varConsumerID,bool? varIsDefected,DateTime? varCreatedOn,DateTime? varModifiedOn,int? varMeterDefectedID)
		{
			TblMeterDefectedDetail item = new TblMeterDefectedDetail();
			
			item.MeterID = varMeterID;
			
			item.ConsumerID = varConsumerID;
			
			item.IsDefected = varIsDefected;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedOn = varModifiedOn;
			
			item.MeterDefectedID = varMeterDefectedID;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMeterDefectedDetailID,int? varMeterID,int? varConsumerID,bool? varIsDefected,DateTime? varCreatedOn,DateTime? varModifiedOn,int? varMeterDefectedID)
		{
			TblMeterDefectedDetail item = new TblMeterDefectedDetail();
			
				item.MeterDefectedDetailID = varMeterDefectedDetailID;
			
				item.MeterID = varMeterID;
			
				item.ConsumerID = varConsumerID;
			
				item.IsDefected = varIsDefected;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedOn = varModifiedOn;
			
				item.MeterDefectedID = varMeterDefectedID;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MeterDefectedDetailIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MeterIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ConsumerIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsDefectedColumn
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
        
        
        
        public static TableSchema.TableColumn MeterDefectedIDColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MeterDefectedDetailID = @"MeterDefectedDetailID";
			 public static string MeterID = @"MeterID";
			 public static string ConsumerID = @"ConsumerID";
			 public static string IsDefected = @"IsDefected";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string MeterDefectedID = @"MeterDefectedID";
						
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