using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProcedimentoCboConvenioConfiguration : EntityTypeConfiguration<ProcedimentoCboConvenio>
    {
        public ProcedimentoCboConvenioConfiguration()
        {
            ToTable("procedimento_cbo_convenio");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ConvenioId)
                .IsRequired()
                .HasColumnName("convenio_id");

            Property(c => c.CboId)
                .IsRequired()
                .HasColumnName("cbo_id");

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("codigo")
                .IsUnicode(false);

            HasRequired(e => e.Cbo)
                .WithMany()
                .HasForeignKey(e => e.CboId)
                .WillCascadeOnDelete(false);
        }
    }
}