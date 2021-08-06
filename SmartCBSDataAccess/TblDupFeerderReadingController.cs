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
    /// Controller class for TblDupFeerderReading
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblDupFeerderReadingController
    {
        // Preload our schema..
        TblDupFeerderReading thisSchemaLoad = new TblDupFeerderReading();
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
        public TblDupFeerderReadingCollection FetchAll()
        {
            TblDupFeerderReadingCollection coll = new TblDupFeerderReadingCollection();
            Query qry = new Query(TblDupFeerderReading.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupFeerderReadingCollection FetchByID(object DuplicateDataID)
        {
            TblDupFeerderReadingCollection coll = new TblDupFeerderReadingCollection().Where("DuplicateDataID", DuplicateDataID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupFeerderReadingCollection FetchByQuery(Query qry)
        {
            TblDupFeerderReadingCollection coll = new TblDupFeerderReadingCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DuplicateDataID)
        {
            return (TblDupFeerderReading.Delete(DuplicateDataID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DuplicateDataID)
        {
            return (TblDupFeerderReading.Destroy(DuplicateDataID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? DataID,string FeederNo,decimal? FeederReading,DateTime? FeederReadingDate,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblDupFeerderReading item = new TblDupFeerderReading();
		    
            item.DataID = DataID;
            
            item.FeederNo = FeederNo;
            
            item.FeederReading = FeederReading;
            
            item.FeederReadingDate = FeederReadingDate;
            
            item.UploadedBy = UploadedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DuplicateDataID,int? DataID,string FeederNo,decimal? FeederReading,DateTime? FeederReadingDate,int? UploadedBy,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblDupFeerderReading item = new TblDupFeerderReading();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DuplicateDataID = DuplicateDataID;
				
			item.DataID = DataID;
				
			item.FeederNo = FeederNo;
				
			item.FeederReading = FeederReading;
				
			item.FeederReadingDate = FeederReadingDate;
				
			item.UploadedBy = UploadedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
