using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBS_API.Helper
{
    public class clMeterReading
    {
        public int id { get; set; }

        public List<clMeterReadingData> lstMeterReading { get; set; }

        public int meterreadinguserid { get; set; }

        public int userid { get; set; }

        public clDeviceInfo deviceinfo { get; set; }
    }

    public class clMeterReadingData
    {
        public List<string> lstMeterReading { get; set; }

        public int meterreadinguserid { get; set; }

        public int meterid { get; set; }

        public string meterno { get; set; }

        public decimal currentreadig { get; set; }

        public int cload { get; set; }

        public int branchid { get; set; }

        public int consumerid { get; set; }

        public string imageurl { get; set; }

        public string serialno { get; set; }

        public DateTime meterreadingdate { get; set; }
    }
}