using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Interfaces;
using ListaProp.Infra.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ListaProp.Infra.Repositorio
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SqLiteContext _sqlitecontext;
        private readonly DbSet<T> _bdSet;
        public Repository (SqLiteContext sqlitecontext )
        {
            _sqlitecontext = sqlitecontext;
            _bdSet = _sqlitecontext.Set<T>();
        }
        public async Task Add(T obj)
        {
            await _bdSet.AddAsync(obj);
            await _sqlitecontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
           return await _bdSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _bdSet.FindAsync(id);  
        }

        public async Task Remove(int id)
        {
            _bdSet.Remove(await GetById(id));  
            await _sqlitecontext.SaveChangesAsync();          
        }

        public async Task Update(T obj)
        {
             _bdSet.Update(obj);
             await _sqlitecontext.SaveChangesAsync();
        }
    }
}