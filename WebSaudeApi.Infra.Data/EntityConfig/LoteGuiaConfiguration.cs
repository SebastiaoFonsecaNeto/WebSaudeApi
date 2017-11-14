using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class LoteGuiaConfiguration : EntityTypeConfiguration<LoteGuia>
    {
        public LoteGuiaConfiguration()
        {
            ToTable("lote_guia");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.TipoLote)
                .HasColumnName("tipo_lote");

            Property(c => c.DataInclusao)
                .HasColumnType("date")
                .HasColumnName("data_inclusao");

            Property(c => c.Situacao)
                .HasColumnName("situacao");

            Property(c => c.DataUltimoEnvio)
                .HasColumnType("date")
                .HasColumnName("data_ultimo_envio");

            Property(c => c.ProtocoloRecebimento)
                .HasMaxLength(300)
                .HasColumnName("protocolo_recebimento")
                .IsUnicode(false);

            HasMany(e => e.GuiaTiss)
                .WithOptional(e => e.LoteGuia)
                .HasForeignKey(e => e.LoteGuiaId);
        }
    }
}