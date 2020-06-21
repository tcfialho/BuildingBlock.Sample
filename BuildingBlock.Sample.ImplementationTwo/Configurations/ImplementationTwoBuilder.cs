using BuildingBlock.Sample.Configurations;

using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlock.Sample.ImplementationTwo.Configurations
{
    /// <summary>
    /// Builder class for allow 'AddSampleImplementationTwo' return 'IImplementationTwoBuilder'.
    /// </summary>
    internal class ImplementationTwoBuilder : SampleBuilderBase, IImplementationTwoBuilder
    {
        public ImplementationTwoBuilder(IServiceCollection services) : base(services)
        {
        }
    }
}
