namespace WebSaude.Domain.Entities
{
    public partial class Tuss
    {
        public int Id { get; set; }
        public int TabelaReferencia { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string DescrocaoDetalhada { get; set; }
        public string ReferenciaFabricante { get; set; }
        public string Fabricante { get; set; }
        public string RegistroAnvisa { get; set; }
        public string ClasseRisco { get; set; }
        public string Apresentacao { get; set; }
        public string Laboratorio { get; set; }
    }
}