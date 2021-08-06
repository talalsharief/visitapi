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
	/// Strongly-typed collection for the TblMeterStatus class.
	/// </summary>
    [Serializable]
	public partial class TblMeterStatusCollection : ActiveList<TblMeterStatus, TblMeterStatusCollection>
	{	   
		public TblMeterStatusCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblMeterStatusCollection</returns>
		public TblMeterStatusCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblMeterStatus o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblMeterStatus table.
	/// </summary>
	[Serializable]
	public partial class TblMeterStatus : ActiveRecord<TblMeterStatus>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblMeterStatus()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblMeterStatus(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblMeterStatus(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblMeterStatus(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblMeterStatus", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMeterStatusID = new TableSchema.TableColumn(schema);
				colvarMeterStatusID.ColumnName = "MeterStatusID";
				colvarMeterStatusID.DataType = DbType.Int32;
				colvarMeterStatusID.MaxLength = 0;
				colvarMeterStatusID.AutoIncrement = true;
				colvarMeterStatusID.IsNullable = false;
				colvarMeterStatusID.IsPrimaryKey = true;
				colvarMeterStatusID.IsForeignKey = false;
				colvarMeterStatusID.IsReadOnly = false;
				colvarMeterStatusID.DefaultSetting = @"";
				colvarMeterStatusID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMeterStatusID);
				
				TableSchema.TableColumn colvarMeterStatusName = new TableSchema.TableColumn(schema);
				colvarMeterStatusName.ColumnName = "MeterStatusName";
				colvarMeterStatusName.DataType = DbType.AnsiString;
				colvarMeterStatusName.MaxLength = 50;
				colvarMeterStatusName.AutoIncrement = false;
				colvarMeterStatusName.IsNullable = true;
				colvarMeterStatusName.IsPrimaryKey = false;
				colvarMeterStatusName.IsForeignKey = false;
				colvarMeterStatusName.IsReadOnly = false;
				colvarMeterStatusName.DefaultSetting = @"";
				colvarMeterStatusName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMeterStatusName);
				
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
				DataService.Providers["PrimaryProvider"].AddSchema("TblMeterStatus",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MeterStatusID")]
		[Bindable(true)]
		public int MeterStatusID 
		{
			get { return GetColumnValue<int>(Columns.MeterStatusID); }
			set { SetColumnValue(Columns.MeterStatusID, value); }
		}
		  
		[XmlAttribute("MeterStatusName")]
		[Bindable(true)]
		public string MeterStatusName 
		{
			get { return GetColumnValue<string>(Columns.MeterStatusName); }
			set { SetColumnValue(Columns.MeterStatusName, value); }
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
        
		
		public SmartCBSDataAccess.TblMeterCollection TblMeterRecords()
		{
			return new SmartCBSDataAccess.TblMeterCollection().Where(TblMeter.Columns.MeterStatusID, MeterStatusID).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMeterStatusName,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblMeterStatus item = new TblMeterStatus();
			
			item.MeterStatusName = varMeterStatusName;
			
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
		public static void Update(int varMeterStatusID,string varMeterStatusName,DateTime? varCreatedOn,DateTime? varModifiedOn)
		{
			TblMeterStatus item = new TblMeterStatus();
			
				item.MeterStatusID = varMeterStatusID;
			
				item.MeterStatusName = varMeterStatusName;
			
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
        
        
        public static TableSchema.TableColumn MeterStatusIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MeterStatusNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MeterStatusID = @"MeterStatusID";
			 public static string MeterStatusName = @"MeterStatusName";
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