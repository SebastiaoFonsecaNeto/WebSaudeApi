using System;

namespace WebSaude.Domain.Entities
{
    public class GuiaTissHonorario
    {
        public int GuiaTissId { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string Observacao { get; set; }
        public decimal? ValorTotal { get; set; }
        public string LocalCodigoOperadora { get; set; }
        public string LocalCnpj { get; set; }
        public string LocalNome { get; set; }
        public string LocalCnes { get; set; }
        public DateTime? DataInicioFaturamento { get; set; }
        public DateTime? DataFinalFaturamento { get; set; }
        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}