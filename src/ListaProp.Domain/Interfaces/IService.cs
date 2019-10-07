using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaProp.Domain.Interfaces
{
    public interface IService<T> where T: class
    {
        Task<T> Consulta(int id);
        Task<IEnumerable<T>> CarregarTodos();
        Task Apagar(int id);
        Task Atualizar(T obj);
        Task Criar(T obj);
    }
}