
namespace GovernadorStore.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Imagem { get; set; }
        public Decimal ValorVenda { get; set; }
        public string QuantidadeEstoque { get; set; }
        public bool Ativo { get; set; }

        /*EF Relation*/

        public Fornecedor Fornecedor { get; set; }
    }
}
