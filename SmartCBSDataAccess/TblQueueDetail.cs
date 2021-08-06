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
	/// Strongly-typed collection for the TblQueueDetail class.
	/// </summary>
    [Serializable]
	public partial class TblQueueDetailCollection : ActiveList<TblQueueDetail, TblQueueDetailCollection>
	{	   
		public TblQueueDetailCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblQueueDetailCollection</returns>
		public TblQueueDetailCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblQueueDetail o = this[i];
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
	/// This is an ActiveRecord class which wraps the tblQueueDetail table.
	/// </summary>
	[Serializable]
	public partial class TblQueueDetail : ActiveRecord<TblQueueDetail>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblQueueDetail()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblQueueDetail(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblQueueDetail(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblQueueDetail(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblQueueDetail", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarQueueDetailID = new TableSchema.TableColumn(schema);
				colvarQueueDetailID.ColumnName = "QueueDetailID";
				colvarQueueDetailID.DataType = DbType.Int32;
				colvarQueueDetailID.MaxLength = 0;
				colvarQueueDetailID.AutoIncrement = true;
				colvarQueueDetailID.IsNullable = false;
				colvarQueueDetailID.IsPrimaryKey = true;
				colvarQueueDetailID.IsForeignKey = false;
				colvarQueueDetailID.IsReadOnly = false;
				colvarQueueDetailID.DefaultSetting = @"";
				colvarQueueDetailID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQueueDetailID);
				
				TableSchema.TableColumn colvarQueueID = new TableSchema.TableColumn(schema);
				colvarQueueID.ColumnName = "QueueID";
				colvarQueueID.DataType = DbType.Int32;
				colvarQueueID.MaxLength = 0;
				colvarQueueID.AutoIncrement = false;
				colvarQueueID.IsNullable = true;
				colvarQueueID.IsPrimaryKey = false;
				colvarQueueID.IsForeignKey = true;
				colvarQueueID.IsReadOnly = false;
				colvarQueueID.DefaultSetting = @"";
				
					colvarQueueID.ForeignKeyTableName = "tblQueue";
				schema.Columns.Add(colvarQueueID);
				
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
				
				TableSchema.TableColumn colvarIsProcessed = new TableSchema.TableColumn(schema);
				colvarIsProcessed.ColumnName = "IsProcessed";
				colvarIsProcessed.DataType = DbType.Boolean;
				colvarIsProcessed.MaxLength = 0;
				colvarIsProcessed.AutoIncrement = false;
				colvarIsProcessed.IsNullable = true;
				colvarIsProcessed.IsPrimaryKey = false;
				colvarIsProcessed.IsForeignKey = false;
				colvarIsProcessed.IsReadOnly = false;
				colvarIsProcessed.DefaultSetting = @"";
				colvarIsProcessed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsProcessed);
				
				TableSchema.TableColumn colvarRefNote = new TableSchema.TableColumn(schema);
				colvarRefNote.ColumnName = "RefNote";
				colvarRefNote.DataType = DbType.AnsiString;
				colvarRefNote.MaxLength = -1;
				colvarRefNote.AutoIncrement = false;
				colvarRefNote.IsNullable = true;
				colvarRefNote.IsPrimaryKey = false;
				colvarRefNote.IsForeignKey = false;
				colvarRefNote.IsReadOnly = false;
				colvarRefNote.DefaultSetting = @"";
				colvarRefNote.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRefNote);
				
				TableSchema.TableColumn colvarDueDate = new TableSchema.TableColumn(schema);
				colvarDueDate.ColumnName = "DueDate";
				colvarDueDate.DataType = DbType.DateTime;
				colvarDueDate.MaxLength = 0;
				colvarDueDate.AutoIncrement = false;
				colvarDueDate.IsNullable = true;
				colvarDueDate.IsPrimaryKey = false;
				colvarDueDate.IsForeignKey = false;
				colvarDueDate.IsReadOnly = false;
				colvarDueDate.DefaultSetting = @"";
				colvarDueDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDueDate);
				
				TableSchema.TableColumn colvarIsDismiss = new TableSchema.TableColumn(schema);
				colvarIsDismiss.ColumnName = "IsDismiss";
				colvarIsDismiss.DataType = DbType.Boolean;
				colvarIsDismiss.MaxLength = 0;
				colvarIsDismiss.AutoIncrement = false;
				colvarIsDismiss.IsNullable = true;
				colvarIsDismiss.IsPrimaryKey = false;
				colvarIsDismiss.IsForeignKey = false;
				colvarIsDismiss.IsReadOnly = false;
				colvarIsDismiss.DefaultSetting = @"";
				colvarIsDismiss.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsDismiss);
				
				TableSchema.TableColumn colvarDismissedBy = new TableSchema.TableColumn(schema);
				colvarDismissedBy.ColumnName = "DismissedBy";
				colvarDismissedBy.DataType = DbType.Int32;
				colvarDismissedBy.MaxLength = 0;
				colvarDismissedBy.AutoIncrement = false;
				colvarDismissedBy.IsNullable = true;
				colvarDismissedBy.IsPrimaryKey = false;
				colvarDismissedBy.IsForeignKey = true;
				colvarDismissedBy.IsReadOnly = false;
				colvarDismissedBy.DefaultSetting = @"";
				
					colvarDismissedBy.ForeignKeyTableName = "tblEmployee";
				schema.Columns.Add(colvarDismissedBy);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("tblQueueDetail",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("QueueDetailID")]
		[Bindable(true)]
		public int QueueDetailID 
		{
			get { return GetColumnValue<int>(Columns.QueueDetailID); }
			set { SetColumnValue(Columns.QueueDetailID, value); }
		}
		  
		[XmlAttribute("QueueID")]
		[Bindable(true)]
		public int? QueueID 
		{
			get { return GetColumnValue<int?>(Columns.QueueID); }
			set { SetColumnValue(Columns.QueueID, value); }
		}
		  
		[XmlAttribute("BillID")]
		[Bindable(true)]
		public int? BillID 
		{
			get { return GetColumnValue<int?>(Columns.BillID); }
			set { SetColumnValue(Columns.BillID, value); }
		}
		  
		[XmlAttribute("IsProcessed")]
		[Bindable(true)]
		public bool? IsProcessed 
		{
			get { return GetColumnValue<bool?>(Columns.IsProcessed); }
			set { SetColumnValue(Columns.IsProcessed, value); }
		}
		  
		[XmlAttribute("RefNote")]
		[Bindable(true)]
		public string RefNote 
		{
			get { return GetColumnValue<string>(Columns.RefNote); }
			set { SetColumnValue(Columns.RefNote, value); }
		}
		  
		[XmlAttribute("DueDate")]
		[Bindable(true)]
		public DateTime? DueDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.DueDate); }
			set { SetColumnValue(Columns.DueDate, value); }
		}
		  
		[XmlAttribute("IsDismiss")]
		[Bindable(true)]
		public bool? IsDismiss 
		{
			get { return GetColumnValue<bool?>(Columns.IsDismiss); }
			set { SetColumnValue(Columns.IsDismiss, value); }
		}
		  
		[XmlAttribute("DismissedBy")]
		[Bindable(true)]
		public int? DismissedBy 
		{
			get { return GetColumnValue<int?>(Columns.DismissedBy); }
			set { SetColumnValue(Columns.DismissedBy, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblBill ActiveRecord object related to this TblQueueDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBill TblBill
		{
			get { return SmartCBSDataAccess.TblBill.FetchByID(this.BillID); }
			set { SetColumnValue("BillID", value.BillID); }
		}
		
		
		/// <summary>
		/// Returns a TblEmployee ActiveRecord object related to this TblQueueDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblEmployee TblEmployee
		{
			get { return SmartCBSDataAccess.TblEmployee.FetchByID(this.DismissedBy); }
			set { SetColumnValue("DismissedBy", value.EmployeeID); }
		}
		
		
		/// <summary>
		/// Returns a TblQueue ActiveRecord object related to this TblQueueDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblQueue TblQueue
		{
			get { return SmartCBSDataAccess.TblQueue.FetchByID(this.QueueID); }
			set { SetColumnValue("QueueID", value.QueueID); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varQueueID,int? varBillID,bool? varIsProcessed,string varRefNote,DateTime? varDueDate,bool? varIsDismiss,int? varDismissedBy)
		{
			TblQueueDetail item = new TblQueueDetail();
			
			item.QueueID = varQueueID;
			
			item.BillID = varBillID;
			
			item.IsProcessed = varIsProcessed;
			
			item.RefNote = varRefNote;
			
			item.DueDate = varDueDate;
			
			item.IsDismiss = varIsDismiss;
			
			item.DismissedBy = varDismissedBy;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varQueueDetailID,int? varQueueID,int? varBillID,bool? varIsProcessed,string varRefNote,DateTime? varDueDate,bool? varIsDismiss,int? varDismissedBy)
		{
			TblQueueDetail item = new TblQueueDetail();
			
				item.QueueDetailID = varQueueDetailID;
			
				item.QueueID = varQueueID;
			
				item.BillID = varBillID;
			
				item.IsProcessed = varIsProcessed;
			
				item.RefNote = varRefNote;
			
				item.DueDate = varDueDate;
			
				item.IsDismiss = varIsDismiss;
			
				item.DismissedBy = varDismissedBy;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn QueueDetailIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn QueueIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BillIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsProcessedColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn RefNoteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DueDateColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IsDismissColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn DismissedByColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string QueueDetailID = @"QueueDetailID";
			 public static string QueueID = @"QueueID";
			 public static string BillID = @"BillID";
			 public static string IsProcessed = @"IsProcessed";
			 public static string RefNote = @"RefNote";
			 public static string DueDate = @"DueDate";
			 public static string IsDismiss = @"IsDismiss";
			 public static string DismissedBy = @"DismissedBy";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}