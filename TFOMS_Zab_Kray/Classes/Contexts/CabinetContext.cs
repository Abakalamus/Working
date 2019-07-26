using System.Data.Entity;

namespace TFOMS_Zab_Kray.Classes.Contexts
{
    class CabinetContext : DbContext
    {
        public CabinetContext() : base("OIODbContext")
        { }

        public DbSet<Cabinet> Cabinets { get; set; }
    }
}
