using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SourceCode.SmartObjects.Services.ServiceSDK.Attributes;
using SourceCode.SmartObjects.Services.ServiceSDK.Objects;
using SourceCode.SmartObjects.Services.ServiceSDK.Types;
using RDCN.CPT.Data.Entity;
using RDCN.CPT.Data.Services;


namespace RDCN.CPT.Data.Svc
{
    [ServiceObject("ContractRequestSvc", "ContractRequestSvc", "ContractRequestSvc")]
    public partial class ContractRequestSvc
    {
		[Property("ContractGuid", SoType.Text, "ContractGuid", "ContractGuid")]
        public string ContractGuid { get; set; }
		[Property("ContractNo", SoType.Text, "ContractNo", "ContractNo")]
        public string ContractNo { get; set; }
		[Property("RequestGuid", SoType.Text, "RequestGuid", "RequestGuid")]
        public string RequestGuid { get; set; }
		[Property("RequestNo", SoType.Text, "RequestNo", "RequestNo")]
        public string RequestNo { get; set; }
		[Property("RequestUrl", SoType.Text, "RequestUrl", "RequestUrl")]
        public string RequestUrl { get; set; }
		[Property("IsSameContent", SoType.Text, "IsSameContent", "IsSameContent")]
        public string IsSameContent { get; set; }
		[Property("IsSameContentText", SoType.Text, "IsSameContentText", "IsSameContentText")]
        public string IsSameContentText { get; set; }
		[Property("IsStandardContract", SoType.Text, "IsStandardContract", "IsStandardContract")]
        public string IsStandardContract { get; set; }
		[Property("IsStandardContractText", SoType.Text, "IsStandardContractText", "IsStandardContractText")]
        public string IsStandardContractText { get; set; }
		[Property("IsStandardCompliance", SoType.Text, "IsStandardCompliance", "IsStandardCompliance")]
        public string IsStandardCompliance { get; set; }
		[Property("IsStandardComplianceText", SoType.Text, "IsStandardComplianceText", "IsStandardComplianceText")]
        public string IsStandardComplianceText { get; set; }
		[Property("IsBigChange", SoType.Text, "IsBigChange", "IsBigChange")]
        public string IsBigChange { get; set; }
		[Property("IsBigChangeText", SoType.Text, "IsBigChangeText", "IsBigChangeText")]
        public string IsBigChangeText { get; set; }
		[Property("IsInvoiceAfterDays", SoType.Text, "IsInvoiceAfterDays", "IsInvoiceAfterDays")]
        public string IsInvoiceAfterDays { get; set; }
		[Property("IsInvoiceAfterDaysText", SoType.Text, "IsInvoiceAfterDaysText", "IsInvoiceAfterDaysText")]
        public string IsInvoiceAfterDaysText { get; set; }
		[Property("ContractUrl", SoType.Text, "ContractUrl", "ContractUrl")]
        public string ContractUrl { get; set; }
		[Property("State", SoType.Text, "State", "State")]
        public string State { get; set; }
		[Property("ProcInstID", SoType.Number, "ProcInstID", "ProcInstID")]
        public Nullable<int> ProcInstID { get; set; }
		[Property("InitiatorID", SoType.Text, "InitiatorID", "InitiatorID")]
        public string InitiatorID { get; set; }
		[Property("InitiatorName", SoType.Text, "InitiatorName", "InitiatorName")]
        public string InitiatorName { get; set; }
		[Property("OwnerID", SoType.Text, "OwnerID", "OwnerID")]
        public string OwnerID { get; set; }
		[Property("OwnerName", SoType.Text, "OwnerName", "OwnerName")]
        public string OwnerName { get; set; }
		[Property("FormFields", SoType.Text, "FormFields", "FormFields")]
        public string FormFields { get; set; }
		[Property("RequestFormFields", SoType.Text, "RequestFormFields", "RequestFormFields")]
        public string RequestFormFields { get; set; }
		[Property("ContractRequestDate", SoType.DateTime, "ContractRequestDate", "ContractRequestDate")]
        public Nullable<System.DateTime> ContractRequestDate { get; set; }
		[Property("IsXR2R", SoType.YesNo, "IsXR2R", "IsXR2R")]
        public Nullable<bool> IsXR2R { get; set; }
		[Property("PONo", SoType.Text, "PONo", "PONo")]
        public string PONo { get; set; }
       
    }

    public partial class ContractRequestSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public ContractRequestSvc()
        { }

