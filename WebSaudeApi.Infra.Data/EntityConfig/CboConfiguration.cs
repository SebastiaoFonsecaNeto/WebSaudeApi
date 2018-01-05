using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class CboConfiguration : EntityTypeConfiguration<Cbo>
    {
        public CboConfiguration()
        {
            ToTable("cbo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("codigo")
                .IsUnicode(false);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(e => e.DiasLimiteAtendimento)
                .HasColumnName("dias_limite_atendimento");

            Property(e => e.DiasLimiteRetorno)
                .HasColumnName("dias_limite_retorno");

            Property(e => e.Clinico)
                .HasColumnName("clinico");
        }
    }
}