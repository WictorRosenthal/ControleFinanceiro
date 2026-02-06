namespace ControleFinanceiro.Entities
{
    public class MeioPagamento
    {
        public int IdMeioPagamento { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public MeioPagamento(int idMeioPagamento, string descricao)
        {
            IdMeioPagamento = idMeioPagamento;
            Descricao = descricao;
        }
    }
}
