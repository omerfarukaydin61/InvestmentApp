using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace InvestmentApp.Entities.EntityData
{
    public partial class InvestmentDbContext : DbContext
    {
        public InvestmentDbContext()
            : base("name=InvestmentDbContext1")
        {
        }

        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<UserInvestment> UserInvestments { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.BankAccounts)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.UserTable)
                .HasForeignKey(e => e.EffecterID);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.UserInvestments)
                .WithOptional(e => e.UserTable)
                .HasForeignKey(e => e.EffecterID);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.UserInvestments1)
                .WithOptional(e => e.UserTable1)
                .HasForeignKey(e => e.AffectedID);
        }
    }
}
