namespace WebSaude.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int CpfCnpj { get; set; }
        public int Telefone { get; set; }        
    }
}
