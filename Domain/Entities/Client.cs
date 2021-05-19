using Domain.Common;

/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Entities
{

    /// <summary>
    /// A Client is a ticket issuer, tickets by a client
    /// can be automaticly categorized if the DefaultPool
    /// property is initialized
    /// </summary>
    public class Client : BaseEntity
    {
        
        public string Name { get; set; }
        public Pool DefaultPool { get; set; }

    }
}
