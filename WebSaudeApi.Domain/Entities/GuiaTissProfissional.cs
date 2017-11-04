using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissProfissional
    {
        public int Id { get; set; }

        public int GuiaTissProcedimentoId { get; set; }

        public int? AnsEquipeId { get; set; }

        public int AnsGrauParticipacaoId { get; set; }

        [StringLength(14)]
        public string CodigoIdentificacao { get; set; }

        [StringLength(70)]
        public string Nome { get; set; }

        public int AnsConselhoId { get; set; }

        [StringLength(15)]
        public string NumeroConselho { get; set; }

        public int AnsUfId { get; set; }

        [StringLength(6)]
        public string Cbo { get; set; }

        public virtual AnsConselhoRegional AnsConselhoRegional { get; set; }

        public virtual AnsGrauParticipacao AnsGrauParticipacao { get; set; }

        public virtual AnsUnidadeFederacao AnsUnidadeFederacao { get; set; }

        public virtual GuiaTissProcedimento GuiaTissProcedimento { get; set; }
    }
}
