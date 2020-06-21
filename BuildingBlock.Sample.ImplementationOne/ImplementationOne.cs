using BuildingBlock.Sample.ImplementationOne.Configurations;

using Microsoft.Extensions.Options;

using System.Threading.Tasks;

namespace BuildingBlock.Sample.ImplementationOne
{
    /// <summary>
    /// An implementation for the component contract.
    /// Must be used by dependency injection of ISample.
    /// </summary>
    public class ImplementationOne : ISample
    {
        private readonly ImplementationOneOptions _options;

        public ImplementationOne(IOptions<ImplementationOneOptions> options)
        {
            _options = options.Value;
        }

        public async Task DoSomething()
        {
            await Task.CompletedTask;
        }
    }
}
