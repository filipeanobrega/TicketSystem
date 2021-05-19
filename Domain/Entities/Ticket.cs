using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;

/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Entities
{
    public class Ticket : BaseEntity, IEventEntity
    {
        
        public Ticket()
        {
            Events = new List<Event>();
        }

        /* Ticket analysis dates */
        public DateTime IssuedDate { get; set; }
        public DateTime ResolutionDate { get; set; }
        public DateTime ClosedDate { get; set; }

        /* Input Properties */
        public Operator Operator { get; set; }
        public Client Client { get; set; }
        public string Description { get; set; }

        /* Process information */
        public Pool Pool { get; set; }

        public TicketState State { get; set; }


        /* List of domain events */
        public List<Event> Events { get; private set; }
    }
}
