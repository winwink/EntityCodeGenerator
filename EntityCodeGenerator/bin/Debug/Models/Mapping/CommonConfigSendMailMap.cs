using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Models.Mapping
{
    public class CommonConfigSendMailMap : EntityTypeConfiguration<CommonConfigSendMail>
    {
        public CommonConfigSendMailMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigID);

            // Properties
            this.Property(t => t.Module)
                .HasMaxLength(200);

            this.Property(t => t.RequestType)
                .HasMaxLength(200);

            this.Property(t => t.ActivityName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Common_Config_SendMail");
            this.Property(t => t.ConfigID).HasColumnName("ConfigID");
            this.Property(t => t.Module).HasColumnName("Module");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.ActivityName).HasColumnName("ActivityName");
            this.Property(t => t.IsSendMail).HasColumnName("IsSendMail");
        }
    }
}
