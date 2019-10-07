using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ListaProp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _repositorio;
        public UsuarioController(IUsuarioService repositorio)
        {
            _repositorio = repositorio;
        }
        // GET api/values
        [HttpGet("usuarios")]
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            try{
                return await _repositorio.CarregarTodos();
            }catch{
                return new List<Usuario>();
            }
            
        }

        // GET api/values/5
        [HttpGet("consulta/{id}")]
        public async Task<Usuario> Get(int id)
        {
            return await _repositorio.Consulta(id);       
        }

        // POST api/values
        [HttpPost("criar")]
        public async Task Post([FromBody] Usuario usuario)
        {
            await _repositorio.Criar(usuario);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Usuario usuario)
        {
            await _repositorio.Atualizar(usuario);
        }

        // DELETE api/values/5
        [HttpDelete("apagar/{id}")]
        public async Task Delete(int id)
        {
            await _repositorio.Apagar(id);
        }
    }
}
