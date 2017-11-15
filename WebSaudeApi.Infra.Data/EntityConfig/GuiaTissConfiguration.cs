using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissConfiguration : EntityTypeConfiguration<GuiaTiss>
    {
        public GuiaTissConfiguration()
        {
            ToTable("guia_tiss");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.NumeroRegistroAns)
                .HasColumnName("numero_registro_ans");

            Property(c => c.NumeroGuiaPrestador)
                .HasColumnName("numero_guia_prestador");

            Property(c => c.SenhaAutorizacao)
                .HasMaxLength(100)
                .HasColumnName("senha_autorizacao")
                .IsUnicode(false);

            Property(c => c.NumeroGuiaPrincipal)
                .HasColumnName("numero_guia_principal");

            Property(c => c.BeneficiarioCarteira)
                .HasMaxLength(20)
                .HasColumnName("beneficiario_carteira")
                .IsUnicode(false);

            Property(c => c.BeneficiarioNome)
                .HasMaxLength(70)
                .HasColumnName("beneficiario_nome")
                .IsUnicode(false);

            Property(c => c.BeneficiarioCns)
                .HasMaxLength(15)
                .HasColumnName("beneficiario_cns")
                .IsUnicode(false);

            Property(c => c.BeneficiarioValidadeCarteira)
                .HasColumnType("date")
                .HasColumnName("beneficiario_validade_carteira");

            Property(c => c.BeneficiarioRn)
                .HasColumnName("beneficiario_rn");

            Property(c => c.ExecutanteCodigoOperadora)
                .HasMaxLength(14)
                .HasColumnName("executante_codigo_operadora")
                .IsUnicode(false);

            Property(c => c.ExecutanteCnpj)
                .HasMaxLength(14)
                .HasColumnName("executante_cnpj")
                .IsUnicode(false);

            Property(c => c.ExecutanteCpf)
                .HasMaxLength(11)
                .HasColumnName("executante_cpf")
                .IsUnicode(false);

            Property(c => c.ExecutanteNome)
                .HasMaxLength(70)
                .HasColumnName("executante_nome")
                .IsUnicode(false);

            Property(c => c.ExecutanteCnes)
                .HasMaxLength(7)
                .HasColumnName("executante_cnes")
                .IsUnicode(false);

            Property(c => c.LoteGuiaId)
                .HasColumnName("lote_guia_id");

            HasMany(e => e.GuiaTissDespesa)
                .WithRequired(e => e.GuiaTiss)
                .HasForeignKey(e => e.GuiaTissId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.GuiaTissProcedimento)
                .WithRequired(e => e.GuiaTiss)
                .HasForeignKey(e => e.GuiaTissId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteConta)
                .WithOptional(e => e.GuiaTiss)
                .HasForeignKey(e => e.GuiaTissId);
        }
    }
}