
/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
namespace Domain.Common
{

    /// <summary>
    /// Entities base properties
    /// </summary>
    public class BaseEntity : AuditableEntity
    {
        
        public int Id { get; set; }
        public string Code { get; set; }

    }
}
