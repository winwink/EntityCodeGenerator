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
    [ServiceObject("CommonDictionarySvc", "CommonDictionarySvc", "CommonDictionarySvc")]
    public partial class CommonDictionarySvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }
		[Property("Type", SoType.Text, "Type", "Type")]
        public string Type { get; set; }
		[Property("SubType", SoType.Text, "SubType", "SubType")]
        public string SubType { get; set; }
		[Property("SubSubType", SoType.Text, "SubSubType", "SubSubType")]
        public string SubSubType { get; set; }
		[Property("Code", SoType.Text, "Code", "Code")]
        public string Code { get; set; }
		[Property("Value", SoType.Text, "Value", "Value")]
        public string Value { get; set; }
		[Property("IsActive", SoType.YesNo, "IsActive", "IsActive")]
        public Nullable<bool> IsActive { get; set; }
		[Property("OrderId", SoType.Number, "OrderId", "OrderId")]
        public Nullable<int> OrderId { get; set; }
       
    }

    public partial class CommonDictionarySvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonDictionarySvc()
        { }

        public static CommonDictionarySvc GetFromEntity(CommonDictionary entity)
        {
            CommonDictionarySvc svc = new CommonDictionarySvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonDictionary entity)
        {
            			this.ID = entity.ID;
			this.Type = entity.Type;
			this.SubType = entity.SubType;
			this.SubSubType = entity.SubSubType;
			this.Code = entity.Code;
			this.Value = entity.Value;
			this.IsActive = entity.IsActive;
			this.OrderId = entity.OrderId;
		}

        private CommonDictionary ConvertToEntity()
        {
            var entity = new CommonDictionary();
            			entity.ID = this.ID;
			entity.Type = this.Type;
			entity.SubType = this.SubType;
			entity.SubSubType = this.SubSubType;
			entity.Code = this.Code;
			entity.Value = this.Value;
			entity.IsActive = this.IsActive;
			entity.OrderId = this.OrderId;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","Type","SubType","SubSubType","Code","Value","IsActive","OrderId"})]
        public CommonDictionarySvc Read()
        {
            CommonDictionaryService service = new CommonDictionaryService(ConnString);
            var model = service.Read(ID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","Type","SubType","SubSubType","Code","Value","IsActive","OrderId" },
            new string[] { "ID"})]
        public CommonDictionarySvc Create()
        {
            CommonDictionaryService service = new CommonDictionaryService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","Type","SubType","SubSubType","Code","Value","IsActive","OrderId" },
            new string[] { })]
        public void Update()
        {
            CommonDictionaryService service = new CommonDictionaryService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonDictionaryService service = new CommonDictionaryService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","Type","SubType","SubSubType","Code","Value","IsActive","OrderId" },
            new string[] { "ID","Type","SubType","SubSubType","Code","Value","IsActive","OrderId" })]
        public List<CommonDictionarySvc> List()
        {
            CommonDictionaryService service = new CommonDictionaryService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}