using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartCBSPresentation.BusinessHelper
{
    public class clGenerateBill
    {
        public int EmployeeID { get; set; }
        public int BranchID { get; set; }
        public int QueID { get; set; }
        public List<int> meterIDList = new List<int>();
        public int cmbMonth { get; set; }
        public int cmbYear { get; set; }
        public DateTime txtBillIssueDate { get; set; }
        public DateTime dtBillingDueDate { get; set; }
        public int UserLoginId { get; set; }
        public int BatchID { get; set; }

    }
}