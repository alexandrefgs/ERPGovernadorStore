using GovernadorStore.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GovernadorStore.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            //Mapeando as propriedades para gerar os campos no banco
            //Configurando a chave primaria, garantindo que o EF vá setar o Id como chave primária
            builder.HasKey(p => p.Id);

            builder.Property(p => p.RazaoSocial)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Fazendo a configuração 1:1 informando que cada fornecedor tem 1 endereço
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);

            //Fazendo o relacionamento de 1:N informando que cada fornecedor tem N produtos
            builder.HasMany(f => f.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }
}
