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
    /// Controller class for tblActivity
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblActivityController
    {
        // Preload our schema..
        TblActivity thisSchemaLoad = new TblActivity();
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
        public TblActivityCollection FetchAll()
        {
            TblActivityCollection coll = new TblActivityCollection();
            Query qry = new Query(TblActivity.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblActivityCollection FetchByID(object ActivityLogID)
        {
            TblActivityCollection coll = new TblActivityCollection().Where("ActivityLogID", ActivityLogID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblActivityCollection FetchByQuery(Query qry)
        {
            TblActivityCollection coll = new TblActivityCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ActivityLogID)
        {
            return (TblActivity.Delete(ActivityLogID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ActivityLogID)
        {
            return (TblActivity.Destroy(ActivityLogID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ActivityCode,int? Pkid,int? UserID,string Remarks,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblActivity item = new TblActivity();
		    
            item.ActivityCode = ActivityCode;
            
            item.Pkid = Pkid;
            
            item.UserID = UserID;
            
            item.Remarks = Remarks;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ActivityLogID,string ActivityCode,int? Pkid,int? UserID,string Remarks,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblActivity item = new TblActivity();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ActivityLogID = ActivityLogID;
				
			item.ActivityCode = ActivityCode;
				
			item.Pkid = Pkid;
				
			item.UserID = UserID;
				
			item.Remarks = Remarks;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
