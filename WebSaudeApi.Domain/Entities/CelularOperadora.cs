using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class CelularOperadora
    {
        public CelularOperadora()
        {
            Paciente = new HashSet<Paciente>();
            Profissional = new HashSet<Profissional>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Nome { get; set; }
        
        public virtual ICollection<Paciente> Paciente { get; set; }
        
        public virtual ICollection<Profissional> Profissional { get; set; }
    }
}
