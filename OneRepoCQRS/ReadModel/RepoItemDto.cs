using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRepoCQRS.ReadModel
{
    public class RepoItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public int Size { get; set; }

        public string URL { get; set; }
    }
}
