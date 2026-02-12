using ControleFinanceiro.Interfaces;
namespace ControleFinanceiro.Services
{
    public interface Convenio : IDespesa
    {
        public int IdConvenio { get; set; }
        public string Descricao { get; set; }
        //definir outros métodos ou propriedades conforme necessário
    }
}
