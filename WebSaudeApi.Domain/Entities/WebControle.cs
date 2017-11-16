using System;

namespace WebSaude.Domain.Entities
{
    public class WebControle
    {
        public int Id { get; set; }
        public int Ip { get; set; }
        public int QuantidadeMinuto { get; set; }
        public DateTime Ultimo { get; set; }
    }
}