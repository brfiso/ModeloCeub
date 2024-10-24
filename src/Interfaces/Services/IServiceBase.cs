using ModeloCeub.Models;

namespace ModeloCeub.Interfaces.Services;
public interface IServiceBase<T> where T : EntityBase
{
    Task<T?> Obter(int id, string? includes = null);
    Task<IEnumerable<T>> ObterTodos(string? includes = null);
    Task Adicionar(T obj);
    Task Atualizar(T obj);
    Task Remover(int id);
}