using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CarService.Context
{
    public class MyPhotosModelContainerMetadata : DbContext
    {
        public MyPhotosModelContainerMetadata()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Photos> Imagini { get; set; }
        public virtual DbSet<DetaliiPhoto> DetaliiComenzi { get; set; }
        public virtual DbSet<User> Clienti { get; set; }
        public virtual DbSet<Search> Searches { get; set; }
    }
}
