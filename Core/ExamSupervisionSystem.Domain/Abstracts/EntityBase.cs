using ExamSupervisionSystem.Domain.Interfaces;

namespace ExamSupervisionSystem.Domain.Abstracts;

public abstract class EntityBase : IEntityBase
{
    public DateTime CreatedTime { get; set; }
    public DateTime? UpdatedTime { get; set; }
    public string? CreatedUserId { get; set; }
    public string? UpdatedUserId { get; set; }
}

public abstract class EntityBase<TKey> : EntityBase, IEntityBase<TKey>
{
    public TKey? Id { get; set; }
}
