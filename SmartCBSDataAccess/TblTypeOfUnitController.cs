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
    /// Controller class for TblTypeOfUnit
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblTypeOfUnitController
    {
        // Preload our schema..
        TblTypeOfUnit thisSchemaLoad = new TblTypeOfUnit();
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
        public TblTypeOfUnitCollection FetchAll()
        {
            TblTypeOfUnitCollection coll = new TblTypeOfUnitCollection();
            Query qry = new Query(TblTypeOfUnit.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTypeOfUnitCollection FetchByID(object TypesOfUnitID)
        {
            TblTypeOfUnitCollection coll = new TblTypeOfUnitCollection().Where("TypesOfUnitID", TypesOfUnitID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblTypeOfUnitCollection FetchByQuery(Query qry)
        {
            TblTypeOfUnitCollection coll = new TblTypeOfUnitCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object TypesOfUnitID)
        {
            return (TblTypeOfUnit.Delete(TypesOfUnitID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object TypesOfUnitID)
        {
            return (TblTypeOfUnit.Destroy(TypesOfUnitID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string UnitName,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive)
	    {
		    TblTypeOfUnit item = new TblTypeOfUnit();
		    
            item.UnitName = UnitName;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IsActive = IsActive;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int TypesOfUnitID,string UnitName,DateTime? CreatedOn,DateTime? ModifiedOn,bool? IsActive)
	    {
		    TblTypeOfUnit item = new TblTypeOfUnit();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.TypesOfUnitID = TypesOfUnitID;
				
			item.UnitName = UnitName;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IsActive = IsActive;
				
	        item.Save(UserName);
	    }
    }
}