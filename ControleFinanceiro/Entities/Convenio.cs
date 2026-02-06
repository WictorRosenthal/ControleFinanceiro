using ControleFinanceiro.Services;

namespace ControleFinanceiro.Entities
{
    public class Convenio
    {
        public int IdConvenio { get; set; }
        public string Descricao { get; set; }

        IConvenio _convenioService;

        public Convenio()
        {
        }

        public Convenio(int idConvenio, string descricao)
        {
            IdConvenio = idConvenio;
            Descricao = descricao;
        }
    }
}
