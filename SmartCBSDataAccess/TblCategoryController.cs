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
    /// Controller class for tblCategory
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblCategoryController
    {
        // Preload our schema..
        TblCategory thisSchemaLoad = new TblCategory();
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
        public TblCategoryCollection FetchAll()
        {
            TblCategoryCollection coll = new TblCategoryCollection();
            Query qry = new Query(TblCategory.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblCategoryCollection FetchByID(object CategoryID)
        {
            TblCategoryCollection coll = new TblCategoryCollection().Where("CategoryID", CategoryID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblCategoryCollection FetchByQuery(Query qry)
        {
            TblCategoryCollection coll = new TblCategoryCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object CategoryID)
        {
            return (TblCategory.Delete(CategoryID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object CategoryID)
        {
            return (TblCategory.Destroy(CategoryID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string CategoryName,bool? IsActive)
	    {
		    TblCategory item = new TblCategory();
		    
            item.CategoryName = CategoryName;
            
            item.IsActive = IsActive;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int CategoryID,string CategoryName,bool? IsActive)
	    {
		    TblCategory item = new TblCategory();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.CategoryID = CategoryID;
				
			item.CategoryName = CategoryName;
				
			item.IsActive = IsActive;
				
	        item.Save(UserName);
	    }
    }
}
