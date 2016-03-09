using CBT.Domain.Entities;

namespace CBT.Domain.Models
{
    public class BatchModel
    {
        public BatchModel(Batch model)
        {
            ID = model.ID;
            UniqueNumber = model.UniqueNumber;
            QuestionCount = model.SQuestions.Count;
        }
        public int ID { get; private set; }
        public string UniqueNumber { get; private set; }
        public int QuestionCount { get; private set; }
    }
}