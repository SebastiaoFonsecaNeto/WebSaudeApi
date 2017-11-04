using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("encaminhamento")]
    public partial class Encaminhamento
    {
        public int Id { get; set; }

        public int CboId { get; set; }

        public int ProfissionalId { get; set; }

        public int PacienteId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] DataHora { get; set; }

        [Column(TypeName = "text")]
        public string Descricao { get; set; }

        public virtual Cbo Cbo { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}
