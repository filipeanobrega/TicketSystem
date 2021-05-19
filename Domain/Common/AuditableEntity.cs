
/*
 * @author Filipe Nóbrega
 * @changeset:
 *  - 19.05.2021 Created
 */
using System;

namespace Domain.Common
{
    public class AuditableEntity
    {
        
        public DateTime CreatedDate { get; set; }
        public string CreateBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

    }
}
