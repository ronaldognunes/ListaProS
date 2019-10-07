

using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;

namespace ListaProp.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemrepository;
        public ItemService(IItemRepository itemrepository)
        {
            _itemrepository = itemrepository;
        }
        public async Task Apagar(int id)
        {
            await _itemrepository.Remove(id);
        }

        public async Task Atualizar(Item obj)
        {
            await _itemrepository.Update(obj);
        }

        public async Task<IEnumerable<Item>> CarregarTodos()
        {
            return await _itemrepository.GetAll();
        }

        public async Task<Item> Consulta(int id)
        {
            return await _itemrepository.GetById(id);
        }

        public async Task Criar(Item obj)
        {
            await _itemrepository.Add(obj);
        }
    }
}