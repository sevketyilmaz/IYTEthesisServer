using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;


namespace IYTEthesis.Data.Map
{
    public class VehicleMap : EntityTypeConfiguration<Vehicle>
    {
        public VehicleMap()
        {
            // Primary Key
            this.HasKey(t => t.VehicleId);

            // Properties
            this.Property(t => t.NumberPlate)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Vehicles");
            this.Property(t => t.VehicleId).HasColumnName("VehicleId");
            this.Property(t => t.NumberPlate).HasColumnName("NumberPlate");
            this.Property(t => t.OwnerId).HasColumnName("OwnerId");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lng).HasColumnName("Lng");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            this.HasOptional(t => t.Driver)
                .WithMany(t => t.Vehicles)
                .HasForeignKey(d => d.DriverId);
            this.HasOptional(t => t.Owner)
                .WithMany(t => t.Vehicles)
                .HasForeignKey(d => d.OwnerId);

        }
    }
}
