using shoniz.Framework.Core.DependencyInjection;
using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.Persistence
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base(ConfigurationManager.ConnectionStrings["Shop"].ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            List<dynamic> mappings = DetectEntityMappings();

            mappings.ForEach(m => modelBuilder.Configurations.Add(m));
        }

        public static List<dynamic> DetectEntityMappings()
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
