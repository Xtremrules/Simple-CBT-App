namespace CBT.Domain.Abstracts
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
