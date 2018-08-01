using System.ComponentModel.DataAnnotations.Schema;
using CSWF.CommonService.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CSWF.CommonService.Entity.Mapping
{
    public class CommonOrgFunctionRegionMap : EntityTypeConfiguration<CommonOrgFunctionRegion>
    {
        public CommonOrgFunctionRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BACode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BLCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Function)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Region)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Common_Org_FunctionRegion");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BACode).HasColumnName("BACode");
            this.Property(t => t.BLCode).HasColumnName("BLCode");
            this.Property(t => t.Function).HasColumnName("Function");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
