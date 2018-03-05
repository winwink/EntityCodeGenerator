using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Daheng88.Model.Models.Mapping;

namespace Daheng88.Model.Models
{
    public partial class CodeFirstAppContext : DbContext
    {
        static CodeFirstAppContext()
        {
            Database.SetInitializer<CodeFirstAppContext>(null);
        }

        public CodeFirstAppContext()
            : base("Name=CodeFirstAppContext")
        {
        }

        public DbSet<Donator> Donators { get; set; }
        public DbSet<PayWay> PayWays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DonatorMap());
            modelBuilder.Configurations.Add(new PayWayMap());
        }
    }
}
