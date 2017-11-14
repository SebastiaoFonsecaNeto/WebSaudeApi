using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class TussConfiguration : EntityTypeConfiguration<Tuss>
    {
        public TussConfiguration()
        {
            ToTable("tuss");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.TabelaReferencia)
                .IsRequired()
                .HasColumnName("tabela_referencia");

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("codigo");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("descricao");

            Property(c => c.DescrocaoDetalhada)
                .HasMaxLength(500)
                .HasColumnName("descricao_detalhada");

            Property(c => c.ReferenciaFabricante)
                .HasMaxLength(60)
                .HasColumnName("referencia_fabricante")
                .IsUnicode(false);

            Property(c => c.Fabricante)
                .HasMaxLength(200)
                .HasColumnName("fabricante")
                .IsUnicode(false);

            Property(c => c.RegistroAnvisa)
                .HasMaxLength(25)
                .HasColumnName("registro_anvisa")
                .IsUnicode(false);

            Property(c => c.ClasseRisco)
                .HasMaxLength(5)
                .HasColumnName("classe_risco")
                .IsUnicode(false);

            Property(c => c.Apresentacao)
                .HasMaxLength(250)
                .HasColumnName("apresentacao")
                .IsUnicode(false);

            Property(c => c.Laboratorio)
                .HasMaxLength(250)
                .HasColumnName("laboratorio")
                .IsUnicode(false);
        }
    }
}