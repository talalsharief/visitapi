using Newtonsoft.Json;
using SmartCBS_API.BusinessHelpers;
using SmartCBS_API.Helper;
using SmartCBSDataAccess;
using SmartCBSDataAccess.BusinessHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartCBS_API.Controllers
{
    public class FillAppMeterController : ApiController
    {

        //FillAppMeterStatus Method Start
        [Route("api/fillappmeter/fillappmeterstatus")]
        [HttpGet]
        public ResponseHelper FillAppMeterStatus([FromUri] clFillAppMeter data)
        {
            string JSONDAta = "";
            string Activity = "";

            Activity = ActivityHelper.SaveActivity(data.userid, data.id, "FillAppMeterStatus", ActivityHelper.Activity.FillAppMeterStatus).ToString();

            try
            {
                List<clFillAppMeter> lstFeedBackStatus = new List<clFillAppMeter>();
                
                TblFeedBackStatusCollection ObjTblFeedBackStatusCollection = new TblFeedBackStatusCollection()
                    .Where(TblFeedBackStatus.Columns.IsActive, true)
                    .Load();

                foreach (var item in ObjTblFeedBackStatusCollection)
                {
                    clFillAppMeter clObjFillAppMeter = new clFillAppMeter();
                    clObjFillAppMeter.statusname = item.StatusName;
                    clObjFillAppMeter.colorcode = item.HashCode;

                    lstFeedBackStatus.Add(clObjFillAppMeter);
                }

                JSONDAta = JsonConvert.SerializeObject(lstFeedBackStatus);
                return new ResponseHelper(1, lstFeedBackStatus, new ErrorDef());
            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging(Activity, ex.Message, "FillAppMeterStatus", ex.Message, data.userid);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(data.userid, "api/fillappmeter/fillappmeterstatus", JSONDAta, JSONDevice);
            }
        }
        //FillAppMeterStatus Method End


        //FetchMeter Method Start
        [Route("api/fillappmeter/fetchmeter")]
        [HttpGet]
        public ResponseHelper FetchMeter([FromUri] clMeter data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(data.userid, data.id, "FetchMeter", ActivityHelper.Activity.FetchMeter);

            try
            {
                TblBatchReaderCollection ObjTblBRColl = new TblBatchReaderCollection()
                    .Where(TblBatchReader.Columns.MeterReaderID, data.meterreaderid)
                    .Load();
                if (ObjTblBRColl.Count > 0)
                {
                    TblBatchMeterCollection ObjTblBatchMeterCollection = new TblBatchMeterCollection()
                        .Where(TblBatchMeter.Columns.BatchID, SubSonic.Comparison.In, ObjTblBRColl.Select(x => x.BatchID))
                        .Load();
                    if (ObjTblBatchMeterCollection.Count > 0)
                    {
                        List<int> ObjLiTblBatchMeter = ObjTblBatchMeterCollection.Select(x => (int)x.MeterID).ToList();
                        List<TblMeter> ObjLiMeterColl = new List<TblMeter>();

                        do
                        {
                            int Range = ObjLiTblBatchMeter.Count > 2000 ? 2000 : ObjLiTblBatchMeter.Count();
                            List<int> ObjLiMeterIDs = ObjLiTblBatchMeter.GetRange(0, Range).ToList();
                            List<TblMeter> ObjLiMeter = new List<TblMeter>();

                            TblMeterCollection ObjTblMeterColl = new TblMeterCollection();
                            if (ObjLiMeterIDs.Count() > 0)
                                ObjTblMeterColl.Where(TblMeter.Columns.MeterID, SubSonic.Comparison.In, ObjLiMeterIDs.Select(x => x)).OrderByAsc(TblMeter.Columns.SerialNo).Load();


                            ObjLiMeter = ObjTblMeterColl.Select(x => x).ToList();
                            ObjLiMeterColl.AddRange(ObjLiMeter);
                            ObjLiTblBatchMeter.RemoveRange(0, Range);

                        } while (ObjLiTblBatchMeter.Count() > 0);

                        ObjLiMeterColl = ObjLiMeterColl.OrderBy(x => x.SerialNo == null).ThenBy(x => x.SerialNo).ToList();

                        List<clMeter> lstMeter = new List<clMeter>();

                        foreach (var MeterItem in ObjLiMeterColl)
                        {
                            TblMeterReadingCollection ObjTblMeterReadingColl = new TblMeterReadingCollection().Where(TblMeterReading.Columns.MeterID, MeterItem.MeterID).OrderByDesc(TblMeterReading.Columns.MeterReadingID).Load();

                            clMeter ObjClMeter = new clMeter();
                            ObjClMeter.meterid = MeterItem.MeterID;
                            ObjClMeter.meterno = MeterItem.MeterNo;
                            ObjClMeter.consumerid = MeterItem.ConsumerID > 0 ? (int)MeterItem.ConsumerID : -1;
                            ObjClMeter.suppmeterno = MeterItem.SupplementaryMeterNo;
                            ObjClMeter.serialno = MeterItem.SerialNo.ToString();
                            ObjClMeter.previousreading = ObjTblMeterReadingColl.Count > 0 ? Convert.ToInt32(ObjTblMeterReadingColl.First().CurrentReading) : 0;
                            lstMeter.Add(ObjClMeter);
                        }

                        JSONDAta = JsonConvert.SerializeObject(lstMeter);
                        return new ResponseHelper(1, lstMeter, new ErrorDef());
                    }
                    else
                        return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Data not found", EnumHelper.ErrorEnums.Exception.ToString(), "Data not found"));
                }
                else
                    return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Meter reader is invalid or inactive", EnumHelper.ErrorEnums.Exception.ToString(), "Meter reader is invalid or inactive"));
            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("FetchMeter", ex.Message, "FetchMeter", ex.Message, data.userid);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(data.userid, "api/fillappmeter/fetchmeter", JSONDAta, JSONDevice);
            }
        }
        //FetchMeter Method End


        //FetchConsumer Method Start
        [Route("api/fillappmeter/fetchconsumer")]
        [HttpGet]
        public ResponseHelper FetchConsumer([FromUri] clConsumer data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(data.userid, data.id, "FetchConsumer", ActivityHelper.Activity.FetchConsumer);

            try
            {
                TblBatchReaderCollection ObjTblBRColl = new TblBatchReaderCollection()
                    .Where(TblBatchReader.Columns.MeterReaderID, data.meterreaderid)
                    .Load();
                if (ObjTblBRColl.Count > 0)
                {
                    TblBatchMeterCollection ObjTblBatchMeter = new TblBatchMeterCollection()
                        .Where(TblBatchMeter.Columns.BatchID, SubSonic.Comparison.In, ObjTblBRColl.Select(x => x.BatchID))
                        .Load();
                    if (ObjTblBatchMeter.Count > 0)
                    {
                        List<int> ObjLiTblBatchMeter = ObjTblBatchMeter.Select(x => (int)x.MeterID).ToList();
                        List<TblMeter> ObjLiMeterColl = new List<TblMeter>();

                        do
                        {
                            int Range = ObjLiTblBatchMeter.Count > 2000 ? 2000 : ObjLiTblBatchMeter.Count();
                            List<int> ObjLiMeterIDs = ObjLiTblBatchMeter.GetRange(0, Range).ToList();
                            List<TblMeter> ObjLiMeter = new List<TblMeter>();

                            TblMeterCollection ObjTblMeterColl = new TblMeterCollection();
                            if (ObjLiMeterIDs.Count() > 0)
                                ObjTblMeterColl.Where(TblMeter.Columns.MeterID, SubSonic.Comparison.In, ObjLiMeterIDs.Select(x => x)).OrderByAsc(TblMeter.Columns.SerialNo).Load();


                            ObjLiMeter = ObjTblMeterColl.Select(x => x).ToList();
                            ObjLiMeterColl.AddRange(ObjLiMeter);
                            ObjLiTblBatchMeter.RemoveRange(0, Range);

                        } while (ObjLiTblBatchMeter.Count() > 0);

                        ObjLiMeterColl = ObjLiMeterColl.OrderBy(x => x.SerialNo == null).ThenBy(x => x.SerialNo).ToList();

                        if (ObjLiMeterColl.Count > 0)
                        {
                            
                            var result = ObjLiMeterColl.Select(x => new
                            {
                                consumerid = x.ConsumerID != null ? x.TblConsumer.CunsumerID : -1,
                                consumerno = x.ConsumerID != null ? x.TblConsumer.ConsumerNo : "",
                                consumername = x.ConsumerID != null ? x.TblConsumer.ConsumerName : "",
                                serialno = x.SerialNo
                                
                            });

                            JSONDAta = JsonConvert.SerializeObject(result);
                            return new ResponseHelper(1, result, new ErrorDef());
                        }
                        else
                            return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Consumer not found", EnumHelper.ErrorEnums.Exception.ToString(), "Consumer not found"));
                    }
                    else
                        return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Batch meter not found", EnumHelper.ErrorEnums.Exception.ToString(), "Batch meter not found"));
                }
                else
                    return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.NoRecordFound, "Meter reader is invalid or inactive", EnumHelper.ErrorEnums.Exception.ToString(), "Meter reader is invalid or inactive"));
            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("FetchConsumer", ex.Message, "FetchConsumer", ex.Message, data.userid);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(data.userid, "api/fillappmeter/fetchconsumer", JSONDAta, JSONDevice);
            }
        }
        //FetchConsumer Method End


        //FetchMeterIndexinConfiguration Method Start
        [Route("api/fillappmeter/fetchmeterindexinconfiguration")]
        [HttpGet]
        public ResponseHelper FetchMeterIndexinConfiguration([FromUri] clFetchMeterIndex data)
        {
            string JSONDAta = "";
            int ActivityID = 0;

            ActivityID = ActivityHelper.SaveActivity(data.userid, data.id, "FetchMeterIndexinConfiguration", ActivityHelper.Activity.FetchMeterIndexinConfiguration);

            try
            {
                TblSystemConfig ObjSystemConfig = new TblSystemConfig(TblSystemConfig.Columns.SystemConfigName, "AllowIndexing");

                JSONDAta = JsonConvert.SerializeObject(ObjSystemConfig.SystemConfigID > 0 ? ObjSystemConfig.SystemConfigValue == "1" : false);
                return new ResponseHelper(1, ObjSystemConfig.SystemConfigID > 0 ? ObjSystemConfig.SystemConfigValue == "1" : false, new ErrorDef());

                //if (ObjSystemConfig.SystemConfigID > 0)
                //{
                //    JSONDAta = JsonConvert.SerializeObject(ObjSystemConfig.SystemConfigID);
                //    return new ResponseHelper(1, ObjSystemConfig.SystemConfigID, new ErrorDef());
                //}
                //else
                //{
                //    JSONDAta = JsonConvert.SerializeObject(false);
                //    return new ResponseHelper(0, false, new ErrorDef());
                //}
            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging("FetchMeterIndexinConfiguration", ex.Message, "FetchMeterIndexinConfiguration", ex.Message, data.userid);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(data.userid, "api/fillappmeter/fetchmeterindexinconfiguration", JSONDAta, JSONDevice);
            }
        }
        //FetchMeterIndexinConfiguration Method End
    }
}
