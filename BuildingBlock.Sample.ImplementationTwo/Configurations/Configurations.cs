using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using System;

namespace BuildingBlock.Sample.ImplementationTwo.Configurations
{
    /// <summary>
    /// Adds dependency injection and handles the correct component configuration.
    /// </summary>
    public static class Configurations
    {
        public static IImplementationTwoBuilder AddSampleImplementationTwo(this IServiceCollection services, Action<ImplementationTwoOptions> options)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            services.Configure(options);

            services.TryAddScoped<ISample, ImplementationTwo>();

            return new ImplementationTwoBuilder(services);
        }
    }
}