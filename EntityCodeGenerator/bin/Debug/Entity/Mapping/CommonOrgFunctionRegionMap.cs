using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class CommonOrgFunctionRegionMap : EntityTypeConfiguration<CommonOrgFunctionRegion>
    {
        public CommonOrgFunctionRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.FunctionRegionCode);

            // Properties
            this.Property(t => t.FunctionRegionCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FunctionRegionNameCN)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FunctionRegionNameEN)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BLCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Org_FunctionRegion");
            this.Property(t => t.FunctionRegionCode).HasColumnName("FunctionRegionCode");
            this.Property(t => t.FunctionRegionNameCN).HasColumnName("FunctionRegionNameCN");
            this.Property(t => t.FunctionRegionNameEN).HasColumnName("FunctionRegionNameEN");
            this.Property(t => t.BLCode).HasColumnName("BLCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
        }
    }
}
