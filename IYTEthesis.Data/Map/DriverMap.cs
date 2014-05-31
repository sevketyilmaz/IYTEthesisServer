using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Map
{
    public class DriverMap : EntityTypeConfiguration<Driver>
    {
        public DriverMap()
        {
            // Primary Key
            this.HasKey(t => t.DriverId);

            // Properties
            this.Property(t => t.DriverName)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(128);

            this.Property(t => t.GSM)
                .HasMaxLength(25);

            this.Property(t => t.DriverLicence)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Drivers");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.DriverName).HasColumnName("DriverName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.GSM).HasColumnName("GSM");
            this.Property(t => t.DriverLicence).HasColumnName("DriverLicence");
        }
    }
}
