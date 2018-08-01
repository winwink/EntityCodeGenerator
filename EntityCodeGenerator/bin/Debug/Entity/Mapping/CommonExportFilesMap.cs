using System.ComponentModel.DataAnnotations.Schema;
using CSWF.CommonService.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CSWF.CommonService.Entity.Mapping
{
    public class CommonExportFilesMap : EntityTypeConfiguration<CommonExportFiles>
    {
        public CommonExportFilesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.File)
                .IsRequired();

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_ExportFiles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.File).HasColumnName("File");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
