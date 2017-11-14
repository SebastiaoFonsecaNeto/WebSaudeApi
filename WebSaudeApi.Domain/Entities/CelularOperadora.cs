using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class CelularOperadora
    {
        public CelularOperadora()
        {
            Paciente = new HashSet<Paciente>();
            Profissional = new HashSet<Profissional>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
        public virtual ICollection<Profissional> Profissional { get; set; }
    }
}