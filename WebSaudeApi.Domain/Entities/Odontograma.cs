using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("odontograma")]
    public partial class Odontograma
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int NumeroDente { get; set; }

        public int Face { get; set; }

        [Column(TypeName = "text")]
        public string Descricao { get; set; }

        public int Status { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
