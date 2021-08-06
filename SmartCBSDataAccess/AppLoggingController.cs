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
    /// Controller class for AppLogging
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AppLoggingController
    {
        // Preload our schema..
        AppLogging thisSchemaLoad = new AppLogging();
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
        public AppLoggingCollection FetchAll()
        {
            AppLoggingCollection coll = new AppLoggingCollection();
            Query qry = new Query(AppLogging.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AppLoggingCollection FetchByID(object AppLoggingID)
        {
            AppLoggingCollection coll = new AppLoggingCollection().Where("AppLoggingID", AppLoggingID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AppLoggingCollection FetchByQuery(Query qry)
        {
            AppLoggingCollection coll = new AppLoggingCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object AppLoggingID)
        {
            return (AppLogging.Delete(AppLoggingID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object AppLoggingID)
        {
            return (AppLogging.Destroy(AppLoggingID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Activity,bool? IsSuccessful,string Model,string AppVersion,string Exception,string JsonData,int? MeterReadingReadingUser)
	    {
		    AppLogging item = new AppLogging();
		    
            item.Activity = Activity;
            
            item.IsSuccessful = IsSuccessful;
            
            item.Model = Model;
            
            item.AppVersion = AppVersion;
            
            item.Exception = Exception;
            
            item.JsonData = JsonData;
            
            item.MeterReadingReadingUser = MeterReadingReadingUser;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int AppLoggingID,string Activity,bool? IsSuccessful,string Model,string AppVersion,string Exception,string JsonData,int? MeterReadingReadingUser)
	    {
		    AppLogging item = new AppLogging();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.AppLoggingID = AppLoggingID;
				
			item.Activity = Activity;
				
			item.IsSuccessful = IsSuccessful;
				
			item.Model = Model;
				
			item.AppVersion = AppVersion;
				
			item.Exception = Exception;
				
			item.JsonData = JsonData;
				
			item.MeterReadingReadingUser = MeterReadingReadingUser;
				
	        item.Save(UserName);
	    }
    }
}
