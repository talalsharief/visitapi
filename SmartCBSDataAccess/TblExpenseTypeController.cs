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
    /// Controller class for tblExpenseType
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblExpenseTypeController
    {
        // Preload our schema..
        TblExpenseType thisSchemaLoad = new TblExpenseType();
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
        public TblExpenseTypeCollection FetchAll()
        {
            TblExpenseTypeCollection coll = new TblExpenseTypeCollection();
            Query qry = new Query(TblExpenseType.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblExpenseTypeCollection FetchByID(object ExpenseTypeID)
        {
            TblExpenseTypeCollection coll = new TblExpenseTypeCollection().Where("ExpenseTypeID", ExpenseTypeID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblExpenseTypeCollection FetchByQuery(Query qry)
        {
            TblExpenseTypeCollection coll = new TblExpenseTypeCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object ExpenseTypeID)
        {
            return (TblExpenseType.Delete(ExpenseTypeID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object ExpenseTypeID)
        {
            return (TblExpenseType.Destroy(ExpenseTypeID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ExpenseTypeName,string Description,bool? IsActive,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblExpenseType item = new TblExpenseType();
		    
            item.ExpenseTypeName = ExpenseTypeName;
            
            item.Description = Description;
            
            item.IsActive = IsActive;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int ExpenseTypeID,string ExpenseTypeName,string Description,bool? IsActive,DateTime? CreatedOn,DateTime? ModifiedOn)
	    {
		    TblExpenseType item = new TblExpenseType();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ExpenseTypeID = ExpenseTypeID;
				
			item.ExpenseTypeName = ExpenseTypeName;
				
			item.Description = Description;
				
			item.IsActive = IsActive;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
