using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class NotaFiscal
    {
        public NotaFiscal()
        {
            NotaFiscalItem = new HashSet<NotaFiscalItem>();
        }

        public int Id { get; set; }

        public int UnidadeId { get; set; }

        public int FornecedorId { get; set; }

        [StringLength(25)]
        public string Numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataEntrada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataEmissao { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        
        public virtual ICollection<NotaFiscalItem> NotaFiscalItem { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
