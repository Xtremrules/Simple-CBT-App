using CBT.Entities.Abstracts;
using System.Collections.Generic;

namespace CBT.Entities
{
    public class SQuestion : NamedAuditableEntity<int>
    {
        public int NumberofOptions { get; set; }
        public int NumberofQuestions { get; set; }
        public int SettingID { get; set; }
        public virtual Setting Setting { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}