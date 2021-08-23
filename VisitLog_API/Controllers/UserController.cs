using Common.DSMARTSecurity;
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

namespace VisitLog_API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("api/user/userlogin")]
    public class UserController : ApiController
    {
        //Start UserLogin
        [Route("api/user/userlogin")]
        [HttpGet]
        public ResponseHelper DemoLogin([FromUri] clUser data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(0, 0, "UserLogin", ActivityHelper.Activity.User);
            try
            {
                UserLoginCollection objTblUserCol = new UserLoginCollection()
                    .Where(UserLogin.Columns.UserName, data.username)
                    .Where(UserLogin.Columns.Passworrd, DSMARTSecurity.EncryptData(data.password))
                    .Load();
                var result = objTblUserCol.Select(x => new
                {
                    username = x.UserName,
                    userid = x.UserLoginId
                });

                if (objTblUserCol.Count > 0)
                {   
                    
                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(1, result, new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Error", EnumHelper.ErrorEnums.NoRecordFound.ToString(), "Error"));
                }
                else
                {
                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(0, new object(), new ErrorDef());
                }

            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("DemoLogin", ex.Message, "DemoLogin", ex.Message, 0);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(0, "api/user/userlogin", JSONDAta, JSONDevice);
            }
        }
        //End UserLogin
    }
}
