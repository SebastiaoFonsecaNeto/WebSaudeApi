using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProcedimentoConvenioConfiguration : EntityTypeConfiguration<ProcedimentoConvenio>
    {
        public ProcedimentoConvenioConfiguration()
        {
            ToTable("procedimento_convenio");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ProcedimentoId)
                .IsRequired()
                .HasColumnName("procedimento_id");

            Property(c => c.ConvenioId)
                .IsRequired()
                .HasColumnName("convenio_id");

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");
        }
    }
}