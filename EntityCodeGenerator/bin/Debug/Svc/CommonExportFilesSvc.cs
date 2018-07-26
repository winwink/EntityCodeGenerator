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
    [ServiceObject("CommonExportFilesSvc", "CommonExportFilesSvc", "CommonExportFilesSvc")]
    public partial class CommonExportFilesSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }

		[Property("File", SoType.Text, "File", "File")]
        public string File { get; set; }

		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public System.DateTime CreateTime { get; set; }

       
    }

    public partial class CommonExportFilesSvc
    {
        public ServiceConfiguration ServiceConfiguration { get; set; }

        public string ConnString
        {
            get
            {
                return ServiceConfiguration[ServiceBroker.DB_CONNECTION_STR_KEY].ToString();
            }
        }

        public CommonExportFilesSvc()
        { }

        public static CommonExportFilesSvc GetFromEntity(CommonExportFiles entity)
        {
            CommonExportFilesSvc svc = new CommonExportFilesSvc();
            svc.ParseFromEntity(entity);
            return svc;
        }

        public void ParseFromEntity(CommonExportFiles entity)
        {
			if (entity == null) return;

			this.ID = entity.ID;
			this.File = entity.File;
			this.CreateTime = entity.CreateTime;
		}

        public CommonExportFiles ConvertToEntity()
        {
            var entity = new CommonExportFiles();
			entity.ID = this.ID;
			entity.File = this.File;
			entity.CreateTime = this.CreateTime;
            return entity;
        }

        [Method("Read", MethodType.Read, "Read", "Read",
            new string[] { },
            new string[] { "ID" },
            new string[] { "ID","File","CreateTime"})]
        public CommonExportFilesSvc Read()
        {
            CommonExportFilesService service = new CommonExportFilesService(ConnString);
            var model = service.Read(ID);
			if (model == null)
            {
                return null;
            }

            ParseFromEntity(model);
            return this;
        }

        [Method("Create", MethodType.Create, "Create", "Create",
            new string[] { },
            new string[] { "ID","File","CreateTime" },
            new string[] { "ID"})]
        public CommonExportFilesSvc Create()
        {
            CommonExportFilesService service = new CommonExportFilesService(ConnString);
            var entity = ConvertToEntity();
            ID = service.Create(entity);

            return this;
        }

        [Method("Update", MethodType.Update, "Update", "Update",
            new string[] { },
            new string[] { "ID","File","CreateTime" },
            new string[] { })]
        public void Update()
        {
            CommonExportFilesService service = new CommonExportFilesService(ConnString);
            var entity = ConvertToEntity();
            service.Update(entity);
        }

        [Method("Delete", MethodType.Delete, "Delete", "Delete",
            new string[] { },
            new string[] { "ID" },
            new string[] { })]
        public void Delete()
        {
            CommonExportFilesService service = new CommonExportFilesService(ConnString);
            service.Delete(ID);
        }

        [Method("List", MethodType.List, "List", "List",
            new string[] { },
            new string[] { "ID","File","CreateTime" },
            new string[] { "ID","File","CreateTime" })]
        public List<CommonExportFilesSvc> List()
        {
			var conditions = BuildConditions();
            List<CommonExportFiles> entityList = new List<CommonExportFiles>();
			QueryDescriptor descriptor = new QueryDescriptor() { Conditions = conditions };
            using (RDCN_CSWF_DataContext db = new RDCN_CSWF_DataContext(ConnString))
            {
                entityList = db.CommonExportFiles.Query(descriptor).ToList() ;
            }

            var result = entityList.Select(m => GetFromEntity(m)).ToList();
            return result;
        }

		private List<QueryCondition> BuildConditions()
        {
            List<QueryCondition> list = new List<QueryCondition>();
			if (ID != default(int))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "ID";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = ID;
				condition.ValueType = typeof(int).GetTypeName();
				list.Add(condition);
			}
			if (File != default(string))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "File";
				condition.Operator = QueryOperator.CONTAINS;
				condition.Value = File;
				condition.ValueType = typeof(string).GetTypeName();
				list.Add(condition);
			}
			if (CreateTime != default(System.DateTime))
			{
				QueryCondition condition = new QueryCondition();
				condition.Key = "CreateTime";
				condition.Operator = QueryOperator.EQUAL;
				condition.Value = CreateTime;
				condition.ValueType = typeof(System.DateTime).GetTypeName();
				list.Add(condition);
			}
            return list;
        }
    }
}
