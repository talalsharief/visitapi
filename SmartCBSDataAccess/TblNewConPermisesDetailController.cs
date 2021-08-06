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
    /// Controller class for TblNewConPermisesDetail
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblNewConPermisesDetailController
    {
        // Preload our schema..
        TblNewConPermisesDetail thisSchemaLoad = new TblNewConPermisesDetail();
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
        public TblNewConPermisesDetailCollection FetchAll()
        {
            TblNewConPermisesDetailCollection coll = new TblNewConPermisesDetailCollection();
            Query qry = new Query(TblNewConPermisesDetail.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConPermisesDetailCollection FetchByID(object PremisesDetailID)
        {
            TblNewConPermisesDetailCollection coll = new TblNewConPermisesDetailCollection().Where("PremisesDetailID", PremisesDetailID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConPermisesDetailCollection FetchByQuery(Query qry)
        {
            TblNewConPermisesDetailCollection coll = new TblNewConPermisesDetailCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object PremisesDetailID)
        {
            return (TblNewConPermisesDetail.Delete(PremisesDetailID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object PremisesDetailID)
        {
            return (TblNewConPermisesDetail.Destroy(PremisesDetailID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? UnitID,decimal? AreaOfThePremises,int? NoOfConnectionMeter,int? LoadRequired,int? TotalLoadrequired,DateTime? CreatedOn,DateTime? ModifiedOn,int? NewConnectionID)
	    {
		    TblNewConPermisesDetail item = new TblNewConPermisesDetail();
		    
            item.UnitID = UnitID;
            
            item.AreaOfThePremises = AreaOfThePremises;
            
            item.NoOfConnectionMeter = NoOfConnectionMeter;
            
            item.LoadRequired = LoadRequired;
            
            item.TotalLoadrequired = TotalLoadrequired;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.NewConnectionID = NewConnectionID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int PremisesDetailID,int? UnitID,decimal? AreaOfThePremises,int? NoOfConnectionMeter,int? LoadRequired,int? TotalLoadrequired,DateTime? CreatedOn,DateTime? ModifiedOn,int? NewConnectionID)
	    {
		    TblNewConPermisesDetail item = new TblNewConPermisesDetail();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.PremisesDetailID = PremisesDetailID;
				
			item.UnitID = UnitID;
				
			item.AreaOfThePremises = AreaOfThePremises;
				
			item.NoOfConnectionMeter = NoOfConnectionMeter;
				
			item.LoadRequired = LoadRequired;
				
			item.TotalLoadrequired = TotalLoadrequired;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.NewConnectionID = NewConnectionID;
				
	        item.Save(UserName);
	    }
    }
}