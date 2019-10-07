using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaProp.Domain.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Remove(int id);
        Task Add(T obj);
        Task Update(T obj);
    }    
}