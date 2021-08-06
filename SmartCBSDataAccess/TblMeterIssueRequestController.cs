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
    /// Controller class for TblMeterIssueRequests
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterIssueRequestController
    {
        // Preload our schema..
        TblMeterIssueRequest thisSchemaLoad = new TblMeterIssueRequest();
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
        public TblMeterIssueRequestCollection FetchAll()
        {
            TblMeterIssueRequestCollection coll = new TblMeterIssueRequestCollection();
            Query qry = new Query(TblMeterIssueRequest.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterIssueRequestCollection FetchByID(object MeterIssueRequestID)
        {
            TblMeterIssueRequestCollection coll = new TblMeterIssueRequestCollection().Where("MeterIssueRequestID", MeterIssueRequestID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterIssueRequestCollection FetchByQuery(Query qry)
        {
            TblMeterIssueRequestCollection coll = new TblMeterIssueRequestCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MeterIssueRequestID)
        {
            return (TblMeterIssueRequest.Delete(MeterIssueRequestID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MeterIssueRequestID)
        {
            return (TblMeterIssueRequest.Destroy(MeterIssueRequestID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? NewConnectionID,DateTime? RequestGeneratedOn,int? RequestGeneratedBy,int? NoOfMeters,int? DefectedID,int? ReplacementID,bool? IsApproved,bool? IsManual,int? ApprovedBy,DateTime? ApprovedOn,DateTime? CreatedOn,DateTime? ModifiedOn,string MeterIssueRequestNo,int? RequestSerial,bool? IsIssued,int? ConsumerID,int? BranchID)
	    {
		    TblMeterIssueRequest item = new TblMeterIssueRequest();
		    
            item.NewConnectionID = NewConnectionID;
            
            item.RequestGeneratedOn = RequestGeneratedOn;
            
            item.RequestGeneratedBy = RequestGeneratedBy;
            
            item.NoOfMeters = NoOfMeters;
            
            item.DefectedID = DefectedID;
            
            item.ReplacementID = ReplacementID;
            
            item.IsApproved = IsApproved;
            
            item.IsManual = IsManual;
            
            item.ApprovedBy = ApprovedBy;
            
            item.ApprovedOn = ApprovedOn;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.MeterIssueRequestNo = MeterIssueRequestNo;
            
            item.RequestSerial = RequestSerial;
            
            item.IsIssued = IsIssued;
            
            item.ConsumerID = ConsumerID;
            
            item.BranchID = BranchID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int MeterIssueRequestID,int? NewConnectionID,DateTime? RequestGeneratedOn,int? RequestGeneratedBy,int? NoOfMeters,int? DefectedID,int? ReplacementID,bool? IsApproved,bool? IsManual,int? ApprovedBy,DateTime? ApprovedOn,DateTime? CreatedOn,DateTime? ModifiedOn,string MeterIssueRequestNo,int? RequestSerial,bool? IsIssued,int? ConsumerID,int? BranchID)
	    {
		    TblMeterIssueRequest item = new TblMeterIssueRequest();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.MeterIssueRequestID = MeterIssueRequestID;
				
			item.NewConnectionID = NewConnectionID;
				
			item.RequestGeneratedOn = RequestGeneratedOn;
				
			item.RequestGeneratedBy = RequestGeneratedBy;
				
			item.NoOfMeters = NoOfMeters;
				
			item.DefectedID = DefectedID;
				
			item.ReplacementID = ReplacementID;
				
			item.IsApproved = IsApproved;
				
			item.IsManual = IsManual;
				
			item.ApprovedBy = ApprovedBy;
				
			item.ApprovedOn = ApprovedOn;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.MeterIssueRequestNo = MeterIssueRequestNo;
				
			item.RequestSerial = RequestSerial;
				
			item.IsIssued = IsIssued;
				
			item.ConsumerID = ConsumerID;
				
			item.BranchID = BranchID;
				
	        item.Save(UserName);
	    }
    }
}
