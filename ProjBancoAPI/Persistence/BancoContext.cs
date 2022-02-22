using Microsoft.EntityFrameworkCore;
using ProjBancoAPI.Models;

namespace ProjBancoAPI.Persistence
{
    public class BancoContext : DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }

        public DbSet<Extrato> Extratos { get; set; }

        public DbSet<Lancamento> Lancamentos { get; set; }
        
        public BancoContext(DbContextOptions<BancoContext> opt) : base(opt) { }

        

    }
}
