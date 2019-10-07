namespace ListaProp.Domain.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Qtd { get; set; }
        public bool Selecionado { get; set; }
        public decimal ValorTotal { get; set; }
        public virtual int IdLista { get; set; }
        public virtual Lista lista { get; set; }
    }
}