using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Database
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");
            builder.HasKey(pk => pk.IdPedido);
            builder.Property(p => p.ValorPedido)
                .HasColumnType("DECIMAL(11,2)")
                .IsRequired();
            builder.Property(p => p.DataPedido)
                .HasColumnType("DATETIME")
                .IsRequired();
            builder.HasOne(fk => fk.Cliente)
                .WithMany(fk => fk.Pedidos)
                .HasForeignKey(fk => fk.IdCliente);
        }
    }
}
