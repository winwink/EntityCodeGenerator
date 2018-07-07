using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class CommonLogMap : EntityTypeConfiguration<CommonLog>
    {
        public CommonLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ActionUserAccount)
                .HasMaxLength(200);

            this.Property(t => t.ActionUserName)
                .HasMaxLength(200);

            this.Property(t => t.Module)
                .HasMaxLength(200);

            this.Property(t => t.Action)
                .HasMaxLength(200);

            this.Property(t => t.OldValue)
                .HasMaxLength(4000);

            this.Property(t => t.NewValue)
                .HasMaxLength(4000);

            this.Property(t => t.Comments)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Common_Log");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ActionUserAccount).HasColumnName("ActionUserAccount");
            this.Property(t => t.ActionUserName).HasColumnName("ActionUserName");
            this.Property(t => t.Module).HasColumnName("Module");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.ActionTime).HasColumnName("ActionTime");
            this.Property(t => t.OldValue).HasColumnName("OldValue");
            this.Property(t => t.NewValue).HasColumnName("NewValue");
            this.Property(t => t.Comments).HasColumnName("Comments");
        }
    }
}
