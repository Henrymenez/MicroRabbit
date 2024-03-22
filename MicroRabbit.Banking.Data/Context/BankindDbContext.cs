using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankindDbContext : DbContext
    {
        public BankindDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
