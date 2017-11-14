using System;

namespace WebSaude.Domain.Entities
{
    public class ProfissionalClinico
    {
        public int ProfissionalId { get; set; }
        public int ConselhoId { get; set; }
        public string NumeroConselho { get; set; }
        public string UfConselho { get; set; }
        public decimal? ValorConsulta { get; set; }
        public string CodigoConsulta { get; set; }
        public bool? AtendeSeg { get; set; }
        public bool? AtendeTer { get; set; }
        public bool? AtendeQua { get; set; }
        public bool? AtendeQui { get; set; }
        public bool? AtendeSex { get; set; }
        public bool? AtendeSab { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFim { get; set; }
        public int? IntervaloConsulta { get; set; }
        public int? MaximoConsulta { get; set; }
        public int? MaximoEncaixe { get; set; }
        public virtual Conselho Conselho { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}