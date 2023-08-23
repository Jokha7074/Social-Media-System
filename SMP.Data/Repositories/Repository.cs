using Microsoft.EntityFrameworkCore;
using SMP.Data.Commons;
using SMP.Data.DbContexts;
using SMP.Data.IRepositories;
using System.Linq.Expressions;

namespace SMP.Data.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{


    public AppDbContext dbContext;
    public DbSet<T> dbSet;
    public Repository(AppDbContext appDbContext)
    {
        this.dbContext = appDbContext;
        dbSet = dbContext.Set<T>();
    }

    public async Task CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        entity.IsDeleted = true;
    }

    public void Detrive(T entity)
    {
        dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        dbContext.Entry(entity).State = EntityState.Modified;
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null, bool IsNoTracking = true, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable();

        query = IsNoTracking ? query : query.AsNoTracking();

        if (includes is not null)
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

        return query;
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null)
    {
        IQueryable<T> query = expression is null ? dbSet.AsQueryable() : dbSet.Where(expression).AsQueryable();

        if (includes is not null)
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        var entity = await query.FirstOrDefaultAsync(expression);

        return entity;
    }

    public async Task SaveAsync()
    {
        await dbContext.SaveChangesAsync();
    }
}
