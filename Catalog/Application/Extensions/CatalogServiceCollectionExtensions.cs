using Catalog.Application.Adapter;
using Catalog.Application.Events;
using Catalog.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;
using Shared.Ports;

namespace Catalog.Application.Extensions
{
    public static class CatalogServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogUseCases(this IServiceCollection services)
        {
            services.AddScoped<INewBookUseCase, NewBookUseCase>();
            services.AddScoped<INewCopyUseCase, NewCopyUseCase>();
            services.AddScoped<ICopyServicePort, CopyServiceAdapter>();

            return services;
        }

        public static IServiceCollection AddCatalogMediatorServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(LoanCreatedListener).Assembly));

            return services;
        }
    }
}
