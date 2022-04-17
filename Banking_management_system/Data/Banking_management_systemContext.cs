using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Banking_management_system.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Banking_management_system.Data
{
    public class Banking_management_systemContext : IdentityDbContext<IdentityUser>
    {
        public Banking_management_systemContext (DbContextOptions<Banking_management_systemContext> options)
            : base(options)
        {
        }

        public DbSet<Banking_management_system.Models.Admin> Admin { get; set; }

        public DbSet<Banking_management_system.Models.Balance> Balance { get; set; }

        public DbSet<Banking_management_system.Models.Bank> Bank { get; set; }

        public DbSet<Banking_management_system.Models.Client> Client { get; set; }

        public DbSet<Banking_management_system.Models.Company> Company { get; set; }

        public DbSet<Banking_management_system.Models.Credit> Credit { get; set; }

        public DbSet<Banking_management_system.Models.Deposit> Deposit { get; set; }

        public DbSet<Banking_management_system.Models.Installment> Installment { get; set; }

        public DbSet<Banking_management_system.Models.Manager> Manager { get; set; }

        public DbSet<Banking_management_system.Models.Operator> Operator { get; set; }

        public DbSet<Banking_management_system.Models.Salary> Salary { get; set; }

        public DbSet<Banking_management_system.Models.Specialist> Specialist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Balance>().ToTable("Balance");
            modelBuilder.Entity<Bank>().ToTable("Bank");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<Deposit>().ToTable("Deposit");
            modelBuilder.Entity<Installment>().ToTable("Installment");
            modelBuilder.Entity<Manager>().ToTable("Manager");
            modelBuilder.Entity<Operator>().ToTable("Operator");
            modelBuilder.Entity<Salary>().ToTable("Salary");
            modelBuilder.Entity<Specialist>().ToTable("Specialist");
        }
    }
    
}
