using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class PacienteConvenio
    {
        public int Id { get; set; }

        public int ConveniosId { get; set; }

        public int PacienteId { get; set; }

        [Required]
        [StringLength(25)]
        public string NumeroPlano { get; set; }

        [StringLength(150)]
        public string DescricaoPlano { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidadePlano { get; set; }

        public virtual Convenio Convenio { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
