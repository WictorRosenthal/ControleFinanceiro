namespace ControleFinanceiro.Services
{
    public interface ITipoTitulo
    {
        public int IdTipoTitulo { get; set; }
        public string Descricao { get; set; }

        //Exemplo, se o tipo titulo for um pagamento faz tal coisa, se for recebimento faz outra..

        //definir outros métodos ou propriedades conforme necessário
    }
}
