using System.ComponentModel.DataAnnotations.Schema;
using CSWF.CommonService.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CSWF.CommonService.Entity.Mapping
{
    public class CommonConfigMap : EntityTypeConfiguration<CommonConfig>
    {
        public CommonConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigKey);

            // Properties
            this.Property(t => t.ConfigKey)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ProcessCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConfigValue)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Remark)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Config");
            this.Property(t => t.ConfigKey).HasColumnName("ConfigKey");
            this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
            this.Property(t => t.ConfigValue).HasColumnName("ConfigValue");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
