using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Domain.Customers;
using System.Data;

namespace shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings
{
    public class AddressMapping : EntityMappingBase<Address>
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
            Property(a => a.Celphone)
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
