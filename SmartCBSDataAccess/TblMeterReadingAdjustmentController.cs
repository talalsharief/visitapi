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
    /// Controller class for TblMeterReadingAdjustment
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterReadingAdjustmentController
    {
        // Preload our schema..
        TblMeterReadingAdjustment thisSchemaLoad = new TblMeterReadingAdjustment();
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
        public TblMeterReadingAdjustmentCollection FetchAll()
        {
            TblMeterReadingAdjustmentCollection coll = new TblMeterReadingAdjustmentCollection();
            Query qry = new Query(TblMeterReadingAdjustment.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterReadingAdjustmentCollection FetchByID(object MeterReadingAdjustmentID)
        {
            TblMeterReadingAdjustmentCollection coll = new TblMeterReadingAdjustmentCollection().Where("MeterReadingAdjustmentID", MeterReadingAdjustmentID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterReadingAdjustmentCollection FetchByQuery(Query qry)
        {
            TblMeterReadingAdjustmentCollection coll = new TblMeterReadingAdjustmentCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MeterReadingAdjustmentID)
        {
            return (TblMeterReadingAdjustment.Delete(MeterReadingAdjustmentID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MeterReadingAdjustmentID)
        {
            return (TblMeterReadingAdjustment.Destroy(MeterReadingAdjustmentID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? PreviuosReading,int? CurrentOldReading,int? NewCurrentReading,DateTime? AdjustmentReadingDate,DateTime? CreatedOn,DateTime? ModifiedOn,int? MeterReadingID,bool? IsApprove,int? NewPreviuosReading,decimal? NewMultiplyFactor,string MeterReadingMonth,string MeterReadingYear,decimal? NewUnitConsumed,int? NewCLoad,DateTime? DueDate,string Remarks,string Attachment)
	    {
		    TblMeterReadingAdjustment item = new TblMeterReadingAdjustment();
		    
            item.PreviuosReading = PreviuosReading;
            
            item.CurrentOldReading = CurrentOldReading;
            
            item.NewCurrentReading = NewCurrentReading;
            
            item.AdjustmentReadingDate = AdjustmentReadingDate;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.MeterReadingID = MeterReadingID;
            
            item.IsApprove = IsApprove;
            
            item.NewPreviuosReading = NewPreviuosReading;
            
            item.NewMultiplyFactor = NewMultiplyFactor;
            
            item.MeterReadingMonth = MeterReadingMonth;
            
            item.MeterReadingYear = MeterReadingYear;
            
            item.NewUnitConsumed = NewUnitConsumed;
            
            item.NewCLoad = NewCLoad;
            
            item.DueDate = DueDate;
            
            item.Remarks = Remarks;
            
            item.Attachment = Attachment;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int MeterReadingAdjustmentID,int? PreviuosReading,int? CurrentOldReading,int? NewCurrentReading,DateTime? AdjustmentReadingDate,DateTime? CreatedOn,DateTime? ModifiedOn,int? MeterReadingID,bool? IsApprove,int? NewPreviuosReading,decimal? NewMultiplyFactor,string MeterReadingMonth,string MeterReadingYear,decimal? NewUnitConsumed,int? NewCLoad,DateTime? DueDate,string Remarks,string Attachment)
	    {
		    TblMeterReadingAdjustment item = new TblMeterReadingAdjustment();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.MeterReadingAdjustmentID = MeterReadingAdjustmentID;
				
			item.PreviuosReading = PreviuosReading;
				
			item.CurrentOldReading = CurrentOldReading;
				
			item.NewCurrentReading = NewCurrentReading;
				
			item.AdjustmentReadingDate = AdjustmentReadingDate;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.MeterReadingID = MeterReadingID;
				
			item.IsApprove = IsApprove;
				
			item.NewPreviuosReading = NewPreviuosReading;
				
			item.NewMultiplyFactor = NewMultiplyFactor;
				
			item.MeterReadingMonth = MeterReadingMonth;
				
			item.MeterReadingYear = MeterReadingYear;
				
			item.NewUnitConsumed = NewUnitConsumed;
				
			item.NewCLoad = NewCLoad;
				
			item.DueDate = DueDate;
				
			item.Remarks = Remarks;
				
			item.Attachment = Attachment;
				
	        item.Save(UserName);
	    }
    }
}