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
namespace SmartCBSDataAccess{
    /// <summary>
    /// Strongly-typed collection for the VwTblFeederReadingDatum class.
    /// </summary>
    [Serializable]
    public partial class VwTblFeederReadingDatumCollection : ReadOnlyList<VwTblFeederReadingDatum, VwTblFeederReadingDatumCollection>
    {        
        public VwTblFeederReadingDatumCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the VwTblFeederReadingData view.
    /// </summary>
    [Serializable]
    public partial class VwTblFeederReadingDatum : ReadOnlyRecord<VwTblFeederReadingDatum>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("VwTblFeederReadingData", TableType.View, DataService.GetInstance("PrimaryProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarDataID = new TableSchema.TableColumn(schema);
                colvarDataID.ColumnName = "DataID";
                colvarDataID.DataType = DbType.Int32;
                colvarDataID.MaxLength = 0;
                colvarDataID.AutoIncrement = false;
                colvarDataID.IsNullable = false;
                colvarDataID.IsPrimaryKey = false;
                colvarDataID.IsForeignKey = false;
                colvarDataID.IsReadOnly = false;
                
                schema.Columns.Add(colvarDataID);
                
                TableSchema.TableColumn colvarFeederNo = new TableSchema.TableColumn(schema);
                colvarFeederNo.ColumnName = "FeederNo";
                colvarFeederNo.DataType = DbType.AnsiString;
                colvarFeederNo.MaxLength = 100;
                colvarFeederNo.AutoIncrement = false;
                colvarFeederNo.IsNullable = true;
                colvarFeederNo.IsPrimaryKey = false;
                colvarFeederNo.IsForeignKey = false;
                colvarFeederNo.IsReadOnly = false;
                
                schema.Columns.Add(colvarFeederNo);
                
                TableSchema.TableColumn colvarFeederReadingDate = new TableSchema.TableColumn(schema);
                colvarFeederReadingDate.ColumnName = "FeederReadingDate";
                colvarFeederReadingDate.DataType = DbType.DateTime;
                colvarFeederReadingDate.MaxLength = 0;
                colvarFeederReadingDate.AutoIncrement = false;
                colvarFeederReadingDate.IsNullable = true;
                colvarFeederReadingDate.IsPrimaryKey = false;
                colvarFeederReadingDate.IsForeignKey = false;
                colvarFeederReadingDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarFeederReadingDate);
                
                TableSchema.TableColumn colvarFeederReading = new TableSchema.TableColumn(schema);
                colvarFeederReading.ColumnName = "FeederReading";
                colvarFeederReading.DataType = DbType.Decimal;
                colvarFeederReading.MaxLength = 0;
                colvarFeederReading.AutoIncrement = false;
                colvarFeederReading.IsNullable = true;
                colvarFeederReading.IsPrimaryKey = false;
                colvarFeederReading.IsForeignKey = false;
                colvarFeederReading.IsReadOnly = false;
                
                schema.Columns.Add(colvarFeederReading);
                
                TableSchema.TableColumn colvarRemarks = new TableSchema.TableColumn(schema);
                colvarRemarks.ColumnName = "Remarks";
                colvarRemarks.DataType = DbType.AnsiString;
                colvarRemarks.MaxLength = 100;
                colvarRemarks.AutoIncrement = false;
                colvarRemarks.IsNullable = true;
                colvarRemarks.IsPrimaryKey = false;
                colvarRemarks.IsForeignKey = false;
                colvarRemarks.IsReadOnly = false;
                
                schema.Columns.Add(colvarRemarks);
                
                TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
                colvarCreatedOn.ColumnName = "CreatedOn";
                colvarCreatedOn.DataType = DbType.DateTime;
                colvarCreatedOn.MaxLength = 0;
                colvarCreatedOn.AutoIncrement = false;
                colvarCreatedOn.IsNullable = true;
                colvarCreatedOn.IsPrimaryKey = false;
                colvarCreatedOn.IsForeignKey = false;
                colvarCreatedOn.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarModifiedOn);
                
                TableSchema.TableColumn colvarApprovalID = new TableSchema.TableColumn(schema);
                colvarApprovalID.ColumnName = "ApprovalID";
                colvarApprovalID.DataType = DbType.Int32;
                colvarApprovalID.MaxLength = 0;
                colvarApprovalID.AutoIncrement = false;
                colvarApprovalID.IsNullable = false;
                colvarApprovalID.IsPrimaryKey = false;
                colvarApprovalID.IsForeignKey = false;
                colvarApprovalID.IsReadOnly = false;
                
                schema.Columns.Add(colvarApprovalID);
                
                TableSchema.TableColumn colvarApprovalStatus = new TableSchema.TableColumn(schema);
                colvarApprovalStatus.ColumnName = "ApprovalStatus";
                colvarApprovalStatus.DataType = DbType.AnsiString;
                colvarApprovalStatus.MaxLength = 50;
                colvarApprovalStatus.AutoIncrement = false;
                colvarApprovalStatus.IsNullable = true;
                colvarApprovalStatus.IsPrimaryKey = false;
                colvarApprovalStatus.IsForeignKey = false;
                colvarApprovalStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarApprovalStatus);
                
