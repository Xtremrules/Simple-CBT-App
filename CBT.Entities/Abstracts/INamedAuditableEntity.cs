namespace CBT.Entities.Abstracts
{
    public interface INamedAuditableEntity : IAuditableEntity
    {
        string Name { get; set; }
    }
}