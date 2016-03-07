using CBT.Domain.Abstracts;

namespace CBT.Domain.Entities
{
    public class Option : Entity<int>
    {
        public int QuestionID { get; set; }
        public string Content { get; set; }
        public virtual Question Question { get; set; }
    }
}