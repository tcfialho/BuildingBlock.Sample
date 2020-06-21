using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace BuildingBlock.Sample.ImplementationOne.Tests
{
    public class ImplementationTwoTests
    {
        [Fact]
        public void ShouldInjectImplementationTwo()
        {
            var services = new ServiceCollection();

            services.AddSampleImplementationTwo(setup =>
            {
                setup.OptionOne = "OptionOne";
            });

            var serviceProvider = services.BuildServiceProvider();

            var sample = serviceProvider.GetService<ISample>();

            Assert.IsType<ImplementationTwo>(sample);
        }
    }
}
