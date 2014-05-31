using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Map
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.JobId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Jobs");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.VehicleId).HasColumnName("VehicleId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.PickupDate).HasColumnName("PickupDate");
            this.Property(t => t.DropDate).HasColumnName("DropDate");
            this.Property(t => t.PickupLat).HasColumnName("PickupLat");
            this.Property(t => t.PickupLng).HasColumnName("PickupLng");
            this.Property(t => t.DropLat).HasColumnName("DropLat");
            this.Property(t => t.DropLng).HasColumnName("DropLng");
        }
    }
}
