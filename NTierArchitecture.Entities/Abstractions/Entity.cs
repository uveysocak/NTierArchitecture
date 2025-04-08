namespace NTierArchitecture.Entities.Abstractions;
public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }

}
