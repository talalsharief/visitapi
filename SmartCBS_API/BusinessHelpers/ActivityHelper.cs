using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartCBSDataAccess;

namespace SmartCBS_API.BusinessHelpers
{
    public class ActivityHelper
    {
        public static int SaveActivity(int? UserID, int? PKID, string remarks, Enum activity)
        {
            TblActivity objTblActivity = new TblActivity();
            if (UserID > 0)
                objTblActivity.UserID = UserID;
            objTblActivity.ActivityCode = activity.ToString();
            if(PKID > 0)
                objTblActivity.Pkid = PKID;
            objTblActivity.Remarks = remarks;
            objTblActivity.Save();

            return objTblActivity.ActivityLogID;
        }

        public enum Activity
        {
            SyncMeterReading,
            FetchMeterIndexinConfiguration,
            FetchConsumer,
            FetchMeter,
            FillAppMeterStatus,
            User,
        }
    }
}