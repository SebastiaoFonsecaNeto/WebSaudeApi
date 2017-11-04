using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissProcedimento
    {
        public GuiaTissProcedimento()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
        }

        public int Id { get; set; }

        public int GuiaTissId { get; set; }

        public int? ProcedimentoTabela { get; set; }

        public int? ProcedimentoCodigo { get; set; }

        [StringLength(300)]
        public string ProcedimentoDescricao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantidade { get; set; }

        public int AnsViaId { get; set; }

        public int AnsTecnicaId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReducaoAcrescimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorUnitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorTotal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }

        public TimeSpan? HoraInicial { get; set; }

        public TimeSpan? HoraFinal { get; set; }

        public virtual AnsTecnica AnsTecnica { get; set; }

        public virtual AnsViaAcesso AnsViaAcesso { get; set; }

        public virtual GuiaTiss GuiaTiss { get; set; }
        
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
    }
}
