using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissProfissionalConfiguration : EntityTypeConfiguration<GuiaTissProfissional>
    {
        public GuiaTissProfissionalConfiguration()
        {
            ToTable("guia_tiss_profissional");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.GuiaTissProcedimentoId)
                .IsRequired()
                .HasColumnName("guia_tiss_procedimento_id");

            Property(c => c.Equipe)
                .HasColumnName("equipe");

            Property(c => c.AnsGrauParticipacaoId)
                .IsRequired()
                .HasColumnName("ans_grau_participacao_id");

            Property(c => c.CodigoIdentificacao)
                .HasMaxLength(14)
                .HasColumnName("codigo_identificacao")
                .IsUnicode(false);

            Property(c => c.Nome)
                .HasMaxLength(70)
                .HasColumnName("nome")
                .IsUnicode(false);

            Property(c => c.AnsConselhoId)
                .IsRequired()
                .HasColumnName("ans_conselho_id");

            Property(c => c.NumeroConselho)
                .HasMaxLength(15)
                .HasColumnName("numero_conselho")
                .IsUnicode(false);

            Property(c => c.AnsUfId)
                .IsRequired()
                .HasColumnName("ans_uf_id");

            Property(c => c.Cbo)
                .HasMaxLength(6)
                .HasColumnName("cbo")
                .IsUnicode(false);
        }
    }
}