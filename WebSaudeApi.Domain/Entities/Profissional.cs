using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Profissional
    {
        public Profissional()
        {
            Agenda = new HashSet<Agenda>();
            Encaminhamento = new HashSet<Encaminhamento>();
            Log = new HashSet<Log>();
            ProfissionalUnidade = new HashSet<ProfissionalUnidade>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }
        public int CboId { get; set; }
        public int PermissaoId { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int? CelularOperadoraId { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool Ativo { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual Cbo Cbo { get; set; }
        public virtual CelularOperadora CelularOperadora { get; set; }
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }
        public virtual ICollection<Log> Log { get; set; }
        public virtual ProfissionalAcesso ProfissionalAcesso { get; set; }
        public virtual ProfissionalClinico ProfissionalClinico { get; set; }
        public virtual ProfissionalPagamento ProfissionalPagamento { get; set; }
        public virtual ICollection<ProfissionalUnidade> ProfissionalUnidade { get; set; }
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}