using System;
using System.Collections.Generic;
using System.Data.Entity;
using CQRSlite.Events;

namespace OneRepoCQRS.ReadModel.Infrastructure
{
    public class RepoItemContext : DbContext
    {
        public RepoItemContext() : base("DefaultConnection")
        {

        }

        public DbSet<RepoItem> RepoItems { get; set; }

        public DbSet<Event> Events { get;set; }

        public DbSet<EventStore> EventStores { get; set; }
    }


    public class Event : IEvent
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public virtual EventStore EventStore { get; set; }
    }

    public class EventStore
    {
        public Guid Id { get; set; }
        public ICollection<IEvent> Events;
    }
}
