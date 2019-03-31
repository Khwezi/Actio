using System.Threading.Tasks;
using Actio.Common.Commands;
using RawRabbit;

namespace Actio.Common.RabbitMq
{
    public static class Extensions
    {
        public static async Task WithCommandHandlerAsync<TCommand>(this IBusClient bus,
            ICommandHandler<TCommand> handler) where TCommand : ICommand
            => bus.SubscribeAsync<TCommand>(msg => handler.HandleAsync(msg),
               ctx => ctx.UseConsumerConfiguration(cfg => cfg.FromDelaredQueue(q => q.WithName("udemy"));
    }
}