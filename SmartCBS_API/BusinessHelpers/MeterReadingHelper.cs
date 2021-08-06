using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartCBSDataAccess;

namespace SmartCBSPresentation.BusinessHelper
{
    public class MeterReadingHelper
    {
        public static int GetMonth()
        {
            TblSystemParamCollection ObjTblsysParamColl = new TblSystemParamCollection();
            ObjTblsysParamColl.Where(TblSystemParam.Columns.SysParamName, "MeterReadingEntryMonth").Load();
            int CurrentMonth = DateTime.Now.AddMonths(Convert.ToInt32(ObjTblsysParamColl[0].SysParamValue)).Month;
            return CurrentMonth;
        }
        public static int GetYear()
        {
            TblSystemParamCollection ObjTblsysParamColl = new TblSystemParamCollection();
            ObjTblsysParamColl.Where(TblSystemParam.Columns.SysParamName, "MeterReadingEntryYear").Load();
            int CurrentYear = DateTime.Now.AddYears(Convert.ToInt32(ObjTblsysParamColl[0].SysParamValue)).Year;
            return CurrentYear;
        }
        public static bool ValidateLaterBillGeneration(int MeterID, int Month, int Year)
        {
            TblMeter ObjTblMeter = new TblMeter(MeterID);

            if (ObjTblMeter.MeterID > 0)
            {
                //TblBillCollection billCol = new TblBillCollection()
                //    .Where(TblBill.Columns.MeterID, MeterID)
                //    .Where(TblBill.Columns.ConsumerID, ObjTblMeter.ConsumerID)
                //    .Where(TblBill.Columns.BillingMonth, SubSonic.Comparison.GreaterThan, Month)
                //    .Where(TblBill.Columns.IsCancel, false)
                //    .OrderByDesc(TblBill.Columns.BillID)
                //.Load();
                TblMeterReadingCollection ObjtblMeterReadings = new TblMeterReadingCollection()
                   .Where(TblMeterReading.Columns.MeterID, MeterID)
                   .Where(TblMeterReading.Columns.ConsumerID, ObjTblMeter.ConsumerID)
                   .Where(TblMeterReading.Columns.MeterReadingMonth, SubSonic.Comparison.GreaterThan, Month)
                   .OrderByDesc(TblMeterReading.Columns.MeterReadingID)
               .Load();

                if (ObjtblMeterReadings.Count > 0 && Convert.ToInt32(ObjtblMeterReadings.First().MeterReadingYear) >= Year)
                {
                    return true;
                }
                else
                {
                    ObjtblMeterReadings = new TblMeterReadingCollection()
                    .Where(TblMeterReading.Columns.MeterID, MeterID)
                    .Where(TblMeterReading.Columns.ConsumerID, ObjTblMeter.ConsumerID)
                    .Where(TblMeterReading.Columns.MeterReadingYear, SubSonic.Comparison.GreaterThan, Year)
                    .OrderByDesc(TblMeterReading.Columns.MeterReadingID)
                .Load();
                    return ObjtblMeterReadings.Count > 0;
                }

            }
            else
                return false;
        }
        public static int GetHouseLockedReading(int MeterID)
        {
            //int MaxMR = 0;
            //int LoopTill = 10;
            //TblMeterReadingCollection ObjTblMRColl = new TblMeterReadingCollection().Where(TblMeterReading.Columns.MeterID, MeterID).OrderByDesc(TblMeterReading.Columns.MeterReadingID).Load();
            //LoopTill = ObjTblMRColl.Count >= 10 ? 10 : ObjTblMRColl.Count; 
            //for (int i = 0; i < LoopTill; i++)
            //    MaxMR = Convert.ToInt32(ObjTblMRColl[i].CurrentReading) > MaxMR ? Convert.ToInt32(ObjTblMRColl[i].CurrentReading) : MaxMR;

            //return MaxMR;

            int MaxUC = 0;
            int LoopTill = 10;
            TblMeter ObjTblMeter = new TblMeter(MeterID);
            int ConsumerID = ObjTblMeter.ConsumerID != null ? (int)ObjTblMeter.ConsumerID : -1;

            TblBillCollection ObjTblBillColl = new TblBillCollection()
                .Where(TblBill.Columns.IsCancel, false)
                .Where(TblBill.Columns.MeterID, MeterID);
            if (ConsumerID > 0)
                ObjTblBillColl.Where(TblBill.Columns.ConsumerID, ConsumerID);
            ObjTblBillColl.OrderByDesc(TblBill.Columns.BillID)
                .Load();

            LoopTill = ObjTblBillColl.Count >= 10 ? 10 : ObjTblBillColl.Count;
            for (int i = 0; i < LoopTill; i++)
                MaxUC = (Convert.ToInt32(ObjTblBillColl[i].UnitsBill) / ObjTblBillColl[i].NoOfMonths) > MaxUC ? (Convert.ToInt32(ObjTblBillColl[i].UnitsBill / ObjTblBillColl[i].NoOfMonths)) : MaxUC;

            if (LoopTill < 10)
            {
                TblMeterIssueCollection ObjTblMeterIssueColl = new TblMeterIssueCollection().Where(TblMeterIssue.Columns.MeterID, MeterID).Load();
                if (ObjTblMeterIssueColl.Count > 0)
                {
                    TblMeterReplacementCollection ObjtblMeterReplacementColl = new TblMeterReplacementCollection();
                    if (ConsumerID > 0)
                        ObjtblMeterReplacementColl.Where(TblMeterReplacement.Columns.ConsumerID, ConsumerID);
                    ObjtblMeterReplacementColl.Where(TblMeterReplacement.Columns.ReplaceID, SubSonic.Comparison.In, ObjTblMeterIssueColl.Select(x => x.ReplacementID)).Load();
                    if (ObjtblMeterReplacementColl.Count > 0)
                    {
                        foreach (var MeterReplace in ObjtblMeterReplacementColl)
                        {
                            TblBillCollection ObjTblBillColl2 = new TblBillCollection()
                                .Where(TblBill.Columns.IsCancel, false)
                                .Where(TblBill.Columns.ConsumerID, ConsumerID)
                                                   .Where(TblBill.Columns.MeterID, MeterReplace.PreviousMeterID).OrderByDesc(TblBill.Columns.BillID).Load();
                            if (ObjTblBillColl2.Count > 0)
                                for (int i = 0; i < 10 - LoopTill; i++)
                                    if (ObjTblBillColl2.Count > i)
                                        MaxUC = (Convert.ToInt32(ObjTblBillColl2[i].UnitsBill) / ObjTblBillColl2[i].NoOfMonths) > MaxUC ? (Convert.ToInt32(ObjTblBillColl2[i].UnitsBill / ObjTblBillColl2[i].NoOfMonths)) : MaxUC;
                                    else
                                        break;
                        }
                    }
                }

            }
            return MaxUC;
        }
        public static bool SetMeterStatusAsActive(int MeterID)
        {
            try
            {
                TblMeterStatus ObjTblMeterStatus = new TblMeterStatus(TblMeterStatus.Columns.MeterStatusName, "Active");
                TblMeter ObjTblMeter = new TblMeter(MeterID);
                ObjTblMeter.MeterStatusID = ObjTblMeterStatus.MeterStatusID;

                if (ObjTblMeterStatus.MeterStatusID > 0 && ObjTblMeter.MeterID > 0)
                    ObjTblMeter.Save();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static DateTime GetMeterReadingMonth(DateTime MeterReadingDate)
        {
            TblSystemConfig ObjTblSystemConfig = new TblSystemConfig(TblSystemConfig.Columns.SystemConfigName, "MeterReadingCutOffDays");
            if(ObjTblSystemConfig.SystemConfigID > 0)
            {
                int CutOffDays = Convert.ToInt32(ObjTblSystemConfig.SystemConfigValue);
                //DateTime _FromDate = MeterReadingDate.AddDays(-CutOffDays);
                //DateTime _ToDate = MeterReadingDate.AddDays(CutOffDays);

                DateTime _PreviousMonth = MeterReadingDate.AddMonths(-1);
                DateTime _FromDate = new DateTime(_PreviousMonth.Year, _PreviousMonth.Month, CutOffDays);
                DateTime _ToDate = new DateTime(MeterReadingDate.Year, MeterReadingDate.Month, CutOffDays);

                if (MeterReadingDate.Ticks > _FromDate.Ticks && MeterReadingDate.Ticks < _ToDate.Ticks)
                {
                    return _PreviousMonth;
                }
                else
                    return MeterReadingDate;
            }
            return MeterReadingDate;
        }
    }
}