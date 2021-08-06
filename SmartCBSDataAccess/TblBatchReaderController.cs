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
    /// Controller class for TblBatchReader
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblBatchReaderController
    {
        // Preload our schema..
        TblBatchReader thisSchemaLoad = new TblBatchReader();
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
        public TblBatchReaderCollection FetchAll()
        {
            TblBatchReaderCollection coll = new TblBatchReaderCollection();
            Query qry = new Query(TblBatchReader.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBatchReaderCollection FetchByID(object ReaderBatchID)
        {
            TblBatchReaderCollection coll = new TblBatchReaderCollection().Where("ReaderBatchID", ReaderBatchID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblBatchReaderCollection FetchByQuery(Query qry)
        {
            TblBatchReaderCollection coll = new TblBatchReaderCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ReaderBatchID)
        {
            return (TblBatchReader.Delete(ReaderBatchID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ReaderBatchID)
        {
            return (TblBatchReader.Destroy(ReaderBatchID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? BatchID,int? MeterReaderID)
	    {
		    TblBatchReader item = new TblBatchReader();
		    
            item.BatchID = BatchID;
            
            item.MeterReaderID = MeterReaderID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ReaderBatchID,int? BatchID,int? MeterReaderID)
	    {
		    TblBatchReader item = new TblBatchReader();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ReaderBatchID = ReaderBatchID;
				
			item.BatchID = BatchID;
				
			item.MeterReaderID = MeterReaderID;
				
	        item.Save(UserName);
	    }
    }
}
