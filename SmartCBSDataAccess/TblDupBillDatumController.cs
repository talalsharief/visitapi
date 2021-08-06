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
    /// Controller class for TblDupBillData
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblDupBillDatumController
    {
        // Preload our schema..
        TblDupBillDatum thisSchemaLoad = new TblDupBillDatum();
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
        public TblDupBillDatumCollection FetchAll()
        {
            TblDupBillDatumCollection coll = new TblDupBillDatumCollection();
            Query qry = new Query(TblDupBillDatum.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupBillDatumCollection FetchByID(object DuplicateDataID)
        {
            TblDupBillDatumCollection coll = new TblDupBillDatumCollection().Where("DuplicateDataID", DuplicateDataID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblDupBillDatumCollection FetchByQuery(Query qry)
        {
            TblDupBillDatumCollection coll = new TblDupBillDatumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DuplicateDataID)
        {
            return (TblDupBillDatum.Delete(DuplicateDataID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DuplicateDataID)
        {
            return (TblDupBillDatum.Destroy(DuplicateDataID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? DataID,DateTime? PaymentDate,decimal? AmountPaid,int? CollectionPointID,bool? IsApproved,int? UploadedBy,DateTime? ModifiedOn,DateTime? CreatedOn)
	    {
		    TblDupBillDatum item = new TblDupBillDatum();
		    
            item.DataID = DataID;
            
            item.PaymentDate = PaymentDate;
            
            item.AmountPaid = AmountPaid;
            
            item.CollectionPointID = CollectionPointID;
            
            item.IsApproved = IsApproved;
            
            item.UploadedBy = UploadedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.CreatedOn = CreatedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DuplicateDataID,int? DataID,DateTime? PaymentDate,decimal? AmountPaid,int? CollectionPointID,bool? IsApproved,int? UploadedBy,DateTime? ModifiedOn,DateTime? CreatedOn)
	    {
		    TblDupBillDatum item = new TblDupBillDatum();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DuplicateDataID = DuplicateDataID;
				
			item.DataID = DataID;
				
			item.PaymentDate = PaymentDate;
				
			item.AmountPaid = AmountPaid;
				
			item.CollectionPointID = CollectionPointID;
				
			item.IsApproved = IsApproved;
				
			item.UploadedBy = UploadedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.CreatedOn = CreatedOn;
				
	        item.Save(UserName);
	    }
    }
}
