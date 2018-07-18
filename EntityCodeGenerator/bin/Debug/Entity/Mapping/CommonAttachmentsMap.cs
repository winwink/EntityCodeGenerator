using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class CommonAttachmentsMap : EntityTypeConfiguration<CommonAttachments>
    {
        public CommonAttachmentsMap()
        {
            // Primary Key
            this.HasKey(t => t.AttachmentID);

            // Properties
            this.Property(t => t.RequestGuid)
                .HasMaxLength(200);

            this.Property(t => t.AttachmentType)
                .HasMaxLength(200);

            this.Property(t => t.AttachmentTypeName)
                .HasMaxLength(200);

            this.Property(t => t.Title)
                .HasMaxLength(200);

            this.Property(t => t.FileName)
                .HasMaxLength(500);

            this.Property(t => t.FileUrl)
                .HasMaxLength(500);

            this.Property(t => t.CreateBy)
                .HasMaxLength(200);

            this.Property(t => t.LastUpdateBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Common_Attachments");
            this.Property(t => t.AttachmentID).HasColumnName("AttachmentID");
            this.Property(t => t.RequestGuid).HasColumnName("RequestGuid");
            this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
            this.Property(t => t.AttachmentTypeName).HasColumnName("AttachmentTypeName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileUrl).HasColumnName("FileUrl");
            this.Property(t => t.IsAddWatermark).HasColumnName("IsAddWatermark");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.LastUpdateBy).HasColumnName("LastUpdateBy");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
        }
    }
}
