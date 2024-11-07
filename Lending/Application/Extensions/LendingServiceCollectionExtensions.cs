using Lending.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Lending.Application.Extensions
{
    public static class LendingServiceCollectionExtensions
    {
        public static IServiceCollection AddLendingUseCases(this IServiceCollection services)
        {
            services.AddScoped<INewLoanUseCase, NewLoanUseCase>();

            return services;
        }

        public static IServiceCollection AddLendingMediatorServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(NewLoanUseCase).Assembly));

            return services;
        }
    }
}
