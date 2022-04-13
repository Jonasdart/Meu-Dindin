namespace Entidades.Models
{
    public class Receitas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Categoria { get; set; }
        public int Usuario { get; set; }
    }
}