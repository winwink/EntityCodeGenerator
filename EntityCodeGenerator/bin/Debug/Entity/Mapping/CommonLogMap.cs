using System.ComponentModel.DataAnnotations.Schema;
using Common.CSWF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Common.CSWF.Entity.Mapping
{
    public class CommonLogMap : EntityTypeConfiguration<CommonLog>
    {
        public CommonLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LogLevel)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Log");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReqeustID).HasColumnName("ReqeustID");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.LogLevel).HasColumnName("LogLevel");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
