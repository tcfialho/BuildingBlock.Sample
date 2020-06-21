using BuildingBlock.Sample.ImplementationTwo.Configurations;

using Microsoft.Extensions.Options;

using System.Threading.Tasks;

namespace BuildingBlock.Sample.ImplementationTwo
{
    /// <summary>
    /// An implementation for the component contract.
    /// Must be used by dependency injection of ISample provided by AddImplementationTwo IServiceCollection extension.
    /// </summary>
    public class ImplementationTwo : ISample
    {
        private readonly ImplementationTwoOptions _options;

        public ImplementationTwo(IOptions<ImplementationTwoOptions> options)
        {
            _options = options.Value;
        }

        public async Task DoSomething()
        {
            await Task.CompletedTask;
        }
    }
}
