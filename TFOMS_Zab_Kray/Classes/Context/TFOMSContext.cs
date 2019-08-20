using System.Data.Entity;

namespace TFOMS_Zab_Kray.Classes.Context
{
    class TFOMSContext : DbContext
    {
        public TFOMSContext() : base("'OIODbContext'")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("OIO");
            modelBuilder.Entity<Building>().ToTable("Buildings", "OIO");
            modelBuilder.Entity<Floor>().ToTable("Floors", "OIO");
            modelBuilder.Entity<Department>().ToTable("Departments", "OIO");
            modelBuilder.Entity<Cabinet>().ToTable("Cabinets", "OIO");
            modelBuilder.Entity<Employee>().ToTable("Employees", "OIO");
            modelBuilder.Entity<Position>().ToTable("Positions", "OIO");
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
