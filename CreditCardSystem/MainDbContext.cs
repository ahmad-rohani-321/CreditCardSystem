using CreditCardSystem.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardSystem
{
    internal class MainDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqliteConnectionStringBuilder connectionString = new();
            //connectionString.DataSource = @"CardSawaneh.db";
            connectionString.DataSource = Defaults.DatabasePath;
            connectionString.Password = "Secret@123Ahmad.Rohani";
            optionsBuilder.UseSqlite(new SqliteConnection(connectionString.ConnectionString))
                .ConfigureWarnings(w =>  w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning)
        );
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Percentage> Percentages { get; set; }
        public DbSet<Ledger> Ledger { get; set; }
    }
}
