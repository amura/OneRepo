using System.Linq;

namespace OneRepoCQRS.ReadModel
{
    public interface IReadModelFacade
    {
        IQueryable<RepoItemDto> GetInventoryItems();
    }
}