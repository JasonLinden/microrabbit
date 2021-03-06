using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T Command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, H>() where T : Event where H : IEventHandler<T>;
    }
}
