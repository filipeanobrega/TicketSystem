using System;
using System.Collections.Generic;

/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Common
{

    /// <summary>
    /// Represents and entity with domain events
    /// </summary>
    public interface IEventEntity
    {
        public List<Event> Events { get; }
    }

    /// <summary>
    /// Domain event
    /// </summary>
    public abstract class Event
    {
        
        public DateTimeOffset Date { get; protected set; }

        protected Event()
        {
            Date = DateTimeOffset.Now;
        }

    }
}
