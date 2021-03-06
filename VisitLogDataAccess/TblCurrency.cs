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
namespace VisitLogDataAccess
{
	/// <summary>
	/// Strongly-typed collection for the TblCurrency class.
	/// </summary>
    [Serializable]
	public partial class TblCurrencyCollection : ActiveList<TblCurrency, TblCurrencyCollection>
	{	   
		public TblCurrencyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblCurrencyCollection</returns>
		public TblCurrencyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblCurrency o = this[i];
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
	/// This is an ActiveRecord class which wraps the tblCurrency table.
	/// </summary>
	[Serializable]
	public partial class TblCurrency : ActiveRecord<TblCurrency>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblCurrency()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblCurrency(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblCurrency(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblCurrency(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("tblCurrency", TableType.Table, DataService.GetInstance("PrimaryProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarCurrencyID = new TableSchema.TableColumn(schema);
				colvarCurrencyID.ColumnName = "CurrencyID";
				colvarCurrencyID.DataType = DbType.Int32;
				colvarCurrencyID.MaxLength = 0;
				colvarCurrencyID.AutoIncrement = true;
				colvarCurrencyID.IsNullable = false;
				colvarCurrencyID.IsPrimaryKey = true;
				colvarCurrencyID.IsForeignKey = false;
				colvarCurrencyID.IsReadOnly = false;
				colvarCurrencyID.DefaultSetting = @"";
				colvarCurrencyID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCurrencyID);
				
				TableSchema.TableColumn colvarCurrencyCode = new TableSchema.TableColumn(schema);
				colvarCurrencyCode.ColumnName = "CurrencyCode";
				colvarCurrencyCode.DataType = DbType.AnsiString;
				colvarCurrencyCode.MaxLength = 50;
				colvarCurrencyCode.AutoIncrement = false;
				colvarCurrencyCode.IsNullable = true;
				colvarCurrencyCode.IsPrimaryKey = false;
				colvarCurrencyCode.IsForeignKey = false;
				colvarCurrencyCode.IsReadOnly = false;
				colvarCurrencyCode.DefaultSetting = @"";
				colvarCurrencyCode.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCurrencyCode);
				
				TableSchema.TableColumn colvarCurrencyName = new TableSchema.TableColumn(schema);
				colvarCurrencyName.ColumnName = "CurrencyName";
				colvarCurrencyName.DataType = DbType.AnsiString;
				colvarCurrencyName.MaxLength = 150;
				colvarCurrencyName.AutoIncrement = false;
				colvarCurrencyName.IsNullable = true;
				colvarCurrencyName.IsPrimaryKey = false;
				colvarCurrencyName.IsForeignKey = false;
				colvarCurrencyName.IsReadOnly = false;
				colvarCurrencyName.DefaultSetting = @"";
				colvarCurrencyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCurrencyName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["PrimaryProvider"].AddSchema("tblCurrency",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("CurrencyID")]
		[Bindable(true)]
		public int CurrencyID 
		{
			get { return GetColumnValue<int>(Columns.CurrencyID); }
			set { SetColumnValue(Columns.CurrencyID, value); }
		}
		  
		[XmlAttribute("CurrencyCode")]
		[Bindable(true)]
		public string CurrencyCode 
		{
			get { return GetColumnValue<string>(Columns.CurrencyCode); }
			set { SetColumnValue(Columns.CurrencyCode, value); }
		}
		  
		[XmlAttribute("CurrencyName")]
		[Bindable(true)]
		public string CurrencyName 
		{
			get { return GetColumnValue<string>(Columns.CurrencyName); }
			set { SetColumnValue(Columns.CurrencyName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varCurrencyCode,string varCurrencyName)
		{
			TblCurrency item = new TblCurrency();
			
			item.CurrencyCode = varCurrencyCode;
			
			item.CurrencyName = varCurrencyName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varCurrencyID,string varCurrencyCode,string varCurrencyName)
		{
			TblCurrency item = new TblCurrency();
			
				item.CurrencyID = varCurrencyID;
			
				item.CurrencyCode = varCurrencyCode;
			
				item.CurrencyName = varCurrencyName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn CurrencyIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CurrencyCodeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CurrencyNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string CurrencyID = @"CurrencyID";
			 public static string CurrencyCode = @"CurrencyCode";
			 public static string CurrencyName = @"CurrencyName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
