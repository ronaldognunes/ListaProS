using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ListaProp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaController:ControllerBase
    {   
        private readonly IListaService _repositorio;
        public ListaController(IListaService repositorio)
        {
            _repositorio = repositorio;
        } 

        [HttpGet("todas")]
        public async Task<IEnumerable<Lista>> GetAll(){
            try
            {
                return await _repositorio.CarregarTodos();
            }
            catch 
            {
                return new List<Lista>();
            }
        }
        [HttpGet("consulta/{id}")]
        public async Task<Lista> GetById( int id){
            return await _repositorio.Consulta(id);
        }
        [HttpPost("criar")]
        public async Task Cadastrar([FromBody] Lista lista){
            await _repositorio.Criar(lista);
        }

        [HttpPut("atualizar/{id}")]
        public async Task Atualizar(int id,[FromBody] Lista lista){
            await _repositorio.Atualizar(lista);
        }

        [HttpDelete("apagar/{id}")]
        public async Task Deletar(int id){
            await _repositorio.Apagar(id);
        }

    }
}