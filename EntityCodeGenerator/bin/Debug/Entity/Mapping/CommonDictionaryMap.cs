using System.ComponentModel.DataAnnotations.Schema;
using Common.CSWF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Common.CSWF.Entity.Mapping
{
    public class CommonDictionaryMap : EntityTypeConfiguration<CommonDictionary>
    {
        public CommonDictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ProcessCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SubType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SubSubType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Dictionary");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.SubType).HasColumnName("SubType");
            this.Property(t => t.SubSubType).HasColumnName("SubSubType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
