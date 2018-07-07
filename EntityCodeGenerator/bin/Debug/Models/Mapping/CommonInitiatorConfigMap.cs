using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class CommonInitiatorConfigMap : EntityTypeConfiguration<CommonInitiatorConfig>
    {
        public CommonInitiatorConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RequestType)
                .HasMaxLength(200);

            this.Property(t => t.RequestSubType)
                .HasMaxLength(200);

            this.Property(t => t.UserAccount)
                .HasMaxLength(50);

            this.Property(t => t.CreateBy)
                .HasMaxLength(200);

            this.Property(t => t.UpdateBy)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Common_Initiator_Config");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.RequestSubType).HasColumnName("RequestSubType");
            this.Property(t => t.UserAccount).HasColumnName("UserAccount");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
        }
    }
}
