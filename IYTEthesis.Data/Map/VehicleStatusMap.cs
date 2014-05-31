using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Map
{
    public class VehicleStatusMap : EntityTypeConfiguration<VehicleStatus>
    {
        public VehicleStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.Status)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("VehicleStatuses");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
