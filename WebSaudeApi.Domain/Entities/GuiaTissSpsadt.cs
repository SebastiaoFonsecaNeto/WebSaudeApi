using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissSpsadt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuiaTissId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataAutorizacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataValidadeSenha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorTotal { get; set; }

        public int CaraterAtendimentoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SolicitacaoData { get; set; }

        [StringLength(500)]
        public string IndicacaoClinica { get; set; }

        [StringLength(14)]
        public string SolicitanteCodigoOperadora { get; set; }

        [StringLength(14)]
        public string SolicitanteCnpj { get; set; }

        [StringLength(11)]
        public string SolicitanteCpf { get; set; }

        [StringLength(70)]
        public string SolicitanteNome { get; set; }

        [StringLength(70)]
        public string ProfSolicNome { get; set; }

        [Required]
        [StringLength(10)]
        public string ProfSolicCodConselho { get; set; }

        [StringLength(15)]
        public string ProfSolicNumeroConselho { get; set; }

        public int ProfSolicUfConselhoId { get; set; }

        [StringLength(6)]
        public string ProfSolicCbo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CodIndicadorAcidente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataAtendimento { get; set; }

        public int TipoConsultaId { get; set; }

        [StringLength(500)]
        public string ObservacaoJustificativa { get; set; }

        public int MotivoEncerramentoObitoId { get; set; }

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

        public int TipoAtendimentoId { get; set; }

        public virtual AnsCaraterAtendimento AnsCaraterAtendimento { get; set; }

        public virtual AnsMotivoEncerramentoObito AnsMotivoEncerramentoObito { get; set; }

        public virtual AnsTipoAtendimento AnsTipoAtendimento { get; set; }

        public virtual AnsTipoConsulta AnsTipoConsulta { get; set; }

        public virtual AnsUnidadeFederacao AnsUnidadeFederacao { get; set; }

        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}
