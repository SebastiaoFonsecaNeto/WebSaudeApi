using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("log")]
    public partial class Log
    {
        public int Id { get; set; }

        public int ProfissionalId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Data { get; set; }

        [Required]
        [StringLength(50)]
        public string Tabela { get; set; }

        [Required]
        [StringLength(10)]
        public string TipoManutencao { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DadosAnt { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DadosPost { get; set; }

        public int RegId { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}
