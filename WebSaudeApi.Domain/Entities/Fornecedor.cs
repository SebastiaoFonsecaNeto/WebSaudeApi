using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("fornecedor")]
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            NotaFiscal = new HashSet<NotaFiscal>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(14)]
        public string Documento { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public bool Ativo { get; set; }
        
        public virtual ICollection<NotaFiscal> NotaFiscal { get; set; }
    }
}
