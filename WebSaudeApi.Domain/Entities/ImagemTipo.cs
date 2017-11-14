using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class ImagemTipo
    {
        public ImagemTipo()
        {
            PacienteImagem = new HashSet<PacienteImagem>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<PacienteImagem> PacienteImagem { get; set; }
    }
}