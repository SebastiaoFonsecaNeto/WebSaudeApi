namespace WebSaude.Domain.Entities
{
    public class PacienteProntuarioUnidade
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int UnidadeId { get; set; }
        public int Numero { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}