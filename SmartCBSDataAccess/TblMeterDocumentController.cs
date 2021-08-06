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
    /// Controller class for tblMeterDocument
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMeterDocumentController
    {
        // Preload our schema..
        TblMeterDocument thisSchemaLoad = new TblMeterDocument();
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
        public TblMeterDocumentCollection FetchAll()
        {
            TblMeterDocumentCollection coll = new TblMeterDocumentCollection();
            Query qry = new Query(TblMeterDocument.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterDocumentCollection FetchByID(object MeterDocumentID)
        {
            TblMeterDocumentCollection coll = new TblMeterDocumentCollection().Where("MeterDocumentID", MeterDocumentID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMeterDocumentCollection FetchByQuery(Query qry)
        {
            TblMeterDocumentCollection coll = new TblMeterDocumentCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object MeterDocumentID)
        {
            return (TblMeterDocument.Delete(MeterDocumentID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object MeterDocumentID)
        {
            return (TblMeterDocument.Destroy(MeterDocumentID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? MeterTypeID,int? DocumentID)
	    {
		    TblMeterDocument item = new TblMeterDocument();
		    
            item.MeterTypeID = MeterTypeID;
            
            item.DocumentID = DocumentID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int MeterDocumentID,int? MeterTypeID,int? DocumentID)
	    {
		    TblMeterDocument item = new TblMeterDocument();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.MeterDocumentID = MeterDocumentID;
				
			item.MeterTypeID = MeterTypeID;
				
			item.DocumentID = DocumentID;
				
	        item.Save(UserName);
	    }
    }
}
