using System;
using System.Collections.Generic;
using System.Linq;
using CQRSlite.Events;
using OneRepoCQRS.ReadModel.Infrastructure;

namespace OneRepoCQRS.WriteModel
{
    public class DbEventStore : IEventStore
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly RepoItemContext _context;

        public DbEventStore(IEventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
            _context = new RepoItemContext();
        }

        public void Save<T>(IEnumerable<IEvent> events)
        {
            EventStore eventStore = null;
            foreach (var @event in events)
            {
                //does this already exist in the context
                if (!_context.EventStores.Any(es => es.Id == @event.Id))
                    eventStore = _context.EventStores.Add(new EventStore());

                eventStore.Events.Add(@event);

                _eventPublisher.Publish(@event);
            }
        }

        public IEnumerable<IEvent> Get<T>(Guid aggregateId, int fromVersion)
        {
            List<IEvent> events;
            var eventStore = _context.EventStores.SingleOrDefault(es => es.Id == aggregateId);
            return eventStore != null ? eventStore.Events : new List<IEvent>();
        }
    }
}
