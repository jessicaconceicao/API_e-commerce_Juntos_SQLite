using System.Collections.Generic;

namespace API_Juntos.Core.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Lote { get; set; }
        public string Validade { get; set; }
        public decimal QuantidadeEmbalagem { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; }

    }
}
