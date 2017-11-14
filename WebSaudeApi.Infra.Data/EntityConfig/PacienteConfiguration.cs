using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            ToTable("paciente");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("nome");

            Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("data_nascimento");

            Property(c => c.Sexo)
                .IsRequired()
                .HasColumnName("sexo");

            Property(c => c.Cpf)
                .HasMaxLength(11)
                .HasColumnName("cpf")
                .IsUnicode(false);

            Property(c => c.Cns)
                .HasMaxLength(15)
                .HasColumnName("cns")
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

            Property(c => c.Dependente)
                .HasColumnName("dependente");

            Property(c => c.Responsavel)
                .HasMaxLength(200)
                .HasColumnName("responsavel")
                .IsUnicode(false);

            HasMany(e => e.Agenda)
                .WithOptional(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId);

            HasMany(e => e.AgendaAparelho)
                .WithOptional(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId);

            HasMany(e => e.Encaminhamento)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Odontograma)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteConta)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteConvenio)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteImagem)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteMatmed)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteProcedimento)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteProntuarioUnidade)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntoAtendimento)
                .WithOptional(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId);

            HasMany(e => e.ProntuarioClinico)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacienteId)
                .WillCascadeOnDelete(false);
        }
    }
}