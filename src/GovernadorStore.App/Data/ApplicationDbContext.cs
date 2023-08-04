using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GovernadorStore.App.ViewModels;

namespace GovernadorStore.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GovernadorStore.App.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; }
    }
}