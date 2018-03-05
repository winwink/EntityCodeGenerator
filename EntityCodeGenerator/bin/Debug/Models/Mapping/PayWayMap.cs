using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Daheng88.Model.Models.Mapping
{
    public class PayWayMap : EntityTypeConfiguration<PayWay>
    {
        public PayWayMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("PayWays");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Donator_DonatorId).HasColumnName("Donator_DonatorId");

            // Relationships
            this.HasOptional(t => t.Donator)
                .WithMany(t => t.PayWays)
                .HasForeignKey(d => d.Donator_DonatorId);

        }
    }
}
