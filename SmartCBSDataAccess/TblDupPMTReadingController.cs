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
    /// Controller class for TblDupPMTReading
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblDupPMTReadingController
    {
        // Preload our schema..
        TblDupPMTReading thisSchemaLoad = new TblDupPMTReading();
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
        public TblDupPMTReadingCollection FetchAll()
        {
            TblDupPMTReadingCollection coll = new TblDupPMTReadingCollection();
            Query qry = new Query(TblDupPMTReading.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupPMTReadingCollection FetchByID(object DuplicateDataID)
        {
            TblDupPMTReadingCollection coll = new TblDupPMTReadingCollection().Where("DuplicateDataID", DuplicateDataID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupPMTReadingCollection FetchByQuery(Query qry)
        {
            TblDupPMTReadingCollection coll = new TblDupPMTReadingCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DuplicateDataID)
        {
            return (TblDupPMTReading.Delete(DuplicateDataID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DuplicateDataID)
        {
            return (TblDupPMTReading.Destroy(DuplicateDataID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? DataID,string PMTNo,decimal? PMTReading,DateTime? PMTReadingDate,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblDupPMTReading item = new TblDupPMTReading();
		    
            item.DataID = DataID;
            
            item.PMTNo = PMTNo;
            
            item.PMTReading = PMTReading;
            
            item.PMTReadingDate = PMTReadingDate;
            
            item.UploadedBy = UploadedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DuplicateDataID,int? DataID,string PMTNo,decimal? PMTReading,DateTime? PMTReadingDate,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblDupPMTReading item = new TblDupPMTReading();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DuplicateDataID = DuplicateDataID;
				
			item.DataID = DataID;
				
			item.PMTNo = PMTNo;
				
			item.PMTReading = PMTReading;
				
			item.PMTReadingDate = PMTReadingDate;
				
			item.UploadedBy = UploadedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
