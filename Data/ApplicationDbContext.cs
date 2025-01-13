using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<LoansModel> Loans { get; set; }
    }
}
