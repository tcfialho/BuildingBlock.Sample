using BuildingBlock.Sample.Configurations;

using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlock.Sample.ImplementationOne.Configurations
{
    internal class ImplementationOneBuilder : SampleBuilderBase, IImplementationOneBuilder
    {
        public ImplementationOneBuilder(IServiceCollection services) : base(services)
        {
        }
    }
}
