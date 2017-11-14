using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public partial class Unidade
    {
        public Unidade()
        {
            Agenda = new HashSet<Agenda>();
            AgendaAparelho = new HashSet<AgendaAparelho>();
            EstoqueKardex = new HashSet<EstoqueKardex>();
            EstoqueProduto = new HashSet<EstoqueProduto>();
            NotaFiscal = new HashSet<NotaFiscal>();
            PacienteProntuarioUnidade = new HashSet<PacienteProntuarioUnidade>();
            ProfissionalUnidade = new HashSet<ProfissionalUnidade>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public virtual ICollection<Agenda> Agenda { get; set; }

        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }

        public virtual ICollection<EstoqueKardex> EstoqueKardex { get; set; }

        public virtual ICollection<EstoqueProduto> EstoqueProduto { get; set; }

        public virtual ICollection<NotaFiscal> NotaFiscal { get; set; }

        public virtual ICollection<PacienteProntuarioUnidade> PacienteProntuarioUnidade { get; set; }

        public virtual ICollection<ProfissionalUnidade> ProfissionalUnidade { get; set; }

        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }

        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}