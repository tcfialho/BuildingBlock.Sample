using BuildingBlock.Sample.ImplementationOne.Configurations;

using Microsoft.Extensions.Options;

using System.Threading.Tasks;

namespace BuildingBlock.Sample.ImplementationOne
{
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
