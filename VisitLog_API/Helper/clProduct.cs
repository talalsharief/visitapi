using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBS_API.Helper
{
    public class clProduct
    {
        public clDeviceInfo Deviceinfo { get; set; }
        public string productname { get; set; }
        public string isactive { get; set; }
        public int productid { get; set; }
        public int userid { get; set; }
    }
}