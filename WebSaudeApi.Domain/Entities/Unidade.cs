using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("unidade")]
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

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; }

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
