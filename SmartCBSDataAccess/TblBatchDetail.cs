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
	/// Strongly-typed collection for the TblBatchDetail class.
	/// </summary>
    [Serializable]
	public partial class TblBatchDetailCollection : ActiveList<TblBatchDetail, TblBatchDetailCollection>
	{	   
		public TblBatchDetailCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblBatchDetailCollection</returns>
		public TblBatchDetailCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblBatchDetail o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblBatchDetails table.
	/// </summary>
	[Serializable]
	public partial class TblBatchDetail : ActiveRecord<TblBatchDetail>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblBatchDetail()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblBatchDetail(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblBatchDetail(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblBatchDetail(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblBatchDetails", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarBatchDetailID = new TableSchema.TableColumn(schema);
				colvarBatchDetailID.ColumnName = "BatchDetailID";
				colvarBatchDetailID.DataType = DbType.Int32;
				colvarBatchDetailID.MaxLength = 0;
				colvarBatchDetailID.AutoIncrement = true;
				colvarBatchDetailID.IsNullable = false;
				colvarBatchDetailID.IsPrimaryKey = true;
				colvarBatchDetailID.IsForeignKey = false;
				colvarBatchDetailID.IsReadOnly = false;
				colvarBatchDetailID.DefaultSetting = @"";
				colvarBatchDetailID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBatchDetailID);
				
				TableSchema.TableColumn colvarBatchID = new TableSchema.TableColumn(schema);
				colvarBatchID.ColumnName = "BatchID";
				colvarBatchID.DataType = DbType.Int32;
				colvarBatchID.MaxLength = 0;
				colvarBatchID.AutoIncrement = false;
				colvarBatchID.IsNullable = true;
				colvarBatchID.IsPrimaryKey = false;
				colvarBatchID.IsForeignKey = true;
				colvarBatchID.IsReadOnly = false;
				colvarBatchID.DefaultSetting = @"";
				
					colvarBatchID.ForeignKeyTableName = "tblBatch";
				schema.Columns.Add(colvarBatchID);
				
				TableSchema.TableColumn colvarPMTid = new TableSchema.TableColumn(schema);
				colvarPMTid.ColumnName = "PMTid";
				colvarPMTid.DataType = DbType.Int32;
				colvarPMTid.MaxLength = 0;
				colvarPMTid.AutoIncrement = false;
				colvarPMTid.IsNullable = true;
				colvarPMTid.IsPrimaryKey = false;
				colvarPMTid.IsForeignKey = true;
				colvarPMTid.IsReadOnly = false;
				colvarPMTid.DefaultSetting = @"";
				
					colvarPMTid.ForeignKeyTableName = "TblPMT";
				schema.Columns.Add(colvarPMTid);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("TblBatchDetails",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("BatchDetailID")]
		[Bindable(true)]
		public int BatchDetailID 
		{
			get { return GetColumnValue<int>(Columns.BatchDetailID); }
			set { SetColumnValue(Columns.BatchDetailID, value); }
		}
		  
		[XmlAttribute("BatchID")]
		[Bindable(true)]
		public int? BatchID 
		{
			get { return GetColumnValue<int?>(Columns.BatchID); }
			set { SetColumnValue(Columns.BatchID, value); }
		}
		  
		[XmlAttribute("PMTid")]
		[Bindable(true)]
		public int? PMTid 
		{
			get { return GetColumnValue<int?>(Columns.PMTid); }
			set { SetColumnValue(Columns.PMTid, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblBatch ActiveRecord object related to this TblBatchDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblBatch TblBatch
		{
			get { return SmartCBSDataAccess.TblBatch.FetchByID(this.BatchID); }
			set { SetColumnValue("BatchID", value.BatchID); }
		}
		
		
		/// <summary>
		/// Returns a TblPMT ActiveRecord object related to this TblBatchDetail
		/// 
		/// </summary>
		public SmartCBSDataAccess.TblPMT TblPMT
		{
			get { return SmartCBSDataAccess.TblPMT.FetchByID(this.PMTid); }
			set { SetColumnValue("PMTid", value.Pmtid); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varBatchID,int? varPMTid)
		{
			TblBatchDetail item = new TblBatchDetail();
			
			item.BatchID = varBatchID;
			
			item.PMTid = varPMTid;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varBatchDetailID,int? varBatchID,int? varPMTid)
		{
			TblBatchDetail item = new TblBatchDetail();
			
				item.BatchDetailID = varBatchDetailID;
			
				item.BatchID = varBatchID;
			
				item.PMTid = varPMTid;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn BatchDetailIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn BatchIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PMTidColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string BatchDetailID = @"BatchDetailID";
			 public static string BatchID = @"BatchID";
			 public static string PMTid = @"PMTid";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
