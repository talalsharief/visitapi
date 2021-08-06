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
    /// Controller class for TblAdvertisement
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblAdvertisementController
    {
        // Preload our schema..
        TblAdvertisement thisSchemaLoad = new TblAdvertisement();
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
        public TblAdvertisementCollection FetchAll()
        {
            TblAdvertisementCollection coll = new TblAdvertisementCollection();
            Query qry = new Query(TblAdvertisement.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblAdvertisementCollection FetchByID(object AdvertiseID)
        {
            TblAdvertisementCollection coll = new TblAdvertisementCollection().Where("AdvertiseID", AdvertiseID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblAdvertisementCollection FetchByQuery(Query qry)
        {
            TblAdvertisementCollection coll = new TblAdvertisementCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object AdvertiseID)
        {
            return (TblAdvertisement.Delete(AdvertiseID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object AdvertiseID)
        {
            return (TblAdvertisement.Destroy(AdvertiseID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? AdsLocationID,string ImageURL,DateTime? StartingBillingMonth,DateTime? EndingBillingMonth,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive,string AdvertiseName)
	    {
		    TblAdvertisement item = new TblAdvertisement();
		    
            item.AdsLocationID = AdsLocationID;
            
            item.ImageURL = ImageURL;
            
            item.StartingBillingMonth = StartingBillingMonth;
            
            item.EndingBillingMonth = EndingBillingMonth;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IsActive = IsActive;
            
            item.AdvertiseName = AdvertiseName;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int AdvertiseID,int? AdsLocationID,string ImageURL,DateTime? StartingBillingMonth,DateTime? EndingBillingMonth,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive,string AdvertiseName)
	    {
		    TblAdvertisement item = new TblAdvertisement();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.AdvertiseID = AdvertiseID;
				
			item.AdsLocationID = AdsLocationID;
				
			item.ImageURL = ImageURL;
				
			item.StartingBillingMonth = StartingBillingMonth;
				
			item.EndingBillingMonth = EndingBillingMonth;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IsActive = IsActive;
				
			item.AdvertiseName = AdvertiseName;
				
	        item.Save(UserName);
	    }
    }
}