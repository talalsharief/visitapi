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
    /// Controller class for TblArrearAdjustment
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblArrearAdjustmentController
    {
        // Preload our schema..
        TblArrearAdjustment thisSchemaLoad = new TblArrearAdjustment();
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
        public TblArrearAdjustmentCollection FetchAll()
        {
            TblArrearAdjustmentCollection coll = new TblArrearAdjustmentCollection();
            Query qry = new Query(TblArrearAdjustment.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblArrearAdjustmentCollection FetchByID(object ArrearAdjustmentID)
        {
            TblArrearAdjustmentCollection coll = new TblArrearAdjustmentCollection().Where("ArrearAdjustmentID", ArrearAdjustmentID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblArrearAdjustmentCollection FetchByQuery(Query qry)
        {
            TblArrearAdjustmentCollection coll = new TblArrearAdjustmentCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ArrearAdjustmentID)
        {
            return (TblArrearAdjustment.Delete(ArrearAdjustmentID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ArrearAdjustmentID)
        {
            return (TblArrearAdjustment.Destroy(ArrearAdjustmentID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal? PreviousAmount,decimal? NewAmount,int? ArrearID,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive,string Description,bool? IsApprove,bool? IsPending)
	    {
		    TblArrearAdjustment item = new TblArrearAdjustment();
		    
            item.PreviousAmount = PreviousAmount;
            
            item.NewAmount = NewAmount;
            
            item.ArrearID = ArrearID;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IsActive = IsActive;
            
            item.Description = Description;
            
            item.IsApprove = IsApprove;
            
            item.IsPending = IsPending;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ArrearAdjustmentID,decimal? PreviousAmount,decimal? NewAmount,int? ArrearID,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive,string Description,bool? IsApprove,bool? IsPending)
	    {
		    TblArrearAdjustment item = new TblArrearAdjustment();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ArrearAdjustmentID = ArrearAdjustmentID;
				
			item.PreviousAmount = PreviousAmount;
				
			item.NewAmount = NewAmount;
				
			item.ArrearID = ArrearID;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IsActive = IsActive;
				
			item.Description = Description;
				
			item.IsApprove = IsApprove;
				
			item.IsPending = IsPending;
				
	        item.Save(UserName);
	    }
    }
}
