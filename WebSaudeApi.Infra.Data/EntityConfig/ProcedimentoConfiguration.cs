using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProcedimentoConfiguration : EntityTypeConfiguration<Procedimento>
    {
        public ProcedimentoConfiguration()
        {
            ToTable("procedimento");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("codigo")
                .IsUnicode(false);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            Property(c => c.Tipo)
                .HasColumnName("tipo");

            HasMany(e => e.PacienteProcedimento)
                .WithRequired(e => e.Procedimento)
                .HasForeignKey(e => e.ProcedimentoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoConvenio)
                .WithRequired(e => e.Procedimento)
                .HasForeignKey(e => e.ProcedimentoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoMatmed)
                .WithRequired(e => e.Procedimento)
                .HasForeignKey(e => e.ProcedimentoId)
                .WillCascadeOnDelete(false);
        }
    }
}