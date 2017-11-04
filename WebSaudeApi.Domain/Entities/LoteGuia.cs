using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class LoteGuia
    {
        public LoteGuia()
        {
            GuiaTiss = new HashSet<GuiaTiss>();
        }

        public int Id { get; set; }

        public int? CodTipoLote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatInclusao { get; set; }

        public int? CodSituacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatUltimoEnvio { get; set; }

        [StringLength(300)]
        public string NumProtocoloRecebimento { get; set; }
        
        public virtual ICollection<GuiaTiss> GuiaTiss { get; set; }
    }
}
