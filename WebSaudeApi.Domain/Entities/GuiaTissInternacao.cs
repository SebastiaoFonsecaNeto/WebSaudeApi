using System;

namespace WebSaude.Domain.Entities
{
    public class GuiaTissInternacao
    {
        public int GuiaTissId { get; set; }
        public DateTime? DataAutorizacao { get; set; }
        public DateTime? DataValidadeSenha { get; set; }
        public string Observacao { get; set; }
        public int AnsCaraterAtendimentoId { get; set; }
        public int AnsTipoFaturamentoId { get; set; }
        public DateTime? DataInicioFaturamento { get; set; }
        public TimeSpan? HoraInicioFaturamento { get; set; }
        public DateTime? DataFinalFaturamento { get; set; }
        public TimeSpan? HoraFinalFaturamento { get; set; }
        public int AnsTipoInternacaoId { get; set; }
        public int AnsRegimeInternacaoId { get; set; }
        public string Cid1 { get; set; }
        public string Cid2 { get; set; }
        public string Cid3 { get; set; }
        public string Cid4 { get; set; }
        public int AnsIndicadorAcidenteId { get; set; }
        public int AnsMotivoEncerramentoId { get; set; }
        public string DeclaracaoNascido { get; set; }
        public string CidObito { get; set; }
        public string DeclaracaoObito { get; set; }
        public bool? IndicadorObitoRn { get; set; }
        public decimal? ValorProcedimentos { get; set; }
        public decimal? ValorTaxasAlugueis { get; set; }
        public decimal? ValorMateriais { get; set; }
        public decimal? ValorMedicamentos { get; set; }
        public decimal? ValorOpme { get; set; }
        public decimal? ValorGasesMedicinais { get; set; }
        public decimal? ValorTotalGeral { get; set; }
        public virtual AnsCaraterAtendimento AnsCaraterAtendimento { get; set; }
        public virtual AnsIndicadorAcidente AnsIndicadorAcidente { get; set; }
        public virtual AnsMotivoEncerramento AnsMotivoEncerramento { get; set; }
        public virtual AnsRegimeInternacao AnsRegimeInternacao { get; set; }
        public virtual AnsTipoFaturamento AnsTipoFaturamento { get; set; }
        public virtual AnsTipoInternacao AnsTipoInternacao { get; set; }
        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}