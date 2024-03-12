using Microsoft.EntityFrameworkCore;
using Funcionarios.API.Models;

namespace Funcionarios.API.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
