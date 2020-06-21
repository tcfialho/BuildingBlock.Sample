using BuildingBlock.Sample.ImplementationTwo.Configurations;

using Microsoft.Extensions.Options;

using System.Threading.Tasks;

namespace BuildingBlock.Sample.ImplementationOne
{
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
