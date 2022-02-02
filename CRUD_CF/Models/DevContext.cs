using System.Data.Entity;

namespace CRUD_CF.Models
{
    public class DevContext : DbContext
    {

        public DevContext() : base("DevDBContext")
        {

        }

        public DbSet<Modelo> Modelo { get; set; }
    }
}