using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class EventMatchResultMap : EntityTypeConfiguration<EventMatchResult>
    {
        public EventMatchResultMap()
        {
            // Primary Key
            this.HasKey(t => t.MatchResultID);

            // Properties
            this.Property(t => t.MatchResultID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RequestGuid)
                .HasMaxLength(200);

            this.Property(t => t.EventID)
                .HasMaxLength(200);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            this.Property(t => t.EventLocation)
                .HasMaxLength(200);

            this.Property(t => t.EventProvince)
                .HasMaxLength(200);

            this.Property(t => t.EventCity)
                .HasMaxLength(200);

            this.Property(t => t.EventOtherLocation)
                .HasMaxLength(500);

            this.Property(t => t.EventSummary)
                .HasMaxLength(500);

            this.Property(t => t.EventFirstRequestGuid)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Event_MatchResult");
            this.Property(t => t.MatchResultID).HasColumnName("MatchResultID");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
            this.Property(t => t.EventLocation).HasColumnName("EventLocation");
            this.Property(t => t.EventProvince).HasColumnName("EventProvince");
            this.Property(t => t.EventCity).HasColumnName("EventCity");
            this.Property(t => t.EventOtherLocation).HasColumnName("EventOtherLocation");
            this.Property(t => t.IsSelected).HasColumnName("IsSelected");
            this.Property(t => t.EventSummary).HasColumnName("EventSummary");
            this.Property(t => t.EventFirstRequestGuid).HasColumnName("EventFirstRequestGuid");
        }
    }
}
