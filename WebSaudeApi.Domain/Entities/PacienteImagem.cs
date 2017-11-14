namespace WebSaude.Domain.Entities
{
    public class PacienteImagem
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string Descricao { get; set; }
        public int ImagemTipoId { get; set; }
        public string Imagem { get; set; }
        public virtual ImagemTipo ImagemTipo { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}