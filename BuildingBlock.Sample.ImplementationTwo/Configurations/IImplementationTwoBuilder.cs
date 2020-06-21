
using BuildingBlock.Sample.Configurations;

namespace BuildingBlock.Sample.ImplementationTwo.Configurations
{
    /// <summary>
    /// Inteface to allow any 'ImplementationOne' optional implementation be added.
    /// </summary>
    public interface IImplementationTwoBuilder : ISampleBuilder
    {
    }
}
