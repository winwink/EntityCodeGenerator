using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RDCN.CPT.Data.Entity.Mapping;

namespace RDCN.CPT.Data.Entity
{
    public partial class RDCN_CPT_SMF_DataContext : DbContext
    {
        static RDCN_CPT_SMF_DataContext()
        {
            Database.SetInitializer<RDCN_CPT_SMF_DataContext>(null);
        }

        public RDCN_CPT_SMF_DataContext()
            : base("Name=RDCN_CPT_SMF_DataContext")
        {
        }

		public RDCN_CPT_SMF_DataContext(string connectionString):base(connectionString)
        {
		}

        public DbSet<CommonAttachments> CommonAttachments { get; set; }
        public DbSet<CommonAttachmentsConfig> CommonAttachmentsConfig { get; set; }
        public DbSet<CommonConfig> CommonConfig { get; set; }
        public DbSet<CommonConfigSendMail> CommonConfigSendMail { get; set; }
        public DbSet<CommonDictionary> CommonDictionary { get; set; }
        public DbSet<CommonExportFiles> CommonExportFiles { get; set; }
        public DbSet<CommonInitiatorConfig> CommonInitiatorConfig { get; set; }
        public DbSet<CommonLog> CommonLog { get; set; }
        public DbSet<CommonOrgBusinessArea> CommonOrgBusinessArea { get; set; }
        public DbSet<CommonOrgBusinessLine> CommonOrgBusinessLine { get; set; }
        public DbSet<CommonOrgFunctionRegion> CommonOrgFunctionRegion { get; set; }
        public DbSet<ContractRequest> ContractRequest { get; set; }
        public DbSet<EventList> EventList { get; set; }
        public DbSet<EventMatchResult> EventMatchResult { get; set; }
        public DbSet<EventRequest> EventRequest { get; set; }
        public DbSet<EventRequestBudget> EventRequestBudget { get; set; }
        public DbSet<EventRequestSchedule> EventRequestSchedule { get; set; }
        public DbSet<EventSelfCheckResult> EventSelfCheckResult { get; set; }
        public DbSet<RequestCarFleet> RequestCarFleet { get; set; }
        public DbSet<VReportsHCOBudget> VReportsHCOBudget { get; set; }
        public DbSet<VReportsProcessingTime> VReportsProcessingTime { get; set; }
        public DbSet<VReportsRequestDetailsWithStep> VReportsRequestDetailsWithStep { get; set; }
        public DbSet<VReportsWorkLog> VReportsWorkLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CommonAttachmentsMap());
            modelBuilder.Configurations.Add(new CommonAttachmentsConfigMap());
            modelBuilder.Configurations.Add(new CommonConfigMap());
            modelBuilder.Configurations.Add(new CommonConfigSendMailMap());
            modelBuilder.Configurations.Add(new CommonDictionaryMap());
            modelBuilder.Configurations.Add(new CommonExportFilesMap());
            modelBuilder.Configurations.Add(new CommonInitiatorConfigMap());
            modelBuilder.Configurations.Add(new CommonLogMap());
            modelBuilder.Configurations.Add(new CommonOrgBusinessAreaMap());
            modelBuilder.Configurations.Add(new CommonOrgBusinessLineMap());
            modelBuilder.Configurations.Add(new CommonOrgFunctionRegionMap());
            modelBuilder.Configurations.Add(new ContractRequestMap());
            modelBuilder.Configurations.Add(new EventListMap());
            modelBuilder.Configurations.Add(new EventMatchResultMap());
            modelBuilder.Configurations.Add(new EventRequestMap());
            modelBuilder.Configurations.Add(new EventRequestBudgetMap());
            modelBuilder.Configurations.Add(new EventRequestScheduleMap());
            modelBuilder.Configurations.Add(new EventSelfCheckResultMap());
            modelBuilder.Configurations.Add(new RequestCarFleetMap());
            modelBuilder.Configurations.Add(new VReportsHCOBudgetMap());
            modelBuilder.Configurations.Add(new VReportsProcessingTimeMap());
            modelBuilder.Configurations.Add(new VReportsRequestDetailsWithStepMap());
            modelBuilder.Configurations.Add(new VReportsWorkLogMap());
        }
    }
}
