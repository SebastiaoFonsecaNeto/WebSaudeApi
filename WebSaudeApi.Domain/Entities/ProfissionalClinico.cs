using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class ProfissionalClinico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfissionalId { get; set; }

        public int ConselhoId { get; set; }

        [Required]
        [StringLength(10)]
        public string NumeroConselho { get; set; }

        [Required]
        [StringLength(2)]
        public string UfConselho { get; set; }

        [Column(TypeName = "money")]
        public decimal? ValorConsulta { get; set; }

        [StringLength(8)]
        public string CodigoConsulta { get; set; }

        public bool? AtendeSeg { get; set; }

        public bool? AtendeTer { get; set; }

        public bool? AtendeQua { get; set; }

        public bool? AtendeQui { get; set; }

        public bool? AtendeSex { get; set; }

        public bool? AtendeSab { get; set; }

        public TimeSpan? HoraInicio { get; set; }

        public TimeSpan? HoraFim { get; set; }

        public int? IntervaloConsulta { get; set; }

        public int? MaximoConsulta { get; set; }

        public int? MaximoEncaixe { get; set; }

        public virtual Conselho Conselho { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}
