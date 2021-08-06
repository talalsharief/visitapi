using SmartCBSDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SmartCBS_API.BusinessHelpers
{
    public class BaseHelper
    {
        public static void SystemLogging(int? UserID, string RequestURL, string JSONData, string Device)
        {
            TblSystemLogging tblSystemLogging = new TblSystemLogging();
            tblSystemLogging.LogDate = DateTime.UtcNow;
            if (UserID > 0)
                tblSystemLogging.UserID = UserID;
            tblSystemLogging.JSONData = JSONData;
            tblSystemLogging.RequestURL = RequestURL;
            tblSystemLogging.Device = Device;
            tblSystemLogging.Save();
        }
        public static void ExceptionLogging(string Activity, string StackTrace, string ErrorMethod, string Exception, int? UserId)
        {
            TblException objTblException = new TblException();
            objTblException.Activity = Activity;
            objTblException.StackTrace = StackTrace;
            objTblException.ErrorMethod = ErrorMethod;
            objTblException.Exception = Exception;
            if(UserId > 0)
                objTblException.CurrentUserID = UserId;
            objTblException.ExceptionDateTime = DateTime.Now;
            objTblException.Save();
        }

    }
}