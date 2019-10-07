using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;

namespace ListaProp.Service
{
    public class ListaService : IListaService
    {
        private readonly IListaRepository _listaRepository;
        public ListaService(IListaRepository listaRepository)
        {
            _listaRepository = listaRepository;
        }
        public async Task Apagar(int id)
        {
           await _listaRepository.Remove(id);
        }

        public async Task Atualizar(Lista obj)
        {
            await _listaRepository.Update(obj);
        }

        public async Task<IEnumerable<Lista>> CarregarTodos()
        {
           return await _listaRepository.GetAll();
        }

        public async Task<Lista> Consulta(int id)
        {
            return await _listaRepository.GetById(id);
        }

        public async Task Criar(Lista obj)
        {
            await _listaRepository.Add(obj);
        }
    }
}