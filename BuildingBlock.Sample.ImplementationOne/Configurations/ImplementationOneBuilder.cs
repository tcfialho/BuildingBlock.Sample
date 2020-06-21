using BuildingBlock.Sample.Configurations;

using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlock.Sample.ImplementationOne.Configurations
{
    /// <summary>
    /// Builder class for allow 'AddSampleImplementationOne' return 'IImplementationOneBuilder'.
    /// </summary>
    internal class ImplementationOneBuilder : SampleBuilderBase, IImplementationOneBuilder
    {
        public ImplementationOneBuilder(IServiceCollection services) : base(services)
        {
        }
    }
}
