namespace Entidades.Models
{
    public class Despesas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Momento { get; set; }
        public int Categoria { get; set; }
        public int Usuario { get; set; }
    }
}