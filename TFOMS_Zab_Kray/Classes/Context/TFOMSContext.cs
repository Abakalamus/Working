using System.Data.Entity;

namespace TFOMS_Zab_Kray.Classes.Context
{
    class TFOMSContext : DbContext
    {
        public TFOMSContext() : base("OIODbContext")
        { }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
