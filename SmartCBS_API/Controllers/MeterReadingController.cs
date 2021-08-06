using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SmartCBS_API.BusinessHelpers;
using SmartCBS_API.Helper;
using SmartCBSDataAccess;
using SmartCBSDataAccess.BusinessHelpers;
using SmartCBSPresentation.BusinessHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartCBS_API.Controllers
{
    public class MeterReadingController : ApiController
    {
        //SyncMeterReading Method Start
        [Route("api/meterreading/syncmeterreading")]
        [HttpGet]
        public ResponseHelper SyncMeterReading([FromUri] clMeterReading data)
        {
            string JSONDAta = "";
            string Activity = "";

            Activity = ActivityHelper.SaveActivity(data.userid, data.id, "MeterReading", ActivityHelper.Activity.SyncMeterReading).ToString();

            try
            {
                AppLogging objAppLogging = new AppLogging();
                objAppLogging.Activity = "Meter Reading";
                objAppLogging.IsSuccessful = true;

                try
                {
                    objAppLogging.MeterReadingReadingUser = data.meterreadinguserid;
                    //List<List<string>> lstmeter = new List<List<string>>();
                    //lstmeter.Add(data.lstMeterReading);
                    //objAppLogging.JsonData = JsonConvert.SerializeObject(lstmeter);

                    //Change Flow of List
                    objAppLogging.JsonData = JsonConvert.SerializeObject(data.lstMeterReading);
                }
                catch (Exception e)
                {
                    objAppLogging.IsSuccessful = false;
                    objAppLogging.Exception = "Logging Error : " + e.Message;
                }

                #region
                //DataTable dtMeter = new DataTable();
                //dtMeter.Columns.Add("MeterId");
                //dtMeter.Columns.Add("MeterNo");
                //dtMeter.Columns.Add("CurrentReadig");
                //dtMeter.Columns.Add("Cload");
                //dtMeter.Columns.Add("MeterReadingUserID");
                //dtMeter.Columns.Add("BranchID");
                //dtMeter.Columns.Add("ConsumerID");
                //dtMeter.Columns.Add("ImageUrl");
                //dtMeter.Columns.Add("SerialNo");
                //dtMeter.Columns.Add("MeterReadingDate");



                //try
                //{
                //    foreach (string Meter in data.lstMeterReading)
                //    {
                //        string string1 = "[" + Meter + "]";

                //        //clMeterReading[] objclMeter = JsonSerializer.Deserialize<clMeterReading[]>(string1);
                //        clMeterReading[] objclMeter = JsonConvert.DeserializeObject<clMeterReading[]>(string1);
                //        DataRow dtrow = dtMeter.NewRow();
                //        dtrow[0] = objclMeter[0].meterid;
                //        dtrow[1] = objclMeter[0].meterno;
                //        dtrow[2] = objclMeter[0].currentreadig;
                //        dtrow[3] = objclMeter[0].cload;
                //        dtrow[4] = objclMeter[0].meterreadinguserid;
                //        dtrow[5] = objclMeter[0].branchid;
                //        dtrow[6] = objclMeter[0].consumerid;
                //        dtrow[7] = objclMeter[0].imageurl;
                //        dtrow[8] = objclMeter[0].serialno == null ? "-1" : objclMeter[0].serialno;
                //        dtrow[9] = objclMeter[0].meterreadingdate;
                //        dtMeter.Rows.Add(dtrow);
                //    }
                //}
                //catch (Exception e)
                //{
                //    objAppLogging.IsSuccessful = false;
                //    objAppLogging.Exception = e.Message;

                //}
                #endregion

                List<int> lstMeterReadingId = new List<int>();
                try
                {
                    List<int> ObjLiMeterIDs = new List<int>();
                    int BranchID = -1;
                    
                    int Year = MeterReadingHelper.GetYear();
                    int Month = MeterReadingHelper.GetMonth();

                    foreach (var item in data.lstMeterReading)
                    {
                        BranchID = item.branchid;
                        TblMeterReadingCollection ObjTblMeterReadingColl = new TblMeterReadingCollection();
                        ObjTblMeterReadingColl.Where(TblMeterReading.Columns.MeterID, item.meterid);
                        ObjTblMeterReadingColl.OrderByDesc(TblMeterReading.Columns.MeterReadingID).Load();

                        int CurrentReading = ObjTblMeterReadingColl.Count > 0 ? Convert.ToInt32(ObjTblMeterReadingColl[0].CurrentReading) : 0;
                        
                        DateTime MeterReadingDate = MeterReadingHelper.GetMeterReadingMonth(item.meterreadingdate);
                        string _MeterReadingMonth = MeterReadingDate.Month.ToString();
                        string _MeterReadingYear = MeterReadingDate.ToString("yyyy");
                        Month = Convert.ToInt32(_MeterReadingMonth);
                        Year = Convert.ToInt32(_MeterReadingYear);

                        TblMeterReading ObjtblMeterReading = new TblMeterReading();
                        ObjtblMeterReading.MeterID = item.meterid;
                        ObjtblMeterReading.MeterReadModeID = new TblMeterReadingMode(TblMeterReadingMode.Columns.MeterReadCode, "Mob").MeterReadModeID;
                        ObjtblMeterReading.MeterReadingMonth = Month;
                        ObjtblMeterReading.MeterReadingYear = Year;
                        ObjtblMeterReading.PreviousReading = CurrentReading;
                        ObjtblMeterReading.CurrentReading = item.currentreadig;
                        ObjtblMeterReading.TotalUnits = item.currentreadig - Convert.ToDecimal(CurrentReading);
                        ObjtblMeterReading.MultiplyingFactor = new TblMeter(ObjtblMeterReading.MeterID).Mf.HasValue ? new TblMeter(ObjtblMeterReading.MeterID).Mf.Value : 1;
                        ObjtblMeterReading.UnitsConsumed = (item.currentreadig - Convert.ToDecimal(CurrentReading)) * ObjtblMeterReading.MultiplyingFactor.Value;
                        ObjtblMeterReading.MeterReadingDate = DateTime.Now;
                        ObjtblMeterReading.MeterReadingUserID = item.meterreadinguserid;
                        ObjtblMeterReading.ConsumerID = item.consumerid;
                        ObjtblMeterReading.CLoad = item.cload;
                        ObjtblMeterReading.BranchID = item.branchid;
                        ObjtblMeterReading.MeterReadBy = 1010;
                        if (item.imageurl != "")
                            ObjtblMeterReading.MeterImage = Path.GetFileName(item.imageurl);

                        ObjtblMeterReading.IsSupplementary = false;

                        //Checking duplicate meter reading
                        TblMeterReadingCollection ObjTblMeterReadingCol = new TblMeterReadingCollection()
                            .Where(TblMeterReading.Columns.MeterReadingMonth, _MeterReadingMonth)
                            .Where(TblMeterReading.Columns.MeterReadingYear, _MeterReadingYear)
                            .Where(TblMeterReading.Columns.MeterID, ObjtblMeterReading.MeterID).Load();

                        TblMeter ObjTblMeter = new TblMeter(ObjtblMeterReading.MeterID);
                        bool IsLaterBillGenerated = MeterReadingHelper.ValidateLaterBillGeneration((int)ObjtblMeterReading.MeterID, Convert.ToInt32(_MeterReadingMonth), Convert.ToInt32(_MeterReadingYear));
                        if (ObjTblMeterReadingCol.Count == 0 && !IsLaterBillGenerated)
                        {
                            ObjtblMeterReading.Save();
                            lstMeterReadingId.Add(ObjtblMeterReading.MeterReadingID);
                            MeterReadingHelper.SetMeterStatusAsActive((int)ObjtblMeterReading.MeterID);
                        }
                        else
                        {
                            TblDupMeterReading ObjTblDupMeterReading = new TblDupMeterReading();
                            ObjTblDupMeterReading.MeterNo = ObjTblMeter.MeterNo;
                            ObjTblDupMeterReading.MeterReading = ObjtblMeterReading.CurrentReading;
                            ObjTblDupMeterReading.ConsumerID = ObjTblMeter.ConsumerID;
                            ObjTblDupMeterReading.MultiplyingFactor = Convert.ToInt32(ObjtblMeterReading.MultiplyingFactor);

                            ObjTblDupMeterReading.MeterReadingDate = Convert.ToDateTime(ObjtblMeterReading.MeterReadingDate);
                            ObjTblDupMeterReading.IsApprovedTime = false;
                            ObjTblDupMeterReading.Month = ObjtblMeterReading.MeterReadingMonth.ToString();
                            ObjTblDupMeterReading.Year = ObjtblMeterReading.MeterReadingYear.ToString();
                            ObjTblDupMeterReading.ErrorX = ObjTblMeterReadingCol.Count == 0 ? "Cannot add meter reading because Bill after " + ObjtblMeterReading.MeterReadingMonth + " " + ObjtblMeterReading.MeterReadingYear + " is already generated." : "Meter reading discarded because of duplication";
                            ObjTblDupMeterReading.MeterReadingUserID = data.meterreadinguserid;
                            ObjTblDupMeterReading.Save();
                            lstMeterReadingId.Add(ObjTblDupMeterReading.DuplicateDataID); // Added By Muhammad Areeb Hassan
                        }

                        if (!string.IsNullOrEmpty(item.serialno) && item.serialno != "undefined" && Convert.ToInt32(item.serialno) > 0)
                        {
                            TblMeter ObjTblMeterSe = new TblMeter(ObjtblMeterReading.MeterID);
                            ObjTblMeterSe.SerialNo = item.serialno != null ? Convert.ToInt32(item.serialno) : 0;
                            ObjTblMeterSe.Save();
                        }
                        ObjLiMeterIDs.Add((int)ObjtblMeterReading.MeterID);

                    }
                    
                    clGenerateBill generateBill = new clGenerateBill();
                    DateTime DueDate = DateTime.Today.AddDays(Convert.ToInt32(new TblSystemConfig(TblSystemConfig.Columns.SystemConfigName, "NoOfDueDays").SystemConfigValue));

                    generateBill.EmployeeID = new TblEmployeeCollection().Load()[0].EmployeeID;//1010;
                    generateBill.BranchID = BranchID;//1;
                    generateBill.meterIDList = ObjLiMeterIDs;
                    generateBill.cmbMonth = Month;
                    generateBill.cmbYear = Year;
                    generateBill.txtBillIssueDate = DateTime.Today;
                    generateBill.dtBillingDueDate = Convert.ToDateTime(DueDate);

                    string json = JsonConvert.SerializeObject(generateBill,
                    new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });

                    string WebServerURL = ConfigurationManager.AppSettings.Get("WebServerURL") + "GenerateBills?Bills=" + json;
                    HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(WebServerURL);

                    myRequest.Method = "GET";
                    myRequest.GetResponseAsync();
                }

                catch (Exception e)
                {
                    objAppLogging.IsSuccessful = false;
                    objAppLogging.Exception = e.Message;
                    JSONDAta = JsonConvert.SerializeObject(lstMeterReadingId);
                    
                }
                objAppLogging.Save();
                JSONDAta = JsonConvert.SerializeObject(lstMeterReadingId);
                return new ResponseHelper(1, lstMeterReadingId, new ErrorDef());
            }
            catch (Exception ex)
            {
                BaseHelper.ExceptionLogging(Activity, ex.Message, "SyncMeterReading", ex.Message, data.userid);
                return new ResponseHelper(0, new object(), new ErrorDef((int)EnumHelper.ErrorEnums.InvalidData, "Error", EnumHelper.ErrorEnums.Exception.ToString(), "This data is Incorrect"));
            }
            finally
            {
                string JSONDevice = JsonConvert.SerializeObject(data.deviceinfo);

                BaseHelper.SystemLogging(data.userid, "api/meterreading/syncmeterreading", JSONDAta, JSONDevice);
            }
        }
        //SyncMeterReading Method End
    }
}
