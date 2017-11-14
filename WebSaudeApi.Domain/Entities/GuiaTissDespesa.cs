using System;

namespace WebSaude.Domain.Entities
{
    public class GuiaTissDespesa
    {
        public int Id { get; set; }
        public int GuiaTissId { get; set; }
        public int AnsDespesaId { get; set; }
        public DateTime? DataExecucao { get; set; }
        public TimeSpan? HoraInicial { get; set; }
        public TimeSpan? HoraFinal { get; set; }
        public int? ProcedimentoTabela { get; set; }
        public int? ProcedimentoCodigo { get; set; }
        public string ProcedimentoDescricao { get; set; }
        public decimal? QuantidadeExecutada { get; set; }
        public int AnsUnidadeMedidaId { get; set; }
        public decimal? ReducaoAcrescimo { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
        public string RegistroAnvisa { get; set; }
        public string CodigoRefFabricante { get; set; }
        public string AutorizacaoFuncionamento { get; set; }
        public virtual AnsDespesa AnsDespesa { get; set; }
        public virtual AnsUnidadeMedida AnsUnidadeMedida { get; set; }
        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}