using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using ListaProp.Infra.Contexto;

namespace ListaProp.Infra.Repositorio
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(SqLiteContext sqlitecontext) : base(sqlitecontext)
        {

        }
    }
}