namespace CBT.Entities.Abstracts
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}