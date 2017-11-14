using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProfissionalPagamentoConfiguration : EntityTypeConfiguration<ProfissionalPagamento>
    {
        public ProfissionalPagamentoConfiguration()
        {
            ToTable("profissional_pagamento");

            HasKey(c => c.ProfissionalId);

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.PagamentoId)
                .IsRequired()
                .HasColumnName("pagamento_id");

            Property(c => c.ReciboId)
                .IsRequired()
                .HasColumnName("recibo_id");

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            HasOptional(e => e.Profissional)
                .WithRequired(e => e.ProfissionalPagamento);
        }
    }
}