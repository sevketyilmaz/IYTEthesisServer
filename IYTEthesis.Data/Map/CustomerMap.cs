using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Map
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerId);

            // Properties
            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(128);

            this.Property(t => t.GSM)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.GSM).HasColumnName("GSM");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lng).HasColumnName("Lng");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
