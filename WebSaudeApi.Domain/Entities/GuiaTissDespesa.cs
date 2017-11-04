using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissDespesa
    {
        public int Id { get; set; }

        public int GuiaTissId { get; set; }

        public int AnsDespesaId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataExecucao { get; set; }

        public TimeSpan? HoraInicial { get; set; }

        public TimeSpan? HoraFinal { get; set; }

        public int? ProcedimentoTabela { get; set; }

        public int? ProcedimentoCodigo { get; set; }

        [StringLength(300)]
        public string ProcedimentoDescricao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QuantidadeExecutada { get; set; }

        public int AnsUnidadeMedidaId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReducaoAcrescimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorTotal { get; set; }

        [StringLength(15)]
        public string RegistroAnvisa { get; set; }

        [StringLength(60)]
        public string CodigoRefFabricante { get; set; }

        [StringLength(30)]
        public string AutorizacaoFuncionamento { get; set; }

        public virtual AnsDespesa AnsDespesa { get; set; }

        public virtual AnsUnidadeMedida AnsUnidadeMedida { get; set; }

        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}
