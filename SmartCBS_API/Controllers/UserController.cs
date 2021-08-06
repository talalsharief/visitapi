using Common.DSMARTSecurity;
using Newtonsoft.Json;
using SmartCBS_API.BusinessHelpers;
using SmartCBS_API.Helper;
using SmartCBSDataAccess;
using SmartCBSDataAccess.BusinessHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartCBS_API.Controllers
{
    public class UserController : ApiController
    {
        //Start UserLogin
        [Route("api/user/userlogin")]
        [HttpGet]
        public ResponseHelper UserLogin([FromUri] clUser data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(0, 0, "UserLogin", ActivityHelper.Activity.User);
            try
            {
                VwTblMeterReadingUserCollection mrUserCol = new VwTblMeterReadingUserCollection()
                    .Where(VwTblMeterReadingUser.Columns.UserName, data.username)
                    .Where(VwTblMeterReadingUser.Columns.Password, DSMARTSecurity.EncryptData(data.password))
                    .Load();

                var result = mrUserCol.Select(x => new
                {
                    username = x.UserName,
                    branchname = x.BranchName,
                    mtuserid = x.MeterReadingUserID,
                    branchid = x.BranchID
                }).ToList();

                if (result.Count > 0)
                {

                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(1, result, new ErrorDef());
                }
                else
                {
                    JSONDAta = JsonConvert.SerializeObject(result);
                    return new ResponseHelper(0, result, new ErrorDef());
                }

            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("UserLogin", ex.Message, "UserLogin", ex.Message, 0);
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
