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
    [ServiceObject("CommonOrgFunctionRegionSvc", "CommonOrgFunctionRegionSvc", "CommonOrgFunctionRegionSvc")]
    public partial class CommonOrgFunctionRegionSvc
    {
		[Property("FunctionRegionCode", SoType.Text, "FunctionRegionCode", "FunctionRegionCode")]
        public string FunctionRegionCode { get; set; }
		[Property("FunctionRegionNameCN", SoType.Text, "FunctionRegionNameCN", "FunctionRegionNameCN")]
        public string FunctionRegionNameCN { get; set; }
		[Property("FunctionRegionNameEN", SoType.Text, "FunctionRegionNameEN", "FunctionRegionNameEN")]
        public string FunctionRegionNameEN { get; set; }
		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public bool IsActive { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }
       
    }

    public partial class CommonOrgFunctionRegionSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonOrgFunctionRegionSvc()
        { }

        public static CommonOrgFunctionRegionSvc GetFromEntity(CommonOrgFunctionRegion entity)
        {
            CommonOrgFunctionRegionSvc svc = new CommonOrgFunctionRegionSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgFunctionRegion entity)
        {
            			this.FunctionRegionCode = entity.FunctionRegionCode;
			this.FunctionRegionNameCN = entity.FunctionRegionNameCN;
			this.FunctionRegionNameEN = entity.FunctionRegionNameEN;
			this.BLCode = entity.BLCode;
			this.IsActive = entity.IsActive;
			this.OrderId = entity.OrderId;
		}

        private CommonOrgFunctionRegion ConvertToEntity()
        {
            var entity = new CommonOrgFunctionRegion();
            			entity.FunctionRegionCode = this.FunctionRegionCode;
			entity.FunctionRegionNameCN = this.FunctionRegionNameCN;
			entity.FunctionRegionNameEN = this.FunctionRegionNameEN;
			entity.BLCode = this.BLCode;
			entity.IsActive = this.IsActive;
			entity.OrderId = this.OrderId;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "FunctionRegionCode" },
            new string[] { "FunctionRegionCode","FunctionRegionNameCN","FunctionRegionNameEN","BLCode","IsActive","OrderId"})]
        public CommonOrgFunctionRegionSvc Read()
        {
            CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
            var model = service.Read(FunctionRegionCode);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "FunctionRegionCode","FunctionRegionNameCN","FunctionRegionNameEN","BLCode","IsActive","OrderId" },
            new string[] { "FunctionRegionCode"})]
        public CommonOrgFunctionRegionSvc Create()
        {
            CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
            var entity = ConvertToEntity();
            FunctionRegionCode = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "FunctionRegionCode","FunctionRegionNameCN","FunctionRegionNameEN","BLCode","IsActive","OrderId" },
            new string[] { })]
        public void Update()
        {
            CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "FunctionRegionCode" },
            new string[] { })]
        public void Delete()
        {
            CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
            service.Delete(FunctionRegionCode);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "FunctionRegionCode","FunctionRegionNameCN","FunctionRegionNameEN","BLCode","IsActive","OrderId" },
            new string[] { "FunctionRegionCode","FunctionRegionNameCN","FunctionRegionNameEN","BLCode","IsActive","OrderId" })]
        public List<CommonOrgFunctionRegionSvc> List()
        {
            CommonOrgFunctionRegionService service = new CommonOrgFunctionRegionService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}