using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class WebControle
    {
        public int Id { get; set; }

        public int Ip { get; set; }

        public int QuantidadeMinuto { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Ultimo { get; set; }
    }
}
