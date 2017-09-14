using System.Linq;
using Domain.Entities;

namespace Domain.Abstract
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }
    }
}
