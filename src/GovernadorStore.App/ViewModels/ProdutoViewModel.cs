using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GovernadorStore.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [StringLength (200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Categoria { get; set; }

        public IFormFile ImagemUpload { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Decimal ValorVenda { get; set; }

        [ScaffoldColumn(false)]
        public string QuantidadeEstoque { get; set; }

        [DisplayName("Ativo?")]
        public string Ativo { get; set; }

        /*EF Relation*/

        public FornecedorViewModel Fornecedor { get; set; }
    }
}
