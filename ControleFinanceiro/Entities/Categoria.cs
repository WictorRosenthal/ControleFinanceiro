namespace ControleFinanceiro.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }
        public Categoria(int idCategoria, string descricao)
        {
            IdCategoria = idCategoria;
            Descricao = descricao;
        }
    }
}
