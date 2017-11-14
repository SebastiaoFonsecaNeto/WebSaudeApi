using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            NotaFiscal = new HashSet<NotaFiscal>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<NotaFiscal> NotaFiscal { get; set; }
    }
}