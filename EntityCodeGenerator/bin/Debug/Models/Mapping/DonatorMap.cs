using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Daheng88.Model.Models.Mapping
{
    public class DonatorMap : EntityTypeConfiguration<Donator>
    {
        public DonatorMap()
        {
            // Primary Key
            this.HasKey(t => t.DonatorId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Donators");
            this.Property(t => t.DonatorId).HasColumnName("DonatorId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DonateDate).HasColumnName("DonateDate");
        }
    }
}
