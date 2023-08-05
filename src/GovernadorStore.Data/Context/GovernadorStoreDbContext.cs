using GovernadorStore.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace GovernadorStore.Data.Context
{
    public class GovernadorStoreDbContext: DbContext
    {
        public GovernadorStoreDbContext(DbContextOptions options) : base(options) 
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        //Mapeando as entidades
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        //Configuração para registrar todas as entidades no banco de dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Setando um tamanho padrão para caso for esquecido de setar um tamanho
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GovernadorStoreDbContext).Assembly);

            //desativando o deletecascade
            //com essa opção ativa, sempre que deletar um fornecedor, os produtos dele vão ser deletados também
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
