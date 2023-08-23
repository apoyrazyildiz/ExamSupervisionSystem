using ExamSupervisionSystem.Domain.Abstracts;
using ExamSupervisionSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ExamSupervisionSystem.Persistence.Concrete.EntityFrameworkCore.Contexts;

public  class EfDbContext : DbContext
{
    public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)  { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDbContext).Assembly);
    }
    
    public override int SaveChanges()
    {
        SaveBefore();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SaveBefore();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void SaveBefore()
    {
        var entries = ChangeTracker.Entries().Where(x => x.Entity is IEntityBase);
        foreach (var entry in entries)
        {
            if (entry.Entity is not IEntityBase entity) continue;
            entry.Property("UpdatedTime").IsModified = true;
            entity.UpdatedTime = DateTime.UtcNow;
            switch (entry)
            {
                case { State: EntityState.Added }:
                    entity.CreatedTime = DateTime.Now;
                    break;

                case { State: EntityState.Modified }:
                    UpdateRules(entry, entity);
                    break;
                case  { State: EntityState.Detached}:
                    entry.State = EntityState.Modified;
                    UpdateRules(entry, entity);
                    break;
            }
        }
    }

    private static void UpdateRules(EntityEntry entry, IEntityBase entity)
    {
        entry.Property("CreatedTime").IsModified = false;
        entry.Property("CreatedUserId").IsModified = false;
    }
}