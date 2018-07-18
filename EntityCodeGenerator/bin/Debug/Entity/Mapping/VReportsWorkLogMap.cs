using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class VReportsWorkLogMap : EntityTypeConfiguration<VReportsWorkLog>
    {
        public VReportsWorkLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IsHCO, t.IsAfterFact });

            // Properties
            this.Property(t => t.Approver)
                .HasMaxLength(50);

            this.Property(t => t.RequestNo)
                .HasMaxLength(200);

            this.Property(t => t.BACode)
                .HasMaxLength(200);

            this.Property(t => t.BAName)
                .HasMaxLength(200);

            this.Property(t => t.BLName)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorID)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorName)
                .HasMaxLength(200);

            this.Property(t => t.OwnerID)
                .HasMaxLength(200);

            this.Property(t => t.OwnerName)
                .HasMaxLength(200);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            this.Property(t => t.IsHCO)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.EventLocationName)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeName)
                .HasMaxLength(200);

            this.Property(t => t.IsAfterFact)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_Reports_WorkLog");
            this.Property(t => t.Approver).HasColumnName("Approver");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.IsHaveContract).HasColumnName("IsHaveContract");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BAName).HasColumnName("BAName");
            this.Property(t => t.BLName).HasColumnName("BLName");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.IsHCO).HasColumnName("IsHCO");
            this.Property(t => t.EventLocationName).HasColumnName("EventLocationName");
            this.Property(t => t.RequestSubTypeCode).HasColumnName("RequestSubTypeCode");
            this.Property(t => t.RequestSubTypeName).HasColumnName("RequestSubTypeName");
            this.Property(t => t.BudgetAmount).HasColumnName("BudgetAmount");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.IsAfterFact).HasColumnName("IsAfterFact");
            this.Property(t => t.SubmitTime).HasColumnName("SubmitTime");
            this.Property(t => t.Action).HasColumnName("Action");
        }
    }
}
