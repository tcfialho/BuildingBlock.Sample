
using System.Threading.Tasks;

namespace BuildingBlock.Sample
{
    /// <summary>
    /// Public interface for client use the component.
    /// Defines the component contract.
    /// </summary>
    public interface ISample
    {
        Task DoSomething();
    }
}
