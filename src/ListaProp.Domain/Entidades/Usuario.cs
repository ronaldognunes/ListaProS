using System.Collections.Generic;

namespace ListaProp.Domain.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual IList<ListaUsuario> Listas { get; set; }
    }
}