namespace CBT.Domain.Abstracts
{
    public interface INamedAuditableEntity : IAuditableEntity
    {
        string Name { get; set; }
    }
}