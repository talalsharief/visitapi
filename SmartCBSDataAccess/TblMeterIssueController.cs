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
    /// Controller class for TblMeterIssue
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterIssueController
    {
        // Preload our schema..
        TblMeterIssue thisSchemaLoad = new TblMeterIssue();
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
        public TblMeterIssueCollection FetchAll()
        {
            TblMeterIssueCollection coll = new TblMeterIssueCollection();
            Query qry = new Query(TblMeterIssue.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterIssueCollection FetchByID(object IssueID)
        {
            TblMeterIssueCollection coll = new TblMeterIssueCollection().Where("IssueID", IssueID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterIssueCollection FetchByQuery(Query qry)
        {
            TblMeterIssueCollection coll = new TblMeterIssueCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IssueID)
        {
            return (TblMeterIssue.Delete(IssueID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IssueID)
        {
            return (TblMeterIssue.Destroy(IssueID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? MeterID,DateTime? ModifiedOn,DateTime? CreatedOn,DateTime? IssueDate,int? IssuedBy,int? BranchID,bool? IsApprove,int? NewConnectionID,int? MeterDefectedID,int? ReplacementID)
	    {
		    TblMeterIssue item = new TblMeterIssue();
		    
            item.MeterID = MeterID;
            
            item.ModifiedOn = ModifiedOn;
            
            item.CreatedOn = CreatedOn;
            
            item.IssueDate = IssueDate;
            
            item.IssuedBy = IssuedBy;
            
            item.BranchID = BranchID;
            
            item.IsApprove = IsApprove;
            
            item.NewConnectionID = NewConnectionID;
            
            item.MeterDefectedID = MeterDefectedID;
            
            item.ReplacementID = ReplacementID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IssueID,int? MeterID,DateTime? ModifiedOn,DateTime? CreatedOn,DateTime? IssueDate,int? IssuedBy,int? BranchID,bool? IsApprove,int? NewConnectionID,int? MeterDefectedID,int? ReplacementID)
	    {
		    TblMeterIssue item = new TblMeterIssue();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IssueID = IssueID;
				
			item.MeterID = MeterID;
				
			item.ModifiedOn = ModifiedOn;
				
			item.CreatedOn = CreatedOn;
				
			item.IssueDate = IssueDate;
				
			item.IssuedBy = IssuedBy;
				
			item.BranchID = BranchID;
				
			item.IsApprove = IsApprove;
				
			item.NewConnectionID = NewConnectionID;
				
			item.MeterDefectedID = MeterDefectedID;
				
			item.ReplacementID = ReplacementID;
				
	        item.Save(UserName);
	    }
    }
}
