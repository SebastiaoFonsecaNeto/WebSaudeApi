using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class UnidadeConfiguration : EntityTypeConfiguration<Unidade>
    {
        public UnidadeConfiguration()
        {
            ToTable("paciente");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao");

            Property(c => c.Telefone)
                .HasMaxLength(10)
                .HasColumnName("telefone")
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

            HasMany(e => e.Agenda)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.AgendaAparelho)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.EstoqueKardex)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.EstoqueProduto)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.NotaFiscal)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteProntuarioUnidade)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProfissionalUnidade)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntoAtendimento)
                .WithOptional(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId);

            HasMany(e => e.ProntuarioClinico)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadeId)
                .WillCascadeOnDelete(false);
        }
    }
}