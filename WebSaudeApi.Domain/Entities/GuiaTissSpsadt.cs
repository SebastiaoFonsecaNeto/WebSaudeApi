using System;

namespace WebSaude.Domain.Entities
{
    public class GuiaTissSpsadt
    {
        public int GuiaTissId { get; set; }
        public DateTime? DataAutorizacao { get; set; }
        public DateTime? DataValidadeSenha { get; set; }
        public decimal? ValorTotal { get; set; }
        public int CaraterAtendimentoId { get; set; }
        public DateTime? SolicitacaoData { get; set; }
        public string IndicacaoClinica { get; set; }
        public string SolicitanteCodigoOperadora { get; set; }
        public string SolicitanteCnpj { get; set; }
        public string SolicitanteCpf { get; set; }
        public string SolicitanteNome { get; set; }
        public string ProfSolicNome { get; set; }
        public int ProfSolicCodConselhoId { get; set; }
        public string ProfSolicNumeroConselho { get; set; }
        public int ProfSolicUfConselhoId { get; set; }
        public string ProfSolicCbo { get; set; }
        public int IndicadorAcidenteId { get; set; }
        public DateTime? DataAtendimento { get; set; }
        public int TipoConsultaId { get; set; }
        public string ObservacaoJustificativa { get; set; }
        public int MotivoEncerramentoObitoId { get; set; }
        public decimal? ValorProcedimentos { get; set; }
        public decimal? ValorTaxasAlugueis { get; set; }
        public decimal? ValorMateriais { get; set; }
        public decimal? ValorMedicamentos { get; set; }
        public decimal? ValorOpme { get; set; }
        public decimal? ValorGasesMedicinais { get; set; }
        public decimal? ValorTotalGeral { get; set; }
        public int TipoAtendimentoId { get; set; }
        public virtual AnsCaraterAtendimento AnsCaraterAtendimento { get; set; }
        public virtual AnsMotivoEncerramentoObito AnsMotivoEncerramentoObito { get; set; }
        public virtual AnsTipoAtendimento AnsTipoAtendimento { get; set; }
        public virtual AnsTipoConsulta AnsTipoConsulta { get; set; }
        public virtual AnsUnidadeFederacao AnsUnidadeFederacao { get; set; }
        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}