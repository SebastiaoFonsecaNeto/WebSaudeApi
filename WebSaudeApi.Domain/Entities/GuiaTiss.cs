using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTiss
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

        [StringLength(100)]
        public string SenhaAutorizacao { get; set; }

        public int? NumeroGuiaPrincipal { get; set; }

        [StringLength(20)]
        public string BeneficiarioCarteira { get; set; }

        [StringLength(70)]
        public string BeneficiarioNome { get; set; }

        [StringLength(15)]
        public string BeneficiarioCns { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BeneficiarioValidadeCarteira { get; set; }

        public bool? BeneficiarioRn { get; set; }

        [StringLength(14)]
        public string ExecutanteCodigoOperadora { get; set; }

        [StringLength(14)]
        public string ExecutanteCnpj { get; set; }

        [StringLength(11)]
        public string ExecutanteCpf { get; set; }

        [StringLength(70)]
        public string ExecutanteNome { get; set; }

        [StringLength(7)]
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
