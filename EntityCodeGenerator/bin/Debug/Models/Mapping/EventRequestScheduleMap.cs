using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class EventRequestScheduleMap : EntityTypeConfiguration<EventRequestSchedule>
    {
        public EventRequestScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.Guid);

            // Properties
            this.Property(t => t.Guid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestGuid)
                .HasMaxLength(50);

            this.Property(t => t.PlannedTopic)
                .HasMaxLength(200);

            this.Property(t => t.PlannedSpeaker)
                .HasMaxLength(200);

            this.Property(t => t.PlannedChairman)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Event_Request_Schedule");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.PlannedDate).HasColumnName("PlannedDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.PlannedTopic).HasColumnName("PlannedTopic");
            this.Property(t => t.PlannedSpeaker).HasColumnName("PlannedSpeaker");
            this.Property(t => t.PlannedChairman).HasColumnName("PlannedChairman");
            this.Property(t => t.HasOffLabel).HasColumnName("HasOffLabel");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
        }
    }
}
