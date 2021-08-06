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
    /// Controller class for TblMeterReadingUser
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterReadingUserController
    {
        // Preload our schema..
        TblMeterReadingUser thisSchemaLoad = new TblMeterReadingUser();
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
        public TblMeterReadingUserCollection FetchAll()
        {
            TblMeterReadingUserCollection coll = new TblMeterReadingUserCollection();
            Query qry = new Query(TblMeterReadingUser.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterReadingUserCollection FetchByID(object MeterReadingUserID)
        {
            TblMeterReadingUserCollection coll = new TblMeterReadingUserCollection().Where("MeterReadingUserID", MeterReadingUserID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterReadingUserCollection FetchByQuery(Query qry)
        {
            TblMeterReadingUserCollection coll = new TblMeterReadingUserCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MeterReadingUserID)
        {
            return (TblMeterReadingUser.Delete(MeterReadingUserID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MeterReadingUserID)
        {
            return (TblMeterReadingUser.Destroy(MeterReadingUserID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string UserName,string Password,string EmployeeName,bool? IsActive,DateTime? CreatedOn,DateTime? ModifiedOn,int? BranchID)
	    {
		    TblMeterReadingUser item = new TblMeterReadingUser();
		    
            item.UserName = UserName;
            
            item.Password = Password;
            
            item.EmployeeName = EmployeeName;
            
            item.IsActive = IsActive;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.BranchID = BranchID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int MeterReadingUserID,string UserName,string Password,string EmployeeName,bool? IsActive,DateTime? CreatedOn,DateTime? ModifiedOn,int? BranchID)
	    {
		    TblMeterReadingUser item = new TblMeterReadingUser();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.MeterReadingUserID = MeterReadingUserID;
				
			item.UserName = UserName;
				
			item.Password = Password;
				
			item.EmployeeName = EmployeeName;
				
			item.IsActive = IsActive;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.BranchID = BranchID;
				
	        item.Save(UserName);
	    }
    }
}