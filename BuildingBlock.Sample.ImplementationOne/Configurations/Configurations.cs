using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using System;

namespace BuildingBlock.Sample.ImplementationOne.Configurations
{
    public static class Configurations
    {
        public static IImplementationOneBuilder AddSampleImplementationOne(this IServiceCollection services, Action<ImplementationOneOptions> options)
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

            services.TryAddScoped<ISample, ImplementationOne>();

            return new ImplementationOneBuilder(services);
        }
    }
}