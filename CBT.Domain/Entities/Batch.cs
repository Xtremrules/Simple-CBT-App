using CBT.Domain.Abstracts;
using System.Collections.Generic;

namespace CBT.Domain.Entities
{
    public class Batch : NamedAuditableEntity<int>
    {
        public string UniqueNumber { get; set; }

        public ICollection<SQuestion> SQuestions { get; set; }
    }
}
