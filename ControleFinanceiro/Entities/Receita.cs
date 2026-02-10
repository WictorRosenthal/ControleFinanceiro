namespace ControleFinanceiro.Entities
{
    public class Receita
    {
        public int IdReceita { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public decimal? ValorTotal { get; set; }

        TipoReceita tiporeceita = new TipoReceita();
        Convenio convenio = new Convenio();
        Categoria? categoria = new Categoria();
        public Receita()
        {
        }
        /// <summary>
        ///pensei em criar um construtor para trazer os diferentes cenarios,
        ///como por exemplo, fazer um serviço (ITipoReceita) quando a receita for do tipo salário,
        ///onde o valor total seria o valor bruto menos os descontos de impostos e convenios.
        ///e com isso fazer um construtor para esse cenario do salario e outro construtor para o
        ///cenario de uma receita de venda, onde o valor total seria o valor bruto mais os impostos e descontos.
        ///ou quando a receita for do tipo freelancer, onde poderimaos lançar uma conta avulsa.
        /// </summary>
    }
}
