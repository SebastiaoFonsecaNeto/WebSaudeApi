using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissInternacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuiaTissId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataAutorizacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataValidadeSenha { get; set; }

        [StringLength(500)]
        public string Observacao { get; set; }

        public int AnsCaraterAtendimentoId { get; set; }

        public int AnsTipoFaturamentoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataInicioFaturamento { get; set; }

        public TimeSpan? HoraInicioFaturamento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataFinalFaturamento { get; set; }

        public TimeSpan? HoraFinalFaturamento { get; set; }

        public int AnsTipoInternacaoId { get; set; }

        public int AnsRegimeInternacaoId { get; set; }

        [StringLength(4)]
        public string Cid1 { get; set; }

        [StringLength(4)]
        public string Cid2 { get; set; }

        [StringLength(4)]
        public string Cid3 { get; set; }

        [StringLength(4)]
        public string Cid4 { get; set; }

        public int AnsIndicadorAcidenteId { get; set; }

        public int AnsMotivoEncerramentoId { get; set; }

        [StringLength(11)]
        public string DeclaracaoNascido { get; set; }

        [StringLength(4)]
        public string CidObito { get; set; }

        [StringLength(11)]
        public string DeclaracaoObito { get; set; }

        public bool? IndicadorObitoRn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorProcedimentos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorTaxasAlugueis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorMateriais { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorMedicamentos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorOpme { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorGasesMedicinais { get; set; }

        [Column(TypeName = "numeric")]
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
