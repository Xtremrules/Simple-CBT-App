using System.Collections.Generic;

namespace CBT.Entities
{
    public class Batch : Abstracts.NamedAuditableEntity<int>
    {
        public string UniqueNumber { get; set; }

        public ICollection<SQuestion> SQuestions { get; set; }
    }
}