using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBS_API.Helper
{
    public class clUser
    {
        public int userid { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string usertype { get; set; }

        public string email { get; set; }

        public int userroleid { get; set; }

        public int employeeid { get; set; }

        public int attempt { get; set; }

        public clDeviceInfo deviceinfo { get; set; }
    }
}