
/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Enums
{

    /// <summary>
    /// Ticket resolution state
    /// </summary>
    public enum TicketState
    {

        /*
         * TODO:
         * These states are minimal and for more dynamic purposes
         * should be stored in a table with some sort of ticker 
         * workflow process.
         */

        /* Represents a ticket that is open */
        OPEN = 0,

        /* Represents a ticket that is being resolved */
        INRESOLUTION = 1,

        /* Represents a ticket that is closed */
        CLOSED = 2

    }
}
