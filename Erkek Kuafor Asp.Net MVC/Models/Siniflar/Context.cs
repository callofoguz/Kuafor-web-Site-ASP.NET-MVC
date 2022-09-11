using System.Data.Entity;

namespace Deneme09.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public  DbSet<Randevu> Randevus { get; set; }
        


    }
}