using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class GuiaTissProcedimento
    {
        public GuiaTissProcedimento()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
        }

        public int Id { get; set; }
        public int GuiaTissId { get; set; }
        public int? ProcedimentoTabela { get; set; }
        public int? ProcedimentoCodigo { get; set; }
        public string ProcedimentoDescricao { get; set; }
        public decimal? Quantidade { get; set; }
        public int AnsViaId { get; set; }
        public int AnsTecnicaId { get; set; }
        public decimal? ReducaoAcrescimo { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? ValorTotal { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan? HoraInicial { get; set; }
        public TimeSpan? HoraFinal { get; set; }
        public virtual AnsTecnica AnsTecnica { get; set; }
        public virtual AnsViaAcesso AnsViaAcesso { get; set; }
        public virtual GuiaTiss GuiaTiss { get; set; }
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
    }
}