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
    /// Controller class for TblTypesOfService
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblTypesOfServiceController
    {
        // Preload our schema..
        TblTypesOfService thisSchemaLoad = new TblTypesOfService();
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
        public TblTypesOfServiceCollection FetchAll()
        {
            TblTypesOfServiceCollection coll = new TblTypesOfServiceCollection();
            Query qry = new Query(TblTypesOfService.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTypesOfServiceCollection FetchByID(object ServiceID)
        {
            TblTypesOfServiceCollection coll = new TblTypesOfServiceCollection().Where("ServiceID", ServiceID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTypesOfServiceCollection FetchByQuery(Query qry)
        {
            TblTypesOfServiceCollection coll = new TblTypesOfServiceCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ServiceID)
        {
            return (TblTypesOfService.Delete(ServiceID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ServiceID)
        {
            return (TblTypesOfService.Destroy(ServiceID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ServiceName,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive)
	    {
		    TblTypesOfService item = new TblTypesOfService();
		    
            item.ServiceName = ServiceName;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IsActive = IsActive;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ServiceID,string ServiceName,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive)
	    {
		    TblTypesOfService item = new TblTypesOfService();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ServiceID = ServiceID;
				
			item.ServiceName = ServiceName;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IsActive = IsActive;
				
	        item.Save(UserName);
	    }
    }
}