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
    /// Controller class for TblConsumer
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblConsumerController
    {
        // Preload our schema..
        TblConsumer thisSchemaLoad = new TblConsumer();
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
        public TblConsumerCollection FetchAll()
        {
            TblConsumerCollection coll = new TblConsumerCollection();
            Query qry = new Query(TblConsumer.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblConsumerCollection FetchByID(object CunsumerID)
        {
            TblConsumerCollection coll = new TblConsumerCollection().Where("CunsumerID", CunsumerID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblConsumerCollection FetchByQuery(Query qry)
        {
            TblConsumerCollection coll = new TblConsumerCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object CunsumerID)
        {
            return (TblConsumer.Delete(CunsumerID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object CunsumerID)
        {
            return (TblConsumer.Destroy(CunsumerID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ConsumerName,string CunsumerEmail,string ConsumerResidensePhoneNo,string CunsumerAddress,string ConsumerMobileNo,string ConsumerNo,string ConsumerNIC,DateTime? CreatedOn,DateTime? ModifiedOn,int? ConsumerStatusID,string ConsumerFatherHusbandName,string ConsumerCNICExpiryDate,string ConsumerProfessionalOccupation,string ConsumerOfficePhoneNo,string ConsumerNationalTaxGSTNo,int? BranchID,int? ConsumerCreatedBy,string OldCunsomerNo,bool? IsBankChargeAndSurChargeApply,int? FreeUnits,bool? IsGovernment,string BusinessName)
	    {
		    TblConsumer item = new TblConsumer();
		    
            item.ConsumerName = ConsumerName;
            
            item.CunsumerEmail = CunsumerEmail;
            
            item.ConsumerResidensePhoneNo = ConsumerResidensePhoneNo;
            
            item.CunsumerAddress = CunsumerAddress;
            
            item.ConsumerMobileNo = ConsumerMobileNo;
            
            item.ConsumerNo = ConsumerNo;
            
            item.ConsumerNIC = ConsumerNIC;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.ConsumerStatusID = ConsumerStatusID;
            
            item.ConsumerFatherHusbandName = ConsumerFatherHusbandName;
            
            item.ConsumerCNICExpiryDate = ConsumerCNICExpiryDate;
            
            item.ConsumerProfessionalOccupation = ConsumerProfessionalOccupation;
            
            item.ConsumerOfficePhoneNo = ConsumerOfficePhoneNo;
            
            item.ConsumerNationalTaxGSTNo = ConsumerNationalTaxGSTNo;
            
            item.BranchID = BranchID;
            
            item.ConsumerCreatedBy = ConsumerCreatedBy;
            
            item.OldCunsomerNo = OldCunsomerNo;
            
            item.IsBankChargeAndSurChargeApply = IsBankChargeAndSurChargeApply;
            
            item.FreeUnits = FreeUnits;
            
            item.IsGovernment = IsGovernment;
            
            item.BusinessName = BusinessName;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int CunsumerID,string ConsumerName,string CunsumerEmail,string ConsumerResidensePhoneNo,string CunsumerAddress,string ConsumerMobileNo,string ConsumerNo,string ConsumerNIC,DateTime? CreatedOn,DateTime? ModifiedOn,int? ConsumerStatusID,string ConsumerFatherHusbandName,string ConsumerCNICExpiryDate,string ConsumerProfessionalOccupation,string ConsumerOfficePhoneNo,string ConsumerNationalTaxGSTNo,int? BranchID,int? ConsumerCreatedBy,string OldCunsomerNo,bool? IsBankChargeAndSurChargeApply,int? FreeUnits,bool? IsGovernment,string BusinessName)
	    {
		    TblConsumer item = new TblConsumer();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.CunsumerID = CunsumerID;
				
			item.ConsumerName = ConsumerName;
				
			item.CunsumerEmail = CunsumerEmail;
				
			item.ConsumerResidensePhoneNo = ConsumerResidensePhoneNo;
				
			item.CunsumerAddress = CunsumerAddress;
				
			item.ConsumerMobileNo = ConsumerMobileNo;
				
			item.ConsumerNo = ConsumerNo;
				
			item.ConsumerNIC = ConsumerNIC;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.ConsumerStatusID = ConsumerStatusID;
				
			item.ConsumerFatherHusbandName = ConsumerFatherHusbandName;
				
			item.ConsumerCNICExpiryDate = ConsumerCNICExpiryDate;
				
			item.ConsumerProfessionalOccupation = ConsumerProfessionalOccupation;
				
			item.ConsumerOfficePhoneNo = ConsumerOfficePhoneNo;
				
			item.ConsumerNationalTaxGSTNo = ConsumerNationalTaxGSTNo;
				
			item.BranchID = BranchID;
				
			item.ConsumerCreatedBy = ConsumerCreatedBy;
				
			item.OldCunsomerNo = OldCunsomerNo;
				
			item.IsBankChargeAndSurChargeApply = IsBankChargeAndSurChargeApply;
				
			item.FreeUnits = FreeUnits;
				
			item.IsGovernment = IsGovernment;
				
			item.BusinessName = BusinessName;
				
	        item.Save(UserName);
	    }
    }
}