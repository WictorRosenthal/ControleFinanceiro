
namespace ControleFinanceiro.Entities
{
    public class Titulo
    {
        public int IdTitulo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
        
        Status status = new Status();
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorFinal { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public Categoria? Categoria { get; set; }
        public bool Pago { get; set; }
        //Serviços 
        public Titulo()
        {
        }
        public Titulo(int idTitulo, DateTime dataCadastro, string descricao, decimal valor,
            DateTime dataVencimento, DateTime? dataRecebimento, DateTime? dataPagamento,
            decimal? valorTotal, decimal? valorFinal, MeioPagamento meioPagamento,  Categoria? categoria, bool pago)
        {
            IdTitulo = idTitulo;
            DataCadastro = dataCadastro;
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Valor = valor;
            DataVencimento = dataVencimento;
            DataRecebimento = dataRecebimento;
            DataPagamento = dataPagamento;
            ValorTotal = valorTotal;
            ValorFinal = valorFinal;
            MeioPagamento = meioPagamento ?? throw new ArgumentNullException(nameof(meioPagamento));
            Categoria = categoria;
            Pago = pago;
        }
    }
}
