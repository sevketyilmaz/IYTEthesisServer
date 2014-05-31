using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Map
{
    public class OnlineVehicleMap : EntityTypeConfiguration<OnlineVehicle>
    {
        public OnlineVehicleMap()
        {
            // Primary Key
            this.HasKey(t => t.VehicleId);

            // Properties
            this.Property(t => t.VehicleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OnlineVehicles");
            this.Property(t => t.VehicleId).HasColumnName("VehicleId");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lng).HasColumnName("Lng");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.JobId).HasColumnName("JobId");

            // Relationships
            this.HasOptional(t => t.Job)
                .WithMany(t => t.OnlineVehicles)
                .HasForeignKey(d => d.JobId);
            this.HasRequired(t => t.Vehicle)
                .WithOptional(t => t.OnlineVehicle);
            this.HasOptional(t => t.VehicleStatus)
                .WithMany(t => t.OnlineVehicles)
                .HasForeignKey(d => d.StatusId);

        }
    }
}
