using System;

namespace OneRepoCQRS.ReadModel.Infrastructure
{
    public class RepoItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public int Size { get; set; }

        public string URL { get; set; }
    }
}
