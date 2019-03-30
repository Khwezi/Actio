using System.ComponentModel;
using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    public interface ICommandHandler<in T> : ICommand
    {
        Task HandleAsync(T command);
    }
}