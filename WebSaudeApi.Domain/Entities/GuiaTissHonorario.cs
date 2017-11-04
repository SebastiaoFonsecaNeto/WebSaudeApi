using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class GuiaTissHonorario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuiaTissId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataEmissao { get; set; }

        [StringLength(500)]
        public string Observacao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValorTotal { get; set; }

        [StringLength(14)]
        public string LocalCodigoOperadora { get; set; }

        [StringLength(14)]
        public string LocalCnpj { get; set; }

        [StringLength(70)]
        public string LocalNome { get; set; }

        [StringLength(7)]
        public string LocalCnes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataInicioFaturamento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataFinalFaturamento { get; set; }

        public virtual GuiaTiss GuiaTiss { get; set; }
    }
}
