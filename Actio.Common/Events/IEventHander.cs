using System.Threading.Tasks;

namespace Actio.Common.Events
{
    public interface IEventHander<in T> : IEvent
    {
        Task HandleAsync(T @event);
    }
}