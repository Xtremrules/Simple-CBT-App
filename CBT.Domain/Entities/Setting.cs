using CBT.Domain.Abstracts;

namespace CBT.Domain.Entities
{
    public class Setting : NamedAuditableEntity<int>
    {
        public Setting()
        {
            SortOptions = false;
            SortQuestion = false;
        }
        public bool SortQuestion { get; set; }
        public bool SortOptions { get; set; }
    }
}