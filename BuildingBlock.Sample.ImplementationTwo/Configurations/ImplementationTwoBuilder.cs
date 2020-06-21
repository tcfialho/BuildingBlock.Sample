using BuildingBlock.Sample.Configurations;

using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlock.Sample.ImplementationTwo.Configurations
{
    internal class ImplementationTwoBuilder : SampleBuilderBase, IImplementationTwoBuilder
    {
        public ImplementationTwoBuilder(IServiceCollection services) : base(services)
        {
        }
    }
}
