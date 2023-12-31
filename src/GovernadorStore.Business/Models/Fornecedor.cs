﻿
namespace GovernadorStore.Business.Models
{
    public class Fornecedor : Entity
    {
        public string RazaoSocial { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relation */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
