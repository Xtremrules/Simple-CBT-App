using CBT.Domain.Abstracts;
using System.Collections.Generic;

namespace CBT.Domain.Entities
{
    public class SQuestion : NamedAuditableEntity<int>
    {
        public int NumberofOptions { get; set; }
        public int NumberofQuestions { get; set; }
        public int SettingID { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}