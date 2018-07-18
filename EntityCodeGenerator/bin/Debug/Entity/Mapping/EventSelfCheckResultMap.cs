using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class EventSelfCheckResultMap : EntityTypeConfiguration<EventSelfCheckResult>
    {
        public EventSelfCheckResultMap()
        {
            // Primary Key
            this.HasKey(t => t.SelfCheckID);

            // Properties
            this.Property(t => t.RequestGuid)
                .HasMaxLength(200);

            this.Property(t => t.CheckContent)
                .HasMaxLength(2000);

            this.Property(t => t.CheckResult)
                .HasMaxLength(200);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.OwnerID)
                .HasMaxLength(200);

            this.Property(t => t.OwnerName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Event_SelfCheckResult");
            this.Property(t => t.SelfCheckID).HasColumnName("SelfCheckID");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CheckContent).HasColumnName("CheckContent");
            this.Property(t => t.CheckResult).HasColumnName("CheckResult");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
