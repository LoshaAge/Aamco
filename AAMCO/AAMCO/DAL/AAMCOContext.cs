using AAMCO.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AAMCO.DAL
{
    public class AAMCOContext : DbContext
    {

        public AAMCOContext() : base("AAMCOContext")
        {
        }

        public DbSet<StubDataModel> StubData { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}