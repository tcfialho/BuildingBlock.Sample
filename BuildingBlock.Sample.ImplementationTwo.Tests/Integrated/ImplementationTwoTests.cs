using Microsoft.Extensions.DependencyInjection;
using BuildingBlock.Sample.ImplementationTwo.Configurations;

using Xunit;

namespace BuildingBlock.Sample.ImplementationTwo.Tests
{
    public class ImplementationTwoTests
    {
        [Fact]
        public void ShouldInjectImplementationTwo()
        {
            var services = new ServiceCollection();

            services.AddSampleImplementationTwo(setup =>
            {
                setup.OtherConfigParam = "OptionOne";
            });

            var serviceProvider = services.BuildServiceProvider();

            var sample = serviceProvider.GetService<ISample>();

            Assert.IsType<ImplementationTwo>(sample);
        }
    }
}
