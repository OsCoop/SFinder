using SFinder.Domain.Core.Entities;

namespace SFinder.Domain.Core.CommandHandlers
{
    public abstract class CommandHandler<TEntity> where TEntity : Entity
    {
        public CommandHandler()
        {
        }
    }
}
