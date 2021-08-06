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
    /// Controller class for tblLedger
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblLedgerController
    {
        // Preload our schema..
        TblLedger thisSchemaLoad = new TblLedger();
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
        public TblLedgerCollection FetchAll()
        {
            TblLedgerCollection coll = new TblLedgerCollection();
            Query qry = new Query(TblLedger.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblLedgerCollection FetchByID(object LedgerID)
        {
            TblLedgerCollection coll = new TblLedgerCollection().Where("LedgerID", LedgerID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblLedgerCollection FetchByQuery(Query qry)
        {
            TblLedgerCollection coll = new TblLedgerCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object LedgerID)
        {
            return (TblLedger.Delete(LedgerID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object LedgerID)
        {
            return (TblLedger.Destroy(LedgerID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? ConsumerID,int? MeterID,int? BillID,int? BillAdjustmentID,int? BillPaymentID,int? InstallmentID,int? Debit,int? Credit,string Remarks,DateTime? CreatedOn,DateTime? ModifiedOn,DateTime? EntryDate,int? AdvanceID)
	    {
		    TblLedger item = new TblLedger();
		    
            item.ConsumerID = ConsumerID;
            
            item.MeterID = MeterID;
            
            item.BillID = BillID;
            
            item.BillAdjustmentID = BillAdjustmentID;
            
            item.BillPaymentID = BillPaymentID;
            
            item.InstallmentID = InstallmentID;
            
            item.Debit = Debit;
            
            item.Credit = Credit;
            
            item.Remarks = Remarks;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.EntryDate = EntryDate;
            
            item.AdvanceID = AdvanceID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int LedgerID,int? ConsumerID,int? MeterID,int? BillID,int? BillAdjustmentID,int? BillPaymentID,int? InstallmentID,int? Debit,int? Credit,string Remarks,DateTime? CreatedOn,DateTime? ModifiedOn,DateTime? EntryDate,int? AdvanceID)
	    {
		    TblLedger item = new TblLedger();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.LedgerID = LedgerID;
				
			item.ConsumerID = ConsumerID;
				
			item.MeterID = MeterID;
				
			item.BillID = BillID;
				
			item.BillAdjustmentID = BillAdjustmentID;
				
			item.BillPaymentID = BillPaymentID;
				
			item.InstallmentID = InstallmentID;
				
			item.Debit = Debit;
				
			item.Credit = Credit;
				
			item.Remarks = Remarks;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.EntryDate = EntryDate;
				
			item.AdvanceID = AdvanceID;
				
	        item.Save(UserName);
	    }
    }
}