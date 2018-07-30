using System.ComponentModel.DataAnnotations.Schema;
using Common.CSWF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Common.CSWF.Entity.Mapping
{
    public class CommonAttachmentsConfigMap : EntityTypeConfiguration<CommonAttachmentsConfig>
    {
        public CommonAttachmentsConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ProcessCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RequestType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RequestSubType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AttachmentType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AttachmentTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Condition)
                .HasMaxLength(500);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Attachments_Config");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.RequestSubType).HasColumnName("RequestSubType");
            this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
            this.Property(t => t.AttachmentTypeName).HasColumnName("AttachmentTypeName");
            this.Property(t => t.IsMandatory).HasColumnName("IsMandatory");
            this.Property(t => t.IsAddWatermark).HasColumnName("IsAddWatermark");
            this.Property(t => t.Condition).HasColumnName("Condition");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
