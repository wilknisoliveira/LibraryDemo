using Catalog.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Extensions
{
    public static class CatalogServiceCollectionExtensions
    {
        public static IServiceCollection AddCatalogUseCases(this IServiceCollection services)
        {
            services.AddScoped<INewBookUseCase, NewBookUseCase>();

            return services;
        }
    }
}
