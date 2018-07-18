using System.ComponentModel.DataAnnotations.Schema;
using RDCN.CPT.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RDCN.CPT.Data.Entity.Mapping
{
    public class RequestCarFleetMap : EntityTypeConfiguration<RequestCarFleet>
    {
        public RequestCarFleetMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.RequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RequestNo)
                .HasMaxLength(50);

            this.Property(t => t.RequestType)
                .HasMaxLength(50);

            this.Property(t => t.RequestTypeName)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            this.Property(t => t.InitiatorID)
                .HasMaxLength(50);

            this.Property(t => t.InitiatorName)
                .HasMaxLength(50);

            this.Property(t => t.RequestUrl)
                .HasMaxLength(200);

            this.Property(t => t.CreateBy)
                .HasMaxLength(50);

            this.Property(t => t.UpdateBy)
                .HasMaxLength(50);

            this.Property(t => t.FormFields)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Request_CarFleet");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.RequestNo).HasColumnName("RequestNo");
            this.Property(t => t.RequestType).HasColumnName("RequestType");
            this.Property(t => t.RequestTypeName).HasColumnName("RequestTypeName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ProcInstID).HasColumnName("ProcInstID");
            this.Property(t => t.InitiatorID).HasColumnName("InitiatorID");
            this.Property(t => t.InitiatorName).HasColumnName("InitiatorName");
            this.Property(t => t.RequestUrl).HasColumnName("RequestUrl");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.CompleteTime).HasColumnName("CompleteTime");
            this.Property(t => t.FormFields).HasColumnName("FormFields");
        }
    }
}
