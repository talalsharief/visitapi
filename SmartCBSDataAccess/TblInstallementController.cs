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
    /// Controller class for TblInstallement
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblInstallementController
    {
        // Preload our schema..
        TblInstallement thisSchemaLoad = new TblInstallement();
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
        public TblInstallementCollection FetchAll()
        {
            TblInstallementCollection coll = new TblInstallementCollection();
            Query qry = new Query(TblInstallement.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblInstallementCollection FetchByID(object InstallementID)
        {
            TblInstallementCollection coll = new TblInstallementCollection().Where("InstallementID", InstallementID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblInstallementCollection FetchByQuery(Query qry)
        {
            TblInstallementCollection coll = new TblInstallementCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object InstallementID)
        {
            return (TblInstallement.Delete(InstallementID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object InstallementID)
        {
            return (TblInstallement.Destroy(InstallementID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? ArrearID,int? BillID,int? ConsumerID,int? MeterID,int? NoOfInstallement,int? NoOfDays,decimal? Amount,bool? IsApproved,decimal? UpFrontAmount,DateTime? InstallmentDate,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblInstallement item = new TblInstallement();
		    
            item.ArrearID = ArrearID;
            
            item.BillID = BillID;
            
            item.ConsumerID = ConsumerID;
            
            item.MeterID = MeterID;
            
            item.NoOfInstallement = NoOfInstallement;
            
            item.NoOfDays = NoOfDays;
            
            item.Amount = Amount;
            
            item.IsApproved = IsApproved;
            
            item.UpFrontAmount = UpFrontAmount;
            
            item.InstallmentDate = InstallmentDate;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int InstallementID,int? ArrearID,int? BillID,int? ConsumerID,int? MeterID,int? NoOfInstallement,int? NoOfDays,decimal? Amount,bool? IsApproved,decimal? UpFrontAmount,DateTime? InstallmentDate,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblInstallement item = new TblInstallement();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.InstallementID = InstallementID;
				
			item.ArrearID = ArrearID;
				
			item.BillID = BillID;
				
			item.ConsumerID = ConsumerID;
				
			item.MeterID = MeterID;
				
			item.NoOfInstallement = NoOfInstallement;
				
			item.NoOfDays = NoOfDays;
				
			item.Amount = Amount;
				
			item.IsApproved = IsApproved;
				
			item.UpFrontAmount = UpFrontAmount;
				
			item.InstallmentDate = InstallmentDate;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}