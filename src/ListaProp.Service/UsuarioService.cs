using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;

namespace ListaProp.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository; 
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task Apagar(int id)
        {
            await _repository.Remove(id);
        }

        public async Task Atualizar(Usuario obj)
        {
            await _repository.Update(obj);
        }

        public async Task<IEnumerable<Usuario>> CarregarTodos()
        {
            return await _repository.GetAll();
        }

        public async Task<Usuario> Consulta(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Criar(Usuario obj)
        {
            await _repository.Add(obj);
        }
    }
}