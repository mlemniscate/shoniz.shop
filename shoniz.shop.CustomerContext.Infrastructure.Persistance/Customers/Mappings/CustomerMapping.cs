using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Domain.Customers;
using System.Data;

namespace shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings
{
    public class CustomerMapping : EntityMappingBase<Customer>
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
}
