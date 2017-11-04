using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("tuss")]
    public partial class Tuss
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TabelaReferencia { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string Descricao { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string DescrocaoDetalhada { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(60)]
        public string ReferenciaFabricante { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string Fabricante { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(25)]
        public string RegistroAnvisa { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(5)]
        public string ClasseRisco { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(250)]
        public string Apresentacao { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(250)]
        public string Laboratorio { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChAmb92 { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrasindiceSp { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrasindicePr { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrasindiceRj { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrasindiceMg { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrasindiceRs { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(10)]
        public string BrasindiceTiss { get; set; }
    }
}
