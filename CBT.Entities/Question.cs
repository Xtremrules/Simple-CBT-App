using CBT.Entities.Abstracts;
using System.Collections.Generic;

namespace CBT.Entities
{
    public class Question : AuditableEntity<int>
    {
        public int SQuestionID { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// This should have the id to the right option
        /// </summary>
        public int Answer { get; set; }
        public virtual SQuestion SQuestion { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}