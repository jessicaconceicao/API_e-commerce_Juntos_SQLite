namespace API_Juntos.Application.Models.Produtos.ListarProdutos
{
    public class ListarProdutosResponse
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Lote { get; set; }
        public string Validade { get; set; }
        public decimal QuantidadeEmbalagem { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Valor { get; set; }
        public decimal QuantidadeEstoque { get; set; }
    }
}
