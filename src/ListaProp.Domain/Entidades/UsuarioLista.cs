namespace ListaProp.Domain.Entidades
{
    public class ListaUsuario
    {
        public int IdLista { get; set; }
        public int IdUsuario { get; set; }
        public virtual Lista lista { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}