        public static ContractRequestSvc GetFromEntity(ContractRequest entity)
        {
            ContractRequestSvc svc = new ContractRequestSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(ContractRequest entity)
        {
            			this.ContractGuid = entity.ContractGuid;
			this.ContractNo = entity.ContractNo;
			this.RequestGuid = entity.RequestGuid;
			this.RequestNo = entity.RequestNo;
			this.RequestUrl = entity.RequestUrl;
			this.IsSameContent = entity.IsSameContent;
			this.IsSameContentText = entity.IsSameContentText;
			this.IsStandardContract = entity.IsStandardContract;
			this.IsStandardContractText = entity.IsStandardContractText;
			this.IsStandardCompliance = entity.IsStandardCompliance;
			this.IsStandardComplianceText = entity.IsStandardComplianceText;
			this.IsBigChange = entity.IsBigChange;
			this.IsBigChangeText = entity.IsBigChangeText;
			this.IsInvoiceAfterDays = entity.IsInvoiceAfterDays;
			this.IsInvoiceAfterDaysText = entity.IsInvoiceAfterDaysText;
			this.ContractUrl = entity.ContractUrl;
			this.State = entity.State;
			this.ProcInstID = entity.ProcInstID;
			this.InitiatorID = entity.InitiatorID;
			this.InitiatorName = entity.InitiatorName;
			this.OwnerID = entity.OwnerID;
			this.OwnerName = entity.OwnerName;
			this.FormFields = entity.FormFields;
			this.RequestFormFields = entity.RequestFormFields;
			this.ContractRequestDate = entity.ContractRequestDate;
			this.IsXR2R = entity.IsXR2R;
			this.PONo = entity.PONo;
		}

        private ContractRequest ConvertToEntity()
        {
            var entity = new ContractRequest();
            			entity.ContractGuid = this.ContractGuid;
			entity.ContractNo = this.ContractNo;
			entity.RequestGuid = this.RequestGuid;
			entity.RequestNo = this.RequestNo;
			entity.RequestUrl = this.RequestUrl;
			entity.IsSameContent = this.IsSameContent;
			entity.IsSameContentText = this.IsSameContentText;
			entity.IsStandardContract = this.IsStandardContract;
			entity.IsStandardContractText = this.IsStandardContractText;
			entity.IsStandardCompliance = this.IsStandardCompliance;
			entity.IsStandardComplianceText = this.IsStandardComplianceText;
			entity.IsBigChange = this.IsBigChange;
			entity.IsBigChangeText = this.IsBigChangeText;
			entity.IsInvoiceAfterDays = this.IsInvoiceAfterDays;
			entity.IsInvoiceAfterDaysText = this.IsInvoiceAfterDaysText;
			entity.ContractUrl = this.ContractUrl;
			entity.State = this.State;
			entity.ProcInstID = this.ProcInstID;
			entity.InitiatorID = this.InitiatorID;
			entity.InitiatorName = this.InitiatorName;
			entity.OwnerID = this.OwnerID;
			entity.OwnerName = this.OwnerName;
			entity.FormFields = this.FormFields;
			entity.RequestFormFields = this.RequestFormFields;
			entity.ContractRequestDate = this.ContractRequestDate;
			entity.IsXR2R = this.IsXR2R;
			entity.PONo = this.PONo;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ContractGuid" },
            new string[] { "ContractGuid","ContractNo","RequestGuid","RequestNo","RequestUrl","IsSameContent","IsSameContentText","IsStandardContract","IsStandardContractText","IsStandardCompliance","IsStandardComplianceText","IsBigChange","IsBigChangeText","IsInvoiceAfterDays","IsInvoiceAfterDaysText","ContractUrl","State","ProcInstID","InitiatorID","InitiatorName","OwnerID","OwnerName","FormFields","RequestFormFields","ContractRequestDate","IsXR2R","PONo"})]
        public ContractRequestSvc Read()
        {
            ContractRequestService service = new ContractRequestService(ConnString);
            var model = service.Read(ContractGuid);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ContractGuid","ContractNo","RequestGuid","RequestNo","RequestUrl","IsSameContent","IsSameContentText","IsStandardContract","IsStandardContractText","IsStandardCompliance","IsStandardComplianceText","IsBigChange","IsBigChangeText","IsInvoiceAfterDays","IsInvoiceAfterDaysText","ContractUrl","State","ProcInstID","InitiatorID","InitiatorName","OwnerID","OwnerName","FormFields","RequestFormFields","ContractRequestDate","IsXR2R","PONo" },
            new string[] { "ContractGuid"})]
        public ContractRequestSvc Create()
        {
            ContractRequestService service = new ContractRequestService(ConnString);
            var entity = ConvertToEntity();
            ContractGuid = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ContractGuid","ContractNo","RequestGuid","RequestNo","RequestUrl","IsSameContent","IsSameContentText","IsStandardContract","IsStandardContractText","IsStandardCompliance","IsStandardComplianceText","IsBigChange","IsBigChangeText","IsInvoiceAfterDays","IsInvoiceAfterDaysText","ContractUrl","State","ProcInstID","InitiatorID","InitiatorName","OwnerID","OwnerName","FormFields","RequestFormFields","ContractRequestDate","IsXR2R","PONo" },
            new string[] { })]
        public void Update()
        {
            ContractRequestService service = new ContractRequestService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ContractGuid" },
            new string[] { })]
        public void Delete()
        {
            ContractRequestService service = new ContractRequestService(ConnString);
            service.Delete(ContractGuid);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ContractGuid","ContractNo","RequestGuid","RequestNo","RequestUrl","IsSameContent","IsSameContentText","IsStandardContract","IsStandardContractText","IsStandardCompliance","IsStandardComplianceText","IsBigChange","IsBigChangeText","IsInvoiceAfterDays","IsInvoiceAfterDaysText","ContractUrl","State","ProcInstID","InitiatorID","InitiatorName","OwnerID","OwnerName","FormFields","RequestFormFields","ContractRequestDate","IsXR2R","PONo" },
            new string[] { "ContractGuid","ContractNo","RequestGuid","RequestNo","RequestUrl","IsSameContent","IsSameContentText","IsStandardContract","IsStandardContractText","IsStandardCompliance","IsStandardComplianceText","IsBigChange","IsBigChangeText","IsInvoiceAfterDays","IsInvoiceAfterDaysText","ContractUrl","State","ProcInstID","InitiatorID","InitiatorName","OwnerID","OwnerName","FormFields","RequestFormFields","ContractRequestDate","IsXR2R","PONo" })]
        public List<ContractRequestSvc> List()
        {
            ContractRequestService service = new ContractRequestService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}