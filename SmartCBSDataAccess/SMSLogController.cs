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
    /// Controller class for SMSLog
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SMSLogController
    {
        // Preload our schema..
        SMSLog thisSchemaLoad = new SMSLog();
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
        public SMSLogCollection FetchAll()
        {
            SMSLogCollection coll = new SMSLogCollection();
            Query qry = new Query(SMSLog.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SMSLogCollection FetchByID(object SMSLogID)
        {
            SMSLogCollection coll = new SMSLogCollection().Where("SMSLogID", SMSLogID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SMSLogCollection FetchByQuery(Query qry)
        {
            SMSLogCollection coll = new SMSLogCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object SMSLogID)
        {
            return (SMSLog.Delete(SMSLogID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object SMSLogID)
        {
            return (SMSLog.Destroy(SMSLogID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string DeviceText,string DeviceNo,DateTime? DeviceSendingDateTime,DateTime? ReportedDateTime,bool? InvalidFormat,string InvalidField,int? MeterID)
	    {
		    SMSLog item = new SMSLog();
		    
            item.DeviceText = DeviceText;
            
            item.DeviceNo = DeviceNo;
            
            item.DeviceSendingDateTime = DeviceSendingDateTime;
            
            item.ReportedDateTime = ReportedDateTime;
            
            item.InvalidFormat = InvalidFormat;
            
            item.InvalidField = InvalidField;
            
            item.MeterID = MeterID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int SMSLogID,string DeviceText,string DeviceNo,DateTime? DeviceSendingDateTime,DateTime? ReportedDateTime,bool? InvalidFormat,string InvalidField,int? MeterID)
	    {
		    SMSLog item = new SMSLog();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.SMSLogID = SMSLogID;
				
			item.DeviceText = DeviceText;
				
			item.DeviceNo = DeviceNo;
				
			item.DeviceSendingDateTime = DeviceSendingDateTime;
				
			item.ReportedDateTime = ReportedDateTime;
				
			item.InvalidFormat = InvalidFormat;
				
			item.InvalidField = InvalidField;
				
			item.MeterID = MeterID;
				
	        item.Save(UserName);
	    }
    }
}
