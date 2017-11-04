using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AgendaConfiguration : EntityTypeConfiguration<Agenda>
    {
        public AgendaConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");
        }
    }
}