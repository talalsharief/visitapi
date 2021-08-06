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
    /// Controller class for TblNewConnection
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblNewConnectionController
    {
        // Preload our schema..
        TblNewConnection thisSchemaLoad = new TblNewConnection();
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
        public TblNewConnectionCollection FetchAll()
        {
            TblNewConnectionCollection coll = new TblNewConnectionCollection();
            Query qry = new Query(TblNewConnection.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConnectionCollection FetchByID(object NewConnectionID)
        {
            TblNewConnectionCollection coll = new TblNewConnectionCollection().Where("NewConnectionID", NewConnectionID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConnectionCollection FetchByQuery(Query qry)
        {
            TblNewConnectionCollection coll = new TblNewConnectionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object NewConnectionID)
        {
            return (TblNewConnection.Delete(NewConnectionID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object NewConnectionID)
        {
            return (TblNewConnection.Destroy(NewConnectionID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? ConsumerID,string RequestCode,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsApprove,int? BranchID,int? NCCreatedBy,int? MeterTypeID,int? BrickTypeID,int? BrickID)
	    {
		    TblNewConnection item = new TblNewConnection();
		    
            item.ConsumerID = ConsumerID;
            
            item.RequestCode = RequestCode;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IsApprove = IsApprove;
            
            item.BranchID = BranchID;
            
            item.NCCreatedBy = NCCreatedBy;
            
            item.MeterTypeID = MeterTypeID;
            
            item.BrickTypeID = BrickTypeID;
            
            item.BrickID = BrickID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int NewConnectionID,int? ConsumerID,string RequestCode,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsApprove,int? BranchID,int? NCCreatedBy,int? MeterTypeID,int? BrickTypeID,int? BrickID)
	    {
		    TblNewConnection item = new TblNewConnection();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.NewConnectionID = NewConnectionID;
				
			item.ConsumerID = ConsumerID;
				
			item.RequestCode = RequestCode;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IsApprove = IsApprove;
				
			item.BranchID = BranchID;
				
			item.NCCreatedBy = NCCreatedBy;
				
			item.MeterTypeID = MeterTypeID;
				
			item.BrickTypeID = BrickTypeID;
				
			item.BrickID = BrickID;
				
	        item.Save(UserName);
	    }
    }
}
