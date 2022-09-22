namespace API_Juntos.Application.Models.Pedidos.ListarPedidoPorId
{
    public class ListarPedidoporIdProdutosDetalhadosResponse
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal totalParcial { get; set; }

    }
}
