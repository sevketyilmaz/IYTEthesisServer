using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using IYTEthesis.Model;


namespace IYTEthesis.Data.Map
{
    public class OwnerMap : EntityTypeConfiguration<Owner>
    {
        public OwnerMap()
        {
            // Primary Key
            this.HasKey(t => t.OwnerId);

            // Properties
            this.Property(t => t.OwnerName)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .HasMaxLength(128);

            this.Property(t => t.GSM)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Owners");
            this.Property(t => t.OwnerId).HasColumnName("OwnerId");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.GSM).HasColumnName("GSM");
        }
    }
}
