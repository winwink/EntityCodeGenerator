using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class VReportsHCOBudgetMap : EntityTypeConfiguration<VReportsHCOBudget>
    {
        public VReportsHCOBudgetMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestGuid);

            // Properties
            this.Property(t => t.RequestGuid)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RequestNo)
                .HasMaxLength(200);

            this.Property(t => t.BA)
                .HasMaxLength(200);

            this.Property(t => t.BL)
                .HasMaxLength(200);

            this.Property(t => t.Function)
                .HasMaxLength(200);

            this.Property(t => t.Region)
                .HasMaxLength(200);

            this.Property(t => t.InstitutionCode)
                .HasMaxLength(50);

            this.Property(t => t.InstitutionName)
                .HasMaxLength(200);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            this.Property(t => t.RequestDescription)
                .HasMaxLength(4000);

            this.Property(t => t.RequestSubTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubTypeName)
                .HasMaxLength(200);

            this.Property(t => t.State)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("V_Reports_HCOBudget");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.BA).HasColumnName("BA");
            this.Property(t => t.BL).HasColumnName("BL");
            this.Property(t => t.Function).HasColumnName("Function");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.InstitutionCode).HasColumnName("InstitutionCode");
            this.Property(t => t.InstitutionName).HasColumnName("InstitutionName");
            this.Property(t => t.BudgetAmount).HasColumnName("BudgetAmount");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.RequestDescription).HasColumnName("RequestDescription");
            this.Property(t => t.RequestSubTypeCode).HasColumnName("RequestSubTypeCode");
            this.Property(t => t.RequestSubTypeName).HasColumnName("RequestSubTypeName");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
            this.Property(t => t.CompletedTime).HasColumnName("CompletedTime");
        }
    }
}
