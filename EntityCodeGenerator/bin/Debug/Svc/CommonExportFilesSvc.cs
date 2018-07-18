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
    [ServiceObject("CommonExportFilesSvc", "CommonExportFilesSvc", "CommonExportFilesSvc")]
    public partial class CommonExportFilesSvc
    {
		[Property("ID", SoType.Number, "ID", "ID")]
        public int ID { get; set; }
		[Property("File", SoType.Text, "File", "File")]
        public string File { get; set; }
		[Property("CreateTime", SoType.DateTime, "CreateTime", "CreateTime")]
        public Nullable<System.DateTime> CreateTime { get; set; }
       
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
            			this.ID = entity.ID;
			this.File = entity.File;
			this.CreateTime = entity.CreateTime;
		}

        private CommonExportFiles ConvertToEntity()
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
            CommonExportFilesService service = new CommonExportFilesService(ConnString);
            var list = service.List();
            var result = list.Select(m => GetFromEntity(m)).ToList();
            return result;
        }
    }
}