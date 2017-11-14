namespace WebSaude.Domain.Entities
{
    public class GuiaTissProfissional
    {
        public int Id { get; set; }
        public int GuiaTissProcedimentoId { get; set; }
        public int? Equipe { get; set; }
        public int AnsGrauParticipacaoId { get; set; }
        public string CodigoIdentificacao { get; set; }
        public string Nome { get; set; }
        public int AnsConselhoId { get; set; }
        public string NumeroConselho { get; set; }
        public int AnsUfId { get; set; }
        public string Cbo { get; set; }
        public virtual AnsConselhoRegional AnsConselhoRegional { get; set; }
        public virtual AnsGrauParticipacao AnsGrauParticipacao { get; set; }
        public virtual AnsUnidadeFederacao AnsUnidadeFederacao { get; set; }
        public virtual GuiaTissProcedimento GuiaTissProcedimento { get; set; }
    }
}