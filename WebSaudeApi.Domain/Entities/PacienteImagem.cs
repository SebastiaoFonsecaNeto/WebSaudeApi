using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class PacienteImagem
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int ImagemTipoId { get; set; }

        [Required]
        [StringLength(250)]
        public string Imagem { get; set; }

        public virtual ImagemTipo ImagemTipo { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
