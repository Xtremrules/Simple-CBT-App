using System;

namespace CBT.Domain.Abstracts
{
    public abstract class NamedAuditableEntity<T> : Entity<T>, INamedAuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
