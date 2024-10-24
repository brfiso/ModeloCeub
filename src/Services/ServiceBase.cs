
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using ModeloCeub.Data;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Services;

public abstract class ServiceBase<T> : IServiceBase<T> where T : EntityBase
{
    private readonly CeubDbContext Context;

    protected ServiceBase(CeubDbContext context)
    {
        Context = context;
    }

    public virtual async Task<T?> Obter(int id, string? includes = null)
    {
        IQueryable<T> query = Context.Set<T>();

        if (!string.IsNullOrEmpty(includes))
        {
            var includesList = includes.Split(',');

            foreach (var include in includesList)
                query = query.Include(include.Trim());
        }

        return await query.FirstOrDefaultAsync(x => x.Id == id);
    }

    public virtual async Task<IEnumerable<T>> ObterTodos(string? includes = null)
    {
        if (Context is null)
            return Enumerable.Empty<T>();

        IQueryable<T> query = Context.Set<T>().AsNoTracking();

        if (!string.IsNullOrEmpty(includes))
        {
            var includesList = includes.Split(',');

            foreach (var include in includesList)
                query = query.Include(include.Trim());
        }

        return await query.ToListAsync();
    }

    public virtual async Task Adicionar(T obj)
    {
        await Context.Set<T>().AddAsync(obj);
        await Context.SaveChangesAsync();
    }

    public virtual async Task Atualizar(T obj)
    {
        Context.Set<T>().Update(obj);
        await Context.SaveChangesAsync();
    }

    public virtual async Task Remover(int id)
    {
        var obj = await Obter(id);
        if (obj != null)
        {
            Context.Set<T>().Remove(obj);
            await Context.SaveChangesAsync();
        }
    }

    public virtual async Task Remover(T obj)
    {
        if (obj != null)
        {
            Context.Set<T>().Remove(obj);
            await Context.SaveChangesAsync();
        }
    }
}