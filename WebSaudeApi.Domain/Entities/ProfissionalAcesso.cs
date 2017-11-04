using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class ProfissionalAcesso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfissionalId { get; set; }

        [StringLength(250)]
        public string Senha { get; set; }

        public TimeSpan? HoraInicio { get; set; }

        public TimeSpan? HoraFim { get; set; }

        public bool? Dom { get; set; }

        public bool? Seg { get; set; }

        public bool? Ter { get; set; }

        public bool? Qua { get; set; }

        public bool? Qui { get; set; }

        public bool? Sex { get; set; }

        public bool? Sab { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Ultimo { get; set; }

        public int? Ip { get; set; }

        public int? QuantidadeMinuto { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}
