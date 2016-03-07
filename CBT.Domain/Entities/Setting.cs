using CBT.Domain.Abstracts;

namespace CBT.Domain.Entities
{
    public class Setting : NamedAuditableEntity<int>
    {
        public bool SortQuestion { get; set; }
        public bool SortOptions { get; set; }
    }
}