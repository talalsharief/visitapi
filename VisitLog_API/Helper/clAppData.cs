using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBS_API.Helper
{
    public class clAppData
    {
        public clDeviceInfo Deviceinfo { get; set; }
        public int AppDataID { get; set; }
        public string AppData { get; set; }
        public int UserID { get; set; }
        public string CreatedOn { get; set; }
    }
}