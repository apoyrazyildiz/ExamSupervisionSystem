using ExamSupervisionSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamSupervisionSystem.Persistence.Concrete.EntityFrameworkCore.Mapping;

public static class Extensions
{
    public static void EntityBaseMap<TEntity, TKey>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IEntityBase<TKey>, new()
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.CreatedTime).ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.UpdatedTime).ValueGeneratedOnUpdate().IsRequired(false);
        builder.Property(x => x.CreatedUserId).IsRequired();
        builder.Property(x => x.UpdatedUserId).IsRequired(false);
    }

}