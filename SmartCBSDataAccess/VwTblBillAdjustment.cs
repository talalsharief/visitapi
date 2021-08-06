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
    /// Strongly-typed collection for the VwTblBillAdjustment class.
    /// </summary>
    [Serializable]
    public partial class VwTblBillAdjustmentCollection : ReadOnlyList<VwTblBillAdjustment, VwTblBillAdjustmentCollection>
    {        
        public VwTblBillAdjustmentCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the VwTblBillAdjustment view.
    /// </summary>
    [Serializable]
    public partial class VwTblBillAdjustment : ReadOnlyRecord<VwTblBillAdjustment>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("VwTblBillAdjustment", TableType.View, DataService.GetInstance("PrimaryProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarBillAdjustmentID = new TableSchema.TableColumn(schema);
                colvarBillAdjustmentID.ColumnName = "BillAdjustmentID";
                colvarBillAdjustmentID.DataType = DbType.Int32;
                colvarBillAdjustmentID.MaxLength = 0;
                colvarBillAdjustmentID.AutoIncrement = false;
                colvarBillAdjustmentID.IsNullable = false;
                colvarBillAdjustmentID.IsPrimaryKey = false;
                colvarBillAdjustmentID.IsForeignKey = false;
                colvarBillAdjustmentID.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillAdjustmentID);
                
                TableSchema.TableColumn colvarIsApprove = new TableSchema.TableColumn(schema);
                colvarIsApprove.ColumnName = "IsApprove";
                colvarIsApprove.DataType = DbType.Boolean;
                colvarIsApprove.MaxLength = 0;
                colvarIsApprove.AutoIncrement = false;
                colvarIsApprove.IsNullable = true;
                colvarIsApprove.IsPrimaryKey = false;
                colvarIsApprove.IsForeignKey = false;
                colvarIsApprove.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsApprove);
                
                TableSchema.TableColumn colvarAdjustmentAmount = new TableSchema.TableColumn(schema);
                colvarAdjustmentAmount.ColumnName = "AdjustmentAmount";
                colvarAdjustmentAmount.DataType = DbType.Decimal;
                colvarAdjustmentAmount.MaxLength = 0;
                colvarAdjustmentAmount.AutoIncrement = false;
                colvarAdjustmentAmount.IsNullable = true;
                colvarAdjustmentAmount.IsPrimaryKey = false;
                colvarAdjustmentAmount.IsForeignKey = false;
                colvarAdjustmentAmount.IsReadOnly = false;
                
                schema.Columns.Add(colvarAdjustmentAmount);
                
                TableSchema.TableColumn colvarBillID = new TableSchema.TableColumn(schema);
                colvarBillID.ColumnName = "BillID";
                colvarBillID.DataType = DbType.Int32;
                colvarBillID.MaxLength = 0;
                colvarBillID.AutoIncrement = false;
                colvarBillID.IsNullable = false;
                colvarBillID.IsPrimaryKey = false;
                colvarBillID.IsForeignKey = false;
                colvarBillID.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillID);
                
                TableSchema.TableColumn colvarBillNo = new TableSchema.TableColumn(schema);
                colvarBillNo.ColumnName = "BillNo";
                colvarBillNo.DataType = DbType.AnsiString;
                colvarBillNo.MaxLength = 100;
                colvarBillNo.AutoIncrement = false;
                colvarBillNo.IsNullable = true;
                colvarBillNo.IsPrimaryKey = false;
                colvarBillNo.IsForeignKey = false;
                colvarBillNo.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillNo);
                
                TableSchema.TableColumn colvarNoOfMonths = new TableSchema.TableColumn(schema);
                colvarNoOfMonths.ColumnName = "NoOfMonths";
                colvarNoOfMonths.DataType = DbType.Int32;
                colvarNoOfMonths.MaxLength = 0;
                colvarNoOfMonths.AutoIncrement = false;
                colvarNoOfMonths.IsNullable = true;
                colvarNoOfMonths.IsPrimaryKey = false;
                colvarNoOfMonths.IsForeignKey = false;
                colvarNoOfMonths.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoOfMonths);
                
                TableSchema.TableColumn colvarSLoad = new TableSchema.TableColumn(schema);
                colvarSLoad.ColumnName = "SLoad";
                colvarSLoad.DataType = DbType.Int32;
                colvarSLoad.MaxLength = 0;
                colvarSLoad.AutoIncrement = false;
                colvarSLoad.IsNullable = true;
                colvarSLoad.IsPrimaryKey = false;
                colvarSLoad.IsForeignKey = false;
                colvarSLoad.IsReadOnly = false;
                
                schema.Columns.Add(colvarSLoad);
                
                TableSchema.TableColumn colvarTotalSD = new TableSchema.TableColumn(schema);
                colvarTotalSD.ColumnName = "TotalSD";
                colvarTotalSD.DataType = DbType.Decimal;
                colvarTotalSD.MaxLength = 0;
                colvarTotalSD.AutoIncrement = false;
                colvarTotalSD.IsNullable = true;
                colvarTotalSD.IsPrimaryKey = false;
                colvarTotalSD.IsForeignKey = false;
                colvarTotalSD.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalSD);
                
                TableSchema.TableColumn colvarIssueDate = new TableSchema.TableColumn(schema);
                colvarIssueDate.ColumnName = "IssueDate";
                colvarIssueDate.DataType = DbType.DateTime;
                colvarIssueDate.MaxLength = 0;
                colvarIssueDate.AutoIncrement = false;
                colvarIssueDate.IsNullable = true;
                colvarIssueDate.IsPrimaryKey = false;
                colvarIssueDate.IsForeignKey = false;
                colvarIssueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarIssueDate);
                
                TableSchema.TableColumn colvarDueDate = new TableSchema.TableColumn(schema);
                colvarDueDate.ColumnName = "DueDate";
                colvarDueDate.DataType = DbType.DateTime;
                colvarDueDate.MaxLength = 0;
                colvarDueDate.AutoIncrement = false;
                colvarDueDate.IsNullable = true;
                colvarDueDate.IsPrimaryKey = false;
                colvarDueDate.IsForeignKey = false;
                colvarDueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarDueDate);
                
                TableSchema.TableColumn colvarBillingMonth = new TableSchema.TableColumn(schema);
                colvarBillingMonth.ColumnName = "BillingMonth";
                colvarBillingMonth.DataType = DbType.AnsiString;
                colvarBillingMonth.MaxLength = 50;
                colvarBillingMonth.AutoIncrement = false;
                colvarBillingMonth.IsNullable = true;
                colvarBillingMonth.IsPrimaryKey = false;
                colvarBillingMonth.IsForeignKey = false;
                colvarBillingMonth.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillingMonth);
                
                TableSchema.TableColumn colvarBillingYear = new TableSchema.TableColumn(schema);
                colvarBillingYear.ColumnName = "BillingYear";
                colvarBillingYear.DataType = DbType.AnsiString;
                colvarBillingYear.MaxLength = 50;
                colvarBillingYear.AutoIncrement = false;
                colvarBillingYear.IsNullable = true;
                colvarBillingYear.IsPrimaryKey = false;
                colvarBillingYear.IsForeignKey = false;
                colvarBillingYear.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillingYear);
                
                TableSchema.TableColumn colvarUnitsBill = new TableSchema.TableColumn(schema);
                colvarUnitsBill.ColumnName = "UnitsBill";
                colvarUnitsBill.DataType = DbType.Decimal;
                colvarUnitsBill.MaxLength = 0;
                colvarUnitsBill.AutoIncrement = false;
                colvarUnitsBill.IsNullable = false;
                colvarUnitsBill.IsPrimaryKey = false;
                colvarUnitsBill.IsForeignKey = false;
                colvarUnitsBill.IsReadOnly = false;
                
                schema.Columns.Add(colvarUnitsBill);
                
                TableSchema.TableColumn colvarUnitsAdjusted = new TableSchema.TableColumn(schema);
                colvarUnitsAdjusted.ColumnName = "UnitsAdjusted";
                colvarUnitsAdjusted.DataType = DbType.Decimal;
                colvarUnitsAdjusted.MaxLength = 0;
                colvarUnitsAdjusted.AutoIncrement = false;
                colvarUnitsAdjusted.IsNullable = true;
                colvarUnitsAdjusted.IsPrimaryKey = false;
                colvarUnitsAdjusted.IsForeignKey = false;
                colvarUnitsAdjusted.IsReadOnly = false;
                
                schema.Columns.Add(colvarUnitsAdjusted);
                
                TableSchema.TableColumn colvarBillUpto = new TableSchema.TableColumn(schema);
                colvarBillUpto.ColumnName = "BillUpto";
                colvarBillUpto.DataType = DbType.Decimal;
                colvarBillUpto.MaxLength = 0;
                colvarBillUpto.AutoIncrement = false;
                colvarBillUpto.IsNullable = true;
                colvarBillUpto.IsPrimaryKey = false;
                colvarBillUpto.IsForeignKey = false;
                colvarBillUpto.IsReadOnly = false;
                
                schema.Columns.Add(colvarBillUpto);
                
                TableSchema.TableColumn colvarMdi = new TableSchema.TableColumn(schema);
                colvarMdi.ColumnName = "MDI";
                colvarMdi.DataType = DbType.Decimal;
                colvarMdi.MaxLength = 0;
                colvarMdi.AutoIncrement = false;
                colvarMdi.IsNullable = true;
                colvarMdi.IsPrimaryKey = false;
                colvarMdi.IsForeignKey = false;
                colvarMdi.IsReadOnly = false;
                
                schema.Columns.Add(colvarMdi);
                
                TableSchema.TableColumn colvarTotalArears = new TableSchema.TableColumn(schema);
                colvarTotalArears.ColumnName = "TotalArears";
                colvarTotalArears.DataType = DbType.Decimal;
                colvarTotalArears.MaxLength = 0;
                colvarTotalArears.AutoIncrement = false;
                colvarTotalArears.IsNullable = true;
                colvarTotalArears.IsPrimaryKey = false;
                colvarTotalArears.IsForeignKey = false;
                colvarTotalArears.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalArears);
                
                TableSchema.TableColumn colvarAmountPaybleDueDate = new TableSchema.TableColumn(schema);
                colvarAmountPaybleDueDate.ColumnName = "AmountPaybleDueDate";
                colvarAmountPaybleDueDate.DataType = DbType.Decimal;
                colvarAmountPaybleDueDate.MaxLength = 0;
                colvarAmountPaybleDueDate.AutoIncrement = false;
                colvarAmountPaybleDueDate.IsNullable = true;
                colvarAmountPaybleDueDate.IsPrimaryKey = false;
                colvarAmountPaybleDueDate.IsForeignKey = false;
                colvarAmountPaybleDueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarAmountPaybleDueDate);
                
                TableSchema.TableColumn colvarAmountPaybleAfterDueDate = new TableSchema.TableColumn(schema);
                colvarAmountPaybleAfterDueDate.ColumnName = "AmountPaybleAfterDueDate";
                colvarAmountPaybleAfterDueDate.DataType = DbType.Decimal;
                colvarAmountPaybleAfterDueDate.MaxLength = 0;
                colvarAmountPaybleAfterDueDate.AutoIncrement = false;
                colvarAmountPaybleAfterDueDate.IsNullable = true;
                colvarAmountPaybleAfterDueDate.IsPrimaryKey = false;
                colvarAmountPaybleAfterDueDate.IsForeignKey = false;
                colvarAmountPaybleAfterDueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarAmountPaybleAfterDueDate);
                
                TableSchema.TableColumn colvarActualBillPaybleDueDate = new TableSchema.TableColumn(schema);
                colvarActualBillPaybleDueDate.ColumnName = "ActualBillPaybleDueDate";
                colvarActualBillPaybleDueDate.DataType = DbType.Decimal;
                colvarActualBillPaybleDueDate.MaxLength = 0;
                colvarActualBillPaybleDueDate.AutoIncrement = false;
                colvarActualBillPaybleDueDate.IsNullable = true;
                colvarActualBillPaybleDueDate.IsPrimaryKey = false;
                colvarActualBillPaybleDueDate.IsForeignKey = false;
                colvarActualBillPaybleDueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarActualBillPaybleDueDate);
                
                TableSchema.TableColumn colvarActualBillPaybleAfterDueDate = new TableSchema.TableColumn(schema);
                colvarActualBillPaybleAfterDueDate.ColumnName = "ActualBillPaybleAfterDueDate";
                colvarActualBillPaybleAfterDueDate.DataType = DbType.Decimal;
                colvarActualBillPaybleAfterDueDate.MaxLength = 0;
                colvarActualBillPaybleAfterDueDate.AutoIncrement = false;
                colvarActualBillPaybleAfterDueDate.IsNullable = true;
                colvarActualBillPaybleAfterDueDate.IsPrimaryKey = false;
                colvarActualBillPaybleAfterDueDate.IsForeignKey = false;
                colvarActualBillPaybleAfterDueDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarActualBillPaybleAfterDueDate);
                
                TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
                colvarStatus.ColumnName = "Status";
                colvarStatus.DataType = DbType.AnsiString;
                colvarStatus.MaxLength = 50;
                colvarStatus.AutoIncrement = false;
                colvarStatus.IsNullable = true;
                colvarStatus.IsPrimaryKey = false;
                colvarStatus.IsForeignKey = false;
                colvarStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarStatus);
                
                TableSchema.TableColumn colvarRemarks = new TableSchema.TableColumn(schema);
                colvarRemarks.ColumnName = "Remarks";
                colvarRemarks.DataType = DbType.AnsiString;
                colvarRemarks.MaxLength = -1;
                colvarRemarks.AutoIncrement = false;
                colvarRemarks.IsNullable = true;
                colvarRemarks.IsPrimaryKey = false;
                colvarRemarks.IsForeignKey = false;
                colvarRemarks.IsReadOnly = false;
                
                schema.Columns.Add(colvarRemarks);
                
                TableSchema.TableColumn colvarIsPending = new TableSchema.TableColumn(schema);
                colvarIsPending.ColumnName = "IsPending";
                colvarIsPending.DataType = DbType.Boolean;
                colvarIsPending.MaxLength = 0;
                colvarIsPending.AutoIncrement = false;
                colvarIsPending.IsNullable = true;
                colvarIsPending.IsPrimaryKey = false;
                colvarIsPending.IsForeignKey = false;
                colvarIsPending.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsPending);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["PrimaryProvider"].AddSchema("VwTblBillAdjustment",schema);
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
	    public VwTblBillAdjustment()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwTblBillAdjustment(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwTblBillAdjustment(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwTblBillAdjustment(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("BillAdjustmentID")]
        [Bindable(true)]
        public int BillAdjustmentID 
	    {
		    get
		    {
			    return GetColumnValue<int>("BillAdjustmentID");
		    }
            set 
		    {
			    SetColumnValue("BillAdjustmentID", value);
            }
        }
	      
        [XmlAttribute("IsApprove")]
        [Bindable(true)]
        public bool? IsApprove 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("IsApprove");
		    }
            set 
		    {
			    SetColumnValue("IsApprove", value);
            }
        }
	      
        [XmlAttribute("AdjustmentAmount")]
        [Bindable(true)]
        public decimal? AdjustmentAmount 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("AdjustmentAmount");
		    }
            set 
		    {
			    SetColumnValue("AdjustmentAmount", value);
            }
        }
	      
        [XmlAttribute("BillID")]
        [Bindable(true)]
        public int BillID 
	    {
		    get
		    {
			    return GetColumnValue<int>("BillID");
		    }
            set 
		    {
			    SetColumnValue("BillID", value);
            }
        }
	      
        [XmlAttribute("BillNo")]
        [Bindable(true)]
        public string BillNo 
	    {
		    get
		    {
			    return GetColumnValue<string>("BillNo");
		    }
            set 
		    {
			    SetColumnValue("BillNo", value);
            }
        }
	      
        [XmlAttribute("NoOfMonths")]
        [Bindable(true)]
        public int? NoOfMonths 
	    {
		    get
		    {
			    return GetColumnValue<int?>("NoOfMonths");
		    }
            set 
		    {
			    SetColumnValue("NoOfMonths", value);
            }
        }
	      
        [XmlAttribute("SLoad")]
        [Bindable(true)]
        public int? SLoad 
	    {
		    get
		    {
			    return GetColumnValue<int?>("SLoad");
		    }
            set 
		    {
			    SetColumnValue("SLoad", value);
            }
        }
	      
        [XmlAttribute("TotalSD")]
        [Bindable(true)]
        public decimal? TotalSD 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalSD");
		    }
            set 
		    {
			    SetColumnValue("TotalSD", value);
            }
        }
	      
        [XmlAttribute("IssueDate")]
        [Bindable(true)]
        public DateTime? IssueDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("IssueDate");
		    }
            set 
		    {
			    SetColumnValue("IssueDate", value);
            }
        }
	      
        [XmlAttribute("DueDate")]
        [Bindable(true)]
        public DateTime? DueDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("DueDate");
		    }
            set 
		    {
			    SetColumnValue("DueDate", value);
            }
        }
	      
        [XmlAttribute("BillingMonth")]
        [Bindable(true)]
        public string BillingMonth 
	    {
		    get
		    {
			    return GetColumnValue<string>("BillingMonth");
		    }
            set 
		    {
			    SetColumnValue("BillingMonth", value);
            }
        }
	      
        [XmlAttribute("BillingYear")]
        [Bindable(true)]
        public string BillingYear 
	    {
		    get
		    {
			    return GetColumnValue<string>("BillingYear");
		    }
            set 
		    {
			    SetColumnValue("BillingYear", value);
            }
        }
	      
        [XmlAttribute("UnitsBill")]
        [Bindable(true)]
        public decimal UnitsBill 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("UnitsBill");
		    }
            set 
		    {
			    SetColumnValue("UnitsBill", value);
            }
        }
	      
        [XmlAttribute("UnitsAdjusted")]
        [Bindable(true)]
        public decimal? UnitsAdjusted 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("UnitsAdjusted");
		    }
            set 
		    {
			    SetColumnValue("UnitsAdjusted", value);
            }
        }
	      
        [XmlAttribute("BillUpto")]
        [Bindable(true)]
        public decimal? BillUpto 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("BillUpto");
		    }
            set 
		    {
			    SetColumnValue("BillUpto", value);
            }
        }
	      
        [XmlAttribute("Mdi")]
        [Bindable(true)]
        public decimal? Mdi 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("MDI");
		    }
            set 
		    {
			    SetColumnValue("MDI", value);
            }
        }
	      
        [XmlAttribute("TotalArears")]
        [Bindable(true)]
        public decimal? TotalArears 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalArears");
		    }
            set 
		    {
			    SetColumnValue("TotalArears", value);
            }
        }
	      
        [XmlAttribute("AmountPaybleDueDate")]
        [Bindable(true)]
        public decimal? AmountPaybleDueDate 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("AmountPaybleDueDate");
		    }
            set 
		    {
			    SetColumnValue("AmountPaybleDueDate", value);
            }
        }
	      
        [XmlAttribute("AmountPaybleAfterDueDate")]
        [Bindable(true)]
        public decimal? AmountPaybleAfterDueDate 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("AmountPaybleAfterDueDate");
		    }
            set 
		    {
			    SetColumnValue("AmountPaybleAfterDueDate", value);
            }
        }
	      
        [XmlAttribute("ActualBillPaybleDueDate")]
        [Bindable(true)]
        public decimal? ActualBillPaybleDueDate 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("ActualBillPaybleDueDate");
		    }
            set 
		    {
			    SetColumnValue("ActualBillPaybleDueDate", value);
            }
        }
	      
        [XmlAttribute("ActualBillPaybleAfterDueDate")]
        [Bindable(true)]
        public decimal? ActualBillPaybleAfterDueDate 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("ActualBillPaybleAfterDueDate");
		    }
            set 
		    {
			    SetColumnValue("ActualBillPaybleAfterDueDate", value);
            }
        }
	      
        [XmlAttribute("Status")]
        [Bindable(true)]
        public string Status 
	    {
		    get
		    {
			    return GetColumnValue<string>("Status");
		    }
            set 
		    {
			    SetColumnValue("Status", value);
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
	      
        [XmlAttribute("IsPending")]
        [Bindable(true)]
        public bool? IsPending 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("IsPending");
		    }
            set 
		    {
			    SetColumnValue("IsPending", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string BillAdjustmentID = @"BillAdjustmentID";
            
            public static string IsApprove = @"IsApprove";
            
            public static string AdjustmentAmount = @"AdjustmentAmount";
            
            public static string BillID = @"BillID";
            
            public static string BillNo = @"BillNo";
            
            public static string NoOfMonths = @"NoOfMonths";
            
            public static string SLoad = @"SLoad";
            
            public static string TotalSD = @"TotalSD";
            
            public static string IssueDate = @"IssueDate";
            
            public static string DueDate = @"DueDate";
            
            public static string BillingMonth = @"BillingMonth";
            
            public static string BillingYear = @"BillingYear";
            
            public static string UnitsBill = @"UnitsBill";
            
            public static string UnitsAdjusted = @"UnitsAdjusted";
            
            public static string BillUpto = @"BillUpto";
            
            public static string Mdi = @"MDI";
            
            public static string TotalArears = @"TotalArears";
            
            public static string AmountPaybleDueDate = @"AmountPaybleDueDate";
            
            public static string AmountPaybleAfterDueDate = @"AmountPaybleAfterDueDate";
            
            public static string ActualBillPaybleDueDate = @"ActualBillPaybleDueDate";
            
            public static string ActualBillPaybleAfterDueDate = @"ActualBillPaybleAfterDueDate";
            
            public static string Status = @"Status";
            
            public static string Remarks = @"Remarks";
            
            public static string IsPending = @"IsPending";
            
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