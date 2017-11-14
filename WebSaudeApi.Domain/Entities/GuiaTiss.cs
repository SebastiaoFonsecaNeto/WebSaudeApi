using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class GuiaTiss
    {
        public GuiaTiss()
        {
            GuiaTissDespesa = new HashSet<GuiaTissDespesa>();
            GuiaTissProcedimento = new HashSet<GuiaTissProcedimento>();
            PacienteConta = new HashSet<PacienteConta>();
        }

        public int Id { get; set; }
        public int? NumeroRegistroAns { get; set; }
        public int? NumeroGuiaPrestador { get; set; }
        public string SenhaAutorizacao { get; set; }
        public int? NumeroGuiaPrincipal { get; set; }
        public string BeneficiarioCarteira { get; set; }
        public string BeneficiarioNome { get; set; }
        public string BeneficiarioCns { get; set; }
        public DateTime? BeneficiarioValidadeCarteira { get; set; }
        public bool? BeneficiarioRn { get; set; }
        public string ExecutanteCodigoOperadora { get; set; }
        public string ExecutanteCnpj { get; set; }
        public string ExecutanteCpf { get; set; }
        public string ExecutanteNome { get; set; }
        public string ExecutanteCnes { get; set; }
        public int? LoteGuiaId { get; set; }
        public virtual ICollection<GuiaTissDespesa> GuiaTissDespesa { get; set; }
        public virtual GuiaTissHonorario GuiaTissHonorario { get; set; }
        public virtual GuiaTissInternacao GuiaTissInternacao { get; set; }
        public virtual GuiaTissSpsadt GuiaTissSpsadt { get; set; }
        public virtual LoteGuia LoteGuia { get; set; }
        public virtual ICollection<GuiaTissProcedimento> GuiaTissProcedimento { get; set; }
        public virtual ICollection<PacienteConta> PacienteConta { get; set; }
    }
}