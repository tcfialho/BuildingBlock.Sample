using BuildingBlock.Sample.ImplementationOne.Configurations;

using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace BuildingBlock.Sample.ImplementationOne.Tests
{
    public class ImplementationOneTests
    {
        [Fact]
        public void ShouldInjectImplementationOne()
        {
            var services = new ServiceCollection();

            services.AddSampleImplementationOne(setup =>
            {
                setup.OptionOne = "OptionOne";
            });

            var serviceProvider = services.BuildServiceProvider();

            var sample = serviceProvider.GetService<ISample>();

            Assert.IsType<ImplementationOne>(sample);
        }
    }
}
