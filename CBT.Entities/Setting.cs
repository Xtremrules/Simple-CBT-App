using CBT.Entities.Abstracts;

namespace CBT.Entities
{
    public class Setting : NamedAuditableEntity<int>
    {
        public bool SortQuestion { get; set; }
        public bool SortOptions { get; set; }
    }
}