                TableSchema.TableColumn colvarEmployeeID = new TableSchema.TableColumn(schema);
                colvarEmployeeID.ColumnName = "EmployeeID";
                colvarEmployeeID.DataType = DbType.Int32;
                colvarEmployeeID.MaxLength = 0;
                colvarEmployeeID.AutoIncrement = false;
                colvarEmployeeID.IsNullable = true;
                colvarEmployeeID.IsPrimaryKey = false;
                colvarEmployeeID.IsForeignKey = false;
                colvarEmployeeID.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmployeeID);
                
                TableSchema.TableColumn colvarEmployeeName = new TableSchema.TableColumn(schema);
                colvarEmployeeName.ColumnName = "EmployeeName";
                colvarEmployeeName.DataType = DbType.AnsiString;
                colvarEmployeeName.MaxLength = 100;
                colvarEmployeeName.AutoIncrement = false;
                colvarEmployeeName.IsNullable = true;
                colvarEmployeeName.IsPrimaryKey = false;
                colvarEmployeeName.IsForeignKey = false;
                colvarEmployeeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmployeeName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["PrimaryProvider"].AddSchema("VwTblFeederReadingData",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public VwTblFeederReadingDatum()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwTblFeederReadingDatum(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwTblFeederReadingDatum(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwTblFeederReadingDatum(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("DataID")]
        [Bindable(true)]
        public int DataID 
	    {
		    get
		    {
			    return GetColumnValue<int>("DataID");
		    }
            set 
		    {
			    SetColumnValue("DataID", value);
            }
        }
	      
        [XmlAttribute("FeederNo")]
        [Bindable(true)]
        public string FeederNo 
	    {
		    get
		    {
			    return GetColumnValue<string>("FeederNo");
		    }
            set 
		    {
			    SetColumnValue("FeederNo", value);
            }
        }
	      
        [XmlAttribute("FeederReadingDate")]
        [Bindable(true)]
        public DateTime? FeederReadingDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("FeederReadingDate");
		    }
            set 
		    {
			    SetColumnValue("FeederReadingDate", value);
            }
        }
	      
        [XmlAttribute("FeederReading")]
        [Bindable(true)]
        public decimal? FeederReading 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("FeederReading");
		    }
            set 
		    {
			    SetColumnValue("FeederReading", value);
            }
        }
	      
        [XmlAttribute("Remarks")]
        [Bindable(true)]
        public string Remarks 
	    {
		    get
		    {
			    return GetColumnValue<string>("Remarks");
		    }
            set 
		    {
			    SetColumnValue("Remarks", value);
            }
        }
	      
        [XmlAttribute("CreatedOn")]
        [Bindable(true)]
        public DateTime? CreatedOn 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("CreatedOn");
		    }
            set 
		    {
			    SetColumnValue("CreatedOn", value);
            }
        }
	      
        [XmlAttribute("ModifiedOn")]
        [Bindable(true)]
        public DateTime? ModifiedOn 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("ModifiedOn");
		    }
            set 
		    {
			    SetColumnValue("ModifiedOn", value);
            }
        }
	      
        [XmlAttribute("ApprovalID")]
        [Bindable(true)]
        public int ApprovalID 
	    {
		    get
		    {
			    return GetColumnValue<int>("ApprovalID");
		    }
            set 
		    {
			    SetColumnValue("ApprovalID", value);
            }
        }
	      
        [XmlAttribute("ApprovalStatus")]
        [Bindable(true)]
        public string ApprovalStatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("ApprovalStatus");
		    }
            set 
		    {
			    SetColumnValue("ApprovalStatus", value);
            }
        }
	      
        [XmlAttribute("EmployeeID")]
        [Bindable(true)]
        public int? EmployeeID 
	    {
		    get
		    {
			    return GetColumnValue<int?>("EmployeeID");
		    }
            set 
		    {
			    SetColumnValue("EmployeeID", value);
            }
        }
	      
        [XmlAttribute("EmployeeName")]
        [Bindable(true)]
        public string EmployeeName 
	    {
		    get
		    {
			    return GetColumnValue<string>("EmployeeName");
		    }
            set 
		    {
			    SetColumnValue("EmployeeName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string DataID = @"DataID";
            
            public static string FeederNo = @"FeederNo";
            
            public static string FeederReadingDate = @"FeederReadingDate";
            
            public static string FeederReading = @"FeederReading";
            
            public static string Remarks = @"Remarks";
            
            public static string CreatedOn = @"CreatedOn";
            
            public static string ModifiedOn = @"ModifiedOn";
            
            public static string ApprovalID = @"ApprovalID";
            
            public static string ApprovalStatus = @"ApprovalStatus";
            
            public static string EmployeeID = @"EmployeeID";
            
            public static string EmployeeName = @"EmployeeName";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
