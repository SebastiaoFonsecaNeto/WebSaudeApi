using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class WebControleConfiguration : EntityTypeConfiguration<WebControle>
    {
        public WebControleConfiguration()
        {
            ToTable("web_controle");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Ultimo)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("ultimo");

            Property(c => c.Ip)
                .HasColumnName("ip");

            Property(c => c.QuantidadeMinuto)
                .HasColumnName("quantidade_minuto");
        }
    }
}