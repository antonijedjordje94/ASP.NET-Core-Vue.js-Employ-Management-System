namespace EMS.Domain.Common
{
    // Common Domain
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AuditEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
