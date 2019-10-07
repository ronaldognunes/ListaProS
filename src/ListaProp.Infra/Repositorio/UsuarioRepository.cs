using ListaProp.Domain.Entidades;
using ListaProp.Domain.Interfaces;
using ListaProp.Infra.Contexto;

namespace ListaProp.Infra.Repositorio
{
    public class UsuarioRepository : Repository<Usuario>,IUsuarioRepository
    {
        public UsuarioRepository(SqLiteContext sqlitecontext) : base(sqlitecontext)
        {
        }
    }
}