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
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("api/appdata/appdata")]
    public class AppDataController : ApiController
    {
        //Start AppData
        [Route("api/appdata/appdata")]
        [HttpPost]
        public ResponseHelper AppData( clAppData data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(0, 0, "AppData", ActivityHelper.Activity.User);
            try
            {
                TblAppDatum objTblAppData = new TblAppDatum();
                objTblAppData.AppData = data.AppData;
                objTblAppData.CreatedOn = DateTime.Today;
                objTblAppData.UserID = data.UserID;
                objTblAppData.Save();



                    JSONDAta = JsonConvert.SerializeObject(objTblAppData);
                    return new ResponseHelper(1, objTblAppData, new ErrorDef());
              

            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("AppData", ex.Message, "AppData", ex.Message, 0);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.Deviceinfo);

                BaseHelper.SystemLogging(0, "api/appdata/appdata", JSONDAta, JSONDevice);
            }
        }
        //End AppData

    }
}
