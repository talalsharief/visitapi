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
    /// Controller class for TblFeederReadingData
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblFeederReadingDatumController
    {
        // Preload our schema..
        TblFeederReadingDatum thisSchemaLoad = new TblFeederReadingDatum();
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
        public TblFeederReadingDatumCollection FetchAll()
        {
            TblFeederReadingDatumCollection coll = new TblFeederReadingDatumCollection();
            Query qry = new Query(TblFeederReadingDatum.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblFeederReadingDatumCollection FetchByID(object DataID)
        {
            TblFeederReadingDatumCollection coll = new TblFeederReadingDatumCollection().Where("DataID", DataID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblFeederReadingDatumCollection FetchByQuery(Query qry)
        {
            TblFeederReadingDatumCollection coll = new TblFeederReadingDatumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DataID)
        {
            return (TblFeederReadingDatum.Delete(DataID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DataID)
        {
            return (TblFeederReadingDatum.Destroy(DataID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string FeederNo,DateTime? FeederReadingDate,decimal? FeederReading,string Remarks,int? ApprovalStatusID,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblFeederReadingDatum item = new TblFeederReadingDatum();
		    
            item.FeederNo = FeederNo;
            
            item.FeederReadingDate = FeederReadingDate;
            
            item.FeederReading = FeederReading;
            
            item.Remarks = Remarks;
            
            item.ApprovalStatusID = ApprovalStatusID;
            
            item.UploadedBy = UploadedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DataID,string FeederNo,DateTime? FeederReadingDate,decimal? FeederReading,string Remarks,int? ApprovalStatusID,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblFeederReadingDatum item = new TblFeederReadingDatum();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DataID = DataID;
				
			item.FeederNo = FeederNo;
				
			item.FeederReadingDate = FeederReadingDate;
				
			item.FeederReading = FeederReading;
				
			item.Remarks = Remarks;
				
			item.ApprovalStatusID = ApprovalStatusID;
				
			item.UploadedBy = UploadedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}