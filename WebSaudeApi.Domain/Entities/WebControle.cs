using System;

namespace WebSaude.Domain.Entities
{
    public partial class WebControle
    {
        public int Id { get; set; }
        public int Ip { get; set; }
        public int QuantidadeMinuto { get; set; }
        public byte[] Ultimo { get; set; }
    }
}