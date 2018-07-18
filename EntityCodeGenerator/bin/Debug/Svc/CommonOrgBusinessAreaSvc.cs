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
    [ServiceObject("CommonOrgBusinessAreaSvc", "CommonOrgBusinessAreaSvc", "CommonOrgBusinessAreaSvc")]
    public partial class CommonOrgBusinessAreaSvc
    {
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }
		[Property("BANameCN", SoType.Text, "BANameCN", "BANameCN")]
        public string BANameCN { get; set; }
		[Property("BANameEN", SoType.Text, "BANameEN", "BANameEN")]
        public string BANameEN { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public bool IsActive { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }
       
    }

    public partial class CommonOrgBusinessAreaSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonOrgBusinessAreaSvc()
        { }

        public static CommonOrgBusinessAreaSvc GetFromEntity(CommonOrgBusinessArea entity)
        {
            CommonOrgBusinessAreaSvc svc = new CommonOrgBusinessAreaSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgBusinessArea entity)
        {
            			this.BACode = entity.BACode;
			this.BANameCN = entity.BANameCN;
			this.BANameEN = entity.BANameEN;
			this.IsActive = entity.IsActive;
			this.OrderId = entity.OrderId;
		}

        private CommonOrgBusinessArea ConvertToEntity()
        {
            var entity = new CommonOrgBusinessArea();
            			entity.BACode = this.BACode;
			entity.BANameCN = this.BANameCN;
			entity.BANameEN = this.BANameEN;
			entity.IsActive = this.IsActive;
			entity.OrderId = this.OrderId;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "BACode" },
            new string[] { "BACode","BANameCN","BANameEN","IsActive","OrderId"})]
        public CommonOrgBusinessAreaSvc Read()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var model = service.Read(BACode);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "BACode","BANameCN","BANameEN","IsActive","OrderId" },
            new string[] { "BACode"})]
        public CommonOrgBusinessAreaSvc Create()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var entity = ConvertToEntity();
            BACode = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "BACode","BANameCN","BANameEN","IsActive","OrderId" },
            new string[] { })]
        public void Update()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "BACode" },
            new string[] { })]
        public void Delete()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            service.Delete(BACode);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "BACode","BANameCN","BANameEN","IsActive","OrderId" },
            new string[] { "BACode","BANameCN","BANameEN","IsActive","OrderId" })]
        public List<CommonOrgBusinessAreaSvc> List()
        {
            CommonOrgBusinessAreaService service = new CommonOrgBusinessAreaService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}