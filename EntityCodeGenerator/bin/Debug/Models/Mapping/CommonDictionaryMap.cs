using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class CommonDictionaryMap : EntityTypeConfiguration<CommonDictionary>
    {
        public CommonDictionaryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(100);

            this.Property(t => t.SubType)
                .HasMaxLength(100);

            this.Property(t => t.SubSubType)
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(500);

            this.Property(t => t.Value)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Common_Dictionary");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.SubType).HasColumnName("SubType");
            this.Property(t => t.SubSubType).HasColumnName("SubSubType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
        }
    }
}
