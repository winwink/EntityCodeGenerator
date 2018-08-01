using System.ComponentModel.DataAnnotations.Schema;
using CSWF.CommonService.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CSWF.CommonService.Entity.Mapping
{
    public class CommonOrgBusinessAreaMap : EntityTypeConfiguration<CommonOrgBusinessArea>
    {
        public CommonOrgBusinessAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.BACode);

            // Properties
            this.Property(t => t.BACode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BANameCN)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Org_BusinessArea");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BANameCN).HasColumnName("BANameCN");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
        }
    }
}
