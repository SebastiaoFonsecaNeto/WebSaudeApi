namespace WebSaude.Domain.Entities
{
    public class Odontograma
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int NumeroDente { get; set; }
        public int Face { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}