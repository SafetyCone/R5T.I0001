using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.I0001
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceCollection(this IServiceCollection services)
        {
            services.AddSingleton(services);

            return services;
        }
    }
}
