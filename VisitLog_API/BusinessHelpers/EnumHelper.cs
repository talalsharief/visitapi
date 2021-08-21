using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VisitLog_API.BusinessHelpers
{
    public class EnumHelper
    {
        public enum ErrorEnums
        {
            EmptyData = 1,
            NoRecordFound = 2,
            DataAlreadyExist = 3,
            InvalidData = 4,
            Exception = 5,
            UnauthorizedAccess = 6
        }

        public enum PaymentMode
        {
            Cash = 1,
            IBFT = 1,
            EasyPaisa = 1,
            JazzCash = 1,
            Credit = 2,
            Cheque = 3
        }
    }
}