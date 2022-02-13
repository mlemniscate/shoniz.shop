using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace shoniz.shop.Persistence
{
    public class ShopDbContext : DbContextBase
    {
        public ShopDbContext() : base(ConfigurationManager.ConnectionStrings["Shop"].ConnectionString)
        {

        }

        protected override List<dynamic> DetectEntityMappings()
        {
            var entityMappings = typeof(CustomerMapping).Assembly
                .GetTypes()
                .Where(t => t.GetInterface(typeof(IEntityMapping).Name) != null)
                .Select(t => Activator.CreateInstance(t))
                .Cast<dynamic>()
                .ToList();
            return entityMappings;
        }
    }
}
