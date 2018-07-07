using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
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

            this.Property(t => t.ConfigValue)
                .HasMaxLength(2000);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(200);

            this.Property(t => t.LastUpdateBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Common_Config");
            this.Property(t => t.ConfigKey).HasColumnName("ConfigKey");
            this.Property(t => t.ConfigValue).HasColumnName("ConfigValue");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.LastUpdateBy).HasColumnName("LastUpdateBy");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
        }
    }
}
