using Domain.Common;
using System.Collections.Generic;


/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Entities
{

    /// <summary>
    /// Pools are ticket containers, they can aggragate tickets from clients,
    /// fields or software (ex. Mr. Smith, HelpDesk, Outlook, etc)
    /// </summary>
    public class Pool : BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Ticket> Tickets { get; private set; }

    }
}
