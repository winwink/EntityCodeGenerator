using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class CommonAttachmentsConfigMap : EntityTypeConfiguration<CommonAttachmentsConfig>
    {
        public CommonAttachmentsConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.AttachmentConfigGuid);

            // Properties
            this.Property(t => t.AttachmentConfigGuid)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RequestType)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubType)
                .HasMaxLength(200);

            this.Property(t => t.AttachmentType)
                .HasMaxLength(200);

            this.Property(t => t.AttachmentTypeName)
                .HasMaxLength(200);

            this.Property(t => t.Condition)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Common_Attachments_Config");
            this.Property(t => t.AttachmentConfigGuid).HasColumnName("AttachmentConfigGuid");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.RequestSubType).HasColumnName("RequestSubType");
            this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
            this.Property(t => t.AttachmentTypeName).HasColumnName("AttachmentTypeName");
            this.Property(t => t.IsMandatory).HasColumnName("IsMandatory");
            this.Property(t => t.IsAddWatermark).HasColumnName("IsAddWatermark");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
