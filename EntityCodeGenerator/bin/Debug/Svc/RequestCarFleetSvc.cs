using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using Common.CSWF.Entity;
using Common.CSWF.Services;
using Common.CSWF.Core;


namespace Common.CSWF.CommonSvc
{
    [ServiceObject("RequestCarFleetSvc", "RequestCarFleetSvc", "RequestCarFleetSvc")]
    public partial class RequestCarFleetSvc
    {
		[Property("RequestID", SoType.Number, "RequestID", "RequestID")]
        public long RequestID { get; set; }

		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }

		[Property("RequestTypeCode", SoType.Text, "RequestTypeCode", "RequestTypeCode")]
        public string RequestTypeCode { get; set; }

		[Property("RequestTypeName", SoType.Text, "RequestTypeName", "RequestTypeName")]
        public string RequestTypeName { get; set; }

		[Property("Status", SoType.Text, "Status", "Status")]
        public string Status { get; set; }

		[Property("ProcInstID", SoType.Number, "ProcInstID", "ProcInstID")]
        public int ProcInstID { get; set; }

		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }

		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }

		[Property("RequestUrl", SoType.Text, "RequestUrl", "RequestUrl")]
        public string RequestUrl { get; set; }

		[Property("CreateBy", SoType.Text, "CreateBy", "CreateBy")]
        public string CreateBy { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }

		[Property("UpdateBy", SoType.Text, "UpdateBy", "UpdateBy")]
        public string UpdateBy { get; set; }

		[Property("UpdateTime", SoType.DateTime, "UpdateTime", "UpdateTime")]
        public Nullable<System.DateTime> UpdateTime { get; set; }

		[Property("CompleteTime", SoType.DateTime, "CompleteTime", "CompleteTime")]
        public Nullable<System.DateTime> CompleteTime { get; set; }

		[Property("FormFields", SoType.Text, "FormFields", "FormFields")]
        public string FormFields { get; set; }

		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }

		[Property("BAName", SoType.Text, "BAName", "BAName")]
        public string BAName { get; set; }

		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }

		[Property("BLName", SoType.Text, "BLName", "BLName")]
        public string BLName { get; set; }

		[Property("FunctionRegionCode", SoType.Text, "FunctionRegionCode", "FunctionRegionCode")]
        public string FunctionRegionCode { get; set; }

		[Property("FunctionRegionName", SoType.Text, "FunctionRegionName", "FunctionRegionName")]
        public string FunctionRegionName { get; set; }

		[Property("DriverLicenseCode", SoType.Text, "DriverLicenseCode", "DriverLicenseCode")]
        public string DriverLicenseCode { get; set; }

		[Property("DriverLicenseType", SoType.Text, "DriverLicenseType", "DriverLicenseType")]
        public string DriverLicenseType { get; set; }

		[Property("DriverLicenseStartDate", SoType.DateTime, "DriverLicenseStartDate", "DriverLicenseStartDate")]
        public Nullable<System.DateTime> DriverLicenseStartDate { get; set; }

		[Property("DriverLicenseEndDate", SoType.DateTime, "DriverLicenseEndDate", "DriverLicenseEndDate")]
        public Nullable<System.DateTime> DriverLicenseEndDate { get; set; }

		[Property("VehicleLicenseCode", SoType.Text, "VehicleLicenseCode", "VehicleLicenseCode")]
        public string VehicleLicenseCode { get; set; }

		[Property("CompulsoryInsuranceStartDate", SoType.DateTime, "CompulsoryInsuranceStartDate", "CompulsoryInsuranceStartDate")]
        public Nullable<System.DateTime> CompulsoryInsuranceStartDate { get; set; }

		[Property("CompulsoryInsuranceEndDate", SoType.DateTime, "CompulsoryInsuranceEndDate", "CompulsoryInsuranceEndDate")]
        public Nullable<System.DateTime> CompulsoryInsuranceEndDate { get; set; }

		[Property("YearlyInspectionDate", SoType.DateTime, "YearlyInspectionDate", "YearlyInspectionDate")]
        public Nullable<System.DateTime> YearlyInspectionDate { get; set; }

		[Property("RentingTypeCode", SoType.Text, "RentingTypeCode", "RentingTypeCode")]
        public string RentingTypeCode { get; set; }

		[Property("RentingTypeName", SoType.Text, "RentingTypeName", "RentingTypeName")]
        public string RentingTypeName { get; set; }

		[Property("HasDriver", SoType.YesNo, "HasDriver", "HasDriver")]
        public Nullable<bool> HasDriver { get; set; }

		[Property("DriverName", SoType.Text, "DriverName", "DriverName")]
        public string DriverName { get; set; }

		[Property("RentingCompany", SoType.Text, "RentingCompany", "RentingCompany")]
        public string RentingCompany { get; set; }

		[Property("ActualUser", SoType.Text, "ActualUser", "ActualUser")]
        public string ActualUser { get; set; }

       
    }

    public partial class RequestCarFleetSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public RequestCarFleetSvc()
        { }

        public static RequestCarFleetSvc GetFromEntity(RequestCarFleet entity)
        {
            RequestCarFleetSvc svc = new RequestCarFleetSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(RequestCarFleet entity)
        {
			if (entity == null) return;

			this.RequestID = entity.RequestID;
			this.RequestNo = entity.RequestNo;
			this.RequestTypeCode = entity.RequestTypeCode;
			this.RequestTypeName = entity.RequestTypeName;
			this.Status = entity.Status;
			this.ProcInstID = entity.ProcInstID;
			this.InitiatorID = entity.InitiatorID;
			this.InitiatorName = entity.InitiatorName;
			this.RequestUrl = entity.RequestUrl;
			this.CreateBy = entity.CreateBy;
			this.CreateTime = entity.CreateTime;
			this.UpdateBy = entity.UpdateBy;
			this.UpdateTime = entity.UpdateTime;
			this.CompleteTime = entity.CompleteTime;
			this.FormFields = entity.FormFields;
			this.BACode = entity.BACode;
			this.BAName = entity.BAName;
			this.BLCode = entity.BLCode;
			this.BLName = entity.BLName;
			this.FunctionRegionCode = entity.FunctionRegionCode;
			this.FunctionRegionName = entity.FunctionRegionName;
			this.DriverLicenseCode = entity.DriverLicenseCode;
			this.DriverLicenseType = entity.DriverLicenseType;
			this.DriverLicenseStartDate = entity.DriverLicenseStartDate;
			this.DriverLicenseEndDate = entity.DriverLicenseEndDate;
			this.VehicleLicenseCode = entity.VehicleLicenseCode;
			this.CompulsoryInsuranceStartDate = entity.CompulsoryInsuranceStartDate;
			this.CompulsoryInsuranceEndDate = entity.CompulsoryInsuranceEndDate;
			this.YearlyInspectionDate = entity.YearlyInspectionDate;
			this.RentingTypeCode = entity.RentingTypeCode;
			this.RentingTypeName = entity.RentingTypeName;
			this.HasDriver = entity.HasDriver;
			this.DriverName = entity.DriverName;
			this.RentingCompany = entity.RentingCompany;
			this.ActualUser = entity.ActualUser;
		}

        public RequestCarFleet ConvertToEntity()
        {
            var entity = new RequestCarFleet();
			entity.RequestID = this.RequestID;
			entity.RequestNo = this.RequestNo;
			entity.RequestTypeCode = this.RequestTypeCode;
			entity.RequestTypeName = this.RequestTypeName;
			entity.Status = this.Status;
			entity.ProcInstID = this.ProcInstID;
			entity.InitiatorID = this.InitiatorID;
			entity.InitiatorName = this.InitiatorName;
			entity.RequestUrl = this.RequestUrl;
			entity.CreateBy = this.CreateBy;
			entity.CreateTime = this.CreateTime;
			entity.UpdateBy = this.UpdateBy;
			entity.UpdateTime = this.UpdateTime;
			entity.CompleteTime = this.CompleteTime;
			entity.FormFields = this.FormFields;
			entity.BACode = this.BACode;
			entity.BAName = this.BAName;
			entity.BLCode = this.BLCode;
			entity.BLName = this.BLName;
			entity.FunctionRegionCode = this.FunctionRegionCode;
			entity.FunctionRegionName = this.FunctionRegionName;
			entity.DriverLicenseCode = this.DriverLicenseCode;
			entity.DriverLicenseType = this.DriverLicenseType;
			entity.DriverLicenseStartDate = this.DriverLicenseStartDate;
			entity.DriverLicenseEndDate = this.DriverLicenseEndDate;
			entity.VehicleLicenseCode = this.VehicleLicenseCode;
			entity.CompulsoryInsuranceStartDate = this.CompulsoryInsuranceStartDate;
			entity.CompulsoryInsuranceEndDate = this.CompulsoryInsuranceEndDate;
			entity.YearlyInspectionDate = this.YearlyInspectionDate;
			entity.RentingTypeCode = this.RentingTypeCode;
			entity.RentingTypeName = this.RentingTypeName;
			entity.HasDriver = this.HasDriver;
			entity.DriverName = this.DriverName;
			entity.RentingCompany = this.RentingCompany;
			entity.ActualUser = this.ActualUser;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "RequestID" },
            new string[] { "RequestID","RequestNo","RequestTypeCode","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields","BACode","BAName","BLCode","BLName","FunctionRegionCode","FunctionRegionName","DriverLicenseCode","DriverLicenseType","DriverLicenseStartDate","DriverLicenseEndDate","VehicleLicenseCode","CompulsoryInsuranceStartDate","CompulsoryInsuranceEndDate","YearlyInspectionDate","RentingTypeCode","RentingTypeName","HasDriver","DriverName","RentingCompany","ActualUser"})]
        public RequestCarFleetSvc Read()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var model = service.Read(RequestID);
			if (model == null)
            {
                return null;
            }

            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestTypeCode","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields","BACode","BAName","BLCode","BLName","FunctionRegionCode","FunctionRegionName","DriverLicenseCode","DriverLicenseType","DriverLicenseStartDate","DriverLicenseEndDate","VehicleLicenseCode","CompulsoryInsuranceStartDate","CompulsoryInsuranceEndDate","YearlyInspectionDate","RentingTypeCode","RentingTypeName","HasDriver","DriverName","RentingCompany","ActualUser" },
            new string[] { "RequestID"})]
        public RequestCarFleetSvc Create()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var entity = ConvertToEntity();
            RequestID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestTypeCode","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields","BACode","BAName","BLCode","BLName","FunctionRegionCode","FunctionRegionName","DriverLicenseCode","DriverLicenseType","DriverLicenseStartDate","DriverLicenseEndDate","VehicleLicenseCode","CompulsoryInsuranceStartDate","CompulsoryInsuranceEndDate","YearlyInspectionDate","RentingTypeCode","RentingTypeName","HasDriver","DriverName","RentingCompany","ActualUser" },
            new string[] { })]
        public void Update()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "RequestID" },
            new string[] { })]
        public void Delete()
        {
            RequestCarFleetService service = new RequestCarFleetService(ConnString);
            service.Delete(RequestID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "RequestID","RequestNo","RequestTypeCode","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields","BACode","BAName","BLCode","BLName","FunctionRegionCode","FunctionRegionName","DriverLicenseCode","DriverLicenseType","DriverLicenseStartDate","DriverLicenseEndDate","VehicleLicenseCode","CompulsoryInsuranceStartDate","CompulsoryInsuranceEndDate","YearlyInspectionDate","RentingTypeCode","RentingTypeName","HasDriver","DriverName","RentingCompany","ActualUser" },
            new string[] { "RequestID","RequestNo","RequestTypeCode","RequestTypeName","Status","ProcInstID","InitiatorID","InitiatorName","RequestUrl","CreateBy","CreateTime","UpdateBy","UpdateTime","CompleteTime","FormFields","BACode","BAName","BLCode","BLName","FunctionRegionCode","FunctionRegionName","DriverLicenseCode","DriverLicenseType","DriverLicenseStartDate","DriverLicenseEndDate","VehicleLicenseCode","CompulsoryInsuranceStartDate","CompulsoryInsuranceEndDate","YearlyInspectionDate","RentingTypeCode","RentingTypeName","HasDriver","DriverName","RentingCompany","ActualUser" })]
        public List<RequestCarFleetSvc> List()
        {
			var conditions = BuildConditions();
            List<RequestCarFleet> entityList = new List<RequestCarFleet>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.RequestCarFleet.Query(descriptor).ToList() ;
            }

            var result = entityList.Select(m => GetFromEntity(m)).ToList();
            return result;
        }

		private List<QueryCondition> BuildConditions()
        {
            List<QueryCondition> list = new List<QueryCondition>();
			if (RequestID != default(long))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = RequestID;
				condition.ValueType = typeof(long).GetTypeName();
				list.Add(condition);
			}
			if (RequestNo != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestNo";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestNo;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RequestTypeCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestTypeCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestTypeCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RequestTypeName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestTypeName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestTypeName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (Status != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "Status";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = Status;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (ProcInstID != default(int))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ProcInstID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = ProcInstID;
				condition.ValueType = typeof(int).GetTypeName();
				list.Add(condition);
			}
			if (InitiatorID != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "InitiatorID";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = InitiatorID;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (InitiatorName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "InitiatorName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = InitiatorName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RequestUrl != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RequestUrl";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RequestUrl;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateBy != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateBy";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = CreateBy;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CreateTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (UpdateBy != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateBy";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = UpdateBy;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (UpdateTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "UpdateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = UpdateTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (CompleteTime != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CompleteTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CompleteTime;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (FormFields != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "FormFields";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = FormFields;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BACode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BACode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BACode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BAName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BAName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BAName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BLCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BLCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BLCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (BLName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "BLName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = BLName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (FunctionRegionCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "FunctionRegionCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = FunctionRegionCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (FunctionRegionName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "FunctionRegionName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = FunctionRegionName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (DriverLicenseCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "DriverLicenseCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = DriverLicenseCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (DriverLicenseType != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "DriverLicenseType";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = DriverLicenseType;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (DriverLicenseStartDate != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "DriverLicenseStartDate";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = DriverLicenseStartDate;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (DriverLicenseEndDate != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "DriverLicenseEndDate";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = DriverLicenseEndDate;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (VehicleLicenseCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "VehicleLicenseCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = VehicleLicenseCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CompulsoryInsuranceStartDate != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CompulsoryInsuranceStartDate";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CompulsoryInsuranceStartDate;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (CompulsoryInsuranceEndDate != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CompulsoryInsuranceEndDate";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CompulsoryInsuranceEndDate;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (YearlyInspectionDate != default(Nullable<System.DateTime>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "YearlyInspectionDate";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = YearlyInspectionDate;
				condition.ValueType = typeof(Nullable<System.DateTime>).GetTypeName();
				list.Add(condition);
			}
			if (RentingTypeCode != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RentingTypeCode";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RentingTypeCode;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RentingTypeName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RentingTypeName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RentingTypeName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (HasDriver != default(Nullable<bool>))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "HasDriver";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = HasDriver;
				condition.ValueType = typeof(Nullable<bool>).GetTypeName();
				list.Add(condition);
			}
			if (DriverName != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "DriverName";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = DriverName;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (RentingCompany != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "RentingCompany";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = RentingCompany;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (ActualUser != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ActualUser";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = ActualUser;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
