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
    /// Controller class for TblMeter
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterController
    {
        // Preload our schema..
        TblMeter thisSchemaLoad = new TblMeter();
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
        public TblMeterCollection FetchAll()
        {
            TblMeterCollection coll = new TblMeterCollection();
            Query qry = new Query(TblMeter.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterCollection FetchByID(object MeterID)
        {
            TblMeterCollection coll = new TblMeterCollection().Where("MeterID", MeterID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterCollection FetchByQuery(Query qry)
        {
            TblMeterCollection coll = new TblMeterCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MeterID)
        {
            return (TblMeter.Delete(MeterID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MeterID)
        {
            return (TblMeter.Destroy(MeterID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string MeterNo,int? ConsumerID,int? FeaderID,string AccountNo,DateTime? CreatedOn,DateTime? MeterIssueDate,int? MeterTypeID,int? MeterLife,int? MeterStatusID,DateTime? ModifiedOn,int? BranchID,int? MeterCreatedBy,int? MeterInvDetID,int? TarrifID,int? Pmtid,int? MeterDigit,string SupplementaryMeterNo,string Address,int? SerialNo,int? Mf,int? ConnectionTypeID,int? CategoryID)
	    {
		    TblMeter item = new TblMeter();
		    
            item.MeterNo = MeterNo;
            
            item.ConsumerID = ConsumerID;
            
            item.FeaderID = FeaderID;
            
            item.AccountNo = AccountNo;
            
            item.CreatedOn = CreatedOn;
            
            item.MeterIssueDate = MeterIssueDate;
            
            item.MeterTypeID = MeterTypeID;
            
            item.MeterLife = MeterLife;
            
            item.MeterStatusID = MeterStatusID;
            
            item.ModifiedOn = ModifiedOn;
            
            item.BranchID = BranchID;
            
            item.MeterCreatedBy = MeterCreatedBy;
            
            item.MeterInvDetID = MeterInvDetID;
            
            item.TarrifID = TarrifID;
            
            item.Pmtid = Pmtid;
            
            item.MeterDigit = MeterDigit;
            
            item.SupplementaryMeterNo = SupplementaryMeterNo;
            
            item.Address = Address;
            
            item.SerialNo = SerialNo;
            
            item.Mf = Mf;
            
            item.ConnectionTypeID = ConnectionTypeID;
            
            item.CategoryID = CategoryID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int MeterID,string MeterNo,int? ConsumerID,int? FeaderID,string AccountNo,DateTime? CreatedOn,DateTime? MeterIssueDate,int? MeterTypeID,int? MeterLife,int? MeterStatusID,DateTime? ModifiedOn,int? BranchID,int? MeterCreatedBy,int? MeterInvDetID,int? TarrifID,int? Pmtid,int? MeterDigit,string SupplementaryMeterNo,string Address,int? SerialNo,int? Mf,int? ConnectionTypeID,int? CategoryID)
	    {
		    TblMeter item = new TblMeter();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.MeterID = MeterID;
				
			item.MeterNo = MeterNo;
				
			item.ConsumerID = ConsumerID;
				
			item.FeaderID = FeaderID;
				
			item.AccountNo = AccountNo;
				
			item.CreatedOn = CreatedOn;
				
			item.MeterIssueDate = MeterIssueDate;
				
			item.MeterTypeID = MeterTypeID;
				
			item.MeterLife = MeterLife;
				
			item.MeterStatusID = MeterStatusID;
				
			item.ModifiedOn = ModifiedOn;
				
			item.BranchID = BranchID;
				
			item.MeterCreatedBy = MeterCreatedBy;
				
			item.MeterInvDetID = MeterInvDetID;
				
			item.TarrifID = TarrifID;
				
			item.Pmtid = Pmtid;
				
			item.MeterDigit = MeterDigit;
				
			item.SupplementaryMeterNo = SupplementaryMeterNo;
				
			item.Address = Address;
				
			item.SerialNo = SerialNo;
				
			item.Mf = Mf;
				
			item.ConnectionTypeID = ConnectionTypeID;
				
			item.CategoryID = CategoryID;
				
	        item.Save(UserName);
	    }
    }
}
