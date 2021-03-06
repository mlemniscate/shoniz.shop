using Castle.MicroKernel.Registration;
using Castle.Windsor;
using shoniz.Framework.Core;
using shoniz.Framework.Core.Persistance;
using shoniz.Framework.DependencyInjection;
using shoniz.Framework.Domain;
using shoniz.Framework.Facade;
using shoniz.Framework.Persistance;
using shoniz.Framework.Security;
using shoniz.shop.CustomerContext.ApplicationService.Customers;
using shoniz.shop.CustomerContext.Domain.Services.Customers;
using shoniz.shop.CustomerContext.Facade;
using shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers;
using shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers.Mappings;
using shoniz.shop.Persistence;
using Shoniz.Framework.ApplicationService;

namespace shoniz.Shop.CustomerContext.Configuration
{
    public class Registrar : IRegistrar
    {
        public void Register(WindsorContainer container)
        {
            container.Register(
                Component
                .For<IHashProvider>()
                .ImplementedBy<HashProvider>()
                .LifestyleSingleton()
                );

            container.Register(
                Component
                .For<IDbContext>()
                .ImplementedBy<ShopDbContext>()
                .LifestyleSingleton()
                );

            container.Register(
                Classes
                .FromAssemblyContaining<SignupCommandHandler>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(
                Classes
                .FromAssemblyContaining<CustomerCommandFacade>()
                .BasedOn(typeof(BaseCommandFacade))
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(
                Classes
                .FromAssemblyContaining<NationalCodeDuplicationChecker>()
                .BasedOn<IDomainService>()
                .WithServiceAllInterfaces()
                .LifestyleTransient());
            
            container.Register(
                Classes
                .FromAssemblyContaining<CustomerMapping>()
                .BasedOn<IEntityMapping>()
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            container.Register(
                Classes
                .FromAssemblyContaining<CustomerRepository>()
                .BasedOn(typeof(IRepository<>))
                .WithServiceAllInterfaces()
                .LifestyleTransient());
        }
    }
}
