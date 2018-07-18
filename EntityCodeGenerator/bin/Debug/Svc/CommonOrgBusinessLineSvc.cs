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
    [ServiceObject("CommonOrgBusinessLineSvc", "CommonOrgBusinessLineSvc", "CommonOrgBusinessLineSvc")]
    public partial class CommonOrgBusinessLineSvc
    {
		[Property("BLCode", SoType.Text, "BLCode", "BLCode")]
        public string BLCode { get; set; }
		[Property("BACode", SoType.Text, "BACode", "BACode")]
        public string BACode { get; set; }
		[Property("BLNameCN", SoType.Text, "BLNameCN", "BLNameCN")]
        public string BLNameCN { get; set; }
		[Property("BLNameEN", SoType.Text, "BLNameEN", "BLNameEN")]
        public string BLNameEN { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public bool IsActive { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public int OrderId { get; set; }
       
    }

    public partial class CommonOrgBusinessLineSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonOrgBusinessLineSvc()
        { }

        public static CommonOrgBusinessLineSvc GetFromEntity(CommonOrgBusinessLine entity)
        {
            CommonOrgBusinessLineSvc svc = new CommonOrgBusinessLineSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonOrgBusinessLine entity)
        {
            			this.BLCode = entity.BLCode;
			this.BACode = entity.BACode;
			this.BLNameCN = entity.BLNameCN;
			this.BLNameEN = entity.BLNameEN;
			this.IsActive = entity.IsActive;
			this.OrderId = entity.OrderId;
		}

        private CommonOrgBusinessLine ConvertToEntity()
        {
            var entity = new CommonOrgBusinessLine();
            			entity.BLCode = this.BLCode;
			entity.BACode = this.BACode;
			entity.BLNameCN = this.BLNameCN;
			entity.BLNameEN = this.BLNameEN;
			entity.IsActive = this.IsActive;
			entity.OrderId = this.OrderId;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "BLCode" },
            new string[] { "BLCode","BACode","BLNameCN","BLNameEN","IsActive","OrderId"})]
        public CommonOrgBusinessLineSvc Read()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var model = service.Read(BLCode);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "BLCode","BACode","BLNameCN","BLNameEN","IsActive","OrderId" },
            new string[] { "BLCode"})]
        public CommonOrgBusinessLineSvc Create()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var entity = ConvertToEntity();
            BLCode = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "BLCode","BACode","BLNameCN","BLNameEN","IsActive","OrderId" },
            new string[] { })]
        public void Update()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "BLCode" },
            new string[] { })]
        public void Delete()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            service.Delete(BLCode);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "BLCode","BACode","BLNameCN","BLNameEN","IsActive","OrderId" },
            new string[] { "BLCode","BACode","BLNameCN","BLNameEN","IsActive","OrderId" })]
        public List<CommonOrgBusinessLineSvc> List()
        {
            CommonOrgBusinessLineService service = new CommonOrgBusinessLineService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}