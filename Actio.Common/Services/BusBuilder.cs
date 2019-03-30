using Actio.Common.Commands;
using Actio.Common.Events;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;

namespace Actio.Common.Services
{
    public class BusBuilder : BuildBase
    {
        private readonly IWebHost webHost;

        private readonly IBusClient bus;

        public BusBuilder(IWebHost webHost, IBusClient bus)
        {
            this.webHost = webHost;
            this.bus = bus;
        }

        public override ServiceHost Build() => new ServiceHost(this.webHost);

        public BusBuilder SubscribeToCommand<TCommand>() where TCommand : ICommand
        {
            var handler = (ICommandHandler<TCommand>)webHost.Services
                .GetService(typeof(ICommandHandler<TCommand>));
            bus.WithCommandHandlerAsync(handler);

            return this;
        }

        public BusBuilder SubscribeToEvent<TEvent>() where TEvent : IEvent
        {
            var handler = (IEventHander<TEvent>)webHost.Services
                .GetService(typeof(IEventHander<TEvent>));
            bus.WithEventHandlerAsync(handler);

            return this;
        }
    }
}