using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PlanoContasConfiguration : EntityTypeConfiguration<PlanoContas>
    {
        public PlanoContasConfiguration()
        {
            ToTable("plano_contas");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ContaCategoriaId)
                .IsRequired()
                .HasColumnName("conta_categoria_id");

            Property(c => c.PacienteContaId)
                .HasColumnName("paciente_conta_id");

            Property(c => c.ContaTipoId)
                .IsRequired()
                .HasColumnName("conta_tipo_id");

            Property(c => c.ContaId)
                .IsRequired()
                .HasColumnName("conta_id");

            Property(c => c.Data)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("data");

            Property(c => c.Descricao)
                .HasMaxLength(250)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");
        }
    }
}