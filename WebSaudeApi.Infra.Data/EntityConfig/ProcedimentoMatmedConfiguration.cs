using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProcedimentoMatmedConfiguration : EntityTypeConfiguration<ProcedimentoMatmed>
    {
        public ProcedimentoMatmedConfiguration()
        {
            ToTable("procedimento_matmed");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ProcedimentoId)
                .IsRequired()
                .HasColumnName("procedimento_id");

            Property(c => c.EstoqueId)
                .IsRequired()
                .HasColumnName("estoque_id");

            Property(c => c.Quantidade)
                .IsRequired()
                .HasColumnName("quantidade");

            Property(c => c.CodigoTuss)
                .HasMaxLength(8)
                .HasColumnName("codigo_tuss")
                .IsUnicode(false);
        }
    }
}