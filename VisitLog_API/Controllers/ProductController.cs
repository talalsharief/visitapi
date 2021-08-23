using Newtonsoft.Json;
using SmartCBS_API.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using VisitLog_API.BusinessHelpers;
using VisitLogDataAccess;

namespace SmartCBS_API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/product/products")]
    public class ProductController : ApiController
    {
        //Start Product
        [Route("api/product/products")]
        [HttpGet]
        public ResponseHelper ProductList([FromUri] clProduct data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(0, 0, "ProductList", ActivityHelper.Activity.User);
            try
            {
                TblProductCollection objTblProdCol = new TblProductCollection()
                    //.Where(TblProduct.Columns.ProductName, data.productname)
                  //  .Where(UserLogin.Columns.Passworrd, DSMARTSecurity.EncryptData(data.password))
                    .Load();
                var result = objTblProdCol.Select(x => new
                {
                    productname = x.ProductName,
                    productid = x.ProductID,
                    productactive = x.IsActive
                    
                    
                });

                if (objTblProdCol.Count > 0)
                {

                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(1, result, new ErrorDef());
                }
                else
                {
                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Error", EnumHelper.ErrorEnums.NoRecordFound.ToString(), "Error"));
                }

            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("ProductList", ex.Message, "ProductList", ex.Message, 0);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.Deviceinfo);

                BaseHelper.SystemLogging(0, "api/product/products", JSONDAta, JSONDevice);
            }
        }
        //End Product
    }
}
