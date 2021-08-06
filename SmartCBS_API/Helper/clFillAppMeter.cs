using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBS_API.Helper
{
    public class clFillAppMeter
    {
        public int id { get; set; }

        public string statusname { get; set; }

        public string colorcode;

        public int userid;

        public clDeviceInfo deviceinfo { get; set; }
    }

    public class clMeter
    {
        public int id { get; set; }

        public int meterreaderid { get; set; }

        public int meterid { get; set; }

        public string meterno { get; set; }

        public int consumerid { get; set; }

        public string suppmeterno { get; set; }

        public string serialno { get; set; }

        public int previousreading { get; set; }

        public int userid { get; set; }

        public clDeviceInfo deviceinfo { get; set; }
    }

    public class clConsumer
    {
        public int id { get; set; }

        public int meterreaderid { get; set; }

        public int userid { get; set; }

        public clDeviceInfo deviceinfo { get; set; }
    }

    public class clFetchMeterIndex
    {
        public int id { get; set; }

        public int userid { get; set; }

        public clDeviceInfo deviceinfo { get; set; }
    }
}