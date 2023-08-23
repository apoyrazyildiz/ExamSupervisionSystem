namespace ExamSupervisionSystem.Domain.Interfaces;

public interface IEntityBase
{
     DateTime CreatedTime { get; set; }
     DateTime? UpdatedTime { get; set; }
     string? CreatedUserId { get; set; }
     string? UpdatedUserId { get; set; }
}

public interface IEntityBase<TKey> : IEntityBase
{
    TKey? Id { get; set; }
}
