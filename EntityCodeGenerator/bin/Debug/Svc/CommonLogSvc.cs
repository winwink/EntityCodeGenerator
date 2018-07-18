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
    [ServiceObject("CommonLogSvc", "CommonLogSvc", "CommonLogSvc")]
    public partial class CommonLogSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }
		[Property("ActionUserAccount", SoType.Text, "ActionUserAccount", "ActionUserAccount")]
        public string ActionUserAccount { get; set; }
		[Property("ActionUserName", SoType.Text, "ActionUserName", "ActionUserName")]
        public string ActionUserName { get; set; }
		[Property("Module", SoType.Text, "Module", "Module")]
        public string Module { get; set; }
		[Property("Action", SoType.Text, "Action", "Action")]
        public string Action { get; set; }
		[Property("ActionTime", SoType.DateTime, "ActionTime", "ActionTime")]
        public Nullable<System.DateTime> ActionTime { get; set; }
		[Property("OldValue", SoType.Text, "OldValue", "OldValue")]
        public string OldValue { get; set; }
		[Property("NewValue", SoType.Text, "NewValue", "NewValue")]
        public string NewValue { get; set; }
		[Property("Comments", SoType.Text, "Comments", "Comments")]
        public string Comments { get; set; }
       
    }

    public partial class CommonLogSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonLogSvc()
        { }

        public static CommonLogSvc GetFromEntity(CommonLog entity)
        {
            CommonLogSvc svc = new CommonLogSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonLog entity)
        {
            			this.ID = entity.ID;
			this.ActionUserAccount = entity.ActionUserAccount;
			this.ActionUserName = entity.ActionUserName;
			this.Module = entity.Module;
			this.Action = entity.Action;
			this.ActionTime = entity.ActionTime;
			this.OldValue = entity.OldValue;
			this.NewValue = entity.NewValue;
			this.Comments = entity.Comments;
		}

        private CommonLog ConvertToEntity()
        {
            var entity = new CommonLog();
            			entity.ID = this.ID;
			entity.ActionUserAccount = this.ActionUserAccount;
			entity.ActionUserName = this.ActionUserName;
			entity.Module = this.Module;
			entity.Action = this.Action;
			entity.ActionTime = this.ActionTime;
			entity.OldValue = this.OldValue;
			entity.NewValue = this.NewValue;
			entity.Comments = this.Comments;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","ActionUserAccount","ActionUserName","Module","Action","ActionTime","OldValue","NewValue","Comments"})]
        public CommonLogSvc Read()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var model = service.Read(ID);
            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","ActionUserAccount","ActionUserName","Module","Action","ActionTime","OldValue","NewValue","Comments" },
            new string[] { "ID"})]
        public CommonLogSvc Create()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","ActionUserAccount","ActionUserName","Module","Action","ActionTime","OldValue","NewValue","Comments" },
            new string[] { })]
        public void Update()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonLogService service = new CommonLogService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","ActionUserAccount","ActionUserName","Module","Action","ActionTime","OldValue","NewValue","Comments" },
            new string[] { "ID","ActionUserAccount","ActionUserName","Module","Action","ActionTime","OldValue","NewValue","Comments" })]
        public List<CommonLogSvc> List()
        {
            CommonLogService service = new CommonLogService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}