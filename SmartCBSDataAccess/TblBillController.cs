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
    /// Controller class for TblBill
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblBillController
    {
        // Preload our schema..
        TblBill thisSchemaLoad = new TblBill();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TblBillCollection FetchAll()
        {
            TblBillCollection coll = new TblBillCollection();
            Query qry = new Query(TblBill.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBillCollection FetchByID(object BillID)
        {
            TblBillCollection coll = new TblBillCollection().Where("BillID", BillID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBillCollection FetchByQuery(Query qry)
        {
            TblBillCollection coll = new TblBillCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object BillID)
        {
            return (TblBill.Delete(BillID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object BillID)
        {
            return (TblBill.Destroy(BillID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string BillNo,int MeterReadingID,int? NoOfMonths,int BillChargingModeID,int TariffID,int? SLoad,decimal? TotalSD,DateTime? IssueDate,DateTime? DueDate,string BillingMonth,string BillingYear,decimal UnitsBill,decimal? UnitsAdjusted,decimal? BillUpto,decimal? Mdi,decimal? TotalArears,decimal? AmountPaybleDueDate,decimal? AmountPaybleAfterDueDate,decimal? ActualBillPaybleDueDate,decimal? ActualBillPaybleAfterDueDate,DateTime? CreatedOn,DateTime? ModifiedOn,string Status,int? MeterID,int? BillCreatedBy,int? BranchID,bool? IsCancel,int? ConsumerID,string BillBarcode,bool? IsSupplementary)
	    {
		    TblBill item = new TblBill();
		    
            item.BillNo = BillNo;
            
            item.MeterReadingID = MeterReadingID;
            
            item.NoOfMonths = NoOfMonths;
            
            item.BillChargingModeID = BillChargingModeID;
            
            item.TariffID = TariffID;
            
            item.SLoad = SLoad;
            
            item.TotalSD = TotalSD;
            
            item.IssueDate = IssueDate;
            
            item.DueDate = DueDate;
            
            item.BillingMonth = BillingMonth;
            
            item.BillingYear = BillingYear;
            
            item.UnitsBill = UnitsBill;
            
            item.UnitsAdjusted = UnitsAdjusted;
            
            item.BillUpto = BillUpto;
            
            item.Mdi = Mdi;
            
            item.TotalArears = TotalArears;
            
            item.AmountPaybleDueDate = AmountPaybleDueDate;
            
            item.AmountPaybleAfterDueDate = AmountPaybleAfterDueDate;
            
            item.ActualBillPaybleDueDate = ActualBillPaybleDueDate;
            
            item.ActualBillPaybleAfterDueDate = ActualBillPaybleAfterDueDate;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.Status = Status;
            
            item.MeterID = MeterID;
            
            item.BillCreatedBy = BillCreatedBy;
            
            item.BranchID = BranchID;
            
            item.IsCancel = IsCancel;
            
            item.ConsumerID = ConsumerID;
            
            item.BillBarcode = BillBarcode;
            
            item.IsSupplementary = IsSupplementary;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int BillID,string BillNo,int MeterReadingID,int? NoOfMonths,int BillChargingModeID,int TariffID,int? SLoad,decimal? TotalSD,DateTime? IssueDate,DateTime? DueDate,string BillingMonth,string BillingYear,decimal UnitsBill,decimal? UnitsAdjusted,decimal? BillUpto,decimal? Mdi,decimal? TotalArears,decimal? AmountPaybleDueDate,decimal? AmountPaybleAfterDueDate,decimal? ActualBillPaybleDueDate,decimal? ActualBillPaybleAfterDueDate,DateTime? CreatedOn,DateTime? ModifiedOn,string Status,int? MeterID,int? BillCreatedBy,int? BranchID,bool? IsCancel,int? ConsumerID,string BillBarcode,bool? IsSupplementary)
	    {
		    TblBill item = new TblBill();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.BillID = BillID;
				
			item.BillNo = BillNo;
				
			item.MeterReadingID = MeterReadingID;
				
			item.NoOfMonths = NoOfMonths;
				
			item.BillChargingModeID = BillChargingModeID;
				
			item.TariffID = TariffID;
				
			item.SLoad = SLoad;
				
			item.TotalSD = TotalSD;
				
			item.IssueDate = IssueDate;
				
			item.DueDate = DueDate;
				
			item.BillingMonth = BillingMonth;
				
			item.BillingYear = BillingYear;
				
			item.UnitsBill = UnitsBill;
				
			item.UnitsAdjusted = UnitsAdjusted;
				
			item.BillUpto = BillUpto;
				
			item.Mdi = Mdi;
				
			item.TotalArears = TotalArears;
				
			item.AmountPaybleDueDate = AmountPaybleDueDate;
				
			item.AmountPaybleAfterDueDate = AmountPaybleAfterDueDate;
				
			item.ActualBillPaybleDueDate = ActualBillPaybleDueDate;
				
			item.ActualBillPaybleAfterDueDate = ActualBillPaybleAfterDueDate;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.Status = Status;
				
			item.MeterID = MeterID;
				
			item.BillCreatedBy = BillCreatedBy;
				
			item.BranchID = BranchID;
				
			item.IsCancel = IsCancel;
				
			item.ConsumerID = ConsumerID;
				
			item.BillBarcode = BillBarcode;
				
			item.IsSupplementary = IsSupplementary;
				
	        item.Save(UserName);
	    }
    }
}