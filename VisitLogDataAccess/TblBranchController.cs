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
namespace VisitLogDataAccess
{
    /// <summary>
    /// Controller class for TblBranch
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblBranchController
    {
        // Preload our schema..
        TblBranch thisSchemaLoad = new TblBranch();
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
        public TblBranchCollection FetchAll()
        {
            TblBranchCollection coll = new TblBranchCollection();
            Query qry = new Query(TblBranch.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBranchCollection FetchByID(object BranchID)
        {
            TblBranchCollection coll = new TblBranchCollection().Where("BranchID", BranchID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBranchCollection FetchByQuery(Query qry)
        {
            TblBranchCollection coll = new TblBranchCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object BranchID)
        {
            return (TblBranch.Delete(BranchID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object BranchID)
        {
            return (TblBranch.Destroy(BranchID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string BranchCode,string BranchName,bool? IsActive)
	    {
		    TblBranch item = new TblBranch();
		    
            item.BranchCode = BranchCode;
            
            item.BranchName = BranchName;
            
            item.IsActive = IsActive;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int BranchID,string BranchCode,string BranchName,bool? IsActive)
	    {
		    TblBranch item = new TblBranch();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.BranchID = BranchID;
				
			item.BranchCode = BranchCode;
				
			item.BranchName = BranchName;
				
			item.IsActive = IsActive;
				
	        item.Save(UserName);
	    }
    }
}
