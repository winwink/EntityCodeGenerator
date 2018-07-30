using System.ComponentModel.DataAnnotations.Schema;
using Common.CSWF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Common.CSWF.Entity.Mapping
{
    public class CommonAttachmentsMap : EntityTypeConfiguration<CommonAttachments>
    {
        public CommonAttachmentsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AttachmentType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AttachmentTypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.FileUrl)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Attachments");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
            this.Property(t => t.AttachmentTypeName).HasColumnName("AttachmentTypeName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileUrl).HasColumnName("FileUrl");
            this.Property(t => t.IsAddWatermark).HasColumnName("IsAddWatermark");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
