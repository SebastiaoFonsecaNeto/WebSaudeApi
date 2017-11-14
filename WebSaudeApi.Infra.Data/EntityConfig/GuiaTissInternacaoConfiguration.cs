using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissInternacaoConfiguration : EntityTypeConfiguration<GuiaTissInternacao>
    {
        public GuiaTissInternacaoConfiguration()
        {
            ToTable("guia_tiss_internacao");

            HasKey(c => c.GuiaTissId);

            Property(c => c.GuiaTissId)
                .IsRequired()
                .HasColumnName("guia_tiss_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.DataAutorizacao)
                .HasColumnType("date")
                .HasColumnName("data_autorizacao");

            Property(c => c.DataValidadeSenha)
                .HasColumnType("date")
                .HasColumnName("data_validade_senha");

            Property(c => c.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao")
                .IsUnicode(false);

            Property(c => c.AnsCaraterAtendimentoId)
                .IsRequired()
                .HasColumnName("ans_carater_atendimento_id");

            Property(c => c.AnsTipoFaturamentoId)
                .IsRequired()
                .HasColumnName("ans_tipo_faturamento_id");

            Property(c => c.DataInicioFaturamento)
                .HasColumnType("date")
                .HasColumnName("data_inicio_faturamento");

            Property(c => c.HoraInicioFaturamento)
                .HasColumnName("hora_inicio_faturamento");

            Property(c => c.DataFinalFaturamento)
                .HasColumnType("date")
                .HasColumnName("data_final_faturamento");

            Property(c => c.HoraFinalFaturamento)
                .HasColumnName("hora_final_faturamento");

            Property(c => c.AnsTipoInternacaoId)
                .IsRequired()
                .HasColumnName("ans_tipo_internacao_id");

            Property(c => c.AnsRegimeInternacaoId)
                .IsRequired()
                .HasColumnName("ans_regime_internacao_id");

            Property(c => c.Cid1)
                .HasMaxLength(4)
                .HasColumnName("cid1")
                .IsUnicode(false);

            Property(c => c.Cid2)
                .HasMaxLength(4)
                .HasColumnName("cid2")
                .IsUnicode(false);

            Property(c => c.Cid3)
                .HasMaxLength(4)
                .HasColumnName("cid3")
                .IsUnicode(false);

            Property(c => c.Cid4)
                .HasMaxLength(4)
                .HasColumnName("cid4")
                .IsUnicode(false);

            Property(c => c.AnsIndicadorAcidenteId)
                .IsRequired()
                .HasColumnName("ans_indicador_acidente_id");

            Property(c => c.AnsMotivoEncerramentoId)
                .IsRequired()
                .HasColumnName("ans_motivo_encerramento_id");

            Property(c => c.DeclaracaoNascido)
                .HasMaxLength(11)
                .HasColumnName("declaracao_nascido")
                .IsUnicode(false);

            Property(c => c.CidObito)
                .HasMaxLength(4)
                .HasColumnName("cid_obito")
                .IsUnicode(false);

            Property(c => c.DeclaracaoObito)
                .HasMaxLength(11)
                .HasColumnName("declaracao_obito")
                .IsUnicode(false);

            Property(c => c.IndicadorObitoRn)
                .IsRequired()
                .HasColumnName("indicador_obito_rn");

            Property(c => c.ValorProcedimentos)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_procedimentos");

            Property(c => c.ValorTaxasAlugueis)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_taxas_alugueis");

            Property(c => c.ValorMateriais)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_materiais");

            Property(c => c.ValorMedicamentos)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_medicamentos");

            Property(c => c.ValorOpme)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_opme");

            Property(c => c.ValorGasesMedicinais)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_gases_medicinais");

            Property(c => c.ValorTotalGeral)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_total_geral");

            HasOptional(e => e.GuiaTiss)
                .WithRequired(e => e.GuiaTissInternacao);
        }
    }
}