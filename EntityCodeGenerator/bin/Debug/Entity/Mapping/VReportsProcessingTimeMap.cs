using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class VReportsProcessingTimeMap : EntityTypeConfiguration<VReportsProcessingTime>
    {
        public VReportsProcessingTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestTypeName);

            // Properties
            this.Property(t => t.RequestNo)
                .HasMaxLength(200);

            this.Property(t => t.BACode)
                .HasMaxLength(200);

            this.Property(t => t.BAName)
                .HasMaxLength(200);

            this.Property(t => t.BLCode)
                .HasMaxLength(200);

            this.Property(t => t.BLName)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeName)
                .HasMaxLength(200);

            this.Property(t => t.RequestTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RequestTypeName)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.InitiatorName)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorID)
                .HasMaxLength(200);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            this.Property(t => t.ActivityName)
                .HasMaxLength(50);

            this.Property(t => t.Action)
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("V_Reports_ProcessingTime");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BAName).HasColumnName("BAName");
            this.Property(t => t.BLCode).HasColumnName("BLCode");
            this.Property(t => t.BLName).HasColumnName("BLName");
            this.Property(t => t.RequestSubTypeCode).HasColumnName("RequestSubTypeCode");
            this.Property(t => t.RequestSubTypeName).HasColumnName("RequestSubTypeName");
            this.Property(t => t.RequestTypeCode).HasColumnName("RequestTypeCode");
            this.Property(t => t.RequestTypeName).HasColumnName("RequestTypeName");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Department).HasColumnName("Department");
        }
    }
}
