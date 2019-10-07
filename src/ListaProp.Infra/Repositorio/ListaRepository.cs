using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using ListaProp.Infra.Contexto;

namespace ListaProp.Infra.Repositorio
{
    public class ListaRepository : Repository<Lista>, IListaRepository
    {
        public ListaRepository(SqLiteContext sqlitecontext) : base(sqlitecontext)
        {
        }
    }
}