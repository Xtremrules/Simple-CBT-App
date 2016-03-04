namespace CBT.Entities
{
    public class Option : Abstracts.Entity<int>
    {
        public int QuestionID { get; set; }
        public string Content { get; set; }
        public virtual Question Question { get; set; }
    }
}