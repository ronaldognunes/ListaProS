using System.Collections.Generic;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ListaProp.api.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _repositorio;
        public ItemController(IItemService repositorio)
        {
            _repositorio = repositorio;
        }
        
        [HttpGet("todos")]
        public async Task<IEnumerable<Item>> GetAll(){
            try
            {
                return await _repositorio.CarregarTodos();
            }
            catch
            {
                return new List<Item>();
            }
            
        }

        [HttpGet("consulta/{id}")]
        public async Task<Item> GetById(int id){
            return await _repositorio.Consulta(id);
        }

        [HttpPost("criar")]
        public async Task Cadastrar([FromBody] Item item){
            await _repositorio.Criar(item);
        }

        [HttpPut("atualizar/{id}")]
        public async Task Atualizar( int id , [FromBody] Item item){
            await _repositorio.Atualizar(item);
        }

        [HttpDelete("apagar/{id}")]
        public async Task Deletar(int id){
           await _repositorio.Apagar(id);     
        }


    }
}