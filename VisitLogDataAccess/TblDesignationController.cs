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
    /// Controller class for TblDesignation
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblDesignationController
    {
        // Preload our schema..
        TblDesignation thisSchemaLoad = new TblDesignation();
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
        public TblDesignationCollection FetchAll()
        {
            TblDesignationCollection coll = new TblDesignationCollection();
            Query qry = new Query(TblDesignation.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDesignationCollection FetchByID(object DesignationID)
        {
            TblDesignationCollection coll = new TblDesignationCollection().Where("DesignationID", DesignationID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDesignationCollection FetchByQuery(Query qry)
        {
            TblDesignationCollection coll = new TblDesignationCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DesignationID)
        {
            return (TblDesignation.Delete(DesignationID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DesignationID)
        {
            return (TblDesignation.Destroy(DesignationID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string DesignationName,bool? IsActive)
	    {
		    TblDesignation item = new TblDesignation();
		    
            item.DesignationName = DesignationName;
            
            item.IsActive = IsActive;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DesignationID,string DesignationName,bool? IsActive)
	    {
		    TblDesignation item = new TblDesignation();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DesignationID = DesignationID;
				
			item.DesignationName = DesignationName;
				
			item.IsActive = IsActive;
				
	        item.Save(UserName);
	    }
    }
}
