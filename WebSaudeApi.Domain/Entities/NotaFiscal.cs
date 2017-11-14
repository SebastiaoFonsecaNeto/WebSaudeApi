using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class NotaFiscal
    {
        public NotaFiscal()
        {
            NotaFiscalItem = new HashSet<NotaFiscalItem>();
        }

        public int Id { get; set; }
        public int UnidadeId { get; set; }
        public int FornecedorId { get; set; }
        public string Numero { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataEmissao { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<NotaFiscalItem> NotaFiscalItem { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}