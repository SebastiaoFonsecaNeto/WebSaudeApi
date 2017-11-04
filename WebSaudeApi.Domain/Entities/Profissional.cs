using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("profissional")]
    public partial class Profissional
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

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [StringLength(14)]
        public string Documento { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Telefone { get; set; }

        [StringLength(11)]
        public string Celular { get; set; }

        public int? CelularOperadoraId { get; set; }

        [StringLength(200)]
        public string Endereco { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(50)]
        public string Complemento { get; set; }

        [StringLength(100)]
        public string Bairro { get; set; }

        [StringLength(150)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string Estado { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        public bool Ativo { get; set; }

        [StringLength(250)]
        public string Observacao { get; set; }

        
        public virtual ICollection<Agenda> Agenda { get; set; }

        public virtual Cbo Cbo { get; set; }

        public virtual CelularOperadora CelularOperadora { get; set; }

        
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }

        
        public virtual ICollection<Log> Log { get; set; }

        public virtual Permissao Permissao { get; set; }

        public virtual ProfissionalAcesso ProfissionalAcesso { get; set; }

        public virtual ProfissionalClinico ProfissionalClinico { get; set; }

        public virtual ProfissionalPagamento ProfissionalPagamento { get; set; }

        
        public virtual ICollection<ProfissionalUnidade> ProfissionalUnidade { get; set; }

        
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }

        
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}
