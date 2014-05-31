using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IYTEthesis.Model;
using IYTEthesis.Data.Map;

namespace IYTEthesis.Data
{
    public partial class IYTEthesisDbContext : DbContext
    {
        static IYTEthesisDbContext()
        {
            Database.SetInitializer<IYTEthesisDbContext>(null);
        }

        public IYTEthesisDbContext()
            : base("Name=IYTEthesisDbContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<OnlineVehicle> OnlineVehicles { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleStatus> VehicleStatuses { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DriverMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new OnlineVehicleMap());
            modelBuilder.Configurations.Add(new OwnerMap());
            modelBuilder.Configurations.Add(new VehicleMap());
            modelBuilder.Configurations.Add(new VehicleStatusMap());
        }
    }
}
