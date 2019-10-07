using System.Collections.Generic;

namespace ListaProp.Domain.Entidades
{
     public class Lista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdItens { get; set; }
        public decimal Valor { get; set; }
        public bool Situacao { get; set; }        
        public bool Compartilhada { get; set; }
        public virtual IList<Item> Itens { get; set; }
        public virtual IList<ListaUsuario> Usuarios { get; set; }
    }
}