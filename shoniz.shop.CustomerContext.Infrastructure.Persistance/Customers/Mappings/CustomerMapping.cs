using shoniz.shop.CustomerContext.Domain.Customers;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            Property(c => c.NationalCode)
                .HasColumnType(SqlDbType.Char.ToString())
                .HasMaxLength(10)
                .IsRequired();
            Property(c => c.Email)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.FirstName)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(20)
                .IsRequired();
            Property(c => c.LastName)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(20)
                .IsRequired();
            Property(c => c.Password)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .IsMaxLength()
                .IsRequired();
        }
    }
    public class AddressMapping : EntityTypeConfiguration<Address>
    {
        public AddressMapping()
        {
            Property(a => a.CustomerId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString())
                .IsRequired();
            HasRequired(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CustomerId)
                .WillCascadeOnDelete();
            Property(a => a.Coordinate)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(30)
                .IsOptional();
            Property(a => a.Telephone)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(20)
                .IsOptional();
            Property(a => a.AddressLine)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .HasMaxLength(500)
                .IsRequired();
            Property(a => a.PostalCode)
                .HasColumnType(SqlDbType.Char.ToString())
                .HasMaxLength(10)
                .IsRequired();
            Property(a => a.CityId)
                .HasColumnType(SqlDbType.Int.ToString())
                .IsRequired();
        }
    }
}
