using Microsoft.EntityFrameworkCore;
using PageFilterSortApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Data.Context
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomerContext(DbContextOptions<CustomerContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Id).ValueGeneratedOnAdd(); //Identity
            modelBuilder.Entity<Customer>().Property(c => c.Firstname).HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Lastname).HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Age).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Gender).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.TotalOrderCount).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.MarriageStatus).IsRequired();
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id=1, Firstname="Semih", Lastname="Ilgaz", Age=26, Gender="Male", TotalOrderCount=28, MarriageStatus="Single"},
                new Customer() { Id = 2, Firstname = "Kerem", Lastname = "Erdogdu", Age = 19, Gender = "Male", TotalOrderCount = 58, MarriageStatus = "Single" },
                new Customer() { Id = 3, Firstname = "Ali", Lastname = "Cakir", Age = 43, Gender = "Male", TotalOrderCount = 12, MarriageStatus = "Married" },
                new Customer() { Id = 4, Firstname = "Ebru", Lastname = "Deniz", Age = 23, Gender = "Female", TotalOrderCount = 8, MarriageStatus = "Single" },
                new Customer() { Id = 5, Firstname = "Sinem", Lastname = "Yılmaz", Age = 34, Gender = "Female", TotalOrderCount = 41, MarriageStatus = "Married" },
                new Customer() { Id = 6, Firstname = "Ceyhan", Lastname = "Korkmaz", Age = 28, Gender = "Female", TotalOrderCount = 6, MarriageStatus = "Single" },
                new Customer() { Id = 7, Firstname = "Berkcan", Lastname = "Hasanoglu", Age = 47, Gender = "Male", TotalOrderCount = 126, MarriageStatus = "Single" },
                new Customer() { Id = 8, Firstname = "Onur", Lastname = "Aslan", Age = 19, Gender = "Male", TotalOrderCount = 17, MarriageStatus = "Single" },
                new Customer() { Id = 9, Firstname = "Suleyman", Lastname = "Demir", Age = 35, Gender = "Male", TotalOrderCount = 32, MarriageStatus = "Single" },
                new Customer() { Id = 10, Firstname = "Kaan", Lastname = "Avci", Age = 28, Gender = "Male", TotalOrderCount = 205, MarriageStatus = "Married" },
                new Customer() { Id = 11, Firstname = "Engin", Lastname = "Yurtgezer", Age = 58, Gender = "Male", TotalOrderCount = 41, MarriageStatus = "Single" },
                new Customer() { Id = 12, Firstname = "Selin", Lastname = "Uzuner", Age = 25, Gender = "Female", TotalOrderCount = 16, MarriageStatus = "Single" },
                new Customer() { Id = 13, Firstname = "Seyma", Lastname = "Sezengil", Age = 32, Gender = "Female", TotalOrderCount = 83, MarriageStatus = "Married" },
                new Customer() { Id = 14, Firstname = "Orhan", Lastname = "Sabuncu", Age = 33, Gender = "Male", TotalOrderCount = 41, MarriageStatus = "Single" }
            );
        }
    }
}
