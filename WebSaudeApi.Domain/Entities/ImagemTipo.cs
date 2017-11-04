using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class ImagemTipo
    {
        public ImagemTipo()
        {
            PacienteImagem = new HashSet<PacienteImagem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
        
        public virtual ICollection<PacienteImagem> PacienteImagem { get; set; }
    }
}
