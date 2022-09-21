using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Juntos.Infra.Database
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");
            builder.HasKey(pk => pk.IdProduto);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();
            builder.Property(p => p.Lote)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(P => P.Validade)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(p => p.QuantidadeEmbalagem)
                .HasColumnType("DECIMAL(10,2)");
            builder.Property(p => p.UnidadeMedida)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(p => p.Valor)
                .HasColumnType("DECIMAL(10,2)")
                .IsRequired();
            builder.Property(p => p.QuantidadeEstoque)
                .IsRequired();
        }
    }
}
