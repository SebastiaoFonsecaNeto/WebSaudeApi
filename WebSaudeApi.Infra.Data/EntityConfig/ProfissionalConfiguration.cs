using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProfissionalConfiguration : EntityTypeConfiguration<Profissional>
    {
        public ProfissionalConfiguration()
        {
            ToTable("profissional");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.CboId)
                .IsRequired()
                .HasColumnName("cbo_id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("nome");

            Property(c => c.Documento)
                .HasMaxLength(14)
                .HasColumnName("documento")
                .IsUnicode(false);

            Property(c => c.Telefone)
                .HasMaxLength(10)
                .HasColumnName("telefone")
                .IsUnicode(false);

            Property(c => c.Celular)
                .HasMaxLength(11)
                .HasColumnName("celular")
                .IsUnicode(false);

            Property(c => c.CelularOperadoraId)
                .HasColumnName("celular_operadora_id");

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("email")
                .IsUnicode(false);

            Property(c => c.Endereco)
                .HasMaxLength(200)
                .HasColumnName("endereco")
                .IsUnicode(false);

            Property(c => c.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero")
                .IsUnicode(false);

            Property(c => c.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento")
                .IsUnicode(false);

            Property(c => c.Bairro)
                .HasMaxLength(100)
                .HasColumnName("bairro")
                .IsUnicode(false);

            Property(c => c.Cidade)
                .HasMaxLength(150)
                .HasColumnName("cidade")
                .IsUnicode(false);

            Property(c => c.Estado)
                .HasMaxLength(2)
                .HasColumnName("estado")
                .IsUnicode(false);

            Property(c => c.Cep)
                .HasMaxLength(8)
                .HasColumnName("cep")
                .IsUnicode(false);

            Property(c => c.Ativo)
                .HasColumnName("ativo");

            Property(c => c.Observacao)
                .HasMaxLength(250)
                .HasColumnName("observacao")
                .IsUnicode(false);

            HasMany(e => e.Agenda)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Encaminhamento)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Log)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProfissionalUnidade)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntoAtendimento)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntuarioClinico)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.ProfissionalId)
                .WillCascadeOnDelete(false);
        }
    }
}