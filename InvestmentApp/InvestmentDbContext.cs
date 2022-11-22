using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InvestmentApp
{
    public partial class InvestmentDbContext : DbContext
    {
        public InvestmentDbContext()
            : base("name=InvestmentDbContext")
        {
        }

        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserInvestment> UserInvestments { get; set; }
        public virtual DbSet<UserModel> UserModels { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.UserTable)
                .HasForeignKey(e => e.EffecterID);
        }
    }
}
