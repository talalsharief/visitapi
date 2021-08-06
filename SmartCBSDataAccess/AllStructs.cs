using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace SmartCBSDataAccess
{
	#region Tables Struct
	public partial struct Tables
	{
		
		public static readonly string AppLogging = @"AppLogging";
        
		public static readonly string ListReport = @"ListReport";
        
		public static readonly string ListReportDetail = @"ListReportDetail";
        
		public static readonly string Privillage = @"Privillage";
        
		public static readonly string RolePrivillage = @"RolePrivillage";
        
		public static readonly string SMSLog = @"SMSLog";
        
		public static readonly string SMSSendingLog = @"SMSSendingLog";
        
		public static readonly string SystemLogging = @"SystemLogging";
        
		public static readonly string TblActivity = @"tblActivity";
        
		public static readonly string TblAdvance = @"tblAdvance";
        
		public static readonly string TblAdvertiseLocation = @"TblAdvertiseLocation";
        
		public static readonly string TblAdvertisement = @"TblAdvertisement";
        
		public static readonly string TblAppMeterStatus = @"TblAppMeterStatus";
        
		public static readonly string TblApprovalStatus = @"TblApprovalStatus";
        
		public static readonly string TblArrear = @"TblArrear";
        
		public static readonly string TblArrearAdjustment = @"TblArrearAdjustment";
        
		public static readonly string TblAssignPrivillage = @"TblAssignPrivillage";
        
		public static readonly string TblBatch = @"tblBatch";
        
		public static readonly string TblBatchDetail = @"TblBatchDetails";
        
		public static readonly string TblBatchMeter = @"TblBatchMeter";
        
		public static readonly string TblBatchReader = @"TblBatchReader";
        
		public static readonly string TblBill = @"TblBill";
        
		public static readonly string TblBillAdjustment = @"TblBillAdjustment";
        
		public static readonly string TblBillArear = @"TblBillArears";
        
		public static readonly string TblBillCalculation = @"TblBillCalculation";
        
		public static readonly string TblBillCalculationType = @"TblBillCalculationType";
        
		public static readonly string TblBillChargingMode = @"TblBillChargingMode";
        
		public static readonly string TblBillDetail = @"TblBillDetail";
        
		public static readonly string TblBillMode = @"TblBillModes";
        
		public static readonly string TblBillPayment = @"TblBillPayment";
        
		public static readonly string TblBillPaymentDatum = @"TblBillPaymentData";
        
		public static readonly string TblBillPrintLog = @"TblBillPrintLog";
        
		public static readonly string TblBranch = @"TblBranch";
        
		public static readonly string TblBrick = @"TblBrick";
        
		public static readonly string TblBrickType = @"TblBrickType";
        
		public static readonly string TblCategory = @"tblCategory";
        
		public static readonly string TblChargeCategory = @"tblChargeCategory";
        
		public static readonly string TblCharge = @"TblCharges";
        
		public static readonly string TblChargestype = @"TblChargestype";
        
		public static readonly string TblCheque = @"TblCheque";
        
		public static readonly string TblCollectionPoint = @"TblCollectionPoint";
        
		public static readonly string TblCollectionPointCategory = @"TblCollectionPointCategory";
        
		public static readonly string TblConsumer = @"TblConsumer";
        
		public static readonly string TblConsumerLedger = @"tblConsumerLedger";
        
		public static readonly string TblConsumerLedgerLog = @"tblConsumerLedgerLog";
        
		public static readonly string TblConsumerStatus = @"TblConsumerStatus";
        
		public static readonly string TblConsumerUpdateOnMeter = @"TblConsumerUpdateOnMeter";
        
		public static readonly string TblCurrency = @"tblCurrency";
        
		public static readonly string TblDBBackup = @"tblDBBackup";
        
		public static readonly string TblDesignation = @"TblDesignation";
        
		public static readonly string TblDetectionBill = @"tblDetectionBill";
        
		public static readonly string TblDetectionBillPayment = @"tblDetectionBillPayment";
        
		public static readonly string TblDocumentRequired = @"TblDocumentRequired";
        
		public static readonly string TblDupBillDatum = @"TblDupBillData";
        
		public static readonly string TblDupFeerderReading = @"TblDupFeerderReading";
        
		public static readonly string TblDupMeterReading = @"TblDupMeterReading";
        
		public static readonly string TblDupPMTReading = @"TblDupPMTReading";
        
		public static readonly string TblEmployee = @"tblEmployee";
        
		public static readonly string TblException = @"tblException";
        
		public static readonly string TblExpense = @"tblExpense";
        
		public static readonly string TblExpenseType = @"tblExpenseType";
        
		public static readonly string TblFeedBackStatus = @"TblFeedBackStatus";
        
		public static readonly string TblFeeder = @"TblFeeder";
        
		public static readonly string TblFeederReading = @"TblFeederReading";
        
		public static readonly string TblFeederReadingDatum = @"TblFeederReadingData";
        
		public static readonly string TblFeederReadMode = @"TblFeederReadMode";
        
		public static readonly string TblFeederStatus = @"TblFeederStatus";
        
		public static readonly string TblGSMLog = @"tblGSMLog";
        
		public static readonly string TblInstallement = @"TblInstallement";
        
		public static readonly string TblInventoryLog = @"TblInventoryLog";
        
		public static readonly string TblLedger = @"tblLedger";
        
		public static readonly string TblMeter = @"TblMeter";
        
		public static readonly string TblMeterDefected = @"TblMeterDefected";
        
		public static readonly string TblMeterDefectedDetail = @"TblMeterDefectedDetail";
        
		public static readonly string TblMeterDisConnection = @"TblMeterDisConnection";
        
		public static readonly string TblMeterDocument = @"tblMeterDocument";
        
		public static readonly string TblMeterFeedBack = @"TblMeterFeedBack";
        
		public static readonly string TblMeterInventoryDetail = @"TblMeterInventoryDetail";
        
		public static readonly string TblMeterInventoryMaster = @"TblMeterInventoryMaster";
        
		public static readonly string TblMeterIssue = @"TblMeterIssue";
        
		public static readonly string TblMeterIssueRequest = @"TblMeterIssueRequests";
        
		public static readonly string TblMeterNoUpdateLog = @"tblMeterNoUpdateLog";
        
		public static readonly string TblMeterReading = @"TblMeterReading";
        
		public static readonly string TblMeterReadingAdjustment = @"TblMeterReadingAdjustment";
        
		public static readonly string TblMeterReadingBatch = @"TblMeterReadingBatch";
        
		public static readonly string TblMeterReadingDatum = @"TblMeterReadingData";
        
		public static readonly string TblMeterReadingList = @"TblMeterReadingList";
        
		public static readonly string TblMeterReadingMode = @"TblMeterReadingMode";
        
		public static readonly string TblMeterReadingUser = @"TblMeterReadingUser";
        
		public static readonly string TblMeterReplacement = @"TblMeterReplacement";
        
		public static readonly string TblMeterStatus = @"TblMeterStatus";
        
		public static readonly string TblMeterType = @"TblMeterType";
        
		public static readonly string TblModule = @"tblModule";
        
		public static readonly string TblMonth = @"TblMonth";
        
		public static readonly string TblNewConComRepProfile = @"TblNewConComRepProfile";
        
		public static readonly string TblNewConDocumentRequiredDet = @"TblNewConDocumentRequiredDet";
        
		public static readonly string TblNewConLocation = @"TblNewConLocation";
        
		public static readonly string TblNewConnection = @"TblNewConnection";
        
		public static readonly string TblNewConPermisesDetail = @"TblNewConPermisesDetail";
        
		public static readonly string TblNewConRefrencesDetail = @"TblNewConRefrencesDetail";
        
		public static readonly string TblNewConServiceReqDetail = @"TblNewConServiceReqDetail";
        
		public static readonly string TblNewConTypeOfConDetail = @"TblNewConTypeOfConDetail";
        
		public static readonly string TblPMT = @"TblPMT";
        
		public static readonly string TblPMTReading = @"TblPMTReading";
        
		public static readonly string TblPMTReadingDatum = @"TblPMTReadingData";
        
		public static readonly string TblPMTReadMode = @"TblPMTReadMode";
        
		public static readonly string TblPMTStatus = @"TblPMTStatus";
        
		public static readonly string TblPreferenceApproval = @"tblPreferenceApproval";
        
		public static readonly string TblQueryLog = @"tblQueryLog";
        
		public static readonly string TblQueue = @"tblQueue";
        
		public static readonly string TblQueueDetail = @"tblQueueDetail";
        
		public static readonly string TblRecoveryTarget = @"TblRecoveryTarget";
        
		public static readonly string TblScheduleInstallement = @"TblScheduleInstallement";
        
		public static readonly string TblSMSLog = @"tblSMSLog";
        
		public static readonly string TblSystemConfig = @"tblSystemConfig";
        
		public static readonly string TblSystemLogging = @"tblSystemLogging";
        
		public static readonly string TblSystemParam = @"tblSystemParams";
        
		public static readonly string TblTariff = @"TblTariff";
        
		public static readonly string TblTariffSlab = @"TblTariffSlabs";
        
		public static readonly string TblTariffSlabsLog = @"TblTariffSlabsLog";
        
		public static readonly string TblTempSM = @"tblTempSMS";
        
		public static readonly string TblTypeOfConnection = @"TblTypeOfConnection";
        
		public static readonly string TblTypeOfUnit = @"TblTypeOfUnit";
        
		public static readonly string TblTypesOfService = @"TblTypesOfService";
        
		public static readonly string UserLogin = @"UserLogin";
        
		public static readonly string UserMenu = @"UserMenu";
        
		public static readonly string UserRole = @"UserRole";
        
	}
	#endregion
    #region Schemas
    public partial class Schemas {
		
		public static TableSchema.Table AppLogging
		{
            get { return DataService.GetSchema("AppLogging", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table ListReport
		{
            get { return DataService.GetSchema("ListReport", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table ListReportDetail
		{
            get { return DataService.GetSchema("ListReportDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table Privillage
		{
            get { return DataService.GetSchema("Privillage", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table RolePrivillage
		{
            get { return DataService.GetSchema("RolePrivillage", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table SMSLog
		{
            get { return DataService.GetSchema("SMSLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table SMSSendingLog
		{
            get { return DataService.GetSchema("SMSSendingLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table SystemLogging
		{
            get { return DataService.GetSchema("SystemLogging", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblActivity
		{
            get { return DataService.GetSchema("tblActivity", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblAdvance
		{
            get { return DataService.GetSchema("tblAdvance", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblAdvertiseLocation
		{
            get { return DataService.GetSchema("TblAdvertiseLocation", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblAdvertisement
		{
            get { return DataService.GetSchema("TblAdvertisement", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblAppMeterStatus
		{
            get { return DataService.GetSchema("TblAppMeterStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblApprovalStatus
		{
            get { return DataService.GetSchema("TblApprovalStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblArrear
		{
            get { return DataService.GetSchema("TblArrear", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblArrearAdjustment
		{
            get { return DataService.GetSchema("TblArrearAdjustment", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblAssignPrivillage
		{
            get { return DataService.GetSchema("TblAssignPrivillage", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBatch
		{
            get { return DataService.GetSchema("tblBatch", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBatchDetail
		{
            get { return DataService.GetSchema("TblBatchDetails", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBatchMeter
		{
            get { return DataService.GetSchema("TblBatchMeter", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBatchReader
		{
            get { return DataService.GetSchema("TblBatchReader", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBill
		{
            get { return DataService.GetSchema("TblBill", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillAdjustment
		{
            get { return DataService.GetSchema("TblBillAdjustment", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillArear
		{
            get { return DataService.GetSchema("TblBillArears", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillCalculation
		{
            get { return DataService.GetSchema("TblBillCalculation", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillCalculationType
		{
            get { return DataService.GetSchema("TblBillCalculationType", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillChargingMode
		{
            get { return DataService.GetSchema("TblBillChargingMode", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillDetail
		{
            get { return DataService.GetSchema("TblBillDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillMode
		{
            get { return DataService.GetSchema("TblBillModes", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillPayment
		{
            get { return DataService.GetSchema("TblBillPayment", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillPaymentDatum
		{
            get { return DataService.GetSchema("TblBillPaymentData", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBillPrintLog
		{
            get { return DataService.GetSchema("TblBillPrintLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBranch
		{
            get { return DataService.GetSchema("TblBranch", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBrick
		{
            get { return DataService.GetSchema("TblBrick", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblBrickType
		{
            get { return DataService.GetSchema("TblBrickType", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCategory
		{
            get { return DataService.GetSchema("tblCategory", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblChargeCategory
		{
            get { return DataService.GetSchema("tblChargeCategory", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCharge
		{
            get { return DataService.GetSchema("TblCharges", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblChargestype
		{
            get { return DataService.GetSchema("TblChargestype", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCheque
		{
            get { return DataService.GetSchema("TblCheque", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCollectionPoint
		{
            get { return DataService.GetSchema("TblCollectionPoint", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCollectionPointCategory
		{
            get { return DataService.GetSchema("TblCollectionPointCategory", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblConsumer
		{
            get { return DataService.GetSchema("TblConsumer", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblConsumerLedger
		{
            get { return DataService.GetSchema("tblConsumerLedger", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblConsumerLedgerLog
		{
            get { return DataService.GetSchema("tblConsumerLedgerLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblConsumerStatus
		{
            get { return DataService.GetSchema("TblConsumerStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblConsumerUpdateOnMeter
		{
            get { return DataService.GetSchema("TblConsumerUpdateOnMeter", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblCurrency
		{
            get { return DataService.GetSchema("tblCurrency", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDBBackup
		{
            get { return DataService.GetSchema("tblDBBackup", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDesignation
		{
            get { return DataService.GetSchema("TblDesignation", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDetectionBill
		{
            get { return DataService.GetSchema("tblDetectionBill", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDetectionBillPayment
		{
            get { return DataService.GetSchema("tblDetectionBillPayment", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDocumentRequired
		{
            get { return DataService.GetSchema("TblDocumentRequired", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDupBillDatum
		{
            get { return DataService.GetSchema("TblDupBillData", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDupFeerderReading
		{
            get { return DataService.GetSchema("TblDupFeerderReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDupMeterReading
		{
            get { return DataService.GetSchema("TblDupMeterReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblDupPMTReading
		{
            get { return DataService.GetSchema("TblDupPMTReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblEmployee
		{
            get { return DataService.GetSchema("tblEmployee", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblException
		{
            get { return DataService.GetSchema("tblException", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblExpense
		{
            get { return DataService.GetSchema("tblExpense", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblExpenseType
		{
            get { return DataService.GetSchema("tblExpenseType", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeedBackStatus
		{
            get { return DataService.GetSchema("TblFeedBackStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeeder
		{
            get { return DataService.GetSchema("TblFeeder", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeederReading
		{
            get { return DataService.GetSchema("TblFeederReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeederReadingDatum
		{
            get { return DataService.GetSchema("TblFeederReadingData", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeederReadMode
		{
            get { return DataService.GetSchema("TblFeederReadMode", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblFeederStatus
		{
            get { return DataService.GetSchema("TblFeederStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblGSMLog
		{
            get { return DataService.GetSchema("tblGSMLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblInstallement
		{
            get { return DataService.GetSchema("TblInstallement", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblInventoryLog
		{
            get { return DataService.GetSchema("TblInventoryLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblLedger
		{
            get { return DataService.GetSchema("tblLedger", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeter
		{
            get { return DataService.GetSchema("TblMeter", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterDefected
		{
            get { return DataService.GetSchema("TblMeterDefected", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterDefectedDetail
		{
            get { return DataService.GetSchema("TblMeterDefectedDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterDisConnection
		{
            get { return DataService.GetSchema("TblMeterDisConnection", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterDocument
		{
            get { return DataService.GetSchema("tblMeterDocument", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterFeedBack
		{
            get { return DataService.GetSchema("TblMeterFeedBack", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterInventoryDetail
		{
            get { return DataService.GetSchema("TblMeterInventoryDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterInventoryMaster
		{
            get { return DataService.GetSchema("TblMeterInventoryMaster", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterIssue
		{
            get { return DataService.GetSchema("TblMeterIssue", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterIssueRequest
		{
            get { return DataService.GetSchema("TblMeterIssueRequests", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterNoUpdateLog
		{
            get { return DataService.GetSchema("tblMeterNoUpdateLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReading
		{
            get { return DataService.GetSchema("TblMeterReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingAdjustment
		{
            get { return DataService.GetSchema("TblMeterReadingAdjustment", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingBatch
		{
            get { return DataService.GetSchema("TblMeterReadingBatch", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingDatum
		{
            get { return DataService.GetSchema("TblMeterReadingData", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingList
		{
            get { return DataService.GetSchema("TblMeterReadingList", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingMode
		{
            get { return DataService.GetSchema("TblMeterReadingMode", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReadingUser
		{
            get { return DataService.GetSchema("TblMeterReadingUser", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterReplacement
		{
            get { return DataService.GetSchema("TblMeterReplacement", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterStatus
		{
            get { return DataService.GetSchema("TblMeterStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMeterType
		{
            get { return DataService.GetSchema("TblMeterType", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblModule
		{
            get { return DataService.GetSchema("tblModule", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblMonth
		{
            get { return DataService.GetSchema("TblMonth", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConComRepProfile
		{
            get { return DataService.GetSchema("TblNewConComRepProfile", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConDocumentRequiredDet
		{
            get { return DataService.GetSchema("TblNewConDocumentRequiredDet", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConLocation
		{
            get { return DataService.GetSchema("TblNewConLocation", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConnection
		{
            get { return DataService.GetSchema("TblNewConnection", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConPermisesDetail
		{
            get { return DataService.GetSchema("TblNewConPermisesDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConRefrencesDetail
		{
            get { return DataService.GetSchema("TblNewConRefrencesDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConServiceReqDetail
		{
            get { return DataService.GetSchema("TblNewConServiceReqDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblNewConTypeOfConDetail
		{
            get { return DataService.GetSchema("TblNewConTypeOfConDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPMT
		{
            get { return DataService.GetSchema("TblPMT", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPMTReading
		{
            get { return DataService.GetSchema("TblPMTReading", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPMTReadingDatum
		{
            get { return DataService.GetSchema("TblPMTReadingData", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPMTReadMode
		{
            get { return DataService.GetSchema("TblPMTReadMode", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPMTStatus
		{
            get { return DataService.GetSchema("TblPMTStatus", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblPreferenceApproval
		{
            get { return DataService.GetSchema("tblPreferenceApproval", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblQueryLog
		{
            get { return DataService.GetSchema("tblQueryLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblQueue
		{
            get { return DataService.GetSchema("tblQueue", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblQueueDetail
		{
            get { return DataService.GetSchema("tblQueueDetail", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblRecoveryTarget
		{
            get { return DataService.GetSchema("TblRecoveryTarget", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblScheduleInstallement
		{
            get { return DataService.GetSchema("TblScheduleInstallement", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblSMSLog
		{
            get { return DataService.GetSchema("tblSMSLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblSystemConfig
		{
            get { return DataService.GetSchema("tblSystemConfig", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblSystemLogging
		{
            get { return DataService.GetSchema("tblSystemLogging", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblSystemParam
		{
            get { return DataService.GetSchema("tblSystemParams", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTariff
		{
            get { return DataService.GetSchema("TblTariff", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTariffSlab
		{
            get { return DataService.GetSchema("TblTariffSlabs", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTariffSlabsLog
		{
            get { return DataService.GetSchema("TblTariffSlabsLog", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTempSM
		{
            get { return DataService.GetSchema("tblTempSMS", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTypeOfConnection
		{
            get { return DataService.GetSchema("TblTypeOfConnection", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTypeOfUnit
		{
            get { return DataService.GetSchema("TblTypeOfUnit", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table TblTypesOfService
		{
            get { return DataService.GetSchema("TblTypesOfService", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table UserLogin
		{
            get { return DataService.GetSchema("UserLogin", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table UserMenu
		{
            get { return DataService.GetSchema("UserMenu", "PrimaryProvider"); }
		}
        
		public static TableSchema.Table UserRole
		{
            get { return DataService.GetSchema("UserRole", "PrimaryProvider"); }
		}
        
	
    }
    #endregion
    #region View Struct
    public partial struct Views 
    {
		
		public static readonly string VwAssignPrivillage = @"VwAssignPrivillage";
        
		public static readonly string VwBill = @"VwBill";
        
		public static readonly string VwBillDetail = @"VwBillDetail";
        
		public static readonly string VwBillGraph = @"VwBillGraph";
        
		public static readonly string VwBillPaymentDatum = @"VwBillPaymentData";
        
		public static readonly string VwBillReport = @"VwBillReport";
        
		public static readonly string VwCollectionPoint = @"VwCollectionPoints";
        
		public static readonly string VwConsumer = @"VwConsumer";
        
		public static readonly string VwEmployee = @"VwEmployee";
        
		public static readonly string VwFeederChart = @"VwFeederChart";
        
		public static readonly string VwFeederLoadDatum = @"vwFeederLoadData";
        
		public static readonly string VwMeterReadingDatum = @"VwMeterReadingData";
        
		public static readonly string VwPMTChart = @"VwPMTChart";
        
		public static readonly string VwPMTReading = @"VwPMTReadings";
        
		public static readonly string VwRolePrivillage = @"vwRolePrivillage";
        
		public static readonly string VwRptConsumer = @"VwRptConsumer";
        
		public static readonly string VwRptDefualder = @"VwRptDefualders";
        
		public static readonly string VwRptPaymentSummary = @"VwRptPaymentSummary";
        
		public static readonly string VwSystemLog = @"VwSystemLog";
        
		public static readonly string VwTblAdvertisement = @"VwTblAdvertisement";
        
		public static readonly string VwTblBillAdjustment = @"VwTblBillAdjustment";
        
		public static readonly string VwTblBillPrintLog = @"VwTblBillPrintLog";
        
		public static readonly string VwTblBrick = @"VwTblBrick";
        
		public static readonly string VwTblConsumerMeterWise = @"VwTblConsumerMeterWise";
        
		public static readonly string VwTblFeeder = @"VwTblFeeder";
        
		public static readonly string VwTblFeederReading = @"VwTblFeederReading";
        
		public static readonly string VwTblFeederReadingDatum = @"VwTblFeederReadingData";
        
		public static readonly string VwTblMeter = @"VwTblMeter";
        
		public static readonly string VwTblMeterConsumerWise = @"VwTblMeterConsumerWise";
        
		public static readonly string VwTblMeterDefected = @"VwTblMeterDefected";
        
		public static readonly string VwTblMeterDefectedDetail = @"VwTblMeterDefectedDetail";
        
		public static readonly string VwTblMeterDisConnection = @"VwTblMeterDisConnection";
        
		public static readonly string VwTblMeterFeedBack = @"VwTblMeterFeedBack";
        
		public static readonly string VwTblMeterInventoryDetail = @"VwTblMeterInventoryDetail";
        
		public static readonly string VwTblMeterIssue = @"VwTblMeterIssue";
        
		public static readonly string VwTblMeterReading = @"VwTblMeterReading";
        
		public static readonly string VwTblMeterReadingUser = @"VwTblMeterReadingUser";
        
		public static readonly string VwTblMeterReplacement = @"VwTblMeterReplacement";
        
		public static readonly string VwTblNewConnection = @"VwTblNewConnection";
        
		public static readonly string VwTblPMT = @"VwTblPMT";
        
		public static readonly string VwTblPMTReadingDatum = @"VwTblPMTReadingData";
        
		public static readonly string VwTblPMTReading = @"VwTblPMTReadings";
        
		public static readonly string VwTblRecoveryTarget = @"VwTblRecoveryTarget";
        
		public static readonly string VwTblTariffSlab = @"VwTblTariffSlab";
        
		public static readonly string VwUserLogin = @"VwUserLogin";
        
		public static readonly string VwUserMenu = @"VwUserMenu";
        
    }
    #endregion
    
    #region Query Factories
	public static partial class DB
	{
        public static DataProvider _provider = DataService.Providers["PrimaryProvider"];
        static ISubSonicRepository _repository;
        public static ISubSonicRepository Repository 
        {
            get 
            {
                if (_repository == null)
                    return new SubSonicRepository(_provider);
                return _repository; 
            }
            set { _repository = value; }
        }
        public static Select SelectAllColumnsFrom<T>() where T : RecordBase<T>, new()
	    {
            return Repository.SelectAllColumnsFrom<T>();
	    }
	    public static Select Select()
	    {
            return Repository.Select();
	    }
	    
		public static Select Select(params string[] columns)
		{
            return Repository.Select(columns);
        }
	    
		public static Select Select(params Aggregate[] aggregates)
		{
            return Repository.Select(aggregates);
        }
   
	    public static Update Update<T>() where T : RecordBase<T>, new()
	    {
            return Repository.Update<T>();
	    }
	    
	    public static Insert Insert()
	    {
            return Repository.Insert();
	    }
	    
	    public static Delete Delete()
	    {
            return Repository.Delete();
	    }
	    
	    public static InlineQuery Query()
	    {
            return Repository.Query();
	    }
	    	    
	    
	}
    #endregion
    
}
#region Databases
public partial struct Databases 
{
	
	public static readonly string PrimaryProvider = @"PrimaryProvider";
    
}
#endregion