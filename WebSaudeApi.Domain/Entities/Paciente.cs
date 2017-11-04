using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("paciente")]
    public partial class Paciente
    {
        public Paciente()
        {
            Agenda = new HashSet<Agenda>();
            AgendaAparelho = new HashSet<AgendaAparelho>();
            Encaminhamento = new HashSet<Encaminhamento>();
            Odontograma = new HashSet<Odontograma>();
            PacienteConta = new HashSet<PacienteConta>();
            PacienteConvenio = new HashSet<PacienteConvenio>();
            PacienteImagem = new HashSet<PacienteImagem>();
            PacienteMatmed = new HashSet<PacienteMatmed>();
            PacienteProcedimento = new HashSet<PacienteProcedimento>();
            PacienteProntuarioUnidade = new HashSet<PacienteProntuarioUnidade>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        public int Sexo { get; set; }

        [StringLength(11)]
        public string Cpf { get; set; }

        [StringLength(15)]
        public string Cns { get; set; }

        [StringLength(10)]
        public string Telefone { get; set; }

        [StringLength(11)]
        public string Celular { get; set; }

        public int? CelularOperadoraId { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

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

        public int? Dependente { get; set; }

        [StringLength(200)]
        public string Responsavel { get; set; }
        
        public virtual ICollection<Agenda> Agenda { get; set; }
        
        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }

        public virtual CelularOperadora CelularOperadora { get; set; }
        
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }
        
        public virtual ICollection<Odontograma> Odontograma { get; set; }
        
        public virtual ICollection<PacienteConta> PacienteConta { get; set; }
        
        public virtual ICollection<PacienteConvenio> PacienteConvenio { get; set; }

        public virtual ICollection<PacienteImagem> PacienteImagem { get; set; }

        public virtual ICollection<PacienteMatmed> PacienteMatmed { get; set; }
        
        public virtual ICollection<PacienteProcedimento> PacienteProcedimento { get; set; }
        
        public virtual ICollection<PacienteProntuarioUnidade> PacienteProntuarioUnidade { get; set; }
        
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
        
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}
