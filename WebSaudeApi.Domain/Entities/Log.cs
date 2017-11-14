using System;

namespace WebSaude.Domain.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public DateTime Data { get; set; }
        public string Tabela { get; set; }
        public string TipoManutencao { get; set; }
        public string DadosAnt { get; set; }
        public string DadosPost { get; set; }
        public int RegId { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}