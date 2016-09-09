using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneRepoCQRS.ReadModel.Infrastructure;

namespace OneRepoCQRS.ReadModel
{
    public class ReadModelFacade : IReadModelFacade
    {
        private RepoItemContext _context;

        public ReadModelFacade()
        {
            _context = new RepoItemContext();
        }
        public IQueryable<RepoItemDto> GetInventoryItems()
        {
            return _context.RepoItems.Select(ri=>new RepoItemDto(){Description = ri.Description, Id =  ri.Id, Name = ri.Name, Size = ri.Size, TimeStamp = ri.TimeStamp});
        }
    }
}
