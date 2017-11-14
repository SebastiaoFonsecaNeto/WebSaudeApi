using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class LoteGuia
    {
        public LoteGuia()
        {
            GuiaTiss = new HashSet<GuiaTiss>();
        }

        public int Id { get; set; }
        public int? TipoLote { get; set; }
        public DateTime? DataInclusao { get; set; }
        public int? Situacao { get; set; }
        public DateTime? DataUltimoEnvio { get; set; }
        public string ProtocoloRecebimento { get; set; }
        public virtual ICollection<GuiaTiss> GuiaTiss { get; set; }
    }
}