namespace WebSaude.Domain.Entities
{
    public class Cbo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int DiasLimiteAtendimento { get; set; }
        public int DiasLimiteRetorno { get; set; }
        public bool Clinico { get; set; }
    }
}