using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class CommonExportFilesMap : EntityTypeConfiguration<CommonExportFiles>
    {
        public CommonExportFilesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Common_ExportFiles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.File).HasColumnName("File");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
