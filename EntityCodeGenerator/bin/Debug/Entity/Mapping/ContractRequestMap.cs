using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class ContractRequestMap : EntityTypeConfiguration<ContractRequest>
    {
        public ContractRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.ContractGuid);

            // Properties
            this.Property(t => t.ContractGuid)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ContractNo)
                .HasMaxLength(200);

            this.Property(t => t.RequestGuid)
                .HasMaxLength(200);

            this.Property(t => t.RequestNo)
                .HasMaxLength(200);

            this.Property(t => t.RequestUrl)
                .HasMaxLength(200);

            this.Property(t => t.IsSameContent)
                .HasMaxLength(200);

            this.Property(t => t.IsSameContentText)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardContract)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardContractText)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardCompliance)
                .HasMaxLength(200);

            this.Property(t => t.IsStandardComplianceText)
                .HasMaxLength(200);

            this.Property(t => t.IsBigChange)
                .HasMaxLength(200);

            this.Property(t => t.IsBigChangeText)
                .HasMaxLength(200);

            this.Property(t => t.IsInvoiceAfterDays)
                .HasMaxLength(200);

            this.Property(t => t.IsInvoiceAfterDaysText)
                .HasMaxLength(200);

            this.Property(t => t.ContractUrl)
                .HasMaxLength(500);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.InitiatorID)
                .HasMaxLength(200);

            this.Property(t => t.InitiatorName)
                .HasMaxLength(200);

            this.Property(t => t.OwnerID)
                .HasMaxLength(200);

            this.Property(t => t.OwnerName)
                .HasMaxLength(200);

            this.Property(t => t.PONo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Contract_Request");
            this.Property(t => t.ContractGuid).HasColumnName("ContractGuid");
            this.Property(t => t.ContractNo).HasColumnName("ContractNo");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
            this.Property(t => t.IsSameContent).HasColumnName("IsSameContent");
            this.Property(t => t.IsSameContentText).HasColumnName("IsSameContentText");
            this.Property(t => t.IsStandardContract).HasColumnName("IsStandardContract");
            this.Property(t => t.IsStandardContractText).HasColumnName("IsStandardContractText");
            this.Property(t => t.IsStandardCompliance).HasColumnName("IsStandardCompliance");
            this.Property(t => t.IsStandardComplianceText).HasColumnName("IsStandardComplianceText");
            this.Property(t => t.IsBigChange).HasColumnName("IsBigChange");
            this.Property(t => t.IsBigChangeText).HasColumnName("IsBigChangeText");
            this.Property(t => t.IsInvoiceAfterDays).HasColumnName("IsInvoiceAfterDays");
            this.Property(t => t.IsInvoiceAfterDaysText).HasColumnName("IsInvoiceAfterDaysText");
            this.Property(t => t.ContractUrl).HasColumnName("ContractUrl");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.FormFields).HasColumnName("FormFields");
            this.Property(t => t.RequestFormFields).HasColumnName("RequestFormFields");
            this.Property(t => t.ContractRequestDate).HasColumnName("ContractRequestDate");
            this.Property(t => t.IsXR2R).HasColumnName("IsXR2R");
            this.Property(t => t.PONo).HasColumnName("PONo");
        }
    }
}
