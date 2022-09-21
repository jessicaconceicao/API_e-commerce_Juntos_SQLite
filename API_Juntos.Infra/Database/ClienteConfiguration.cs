using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Juntos.Infra.Database
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");
            builder.HasKey(pk => pk.IdCliente);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(p => p.CPF)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(P => P.Email)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
            builder.Property(p => p.Telefone)
                .HasColumnType("VARCHAR(15)");
            builder.Property(p => p.Endereco)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
        }
    }
}
