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
    /// Controller class for TblNewConRefrencesDetail
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblNewConRefrencesDetailController
    {
        // Preload our schema..
        TblNewConRefrencesDetail thisSchemaLoad = new TblNewConRefrencesDetail();
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
        public TblNewConRefrencesDetailCollection FetchAll()
        {
            TblNewConRefrencesDetailCollection coll = new TblNewConRefrencesDetailCollection();
            Query qry = new Query(TblNewConRefrencesDetail.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConRefrencesDetailCollection FetchByID(object NewConRefReqID)
        {
            TblNewConRefrencesDetailCollection coll = new TblNewConRefrencesDetailCollection().Where("NewConRefReqID", NewConRefReqID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNewConRefrencesDetailCollection FetchByQuery(Query qry)
        {
            TblNewConRefrencesDetailCollection coll = new TblNewConRefrencesDetailCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object NewConRefReqID)
        {
            return (TblNewConRefrencesDetail.Delete(NewConRefReqID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object NewConRefReqID)
        {
            return (TblNewConRefrencesDetail.Destroy(NewConRefReqID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? NewConnectionID,string RqName,string RqAddress,string RqContactNo,string RqCompanyName,string RqDesignation,string RelationShipWithApplicant,string GivingAnswer,bool? Signature,DateTime? CreatedOn,DateTime? ModifiedOn,int? RefrenceNo,string RqCNIC,string RQConsumer)
	    {
		    TblNewConRefrencesDetail item = new TblNewConRefrencesDetail();
		    
            item.NewConnectionID = NewConnectionID;
            
            item.RqName = RqName;
            
            item.RqAddress = RqAddress;
            
            item.RqContactNo = RqContactNo;
            
            item.RqCompanyName = RqCompanyName;
            
            item.RqDesignation = RqDesignation;
            
            item.RelationShipWithApplicant = RelationShipWithApplicant;
            
            item.GivingAnswer = GivingAnswer;
            
            item.Signature = Signature;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.RefrenceNo = RefrenceNo;
            
            item.RqCNIC = RqCNIC;
            
            item.RQConsumer = RQConsumer;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int NewConRefReqID,int? NewConnectionID,string RqName,string RqAddress,string RqContactNo,string RqCompanyName,string RqDesignation,string RelationShipWithApplicant,string GivingAnswer,bool? Signature,DateTime? CreatedOn,DateTime? ModifiedOn,int? RefrenceNo,string RqCNIC,string RQConsumer)
	    {
		    TblNewConRefrencesDetail item = new TblNewConRefrencesDetail();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.NewConRefReqID = NewConRefReqID;
				
			item.NewConnectionID = NewConnectionID;
				
			item.RqName = RqName;
				
			item.RqAddress = RqAddress;
				
			item.RqContactNo = RqContactNo;
				
			item.RqCompanyName = RqCompanyName;
				
			item.RqDesignation = RqDesignation;
				
			item.RelationShipWithApplicant = RelationShipWithApplicant;
				
			item.GivingAnswer = GivingAnswer;
				
			item.Signature = Signature;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.RefrenceNo = RefrenceNo;
				
			item.RqCNIC = RqCNIC;
				
			item.RQConsumer = RQConsumer;
				
	        item.Save(UserName);
	    }
    }
}