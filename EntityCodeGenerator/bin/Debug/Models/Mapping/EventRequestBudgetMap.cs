using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class EventRequestBudgetMap : EntityTypeConfiguration<EventRequestBudget>
    {
        public EventRequestBudgetMap()
        {
            // Primary Key
            this.HasKey(t => t.Guid);

            // Properties
            this.Property(t => t.Guid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestGuid)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Event_Request_Budget");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParticipantNumber).HasColumnName("ParticipantNumber");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.SinglePrice).HasColumnName("SinglePrice");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
